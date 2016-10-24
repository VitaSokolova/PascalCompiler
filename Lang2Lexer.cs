// $ANTLR 3.3 Nov 30, 2010 12:50:56 Lang2.g 2016-10-24 14:08:45

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System;
using System.Collections.Generic;
using Antlr.Runtime;
using Stack = System.Collections.Generic.Stack<object>;
using List = System.Collections.IList;
using ArrayList = System.Collections.Generic.List<object>;

namespace Lang2
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:50:56")]
[System.CLSCompliant(false)]
public partial class Lang2Lexer : Antlr.Runtime.Lexer
{
	public const int EOF=-1;
	public const int T__56=56;
	public const int T__57=57;
	public const int T__58=58;
	public const int T__59=59;
	public const int PROGRAM=4;
	public const int WHILE=5;
	public const int DO=6;
	public const int FOR=7;
	public const int FUNCTION=8;
	public const int PROCEDURE=9;
	public const int BEGIN=10;
	public const int END=11;
	public const int THEN=12;
	public const int ELSE=13;
	public const int DIV=14;
	public const int MOD=15;
	public const int NOT=16;
	public const int TO=17;
	public const int VAR=18;
	public const int T_CHAR=19;
	public const int T_BOOL=20;
	public const int T_INT=21;
	public const int IF=22;
	public const int BOOL=23;
	public const int CHAR=24;
	public const int INT=25;
	public const int FALSE=26;
	public const int TRUE=27;
	public const int VAR_DECL=28;
	public const int BODY_EXPR=29;
	public const int VAR_EXPR=30;
	public const int FUNC_PROC_EXPR=31;
	public const int PROC_DECL=32;
	public const int FUNC_DECL=33;
	public const int FUNC_CALL=34;
	public const int FUNC_CALL_ARGS=35;
	public const int FUNC_PROC_ARGS=36;
	public const int FUNC_PROC_RET_TYPE=37;
	public const int TYPE_DECL=38;
	public const int BOOL_MULT=39;
	public const int BOOL_ADD=40;
	public const int CONDITION=41;
	public const int OP_END=42;
	public const int WS=43;
	public const int VARIABLE=44;
	public const int ADD=45;
	public const int REM=46;
	public const int MULT=47;
	public const int DIVIDE=48;
	public const int ASSIGN=49;
	public const int GREATER=50;
	public const int LESS=51;
	public const int EQUAL=52;
	public const int LESS_OR_EQUAL=53;
	public const int GREATER_OR_EQUAL=54;
	public const int MORE=55;

    // delegates
    // delegators

	public Lang2Lexer()
	{
		OnCreated();
	}

	public Lang2Lexer(ICharStream input )
		: this(input, new RecognizerSharedState())
	{
	}

	public Lang2Lexer(ICharStream input, RecognizerSharedState state)
		: base(input, state)
	{


		OnCreated();
	}
	public override string GrammarFileName { get { return "Lang2.g"; } }

	private static readonly bool[] decisionCanBacktrack = new bool[0];

 
	protected virtual void OnCreated() {}
	protected virtual void EnterRule(string ruleName, int ruleIndex) {}
	protected virtual void LeaveRule(string ruleName, int ruleIndex) {}

    protected virtual void Enter_PROGRAM() {}
    protected virtual void Leave_PROGRAM() {}

