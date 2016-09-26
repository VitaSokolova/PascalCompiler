// $ANTLR 3.3 Nov 30, 2010 12:50:56 Lang2.g 2016-09-25 16:38:59

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162


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
	public const int T__35=35;
	public const int T__36=36;
	public const int T__37=37;
	public const int T__38=38;
	public const int T__39=39;
	public const int T__40=40;
	public const int T__41=41;
	public const int T__42=42;
	public const int T__43=43;
	public const int T__44=44;
	public const int T__45=45;
	public const int T__46=46;
	public const int T__47=47;
	public const int PROGRAM=4;
	public const int VARDECL=5;
	public const int FUNC_DECL=6;
	public const int FUNC_CALL=7;
	public const int ARR_DECL=8;
	public const int ARR_CALL=9;
	public const int ARGS_RULE=10;
	public const int FUNC_BODY=11;
	public const int EMPTY=12;
	public const int OP_END=13;
	public const int WS=14;
	public const int ADD=15;
	public const int REM=16;
	public const int MULT=17;
	public const int DIV=18;
	public const int ASS=19;
	public const int DISJUNCTION=20;
	public const int CONJUCTION=21;
	public const int IS_MORE=22;
	public const int VITOCHKA=23;
	public const int IS_LESS=24;
	public const int IS_EQUALLY=25;
	public const int INVERT=26;
	public const int IF=27;
	public const int WHILE=28;
	public const int DO=29;
	public const int FOR=30;
	public const int BOOL=31;
	public const int VAR=32;
	public const int INT=33;
	public const int STRING=34;

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


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	partial void Enter_T__35();
	partial void Leave_T__35();

	// $ANTLR start "T__35"
	[GrammarRule("T__35")]
	private void mT__35()
	{
		Enter_T__35();
		EnterRule("T__35", 1);
		TraceIn("T__35", 1);
		try
		{
			int _type = T__35;
			int _channel = DefaultTokenChannel;
			// Lang2.g:9:7: ( 'int' )
			DebugEnterAlt(1);
			// Lang2.g:9:9: 'int'
			{
			DebugLocation(9, 9);
			Match("int"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__35", 1);
			LeaveRule("T__35", 1);
			Leave_T__35();
		}
	}
	// $ANTLR end "T__35"

	partial void Enter_T__36();
	partial void Leave_T__36();

	// $ANTLR start "T__36"
	[GrammarRule("T__36")]
	private void mT__36()
	{
		Enter_T__36();
		EnterRule("T__36", 2);
		TraceIn("T__36", 2);
		try
		{
			int _type = T__36;
			int _channel = DefaultTokenChannel;
			// Lang2.g:10:7: ( 'bool' )
			DebugEnterAlt(1);
			// Lang2.g:10:9: 'bool'
			{
			DebugLocation(10, 9);
			Match("bool"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__36", 2);
			LeaveRule("T__36", 2);
			Leave_T__36();
		}
	}
	// $ANTLR end "T__36"

	partial void Enter_T__37();
	partial void Leave_T__37();

	// $ANTLR start "T__37"
	[GrammarRule("T__37")]
	private void mT__37()
	{
		Enter_T__37();
		EnterRule("T__37", 3);
		TraceIn("T__37", 3);
		try
		{
			int _type = T__37;
			int _channel = DefaultTokenChannel;
			// Lang2.g:11:7: ( 'string' )
			DebugEnterAlt(1);
			// Lang2.g:11:9: 'string'
			{
			DebugLocation(11, 9);
			Match("string"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__37", 3);
			LeaveRule("T__37", 3);
			Leave_T__37();
		}
	}
	// $ANTLR end "T__37"

	partial void Enter_T__38();
	partial void Leave_T__38();

	// $ANTLR start "T__38"
	[GrammarRule("T__38")]
	private void mT__38()
	{
		Enter_T__38();
		EnterRule("T__38", 4);
		TraceIn("T__38", 4);
		try
		{
			int _type = T__38;
			int _channel = DefaultTokenChannel;
			// Lang2.g:12:7: ( '(' )
			DebugEnterAlt(1);
			// Lang2.g:12:9: '('
			{
			DebugLocation(12, 9);
			Match('('); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__38", 4);
			LeaveRule("T__38", 4);
			Leave_T__38();
		}
	}
	// $ANTLR end "T__38"

	partial void Enter_T__39();
	partial void Leave_T__39();

	// $ANTLR start "T__39"
	[GrammarRule("T__39")]
	private void mT__39()
	{
		Enter_T__39();
		EnterRule("T__39", 5);
		TraceIn("T__39", 5);
		try
		{
			int _type = T__39;
			int _channel = DefaultTokenChannel;
			// Lang2.g:13:7: ( ')' )
			DebugEnterAlt(1);
			// Lang2.g:13:9: ')'
			{
			DebugLocation(13, 9);
			Match(')'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__39", 5);
			LeaveRule("T__39", 5);
			Leave_T__39();
		}
	}
	// $ANTLR end "T__39"

	partial void Enter_T__40();
	partial void Leave_T__40();

	// $ANTLR start "T__40"
	[GrammarRule("T__40")]
	private void mT__40()
	{
		Enter_T__40();
		EnterRule("T__40", 6);
		TraceIn("T__40", 6);
		try
		{
			int _type = T__40;
			int _channel = DefaultTokenChannel;
			// Lang2.g:14:7: ( '[]' )
			DebugEnterAlt(1);
			// Lang2.g:14:9: '[]'
			{
			DebugLocation(14, 9);
			Match("[]"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__40", 6);
			LeaveRule("T__40", 6);
			Leave_T__40();
		}
	}
	// $ANTLR end "T__40"

	partial void Enter_T__41();
	partial void Leave_T__41();

	// $ANTLR start "T__41"
	[GrammarRule("T__41")]
	private void mT__41()
	{
		Enter_T__41();
		EnterRule("T__41", 7);
		TraceIn("T__41", 7);
		try
		{
			int _type = T__41;
			int _channel = DefaultTokenChannel;
			// Lang2.g:15:7: ( '[' )
			DebugEnterAlt(1);
			// Lang2.g:15:9: '['
			{
			DebugLocation(15, 9);
			Match('['); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__41", 7);
			LeaveRule("T__41", 7);
			Leave_T__41();
		}
	}
	// $ANTLR end "T__41"

	partial void Enter_T__42();
	partial void Leave_T__42();

	// $ANTLR start "T__42"
	[GrammarRule("T__42")]
	private void mT__42()
	{
		Enter_T__42();
		EnterRule("T__42", 8);
		TraceIn("T__42", 8);
		try
		{
			int _type = T__42;
			int _channel = DefaultTokenChannel;
			// Lang2.g:16:7: ( ']' )
			DebugEnterAlt(1);
			// Lang2.g:16:9: ']'
			{
			DebugLocation(16, 9);
			Match(']'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__42", 8);
			LeaveRule("T__42", 8);
			Leave_T__42();
		}
	}
	// $ANTLR end "T__42"

	partial void Enter_T__43();
	partial void Leave_T__43();

	// $ANTLR start "T__43"
	[GrammarRule("T__43")]
	private void mT__43()
	{
		Enter_T__43();
		EnterRule("T__43", 9);
		TraceIn("T__43", 9);
		try
		{
			int _type = T__43;
			int _channel = DefaultTokenChannel;
			// Lang2.g:17:7: ( 'void' )
			DebugEnterAlt(1);
			// Lang2.g:17:9: 'void'
			{
			DebugLocation(17, 9);
			Match("void"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__43", 9);
			LeaveRule("T__43", 9);
			Leave_T__43();
		}
	}
	// $ANTLR end "T__43"

	partial void Enter_T__44();
	partial void Leave_T__44();

	// $ANTLR start "T__44"
	[GrammarRule("T__44")]
	private void mT__44()
	{
		Enter_T__44();
		EnterRule("T__44", 10);
		TraceIn("T__44", 10);
		try
		{
			int _type = T__44;
			int _channel = DefaultTokenChannel;
			// Lang2.g:18:7: ( ',' )
			DebugEnterAlt(1);
			// Lang2.g:18:9: ','
			{
			DebugLocation(18, 9);
			Match(','); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__44", 10);
			LeaveRule("T__44", 10);
			Leave_T__44();
		}
	}
	// $ANTLR end "T__44"

	partial void Enter_T__45();
	partial void Leave_T__45();

	// $ANTLR start "T__45"
	[GrammarRule("T__45")]
	private void mT__45()
	{
		Enter_T__45();
		EnterRule("T__45", 11);
		TraceIn("T__45", 11);
		try
		{
			int _type = T__45;
			int _channel = DefaultTokenChannel;
			// Lang2.g:19:7: ( '{' )
			DebugEnterAlt(1);
			// Lang2.g:19:9: '{'
			{
			DebugLocation(19, 9);
			Match('{'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__45", 11);
			LeaveRule("T__45", 11);
			Leave_T__45();
		}
	}
	// $ANTLR end "T__45"

	partial void Enter_T__46();
	partial void Leave_T__46();

	// $ANTLR start "T__46"
	[GrammarRule("T__46")]
	private void mT__46()
	{
		Enter_T__46();
		EnterRule("T__46", 12);
		TraceIn("T__46", 12);
		try
		{
			int _type = T__46;
			int _channel = DefaultTokenChannel;
			// Lang2.g:20:7: ( '}' )
			DebugEnterAlt(1);
			// Lang2.g:20:9: '}'
			{
			DebugLocation(20, 9);
			Match('}'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__46", 12);
			LeaveRule("T__46", 12);
			Leave_T__46();
		}
	}
	// $ANTLR end "T__46"

	partial void Enter_T__47();
	partial void Leave_T__47();

	// $ANTLR start "T__47"
	[GrammarRule("T__47")]
	private void mT__47()
	{
		Enter_T__47();
		EnterRule("T__47", 13);
		TraceIn("T__47", 13);
		try
		{
			int _type = T__47;
			int _channel = DefaultTokenChannel;
			// Lang2.g:21:7: ( 'else' )
			DebugEnterAlt(1);
			// Lang2.g:21:9: 'else'
			{
			DebugLocation(21, 9);
			Match("else"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__47", 13);
			LeaveRule("T__47", 13);
			Leave_T__47();
		}
	}
	// $ANTLR end "T__47"

	partial void Enter_OP_END();
	partial void Leave_OP_END();

	// $ANTLR start "OP_END"
	[GrammarRule("OP_END")]
	private void mOP_END()
	{
		Enter_OP_END();
		EnterRule("OP_END", 14);
		TraceIn("OP_END", 14);
		try
		{
			int _type = OP_END;
			int _channel = DefaultTokenChannel;
			// Lang2.g:29:8: ( ';' )
			DebugEnterAlt(1);
			// Lang2.g:29:10: ';'
			{
			DebugLocation(29, 10);
			Match(';'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("OP_END", 14);
			LeaveRule("OP_END", 14);
			Leave_OP_END();
		}
	}
	// $ANTLR end "OP_END"

	partial void Enter_WS();
	partial void Leave_WS();

	// $ANTLR start "WS"
	[GrammarRule("WS")]
	private void mWS()
	{
		Enter_WS();
		EnterRule("WS", 15);
		TraceIn("WS", 15);
		try
		{
			int _type = WS;
			int _channel = DefaultTokenChannel;
			// Lang2.g:32:3: ( ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+ )
			DebugEnterAlt(1);
			// Lang2.g:33:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
			{
			DebugLocation(33, 3);
			// Lang2.g:33:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
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
					DebugLocation(33, 3);
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

			DebugLocation(33, 41);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WS", 15);
			LeaveRule("WS", 15);
			Leave_WS();
		}
	}
	// $ANTLR end "WS"

	partial void Enter_ADD();
	partial void Leave_ADD();

	// $ANTLR start "ADD"
	[GrammarRule("ADD")]
	private void mADD()
	{
		Enter_ADD();
		EnterRule("ADD", 16);
		TraceIn("ADD", 16);
		try
		{
			int _type = ADD;
			int _channel = DefaultTokenChannel;
			// Lang2.g:38:5: ( '+' )
			DebugEnterAlt(1);
			// Lang2.g:38:7: '+'
			{
			DebugLocation(38, 7);
			Match('+'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ADD", 16);
			LeaveRule("ADD", 16);
			Leave_ADD();
		}
	}
	// $ANTLR end "ADD"

	partial void Enter_REM();
	partial void Leave_REM();

	// $ANTLR start "REM"
	[GrammarRule("REM")]
	private void mREM()
	{
		Enter_REM();
		EnterRule("REM", 17);
		TraceIn("REM", 17);
		try
		{
			int _type = REM;
			int _channel = DefaultTokenChannel;
			// Lang2.g:40:5: ( '-' )
			DebugEnterAlt(1);
			// Lang2.g:40:7: '-'
			{
			DebugLocation(40, 7);
			Match('-'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("REM", 17);
			LeaveRule("REM", 17);
			Leave_REM();
		}
	}
	// $ANTLR end "REM"

	partial void Enter_MULT();
	partial void Leave_MULT();

	// $ANTLR start "MULT"
	[GrammarRule("MULT")]
	private void mMULT()
	{
		Enter_MULT();
		EnterRule("MULT", 18);
		TraceIn("MULT", 18);
		try
		{
			int _type = MULT;
			int _channel = DefaultTokenChannel;
			// Lang2.g:42:6: ( '*' )
			DebugEnterAlt(1);
			// Lang2.g:42:8: '*'
			{
			DebugLocation(42, 8);
			Match('*'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MULT", 18);
			LeaveRule("MULT", 18);
			Leave_MULT();
		}
	}
	// $ANTLR end "MULT"

	partial void Enter_DIV();
	partial void Leave_DIV();

	// $ANTLR start "DIV"
	[GrammarRule("DIV")]
	private void mDIV()
	{
		Enter_DIV();
		EnterRule("DIV", 19);
		TraceIn("DIV", 19);
		try
		{
			int _type = DIV;
			int _channel = DefaultTokenChannel;
			// Lang2.g:44:5: ( '/' )
			DebugEnterAlt(1);
			// Lang2.g:44:7: '/'
			{
			DebugLocation(44, 7);
			Match('/'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DIV", 19);
			LeaveRule("DIV", 19);
			Leave_DIV();
		}
	}
	// $ANTLR end "DIV"

	partial void Enter_ASS();
	partial void Leave_ASS();

	// $ANTLR start "ASS"
	[GrammarRule("ASS")]
	private void mASS()
	{
		Enter_ASS();
		EnterRule("ASS", 20);
		TraceIn("ASS", 20);
		try
		{
			int _type = ASS;
			int _channel = DefaultTokenChannel;
			// Lang2.g:46:5: ( '=' )
			DebugEnterAlt(1);
			// Lang2.g:46:7: '='
			{
			DebugLocation(46, 7);
			Match('='); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ASS", 20);
			LeaveRule("ASS", 20);
			Leave_ASS();
		}
	}
	// $ANTLR end "ASS"

	partial void Enter_DISJUNCTION();
	partial void Leave_DISJUNCTION();

	// $ANTLR start "DISJUNCTION"
	[GrammarRule("DISJUNCTION")]
	private void mDISJUNCTION()
	{
		Enter_DISJUNCTION();
		EnterRule("DISJUNCTION", 21);
		TraceIn("DISJUNCTION", 21);
		try
		{
			int _type = DISJUNCTION;
			int _channel = DefaultTokenChannel;
			// Lang2.g:49:2: ( '&&' )
			DebugEnterAlt(1);
			// Lang2.g:49:4: '&&'
			{
			DebugLocation(49, 4);
			Match("&&"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DISJUNCTION", 21);
			LeaveRule("DISJUNCTION", 21);
			Leave_DISJUNCTION();
		}
	}
	// $ANTLR end "DISJUNCTION"

	partial void Enter_CONJUCTION();
	partial void Leave_CONJUCTION();

	// $ANTLR start "CONJUCTION"
	[GrammarRule("CONJUCTION")]
	private void mCONJUCTION()
	{
		Enter_CONJUCTION();
		EnterRule("CONJUCTION", 22);
		TraceIn("CONJUCTION", 22);
		try
		{
			int _type = CONJUCTION;
			int _channel = DefaultTokenChannel;
			// Lang2.g:52:2: ( '||' )
			DebugEnterAlt(1);
			// Lang2.g:52:4: '||'
			{
			DebugLocation(52, 4);
			Match("||"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("CONJUCTION", 22);
			LeaveRule("CONJUCTION", 22);
			Leave_CONJUCTION();
		}
	}
	// $ANTLR end "CONJUCTION"

	partial void Enter_IS_MORE();
	partial void Leave_IS_MORE();

	// $ANTLR start "IS_MORE"
	[GrammarRule("IS_MORE")]
	private void mIS_MORE()
	{
		Enter_IS_MORE();
		EnterRule("IS_MORE", 23);
		TraceIn("IS_MORE", 23);
		try
		{
			int _type = IS_MORE;
			int _channel = DefaultTokenChannel;
			// Lang2.g:55:9: ( '>' )
			DebugEnterAlt(1);
			// Lang2.g:55:11: '>'
			{
			DebugLocation(55, 11);
			Match('>'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("IS_MORE", 23);
			LeaveRule("IS_MORE", 23);
			Leave_IS_MORE();
		}
	}
	// $ANTLR end "IS_MORE"

	partial void Enter_VITOCHKA();
	partial void Leave_VITOCHKA();

	// $ANTLR start "VITOCHKA"
	[GrammarRule("VITOCHKA")]
	private void mVITOCHKA()
	{
		Enter_VITOCHKA();
		EnterRule("VITOCHKA", 24);
		TraceIn("VITOCHKA", 24);
		try
		{
			int _type = VITOCHKA;
			int _channel = DefaultTokenChannel;
			// Lang2.g:58:10: ( 'vitochka' )
			DebugEnterAlt(1);
			// Lang2.g:58:12: 'vitochka'
			{
			DebugLocation(58, 12);
			Match("vitochka"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("VITOCHKA", 24);
			LeaveRule("VITOCHKA", 24);
			Leave_VITOCHKA();
		}
	}
	// $ANTLR end "VITOCHKA"

	partial void Enter_IS_LESS();
	partial void Leave_IS_LESS();

	// $ANTLR start "IS_LESS"
	[GrammarRule("IS_LESS")]
	private void mIS_LESS()
	{
		Enter_IS_LESS();
		EnterRule("IS_LESS", 25);
		TraceIn("IS_LESS", 25);
		try
		{
			int _type = IS_LESS;
			int _channel = DefaultTokenChannel;
			// Lang2.g:61:9: ( '<' )
			DebugEnterAlt(1);
			// Lang2.g:61:11: '<'
			{
			DebugLocation(61, 11);
			Match('<'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("IS_LESS", 25);
			LeaveRule("IS_LESS", 25);
			Leave_IS_LESS();
		}
	}
	// $ANTLR end "IS_LESS"

	partial void Enter_IS_EQUALLY();
	partial void Leave_IS_EQUALLY();

	// $ANTLR start "IS_EQUALLY"
	[GrammarRule("IS_EQUALLY")]
	private void mIS_EQUALLY()
	{
		Enter_IS_EQUALLY();
		EnterRule("IS_EQUALLY", 26);
		TraceIn("IS_EQUALLY", 26);
		try
		{
			int _type = IS_EQUALLY;
			int _channel = DefaultTokenChannel;
			// Lang2.g:64:12: ( '==' )
			DebugEnterAlt(1);
			// Lang2.g:64:14: '=='
			{
			DebugLocation(64, 14);
			Match("=="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("IS_EQUALLY", 26);
			LeaveRule("IS_EQUALLY", 26);
			Leave_IS_EQUALLY();
		}
	}
	// $ANTLR end "IS_EQUALLY"

	partial void Enter_INVERT();
	partial void Leave_INVERT();

	// $ANTLR start "INVERT"
	[GrammarRule("INVERT")]
	private void mINVERT()
	{
		Enter_INVERT();
		EnterRule("INVERT", 27);
		TraceIn("INVERT", 27);
		try
		{
			int _type = INVERT;
			int _channel = DefaultTokenChannel;
			// Lang2.g:67:8: ( '!' )
			DebugEnterAlt(1);
			// Lang2.g:67:10: '!'
			{
			DebugLocation(67, 10);
			Match('!'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("INVERT", 27);
			LeaveRule("INVERT", 27);
			Leave_INVERT();
		}
	}
	// $ANTLR end "INVERT"

	partial void Enter_IF();
	partial void Leave_IF();

	// $ANTLR start "IF"
	[GrammarRule("IF")]
	private void mIF()
	{
		Enter_IF();
		EnterRule("IF", 28);
		TraceIn("IF", 28);
		try
		{
			int _type = IF;
			int _channel = DefaultTokenChannel;
			// Lang2.g:70:4: ( 'if' )
			DebugEnterAlt(1);
			// Lang2.g:70:6: 'if'
			{
			DebugLocation(70, 6);
			Match("if"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("IF", 28);
			LeaveRule("IF", 28);
			Leave_IF();
		}
	}
	// $ANTLR end "IF"

	partial void Enter_WHILE();
	partial void Leave_WHILE();

	// $ANTLR start "WHILE"
	[GrammarRule("WHILE")]
	private void mWHILE()
	{
		Enter_WHILE();
		EnterRule("WHILE", 29);
		TraceIn("WHILE", 29);
		try
		{
			int _type = WHILE;
			int _channel = DefaultTokenChannel;
			// Lang2.g:73:7: ( 'while' )
			DebugEnterAlt(1);
			// Lang2.g:73:9: 'while'
			{
			DebugLocation(73, 9);
			Match("while"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WHILE", 29);
			LeaveRule("WHILE", 29);
			Leave_WHILE();
		}
	}
	// $ANTLR end "WHILE"

	partial void Enter_DO();
	partial void Leave_DO();

	// $ANTLR start "DO"
	[GrammarRule("DO")]
	private void mDO()
	{
		Enter_DO();
		EnterRule("DO", 30);
		TraceIn("DO", 30);
		try
		{
			int _type = DO;
			int _channel = DefaultTokenChannel;
			// Lang2.g:76:4: ( 'do' )
			DebugEnterAlt(1);
			// Lang2.g:76:6: 'do'
			{
			DebugLocation(76, 6);
			Match("do"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DO", 30);
			LeaveRule("DO", 30);
			Leave_DO();
		}
	}
	// $ANTLR end "DO"

	partial void Enter_FOR();
	partial void Leave_FOR();

	// $ANTLR start "FOR"
	[GrammarRule("FOR")]
	private void mFOR()
	{
		Enter_FOR();
		EnterRule("FOR", 31);
		TraceIn("FOR", 31);
		try
		{
			int _type = FOR;
			int _channel = DefaultTokenChannel;
			// Lang2.g:79:5: ( 'for' )
			DebugEnterAlt(1);
			// Lang2.g:79:7: 'for'
			{
			DebugLocation(79, 7);
			Match("for"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FOR", 31);
			LeaveRule("FOR", 31);
			Leave_FOR();
		}
	}
	// $ANTLR end "FOR"

	partial void Enter_BOOL();
	partial void Leave_BOOL();

	// $ANTLR start "BOOL"
	[GrammarRule("BOOL")]
	private void mBOOL()
	{
		Enter_BOOL();
		EnterRule("BOOL", 32);
		TraceIn("BOOL", 32);
		try
		{
			int _type = BOOL;
			int _channel = DefaultTokenChannel;
			// Lang2.g:82:6: ( 'true' | 'false' )
			int alt2=2;
			try { DebugEnterDecision(2, decisionCanBacktrack[2]);
			int LA2_0 = input.LA(1);

			if ((LA2_0=='t'))
			{
				alt2=1;
			}
			else if ((LA2_0=='f'))
			{
				alt2=2;
			}
			else
			{
				NoViableAltException nvae = new NoViableAltException("", 2, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(2); }
			switch (alt2)
			{
			case 1:
				DebugEnterAlt(1);
				// Lang2.g:82:8: 'true'
				{
				DebugLocation(82, 8);
				Match("true"); 


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Lang2.g:82:15: 'false'
				{
				DebugLocation(82, 15);
				Match("false"); 


				}
				break;

			}
			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("BOOL", 32);
			LeaveRule("BOOL", 32);
			Leave_BOOL();
		}
	}
	// $ANTLR end "BOOL"

	partial void Enter_VAR();
	partial void Leave_VAR();

	// $ANTLR start "VAR"
	[GrammarRule("VAR")]
	private void mVAR()
	{
		Enter_VAR();
		EnterRule("VAR", 33);
		TraceIn("VAR", 33);
		try
		{
			int _type = VAR;
			int _channel = DefaultTokenChannel;
			// Lang2.g:85:5: ( ( 'a' .. 'z' | 'A' .. 'Z' )+ )
			DebugEnterAlt(1);
			// Lang2.g:85:7: ( 'a' .. 'z' | 'A' .. 'Z' )+
			{
			DebugLocation(85, 7);
			// Lang2.g:85:7: ( 'a' .. 'z' | 'A' .. 'Z' )+
			int cnt3=0;
			try { DebugEnterSubRule(3);
			while (true)
			{
				int alt3=2;
				try { DebugEnterDecision(3, decisionCanBacktrack[3]);
				int LA3_0 = input.LA(1);

				if (((LA3_0>='A' && LA3_0<='Z')||(LA3_0>='a' && LA3_0<='z')))
				{
					alt3=1;
				}


				} finally { DebugExitDecision(3); }
				switch (alt3)
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:
					{
					DebugLocation(85, 7);
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
			TraceOut("VAR", 33);
			LeaveRule("VAR", 33);
			Leave_VAR();
		}
	}
	// $ANTLR end "VAR"

	partial void Enter_INT();
	partial void Leave_INT();

	// $ANTLR start "INT"
	[GrammarRule("INT")]
	private void mINT()
	{
		Enter_INT();
		EnterRule("INT", 34);
		TraceIn("INT", 34);
		try
		{
			int _type = INT;
			int _channel = DefaultTokenChannel;
			// Lang2.g:88:5: ( ( '0' .. '9' )+ )
			DebugEnterAlt(1);
			// Lang2.g:88:7: ( '0' .. '9' )+
			{
			DebugLocation(88, 7);
			// Lang2.g:88:7: ( '0' .. '9' )+
			int cnt4=0;
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=2;
				try { DebugEnterDecision(4, decisionCanBacktrack[4]);
				int LA4_0 = input.LA(1);

				if (((LA4_0>='0' && LA4_0<='9')))
				{
					alt4=1;
				}


				} finally { DebugExitDecision(4); }
				switch (alt4)
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:88:8: '0' .. '9'
					{
					DebugLocation(88, 8);
					MatchRange('0','9'); 

					}
					break;

				default:
					if (cnt4 >= 1)
						goto loop4;

					EarlyExitException eee4 = new EarlyExitException( 4, input );
					DebugRecognitionException(eee4);
					throw eee4;
				}
				cnt4++;
			}
			loop4:
				;

			} finally { DebugExitSubRule(4); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("INT", 34);
			LeaveRule("INT", 34);
			Leave_INT();
		}
	}
	// $ANTLR end "INT"

	partial void Enter_STRING();
	partial void Leave_STRING();

	// $ANTLR start "STRING"
	[GrammarRule("STRING")]
	private void mSTRING()
	{
		Enter_STRING();
		EnterRule("STRING", 35);
		TraceIn("STRING", 35);
		try
		{
			int _type = STRING;
			int _channel = DefaultTokenChannel;
			// Lang2.g:91:8: ( '\"' ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '' | ' ' )* '\"' )
			DebugEnterAlt(1);
			// Lang2.g:91:10: '\"' ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '' | ' ' )* '\"'
			{
			DebugLocation(91, 13);
			Match('\"'); 
			DebugLocation(91, 14);
			// Lang2.g:91:14: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '' | ' ' )*
			try { DebugEnterSubRule(5);
			while (true)
			{
				int alt5=2;
				try { DebugEnterDecision(5, decisionCanBacktrack[5]);
				int LA5_0 = input.LA(1);

				if ((LA5_0=='O'||LA5_0==' '||(LA5_0>='0' && LA5_0<='9')||(LA5_0>='A' && LA5_0<='Z')||(LA5_0>='a' && LA5_0<='z')))
				{
					alt5=1;
				}


				} finally { DebugExitDecision(5); }
				switch ( alt5 )
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:
					{
					DebugLocation(91, 14);
					if (input.LA(1)=='O'||input.LA(1)==' '||(input.LA(1)>='0' && input.LA(1)<='9')||(input.LA(1)>='A' && input.LA(1)<='Z')||(input.LA(1)>='a' && input.LA(1)<='z'))
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
					goto loop5;
				}
			}

			loop5:
				;

			} finally { DebugExitSubRule(5); }

			DebugLocation(91, 53);
			Match('\"'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("STRING", 35);
			LeaveRule("STRING", 35);
			Leave_STRING();
		}
	}
	// $ANTLR end "STRING"

	public override void mTokens()
	{
		// Lang2.g:1:8: ( T__35 | T__36 | T__37 | T__38 | T__39 | T__40 | T__41 | T__42 | T__43 | T__44 | T__45 | T__46 | T__47 | OP_END | WS | ADD | REM | MULT | DIV | ASS | DISJUNCTION | CONJUCTION | IS_MORE | VITOCHKA | IS_LESS | IS_EQUALLY | INVERT | IF | WHILE | DO | FOR | BOOL | VAR | INT | STRING )
		int alt6=35;
		try { DebugEnterDecision(6, decisionCanBacktrack[6]);
		try
		{
			alt6 = dfa6.Predict(input);
		}
		catch (NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
			throw;
		}
		} finally { DebugExitDecision(6); }
		switch (alt6)
		{
		case 1:
			DebugEnterAlt(1);
			// Lang2.g:1:10: T__35
			{
			DebugLocation(1, 10);
			mT__35(); 

			}
			break;
		case 2:
			DebugEnterAlt(2);
			// Lang2.g:1:16: T__36
			{
			DebugLocation(1, 16);
			mT__36(); 

			}
			break;
		case 3:
			DebugEnterAlt(3);
			// Lang2.g:1:22: T__37
			{
			DebugLocation(1, 22);
			mT__37(); 

			}
			break;
		case 4:
			DebugEnterAlt(4);
			// Lang2.g:1:28: T__38
			{
			DebugLocation(1, 28);
			mT__38(); 

			}
			break;
		case 5:
			DebugEnterAlt(5);
			// Lang2.g:1:34: T__39
			{
			DebugLocation(1, 34);
			mT__39(); 

			}
			break;
		case 6:
			DebugEnterAlt(6);
			// Lang2.g:1:40: T__40
			{
			DebugLocation(1, 40);
			mT__40(); 

			}
			break;
		case 7:
			DebugEnterAlt(7);
			// Lang2.g:1:46: T__41
			{
			DebugLocation(1, 46);
			mT__41(); 

			}
			break;
		case 8:
			DebugEnterAlt(8);
			// Lang2.g:1:52: T__42
			{
			DebugLocation(1, 52);
			mT__42(); 

			}
			break;
		case 9:
			DebugEnterAlt(9);
			// Lang2.g:1:58: T__43
			{
			DebugLocation(1, 58);
			mT__43(); 

			}
			break;
		case 10:
			DebugEnterAlt(10);
			// Lang2.g:1:64: T__44
			{
			DebugLocation(1, 64);
			mT__44(); 

			}
			break;
		case 11:
			DebugEnterAlt(11);
			// Lang2.g:1:70: T__45
			{
			DebugLocation(1, 70);
			mT__45(); 

			}
			break;
		case 12:
			DebugEnterAlt(12);
			// Lang2.g:1:76: T__46
			{
			DebugLocation(1, 76);
			mT__46(); 

			}
			break;
		case 13:
			DebugEnterAlt(13);
			// Lang2.g:1:82: T__47
			{
			DebugLocation(1, 82);
			mT__47(); 

			}
			break;
		case 14:
			DebugEnterAlt(14);
			// Lang2.g:1:88: OP_END
			{
			DebugLocation(1, 88);
			mOP_END(); 

			}
			break;
		case 15:
			DebugEnterAlt(15);
			// Lang2.g:1:95: WS
			{
			DebugLocation(1, 95);
			mWS(); 

			}
			break;
		case 16:
			DebugEnterAlt(16);
			// Lang2.g:1:98: ADD
			{
			DebugLocation(1, 98);
			mADD(); 

			}
			break;
		case 17:
			DebugEnterAlt(17);
			// Lang2.g:1:102: REM
			{
			DebugLocation(1, 102);
			mREM(); 

			}
			break;
		case 18:
			DebugEnterAlt(18);
			// Lang2.g:1:106: MULT
			{
			DebugLocation(1, 106);
			mMULT(); 

			}
			break;
		case 19:
			DebugEnterAlt(19);
			// Lang2.g:1:111: DIV
			{
			DebugLocation(1, 111);
			mDIV(); 

			}
			break;
		case 20:
			DebugEnterAlt(20);
			// Lang2.g:1:115: ASS
			{
			DebugLocation(1, 115);
			mASS(); 

			}
			break;
		case 21:
			DebugEnterAlt(21);
			// Lang2.g:1:119: DISJUNCTION
			{
			DebugLocation(1, 119);
			mDISJUNCTION(); 

			}
			break;
		case 22:
			DebugEnterAlt(22);
			// Lang2.g:1:131: CONJUCTION
			{
			DebugLocation(1, 131);
			mCONJUCTION(); 

			}
			break;
		case 23:
			DebugEnterAlt(23);
			// Lang2.g:1:142: IS_MORE
			{
			DebugLocation(1, 142);
			mIS_MORE(); 

			}
			break;
		case 24:
			DebugEnterAlt(24);
			// Lang2.g:1:150: VITOCHKA
			{
			DebugLocation(1, 150);
			mVITOCHKA(); 

			}
			break;
		case 25:
			DebugEnterAlt(25);
			// Lang2.g:1:159: IS_LESS
			{
			DebugLocation(1, 159);
			mIS_LESS(); 

			}
			break;
		case 26:
			DebugEnterAlt(26);
			// Lang2.g:1:167: IS_EQUALLY
			{
			DebugLocation(1, 167);
			mIS_EQUALLY(); 

			}
			break;
		case 27:
			DebugEnterAlt(27);
			// Lang2.g:1:178: INVERT
			{
			DebugLocation(1, 178);
			mINVERT(); 

			}
			break;
		case 28:
			DebugEnterAlt(28);
			// Lang2.g:1:185: IF
			{
			DebugLocation(1, 185);
			mIF(); 

			}
			break;
		case 29:
			DebugEnterAlt(29);
			// Lang2.g:1:188: WHILE
			{
			DebugLocation(1, 188);
			mWHILE(); 

			}
			break;
		case 30:
			DebugEnterAlt(30);
			// Lang2.g:1:194: DO
			{
			DebugLocation(1, 194);
			mDO(); 

			}
			break;
		case 31:
			DebugEnterAlt(31);
			// Lang2.g:1:197: FOR
			{
			DebugLocation(1, 197);
			mFOR(); 

			}
			break;
		case 32:
			DebugEnterAlt(32);
			// Lang2.g:1:201: BOOL
			{
			DebugLocation(1, 201);
			mBOOL(); 

			}
			break;
		case 33:
			DebugEnterAlt(33);
			// Lang2.g:1:206: VAR
			{
			DebugLocation(1, 206);
			mVAR(); 

			}
			break;
		case 34:
			DebugEnterAlt(34);
			// Lang2.g:1:210: INT
			{
			DebugLocation(1, 210);
			mINT(); 

			}
			break;
		case 35:
			DebugEnterAlt(35);
			// Lang2.g:1:214: STRING
			{
			DebugLocation(1, 214);
			mSTRING(); 

			}
			break;

		}

	}


	#region DFA
	DFA6 dfa6;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa6 = new DFA6(this);
	}

	private class DFA6 : DFA
	{
		private const string DFA6_eotS =
			"\x1\xFFFF\x3\x1D\x2\xFFFF\x1\x25\x1\xFFFF\x1\x1D\x3\xFFFF\x1\x1D\x6"+
			"\xFFFF\x1\x2A\x5\xFFFF\x4\x1D\x3\xFFFF\x1\x1D\x1\x31\x2\x1D\x2\xFFFF"+
			"\x3\x1D\x2\xFFFF\x1\x1D\x1\x38\x3\x1D\x1\x3C\x1\xFFFF\x6\x1D\x1\xFFFF"+
			"\x1\x43\x2\x1D\x1\xFFFF\x1\x46\x1\x1D\x1\x48\x1\x1D\x1\x4A\x1\x1D\x1"+
			"\xFFFF\x1\x1D\x1\x4D\x1\xFFFF\x1\x1D\x1\xFFFF\x1\x1D\x1\xFFFF\x1\x50"+
			"\x1\x4D\x1\xFFFF\x1\x51\x1\x1D\x2\xFFFF\x1\x1D\x1\x54\x1\xFFFF";
		private const string DFA6_eofS =
			"\x55\xFFFF";
		private const string DFA6_minS =
			"\x1\x9\x1\x66\x1\x6F\x1\x74\x2\xFFFF\x1\x5D\x1\xFFFF\x1\x69\x3\xFFFF"+
			"\x1\x6C\x6\xFFFF\x1\x3D\x5\xFFFF\x1\x68\x1\x6F\x1\x61\x1\x72\x3\xFFFF"+
			"\x1\x74\x1\x41\x1\x6F\x1\x72\x2\xFFFF\x1\x69\x1\x74\x1\x73\x2\xFFFF\x1"+
			"\x69\x1\x41\x1\x72\x1\x6C\x1\x75\x1\x41\x1\xFFFF\x1\x6C\x1\x69\x1\x64"+
			"\x1\x6F\x1\x65\x1\x6C\x1\xFFFF\x1\x41\x1\x73\x1\x65\x1\xFFFF\x1\x41\x1"+
			"\x6E\x1\x41\x1\x63\x1\x41\x1\x65\x1\xFFFF\x1\x65\x1\x41\x1\xFFFF\x1\x67"+
			"\x1\xFFFF\x1\x68\x1\xFFFF\x2\x41\x1\xFFFF\x1\x41\x1\x6B\x2\xFFFF\x1\x61"+
			"\x1\x41\x1\xFFFF";
		private const string DFA6_maxS =
			"\x1\x7D\x1\x6E\x1\x6F\x1\x74\x2\xFFFF\x1\x5D\x1\xFFFF\x1\x6F\x3\xFFFF"+
			"\x1\x6C\x6\xFFFF\x1\x3D\x5\xFFFF\x1\x68\x2\x6F\x1\x72\x3\xFFFF\x1\x74"+
			"\x1\x7A\x1\x6F\x1\x72\x2\xFFFF\x1\x69\x1\x74\x1\x73\x2\xFFFF\x1\x69\x1"+
			"\x7A\x1\x72\x1\x6C\x1\x75\x1\x7A\x1\xFFFF\x1\x6C\x1\x69\x1\x64\x1\x6F"+
			"\x1\x65\x1\x6C\x1\xFFFF\x1\x7A\x1\x73\x1\x65\x1\xFFFF\x1\x7A\x1\x6E\x1"+
			"\x7A\x1\x63\x1\x7A\x1\x65\x1\xFFFF\x1\x65\x1\x7A\x1\xFFFF\x1\x67\x1\xFFFF"+
			"\x1\x68\x1\xFFFF\x2\x7A\x1\xFFFF\x1\x7A\x1\x6B\x2\xFFFF\x1\x61\x1\x7A"+
			"\x1\xFFFF";
		private const string DFA6_acceptS =
			"\x4\xFFFF\x1\x4\x1\x5\x1\xFFFF\x1\x8\x1\xFFFF\x1\xA\x1\xB\x1\xC\x1\xFFFF"+
			"\x1\xE\x1\xF\x1\x10\x1\x11\x1\x12\x1\x13\x1\xFFFF\x1\x15\x1\x16\x1\x17"+
			"\x1\x19\x1\x1B\x4\xFFFF\x1\x21\x1\x22\x1\x23\x4\xFFFF\x1\x6\x1\x7\x3"+
			"\xFFFF\x1\x1A\x1\x14\x6\xFFFF\x1\x1C\x6\xFFFF\x1\x1E\x3\xFFFF\x1\x1\x6"+
			"\xFFFF\x1\x1F\x2\xFFFF\x1\x2\x1\xFFFF\x1\x9\x1\xFFFF\x1\xD\x2\xFFFF\x1"+
			"\x20\x2\xFFFF\x1\x1D\x1\x3\x2\xFFFF\x1\x18";
		private const string DFA6_specialS =
			"\x55\xFFFF}>";
		private static readonly string[] DFA6_transitionS =
			{
				"\x2\xE\x1\xFFFF\x2\xE\x12\xFFFF\x1\xE\x1\x18\x1\x1F\x3\xFFFF\x1\x14"+
				"\x1\xFFFF\x1\x4\x1\x5\x1\x11\x1\xF\x1\x9\x1\x10\x1\xFFFF\x1\x12\xA\x1E"+
				"\x1\xFFFF\x1\xD\x1\x17\x1\x13\x1\x16\x2\xFFFF\x1A\x1D\x1\x6\x1\xFFFF"+
				"\x1\x7\x3\xFFFF\x1\x1D\x1\x2\x1\x1D\x1\x1A\x1\xC\x1\x1B\x2\x1D\x1\x1"+
				"\x9\x1D\x1\x3\x1\x1C\x1\x1D\x1\x8\x1\x19\x3\x1D\x1\xA\x1\x15\x1\xB",
				"\x1\x21\x7\xFFFF\x1\x20",
				"\x1\x22",
				"\x1\x23",
				"",
				"",
				"\x1\x24",
				"",
				"\x1\x27\x5\xFFFF\x1\x26",
				"",
				"",
				"",
				"\x1\x28",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x29",
				"",
				"",
				"",
				"",
				"",
				"\x1\x2B",
				"\x1\x2C",
				"\x1\x2E\xD\xFFFF\x1\x2D",
				"\x1\x2F",
				"",
				"",
				"",
				"\x1\x30",
				"\x1A\x1D\x6\xFFFF\x1A\x1D",
				"\x1\x32",
				"\x1\x33",
				"",
				"",
				"\x1\x34",
				"\x1\x35",
				"\x1\x36",
				"",
				"",
				"\x1\x37",
				"\x1A\x1D\x6\xFFFF\x1A\x1D",
				"\x1\x39",
				"\x1\x3A",
				"\x1\x3B",
				"\x1A\x1D\x6\xFFFF\x1A\x1D",
				"",
				"\x1\x3D",
				"\x1\x3E",
				"\x1\x3F",
				"\x1\x40",
				"\x1\x41",
				"\x1\x42",
				"",
				"\x1A\x1D\x6\xFFFF\x1A\x1D",
				"\x1\x44",
				"\x1\x45",
				"",
				"\x1A\x1D\x6\xFFFF\x1A\x1D",
				"\x1\x47",
				"\x1A\x1D\x6\xFFFF\x1A\x1D",
				"\x1\x49",
				"\x1A\x1D\x6\xFFFF\x1A\x1D",
				"\x1\x4B",
				"",
				"\x1\x4C",
				"\x1A\x1D\x6\xFFFF\x1A\x1D",
				"",
				"\x1\x4E",
				"",
				"\x1\x4F",
				"",
				"\x1A\x1D\x6\xFFFF\x1A\x1D",
				"\x1A\x1D\x6\xFFFF\x1A\x1D",
				"",
				"\x1A\x1D\x6\xFFFF\x1A\x1D",
				"\x1\x52",
				"",
				"",
				"\x1\x53",
				"\x1A\x1D\x6\xFFFF\x1A\x1D",
				""
			};

		private static readonly short[] DFA6_eot = DFA.UnpackEncodedString(DFA6_eotS);
		private static readonly short[] DFA6_eof = DFA.UnpackEncodedString(DFA6_eofS);
		private static readonly char[] DFA6_min = DFA.UnpackEncodedStringToUnsignedChars(DFA6_minS);
		private static readonly char[] DFA6_max = DFA.UnpackEncodedStringToUnsignedChars(DFA6_maxS);
		private static readonly short[] DFA6_accept = DFA.UnpackEncodedString(DFA6_acceptS);
		private static readonly short[] DFA6_special = DFA.UnpackEncodedString(DFA6_specialS);
		private static readonly short[][] DFA6_transition;

		static DFA6()
		{
			int numStates = DFA6_transitionS.Length;
			DFA6_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA6_transition[i] = DFA.UnpackEncodedString(DFA6_transitionS[i]);
			}
		}

		public DFA6( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 6;
			this.eot = DFA6_eot;
			this.eof = DFA6_eof;
			this.min = DFA6_min;
			this.max = DFA6_max;
			this.accept = DFA6_accept;
			this.special = DFA6_special;
			this.transition = DFA6_transition;
		}

		public override string Description { get { return "1:1: Tokens : ( T__35 | T__36 | T__37 | T__38 | T__39 | T__40 | T__41 | T__42 | T__43 | T__44 | T__45 | T__46 | T__47 | OP_END | WS | ADD | REM | MULT | DIV | ASS | DISJUNCTION | CONJUCTION | IS_MORE | VITOCHKA | IS_LESS | IS_EQUALLY | INVERT | IF | WHILE | DO | FOR | BOOL | VAR | INT | STRING );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

 
	#endregion

}

} // namespace Lang2
