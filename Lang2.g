grammar Lang2;

options{
	language=CSharp3;
	output=AST;
}



tokens{
	PROGRAM;
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

VAR	:	('a'..'z'|'A'..'Z')+

//----------------ÒÈÏÛ ÄÀÍÍÛÕ------------------------//

CHAR	:	('a'..'z'|'A'..'Z')
	;	
INT		:	('0'..'9')+
	;
BOOL	:	'true'|'false'
	;

//----------------ÎÏÅÐÀÖÈÈ------------------------//
ADD		:	'+'
	;
REM		:	'-'
	;
MULT	:	'*'
	;
DIVIDE	:	'/'
	;
ASS		:	':='
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
boolGroup	:	'('VAR boolOperaror VAR')'|'('BOOL')'|boolNegative
	;
boolNegative : '('NOT boolGroup')'
;
boolOperator: IS_MORE|IS_LESS|IS_EQUAL|LESS_OR_EQUAL|GREATER_OR_EQUAL
;


//----------------Char Operations-----------------------//

charExpr: VAR ASS CHAR
;


//-----------------Math	Operations------------------------//
mathGroup	:	'('!mathExpr+')'!
			|INT
			|VAR
		;

useDiv	: (DIV|MOD)^
		;

mathMult	
	:	mathGroup((MULT|DIVIDE)^mathGroup)*
		|useDiv'('mathExpr+')'!
	;
	
mathAdd	:	mathMult((ADD|REM)^mathMult)*
	;
	
mathExpr
	:	mathAdd
	;	
	
//##########################################################################//

expressions	:	mathExpr|boolExpr|charExpr|funcCall|procCall|assExpr;
			;

funcDeclare: FUNCTION VAR '('!')'! ':' INT|BOOL|CHAR BEGIN! expressions+ END OP_END!
			;
procedureDeclare: PROCEDURE VAR '('!')'! BEGIN! expressions+ END OP_END!

conditionExpr:	IF^'('!boolExpr+')' THEN! BEGIN! expressions+ END! (ELSE BEGIN! expressions+ END!)*
	;

loopExpr:	WHILE^ '('boolExpr+')' DO! BEGIN! expr* END!
			|FOR^ '('! assExpr OP_END! TO INT OP_END!')'! DO BEGIN! expressions+ END!
		;	

assExpr	:	VAR ASS^ expressions
	;

varDecl	:	typeDecl VAR^ OP_END! -> ^(VARDECL typeDecl VAR)
			|typeDecl assExpr OP_END! -> ^(VARDECL typeDecl assExpr)
		;

elseFuncExec	: funcExec
				;


execParamsRule	:	(expressions|funcExec)
				;

funcExec	:	VAR^'('!execParamsRule (','execParamsRule)*')'! OP_END!
			;

funcExpr:	varDecl
			|arrDecl
			|funcExec
			|assExpr OP_END!
			|conditionExpr
			|loopExpr
			|arrExec
	;

expr	:	funcDecl
			|varDecl
	;
	
program: expr+  ;
result: program EOF -> ^(PROGRAM program);
public execute:  result;