    // $ANTLR start "PROGRAM"
    [GrammarRule("PROGRAM")]
    private void mPROGRAM()
    {

    		try
    		{
    		int _type = PROGRAM;
    		int _channel = DefaultTokenChannel;
    		// Lang2.g:9:9: ( 'program' )
    		DebugEnterAlt(1);
    		// Lang2.g:9:11: 'program'
    		{
    		DebugLocation(9, 11);
    		Match("program"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "PROGRAM"

    protected virtual void Enter_WHILE() {}
    protected virtual void Leave_WHILE() {}

    // $ANTLR start "WHILE"
    [GrammarRule("WHILE")]
    private void mWHILE()
    {

    		try
    		{
    		int _type = WHILE;
    		int _channel = DefaultTokenChannel;
    		// Lang2.g:10:7: ( 'while' )
    		DebugEnterAlt(1);
    		// Lang2.g:10:9: 'while'
    		{
    		DebugLocation(10, 9);
    		Match("while"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "WHILE"

    protected virtual void Enter_DO() {}
    protected virtual void Leave_DO() {}

    // $ANTLR start "DO"
    [GrammarRule("DO")]
    private void mDO()
    {

    		try
    		{
    		int _type = DO;
    		int _channel = DefaultTokenChannel;
    		// Lang2.g:11:4: ( 'do' )
    		DebugEnterAlt(1);
    		// Lang2.g:11:6: 'do'
    		{
    		DebugLocation(11, 6);
    		Match("do"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "DO"

    protected virtual void Enter_FOR() {}
    protected virtual void Leave_FOR() {}

    // $ANTLR start "FOR"
    [GrammarRule("FOR")]
    private void mFOR()
    {

    		try
    		{
    		int _type = FOR;
    		int _channel = DefaultTokenChannel;
    		// Lang2.g:12:5: ( 'for' )
    		DebugEnterAlt(1);
    		// Lang2.g:12:7: 'for'
    		{
    		DebugLocation(12, 7);
    		Match("for"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "FOR"

    protected virtual void Enter_FUNCTION() {}
    protected virtual void Leave_FUNCTION() {}

    // $ANTLR start "FUNCTION"
    [GrammarRule("FUNCTION")]
    private void mFUNCTION()
    {

    		try
    		{
    		int _type = FUNCTION;
    		int _channel = DefaultTokenChannel;
    		// Lang2.g:13:10: ( 'function' )
    		DebugEnterAlt(1);
    		// Lang2.g:13:12: 'function'
    		{
    		DebugLocation(13, 12);
    		Match("function"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "FUNCTION"

    protected virtual void Enter_PROCEDURE() {}
    protected virtual void Leave_PROCEDURE() {}

    // $ANTLR start "PROCEDURE"
    [GrammarRule("PROCEDURE")]
    private void mPROCEDURE()
    {

    		try
    		{
    		int _type = PROCEDURE;
    		int _channel = DefaultTokenChannel;
    		// Lang2.g:14:11: ( 'procedure' )
    		DebugEnterAlt(1);
    		// Lang2.g:14:13: 'procedure'
    		{
    		DebugLocation(14, 13);
    		Match("procedure"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "PROCEDURE"

    protected virtual void Enter_BEGIN() {}
    protected virtual void Leave_BEGIN() {}

    // $ANTLR start "BEGIN"
    [GrammarRule("BEGIN")]
    private void mBEGIN()
    {

    		try
    		{
    		int _type = BEGIN;
    		int _channel = DefaultTokenChannel;
    		// Lang2.g:15:7: ( 'begin' )
    		DebugEnterAlt(1);
    		// Lang2.g:15:9: 'begin'
    		{
    		DebugLocation(15, 9);
    		Match("begin"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "BEGIN"

    protected virtual void Enter_END() {}
    protected virtual void Leave_END() {}

    // $ANTLR start "END"
    [GrammarRule("END")]
    private void mEND()
    {

    		try
    		{
    		int _type = END;
    		int _channel = DefaultTokenChannel;
    		// Lang2.g:16:5: ( 'end' )
    		DebugEnterAlt(1);
    		// Lang2.g:16:7: 'end'
    		{
    		DebugLocation(16, 7);
    		Match("end"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "END"

    protected virtual void Enter_THEN() {}
    protected virtual void Leave_THEN() {}

    // $ANTLR start "THEN"
    [GrammarRule("THEN")]
    private void mTHEN()
    {

    		try
    		{
    		int _type = THEN;
    		int _channel = DefaultTokenChannel;
    		// Lang2.g:17:6: ( 'then' )
    		DebugEnterAlt(1);
    		// Lang2.g:17:8: 'then'
    		{
    		DebugLocation(17, 8);
    		Match("then"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "THEN"

    protected virtual void Enter_ELSE() {}
    protected virtual void Leave_ELSE() {}

    // $ANTLR start "ELSE"
    [GrammarRule("ELSE")]
    private void mELSE()
    {

    		try
    		{
    		int _type = ELSE;
    		int _channel = DefaultTokenChannel;
    		// Lang2.g:18:6: ( 'else' )
    		DebugEnterAlt(1);
    		// Lang2.g:18:8: 'else'
    		{
    		DebugLocation(18, 8);
    		Match("else"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "ELSE"

    protected virtual void Enter_DIV() {}
    protected virtual void Leave_DIV() {}

    // $ANTLR start "DIV"
    [GrammarRule("DIV")]
    private void mDIV()
    {

    		try
    		{
    		int _type = DIV;
    		int _channel = DefaultTokenChannel;
    		// Lang2.g:19:5: ( 'div' )
    		DebugEnterAlt(1);
    		// Lang2.g:19:7: 'div'
    		{
    		DebugLocation(19, 7);
    		Match("div"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "DIV"

    protected virtual void Enter_MOD() {}
    protected virtual void Leave_MOD() {}

    // $ANTLR start "MOD"
    [GrammarRule("MOD")]
    private void mMOD()
    {

    		try
    		{
    		int _type = MOD;
    		int _channel = DefaultTokenChannel;
    		// Lang2.g:20:5: ( 'mod' )
    		DebugEnterAlt(1);
    		// Lang2.g:20:7: 'mod'
    		{
    		DebugLocation(20, 7);
    		Match("mod"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "MOD"

    protected virtual void Enter_NOT() {}
    protected virtual void Leave_NOT() {}

    // $ANTLR start "NOT"
    [GrammarRule("NOT")]
    private void mNOT()
    {

    		try
    		{
    		int _type = NOT;
    		int _channel = DefaultTokenChannel;
    		// Lang2.g:21:5: ( 'not' )
    		DebugEnterAlt(1);
    		// Lang2.g:21:7: 'not'
    		{
    		DebugLocation(21, 7);
    		Match("not"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "NOT"

    protected virtual void Enter_TO() {}
    protected virtual void Leave_TO() {}

    // $ANTLR start "TO"
    [GrammarRule("TO")]
    private void mTO()
    {

    		try
    		{
    		int _type = TO;
    		int _channel = DefaultTokenChannel;
    		// Lang2.g:22:4: ( 'to' )
    		DebugEnterAlt(1);
    		// Lang2.g:22:6: 'to'
    		{
    		DebugLocation(22, 6);
    		Match("to"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "TO"

    protected virtual void Enter_VAR() {}
    protected virtual void Leave_VAR() {}

    // $ANTLR start "VAR"
    [GrammarRule("VAR")]
    private void mVAR()
    {

    		try
    		{
    		int _type = VAR;
    		int _channel = DefaultTokenChannel;
    		// Lang2.g:23:5: ( 'var' )
    		DebugEnterAlt(1);
    		// Lang2.g:23:7: 'var'
    		{
    		DebugLocation(23, 7);
    		Match("var"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "VAR"

    protected virtual void Enter_T_CHAR() {}
    protected virtual void Leave_T_CHAR() {}

    // $ANTLR start "T_CHAR"
    [GrammarRule("T_CHAR")]
    private void mT_CHAR()
    {

    		try
    		{
    		int _type = T_CHAR;
    		int _channel = DefaultTokenChannel;
    		// Lang2.g:24:8: ( 'char' )
    		DebugEnterAlt(1);
    		// Lang2.g:24:10: 'char'
    		{
    		DebugLocation(24, 10);
    		Match("char"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "T_CHAR"

    protected virtual void Enter_T_BOOL() {}
    protected virtual void Leave_T_BOOL() {}

    // $ANTLR start "T_BOOL"
    [GrammarRule("T_BOOL")]
    private void mT_BOOL()
    {

    		try
    		{
    		int _type = T_BOOL;
    		int _channel = DefaultTokenChannel;
    		// Lang2.g:25:8: ( 'boolean' )
    		DebugEnterAlt(1);
    		// Lang2.g:25:10: 'boolean'
    		{
    		DebugLocation(25, 10);
    		Match("boolean"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "T_BOOL"

    protected virtual void Enter_T_INT() {}
    protected virtual void Leave_T_INT() {}

    // $ANTLR start "T_INT"
    [GrammarRule("T_INT")]
    private void mT_INT()
    {

    		try
    		{
    		int _type = T_INT;
    		int _channel = DefaultTokenChannel;
    		// Lang2.g:26:7: ( 'integer' )
    		DebugEnterAlt(1);
    		// Lang2.g:26:9: 'integer'
    		{
    		DebugLocation(26, 9);
    		Match("integer"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "T_INT"

    protected virtual void Enter_IF() {}
    protected virtual void Leave_IF() {}

    // $ANTLR start "IF"
    [GrammarRule("IF")]
    private void mIF()
    {

    		try
    		{
    		int _type = IF;
    		int _channel = DefaultTokenChannel;
    		// Lang2.g:27:4: ( 'if' )
    		DebugEnterAlt(1);
    		// Lang2.g:27:6: 'if'
    		{
    		DebugLocation(27, 6);
    		Match("if"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "IF"

    protected virtual void Enter_FALSE() {}
    protected virtual void Leave_FALSE() {}

    // $ANTLR start "FALSE"
    [GrammarRule("FALSE")]
    private void mFALSE()
    {

    		try
    		{
    		int _type = FALSE;
    		int _channel = DefaultTokenChannel;
    		// Lang2.g:28:7: ( 'false' )
    		DebugEnterAlt(1);
    		// Lang2.g:28:9: 'false'
    		{
    		DebugLocation(28, 9);
    		Match("false"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "FALSE"

    protected virtual void Enter_TRUE() {}
    protected virtual void Leave_TRUE() {}

    // $ANTLR start "TRUE"
    [GrammarRule("TRUE")]
    private void mTRUE()
    {

    		try
    		{
    		int _type = TRUE;
    		int _channel = DefaultTokenChannel;
    		// Lang2.g:29:6: ( 'true' )
    		DebugEnterAlt(1);
    		// Lang2.g:29:8: 'true'
    		{
    		DebugLocation(29, 8);
    		Match("true"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "TRUE"

    protected virtual void Enter_BOOL_MULT() {}
    protected virtual void Leave_BOOL_MULT() {}

    // $ANTLR start "BOOL_MULT"
    [GrammarRule("BOOL_MULT")]
    private void mBOOL_MULT()
    {

    		try
    		{
    		int _type = BOOL_MULT;
    		int _channel = DefaultTokenChannel;
    		// Lang2.g:30:11: ( 'AND' )
    		DebugEnterAlt(1);
    		// Lang2.g:30:13: 'AND'
    		{
    		DebugLocation(30, 13);
    		Match("AND"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "BOOL_MULT"

    protected virtual void Enter_BOOL_ADD() {}
    protected virtual void Leave_BOOL_ADD() {}

    // $ANTLR start "BOOL_ADD"
    [GrammarRule("BOOL_ADD")]
    private void mBOOL_ADD()
    {

    		try
    		{
    		int _type = BOOL_ADD;
    		int _channel = DefaultTokenChannel;
    		// Lang2.g:31:10: ( 'OR' )
    		DebugEnterAlt(1);
    		// Lang2.g:31:12: 'OR'
    		{
    		DebugLocation(31, 12);
    		Match("OR"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "BOOL_ADD"

    protected virtual void Enter_T__56() {}
    protected virtual void Leave_T__56() {}

    // $ANTLR start "T__56"
    [GrammarRule("T__56")]
    private void mT__56()
    {

    		try
    		{
    		int _type = T__56;
    		int _channel = DefaultTokenChannel;
    		// Lang2.g:32:7: ( '(' )
    		DebugEnterAlt(1);
    		// Lang2.g:32:9: '('
    		{
    		DebugLocation(32, 9);
    		Match('('); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "T__56"

    protected virtual void Enter_T__57() {}
    protected virtual void Leave_T__57() {}

    // $ANTLR start "T__57"
    [GrammarRule("T__57")]
    private void mT__57()
    {

    		try
    		{
    		int _type = T__57;
    		int _channel = DefaultTokenChannel;
    		// Lang2.g:33:7: ( ')' )
    		DebugEnterAlt(1);
    		// Lang2.g:33:9: ')'
    		{
    		DebugLocation(33, 9);
    		Match(')'); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "T__57"

    protected virtual void Enter_T__58() {}
    protected virtual void Leave_T__58() {}

    // $ANTLR start "T__58"
    [GrammarRule("T__58")]
    private void mT__58()
    {

    		try
    		{
    		int _type = T__58;
    		int _channel = DefaultTokenChannel;
    		// Lang2.g:34:7: ( ',' )
    		DebugEnterAlt(1);
    		// Lang2.g:34:9: ','
    		{
    		DebugLocation(34, 9);
    		Match(','); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "T__58"

    protected virtual void Enter_T__59() {}
    protected virtual void Leave_T__59() {}

    // $ANTLR start "T__59"
    [GrammarRule("T__59")]
    private void mT__59()
    {

    		try
    		{
    		int _type = T__59;
    		int _channel = DefaultTokenChannel;
    		// Lang2.g:35:7: ( ':' )
    		DebugEnterAlt(1);
    		// Lang2.g:35:9: ':'
    		{
    		DebugLocation(35, 9);
    		Match(':'); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "T__59"

    protected virtual void Enter_OP_END() {}
    protected virtual void Leave_OP_END() {}

    // $ANTLR start "OP_END"
    [GrammarRule("OP_END")]
    private void mOP_END()
    {

    		try
    		{
    		int _type = OP_END;
    		int _channel = DefaultTokenChannel;
    		// Lang2.g:59:8: ( ';' )
    		DebugEnterAlt(1);
    		// Lang2.g:59:10: ';'
    		{
    		DebugLocation(59, 10);
    		Match(';'); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "OP_END"

    protected virtual void Enter_WS() {}
    protected virtual void Leave_WS() {}

    // $ANTLR start "WS"
    [GrammarRule("WS")]
    private void mWS()
    {

    		try
    		{
    		int _type = WS;
    		int _channel = DefaultTokenChannel;
    		// Lang2.g:62:3: ( ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+ )
    		DebugEnterAlt(1);
    		// Lang2.g:63:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
    		{
    		DebugLocation(63, 3);
    		// Lang2.g:63:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
    		int cnt1=0;
    		try { DebugEnterSubRule(1);
    		while (true)
    		{
    			int alt1=2;
    			try { DebugEnterDecision(1, decisionCanBacktrack[1]);
    			int LA1_0 = input.LA(1);

    			if (((LA1_0>='\t' && LA1_0<='\n')||(LA1_0>='\f' && LA1_0<='\r')||LA1_0==' '))
    			{
    				alt1=1;
    			}


    			} finally { DebugExitDecision(1); }
    			switch (alt1)
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:
    				{
    				DebugLocation(63, 3);
    				if ((input.LA(1)>='\t' && input.LA(1)<='\n')||(input.LA(1)>='\f' && input.LA(1)<='\r')||input.LA(1)==' ')
    				{
    					input.Consume();

    				}
    				else
    				{
    					MismatchedSetException mse = new MismatchedSetException(null,input);
    					DebugRecognitionException(mse);
    					Recover(mse);
    					throw mse;}


    				}
    				break;

    			default:
    				if (cnt1 >= 1)
    					goto loop1;

    				EarlyExitException eee1 = new EarlyExitException( 1, input );
    				DebugRecognitionException(eee1);
    				throw eee1;
    			}
    			cnt1++;
    		}
    		loop1:
    			;

    		} finally { DebugExitSubRule(1); }

    		DebugLocation(63, 41);

    		    _channel=Hidden;
    		  

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "WS"

    protected virtual void Enter_VARIABLE() {}
    protected virtual void Leave_VARIABLE() {}

    // $ANTLR start "VARIABLE"
    [GrammarRule("VARIABLE")]
    private void mVARIABLE()
    {

    		try
    		{
    		int _type = VARIABLE;
    		int _channel = DefaultTokenChannel;
    		// Lang2.g:67:10: ( ( 'a' .. 'z' | 'A' .. 'Z' )+ )
    		DebugEnterAlt(1);
    		// Lang2.g:67:12: ( 'a' .. 'z' | 'A' .. 'Z' )+
    		{
    		DebugLocation(67, 12);
    		// Lang2.g:67:12: ( 'a' .. 'z' | 'A' .. 'Z' )+
    		int cnt2=0;
    		try { DebugEnterSubRule(2);
    		while (true)
    		{
    			int alt2=2;
    			try { DebugEnterDecision(2, decisionCanBacktrack[2]);
    			int LA2_0 = input.LA(1);

    			if (((LA2_0>='A' && LA2_0<='Z')||(LA2_0>='a' && LA2_0<='z')))
    			{
    				alt2=1;
    			}


    			} finally { DebugExitDecision(2); }
    			switch (alt2)
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:
    				{
    				DebugLocation(67, 12);
    				if ((input.LA(1)>='A' && input.LA(1)<='Z')||(input.LA(1)>='a' && input.LA(1)<='z'))
    				{
    					input.Consume();

    				}
    				else
    				{
    					MismatchedSetException mse = new MismatchedSetException(null,input);
    					DebugRecognitionException(mse);
    					Recover(mse);
    					throw mse;}


    				}
    				break;

    			default:
    				if (cnt2 >= 1)
    					goto loop2;

    				EarlyExitException eee2 = new EarlyExitException( 2, input );
    				DebugRecognitionException(eee2);
    				throw eee2;
    			}
    			cnt2++;
    		}
    		loop2:
    			;

    		} finally { DebugExitSubRule(2); }


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "VARIABLE"

    protected virtual void Enter_CHAR() {}
    protected virtual void Leave_CHAR() {}

    // $ANTLR start "CHAR"
    [GrammarRule("CHAR")]
    private void mCHAR()
    {

    		try
    		{
    		int _type = CHAR;
    		int _channel = DefaultTokenChannel;
    		// Lang2.g:71:6: ( '\\'' ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' ) '\\'' )
    		DebugEnterAlt(1);
    		// Lang2.g:71:8: '\\'' ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' ) '\\''
    		{
    		DebugLocation(71, 12);
    		Match('\''); 
    		DebugLocation(71, 14);
    		if ((input.LA(1)>='0' && input.LA(1)<='9')||(input.LA(1)>='A' && input.LA(1)<='Z')||(input.LA(1)>='a' && input.LA(1)<='z'))
    		{
    			input.Consume();

    		}
    		else
    		{
    			MismatchedSetException mse = new MismatchedSetException(null,input);
    			DebugRecognitionException(mse);
    			Recover(mse);
    			throw mse;}

    		DebugLocation(71, 47);
    		Match('\''); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "CHAR"

    protected virtual void Enter_INT() {}
    protected virtual void Leave_INT() {}

    // $ANTLR start "INT"
    [GrammarRule("INT")]
    private void mINT()
    {

    		try
    		{
    		int _type = INT;
    		int _channel = DefaultTokenChannel;
    		// Lang2.g:73:6: ( ( '0' .. '9' )+ )
    		DebugEnterAlt(1);
    		// Lang2.g:73:8: ( '0' .. '9' )+
    		{
    		DebugLocation(73, 8);
    		// Lang2.g:73:8: ( '0' .. '9' )+
    		int cnt3=0;
    		try { DebugEnterSubRule(3);
    		while (true)
    		{
    			int alt3=2;
    			try { DebugEnterDecision(3, decisionCanBacktrack[3]);
    			int LA3_0 = input.LA(1);

    			if (((LA3_0>='0' && LA3_0<='9')))
    			{
    				alt3=1;
    			}


    			} finally { DebugExitDecision(3); }
    			switch (alt3)
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:73:9: '0' .. '9'
    				{
    				DebugLocation(73, 9);
    				MatchRange('0','9'); 

    				}
    				break;

    			default:
    				if (cnt3 >= 1)
    					goto loop3;

    				EarlyExitException eee3 = new EarlyExitException( 3, input );
    				DebugRecognitionException(eee3);
    				throw eee3;
    			}
    			cnt3++;
    		}
    		loop3:
    			;

    		} finally { DebugExitSubRule(3); }


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "INT"

    protected virtual void Enter_ADD() {}
    protected virtual void Leave_ADD() {}

    // $ANTLR start "ADD"
    [GrammarRule("ADD")]
    private void mADD()
    {

    		try
    		{
    		int _type = ADD;
    		int _channel = DefaultTokenChannel;
    		// Lang2.g:77:6: ( '+' )
    		DebugEnterAlt(1);
    		// Lang2.g:77:8: '+'
    		{
    		DebugLocation(77, 8);
    		Match('+'); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "ADD"

    protected virtual void Enter_REM() {}
    protected virtual void Leave_REM() {}

    // $ANTLR start "REM"
    [GrammarRule("REM")]
    private void mREM()
    {

    		try
    		{
    		int _type = REM;
    		int _channel = DefaultTokenChannel;
    		// Lang2.g:79:6: ( '-' )
    		DebugEnterAlt(1);
    		// Lang2.g:79:8: '-'
    		{
    		DebugLocation(79, 8);
    		Match('-'); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "REM"

    protected virtual void Enter_MULT() {}
    protected virtual void Leave_MULT() {}

    // $ANTLR start "MULT"
    [GrammarRule("MULT")]
    private void mMULT()
    {

    		try
    		{
    		int _type = MULT;
    		int _channel = DefaultTokenChannel;
    		// Lang2.g:81:6: ( '*' )
    		DebugEnterAlt(1);
    		// Lang2.g:81:8: '*'
    		{
    		DebugLocation(81, 8);
    		Match('*'); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "MULT"

    protected virtual void Enter_DIVIDE() {}
    protected virtual void Leave_DIVIDE() {}

    // $ANTLR start "DIVIDE"
    [GrammarRule("DIVIDE")]
    private void mDIVIDE()
    {

    		try
    		{
    		int _type = DIVIDE;
    		int _channel = DefaultTokenChannel;
    		// Lang2.g:83:8: ( '/' )
    		DebugEnterAlt(1);
    		// Lang2.g:83:10: '/'
    		{
    		DebugLocation(83, 10);
    		Match('/'); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "DIVIDE"

    protected virtual void Enter_ASSIGN() {}
    protected virtual void Leave_ASSIGN() {}

    // $ANTLR start "ASSIGN"
    [GrammarRule("ASSIGN")]
    private void mASSIGN()
    {

    		try
    		{
    		int _type = ASSIGN;
    		int _channel = DefaultTokenChannel;
    		// Lang2.g:85:9: ( ':=' )
    		DebugEnterAlt(1);
    		// Lang2.g:85:11: ':='
    		{
    		DebugLocation(85, 11);
    		Match(":="); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "ASSIGN"

    protected virtual void Enter_GREATER() {}
    protected virtual void Leave_GREATER() {}

    // $ANTLR start "GREATER"
    [GrammarRule("GREATER")]
    private void mGREATER()
    {

    		try
    		{
    		int _type = GREATER;
    		int _channel = DefaultTokenChannel;
    		// Lang2.g:87:10: ( '>' )
    		DebugEnterAlt(1);
    		// Lang2.g:87:12: '>'
    		{
    		DebugLocation(87, 12);
    		Match('>'); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "GREATER"

    protected virtual void Enter_LESS() {}
    protected virtual void Leave_LESS() {}

    // $ANTLR start "LESS"
    [GrammarRule("LESS")]
    private void mLESS()
    {

    		try
    		{
    		int _type = LESS;
    		int _channel = DefaultTokenChannel;
    		// Lang2.g:89:6: ( '<' )
    		DebugEnterAlt(1);
    		// Lang2.g:89:8: '<'
    		{
    		DebugLocation(89, 8);
    		Match('<'); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "LESS"

    protected virtual void Enter_EQUAL() {}
    protected virtual void Leave_EQUAL() {}

    // $ANTLR start "EQUAL"
    [GrammarRule("EQUAL")]
    private void mEQUAL()
    {

    		try
    		{
    		int _type = EQUAL;
    		int _channel = DefaultTokenChannel;
    		// Lang2.g:91:7: ( '=' )
    		DebugEnterAlt(1);
    		// Lang2.g:91:9: '='
    		{
    		DebugLocation(91, 9);
    		Match('='); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "EQUAL"

    protected virtual void Enter_LESS_OR_EQUAL() {}
    protected virtual void Leave_LESS_OR_EQUAL() {}

    // $ANTLR start "LESS_OR_EQUAL"
    [GrammarRule("LESS_OR_EQUAL")]
    private void mLESS_OR_EQUAL()
    {

    		try
    		{
    		int _type = LESS_OR_EQUAL;
    		int _channel = DefaultTokenChannel;
    		// Lang2.g:93:16: ( '<=' )
    		DebugEnterAlt(1);
    		// Lang2.g:93:18: '<='
    		{
    		DebugLocation(93, 18);
    		Match("<="); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "LESS_OR_EQUAL"

    protected virtual void Enter_GREATER_OR_EQUAL() {}
    protected virtual void Leave_GREATER_OR_EQUAL() {}

    // $ANTLR start "GREATER_OR_EQUAL"
    [GrammarRule("GREATER_OR_EQUAL")]
    private void mGREATER_OR_EQUAL()
    {

    		try
    		{
    		int _type = GREATER_OR_EQUAL;
    		int _channel = DefaultTokenChannel;
    		// Lang2.g:95:19: ( '>=' )
    		DebugEnterAlt(1);
    		// Lang2.g:95:21: '>='
    		{
    		DebugLocation(95, 21);
    		Match(">="); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "GREATER_OR_EQUAL"

    public override void mTokens()
    {
    	// Lang2.g:1:8: ( PROGRAM | WHILE | DO | FOR | FUNCTION | PROCEDURE | BEGIN | END | THEN | ELSE | DIV | MOD | NOT | TO | VAR | T_CHAR | T_BOOL | T_INT | IF | FALSE | TRUE | BOOL_MULT | BOOL_ADD | T__56 | T__57 | T__58 | T__59 | OP_END | WS | VARIABLE | CHAR | INT | ADD | REM | MULT | DIVIDE | ASSIGN | GREATER | LESS | EQUAL | LESS_OR_EQUAL | GREATER_OR_EQUAL )
    	int alt4=42;
    	try { DebugEnterDecision(4, decisionCanBacktrack[4]);
    	try
    	{
    		alt4 = dfa4.Predict(input);
    	}
    	catch (NoViableAltException nvae)
    	{
    		DebugRecognitionException(nvae);
    		throw;
    	}
    	} finally { DebugExitDecision(4); }
    	switch (alt4)
    	{
    	case 1:
    		DebugEnterAlt(1);
    		// Lang2.g:1:10: PROGRAM
    		{
    		DebugLocation(1, 10);
    		mPROGRAM(); 

    		}
    		break;
    	case 2:
    		DebugEnterAlt(2);
    		// Lang2.g:1:18: WHILE
    		{
    		DebugLocation(1, 18);
    		mWHILE(); 

    		}
    		break;
    	case 3:
    		DebugEnterAlt(3);
    		// Lang2.g:1:24: DO
    		{
    		DebugLocation(1, 24);
    		mDO(); 

    		}
    		break;
    	case 4:
    		DebugEnterAlt(4);
    		// Lang2.g:1:27: FOR
    		{
    		DebugLocation(1, 27);
    		mFOR(); 

    		}
    		break;
    	case 5:
    		DebugEnterAlt(5);
    		// Lang2.g:1:31: FUNCTION
    		{
    		DebugLocation(1, 31);
    		mFUNCTION(); 

    		}
    		break;
    	case 6:
    		DebugEnterAlt(6);
    		// Lang2.g:1:40: PROCEDURE
    		{
    		DebugLocation(1, 40);
    		mPROCEDURE(); 

    		}
    		break;
    	case 7:
    		DebugEnterAlt(7);
    		// Lang2.g:1:50: BEGIN
    		{
    		DebugLocation(1, 50);
    		mBEGIN(); 

    		}
    		break;
    	case 8:
    		DebugEnterAlt(8);
    		// Lang2.g:1:56: END
    		{
    		DebugLocation(1, 56);
    		mEND(); 

    		}
    		break;
    	case 9:
    		DebugEnterAlt(9);
    		// Lang2.g:1:60: THEN
    		{
    		DebugLocation(1, 60);
    		mTHEN(); 

    		}
    		break;
    	case 10:
    		DebugEnterAlt(10);
    		// Lang2.g:1:65: ELSE
    		{
    		DebugLocation(1, 65);
    		mELSE(); 

    		}
    		break;
    	case 11:
    		DebugEnterAlt(11);
    		// Lang2.g:1:70: DIV
    		{
    		DebugLocation(1, 70);
    		mDIV(); 

    		}
    		break;
    	case 12:
    		DebugEnterAlt(12);
    		// Lang2.g:1:74: MOD
    		{
    		DebugLocation(1, 74);
    		mMOD(); 

    		}
    		break;
    	case 13:
    		DebugEnterAlt(13);
    		// Lang2.g:1:78: NOT
    		{
    		DebugLocation(1, 78);
    		mNOT(); 

    		}
    		break;
    	case 14:
    		DebugEnterAlt(14);
    		// Lang2.g:1:82: TO
    		{
    		DebugLocation(1, 82);
    		mTO(); 

    		}
    		break;
    	case 15:
    		DebugEnterAlt(15);
    		// Lang2.g:1:85: VAR
    		{
    		DebugLocation(1, 85);
    		mVAR(); 

    		}
    		break;
    	case 16:
    		DebugEnterAlt(16);
    		// Lang2.g:1:89: T_CHAR
    		{
    		DebugLocation(1, 89);
    		mT_CHAR(); 

    		}
    		break;
    	case 17:
    		DebugEnterAlt(17);
    		// Lang2.g:1:96: T_BOOL
    		{
    		DebugLocation(1, 96);
    		mT_BOOL(); 

    		}
    		break;
    	case 18:
    		DebugEnterAlt(18);
    		// Lang2.g:1:103: T_INT
    		{
    		DebugLocation(1, 103);
    		mT_INT(); 

    		}
    		break;
    	case 19:
    		DebugEnterAlt(19);
    		// Lang2.g:1:109: IF
    		{
    		DebugLocation(1, 109);
    		mIF(); 

    		}
    		break;
    	case 20:
    		DebugEnterAlt(20);
    		// Lang2.g:1:112: FALSE
    		{
    		DebugLocation(1, 112);
    		mFALSE(); 

    		}
    		break;
    	case 21:
    		DebugEnterAlt(21);
    		// Lang2.g:1:118: TRUE
    		{
    		DebugLocation(1, 118);
    		mTRUE(); 

    		}
    		break;
    	case 22:
    		DebugEnterAlt(22);
    		// Lang2.g:1:123: BOOL_MULT
    		{
    		DebugLocation(1, 123);
    		mBOOL_MULT(); 

    		}
    		break;
    	case 23:
    		DebugEnterAlt(23);
    		// Lang2.g:1:133: BOOL_ADD
    		{
    		DebugLocation(1, 133);
    		mBOOL_ADD(); 

    		}
    		break;
    	case 24:
    		DebugEnterAlt(24);
    		// Lang2.g:1:142: T__56
    		{
    		DebugLocation(1, 142);
    		mT__56(); 

    		}
    		break;
    	case 25:
    		DebugEnterAlt(25);
    		// Lang2.g:1:148: T__57
    		{
    		DebugLocation(1, 148);
    		mT__57(); 

    		}
    		break;
    	case 26:
    		DebugEnterAlt(26);
    		// Lang2.g:1:154: T__58
    		{
    		DebugLocation(1, 154);
    		mT__58(); 

    		}
    		break;
    	case 27:
    		DebugEnterAlt(27);
    		// Lang2.g:1:160: T__59
    		{
    		DebugLocation(1, 160);
    		mT__59(); 

    		}
    		break;
    	case 28:
    		DebugEnterAlt(28);
    		// Lang2.g:1:166: OP_END
    		{
    		DebugLocation(1, 166);
    		mOP_END(); 

    		}
    		break;
    	case 29:
    		DebugEnterAlt(29);
    		// Lang2.g:1:173: WS
    		{
    		DebugLocation(1, 173);
    		mWS(); 

    		}
    		break;
    	case 30:
    		DebugEnterAlt(30);
    		// Lang2.g:1:176: VARIABLE
    		{
    		DebugLocation(1, 176);
    		mVARIABLE(); 

    		}
    		break;
    	case 31:
    		DebugEnterAlt(31);
    		// Lang2.g:1:185: CHAR
    		{
    		DebugLocation(1, 185);
    		mCHAR(); 

    		}
    		break;
    	case 32:
    		DebugEnterAlt(32);
    		// Lang2.g:1:190: INT
    		{
    		DebugLocation(1, 190);
    		mINT(); 

    		}
    		break;
    	case 33:
    		DebugEnterAlt(33);
    		// Lang2.g:1:194: ADD
    		{
    		DebugLocation(1, 194);
    		mADD(); 

    		}
    		break;
    	case 34:
    		DebugEnterAlt(34);
    		// Lang2.g:1:198: REM
    		{
    		DebugLocation(1, 198);
    		mREM(); 

    		}
    		break;
    	case 35:
    		DebugEnterAlt(35);
    		// Lang2.g:1:202: MULT
    		{
    		DebugLocation(1, 202);
    		mMULT(); 

    		}
    		break;
    	case 36:
    		DebugEnterAlt(36);
    		// Lang2.g:1:207: DIVIDE
    		{
    		DebugLocation(1, 207);
    		mDIVIDE(); 

    		}
    		break;
    	case 37:
    		DebugEnterAlt(37);
    		// Lang2.g:1:214: ASSIGN
    		{
    		DebugLocation(1, 214);
    		mASSIGN(); 

    		}
    		break;
    	case 38:
    		DebugEnterAlt(38);
    		// Lang2.g:1:221: GREATER
    		{
    		DebugLocation(1, 221);
    		mGREATER(); 

    		}
    		break;
    	case 39:
    		DebugEnterAlt(39);
    		// Lang2.g:1:229: LESS
    		{
    		DebugLocation(1, 229);
    		mLESS(); 

    		}
    		break;
    	case 40:
    		DebugEnterAlt(40);
    		// Lang2.g:1:234: EQUAL
    		{
    		DebugLocation(1, 234);
    		mEQUAL(); 

    		}
    		break;
    	case 41:
    		DebugEnterAlt(41);
    		// Lang2.g:1:240: LESS_OR_EQUAL
    		{
    		DebugLocation(1, 240);
    		mLESS_OR_EQUAL(); 

    		}
    		break;
    	case 42:
    		DebugEnterAlt(42);
    		// Lang2.g:1:254: GREATER_OR_EQUAL
    		{
    		DebugLocation(1, 254);
    		mGREATER_OR_EQUAL(); 

    		}
    		break;

    	}

    }


	#region DFA
	DFA4 dfa4;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa4 = new DFA4(this);
	}

	private class DFA4 : DFA
	{
		private const string DFA4_eotS =
			"\x01\uffff\x0e\x15\x03\uffff\x01\x36\x09\uffff\x01\x38\x01\x3a\x01\uffff"+
			"\x02\x15\x01\x3d\x09\x15\x01\x47\x06\x15\x01\x4e\x01\x15\x01\x50\x06"+
			"\uffff\x02\x15\x01\uffff\x01\x54\x01\x55\x04\x15\x01\x5a\x02\x15\x01"+
			"\uffff\x01\x15\x01\x5e\x01\x5f\x01\x60\x02\x15\x01\uffff\x01\x63\x01"+
			"\uffff\x03\x15\x02\uffff\x04\x15\x01\uffff\x01\x6b\x01\x6c\x01\x6d\x03"+
			"\uffff\x01\x6e\x01\x15\x01\uffff\x02\x15\x01\x72\x01\x15\x01\x74\x01"+
			"\x75\x01\x15\x04\uffff\x03\x15\x01\uffff\x01\x15\x02\uffff\x02\x15\x01"+
			"\x7d\x02\x15\x01\u0080\x01\u0081\x01\uffff\x01\x15\x01\u0083\x02\uffff"+
			"\x01\u0084\x02\uffff";
		private const string DFA4_eofS =
			"\u0085\uffff";
		private const string DFA4_minS =
			"\x01\x09\x01\x72\x01\x68\x01\x69\x01\x61\x01\x65\x01\x6c\x01\x68\x02"+
			"\x6f\x01\x61\x01\x68\x01\x66\x01\x4e\x01\x52\x03\uffff\x01\x3d\x09\uffff"+
			"\x02\x3d\x01\uffff\x01\x6f\x01\x69\x01\x41\x01\x76\x01\x72\x01\x6e\x01"+
			"\x6c\x01\x67\x01\x6f\x01\x64\x01\x73\x01\x65\x01\x41\x01\x75\x01\x64"+
			"\x01\x74\x01\x72\x01\x61\x01\x74\x01\x41\x01\x44\x01\x41\x06\uffff\x01"+
			"\x63\x01\x6c\x01\uffff\x02\x41\x01\x63\x01\x73\x01\x69\x01\x6c\x01\x41"+
			"\x01\x65\x01\x6e\x01\uffff\x01\x65\x03\x41\x01\x72\x01\x65\x01\uffff"+
			"\x01\x41\x01\uffff\x01\x72\x02\x65\x02\uffff\x01\x74\x01\x65\x01\x6e"+
			"\x01\x65\x01\uffff\x03\x41\x03\uffff\x01\x41\x01\x67\x01\uffff\x01\x61"+
			"\x01\x64\x01\x41\x01\x69\x02\x41\x01\x61\x04\uffff\x01\x65\x01\x6d\x01"+
			"\x75\x01\uffff\x01\x6f\x02\uffff\x01\x6e\x01\x72\x01\x41\x01\x72\x01"+
			"\x6e\x02\x41\x01\uffff\x01\x65\x01\x41\x02\uffff\x01\x41\x02\uffff";
		private const string DFA4_maxS =
			"\x01\x7a\x01\x72\x01\x68\x01\x6f\x01\x75\x01\x6f\x01\x6e\x01\x72\x02"+
			"\x6f\x01\x61\x01\x68\x01\x6e\x01\x4e\x01\x52\x03\uffff\x01\x3d\x09\uffff"+
			"\x02\x3d\x01\uffff\x01\x6f\x01\x69\x01\x7a\x01\x76\x01\x72\x01\x6e\x01"+
			"\x6c\x01\x67\x01\x6f\x01\x64\x01\x73\x01\x65\x01\x7a\x01\x75\x01\x64"+
			"\x01\x74\x01\x72\x01\x61\x01\x74\x01\x7a\x01\x44\x01\x7a\x06\uffff\x01"+
			"\x67\x01\x6c\x01\uffff\x02\x7a\x01\x63\x01\x73\x01\x69\x01\x6c\x01\x7a"+
			"\x01\x65\x01\x6e\x01\uffff\x01\x65\x03\x7a\x01\x72\x01\x65\x01\uffff"+
			"\x01\x7a\x01\uffff\x01\x72\x02\x65\x02\uffff\x01\x74\x01\x65\x01\x6e"+
			"\x01\x65\x01\uffff\x03\x7a\x03\uffff\x01\x7a\x01\x67\x01\uffff\x01\x61"+
			"\x01\x64\x01\x7a\x01\x69\x02\x7a\x01\x61\x04\uffff\x01\x65\x01\x6d\x01"+
			"\x75\x01\uffff\x01\x6f\x02\uffff\x01\x6e\x01\x72\x01\x7a\x01\x72\x01"+
			"\x6e\x02\x7a\x01\uffff\x01\x65\x01\x7a\x02\uffff\x01\x7a\x02\uffff";
		private const string DFA4_acceptS =
			"\x0f\uffff\x01\x18\x01\x19\x01\x1a\x01\uffff\x01\x1c\x01\x1d\x01\x1e"+
			"\x01\x1f\x01\x20\x01\x21\x01\x22\x01\x23\x01\x24\x02\uffff\x01\x28\x16"+
			"\uffff\x01\x25\x01\x1b\x01\x2a\x01\x26\x01\x29\x01\x27\x02\uffff\x01"+
			"\x03\x09\uffff\x01\x0e\x06\uffff\x01\x13\x01\uffff\x01\x17\x03\uffff"+
			"\x01\x0b\x01\x04\x04\uffff\x01\x08\x03\uffff\x01\x0c\x01\x0d\x01\x0f"+
			"\x02\uffff\x01\x16\x07\uffff\x01\x0a\x01\x09\x01\x15\x01\x10\x03\uffff"+
			"\x01\x02\x01\uffff\x01\x14\x01\x07\x07\uffff\x01\x01\x02\uffff\x01\x11"+
			"\x01\x12\x01\uffff\x01\x05\x01\x06";
		private const string DFA4_specialS =
			"\u0085\uffff}>";
		private static readonly string[] DFA4_transitionS =
			{
				"\x02\x14\x01\uffff\x02\x14\x12\uffff\x01\x14\x06\uffff\x01\x16\x01"+
				"\x0f\x01\x10\x01\x1a\x01\x18\x01\x11\x01\x19\x01\uffff\x01\x1b\x0a\x17"+
				"\x01\x12\x01\x13\x01\x1d\x01\x1e\x01\x1c\x02\uffff\x01\x0d\x0d\x15\x01"+
				"\x0e\x0b\x15\x06\uffff\x01\x15\x01\x05\x01\x0b\x01\x03\x01\x06\x01\x04"+
				"\x02\x15\x01\x0c\x03\x15\x01\x08\x01\x09\x01\x15\x01\x01\x03\x15\x01"+
				"\x07\x01\x15\x01\x0a\x01\x02\x03\x15",
				"\x01\x1f",
				"\x01\x20",
				"\x01\x22\x05\uffff\x01\x21",
				"\x01\x25\x0d\uffff\x01\x23\x05\uffff\x01\x24",
				"\x01\x26\x09\uffff\x01\x27",
				"\x01\x29\x01\uffff\x01\x28",
				"\x01\x2a\x06\uffff\x01\x2b\x02\uffff\x01\x2c",
				"\x01\x2d",
				"\x01\x2e",
				"\x01\x2f",
				"\x01\x30",
				"\x01\x32\x07\uffff\x01\x31",
				"\x01\x33",
				"\x01\x34",
				"",
				"",
				"",
				"\x01\x35",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x01\x37",
				"\x01\x39",
				"",
				"\x01\x3b",
				"\x01\x3c",
				"\x1a\x15\x06\uffff\x1a\x15",
				"\x01\x3e",
				"\x01\x3f",
				"\x01\x40",
				"\x01\x41",
				"\x01\x42",
				"\x01\x43",
				"\x01\x44",
				"\x01\x45",
				"\x01\x46",
				"\x1a\x15\x06\uffff\x1a\x15",
				"\x01\x48",
				"\x01\x49",
				"\x01\x4a",
				"\x01\x4b",
				"\x01\x4c",
				"\x01\x4d",
				"\x1a\x15\x06\uffff\x1a\x15",
				"\x01\x4f",
				"\x1a\x15\x06\uffff\x1a\x15",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x01\x52\x03\uffff\x01\x51",
				"\x01\x53",
				"",
				"\x1a\x15\x06\uffff\x1a\x15",
				"\x1a\x15\x06\uffff\x1a\x15",
				"\x01\x56",
				"\x01\x57",
				"\x01\x58",
				"\x01\x59",
				"\x1a\x15\x06\uffff\x1a\x15",
				"\x01\x5b",
				"\x01\x5c",
				"",
				"\x01\x5d",
				"\x1a\x15\x06\uffff\x1a\x15",
				"\x1a\x15\x06\uffff\x1a\x15",
				"\x1a\x15\x06\uffff\x1a\x15",
				"\x01\x61",
				"\x01\x62",
				"",
				"\x1a\x15\x06\uffff\x1a\x15",
				"",
				"\x01\x64",
				"\x01\x65",
				"\x01\x66",
				"",
				"",
				"\x01\x67",
				"\x01\x68",
				"\x01\x69",
				"\x01\x6a",
				"",
				"\x1a\x15\x06\uffff\x1a\x15",
				"\x1a\x15\x06\uffff\x1a\x15",
				"\x1a\x15\x06\uffff\x1a\x15",
				"",
				"",
				"",
				"\x1a\x15\x06\uffff\x1a\x15",
				"\x01\x6f",
				"",
				"\x01\x70",
				"\x01\x71",
				"\x1a\x15\x06\uffff\x1a\x15",
				"\x01\x73",
				"\x1a\x15\x06\uffff\x1a\x15",
				"\x1a\x15\x06\uffff\x1a\x15",
				"\x01\x76",
				"",
				"",
				"",
				"",
				"\x01\x77",
				"\x01\x78",
				"\x01\x79",
				"",
				"\x01\x7a",
				"",
				"",
				"\x01\x7b",
				"\x01\x7c",
				"\x1a\x15\x06\uffff\x1a\x15",
				"\x01\x7e",
				"\x01\x7f",
				"\x1a\x15\x06\uffff\x1a\x15",
				"\x1a\x15\x06\uffff\x1a\x15",
				"",
				"\x01\u0082",
				"\x1a\x15\x06\uffff\x1a\x15",
				"",
				"",
				"\x1a\x15\x06\uffff\x1a\x15",
				"",
				""
			};

		private static readonly short[] DFA4_eot = DFA.UnpackEncodedString(DFA4_eotS);
		private static readonly short[] DFA4_eof = DFA.UnpackEncodedString(DFA4_eofS);
		private static readonly char[] DFA4_min = DFA.UnpackEncodedStringToUnsignedChars(DFA4_minS);
		private static readonly char[] DFA4_max = DFA.UnpackEncodedStringToUnsignedChars(DFA4_maxS);
		private static readonly short[] DFA4_accept = DFA.UnpackEncodedString(DFA4_acceptS);
		private static readonly short[] DFA4_special = DFA.UnpackEncodedString(DFA4_specialS);
		private static readonly short[][] DFA4_transition;

		static DFA4()
		{
			int numStates = DFA4_transitionS.Length;
			DFA4_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA4_transition[i] = DFA.UnpackEncodedString(DFA4_transitionS[i]);
			}
		}

		public DFA4( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 4;
			this.eot = DFA4_eot;
			this.eof = DFA4_eof;
			this.min = DFA4_min;
			this.max = DFA4_max;
			this.accept = DFA4_accept;
			this.special = DFA4_special;
			this.transition = DFA4_transition;
		}

		public override string Description { get { return "1:1: Tokens : ( PROGRAM | WHILE | DO | FOR | FUNCTION | PROCEDURE | BEGIN | END | THEN | ELSE | DIV | MOD | NOT | TO | VAR | T_CHAR | T_BOOL | T_INT | IF | FALSE | TRUE | BOOL_MULT | BOOL_ADD | T__56 | T__57 | T__58 | T__59 | OP_END | WS | VARIABLE | CHAR | INT | ADD | REM | MULT | DIVIDE | ASSIGN | GREATER | LESS | EQUAL | LESS_OR_EQUAL | GREATER_OR_EQUAL );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

 
	#endregion

}
}