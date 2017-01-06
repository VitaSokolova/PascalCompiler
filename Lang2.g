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
	NOT	= 'NOT';
	TO = 'to';
	VAR = 'var';
	T_CHAR = 'char';
	T_BOOL = 'boolean';
	T_INT = 'integer';
	T_STRING = 'string';
	IF='if';
	BOOLEAN;
	CHAR;
	INT;
	STRING;
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
	ARRAY = 'array';
	OF='of';
	ARR_DECL;
	RANGE;
	ARR_CALL;
	MAIN_BODY;
	VOID = 'void';
	REPEAT = 'repeat';
	UNTIL = 'until';
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

CHAR	:	'\'' ( options {greedy=false;} : . ) '\''
	;	
INT		:	'-'?('0'..'9')+
	;
STRING	:	 '"'! ( options {greedy=false;} : . )* '"'!
		;

BOOLEAN	:	TRUE|FALSE
		;

//----------------ARRAY TYPE------------------------//
arrayRange :	'['expressions '..' expressions']' -> ^(RANGE expressions expressions)
			;
arrayTypeDecl	:	OF typeDecl -> ^(TYPE_DECL typeDecl)
				;
arrayDecl :  ARRAY arrayRange arrayTypeDecl -> ^(ARR_DECL arrayRange arrayTypeDecl )
			;

arrayCall	:	VARIABLE '['expressions']' -> ^(ARR_CALL VARIABLE expressions)
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
			
boolOperator: MORE|LESS|EQUAL|LESS_OR_EQUAL|GREATER_OR_EQUAL|GREATER
			;

//-----------------Math	Operations------------------------//
mathGroup	:	'('!expressions')'!
			|INT
			|CHAR
			|BOOLEAN 
			|STRING
			|VARIABLE
			|funcCall
			|arrayCall
		;


boolMult	:	mathGroup(BOOL_MULT^ mathGroup)*
			;

boolAdd	:	boolMult(BOOL_ADD^ boolMult)*
		;

boolElse	:	boolAdd(boolOperator^ boolAdd)*
			;

boolNegative : (boolElse)| (NOT^ boolElse)
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

bodyOper	:	assExpr OP_END!
				|conditionExpr
				|loopExpr
				|funcCall OP_END!
				;

expressions	:	mathExpr
				;

funcCallArgs	:	 mathExpr(','! mathExpr)* 
				;
funcCallArgsW	:	mathExpr(',' mathExpr)* -> ^(FUNC_CALL_ARGS mathExpr mathExpr*)
				;

funcCall	:	VARIABLE'(' funcCallArgsW? ')' -> ^(FUNC_CALL VARIABLE funcCallArgsW? )
			;

argDeclExpr	:	'('! argDeclMany? ')'! -> ^(FUNC_PROC_ARGS argDeclMany?)
			;

retTypeExpr	:	(T_INT|T_BOOL|T_CHAR|T_STRING)
			;

retTypeExprWrap	:	retTypeExpr -> ^(FUNC_PROC_RET_TYPE retTypeExpr)
				;

bodyFuncProcExpr	:	varDeclW? bodyExpr
					;

funcDeclare: FUNCTION VARIABLE argDeclExpr':' retTypeExprWrap OP_END!  bodyFuncProcExpr -> ^(FUNC_DECL VARIABLE argDeclExpr retTypeExprWrap bodyFuncProcExpr)
			;

procedureDeclare: PROCEDURE VARIABLE argDeclExpr OP_END bodyFuncProcExpr -> ^(PROC_DECL VARIABLE argDeclExpr bodyFuncProcExpr)
				;

//-------------------------------IF--------------------------------//

conditionElseExpr	:	ELSE! bodyExpr -> ^(ELSE bodyExpr)
					;
condExpr	:	 expressions  -> ^(CONDITION expressions)
			;
conditionExpr:	IF condExpr THEN! bodyExpr conditionElseExpr? -> ^(IF condExpr bodyExpr conditionElseExpr?)
	;

//---------------------------------------------------------------//
forExpr	:	 assExpr TO^ expressions
		;

loopExpr:	WHILE condExpr DO! bodyExpr -> ^(WHILE condExpr bodyExpr)
			|FOR forExpr DO bodyExpr -> ^(FOR forExpr bodyExpr)
			|REPEAT bodyExpr UNTIL condExpr OP_END -> ^(REPEAT condExpr bodyExpr)
		;	

assExpr	:	 VARIABLE ASSIGN^ expressions
			|arrayCall ASSIGN^ expressions
	;

argTypeDecl	:	varTypeDeclW -> ^(TYPE_DECL varTypeDeclW)
			;

partArgDecl: VARIABLE(','! VARIABLE)*;

argDecl	:	VARIABLE(','! VARIABLE)* ':'! argTypeDecl
			|VAR partArgDecl':'! argTypeDecl -> ^(VAR partArgDecl argTypeDecl)
		;

argDeclManyW	:	argDecl(','! argDecl)*
			;
argDeclMany	:	argDeclManyW -> ^(VAR_DECL argDeclManyW)
			;
typeDecl	:	T_INT|T_CHAR|T_BOOL|T_STRING;

//----------------VAR Operations-----------------------//
varTypeDeclW	:	typeDecl|arrayDecl
				;

varTypeDecl	:	varTypeDeclW OP_END -> ^(TYPE_DECL varTypeDeclW)
			;


varDecl2	: VARIABLE(','! VARIABLE)*;

varDecl	:	varDecl2
		;
varDecl12W	:	varDecl ':'! varTypeDecl 
			;
varDeclW	:	VAR (varDecl12W+) -> ^(VAR_DECL varDecl12W+ )
			;

//----------------------------------------------------//

bodyExpr	:	BEGIN! bodyOper* END! OP_END! -> ^(BODY_EXPR bodyOper*)
			;
mainBodyExpr	:	BEGIN! bodyOper* END! OP_END -> ^(MAIN_BODY bodyOper*)
				;
func_proc_expr	: funcDeclare|procedureDeclare ;

fpExprW	:	func_proc_expr* -> ^(FUNC_PROC_EXPR func_proc_expr*);

wrapToBody : varDeclW? fpExprW mainBodyExpr -> ^(BODY_EXPR varDeclW? fpExprW mainBodyExpr)
			;

expr	:	 PROGRAM VARIABLE OP_END! wrapToBody -> ^(PROGRAM VARIABLE wrapToBody)
	;
	
program: expr+  ;
result: program EOF -> ^(PROGRAM program);
public execute:  result;