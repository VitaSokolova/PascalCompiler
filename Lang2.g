grammar Lang2;

options{
	language=CSharp2;
	output=AST;
}



tokens{
	PROGRAM = 'program';
	WHILE ='while';
	DO = 'do';
	FOR = 'for';
	FUNCTION = 'function';
	PROCEDURE = 'procedure';
	BEGIN = 'begin';
	END = 'end';
	THEN = 'then';
	ELSE = 'else';
	DIV	= 'div';
	MOD	= 'mod';
	NOT	= 'not';
	TO = 'to';
	VAR = 'var';
	T_CHAR = 'char';
	T_BOOL = 'boolean';
	T_INT = 'integer';
	IF='if';
	BOOL;
	CHAR;
	INT;
	FALSE = 'false';
	TRUE = 'true';
	VAR_DECL;
	BODY_EXPR;
	VAR_EXPR;
	FUNC_PROC_EXPR;
	PROC_DECL;
	FUNC_DECL;
	FUNC_CALL;
	FUNC_CALL_ARGS;
	FUNC_PROC_ARGS;
	FUNC_PROC_RET_TYPE;
	TYPE_DECL;
	BOOL_MULT ='AND';
	BOOL_ADD = 'OR';
	CONDITION;
}

@header{
	using System;
}

@lexer::namespace{Lang2}
@parser::namespace{Lang2}


OP_END	:	';'
	;

WS:
  ( ' ' | '\t' |  '\f' | '\r' | '\n' )+ {
    $channel=Hidden;
  }
;
 VARIABLE	:	('a'..'z'|'A'..'Z')+;

//----------------DATA TYPES------------------------//

CHAR	:	'\''! ('a'..'z'|'A'..'Z'|'0'..'9') '\''!
	;	
INT		:	('0'..'9')+
	;

//----------------OPERATIONS------------------------//
ADD		:	'+'
	;
REM		:	'-'
	;
MULT	:	'*'
	;
DIVIDE	:	'/'
	;
ASSIGN		:	':='
	;
GREATER		: '>'
	;
LESS	:	'<'
		 ;
EQUAL	:	'='
	;
LESS_OR_EQUAL		:	'<='
		 ;
GREATER_OR_EQUAL		:	'>='
	;


//----------------Boolean Operations-----------------------//
			
boolOperator: MORE|LESS|EQUAL|LESS_OR_EQUAL|GREATER_OR_EQUAL
			;

//-----------------Math	Operations------------------------//
mathGroup	:	'('!mathExpr+')'!
			|INT
			|VAR
			|CHAR
			|FALSE | TRUE
			|funcCall
		;


boolMult	:	mathGroup(BOOL_MULT^ mathGroup)*
			;

boolAdd	:	boolMult(BOOL_ADD^ boolMult)*
		;

boolElse	:	boolAdd(boolOperator^ boolAdd)*
			;

boolNegative : boolElse (NOT^ boolElse)*
			;

useDiv	: boolNegative((DIV|MOD)^ '('! boolNegative ')'! )*
		;

mathMult	
	:	useDiv((MULT|DIVIDE)^useDiv)*
	;
	
mathAdd	:	mathMult((ADD|REM)^mathMult)*
	;
	
mathExpr
	:	mathAdd
	;	
	
//---------------------------------------------------//

bodyOper	:	expressions
				|assExpr OP_END!
				|conditionExpr
				|loopExpr
				;

expressions	:	mathExpr 
				;
funcCallArgs	:	 VARIABLE(',' VARIABLE)* 
				;
funcCallArgsW	:	funcCallArgs -> ^(FUNC_CALL_ARGS funcCallArgs)
				;

funcCall	:	VARIABLE '('! funcCallArgsW? ')'! OP_END -> ^(FUNC_CALL VARIABLE funcCallArgsW? )
			;

argDeclExpr	:	'('! argDeclMany')'! -> ^(FUNC_PROC_ARGS argDeclMany)
			;

retTypeExpr	:	(T_INT|T_BOOL|T_CHAR)
			;

retTypeExprWrap	:	retTypeExpr -> ^(FUNC_PROC_RET_TYPE retTypeExpr)
				;

funcDeclare: FUNCTION VARIABLE argDeclExpr':' retTypeExprWrap OP_END!  bodyExpr -> ^(FUNC_DECL argDeclExpr retTypeExprWrap bodyExpr)
			;

procedureDeclare: PROCEDURE VARIABLE argDeclExpr OP_END bodyExpr -> ^(PROC_DECL VARIABLE argDeclExpr bodyExpr)
				;

//-------------------------------IF--------------------------------//

conditionElseExpr	:	ELSE! bodyExpr -> ^(ELSE bodyExpr)
					;
condExpr	:	'('! mathExpr ')'! -> ^(CONDITION mathExpr)
			;
conditionExpr:	IF condExpr THEN! bodyExpr conditionElseExpr? -> ^(IF condExpr bodyExpr conditionElseExpr?)
	;

//---------------------------------------------------------------//
forExpr	:	 assExpr TO^ expressions
		;
loopExpr:	WHILE condExpr DO! bodyExpr -> ^(WHILE condExpr bodyExpr)
			|FOR forExpr DO bodyExpr -> ^(FOR forExpr bodyExpr)
		;	

assExpr	:	 VARIABLE ASSIGN^ expressions
	;

argTypeDecl	:	typeDecl -> ^(TYPE_DECL typeDecl)
			;

argDecl	:	VAR? VARIABLE(','! VARIABLE)* ':'! argTypeDecl
		;

argDeclManyW	:	argDecl(','! argDecl)*
			;
argDeclMany	:	argDeclManyW -> ^(VAR_DECL argDeclManyW)
			;
typeDecl	:	T_INT|T_CHAR|T_BOOL;

//----------------VAR Operations-----------------------//
varTypeDecl	:	typeDecl OP_END -> ^(TYPE_DECL typeDecl)
			;


varDecl2	: VARIABLE(','! VARIABLE)*;

varDecl	:	varDecl2
		;
varDecl12W	:	varDecl ':'! varTypeDecl 
			;
varDeclW	:	VAR varDecl12W+ -> ^(VAR_DECL varDecl12W+ )
			;

//----------------------------------------------------//

bodyExpr	:	BEGIN! bodyOper+ END! OP_END! -> ^(BODY_EXPR bodyOper+)
			;

func_proc_expr	: funcDeclare|procedureDeclare ;

fpExprW	:	func_proc_expr* -> ^(FUNC_PROC_EXPR func_proc_expr*);

expr	:	 PROGRAM VARIABLE OP_END! varDeclW? fpExprW bodyExpr -> ^(PROGRAM VARIABLE varDeclW? fpExprW bodyExpr)
	;
	
program: expr+  ;
result: program EOF -> ^(PROGRAM program);
public execute:  result;