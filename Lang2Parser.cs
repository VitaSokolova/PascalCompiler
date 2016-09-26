// $ANTLR 3.3 Nov 30, 2010 12:50:56 Lang2.g 2016-09-25 16:38:58

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162


	using System;


using System.Collections.Generic;
using Antlr.Runtime;
using Stack = System.Collections.Generic.Stack<object>;
using List = System.Collections.IList;
using ArrayList = System.Collections.Generic.List<object>;


using Antlr.Runtime.Tree;
using RewriteRuleITokenStream = Antlr.Runtime.Tree.RewriteRuleTokenStream;

namespace Lang2
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:50:56")]
[System.CLSCompliant(false)]
public partial class Lang2Parser : Antlr.Runtime.Parser
{
	internal static readonly string[] tokenNames = new string[] {
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "PROGRAM", "VARDECL", "FUNC_DECL", "FUNC_CALL", "ARR_DECL", "ARR_CALL", "ARGS_RULE", "FUNC_BODY", "EMPTY", "OP_END", "WS", "ADD", "REM", "MULT", "DIV", "ASS", "DISJUNCTION", "CONJUCTION", "IS_MORE", "VITOCHKA", "IS_LESS", "IS_EQUALLY", "INVERT", "IF", "WHILE", "DO", "FOR", "BOOL", "VAR", "INT", "STRING", "'int'", "'bool'", "'string'", "'('", "')'", "'[]'", "'['", "']'", "'void'", "','", "'{'", "'}'", "'else'"
	};
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

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				false, false, false, false, false, false, false, false, false, false, 
				false, false, false, false, false, false, false, false, false, false, 
				false, false, false, false, false, false, false, false, false, false, 
				false, false
			};
	#else
		private static readonly bool[] decisionCanBacktrack = new bool[0];
	#endif
	public Lang2Parser( ITokenStream input )
		: this( input, new RecognizerSharedState() )
	{
	}
	public Lang2Parser(ITokenStream input, RecognizerSharedState state)
		: base(input, state)
	{
		ITreeAdaptor treeAdaptor = null;
		CreateTreeAdaptor(ref treeAdaptor);
		TreeAdaptor = treeAdaptor ?? new CommonTreeAdaptor();

		OnCreated();
	}
		
	// Implement this function in your helper file to use a custom tree adaptor
	partial void CreateTreeAdaptor(ref ITreeAdaptor adaptor);

	private ITreeAdaptor adaptor;

	public ITreeAdaptor TreeAdaptor
	{
		get
		{
			return adaptor;
		}
		set
		{
			this.adaptor = value;
		}
	}

	public override string[] TokenNames { get { return Lang2Parser.tokenNames; } }
	public override string GrammarFileName { get { return "Lang2.g"; } }


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	#region Rules
	public class stringGroup_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_stringGroup();
	partial void Leave_stringGroup();

	// $ANTLR start "stringGroup"
	// Lang2.g:96:1: stringGroup : ( STRING | VAR );
	[GrammarRule("stringGroup")]
	private Lang2Parser.stringGroup_return stringGroup()
	{
		Enter_stringGroup();
		EnterRule("stringGroup", 1);
		TraceIn("stringGroup", 1);
		Lang2Parser.stringGroup_return retval = new Lang2Parser.stringGroup_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set1=null;

		object set1_tree=null;

		try { DebugEnterRule(GrammarFileName, "stringGroup");
		DebugLocation(96, 1);
		try
		{
			// Lang2.g:97:2: ( STRING | VAR )
			DebugEnterAlt(1);
			// Lang2.g:
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(97, 2);
			set1=(IToken)input.LT(1);
			if (input.LA(1)==VAR||input.LA(1)==STRING)
			{
				input.Consume();
				adaptor.AddChild(root_0, (object)adaptor.Create(set1));
				state.errorRecovery=false;
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("stringGroup", 1);
			LeaveRule("stringGroup", 1);
			Leave_stringGroup();
		}
		DebugLocation(99, 1);
		} finally { DebugExitRule(GrammarFileName, "stringGroup"); }
		return retval;

	}
	// $ANTLR end "stringGroup"

	public class stringExpr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_stringExpr();
	partial void Leave_stringExpr();

	// $ANTLR start "stringExpr"
	// Lang2.g:101:1: stringExpr : stringGroup ( ADD stringGroup )* ;
	[GrammarRule("stringExpr")]
	private Lang2Parser.stringExpr_return stringExpr()
	{
		Enter_stringExpr();
		EnterRule("stringExpr", 2);
		TraceIn("stringExpr", 2);
		Lang2Parser.stringExpr_return retval = new Lang2Parser.stringExpr_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ADD3=null;
		Lang2Parser.stringGroup_return stringGroup2 = default(Lang2Parser.stringGroup_return);
		Lang2Parser.stringGroup_return stringGroup4 = default(Lang2Parser.stringGroup_return);

		object ADD3_tree=null;

		try { DebugEnterRule(GrammarFileName, "stringExpr");
		DebugLocation(101, 1);
		try
		{
			// Lang2.g:102:2: ( stringGroup ( ADD stringGroup )* )
			DebugEnterAlt(1);
			// Lang2.g:102:4: stringGroup ( ADD stringGroup )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(102, 4);
			PushFollow(Follow._stringGroup_in_stringExpr394);
			stringGroup2=stringGroup();
			PopFollow();

			adaptor.AddChild(root_0, stringGroup2.Tree);
			DebugLocation(102, 15);
			// Lang2.g:102:15: ( ADD stringGroup )*
			try { DebugEnterSubRule(1);
			while (true)
			{
				int alt1=2;
				try { DebugEnterDecision(1, decisionCanBacktrack[1]);
				int LA1_0 = input.LA(1);

				if ((LA1_0==ADD))
				{
					alt1=1;
				}


				} finally { DebugExitDecision(1); }
				switch ( alt1 )
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:102:16: ADD stringGroup
					{
					DebugLocation(102, 19);
					ADD3=(IToken)Match(input,ADD,Follow._ADD_in_stringExpr396); 
					ADD3_tree = (object)adaptor.Create(ADD3);
					root_0 = (object)adaptor.BecomeRoot(ADD3_tree, root_0);

					DebugLocation(102, 20);
					PushFollow(Follow._stringGroup_in_stringExpr398);
					stringGroup4=stringGroup();
					PopFollow();

					adaptor.AddChild(root_0, stringGroup4.Tree);

					}
					break;

				default:
					goto loop1;
				}
			}

			loop1:
				;

			} finally { DebugExitSubRule(1); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("stringExpr", 2);
			LeaveRule("stringExpr", 2);
			Leave_stringExpr();
		}
		DebugLocation(103, 1);
		} finally { DebugExitRule(GrammarFileName, "stringExpr"); }
		return retval;

	}
	// $ANTLR end "stringExpr"

	public class typeDecl_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_typeDecl();
	partial void Leave_typeDecl();

	// $ANTLR start "typeDecl"
	// Lang2.g:106:1: typeDecl : ( 'int' | 'bool' | 'string' );
	[GrammarRule("typeDecl")]
	private Lang2Parser.typeDecl_return typeDecl()
	{
		Enter_typeDecl();
		EnterRule("typeDecl", 3);
		TraceIn("typeDecl", 3);
		Lang2Parser.typeDecl_return retval = new Lang2Parser.typeDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set5=null;

		object set5_tree=null;

		try { DebugEnterRule(GrammarFileName, "typeDecl");
		DebugLocation(106, 2);
		try
		{
			// Lang2.g:106:9: ( 'int' | 'bool' | 'string' )
			DebugEnterAlt(1);
			// Lang2.g:
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(106, 9);
			set5=(IToken)input.LT(1);
			if ((input.LA(1)>=35 && input.LA(1)<=37))
			{
				input.Consume();
				adaptor.AddChild(root_0, (object)adaptor.Create(set5));
				state.errorRecovery=false;
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("typeDecl", 3);
			LeaveRule("typeDecl", 3);
			Leave_typeDecl();
		}
		DebugLocation(109, 2);
		} finally { DebugExitRule(GrammarFileName, "typeDecl"); }
		return retval;

	}
	// $ANTLR end "typeDecl"

	public class boolGroup_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_boolGroup();
	partial void Leave_boolGroup();

	// $ANTLR start "boolGroup"
	// Lang2.g:112:1: boolGroup : ( BOOL | VAR );
	[GrammarRule("boolGroup")]
	private Lang2Parser.boolGroup_return boolGroup()
	{
		Enter_boolGroup();
		EnterRule("boolGroup", 4);
		TraceIn("boolGroup", 4);
		Lang2Parser.boolGroup_return retval = new Lang2Parser.boolGroup_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set6=null;

		object set6_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolGroup");
		DebugLocation(112, 1);
		try
		{
			// Lang2.g:113:2: ( BOOL | VAR )
			DebugEnterAlt(1);
			// Lang2.g:
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(113, 2);
			set6=(IToken)input.LT(1);
			if ((input.LA(1)>=BOOL && input.LA(1)<=VAR))
			{
				input.Consume();
				adaptor.AddChild(root_0, (object)adaptor.Create(set6));
				state.errorRecovery=false;
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("boolGroup", 4);
			LeaveRule("boolGroup", 4);
			Leave_boolGroup();
		}
		DebugLocation(116, 1);
		} finally { DebugExitRule(GrammarFileName, "boolGroup"); }
		return retval;

	}
	// $ANTLR end "boolGroup"

	public class boolElse_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_boolElse();
	partial void Leave_boolElse();

	// $ANTLR start "boolElse"
	// Lang2.g:118:1: boolElse : boolGroup ( ( IS_MORE | IS_LESS | IS_EQUALLY ) boolGroup ) ;
	[GrammarRule("boolElse")]
	private Lang2Parser.boolElse_return boolElse()
	{
		Enter_boolElse();
		EnterRule("boolElse", 5);
		TraceIn("boolElse", 5);
		Lang2Parser.boolElse_return retval = new Lang2Parser.boolElse_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set8=null;
		Lang2Parser.boolGroup_return boolGroup7 = default(Lang2Parser.boolGroup_return);
		Lang2Parser.boolGroup_return boolGroup9 = default(Lang2Parser.boolGroup_return);

		object set8_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolElse");
		DebugLocation(118, 59);
		try
		{
			// Lang2.g:118:9: ( boolGroup ( ( IS_MORE | IS_LESS | IS_EQUALLY ) boolGroup ) )
			DebugEnterAlt(1);
			// Lang2.g:118:11: boolGroup ( ( IS_MORE | IS_LESS | IS_EQUALLY ) boolGroup )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(118, 11);
			PushFollow(Follow._boolGroup_in_boolElse453);
			boolGroup7=boolGroup();
			PopFollow();

			adaptor.AddChild(root_0, boolGroup7.Tree);
			DebugLocation(118, 20);
			// Lang2.g:118:20: ( ( IS_MORE | IS_LESS | IS_EQUALLY ) boolGroup )
			DebugEnterAlt(1);
			// Lang2.g:118:21: ( IS_MORE | IS_LESS | IS_EQUALLY ) boolGroup
			{
			DebugLocation(118, 21);
			set8=(IToken)input.LT(1);
			set8=(IToken)input.LT(1);
			if (input.LA(1)==IS_MORE||(input.LA(1)>=IS_LESS && input.LA(1)<=IS_EQUALLY))
			{
				input.Consume();
				root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set8), root_0);
				state.errorRecovery=false;
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}

			DebugLocation(118, 50);
			PushFollow(Follow._boolGroup_in_boolElse463);
			boolGroup9=boolGroup();
			PopFollow();

			adaptor.AddChild(root_0, boolGroup9.Tree);

			}


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("boolElse", 5);
			LeaveRule("boolElse", 5);
			Leave_boolElse();
		}
		DebugLocation(118, 59);
		} finally { DebugExitRule(GrammarFileName, "boolElse"); }
		return retval;

	}
	// $ANTLR end "boolElse"

	public class boolAdd_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_boolAdd();
	partial void Leave_boolAdd();

	// $ANTLR start "boolAdd"
	// Lang2.g:120:1: boolAdd : boolElse ( CONJUCTION boolElse )* ;
	[GrammarRule("boolAdd")]
	private Lang2Parser.boolAdd_return boolAdd()
	{
		Enter_boolAdd();
		EnterRule("boolAdd", 6);
		TraceIn("boolAdd", 6);
		Lang2Parser.boolAdd_return retval = new Lang2Parser.boolAdd_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken CONJUCTION11=null;
		Lang2Parser.boolElse_return boolElse10 = default(Lang2Parser.boolElse_return);
		Lang2Parser.boolElse_return boolElse12 = default(Lang2Parser.boolElse_return);

		object CONJUCTION11_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolAdd");
		DebugLocation(120, 2);
		try
		{
			// Lang2.g:120:9: ( boolElse ( CONJUCTION boolElse )* )
			DebugEnterAlt(1);
			// Lang2.g:120:11: boolElse ( CONJUCTION boolElse )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(120, 11);
			PushFollow(Follow._boolElse_in_boolAdd472);
			boolElse10=boolElse();
			PopFollow();

			adaptor.AddChild(root_0, boolElse10.Tree);
			DebugLocation(120, 19);
			// Lang2.g:120:19: ( CONJUCTION boolElse )*
			try { DebugEnterSubRule(2);
			while (true)
			{
				int alt2=2;
				try { DebugEnterDecision(2, decisionCanBacktrack[2]);
				int LA2_0 = input.LA(1);

				if ((LA2_0==CONJUCTION))
				{
					alt2=1;
				}


				} finally { DebugExitDecision(2); }
				switch ( alt2 )
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:120:20: CONJUCTION boolElse
					{
					DebugLocation(120, 30);
					CONJUCTION11=(IToken)Match(input,CONJUCTION,Follow._CONJUCTION_in_boolAdd474); 
					CONJUCTION11_tree = (object)adaptor.Create(CONJUCTION11);
					root_0 = (object)adaptor.BecomeRoot(CONJUCTION11_tree, root_0);

					DebugLocation(120, 31);
					PushFollow(Follow._boolElse_in_boolAdd476);
					boolElse12=boolElse();
					PopFollow();

					adaptor.AddChild(root_0, boolElse12.Tree);

					}
					break;

				default:
					goto loop2;
				}
			}

			loop2:
				;

			} finally { DebugExitSubRule(2); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("boolAdd", 6);
			LeaveRule("boolAdd", 6);
			Leave_boolAdd();
		}
		DebugLocation(121, 2);
		} finally { DebugExitRule(GrammarFileName, "boolAdd"); }
		return retval;

	}
	// $ANTLR end "boolAdd"

	public class boolAnd_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_boolAnd();
	partial void Leave_boolAnd();

	// $ANTLR start "boolAnd"
	// Lang2.g:123:1: boolAnd : boolAdd ( DISJUNCTION boolAdd )* ;
	[GrammarRule("boolAnd")]
	private Lang2Parser.boolAnd_return boolAnd()
	{
		Enter_boolAnd();
		EnterRule("boolAnd", 7);
		TraceIn("boolAnd", 7);
		Lang2Parser.boolAnd_return retval = new Lang2Parser.boolAnd_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken DISJUNCTION14=null;
		Lang2Parser.boolAdd_return boolAdd13 = default(Lang2Parser.boolAdd_return);
		Lang2Parser.boolAdd_return boolAdd15 = default(Lang2Parser.boolAdd_return);

		object DISJUNCTION14_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolAnd");
		DebugLocation(123, 2);
		try
		{
			// Lang2.g:123:9: ( boolAdd ( DISJUNCTION boolAdd )* )
			DebugEnterAlt(1);
			// Lang2.g:123:11: boolAdd ( DISJUNCTION boolAdd )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(123, 11);
			PushFollow(Follow._boolAdd_in_boolAnd489);
			boolAdd13=boolAdd();
			PopFollow();

			adaptor.AddChild(root_0, boolAdd13.Tree);
			DebugLocation(123, 18);
			// Lang2.g:123:18: ( DISJUNCTION boolAdd )*
			try { DebugEnterSubRule(3);
			while (true)
			{
				int alt3=2;
				try { DebugEnterDecision(3, decisionCanBacktrack[3]);
				int LA3_0 = input.LA(1);

				if ((LA3_0==DISJUNCTION))
				{
					alt3=1;
				}


				} finally { DebugExitDecision(3); }
				switch ( alt3 )
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:123:19: DISJUNCTION boolAdd
					{
					DebugLocation(123, 30);
					DISJUNCTION14=(IToken)Match(input,DISJUNCTION,Follow._DISJUNCTION_in_boolAnd491); 
					DISJUNCTION14_tree = (object)adaptor.Create(DISJUNCTION14);
					root_0 = (object)adaptor.BecomeRoot(DISJUNCTION14_tree, root_0);

					DebugLocation(123, 31);
					PushFollow(Follow._boolAdd_in_boolAnd493);
					boolAdd15=boolAdd();
					PopFollow();

					adaptor.AddChild(root_0, boolAdd15.Tree);

					}
					break;

				default:
					goto loop3;
				}
			}

			loop3:
				;

			} finally { DebugExitSubRule(3); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("boolAnd", 7);
			LeaveRule("boolAnd", 7);
			Leave_boolAnd();
		}
		DebugLocation(124, 2);
		} finally { DebugExitRule(GrammarFileName, "boolAnd"); }
		return retval;

	}
	// $ANTLR end "boolAnd"

	public class boolInv_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_boolInv();
	partial void Leave_boolInv();

	// $ANTLR start "boolInv"
	// Lang2.g:126:1: boolInv : boolAnd ( INVERT boolAnd )* ;
	[GrammarRule("boolInv")]
	private Lang2Parser.boolInv_return boolInv()
	{
		Enter_boolInv();
		EnterRule("boolInv", 8);
		TraceIn("boolInv", 8);
		Lang2Parser.boolInv_return retval = new Lang2Parser.boolInv_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken INVERT17=null;
		Lang2Parser.boolAnd_return boolAnd16 = default(Lang2Parser.boolAnd_return);
		Lang2Parser.boolAnd_return boolAnd18 = default(Lang2Parser.boolAnd_return);

		object INVERT17_tree=null;

		try { DebugEnterRule(GrammarFileName, "boolInv");
		DebugLocation(126, 2);
		try
		{
			// Lang2.g:126:9: ( boolAnd ( INVERT boolAnd )* )
			DebugEnterAlt(1);
			// Lang2.g:126:11: boolAnd ( INVERT boolAnd )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(126, 11);
			PushFollow(Follow._boolAnd_in_boolInv506);
			boolAnd16=boolAnd();
			PopFollow();

			adaptor.AddChild(root_0, boolAnd16.Tree);
			DebugLocation(126, 18);
			// Lang2.g:126:18: ( INVERT boolAnd )*
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=2;
				try { DebugEnterDecision(4, decisionCanBacktrack[4]);
				int LA4_0 = input.LA(1);

				if ((LA4_0==INVERT))
				{
					alt4=1;
				}


				} finally { DebugExitDecision(4); }
				switch ( alt4 )
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:126:19: INVERT boolAnd
					{
					DebugLocation(126, 25);
					INVERT17=(IToken)Match(input,INVERT,Follow._INVERT_in_boolInv508); 
					INVERT17_tree = (object)adaptor.Create(INVERT17);
					root_0 = (object)adaptor.BecomeRoot(INVERT17_tree, root_0);

					DebugLocation(126, 26);
					PushFollow(Follow._boolAnd_in_boolInv510);
					boolAnd18=boolAnd();
					PopFollow();

					adaptor.AddChild(root_0, boolAnd18.Tree);

					}
					break;

				default:
					goto loop4;
				}
			}

			loop4:
				;

			} finally { DebugExitSubRule(4); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("boolInv", 8);
			LeaveRule("boolInv", 8);
			Leave_boolInv();
		}
		DebugLocation(127, 2);
		} finally { DebugExitRule(GrammarFileName, "boolInv"); }
		return retval;

	}
	// $ANTLR end "boolInv"

	public class boolExpr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_boolExpr();
	partial void Leave_boolExpr();

	// $ANTLR start "boolExpr"
	// Lang2.g:129:1: boolExpr : boolInv ;
	[GrammarRule("boolExpr")]
	private Lang2Parser.boolExpr_return boolExpr()
	{
		Enter_boolExpr();
		EnterRule("boolExpr", 9);
		TraceIn("boolExpr", 9);
		Lang2Parser.boolExpr_return retval = new Lang2Parser.boolExpr_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		Lang2Parser.boolInv_return boolInv19 = default(Lang2Parser.boolInv_return);


		try { DebugEnterRule(GrammarFileName, "boolExpr");
		DebugLocation(129, 2);
		try
		{
			// Lang2.g:129:9: ( boolInv )
			DebugEnterAlt(1);
			// Lang2.g:129:11: boolInv
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(129, 11);
			PushFollow(Follow._boolInv_in_boolExpr522);
			boolInv19=boolInv();
			PopFollow();

			adaptor.AddChild(root_0, boolInv19.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("boolExpr", 9);
			LeaveRule("boolExpr", 9);
			Leave_boolExpr();
		}
		DebugLocation(130, 2);
		} finally { DebugExitRule(GrammarFileName, "boolExpr"); }
		return retval;

	}
	// $ANTLR end "boolExpr"

	public class mathGroup_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_mathGroup();
	partial void Leave_mathGroup();

	// $ANTLR start "mathGroup"
	// Lang2.g:136:1: mathGroup : ( '(' ( mathExpr )+ ')' | INT | VAR );
	[GrammarRule("mathGroup")]
	private Lang2Parser.mathGroup_return mathGroup()
	{
		Enter_mathGroup();
		EnterRule("mathGroup", 10);
		TraceIn("mathGroup", 10);
		Lang2Parser.mathGroup_return retval = new Lang2Parser.mathGroup_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal20=null;
		IToken char_literal22=null;
		IToken INT23=null;
		IToken VAR24=null;
		Lang2Parser.mathExpr_return mathExpr21 = default(Lang2Parser.mathExpr_return);

		object char_literal20_tree=null;
		object char_literal22_tree=null;
		object INT23_tree=null;
		object VAR24_tree=null;

		try { DebugEnterRule(GrammarFileName, "mathGroup");
		DebugLocation(136, 2);
		try
		{
			// Lang2.g:136:11: ( '(' ( mathExpr )+ ')' | INT | VAR )
			int alt6=3;
			try { DebugEnterDecision(6, decisionCanBacktrack[6]);
			switch (input.LA(1))
			{
			case 38:
				{
				alt6=1;
				}
				break;
			case INT:
				{
				alt6=2;
				}
				break;
			case VAR:
				{
				alt6=3;
				}
				break;
			default:
				{
					NoViableAltException nvae = new NoViableAltException("", 6, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(6); }
			switch (alt6)
			{
			case 1:
				DebugEnterAlt(1);
				// Lang2.g:136:13: '(' ( mathExpr )+ ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(136, 16);
				char_literal20=(IToken)Match(input,38,Follow._38_in_mathGroup538); 
				DebugLocation(136, 17);
				// Lang2.g:136:17: ( mathExpr )+
				int cnt5=0;
				try { DebugEnterSubRule(5);
				while (true)
				{
					int alt5=2;
					try { DebugEnterDecision(5, decisionCanBacktrack[5]);
					int LA5_0 = input.LA(1);

					if (((LA5_0>=VAR && LA5_0<=INT)||LA5_0==38))
					{
						alt5=1;
					}


					} finally { DebugExitDecision(5); }
					switch (alt5)
					{
					case 1:
						DebugEnterAlt(1);
						// Lang2.g:136:17: mathExpr
						{
						DebugLocation(136, 17);
						PushFollow(Follow._mathExpr_in_mathGroup540);
						mathExpr21=mathExpr();
						PopFollow();

						adaptor.AddChild(root_0, mathExpr21.Tree);

						}
						break;

					default:
						if (cnt5 >= 1)
							goto loop5;

						EarlyExitException eee5 = new EarlyExitException( 5, input );
						DebugRecognitionException(eee5);
						throw eee5;
					}
					cnt5++;
				}
				loop5:
					;

				} finally { DebugExitSubRule(5); }

				DebugLocation(136, 29);
				char_literal22=(IToken)Match(input,39,Follow._39_in_mathGroup542); 

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Lang2.g:137:5: INT
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(137, 5);
				INT23=(IToken)Match(input,INT,Follow._INT_in_mathGroup549); 
				INT23_tree = (object)adaptor.Create(INT23);
				adaptor.AddChild(root_0, INT23_tree);


				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Lang2.g:138:5: VAR
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(138, 5);
				VAR24=(IToken)Match(input,VAR,Follow._VAR_in_mathGroup555); 
				VAR24_tree = (object)adaptor.Create(VAR24);
				adaptor.AddChild(root_0, VAR24_tree);


				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("mathGroup", 10);
			LeaveRule("mathGroup", 10);
			Leave_mathGroup();
		}
		DebugLocation(139, 2);
		} finally { DebugExitRule(GrammarFileName, "mathGroup"); }
		return retval;

	}
	// $ANTLR end "mathGroup"

	public class mathMult_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_mathMult();
	partial void Leave_mathMult();

	// $ANTLR start "mathMult"
	// Lang2.g:141:1: mathMult : mathGroup ( ( MULT | DIV ) mathGroup )* ;
	[GrammarRule("mathMult")]
	private Lang2Parser.mathMult_return mathMult()
	{
		Enter_mathMult();
		EnterRule("mathMult", 11);
		TraceIn("mathMult", 11);
		Lang2Parser.mathMult_return retval = new Lang2Parser.mathMult_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set26=null;
		Lang2Parser.mathGroup_return mathGroup25 = default(Lang2Parser.mathGroup_return);
		Lang2Parser.mathGroup_return mathGroup27 = default(Lang2Parser.mathGroup_return);

		object set26_tree=null;

		try { DebugEnterRule(GrammarFileName, "mathMult");
		DebugLocation(141, 1);
		try
		{
			// Lang2.g:142:2: ( mathGroup ( ( MULT | DIV ) mathGroup )* )
			DebugEnterAlt(1);
			// Lang2.g:142:4: mathGroup ( ( MULT | DIV ) mathGroup )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(142, 4);
			PushFollow(Follow._mathGroup_in_mathMult568);
			mathGroup25=mathGroup();
			PopFollow();

			adaptor.AddChild(root_0, mathGroup25.Tree);
			DebugLocation(142, 13);
			// Lang2.g:142:13: ( ( MULT | DIV ) mathGroup )*
			try { DebugEnterSubRule(7);
			while (true)
			{
				int alt7=2;
				try { DebugEnterDecision(7, decisionCanBacktrack[7]);
				int LA7_0 = input.LA(1);

				if (((LA7_0>=MULT && LA7_0<=DIV)))
				{
					alt7=1;
				}


				} finally { DebugExitDecision(7); }
				switch ( alt7 )
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:142:14: ( MULT | DIV ) mathGroup
					{
					DebugLocation(142, 14);
					set26=(IToken)input.LT(1);
					set26=(IToken)input.LT(1);
					if ((input.LA(1)>=MULT && input.LA(1)<=DIV))
					{
						input.Consume();
						root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set26), root_0);
						state.errorRecovery=false;
					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(142, 25);
					PushFollow(Follow._mathGroup_in_mathMult576);
					mathGroup27=mathGroup();
					PopFollow();

					adaptor.AddChild(root_0, mathGroup27.Tree);

					}
					break;

				default:
					goto loop7;
				}
			}

			loop7:
				;

			} finally { DebugExitSubRule(7); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("mathMult", 11);
			LeaveRule("mathMult", 11);
			Leave_mathMult();
		}
		DebugLocation(143, 1);
		} finally { DebugExitRule(GrammarFileName, "mathMult"); }
		return retval;

	}
	// $ANTLR end "mathMult"

	public class mathAdd_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_mathAdd();
	partial void Leave_mathAdd();

	// $ANTLR start "mathAdd"
	// Lang2.g:145:1: mathAdd : mathMult ( ( ADD | REM ) mathMult )* ;
	[GrammarRule("mathAdd")]
	private Lang2Parser.mathAdd_return mathAdd()
	{
		Enter_mathAdd();
		EnterRule("mathAdd", 12);
		TraceIn("mathAdd", 12);
		Lang2Parser.mathAdd_return retval = new Lang2Parser.mathAdd_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set29=null;
		Lang2Parser.mathMult_return mathMult28 = default(Lang2Parser.mathMult_return);
		Lang2Parser.mathMult_return mathMult30 = default(Lang2Parser.mathMult_return);

		object set29_tree=null;

		try { DebugEnterRule(GrammarFileName, "mathAdd");
		DebugLocation(145, 1);
		try
		{
			// Lang2.g:145:9: ( mathMult ( ( ADD | REM ) mathMult )* )
			DebugEnterAlt(1);
			// Lang2.g:145:11: mathMult ( ( ADD | REM ) mathMult )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(145, 11);
			PushFollow(Follow._mathMult_in_mathAdd589);
			mathMult28=mathMult();
			PopFollow();

			adaptor.AddChild(root_0, mathMult28.Tree);
			DebugLocation(145, 19);
			// Lang2.g:145:19: ( ( ADD | REM ) mathMult )*
			try { DebugEnterSubRule(8);
			while (true)
			{
				int alt8=2;
				try { DebugEnterDecision(8, decisionCanBacktrack[8]);
				int LA8_0 = input.LA(1);

				if (((LA8_0>=ADD && LA8_0<=REM)))
				{
					alt8=1;
				}


				} finally { DebugExitDecision(8); }
				switch ( alt8 )
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:145:20: ( ADD | REM ) mathMult
					{
					DebugLocation(145, 20);
					set29=(IToken)input.LT(1);
					set29=(IToken)input.LT(1);
					if ((input.LA(1)>=ADD && input.LA(1)<=REM))
					{
						input.Consume();
						root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set29), root_0);
						state.errorRecovery=false;
					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(145, 30);
					PushFollow(Follow._mathMult_in_mathAdd597);
					mathMult30=mathMult();
					PopFollow();

					adaptor.AddChild(root_0, mathMult30.Tree);

					}
					break;

				default:
					goto loop8;
				}
			}

			loop8:
				;

			} finally { DebugExitSubRule(8); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("mathAdd", 12);
			LeaveRule("mathAdd", 12);
			Leave_mathAdd();
		}
		DebugLocation(146, 1);
		} finally { DebugExitRule(GrammarFileName, "mathAdd"); }
		return retval;

	}
	// $ANTLR end "mathAdd"

	public class mathExpr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_mathExpr();
	partial void Leave_mathExpr();

	// $ANTLR start "mathExpr"
	// Lang2.g:148:1: mathExpr : mathAdd ;
	[GrammarRule("mathExpr")]
	private Lang2Parser.mathExpr_return mathExpr()
	{
		Enter_mathExpr();
		EnterRule("mathExpr", 13);
		TraceIn("mathExpr", 13);
		Lang2Parser.mathExpr_return retval = new Lang2Parser.mathExpr_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		Lang2Parser.mathAdd_return mathAdd31 = default(Lang2Parser.mathAdd_return);


		try { DebugEnterRule(GrammarFileName, "mathExpr");
		DebugLocation(148, 1);
		try
		{
			// Lang2.g:149:2: ( mathAdd )
			DebugEnterAlt(1);
			// Lang2.g:149:4: mathAdd
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(149, 4);
			PushFollow(Follow._mathAdd_in_mathExpr611);
			mathAdd31=mathAdd();
			PopFollow();

			adaptor.AddChild(root_0, mathAdd31.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("mathExpr", 13);
			LeaveRule("mathExpr", 13);
			Leave_mathExpr();
		}
		DebugLocation(150, 1);
		} finally { DebugExitRule(GrammarFileName, "mathExpr"); }
		return retval;

	}
	// $ANTLR end "mathExpr"

	public class expressions_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_expressions();
	partial void Leave_expressions();

	// $ANTLR start "expressions"
	// Lang2.g:157:1: expressions : ( mathExpr | boolExpr | stringExpr );
	[GrammarRule("expressions")]
	private Lang2Parser.expressions_return expressions()
	{
		Enter_expressions();
		EnterRule("expressions", 14);
		TraceIn("expressions", 14);
		Lang2Parser.expressions_return retval = new Lang2Parser.expressions_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		Lang2Parser.mathExpr_return mathExpr32 = default(Lang2Parser.mathExpr_return);
		Lang2Parser.boolExpr_return boolExpr33 = default(Lang2Parser.boolExpr_return);
		Lang2Parser.stringExpr_return stringExpr34 = default(Lang2Parser.stringExpr_return);


		try { DebugEnterRule(GrammarFileName, "expressions");
		DebugLocation(157, 42);
		try
		{
			// Lang2.g:157:13: ( mathExpr | boolExpr | stringExpr )
			int alt9=3;
			try { DebugEnterDecision(9, decisionCanBacktrack[9]);
			switch (input.LA(1))
			{
			case INT:
			case 38:
				{
				alt9=1;
				}
				break;
			case VAR:
				{
				int LA9_2 = input.LA(2);

				if ((LA9_2==OP_END||(LA9_2>=ADD && LA9_2<=DIV)||LA9_2==VAR||LA9_2==39||LA9_2==42||LA9_2==44))
				{
					alt9=1;
				}
				else if ((LA9_2==IS_MORE||(LA9_2>=IS_LESS && LA9_2<=IS_EQUALLY)))
				{
					alt9=2;
				}
				else
				{
					NoViableAltException nvae = new NoViableAltException("", 9, 2, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
				}
				break;
			case BOOL:
				{
				alt9=2;
				}
				break;
			case STRING:
				{
				alt9=3;
				}
				break;
			default:
				{
					NoViableAltException nvae = new NoViableAltException("", 9, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(9); }
			switch (alt9)
			{
			case 1:
				DebugEnterAlt(1);
				// Lang2.g:157:15: mathExpr
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(157, 15);
				PushFollow(Follow._mathExpr_in_expressions628);
				mathExpr32=mathExpr();
				PopFollow();

				adaptor.AddChild(root_0, mathExpr32.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Lang2.g:157:24: boolExpr
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(157, 24);
				PushFollow(Follow._boolExpr_in_expressions630);
				boolExpr33=boolExpr();
				PopFollow();

				adaptor.AddChild(root_0, boolExpr33.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Lang2.g:157:33: stringExpr
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(157, 33);
				PushFollow(Follow._stringExpr_in_expressions632);
				stringExpr34=stringExpr();
				PopFollow();

				adaptor.AddChild(root_0, stringExpr34.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("expressions", 14);
			LeaveRule("expressions", 14);
			Leave_expressions();
		}
		DebugLocation(157, 42);
		} finally { DebugExitRule(GrammarFileName, "expressions"); }
		return retval;

	}
	// $ANTLR end "expressions"

	public class arrDecl_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_arrDecl();
	partial void Leave_arrDecl();

	// $ANTLR start "arrDecl"
	// Lang2.g:159:1: arrDecl : typeDecl VAR '[]' ASS typeDecl '[' expressions ']' OP_END -> ^( ARR_DECL typeDecl VAR ASS typeDecl expressions ) ;
	[GrammarRule("arrDecl")]
	private Lang2Parser.arrDecl_return arrDecl()
	{
		Enter_arrDecl();
		EnterRule("arrDecl", 15);
		TraceIn("arrDecl", 15);
		Lang2Parser.arrDecl_return retval = new Lang2Parser.arrDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken VAR36=null;
		IToken string_literal37=null;
		IToken ASS38=null;
		IToken char_literal40=null;
		IToken char_literal42=null;
		IToken OP_END43=null;
		Lang2Parser.typeDecl_return typeDecl35 = default(Lang2Parser.typeDecl_return);
		Lang2Parser.typeDecl_return typeDecl39 = default(Lang2Parser.typeDecl_return);
		Lang2Parser.expressions_return expressions41 = default(Lang2Parser.expressions_return);

		object VAR36_tree=null;
		object string_literal37_tree=null;
		object ASS38_tree=null;
		object char_literal40_tree=null;
		object char_literal42_tree=null;
		object OP_END43_tree=null;
		RewriteRuleITokenStream stream_VAR=new RewriteRuleITokenStream(adaptor,"token VAR");
		RewriteRuleITokenStream stream_ASS=new RewriteRuleITokenStream(adaptor,"token ASS");
		RewriteRuleITokenStream stream_42=new RewriteRuleITokenStream(adaptor,"token 42");
		RewriteRuleITokenStream stream_41=new RewriteRuleITokenStream(adaptor,"token 41");
		RewriteRuleITokenStream stream_OP_END=new RewriteRuleITokenStream(adaptor,"token OP_END");
		RewriteRuleITokenStream stream_40=new RewriteRuleITokenStream(adaptor,"token 40");
		RewriteRuleSubtreeStream stream_typeDecl=new RewriteRuleSubtreeStream(adaptor,"rule typeDecl");
		RewriteRuleSubtreeStream stream_expressions=new RewriteRuleSubtreeStream(adaptor,"rule expressions");
		try { DebugEnterRule(GrammarFileName, "arrDecl");
		DebugLocation(159, 3);
		try
		{
			// Lang2.g:159:10: ( typeDecl VAR '[]' ASS typeDecl '[' expressions ']' OP_END -> ^( ARR_DECL typeDecl VAR ASS typeDecl expressions ) )
			DebugEnterAlt(1);
			// Lang2.g:159:12: typeDecl VAR '[]' ASS typeDecl '[' expressions ']' OP_END
			{
			DebugLocation(159, 12);
			PushFollow(Follow._typeDecl_in_arrDecl641);
			typeDecl35=typeDecl();
			PopFollow();

			stream_typeDecl.Add(typeDecl35.Tree);
			DebugLocation(159, 21);
			VAR36=(IToken)Match(input,VAR,Follow._VAR_in_arrDecl643);  
			stream_VAR.Add(VAR36);

			DebugLocation(159, 29);
			string_literal37=(IToken)Match(input,40,Follow._40_in_arrDecl645);  
			stream_40.Add(string_literal37);

			DebugLocation(159, 31);
			ASS38=(IToken)Match(input,ASS,Follow._ASS_in_arrDecl648);  
			stream_ASS.Add(ASS38);

			DebugLocation(159, 35);
			PushFollow(Follow._typeDecl_in_arrDecl650);
			typeDecl39=typeDecl();
			PopFollow();

			stream_typeDecl.Add(typeDecl39.Tree);
			DebugLocation(159, 43);
			char_literal40=(IToken)Match(input,41,Follow._41_in_arrDecl651);  
			stream_41.Add(char_literal40);

			DebugLocation(159, 46);
			PushFollow(Follow._expressions_in_arrDecl652);
			expressions41=expressions();
			PopFollow();

			stream_expressions.Add(expressions41.Tree);
			DebugLocation(159, 57);
			char_literal42=(IToken)Match(input,42,Follow._42_in_arrDecl653);  
			stream_42.Add(char_literal42);

			DebugLocation(159, 67);
			OP_END43=(IToken)Match(input,OP_END,Follow._OP_END_in_arrDecl655);  
			stream_OP_END.Add(OP_END43);



			{
			// AST REWRITE
			// elements: typeDecl, VAR, expressions, typeDecl, ASS
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 159:69: -> ^( ARR_DECL typeDecl VAR ASS typeDecl expressions )
			{
				DebugLocation(159, 72);
				// Lang2.g:159:72: ^( ARR_DECL typeDecl VAR ASS typeDecl expressions )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(159, 74);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARR_DECL, "ARR_DECL"), root_1);

				DebugLocation(159, 83);
				adaptor.AddChild(root_1, stream_typeDecl.NextTree());
				DebugLocation(159, 92);
				adaptor.AddChild(root_1, stream_VAR.NextNode());
				DebugLocation(159, 96);
				adaptor.AddChild(root_1, stream_ASS.NextNode());
				DebugLocation(159, 100);
				adaptor.AddChild(root_1, stream_typeDecl.NextTree());
				DebugLocation(159, 109);
				adaptor.AddChild(root_1, stream_expressions.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("arrDecl", 15);
			LeaveRule("arrDecl", 15);
			Leave_arrDecl();
		}
		DebugLocation(160, 3);
		} finally { DebugExitRule(GrammarFileName, "arrDecl"); }
		return retval;

	}
	// $ANTLR end "arrDecl"

	public class arrExec_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_arrExec();
	partial void Leave_arrExec();

	// $ANTLR start "arrExec"
	// Lang2.g:162:1: arrExec : VAR '[' expressions ']' ( ASS expressions )? OP_END -> ^( ARR_CALL VAR expressions ) ;
	[GrammarRule("arrExec")]
	private Lang2Parser.arrExec_return arrExec()
	{
		Enter_arrExec();
		EnterRule("arrExec", 16);
		TraceIn("arrExec", 16);
		Lang2Parser.arrExec_return retval = new Lang2Parser.arrExec_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken VAR44=null;
		IToken char_literal45=null;
		IToken char_literal47=null;
		IToken ASS48=null;
		IToken OP_END50=null;
		Lang2Parser.expressions_return expressions46 = default(Lang2Parser.expressions_return);
		Lang2Parser.expressions_return expressions49 = default(Lang2Parser.expressions_return);

		object VAR44_tree=null;
		object char_literal45_tree=null;
		object char_literal47_tree=null;
		object ASS48_tree=null;
		object OP_END50_tree=null;
		RewriteRuleITokenStream stream_VAR=new RewriteRuleITokenStream(adaptor,"token VAR");
		RewriteRuleITokenStream stream_ASS=new RewriteRuleITokenStream(adaptor,"token ASS");
		RewriteRuleITokenStream stream_42=new RewriteRuleITokenStream(adaptor,"token 42");
		RewriteRuleITokenStream stream_41=new RewriteRuleITokenStream(adaptor,"token 41");
		RewriteRuleITokenStream stream_OP_END=new RewriteRuleITokenStream(adaptor,"token OP_END");
		RewriteRuleSubtreeStream stream_expressions=new RewriteRuleSubtreeStream(adaptor,"rule expressions");
		try { DebugEnterRule(GrammarFileName, "arrExec");
		DebugLocation(162, 3);
		try
		{
			// Lang2.g:162:10: ( VAR '[' expressions ']' ( ASS expressions )? OP_END -> ^( ARR_CALL VAR expressions ) )
			DebugEnterAlt(1);
			// Lang2.g:162:12: VAR '[' expressions ']' ( ASS expressions )? OP_END
			{
			DebugLocation(162, 12);
			VAR44=(IToken)Match(input,VAR,Follow._VAR_in_arrExec685);  
			stream_VAR.Add(VAR44);

			DebugLocation(162, 19);
			char_literal45=(IToken)Match(input,41,Follow._41_in_arrExec687);  
			stream_41.Add(char_literal45);

			DebugLocation(162, 21);
			PushFollow(Follow._expressions_in_arrExec690);
			expressions46=expressions();
			PopFollow();

			stream_expressions.Add(expressions46.Tree);
			DebugLocation(162, 36);
			char_literal47=(IToken)Match(input,42,Follow._42_in_arrExec692);  
			stream_42.Add(char_literal47);

			DebugLocation(162, 38);
			// Lang2.g:162:38: ( ASS expressions )?
			int alt10=2;
			try { DebugEnterSubRule(10);
			try { DebugEnterDecision(10, decisionCanBacktrack[10]);
			int LA10_0 = input.LA(1);

			if ((LA10_0==ASS))
			{
				alt10=1;
			}
			} finally { DebugExitDecision(10); }
			switch (alt10)
			{
			case 1:
				DebugEnterAlt(1);
				// Lang2.g:162:39: ASS expressions
				{
				DebugLocation(162, 39);
				ASS48=(IToken)Match(input,ASS,Follow._ASS_in_arrExec696);  
				stream_ASS.Add(ASS48);

				DebugLocation(162, 43);
				PushFollow(Follow._expressions_in_arrExec698);
				expressions49=expressions();
				PopFollow();

				stream_expressions.Add(expressions49.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(10); }

			DebugLocation(162, 63);
			OP_END50=(IToken)Match(input,OP_END,Follow._OP_END_in_arrExec702);  
			stream_OP_END.Add(OP_END50);



			{
			// AST REWRITE
			// elements: expressions, VAR
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 162:65: -> ^( ARR_CALL VAR expressions )
			{
				DebugLocation(162, 68);
				// Lang2.g:162:68: ^( ARR_CALL VAR expressions )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(162, 70);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARR_CALL, "ARR_CALL"), root_1);

				DebugLocation(162, 79);
				adaptor.AddChild(root_1, stream_VAR.NextNode());
				DebugLocation(162, 83);
				adaptor.AddChild(root_1, stream_expressions.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("arrExec", 16);
			LeaveRule("arrExec", 16);
			Leave_arrExec();
		}
		DebugLocation(163, 3);
		} finally { DebugExitRule(GrammarFileName, "arrExec"); }
		return retval;

	}
	// $ANTLR end "arrExec"

	public class funcTypes_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_funcTypes();
	partial void Leave_funcTypes();

	// $ANTLR start "funcTypes"
	// Lang2.g:165:1: funcTypes : ( typeDecl | 'void' );
	[GrammarRule("funcTypes")]
	private Lang2Parser.funcTypes_return funcTypes()
	{
		Enter_funcTypes();
		EnterRule("funcTypes", 17);
		TraceIn("funcTypes", 17);
		Lang2Parser.funcTypes_return retval = new Lang2Parser.funcTypes_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken string_literal52=null;
		Lang2Parser.typeDecl_return typeDecl51 = default(Lang2Parser.typeDecl_return);

		object string_literal52_tree=null;

		try { DebugEnterRule(GrammarFileName, "funcTypes");
		DebugLocation(165, 3);
		try
		{
			// Lang2.g:165:11: ( typeDecl | 'void' )
			int alt11=2;
			try { DebugEnterDecision(11, decisionCanBacktrack[11]);
			int LA11_0 = input.LA(1);

			if (((LA11_0>=35 && LA11_0<=37)))
			{
				alt11=1;
			}
			else if ((LA11_0==43))
			{
				alt11=2;
			}
			else
			{
				NoViableAltException nvae = new NoViableAltException("", 11, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(11); }
			switch (alt11)
			{
			case 1:
				DebugEnterAlt(1);
				// Lang2.g:165:13: typeDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(165, 13);
				PushFollow(Follow._typeDecl_in_funcTypes725);
				typeDecl51=typeDecl();
				PopFollow();

				adaptor.AddChild(root_0, typeDecl51.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Lang2.g:165:22: 'void'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(165, 22);
				string_literal52=(IToken)Match(input,43,Follow._43_in_funcTypes727); 
				string_literal52_tree = (object)adaptor.Create(string_literal52);
				adaptor.AddChild(root_0, string_literal52_tree);


				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("funcTypes", 17);
			LeaveRule("funcTypes", 17);
			Leave_funcTypes();
		}
		DebugLocation(166, 3);
		} finally { DebugExitRule(GrammarFileName, "funcTypes"); }
		return retval;

	}
	// $ANTLR end "funcTypes"

	public class argRule_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_argRule();
	partial void Leave_argRule();

	// $ANTLR start "argRule"
	// Lang2.g:168:1: argRule : ( typeDecl VAR ( ',' typeDecl VAR )* -> ^( ARGS_RULE typeDecl VAR ( typeDecl VAR )* ) | ( typeDecl VAR )? -> ^( ARGS_RULE ( typeDecl VAR )? ) );
	[GrammarRule("argRule")]
	private Lang2Parser.argRule_return argRule()
	{
		Enter_argRule();
		EnterRule("argRule", 18);
		TraceIn("argRule", 18);
		Lang2Parser.argRule_return retval = new Lang2Parser.argRule_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken VAR54=null;
		IToken char_literal55=null;
		IToken VAR57=null;
		IToken VAR59=null;
		Lang2Parser.typeDecl_return typeDecl53 = default(Lang2Parser.typeDecl_return);
		Lang2Parser.typeDecl_return typeDecl56 = default(Lang2Parser.typeDecl_return);
		Lang2Parser.typeDecl_return typeDecl58 = default(Lang2Parser.typeDecl_return);

		object VAR54_tree=null;
		object char_literal55_tree=null;
		object VAR57_tree=null;
		object VAR59_tree=null;
		RewriteRuleITokenStream stream_VAR=new RewriteRuleITokenStream(adaptor,"token VAR");
		RewriteRuleITokenStream stream_44=new RewriteRuleITokenStream(adaptor,"token 44");
		RewriteRuleSubtreeStream stream_typeDecl=new RewriteRuleSubtreeStream(adaptor,"rule typeDecl");
		try { DebugEnterRule(GrammarFileName, "argRule");
		DebugLocation(168, 2);
		try
		{
			// Lang2.g:168:10: ( typeDecl VAR ( ',' typeDecl VAR )* -> ^( ARGS_RULE typeDecl VAR ( typeDecl VAR )* ) | ( typeDecl VAR )? -> ^( ARGS_RULE ( typeDecl VAR )? ) )
			int alt14=2;
			try { DebugEnterDecision(14, decisionCanBacktrack[14]);
			int LA14_0 = input.LA(1);

			if (((LA14_0>=35 && LA14_0<=37)))
			{
				int LA14_1 = input.LA(2);

				if ((LA14_1==VAR))
				{
					alt14=1;
				}
				else
				{
					NoViableAltException nvae = new NoViableAltException("", 14, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else if ((LA14_0==39))
			{
				alt14=2;
			}
			else
			{
				NoViableAltException nvae = new NoViableAltException("", 14, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(14); }
			switch (alt14)
			{
			case 1:
				DebugEnterAlt(1);
				// Lang2.g:169:5: typeDecl VAR ( ',' typeDecl VAR )*
				{
				DebugLocation(169, 5);
				PushFollow(Follow._typeDecl_in_argRule745);
				typeDecl53=typeDecl();
				PopFollow();

				stream_typeDecl.Add(typeDecl53.Tree);
				DebugLocation(169, 14);
				VAR54=(IToken)Match(input,VAR,Follow._VAR_in_argRule747);  
				stream_VAR.Add(VAR54);

				DebugLocation(169, 18);
				// Lang2.g:169:18: ( ',' typeDecl VAR )*
				try { DebugEnterSubRule(12);
				while (true)
				{
					int alt12=2;
					try { DebugEnterDecision(12, decisionCanBacktrack[12]);
					int LA12_0 = input.LA(1);

					if ((LA12_0==44))
					{
						alt12=1;
					}


					} finally { DebugExitDecision(12); }
					switch ( alt12 )
					{
					case 1:
						DebugEnterAlt(1);
						// Lang2.g:169:19: ',' typeDecl VAR
						{
						DebugLocation(169, 22);
						char_literal55=(IToken)Match(input,44,Follow._44_in_argRule750);  
						stream_44.Add(char_literal55);

						DebugLocation(169, 24);
						PushFollow(Follow._typeDecl_in_argRule753);
						typeDecl56=typeDecl();
						PopFollow();

						stream_typeDecl.Add(typeDecl56.Tree);
						DebugLocation(169, 33);
						VAR57=(IToken)Match(input,VAR,Follow._VAR_in_argRule755);  
						stream_VAR.Add(VAR57);


						}
						break;

					default:
						goto loop12;
					}
				}

				loop12:
					;

				} finally { DebugExitSubRule(12); }



				{
				// AST REWRITE
				// elements: VAR, VAR, typeDecl, typeDecl
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 169:39: -> ^( ARGS_RULE typeDecl VAR ( typeDecl VAR )* )
				{
					DebugLocation(169, 41);
					// Lang2.g:169:41: ^( ARGS_RULE typeDecl VAR ( typeDecl VAR )* )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(169, 43);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARGS_RULE, "ARGS_RULE"), root_1);

					DebugLocation(169, 53);
					adaptor.AddChild(root_1, stream_typeDecl.NextTree());
					DebugLocation(169, 62);
					adaptor.AddChild(root_1, stream_VAR.NextNode());
					DebugLocation(169, 66);
					// Lang2.g:169:66: ( typeDecl VAR )*
					while ( stream_VAR.HasNext||stream_typeDecl.HasNext )
					{
						DebugLocation(169, 67);
						adaptor.AddChild(root_1, stream_typeDecl.NextTree());
						DebugLocation(169, 76);
						adaptor.AddChild(root_1, stream_VAR.NextNode());

					}
					stream_VAR.Reset();
					stream_typeDecl.Reset();

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Lang2.g:170:6: ( typeDecl VAR )?
				{
				DebugLocation(170, 6);
				// Lang2.g:170:6: ( typeDecl VAR )?
				int alt13=2;
				try { DebugEnterSubRule(13);
				try { DebugEnterDecision(13, decisionCanBacktrack[13]);
				int LA13_0 = input.LA(1);

				if (((LA13_0>=35 && LA13_0<=37)))
				{
					alt13=1;
				}
				} finally { DebugExitDecision(13); }
				switch (alt13)
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:170:7: typeDecl VAR
					{
					DebugLocation(170, 7);
					PushFollow(Follow._typeDecl_in_argRule781);
					typeDecl58=typeDecl();
					PopFollow();

					stream_typeDecl.Add(typeDecl58.Tree);
					DebugLocation(170, 16);
					VAR59=(IToken)Match(input,VAR,Follow._VAR_in_argRule783);  
					stream_VAR.Add(VAR59);


					}
					break;

				}
				} finally { DebugExitSubRule(13); }



				{
				// AST REWRITE
				// elements: typeDecl, VAR
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 170:22: -> ^( ARGS_RULE ( typeDecl VAR )? )
				{
					DebugLocation(170, 25);
					// Lang2.g:170:25: ^( ARGS_RULE ( typeDecl VAR )? )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(170, 27);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARGS_RULE, "ARGS_RULE"), root_1);

					DebugLocation(170, 37);
					// Lang2.g:170:37: ( typeDecl VAR )?
					if ( stream_typeDecl.HasNext||stream_VAR.HasNext )
					{
						DebugLocation(170, 38);
						adaptor.AddChild(root_1, stream_typeDecl.NextTree());
						DebugLocation(170, 47);
						adaptor.AddChild(root_1, stream_VAR.NextNode());

					}
					stream_typeDecl.Reset();
					stream_VAR.Reset();

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("argRule", 18);
			LeaveRule("argRule", 18);
			Leave_argRule();
		}
		DebugLocation(172, 2);
		} finally { DebugExitRule(GrammarFileName, "argRule"); }
		return retval;

	}
	// $ANTLR end "argRule"

	public class funcDeclSub_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_funcDeclSub();
	partial void Leave_funcDeclSub();

	// $ANTLR start "funcDeclSub"
	// Lang2.g:174:1: funcDeclSub : ( funcExpr )* -> ^( FUNC_BODY ( funcExpr )* ) ;
	[GrammarRule("funcDeclSub")]
	private Lang2Parser.funcDeclSub_return funcDeclSub()
	{
		Enter_funcDeclSub();
		EnterRule("funcDeclSub", 19);
		TraceIn("funcDeclSub", 19);
		Lang2Parser.funcDeclSub_return retval = new Lang2Parser.funcDeclSub_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		Lang2Parser.funcExpr_return funcExpr60 = default(Lang2Parser.funcExpr_return);

		RewriteRuleSubtreeStream stream_funcExpr=new RewriteRuleSubtreeStream(adaptor,"rule funcExpr");
		try { DebugEnterRule(GrammarFileName, "funcDeclSub");
		DebugLocation(174, 3);
		try
		{
			// Lang2.g:174:13: ( ( funcExpr )* -> ^( FUNC_BODY ( funcExpr )* ) )
			DebugEnterAlt(1);
			// Lang2.g:174:15: ( funcExpr )*
			{
			DebugLocation(174, 15);
			// Lang2.g:174:15: ( funcExpr )*
			try { DebugEnterSubRule(15);
			while (true)
			{
				int alt15=2;
				try { DebugEnterDecision(15, decisionCanBacktrack[15]);
				int LA15_0 = input.LA(1);

				if ((LA15_0==VITOCHKA||(LA15_0>=IF && LA15_0<=FOR)||LA15_0==VAR||(LA15_0>=35 && LA15_0<=37)))
				{
					alt15=1;
				}


				} finally { DebugExitDecision(15); }
				switch ( alt15 )
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:174:15: funcExpr
					{
					DebugLocation(174, 15);
					PushFollow(Follow._funcExpr_in_funcDeclSub814);
					funcExpr60=funcExpr();
					PopFollow();

					stream_funcExpr.Add(funcExpr60.Tree);

					}
					break;

				default:
					goto loop15;
				}
			}

			loop15:
				;

			} finally { DebugExitSubRule(15); }



			{
			// AST REWRITE
			// elements: funcExpr
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 174:25: -> ^( FUNC_BODY ( funcExpr )* )
			{
				DebugLocation(174, 28);
				// Lang2.g:174:28: ^( FUNC_BODY ( funcExpr )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(174, 30);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_BODY, "FUNC_BODY"), root_1);

				DebugLocation(174, 40);
				// Lang2.g:174:40: ( funcExpr )*
				while ( stream_funcExpr.HasNext )
				{
					DebugLocation(174, 40);
					adaptor.AddChild(root_1, stream_funcExpr.NextTree());

				}
				stream_funcExpr.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("funcDeclSub", 19);
			LeaveRule("funcDeclSub", 19);
			Leave_funcDeclSub();
		}
		DebugLocation(175, 3);
		} finally { DebugExitRule(GrammarFileName, "funcDeclSub"); }
		return retval;

	}
	// $ANTLR end "funcDeclSub"

	public class funcDecl_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_funcDecl();
	partial void Leave_funcDecl();

	// $ANTLR start "funcDecl"
	// Lang2.g:177:1: funcDecl : funcTypes VAR '(' argRule ')' '{' funcDeclSub '}' -> ^( FUNC_DECL funcTypes VAR argRule funcDeclSub ) ;
	[GrammarRule("funcDecl")]
	private Lang2Parser.funcDecl_return funcDecl()
	{
		Enter_funcDecl();
		EnterRule("funcDecl", 20);
		TraceIn("funcDecl", 20);
		Lang2Parser.funcDecl_return retval = new Lang2Parser.funcDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken VAR62=null;
		IToken char_literal63=null;
		IToken char_literal65=null;
		IToken char_literal66=null;
		IToken char_literal68=null;
		Lang2Parser.funcTypes_return funcTypes61 = default(Lang2Parser.funcTypes_return);
		Lang2Parser.argRule_return argRule64 = default(Lang2Parser.argRule_return);
		Lang2Parser.funcDeclSub_return funcDeclSub67 = default(Lang2Parser.funcDeclSub_return);

		object VAR62_tree=null;
		object char_literal63_tree=null;
		object char_literal65_tree=null;
		object char_literal66_tree=null;
		object char_literal68_tree=null;
		RewriteRuleITokenStream stream_45=new RewriteRuleITokenStream(adaptor,"token 45");
		RewriteRuleITokenStream stream_VAR=new RewriteRuleITokenStream(adaptor,"token VAR");
		RewriteRuleITokenStream stream_46=new RewriteRuleITokenStream(adaptor,"token 46");
		RewriteRuleITokenStream stream_39=new RewriteRuleITokenStream(adaptor,"token 39");
		RewriteRuleITokenStream stream_38=new RewriteRuleITokenStream(adaptor,"token 38");
		RewriteRuleSubtreeStream stream_funcDeclSub=new RewriteRuleSubtreeStream(adaptor,"rule funcDeclSub");
		RewriteRuleSubtreeStream stream_argRule=new RewriteRuleSubtreeStream(adaptor,"rule argRule");
		RewriteRuleSubtreeStream stream_funcTypes=new RewriteRuleSubtreeStream(adaptor,"rule funcTypes");
		try { DebugEnterRule(GrammarFileName, "funcDecl");
		DebugLocation(177, 3);
		try
		{
			// Lang2.g:177:10: ( funcTypes VAR '(' argRule ')' '{' funcDeclSub '}' -> ^( FUNC_DECL funcTypes VAR argRule funcDeclSub ) )
			DebugEnterAlt(1);
			// Lang2.g:177:12: funcTypes VAR '(' argRule ')' '{' funcDeclSub '}'
			{
			DebugLocation(177, 12);
			PushFollow(Follow._funcTypes_in_funcDecl836);
			funcTypes61=funcTypes();
			PopFollow();

			stream_funcTypes.Add(funcTypes61.Tree);
			DebugLocation(177, 25);
			VAR62=(IToken)Match(input,VAR,Follow._VAR_in_funcDecl838);  
			stream_VAR.Add(VAR62);

			DebugLocation(177, 29);
			char_literal63=(IToken)Match(input,38,Follow._38_in_funcDecl840);  
			stream_38.Add(char_literal63);

			DebugLocation(177, 30);
			PushFollow(Follow._argRule_in_funcDecl842);
			argRule64=argRule();
			PopFollow();

			stream_argRule.Add(argRule64.Tree);
			DebugLocation(177, 40);
			char_literal65=(IToken)Match(input,39,Follow._39_in_funcDecl843);  
			stream_39.Add(char_literal65);

			DebugLocation(177, 44);
			char_literal66=(IToken)Match(input,45,Follow._45_in_funcDecl845);  
			stream_45.Add(char_literal66);

			DebugLocation(177, 45);
			PushFollow(Follow._funcDeclSub_in_funcDecl847);
			funcDeclSub67=funcDeclSub();
			PopFollow();

			stream_funcDeclSub.Add(funcDeclSub67.Tree);
			DebugLocation(177, 59);
			char_literal68=(IToken)Match(input,46,Follow._46_in_funcDecl848);  
			stream_46.Add(char_literal68);



			{
			// AST REWRITE
			// elements: funcTypes, argRule, funcDeclSub, VAR
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 177:60: -> ^( FUNC_DECL funcTypes VAR argRule funcDeclSub )
			{
				DebugLocation(177, 62);
				// Lang2.g:177:62: ^( FUNC_DECL funcTypes VAR argRule funcDeclSub )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(177, 64);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_DECL, "FUNC_DECL"), root_1);

				DebugLocation(177, 74);
				adaptor.AddChild(root_1, stream_funcTypes.NextTree());
				DebugLocation(177, 84);
				adaptor.AddChild(root_1, stream_VAR.NextNode());
				DebugLocation(177, 88);
				adaptor.AddChild(root_1, stream_argRule.NextTree());
				DebugLocation(177, 96);
				adaptor.AddChild(root_1, stream_funcDeclSub.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("funcDecl", 20);
			LeaveRule("funcDecl", 20);
			Leave_funcDecl();
		}
		DebugLocation(178, 3);
		} finally { DebugExitRule(GrammarFileName, "funcDecl"); }
		return retval;

	}
	// $ANTLR end "funcDecl"

	public class conditionExpr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_conditionExpr();
	partial void Leave_conditionExpr();

	// $ANTLR start "conditionExpr"
	// Lang2.g:180:1: conditionExpr : IF '(' ( boolExpr )+ ')' '{' ( funcExpr )* '}' ( 'else' '{' ( funcExpr )* '}' ) ;
	[GrammarRule("conditionExpr")]
	private Lang2Parser.conditionExpr_return conditionExpr()
	{
		Enter_conditionExpr();
		EnterRule("conditionExpr", 21);
		TraceIn("conditionExpr", 21);
		Lang2Parser.conditionExpr_return retval = new Lang2Parser.conditionExpr_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken IF69=null;
		IToken char_literal70=null;
		IToken char_literal72=null;
		IToken char_literal73=null;
		IToken char_literal75=null;
		IToken string_literal76=null;
		IToken char_literal77=null;
		IToken char_literal79=null;
		Lang2Parser.boolExpr_return boolExpr71 = default(Lang2Parser.boolExpr_return);
		Lang2Parser.funcExpr_return funcExpr74 = default(Lang2Parser.funcExpr_return);
		Lang2Parser.funcExpr_return funcExpr78 = default(Lang2Parser.funcExpr_return);

		object IF69_tree=null;
		object char_literal70_tree=null;
		object char_literal72_tree=null;
		object char_literal73_tree=null;
		object char_literal75_tree=null;
		object string_literal76_tree=null;
		object char_literal77_tree=null;
		object char_literal79_tree=null;

		try { DebugEnterRule(GrammarFileName, "conditionExpr");
		DebugLocation(180, 1);
		try
		{
			// Lang2.g:180:14: ( IF '(' ( boolExpr )+ ')' '{' ( funcExpr )* '}' ( 'else' '{' ( funcExpr )* '}' ) )
			DebugEnterAlt(1);
			// Lang2.g:180:16: IF '(' ( boolExpr )+ ')' '{' ( funcExpr )* '}' ( 'else' '{' ( funcExpr )* '}' )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(180, 18);
			IF69=(IToken)Match(input,IF,Follow._IF_in_conditionExpr872); 
			IF69_tree = (object)adaptor.Create(IF69);
			root_0 = (object)adaptor.BecomeRoot(IF69_tree, root_0);

			DebugLocation(180, 22);
			char_literal70=(IToken)Match(input,38,Follow._38_in_conditionExpr874); 
			DebugLocation(180, 23);
			// Lang2.g:180:23: ( boolExpr )+
			int cnt16=0;
			try { DebugEnterSubRule(16);
			while (true)
			{
				int alt16=2;
				try { DebugEnterDecision(16, decisionCanBacktrack[16]);
				int LA16_0 = input.LA(1);

				if (((LA16_0>=BOOL && LA16_0<=VAR)))
				{
					alt16=1;
				}


				} finally { DebugExitDecision(16); }
				switch (alt16)
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:180:23: boolExpr
					{
					DebugLocation(180, 23);
					PushFollow(Follow._boolExpr_in_conditionExpr876);
					boolExpr71=boolExpr();
					PopFollow();

					adaptor.AddChild(root_0, boolExpr71.Tree);

					}
					break;

				default:
					if (cnt16 >= 1)
						goto loop16;

					EarlyExitException eee16 = new EarlyExitException( 16, input );
					DebugRecognitionException(eee16);
					throw eee16;
				}
				cnt16++;
			}
			loop16:
				;

			} finally { DebugExitSubRule(16); }

			DebugLocation(180, 35);
			char_literal72=(IToken)Match(input,39,Follow._39_in_conditionExpr878); 
			DebugLocation(180, 39);
			char_literal73=(IToken)Match(input,45,Follow._45_in_conditionExpr880); 
			DebugLocation(180, 40);
			// Lang2.g:180:40: ( funcExpr )*
			try { DebugEnterSubRule(17);
			while (true)
			{
				int alt17=2;
				try { DebugEnterDecision(17, decisionCanBacktrack[17]);
				int LA17_0 = input.LA(1);

				if ((LA17_0==VITOCHKA||(LA17_0>=IF && LA17_0<=FOR)||LA17_0==VAR||(LA17_0>=35 && LA17_0<=37)))
				{
					alt17=1;
				}


				} finally { DebugExitDecision(17); }
				switch ( alt17 )
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:180:40: funcExpr
					{
					DebugLocation(180, 40);
					PushFollow(Follow._funcExpr_in_conditionExpr882);
					funcExpr74=funcExpr();
					PopFollow();

					adaptor.AddChild(root_0, funcExpr74.Tree);

					}
					break;

				default:
					goto loop17;
				}
			}

			loop17:
				;

			} finally { DebugExitSubRule(17); }

			DebugLocation(180, 52);
			char_literal75=(IToken)Match(input,46,Follow._46_in_conditionExpr884); 
			DebugLocation(180, 54);
			// Lang2.g:180:54: ( 'else' '{' ( funcExpr )* '}' )
			DebugEnterAlt(1);
			// Lang2.g:180:55: 'else' '{' ( funcExpr )* '}'
			{
			DebugLocation(180, 55);
			string_literal76=(IToken)Match(input,47,Follow._47_in_conditionExpr888); 
			string_literal76_tree = (object)adaptor.Create(string_literal76);
			adaptor.AddChild(root_0, string_literal76_tree);

			DebugLocation(180, 64);
			char_literal77=(IToken)Match(input,45,Follow._45_in_conditionExpr889); 
			DebugLocation(180, 65);
			// Lang2.g:180:65: ( funcExpr )*
			try { DebugEnterSubRule(18);
			while (true)
			{
				int alt18=2;
				try { DebugEnterDecision(18, decisionCanBacktrack[18]);
				int LA18_0 = input.LA(1);

				if ((LA18_0==VITOCHKA||(LA18_0>=IF && LA18_0<=FOR)||LA18_0==VAR||(LA18_0>=35 && LA18_0<=37)))
				{
					alt18=1;
				}


				} finally { DebugExitDecision(18); }
				switch ( alt18 )
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:180:65: funcExpr
					{
					DebugLocation(180, 65);
					PushFollow(Follow._funcExpr_in_conditionExpr891);
					funcExpr78=funcExpr();
					PopFollow();

					adaptor.AddChild(root_0, funcExpr78.Tree);

					}
					break;

				default:
					goto loop18;
				}
			}

			loop18:
				;

			} finally { DebugExitSubRule(18); }

			DebugLocation(180, 77);
			char_literal79=(IToken)Match(input,46,Follow._46_in_conditionExpr893); 

			}


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("conditionExpr", 21);
			LeaveRule("conditionExpr", 21);
			Leave_conditionExpr();
		}
		DebugLocation(181, 1);
		} finally { DebugExitRule(GrammarFileName, "conditionExpr"); }
		return retval;

	}
	// $ANTLR end "conditionExpr"

	public class loopExpr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_loopExpr();
	partial void Leave_loopExpr();

	// $ANTLR start "loopExpr"
	// Lang2.g:183:1: loopExpr : ( WHILE '(' ( boolExpr )+ ')' '{' ( expr )* '}' | DO '{' ( funcExpr )* '}' WHILE OP_END | FOR '(' ( assExpr )* OP_END ( boolExpr )* OP_END ( assExpr )* ')' '{' ( funcExpr )* '}' );
	[GrammarRule("loopExpr")]
	private Lang2Parser.loopExpr_return loopExpr()
	{
		Enter_loopExpr();
		EnterRule("loopExpr", 22);
		TraceIn("loopExpr", 22);
		Lang2Parser.loopExpr_return retval = new Lang2Parser.loopExpr_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken WHILE80=null;
		IToken char_literal81=null;
		IToken char_literal83=null;
		IToken char_literal84=null;
		IToken char_literal86=null;
		IToken DO87=null;
		IToken char_literal88=null;
		IToken char_literal90=null;
		IToken WHILE91=null;
		IToken OP_END92=null;
		IToken FOR93=null;
		IToken char_literal94=null;
		IToken OP_END96=null;
		IToken OP_END98=null;
		IToken char_literal100=null;
		IToken char_literal101=null;
		IToken char_literal103=null;
		Lang2Parser.boolExpr_return boolExpr82 = default(Lang2Parser.boolExpr_return);
		Lang2Parser.expr_return expr85 = default(Lang2Parser.expr_return);
		Lang2Parser.funcExpr_return funcExpr89 = default(Lang2Parser.funcExpr_return);
		Lang2Parser.assExpr_return assExpr95 = default(Lang2Parser.assExpr_return);
		Lang2Parser.boolExpr_return boolExpr97 = default(Lang2Parser.boolExpr_return);
		Lang2Parser.assExpr_return assExpr99 = default(Lang2Parser.assExpr_return);
		Lang2Parser.funcExpr_return funcExpr102 = default(Lang2Parser.funcExpr_return);

		object WHILE80_tree=null;
		object char_literal81_tree=null;
		object char_literal83_tree=null;
		object char_literal84_tree=null;
		object char_literal86_tree=null;
		object DO87_tree=null;
		object char_literal88_tree=null;
		object char_literal90_tree=null;
		object WHILE91_tree=null;
		object OP_END92_tree=null;
		object FOR93_tree=null;
		object char_literal94_tree=null;
		object OP_END96_tree=null;
		object OP_END98_tree=null;
		object char_literal100_tree=null;
		object char_literal101_tree=null;
		object char_literal103_tree=null;

		try { DebugEnterRule(GrammarFileName, "loopExpr");
		DebugLocation(183, 2);
		try
		{
			// Lang2.g:183:9: ( WHILE '(' ( boolExpr )+ ')' '{' ( expr )* '}' | DO '{' ( funcExpr )* '}' WHILE OP_END | FOR '(' ( assExpr )* OP_END ( boolExpr )* OP_END ( assExpr )* ')' '{' ( funcExpr )* '}' )
			int alt26=3;
			try { DebugEnterDecision(26, decisionCanBacktrack[26]);
			switch (input.LA(1))
			{
			case WHILE:
				{
				alt26=1;
				}
				break;
			case DO:
				{
				alt26=2;
				}
				break;
			case FOR:
				{
				alt26=3;
				}
				break;
			default:
				{
					NoViableAltException nvae = new NoViableAltException("", 26, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(26); }
			switch (alt26)
			{
			case 1:
				DebugEnterAlt(1);
				// Lang2.g:183:11: WHILE '(' ( boolExpr )+ ')' '{' ( expr )* '}'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(183, 16);
				WHILE80=(IToken)Match(input,WHILE,Follow._WHILE_in_loopExpr904); 
				WHILE80_tree = (object)adaptor.Create(WHILE80);
				root_0 = (object)adaptor.BecomeRoot(WHILE80_tree, root_0);

				DebugLocation(183, 17);
				char_literal81=(IToken)Match(input,38,Follow._38_in_loopExpr906); 
				char_literal81_tree = (object)adaptor.Create(char_literal81);
				adaptor.AddChild(root_0, char_literal81_tree);

				DebugLocation(183, 20);
				// Lang2.g:183:20: ( boolExpr )+
				int cnt19=0;
				try { DebugEnterSubRule(19);
				while (true)
				{
					int alt19=2;
					try { DebugEnterDecision(19, decisionCanBacktrack[19]);
					int LA19_0 = input.LA(1);

					if (((LA19_0>=BOOL && LA19_0<=VAR)))
					{
						alt19=1;
					}


					} finally { DebugExitDecision(19); }
					switch (alt19)
					{
					case 1:
						DebugEnterAlt(1);
						// Lang2.g:183:20: boolExpr
						{
						DebugLocation(183, 20);
						PushFollow(Follow._boolExpr_in_loopExpr907);
						boolExpr82=boolExpr();
						PopFollow();

						adaptor.AddChild(root_0, boolExpr82.Tree);

						}
						break;

					default:
						if (cnt19 >= 1)
							goto loop19;

						EarlyExitException eee19 = new EarlyExitException( 19, input );
						DebugRecognitionException(eee19);
						throw eee19;
					}
					cnt19++;
				}
				loop19:
					;

				} finally { DebugExitSubRule(19); }

				DebugLocation(183, 29);
				char_literal83=(IToken)Match(input,39,Follow._39_in_loopExpr909); 
				char_literal83_tree = (object)adaptor.Create(char_literal83);
				adaptor.AddChild(root_0, char_literal83_tree);

				DebugLocation(183, 35);
				char_literal84=(IToken)Match(input,45,Follow._45_in_loopExpr910); 
				DebugLocation(183, 37);
				// Lang2.g:183:37: ( expr )*
				try { DebugEnterSubRule(20);
				while (true)
				{
					int alt20=2;
					try { DebugEnterDecision(20, decisionCanBacktrack[20]);
					int LA20_0 = input.LA(1);

					if (((LA20_0>=35 && LA20_0<=37)||LA20_0==43))
					{
						alt20=1;
					}


					} finally { DebugExitDecision(20); }
					switch ( alt20 )
					{
					case 1:
						DebugEnterAlt(1);
						// Lang2.g:183:37: expr
						{
						DebugLocation(183, 37);
						PushFollow(Follow._expr_in_loopExpr913);
						expr85=expr();
						PopFollow();

						adaptor.AddChild(root_0, expr85.Tree);

						}
						break;

					default:
						goto loop20;
					}
				}

				loop20:
					;

				} finally { DebugExitSubRule(20); }

				DebugLocation(183, 42);
				char_literal86=(IToken)Match(input,46,Follow._46_in_loopExpr915); 
				char_literal86_tree = (object)adaptor.Create(char_literal86);
				adaptor.AddChild(root_0, char_literal86_tree);


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Lang2.g:184:5: DO '{' ( funcExpr )* '}' WHILE OP_END
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(184, 5);
				DO87=(IToken)Match(input,DO,Follow._DO_in_loopExpr921); 
				DO87_tree = (object)adaptor.Create(DO87);
				adaptor.AddChild(root_0, DO87_tree);

				DebugLocation(184, 10);
				char_literal88=(IToken)Match(input,45,Follow._45_in_loopExpr922); 
				DebugLocation(184, 11);
				// Lang2.g:184:11: ( funcExpr )*
				try { DebugEnterSubRule(21);
				while (true)
				{
					int alt21=2;
					try { DebugEnterDecision(21, decisionCanBacktrack[21]);
					int LA21_0 = input.LA(1);

					if ((LA21_0==VITOCHKA||(LA21_0>=IF && LA21_0<=FOR)||LA21_0==VAR||(LA21_0>=35 && LA21_0<=37)))
					{
						alt21=1;
					}


					} finally { DebugExitDecision(21); }
					switch ( alt21 )
					{
					case 1:
						DebugEnterAlt(1);
						// Lang2.g:184:11: funcExpr
						{
						DebugLocation(184, 11);
						PushFollow(Follow._funcExpr_in_loopExpr924);
						funcExpr89=funcExpr();
						PopFollow();

						adaptor.AddChild(root_0, funcExpr89.Tree);

						}
						break;

					default:
						goto loop21;
					}
				}

				loop21:
					;

				} finally { DebugExitSubRule(21); }

				DebugLocation(184, 20);
				char_literal90=(IToken)Match(input,46,Follow._46_in_loopExpr926); 
				char_literal90_tree = (object)adaptor.Create(char_literal90);
				adaptor.AddChild(root_0, char_literal90_tree);

				DebugLocation(184, 28);
				WHILE91=(IToken)Match(input,WHILE,Follow._WHILE_in_loopExpr927); 
				WHILE91_tree = (object)adaptor.Create(WHILE91);
				root_0 = (object)adaptor.BecomeRoot(WHILE91_tree, root_0);

				DebugLocation(184, 36);
				OP_END92=(IToken)Match(input,OP_END,Follow._OP_END_in_loopExpr930); 

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Lang2.g:185:5: FOR '(' ( assExpr )* OP_END ( boolExpr )* OP_END ( assExpr )* ')' '{' ( funcExpr )* '}'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(185, 8);
				FOR93=(IToken)Match(input,FOR,Follow._FOR_in_loopExpr937); 
				FOR93_tree = (object)adaptor.Create(FOR93);
				root_0 = (object)adaptor.BecomeRoot(FOR93_tree, root_0);

				DebugLocation(185, 12);
				char_literal94=(IToken)Match(input,38,Follow._38_in_loopExpr939); 
				DebugLocation(185, 13);
				// Lang2.g:185:13: ( assExpr )*
				try { DebugEnterSubRule(22);
				while (true)
				{
					int alt22=2;
					try { DebugEnterDecision(22, decisionCanBacktrack[22]);
					int LA22_0 = input.LA(1);

					if ((LA22_0==VAR))
					{
						alt22=1;
					}


					} finally { DebugExitDecision(22); }
					switch ( alt22 )
					{
					case 1:
						DebugEnterAlt(1);
						// Lang2.g:185:13: assExpr
						{
						DebugLocation(185, 13);
						PushFollow(Follow._assExpr_in_loopExpr941);
						assExpr95=assExpr();
						PopFollow();

						adaptor.AddChild(root_0, assExpr95.Tree);

						}
						break;

					default:
						goto loop22;
					}
				}

				loop22:
					;

				} finally { DebugExitSubRule(22); }

				DebugLocation(185, 27);
				OP_END96=(IToken)Match(input,OP_END,Follow._OP_END_in_loopExpr943); 
				DebugLocation(185, 28);
				// Lang2.g:185:28: ( boolExpr )*
				try { DebugEnterSubRule(23);
				while (true)
				{
					int alt23=2;
					try { DebugEnterDecision(23, decisionCanBacktrack[23]);
					int LA23_0 = input.LA(1);

					if (((LA23_0>=BOOL && LA23_0<=VAR)))
					{
						alt23=1;
					}


					} finally { DebugExitDecision(23); }
					switch ( alt23 )
					{
					case 1:
						DebugEnterAlt(1);
						// Lang2.g:185:28: boolExpr
						{
						DebugLocation(185, 28);
						PushFollow(Follow._boolExpr_in_loopExpr945);
						boolExpr97=boolExpr();
						PopFollow();

						adaptor.AddChild(root_0, boolExpr97.Tree);

						}
						break;

					default:
						goto loop23;
					}
				}

				loop23:
					;

				} finally { DebugExitSubRule(23); }

				DebugLocation(185, 43);
				OP_END98=(IToken)Match(input,OP_END,Follow._OP_END_in_loopExpr947); 
				DebugLocation(185, 44);
				// Lang2.g:185:44: ( assExpr )*
				try { DebugEnterSubRule(24);
				while (true)
				{
					int alt24=2;
					try { DebugEnterDecision(24, decisionCanBacktrack[24]);
					int LA24_0 = input.LA(1);

					if ((LA24_0==VAR))
					{
						alt24=1;
					}


					} finally { DebugExitDecision(24); }
					switch ( alt24 )
					{
					case 1:
						DebugEnterAlt(1);
						// Lang2.g:185:44: assExpr
						{
						DebugLocation(185, 44);
						PushFollow(Follow._assExpr_in_loopExpr949);
						assExpr99=assExpr();
						PopFollow();

						adaptor.AddChild(root_0, assExpr99.Tree);

						}
						break;

					default:
						goto loop24;
					}
				}

				loop24:
					;

				} finally { DebugExitSubRule(24); }

				DebugLocation(185, 55);
				char_literal100=(IToken)Match(input,39,Follow._39_in_loopExpr951); 
				DebugLocation(185, 60);
				char_literal101=(IToken)Match(input,45,Follow._45_in_loopExpr954); 
				DebugLocation(185, 69);
				// Lang2.g:185:69: ( funcExpr )*
				try { DebugEnterSubRule(25);
				while (true)
				{
					int alt25=2;
					try { DebugEnterDecision(25, decisionCanBacktrack[25]);
					int LA25_0 = input.LA(1);

					if ((LA25_0==VITOCHKA||(LA25_0>=IF && LA25_0<=FOR)||LA25_0==VAR||(LA25_0>=35 && LA25_0<=37)))
					{
						alt25=1;
					}


					} finally { DebugExitDecision(25); }
					switch ( alt25 )
					{
					case 1:
						DebugEnterAlt(1);
						// Lang2.g:185:69: funcExpr
						{
						DebugLocation(185, 69);
						PushFollow(Follow._funcExpr_in_loopExpr956);
						funcExpr102=funcExpr();
						PopFollow();

						root_0 = (object)adaptor.BecomeRoot(funcExpr102.Tree, root_0);

						}
						break;

					default:
						goto loop25;
					}
				}

				loop25:
					;

				} finally { DebugExitSubRule(25); }

				DebugLocation(185, 74);
				char_literal103=(IToken)Match(input,46,Follow._46_in_loopExpr959); 

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("loopExpr", 22);
			LeaveRule("loopExpr", 22);
			Leave_loopExpr();
		}
		DebugLocation(186, 2);
		} finally { DebugExitRule(GrammarFileName, "loopExpr"); }
		return retval;

	}
	// $ANTLR end "loopExpr"

	public class assExpr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_assExpr();
	partial void Leave_assExpr();

	// $ANTLR start "assExpr"
	// Lang2.g:188:1: assExpr : VAR ASS expressions ;
	[GrammarRule("assExpr")]
	private Lang2Parser.assExpr_return assExpr()
	{
		Enter_assExpr();
		EnterRule("assExpr", 23);
		TraceIn("assExpr", 23);
		Lang2Parser.assExpr_return retval = new Lang2Parser.assExpr_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken VAR104=null;
		IToken ASS105=null;
		Lang2Parser.expressions_return expressions106 = default(Lang2Parser.expressions_return);

		object VAR104_tree=null;
		object ASS105_tree=null;

		try { DebugEnterRule(GrammarFileName, "assExpr");
		DebugLocation(188, 1);
		try
		{
			// Lang2.g:188:9: ( VAR ASS expressions )
			DebugEnterAlt(1);
			// Lang2.g:188:11: VAR ASS expressions
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(188, 11);
			VAR104=(IToken)Match(input,VAR,Follow._VAR_in_assExpr972); 
			VAR104_tree = (object)adaptor.Create(VAR104);
			adaptor.AddChild(root_0, VAR104_tree);

			DebugLocation(188, 18);
			ASS105=(IToken)Match(input,ASS,Follow._ASS_in_assExpr974); 
			ASS105_tree = (object)adaptor.Create(ASS105);
			root_0 = (object)adaptor.BecomeRoot(ASS105_tree, root_0);

			DebugLocation(188, 20);
			PushFollow(Follow._expressions_in_assExpr977);
			expressions106=expressions();
			PopFollow();

			adaptor.AddChild(root_0, expressions106.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("assExpr", 23);
			LeaveRule("assExpr", 23);
			Leave_assExpr();
		}
		DebugLocation(189, 1);
		} finally { DebugExitRule(GrammarFileName, "assExpr"); }
		return retval;

	}
	// $ANTLR end "assExpr"

	public class varDecl_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_varDecl();
	partial void Leave_varDecl();

	// $ANTLR start "varDecl"
	// Lang2.g:191:1: varDecl : ( typeDecl VAR OP_END -> ^( VARDECL typeDecl VAR ) | typeDecl assExpr OP_END -> ^( VARDECL typeDecl assExpr ) );
	[GrammarRule("varDecl")]
	private Lang2Parser.varDecl_return varDecl()
	{
		Enter_varDecl();
		EnterRule("varDecl", 24);
		TraceIn("varDecl", 24);
		Lang2Parser.varDecl_return retval = new Lang2Parser.varDecl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken VAR108=null;
		IToken OP_END109=null;
		IToken OP_END112=null;
		Lang2Parser.typeDecl_return typeDecl107 = default(Lang2Parser.typeDecl_return);
		Lang2Parser.typeDecl_return typeDecl110 = default(Lang2Parser.typeDecl_return);
		Lang2Parser.assExpr_return assExpr111 = default(Lang2Parser.assExpr_return);

		object VAR108_tree=null;
		object OP_END109_tree=null;
		object OP_END112_tree=null;
		RewriteRuleITokenStream stream_VAR=new RewriteRuleITokenStream(adaptor,"token VAR");
		RewriteRuleITokenStream stream_OP_END=new RewriteRuleITokenStream(adaptor,"token OP_END");
		RewriteRuleSubtreeStream stream_typeDecl=new RewriteRuleSubtreeStream(adaptor,"rule typeDecl");
		RewriteRuleSubtreeStream stream_assExpr=new RewriteRuleSubtreeStream(adaptor,"rule assExpr");
		try { DebugEnterRule(GrammarFileName, "varDecl");
		DebugLocation(191, 2);
		try
		{
			// Lang2.g:191:9: ( typeDecl VAR OP_END -> ^( VARDECL typeDecl VAR ) | typeDecl assExpr OP_END -> ^( VARDECL typeDecl assExpr ) )
			int alt27=2;
			try { DebugEnterDecision(27, decisionCanBacktrack[27]);
			int LA27_0 = input.LA(1);

			if (((LA27_0>=35 && LA27_0<=37)))
			{
				int LA27_1 = input.LA(2);

				if ((LA27_1==VAR))
				{
					int LA27_2 = input.LA(3);

					if ((LA27_2==OP_END))
					{
						alt27=1;
					}
					else if ((LA27_2==ASS))
					{
						alt27=2;
					}
					else
					{
						NoViableAltException nvae = new NoViableAltException("", 27, 2, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
				}
				else
				{
					NoViableAltException nvae = new NoViableAltException("", 27, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				NoViableAltException nvae = new NoViableAltException("", 27, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(27); }
			switch (alt27)
			{
			case 1:
				DebugEnterAlt(1);
				// Lang2.g:191:11: typeDecl VAR OP_END
				{
				DebugLocation(191, 11);
				PushFollow(Follow._typeDecl_in_varDecl987);
				typeDecl107=typeDecl();
				PopFollow();

				stream_typeDecl.Add(typeDecl107.Tree);
				DebugLocation(191, 23);
				VAR108=(IToken)Match(input,VAR,Follow._VAR_in_varDecl989);  
				stream_VAR.Add(VAR108);

				DebugLocation(191, 31);
				OP_END109=(IToken)Match(input,OP_END,Follow._OP_END_in_varDecl992);  
				stream_OP_END.Add(OP_END109);



				{
				// AST REWRITE
				// elements: VAR, typeDecl
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 191:33: -> ^( VARDECL typeDecl VAR )
				{
					DebugLocation(191, 36);
					// Lang2.g:191:36: ^( VARDECL typeDecl VAR )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(191, 38);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARDECL, "VARDECL"), root_1);

					DebugLocation(191, 46);
					adaptor.AddChild(root_1, stream_typeDecl.NextTree());
					DebugLocation(191, 55);
					adaptor.AddChild(root_1, stream_VAR.NextNode());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Lang2.g:192:5: typeDecl assExpr OP_END
				{
				DebugLocation(192, 5);
				PushFollow(Follow._typeDecl_in_varDecl1009);
				typeDecl110=typeDecl();
				PopFollow();

				stream_typeDecl.Add(typeDecl110.Tree);
				DebugLocation(192, 14);
				PushFollow(Follow._assExpr_in_varDecl1011);
				assExpr111=assExpr();
				PopFollow();

				stream_assExpr.Add(assExpr111.Tree);
				DebugLocation(192, 28);
				OP_END112=(IToken)Match(input,OP_END,Follow._OP_END_in_varDecl1013);  
				stream_OP_END.Add(OP_END112);



				{
				// AST REWRITE
				// elements: assExpr, typeDecl
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 192:30: -> ^( VARDECL typeDecl assExpr )
				{
					DebugLocation(192, 33);
					// Lang2.g:192:33: ^( VARDECL typeDecl assExpr )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(192, 35);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARDECL, "VARDECL"), root_1);

					DebugLocation(192, 43);
					adaptor.AddChild(root_1, stream_typeDecl.NextTree());
					DebugLocation(192, 52);
					adaptor.AddChild(root_1, stream_assExpr.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("varDecl", 24);
			LeaveRule("varDecl", 24);
			Leave_varDecl();
		}
		DebugLocation(193, 2);
		} finally { DebugExitRule(GrammarFileName, "varDecl"); }
		return retval;

	}
	// $ANTLR end "varDecl"

	public class elseFuncExec_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_elseFuncExec();
	partial void Leave_elseFuncExec();

	// $ANTLR start "elseFuncExec"
	// Lang2.g:195:1: elseFuncExec : funcExec ;
	[GrammarRule("elseFuncExec")]
	private Lang2Parser.elseFuncExec_return elseFuncExec()
	{
		Enter_elseFuncExec();
		EnterRule("elseFuncExec", 25);
		TraceIn("elseFuncExec", 25);
		Lang2Parser.elseFuncExec_return retval = new Lang2Parser.elseFuncExec_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		Lang2Parser.funcExec_return funcExec113 = default(Lang2Parser.funcExec_return);


		try { DebugEnterRule(GrammarFileName, "elseFuncExec");
		DebugLocation(195, 4);
		try
		{
			// Lang2.g:195:14: ( funcExec )
			DebugEnterAlt(1);
			// Lang2.g:195:16: funcExec
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(195, 16);
			PushFollow(Follow._funcExec_in_elseFuncExec1035);
			funcExec113=funcExec();
			PopFollow();

			adaptor.AddChild(root_0, funcExec113.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("elseFuncExec", 25);
			LeaveRule("elseFuncExec", 25);
			Leave_elseFuncExec();
		}
		DebugLocation(196, 4);
		} finally { DebugExitRule(GrammarFileName, "elseFuncExec"); }
		return retval;

	}
	// $ANTLR end "elseFuncExec"

	public class execParamsRule_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_execParamsRule();
	partial void Leave_execParamsRule();

	// $ANTLR start "execParamsRule"
	// Lang2.g:199:1: execParamsRule : ( expressions | funcExec ) ;
	[GrammarRule("execParamsRule")]
	private Lang2Parser.execParamsRule_return execParamsRule()
	{
		Enter_execParamsRule();
		EnterRule("execParamsRule", 26);
		TraceIn("execParamsRule", 26);
		Lang2Parser.execParamsRule_return retval = new Lang2Parser.execParamsRule_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		Lang2Parser.expressions_return expressions114 = default(Lang2Parser.expressions_return);
		Lang2Parser.funcExec_return funcExec115 = default(Lang2Parser.funcExec_return);


		try { DebugEnterRule(GrammarFileName, "execParamsRule");
		DebugLocation(199, 4);
		try
		{
			// Lang2.g:199:16: ( ( expressions | funcExec ) )
			DebugEnterAlt(1);
			// Lang2.g:199:18: ( expressions | funcExec )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(199, 18);
			// Lang2.g:199:18: ( expressions | funcExec )
			int alt28=2;
			try { DebugEnterSubRule(28);
			try { DebugEnterDecision(28, decisionCanBacktrack[28]);
			int LA28_0 = input.LA(1);

			if ((LA28_0==BOOL||(LA28_0>=INT && LA28_0<=STRING)||LA28_0==38))
			{
				alt28=1;
			}
			else if ((LA28_0==VAR))
			{
				int LA28_2 = input.LA(2);

				if ((LA28_2==38))
				{
					alt28=2;
				}
				else if (((LA28_2>=ADD && LA28_2<=DIV)||LA28_2==IS_MORE||(LA28_2>=IS_LESS && LA28_2<=IS_EQUALLY)||LA28_2==39||LA28_2==44))
				{
					alt28=1;
				}
				else
				{
					NoViableAltException nvae = new NoViableAltException("", 28, 2, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				NoViableAltException nvae = new NoViableAltException("", 28, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(28); }
			switch (alt28)
			{
			case 1:
				DebugEnterAlt(1);
				// Lang2.g:199:19: expressions
				{
				DebugLocation(199, 19);
				PushFollow(Follow._expressions_in_execParamsRule1050);
				expressions114=expressions();
				PopFollow();

				adaptor.AddChild(root_0, expressions114.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Lang2.g:199:31: funcExec
				{
				DebugLocation(199, 31);
				PushFollow(Follow._funcExec_in_execParamsRule1052);
				funcExec115=funcExec();
				PopFollow();

				adaptor.AddChild(root_0, funcExec115.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(28); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("execParamsRule", 26);
			LeaveRule("execParamsRule", 26);
			Leave_execParamsRule();
		}
		DebugLocation(200, 4);
		} finally { DebugExitRule(GrammarFileName, "execParamsRule"); }
		return retval;

	}
	// $ANTLR end "execParamsRule"

	public class funcExec_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_funcExec();
	partial void Leave_funcExec();

	// $ANTLR start "funcExec"
	// Lang2.g:202:1: funcExec : VAR '(' execParamsRule ( ',' execParamsRule )* ')' OP_END ;
	[GrammarRule("funcExec")]
	private Lang2Parser.funcExec_return funcExec()
	{
		Enter_funcExec();
		EnterRule("funcExec", 27);
		TraceIn("funcExec", 27);
		Lang2Parser.funcExec_return retval = new Lang2Parser.funcExec_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken VAR116=null;
		IToken char_literal117=null;
		IToken char_literal119=null;
		IToken char_literal121=null;
		IToken OP_END122=null;
		Lang2Parser.execParamsRule_return execParamsRule118 = default(Lang2Parser.execParamsRule_return);
		Lang2Parser.execParamsRule_return execParamsRule120 = default(Lang2Parser.execParamsRule_return);

		object VAR116_tree=null;
		object char_literal117_tree=null;
		object char_literal119_tree=null;
		object char_literal121_tree=null;
		object OP_END122_tree=null;

		try { DebugEnterRule(GrammarFileName, "funcExec");
		DebugLocation(202, 3);
		try
		{
			// Lang2.g:202:10: ( VAR '(' execParamsRule ( ',' execParamsRule )* ')' OP_END )
			DebugEnterAlt(1);
			// Lang2.g:202:12: VAR '(' execParamsRule ( ',' execParamsRule )* ')' OP_END
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(202, 15);
			VAR116=(IToken)Match(input,VAR,Follow._VAR_in_funcExec1066); 
			VAR116_tree = (object)adaptor.Create(VAR116);
			root_0 = (object)adaptor.BecomeRoot(VAR116_tree, root_0);

			DebugLocation(202, 19);
			char_literal117=(IToken)Match(input,38,Follow._38_in_funcExec1068); 
			DebugLocation(202, 20);
			PushFollow(Follow._execParamsRule_in_funcExec1070);
			execParamsRule118=execParamsRule();
			PopFollow();

			adaptor.AddChild(root_0, execParamsRule118.Tree);
			DebugLocation(202, 35);
			// Lang2.g:202:35: ( ',' execParamsRule )*
			try { DebugEnterSubRule(29);
			while (true)
			{
				int alt29=2;
				try { DebugEnterDecision(29, decisionCanBacktrack[29]);
				int LA29_0 = input.LA(1);

				if ((LA29_0==44))
				{
					alt29=1;
				}


				} finally { DebugExitDecision(29); }
				switch ( alt29 )
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:202:36: ',' execParamsRule
					{
					DebugLocation(202, 36);
					char_literal119=(IToken)Match(input,44,Follow._44_in_funcExec1073); 
					char_literal119_tree = (object)adaptor.Create(char_literal119);
					adaptor.AddChild(root_0, char_literal119_tree);

					DebugLocation(202, 39);
					PushFollow(Follow._execParamsRule_in_funcExec1074);
					execParamsRule120=execParamsRule();
					PopFollow();

					adaptor.AddChild(root_0, execParamsRule120.Tree);

					}
					break;

				default:
					goto loop29;
				}
			}

			loop29:
				;

			} finally { DebugExitSubRule(29); }

			DebugLocation(202, 58);
			char_literal121=(IToken)Match(input,39,Follow._39_in_funcExec1077); 
			DebugLocation(202, 66);
			OP_END122=(IToken)Match(input,OP_END,Follow._OP_END_in_funcExec1080); 

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("funcExec", 27);
			LeaveRule("funcExec", 27);
			Leave_funcExec();
		}
		DebugLocation(203, 3);
		} finally { DebugExitRule(GrammarFileName, "funcExec"); }
		return retval;

	}
	// $ANTLR end "funcExec"

	public class funcExpr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_funcExpr();
	partial void Leave_funcExpr();

	// $ANTLR start "funcExpr"
	// Lang2.g:205:1: funcExpr : ( varDecl | arrDecl | funcExec | assExpr OP_END | conditionExpr | loopExpr | VITOCHKA OP_END | arrExec );
	[GrammarRule("funcExpr")]
	private Lang2Parser.funcExpr_return funcExpr()
	{
		Enter_funcExpr();
		EnterRule("funcExpr", 28);
		TraceIn("funcExpr", 28);
		Lang2Parser.funcExpr_return retval = new Lang2Parser.funcExpr_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken OP_END127=null;
		IToken VITOCHKA130=null;
		IToken OP_END131=null;
		Lang2Parser.varDecl_return varDecl123 = default(Lang2Parser.varDecl_return);
		Lang2Parser.arrDecl_return arrDecl124 = default(Lang2Parser.arrDecl_return);
		Lang2Parser.funcExec_return funcExec125 = default(Lang2Parser.funcExec_return);
		Lang2Parser.assExpr_return assExpr126 = default(Lang2Parser.assExpr_return);
		Lang2Parser.conditionExpr_return conditionExpr128 = default(Lang2Parser.conditionExpr_return);
		Lang2Parser.loopExpr_return loopExpr129 = default(Lang2Parser.loopExpr_return);
		Lang2Parser.arrExec_return arrExec132 = default(Lang2Parser.arrExec_return);

		object OP_END127_tree=null;
		object VITOCHKA130_tree=null;
		object OP_END131_tree=null;

		try { DebugEnterRule(GrammarFileName, "funcExpr");
		DebugLocation(205, 1);
		try
		{
			// Lang2.g:205:9: ( varDecl | arrDecl | funcExec | assExpr OP_END | conditionExpr | loopExpr | VITOCHKA OP_END | arrExec )
			int alt30=8;
			try { DebugEnterDecision(30, decisionCanBacktrack[30]);
			try
			{
				alt30 = dfa30.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(30); }
			switch (alt30)
			{
			case 1:
				DebugEnterAlt(1);
				// Lang2.g:205:11: varDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(205, 11);
				PushFollow(Follow._varDecl_in_funcExpr1092);
				varDecl123=varDecl();
				PopFollow();

				adaptor.AddChild(root_0, varDecl123.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Lang2.g:206:5: arrDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(206, 5);
				PushFollow(Follow._arrDecl_in_funcExpr1098);
				arrDecl124=arrDecl();
				PopFollow();

				adaptor.AddChild(root_0, arrDecl124.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Lang2.g:207:5: funcExec
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(207, 5);
				PushFollow(Follow._funcExec_in_funcExpr1104);
				funcExec125=funcExec();
				PopFollow();

				adaptor.AddChild(root_0, funcExec125.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// Lang2.g:208:5: assExpr OP_END
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(208, 5);
				PushFollow(Follow._assExpr_in_funcExpr1110);
				assExpr126=assExpr();
				PopFollow();

				adaptor.AddChild(root_0, assExpr126.Tree);
				DebugLocation(208, 19);
				OP_END127=(IToken)Match(input,OP_END,Follow._OP_END_in_funcExpr1112); 

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// Lang2.g:209:5: conditionExpr
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(209, 5);
				PushFollow(Follow._conditionExpr_in_funcExpr1119);
				conditionExpr128=conditionExpr();
				PopFollow();

				adaptor.AddChild(root_0, conditionExpr128.Tree);

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// Lang2.g:210:5: loopExpr
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(210, 5);
				PushFollow(Follow._loopExpr_in_funcExpr1125);
				loopExpr129=loopExpr();
				PopFollow();

				adaptor.AddChild(root_0, loopExpr129.Tree);

				}
				break;
			case 7:
				DebugEnterAlt(7);
				// Lang2.g:211:5: VITOCHKA OP_END
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(211, 5);
				VITOCHKA130=(IToken)Match(input,VITOCHKA,Follow._VITOCHKA_in_funcExpr1131); 
				VITOCHKA130_tree = (object)adaptor.Create(VITOCHKA130);
				adaptor.AddChild(root_0, VITOCHKA130_tree);

				DebugLocation(211, 13);
				Console.WriteLine("Meow Meow Meow");
				DebugLocation(211, 58);
				OP_END131=(IToken)Match(input,OP_END,Follow._OP_END_in_funcExpr1134); 

				}
				break;
			case 8:
				DebugEnterAlt(8);
				// Lang2.g:212:5: arrExec
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(212, 5);
				PushFollow(Follow._arrExec_in_funcExpr1141);
				arrExec132=arrExec();
				PopFollow();

				adaptor.AddChild(root_0, arrExec132.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("funcExpr", 28);
			LeaveRule("funcExpr", 28);
			Leave_funcExpr();
		}
		DebugLocation(213, 1);
		} finally { DebugExitRule(GrammarFileName, "funcExpr"); }
		return retval;

	}
	// $ANTLR end "funcExpr"

	public class expr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_expr();
	partial void Leave_expr();

	// $ANTLR start "expr"
	// Lang2.g:215:1: expr : ( funcDecl | varDecl );
	[GrammarRule("expr")]
	private Lang2Parser.expr_return expr()
	{
		Enter_expr();
		EnterRule("expr", 29);
		TraceIn("expr", 29);
		Lang2Parser.expr_return retval = new Lang2Parser.expr_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		Lang2Parser.funcDecl_return funcDecl133 = default(Lang2Parser.funcDecl_return);
		Lang2Parser.varDecl_return varDecl134 = default(Lang2Parser.varDecl_return);


		try { DebugEnterRule(GrammarFileName, "expr");
		DebugLocation(215, 1);
		try
		{
			// Lang2.g:215:6: ( funcDecl | varDecl )
			int alt31=2;
			try { DebugEnterDecision(31, decisionCanBacktrack[31]);
			int LA31_0 = input.LA(1);

			if (((LA31_0>=35 && LA31_0<=37)))
			{
				int LA31_1 = input.LA(2);

				if ((LA31_1==VAR))
				{
					int LA31_3 = input.LA(3);

					if ((LA31_3==38))
					{
						alt31=1;
					}
					else if ((LA31_3==OP_END||LA31_3==ASS))
					{
						alt31=2;
					}
					else
					{
						NoViableAltException nvae = new NoViableAltException("", 31, 3, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
				}
				else
				{
					NoViableAltException nvae = new NoViableAltException("", 31, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else if ((LA31_0==43))
			{
				alt31=1;
			}
			else
			{
				NoViableAltException nvae = new NoViableAltException("", 31, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(31); }
			switch (alt31)
			{
			case 1:
				DebugEnterAlt(1);
				// Lang2.g:215:8: funcDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(215, 8);
				PushFollow(Follow._funcDecl_in_expr1151);
				funcDecl133=funcDecl();
				PopFollow();

				adaptor.AddChild(root_0, funcDecl133.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Lang2.g:216:5: varDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(216, 5);
				PushFollow(Follow._varDecl_in_expr1157);
				varDecl134=varDecl();
				PopFollow();

				adaptor.AddChild(root_0, varDecl134.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("expr", 29);
			LeaveRule("expr", 29);
			Leave_expr();
		}
		DebugLocation(217, 1);
		} finally { DebugExitRule(GrammarFileName, "expr"); }
		return retval;

	}
	// $ANTLR end "expr"

	public class program_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_program();
	partial void Leave_program();

	// $ANTLR start "program"
	// Lang2.g:219:1: program : ( expr )+ ;
	[GrammarRule("program")]
	private Lang2Parser.program_return program()
	{
		Enter_program();
		EnterRule("program", 30);
		TraceIn("program", 30);
		Lang2Parser.program_return retval = new Lang2Parser.program_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		Lang2Parser.expr_return expr135 = default(Lang2Parser.expr_return);


		try { DebugEnterRule(GrammarFileName, "program");
		DebugLocation(219, 16);
		try
		{
			// Lang2.g:219:8: ( ( expr )+ )
			DebugEnterAlt(1);
			// Lang2.g:219:10: ( expr )+
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(219, 10);
			// Lang2.g:219:10: ( expr )+
			int cnt32=0;
			try { DebugEnterSubRule(32);
			while (true)
			{
				int alt32=2;
				try { DebugEnterDecision(32, decisionCanBacktrack[32]);
				int LA32_0 = input.LA(1);

				if (((LA32_0>=35 && LA32_0<=37)||LA32_0==43))
				{
					alt32=1;
				}


				} finally { DebugExitDecision(32); }
				switch (alt32)
				{
				case 1:
					DebugEnterAlt(1);
					// Lang2.g:219:10: expr
					{
					DebugLocation(219, 10);
					PushFollow(Follow._expr_in_program1167);
					expr135=expr();
					PopFollow();

					adaptor.AddChild(root_0, expr135.Tree);

					}
					break;

				default:
					if (cnt32 >= 1)
						goto loop32;

					EarlyExitException eee32 = new EarlyExitException( 32, input );
					DebugRecognitionException(eee32);
					throw eee32;
				}
				cnt32++;
			}
			loop32:
				;

			} finally { DebugExitSubRule(32); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("program", 30);
			LeaveRule("program", 30);
			Leave_program();
		}
		DebugLocation(219, 16);
		} finally { DebugExitRule(GrammarFileName, "program"); }
		return retval;

	}
	// $ANTLR end "program"

	public class result_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_result();
	partial void Leave_result();

	// $ANTLR start "result"
	// Lang2.g:220:1: result : program EOF -> ^( PROGRAM program ) ;
	[GrammarRule("result")]
	private Lang2Parser.result_return result()
	{
		Enter_result();
		EnterRule("result", 31);
		TraceIn("result", 31);
		Lang2Parser.result_return retval = new Lang2Parser.result_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken EOF137=null;
		Lang2Parser.program_return program136 = default(Lang2Parser.program_return);

		object EOF137_tree=null;
		RewriteRuleITokenStream stream_EOF=new RewriteRuleITokenStream(adaptor,"token EOF");
		RewriteRuleSubtreeStream stream_program=new RewriteRuleSubtreeStream(adaptor,"rule program");
		try { DebugEnterRule(GrammarFileName, "result");
		DebugLocation(220, 41);
		try
		{
			// Lang2.g:220:7: ( program EOF -> ^( PROGRAM program ) )
			DebugEnterAlt(1);
			// Lang2.g:220:9: program EOF
			{
			DebugLocation(220, 9);
			PushFollow(Follow._program_in_result1176);
			program136=program();
			PopFollow();

			stream_program.Add(program136.Tree);
			DebugLocation(220, 17);
			EOF137=(IToken)Match(input,EOF,Follow._EOF_in_result1178);  
			stream_EOF.Add(EOF137);



			{
			// AST REWRITE
			// elements: program
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 220:21: -> ^( PROGRAM program )
			{
				DebugLocation(220, 24);
				// Lang2.g:220:24: ^( PROGRAM program )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(220, 26);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PROGRAM, "PROGRAM"), root_1);

				DebugLocation(220, 34);
				adaptor.AddChild(root_1, stream_program.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("result", 31);
			LeaveRule("result", 31);
			Leave_result();
		}
		DebugLocation(220, 41);
		} finally { DebugExitRule(GrammarFileName, "result"); }
		return retval;

	}
	// $ANTLR end "result"

	public class execute_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_execute();
	partial void Leave_execute();

	// $ANTLR start "execute"
	// Lang2.g:221:8: public execute : result ;
	[GrammarRule("execute")]
	public Lang2Parser.execute_return execute()
	{
		Enter_execute();
		EnterRule("execute", 32);
		TraceIn("execute", 32);
		Lang2Parser.execute_return retval = new Lang2Parser.execute_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		Lang2Parser.result_return result138 = default(Lang2Parser.result_return);


		try { DebugEnterRule(GrammarFileName, "execute");
		DebugLocation(221, 23);
		try
		{
			// Lang2.g:221:15: ( result )
			DebugEnterAlt(1);
			// Lang2.g:221:18: result
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(221, 18);
			PushFollow(Follow._result_in_execute1195);
			result138=result();
			PopFollow();

			adaptor.AddChild(root_0, result138.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("execute", 32);
			LeaveRule("execute", 32);
			Leave_execute();
		}
		DebugLocation(221, 23);
		} finally { DebugExitRule(GrammarFileName, "execute"); }
		return retval;

	}
	// $ANTLR end "execute"
	#endregion Rules


	#region DFA
	DFA30 dfa30;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa30 = new DFA30( this );
	}

	private class DFA30 : DFA
	{
		private const string DFA30_eotS =
			"\xC\xFFFF";
		private const string DFA30_eofS =
			"\xC\xFFFF";
		private const string DFA30_minS =
			"\x1\x17\x1\x20\x1\x13\x3\xFFFF\x1\xD\x5\xFFFF";
		private const string DFA30_maxS =
			"\x1\x25\x1\x20\x1\x29\x3\xFFFF\x1\x28\x5\xFFFF";
		private const string DFA30_acceptS =
			"\x3\xFFFF\x1\x5\x1\x6\x1\x7\x1\xFFFF\x1\x3\x1\x4\x1\x8\x1\x1\x1\x2";
		private const string DFA30_specialS =
			"\xC\xFFFF}>";
		private static readonly string[] DFA30_transitionS =
			{
				"\x1\x5\x3\xFFFF\x1\x3\x3\x4\x1\xFFFF\x1\x2\x2\xFFFF\x3\x1",
				"\x1\x6",
				"\x1\x8\x12\xFFFF\x1\x7\x2\xFFFF\x1\x9",
				"",
				"",
				"",
				"\x1\xA\x5\xFFFF\x1\xA\x14\xFFFF\x1\xB",
				"",
				"",
				"",
				"",
				""
			};

		private static readonly short[] DFA30_eot = DFA.UnpackEncodedString(DFA30_eotS);
		private static readonly short[] DFA30_eof = DFA.UnpackEncodedString(DFA30_eofS);
		private static readonly char[] DFA30_min = DFA.UnpackEncodedStringToUnsignedChars(DFA30_minS);
		private static readonly char[] DFA30_max = DFA.UnpackEncodedStringToUnsignedChars(DFA30_maxS);
		private static readonly short[] DFA30_accept = DFA.UnpackEncodedString(DFA30_acceptS);
		private static readonly short[] DFA30_special = DFA.UnpackEncodedString(DFA30_specialS);
		private static readonly short[][] DFA30_transition;

		static DFA30()
		{
			int numStates = DFA30_transitionS.Length;
			DFA30_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA30_transition[i] = DFA.UnpackEncodedString(DFA30_transitionS[i]);
			}
		}

		public DFA30( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 30;
			this.eot = DFA30_eot;
			this.eof = DFA30_eof;
			this.min = DFA30_min;
			this.max = DFA30_max;
			this.accept = DFA30_accept;
			this.special = DFA30_special;
			this.transition = DFA30_transition;
		}

		public override string Description { get { return "205:1: funcExpr : ( varDecl | arrDecl | funcExec | assExpr OP_END | conditionExpr | loopExpr | VITOCHKA OP_END | arrExec );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}


	#endregion DFA

	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _set_in_stringGroup0 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _stringGroup_in_stringExpr394 = new BitSet(new ulong[]{0x8002UL});
		public static readonly BitSet _ADD_in_stringExpr396 = new BitSet(new ulong[]{0x500000000UL});
		public static readonly BitSet _stringGroup_in_stringExpr398 = new BitSet(new ulong[]{0x8002UL});
		public static readonly BitSet _set_in_typeDecl0 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_boolGroup0 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolGroup_in_boolElse453 = new BitSet(new ulong[]{0x3400000UL});
		public static readonly BitSet _set_in_boolElse455 = new BitSet(new ulong[]{0x180000000UL});
		public static readonly BitSet _boolGroup_in_boolElse463 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolElse_in_boolAdd472 = new BitSet(new ulong[]{0x200002UL});
		public static readonly BitSet _CONJUCTION_in_boolAdd474 = new BitSet(new ulong[]{0x180000000UL});
		public static readonly BitSet _boolElse_in_boolAdd476 = new BitSet(new ulong[]{0x200002UL});
		public static readonly BitSet _boolAdd_in_boolAnd489 = new BitSet(new ulong[]{0x100002UL});
		public static readonly BitSet _DISJUNCTION_in_boolAnd491 = new BitSet(new ulong[]{0x180000000UL});
		public static readonly BitSet _boolAdd_in_boolAnd493 = new BitSet(new ulong[]{0x100002UL});
		public static readonly BitSet _boolAnd_in_boolInv506 = new BitSet(new ulong[]{0x4000002UL});
		public static readonly BitSet _INVERT_in_boolInv508 = new BitSet(new ulong[]{0x180000000UL});
		public static readonly BitSet _boolAnd_in_boolInv510 = new BitSet(new ulong[]{0x4000002UL});
		public static readonly BitSet _boolInv_in_boolExpr522 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _38_in_mathGroup538 = new BitSet(new ulong[]{0x4300000000UL});
		public static readonly BitSet _mathExpr_in_mathGroup540 = new BitSet(new ulong[]{0xC300000000UL});
		public static readonly BitSet _39_in_mathGroup542 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _INT_in_mathGroup549 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _VAR_in_mathGroup555 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mathGroup_in_mathMult568 = new BitSet(new ulong[]{0x60002UL});
		public static readonly BitSet _set_in_mathMult570 = new BitSet(new ulong[]{0x4300000000UL});
		public static readonly BitSet _mathGroup_in_mathMult576 = new BitSet(new ulong[]{0x60002UL});
		public static readonly BitSet _mathMult_in_mathAdd589 = new BitSet(new ulong[]{0x18002UL});
		public static readonly BitSet _set_in_mathAdd591 = new BitSet(new ulong[]{0x4300000000UL});
		public static readonly BitSet _mathMult_in_mathAdd597 = new BitSet(new ulong[]{0x18002UL});
		public static readonly BitSet _mathAdd_in_mathExpr611 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _mathExpr_in_expressions628 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolExpr_in_expressions630 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _stringExpr_in_expressions632 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _typeDecl_in_arrDecl641 = new BitSet(new ulong[]{0x100000000UL});
		public static readonly BitSet _VAR_in_arrDecl643 = new BitSet(new ulong[]{0x10000000000UL});
		public static readonly BitSet _40_in_arrDecl645 = new BitSet(new ulong[]{0x80000UL});
		public static readonly BitSet _ASS_in_arrDecl648 = new BitSet(new ulong[]{0x3800000000UL});
		public static readonly BitSet _typeDecl_in_arrDecl650 = new BitSet(new ulong[]{0x20000000000UL});
		public static readonly BitSet _41_in_arrDecl651 = new BitSet(new ulong[]{0x4780000000UL});
		public static readonly BitSet _expressions_in_arrDecl652 = new BitSet(new ulong[]{0x40000000000UL});
		public static readonly BitSet _42_in_arrDecl653 = new BitSet(new ulong[]{0x2000UL});
		public static readonly BitSet _OP_END_in_arrDecl655 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _VAR_in_arrExec685 = new BitSet(new ulong[]{0x20000000000UL});
		public static readonly BitSet _41_in_arrExec687 = new BitSet(new ulong[]{0x4780000000UL});
		public static readonly BitSet _expressions_in_arrExec690 = new BitSet(new ulong[]{0x40000000000UL});
		public static readonly BitSet _42_in_arrExec692 = new BitSet(new ulong[]{0x82000UL});
		public static readonly BitSet _ASS_in_arrExec696 = new BitSet(new ulong[]{0x4780000000UL});
		public static readonly BitSet _expressions_in_arrExec698 = new BitSet(new ulong[]{0x2000UL});
		public static readonly BitSet _OP_END_in_arrExec702 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _typeDecl_in_funcTypes725 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _43_in_funcTypes727 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _typeDecl_in_argRule745 = new BitSet(new ulong[]{0x100000000UL});
		public static readonly BitSet _VAR_in_argRule747 = new BitSet(new ulong[]{0x100000000002UL});
		public static readonly BitSet _44_in_argRule750 = new BitSet(new ulong[]{0x3800000000UL});
		public static readonly BitSet _typeDecl_in_argRule753 = new BitSet(new ulong[]{0x100000000UL});
		public static readonly BitSet _VAR_in_argRule755 = new BitSet(new ulong[]{0x100000000002UL});
		public static readonly BitSet _typeDecl_in_argRule781 = new BitSet(new ulong[]{0x100000000UL});
		public static readonly BitSet _VAR_in_argRule783 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funcExpr_in_funcDeclSub814 = new BitSet(new ulong[]{0x3978800002UL});
		public static readonly BitSet _funcTypes_in_funcDecl836 = new BitSet(new ulong[]{0x100000000UL});
		public static readonly BitSet _VAR_in_funcDecl838 = new BitSet(new ulong[]{0x4000000000UL});
		public static readonly BitSet _38_in_funcDecl840 = new BitSet(new ulong[]{0xB800000000UL});
		public static readonly BitSet _argRule_in_funcDecl842 = new BitSet(new ulong[]{0x8000000000UL});
		public static readonly BitSet _39_in_funcDecl843 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _45_in_funcDecl845 = new BitSet(new ulong[]{0x3978800000UL});
		public static readonly BitSet _funcDeclSub_in_funcDecl847 = new BitSet(new ulong[]{0x400000000000UL});
		public static readonly BitSet _46_in_funcDecl848 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IF_in_conditionExpr872 = new BitSet(new ulong[]{0x4000000000UL});
		public static readonly BitSet _38_in_conditionExpr874 = new BitSet(new ulong[]{0x180000000UL});
		public static readonly BitSet _boolExpr_in_conditionExpr876 = new BitSet(new ulong[]{0x8180000000UL});
		public static readonly BitSet _39_in_conditionExpr878 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _45_in_conditionExpr880 = new BitSet(new ulong[]{0x403978800000UL});
		public static readonly BitSet _funcExpr_in_conditionExpr882 = new BitSet(new ulong[]{0x403978800000UL});
		public static readonly BitSet _46_in_conditionExpr884 = new BitSet(new ulong[]{0x800000000000UL});
		public static readonly BitSet _47_in_conditionExpr888 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _45_in_conditionExpr889 = new BitSet(new ulong[]{0x403978800000UL});
		public static readonly BitSet _funcExpr_in_conditionExpr891 = new BitSet(new ulong[]{0x403978800000UL});
		public static readonly BitSet _46_in_conditionExpr893 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _WHILE_in_loopExpr904 = new BitSet(new ulong[]{0x4000000000UL});
		public static readonly BitSet _38_in_loopExpr906 = new BitSet(new ulong[]{0x180000000UL});
		public static readonly BitSet _boolExpr_in_loopExpr907 = new BitSet(new ulong[]{0x8180000000UL});
		public static readonly BitSet _39_in_loopExpr909 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _45_in_loopExpr910 = new BitSet(new ulong[]{0x483800000000UL});
		public static readonly BitSet _expr_in_loopExpr913 = new BitSet(new ulong[]{0x483800000000UL});
		public static readonly BitSet _46_in_loopExpr915 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _DO_in_loopExpr921 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _45_in_loopExpr922 = new BitSet(new ulong[]{0x403978800000UL});
		public static readonly BitSet _funcExpr_in_loopExpr924 = new BitSet(new ulong[]{0x403978800000UL});
		public static readonly BitSet _46_in_loopExpr926 = new BitSet(new ulong[]{0x10000000UL});
		public static readonly BitSet _WHILE_in_loopExpr927 = new BitSet(new ulong[]{0x2000UL});
		public static readonly BitSet _OP_END_in_loopExpr930 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FOR_in_loopExpr937 = new BitSet(new ulong[]{0x4000000000UL});
		public static readonly BitSet _38_in_loopExpr939 = new BitSet(new ulong[]{0x100002000UL});
		public static readonly BitSet _assExpr_in_loopExpr941 = new BitSet(new ulong[]{0x100002000UL});
		public static readonly BitSet _OP_END_in_loopExpr943 = new BitSet(new ulong[]{0x180002000UL});
		public static readonly BitSet _boolExpr_in_loopExpr945 = new BitSet(new ulong[]{0x180002000UL});
		public static readonly BitSet _OP_END_in_loopExpr947 = new BitSet(new ulong[]{0x8100000000UL});
		public static readonly BitSet _assExpr_in_loopExpr949 = new BitSet(new ulong[]{0x8100000000UL});
		public static readonly BitSet _39_in_loopExpr951 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _45_in_loopExpr954 = new BitSet(new ulong[]{0x403978800000UL});
		public static readonly BitSet _funcExpr_in_loopExpr956 = new BitSet(new ulong[]{0x403978800000UL});
		public static readonly BitSet _46_in_loopExpr959 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _VAR_in_assExpr972 = new BitSet(new ulong[]{0x80000UL});
		public static readonly BitSet _ASS_in_assExpr974 = new BitSet(new ulong[]{0x4780000000UL});
		public static readonly BitSet _expressions_in_assExpr977 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _typeDecl_in_varDecl987 = new BitSet(new ulong[]{0x100000000UL});
		public static readonly BitSet _VAR_in_varDecl989 = new BitSet(new ulong[]{0x2000UL});
		public static readonly BitSet _OP_END_in_varDecl992 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _typeDecl_in_varDecl1009 = new BitSet(new ulong[]{0x100000000UL});
		public static readonly BitSet _assExpr_in_varDecl1011 = new BitSet(new ulong[]{0x2000UL});
		public static readonly BitSet _OP_END_in_varDecl1013 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funcExec_in_elseFuncExec1035 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expressions_in_execParamsRule1050 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funcExec_in_execParamsRule1052 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _VAR_in_funcExec1066 = new BitSet(new ulong[]{0x4000000000UL});
		public static readonly BitSet _38_in_funcExec1068 = new BitSet(new ulong[]{0x4780000000UL});
		public static readonly BitSet _execParamsRule_in_funcExec1070 = new BitSet(new ulong[]{0x108000000000UL});
		public static readonly BitSet _44_in_funcExec1073 = new BitSet(new ulong[]{0x4780000000UL});
		public static readonly BitSet _execParamsRule_in_funcExec1074 = new BitSet(new ulong[]{0x108000000000UL});
		public static readonly BitSet _39_in_funcExec1077 = new BitSet(new ulong[]{0x2000UL});
		public static readonly BitSet _OP_END_in_funcExec1080 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _varDecl_in_funcExpr1092 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _arrDecl_in_funcExpr1098 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funcExec_in_funcExpr1104 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assExpr_in_funcExpr1110 = new BitSet(new ulong[]{0x2000UL});
		public static readonly BitSet _OP_END_in_funcExpr1112 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _conditionExpr_in_funcExpr1119 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _loopExpr_in_funcExpr1125 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _VITOCHKA_in_funcExpr1131 = new BitSet(new ulong[]{0x2000UL});
		public static readonly BitSet _OP_END_in_funcExpr1134 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _arrExec_in_funcExpr1141 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funcDecl_in_expr1151 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _varDecl_in_expr1157 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expr_in_program1167 = new BitSet(new ulong[]{0x83800000002UL});
		public static readonly BitSet _program_in_result1176 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _EOF_in_result1178 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _result_in_execute1195 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}

} // namespace Lang2
