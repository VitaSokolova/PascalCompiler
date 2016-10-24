// $ANTLR 3.3 Nov 30, 2010 12:50:56 Lang2.g 2016-10-24 14:08:45

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


	using System;


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
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "PROGRAM", "WHILE", "DO", "FOR", "FUNCTION", "PROCEDURE", "BEGIN", "END", "THEN", "ELSE", "DIV", "MOD", "NOT", "TO", "VAR", "T_CHAR", "T_BOOL", "T_INT", "IF", "BOOL", "CHAR", "INT", "FALSE", "TRUE", "VAR_DECL", "BODY_EXPR", "VAR_EXPR", "FUNC_PROC_EXPR", "PROC_DECL", "FUNC_DECL", "FUNC_CALL", "FUNC_CALL_ARGS", "FUNC_PROC_ARGS", "FUNC_PROC_RET_TYPE", "TYPE_DECL", "BOOL_MULT", "BOOL_ADD", "CONDITION", "OP_END", "WS", "VARIABLE", "ADD", "REM", "MULT", "DIVIDE", "ASSIGN", "GREATER", "LESS", "EQUAL", "LESS_OR_EQUAL", "GREATER_OR_EQUAL", "MORE", "'('", "')'", "','", "':'"
	};
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

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				false, false, false, false, false, false, false, false, false, false, 
				false, false, false, false, false, false, false, false, false, false, 
				false, false, false, false
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
	void CreateTreeAdaptor(ref ITreeAdaptor adaptor) {}

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



 	protected virtual void OnCreated() {}
	protected virtual void EnterRule(string ruleName, int ruleIndex) {}
	protected virtual void LeaveRule(string ruleName, int ruleIndex) {}

    public class boolOperator_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_boolOperator() {}
    protected virtual void Leave_boolOperator() {}

    // $ANTLR start "boolOperator"
    // Lang2.g:101:1: boolOperator : ( MORE | LESS | EQUAL | LESS_OR_EQUAL | GREATER_OR_EQUAL );
    [GrammarRule("boolOperator")]
    private Lang2Parser.boolOperator_return boolOperator()
    {

        Lang2Parser.boolOperator_return retval = new Lang2Parser.boolOperator_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken set1=null;

        object set1_tree=null;

    	try { DebugEnterRule(GrammarFileName, "boolOperator");
    	DebugLocation(101, 3);
    	try
    	{
    		// Lang2.g:101:13: ( MORE | LESS | EQUAL | LESS_OR_EQUAL | GREATER_OR_EQUAL )
    		DebugEnterAlt(1);
    		// Lang2.g:
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(101, 13);
    		set1=(IToken)input.LT(1);
    		if ((input.LA(1)>=LESS && input.LA(1)<=MORE))
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
        }
     	DebugLocation(102, 3);
    	} finally { DebugExitRule(GrammarFileName, "boolOperator"); }
    	return retval;

    }
    // $ANTLR end "boolOperator"

    public class mathGroup_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_mathGroup() {}
    protected virtual void Leave_mathGroup() {}

    // $ANTLR start "mathGroup"
    // Lang2.g:105:1: mathGroup : ( '(' ( mathExpr )+ ')' | INT | VAR | CHAR | FALSE | TRUE | funcCall );
    [GrammarRule("mathGroup")]
    private Lang2Parser.mathGroup_return mathGroup()
    {

        Lang2Parser.mathGroup_return retval = new Lang2Parser.mathGroup_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken char_literal2=null;
        IToken char_literal4=null;
        IToken INT5=null;
        IToken VAR6=null;
        IToken CHAR7=null;
        IToken FALSE8=null;
        IToken TRUE9=null;
        Lang2Parser.mathExpr_return mathExpr3 = default(Lang2Parser.mathExpr_return);
        Lang2Parser.funcCall_return funcCall10 = default(Lang2Parser.funcCall_return);

        object char_literal2_tree=null;
        object char_literal4_tree=null;
        object INT5_tree=null;
        object VAR6_tree=null;
        object CHAR7_tree=null;
        object FALSE8_tree=null;
        object TRUE9_tree=null;

    	try { DebugEnterRule(GrammarFileName, "mathGroup");
    	DebugLocation(105, 2);
    	try
    	{
    		// Lang2.g:105:11: ( '(' ( mathExpr )+ ')' | INT | VAR | CHAR | FALSE | TRUE | funcCall )
    		int alt2=7;
    		try { DebugEnterDecision(2, decisionCanBacktrack[2]);
    		switch (input.LA(1))
    		{
    		case 56:
    			{
    			alt2=1;
    			}
    			break;
    		case INT:
    			{
    			alt2=2;
    			}
    			break;
    		case VAR:
    			{
    			alt2=3;
    			}
    			break;
    		case CHAR:
    			{
    			alt2=4;
    			}
    			break;
    		case FALSE:
    			{
    			alt2=5;
    			}
    			break;
    		case TRUE:
    			{
    			alt2=6;
    			}
    			break;
    		case VARIABLE:
    			{
    			alt2=7;
    			}
    			break;
    		default:
    			{
    				NoViableAltException nvae = new NoViableAltException("", 2, 0, input);

    				DebugRecognitionException(nvae);
    				throw nvae;
    			}
    		}

    		} finally { DebugExitDecision(2); }
    		switch (alt2)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Lang2.g:105:13: '(' ( mathExpr )+ ')'
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(105, 16);
    			char_literal2=(IToken)Match(input,56,Follow._56_in_mathGroup530); 
    			DebugLocation(105, 17);
    			// Lang2.g:105:17: ( mathExpr )+
    			int cnt1=0;
    			try { DebugEnterSubRule(1);
    			while (true)
    			{
    				int alt1=2;
    				try { DebugEnterDecision(1, decisionCanBacktrack[1]);
    				int LA1_0 = input.LA(1);

    				if ((LA1_0==VAR||(LA1_0>=CHAR && LA1_0<=TRUE)||LA1_0==VARIABLE||LA1_0==56))
    				{
    					alt1=1;
    				}


    				} finally { DebugExitDecision(1); }
    				switch (alt1)
    				{
    				case 1:
    					DebugEnterAlt(1);
    					// Lang2.g:105:17: mathExpr
    					{
    					DebugLocation(105, 17);
    					PushFollow(Follow._mathExpr_in_mathGroup532);
    					mathExpr3=mathExpr();
    					PopFollow();

    					adaptor.AddChild(root_0, mathExpr3.Tree);

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

    			DebugLocation(105, 29);
    			char_literal4=(IToken)Match(input,57,Follow._57_in_mathGroup534); 

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Lang2.g:106:5: INT
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(106, 5);
    			INT5=(IToken)Match(input,INT,Follow._INT_in_mathGroup541); 
    			INT5_tree = (object)adaptor.Create(INT5);
    			adaptor.AddChild(root_0, INT5_tree);


    			}
    			break;
    		case 3:
    			DebugEnterAlt(3);
    			// Lang2.g:107:5: VAR
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(107, 5);
    			VAR6=(IToken)Match(input,VAR,Follow._VAR_in_mathGroup547); 
    			VAR6_tree = (object)adaptor.Create(VAR6);
    			adaptor.AddChild(root_0, VAR6_tree);


    			}
    			break;
    		case 4:
    			DebugEnterAlt(4);
    			// Lang2.g:108:5: CHAR
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(108, 5);
    			CHAR7=(IToken)Match(input,CHAR,Follow._CHAR_in_mathGroup553); 
    			CHAR7_tree = (object)adaptor.Create(CHAR7);
    			adaptor.AddChild(root_0, CHAR7_tree);


    			}
    			break;
    		case 5:
    			DebugEnterAlt(5);
    			// Lang2.g:109:5: FALSE
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(109, 5);
    			FALSE8=(IToken)Match(input,FALSE,Follow._FALSE_in_mathGroup559); 
    			FALSE8_tree = (object)adaptor.Create(FALSE8);
    			adaptor.AddChild(root_0, FALSE8_tree);


    			}
    			break;
    		case 6:
    			DebugEnterAlt(6);
    			// Lang2.g:109:13: TRUE
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(109, 13);
    			TRUE9=(IToken)Match(input,TRUE,Follow._TRUE_in_mathGroup563); 
    			TRUE9_tree = (object)adaptor.Create(TRUE9);
    			adaptor.AddChild(root_0, TRUE9_tree);


    			}
    			break;
    		case 7:
    			DebugEnterAlt(7);
    			// Lang2.g:110:5: funcCall
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(110, 5);
    			PushFollow(Follow._funcCall_in_mathGroup569);
    			funcCall10=funcCall();
    			PopFollow();

    			adaptor.AddChild(root_0, funcCall10.Tree);

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
        }
     	DebugLocation(111, 2);
    	} finally { DebugExitRule(GrammarFileName, "mathGroup"); }
    	return retval;

    }
    // $ANTLR end "mathGroup"

    public class boolMult_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_boolMult() {}
    protected virtual void Leave_boolMult() {}

    // $ANTLR start "boolMult"
    // Lang2.g:114:1: boolMult : mathGroup ( BOOL_MULT mathGroup )* ;
    [GrammarRule("boolMult")]
    private Lang2Parser.boolMult_return boolMult()
    {

        Lang2Parser.boolMult_return retval = new Lang2Parser.boolMult_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken BOOL_MULT12=null;
        Lang2Parser.mathGroup_return mathGroup11 = default(Lang2Parser.mathGroup_return);
        Lang2Parser.mathGroup_return mathGroup13 = default(Lang2Parser.mathGroup_return);

        object BOOL_MULT12_tree=null;

    	try { DebugEnterRule(GrammarFileName, "boolMult");
    	DebugLocation(114, 3);
    	try
    	{
    		// Lang2.g:114:10: ( mathGroup ( BOOL_MULT mathGroup )* )
    		DebugEnterAlt(1);
    		// Lang2.g:114:12: mathGroup ( BOOL_MULT mathGroup )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(114, 12);
    		PushFollow(Follow._mathGroup_in_boolMult581);
    		mathGroup11=mathGroup();
    		PopFollow();

    		adaptor.AddChild(root_0, mathGroup11.Tree);
    		DebugLocation(114, 21);
    		// Lang2.g:114:21: ( BOOL_MULT mathGroup )*
    		try { DebugEnterSubRule(3);
    		while (true)
    		{
    			int alt3=2;
    			try { DebugEnterDecision(3, decisionCanBacktrack[3]);
    			int LA3_0 = input.LA(1);

    			if ((LA3_0==BOOL_MULT))
    			{
    				alt3=1;
    			}


    			} finally { DebugExitDecision(3); }
    			switch ( alt3 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:114:22: BOOL_MULT mathGroup
    				{
    				DebugLocation(114, 31);
    				BOOL_MULT12=(IToken)Match(input,BOOL_MULT,Follow._BOOL_MULT_in_boolMult583); 
    				BOOL_MULT12_tree = (object)adaptor.Create(BOOL_MULT12);
    				root_0 = (object)adaptor.BecomeRoot(BOOL_MULT12_tree, root_0);

    				DebugLocation(114, 33);
    				PushFollow(Follow._mathGroup_in_boolMult586);
    				mathGroup13=mathGroup();
    				PopFollow();

    				adaptor.AddChild(root_0, mathGroup13.Tree);

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
        }
     	DebugLocation(115, 3);
    	} finally { DebugExitRule(GrammarFileName, "boolMult"); }
    	return retval;

    }
    // $ANTLR end "boolMult"

    public class boolAdd_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_boolAdd() {}
    protected virtual void Leave_boolAdd() {}

    // $ANTLR start "boolAdd"
    // Lang2.g:117:1: boolAdd : boolMult ( BOOL_ADD boolMult )* ;
    [GrammarRule("boolAdd")]
    private Lang2Parser.boolAdd_return boolAdd()
    {

        Lang2Parser.boolAdd_return retval = new Lang2Parser.boolAdd_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken BOOL_ADD15=null;
        Lang2Parser.boolMult_return boolMult14 = default(Lang2Parser.boolMult_return);
        Lang2Parser.boolMult_return boolMult16 = default(Lang2Parser.boolMult_return);

        object BOOL_ADD15_tree=null;

    	try { DebugEnterRule(GrammarFileName, "boolAdd");
    	DebugLocation(117, 2);
    	try
    	{
    		// Lang2.g:117:9: ( boolMult ( BOOL_ADD boolMult )* )
    		DebugEnterAlt(1);
    		// Lang2.g:117:11: boolMult ( BOOL_ADD boolMult )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(117, 11);
    		PushFollow(Follow._boolMult_in_boolAdd600);
    		boolMult14=boolMult();
    		PopFollow();

    		adaptor.AddChild(root_0, boolMult14.Tree);
    		DebugLocation(117, 19);
    		// Lang2.g:117:19: ( BOOL_ADD boolMult )*
    		try { DebugEnterSubRule(4);
    		while (true)
    		{
    			int alt4=2;
    			try { DebugEnterDecision(4, decisionCanBacktrack[4]);
    			int LA4_0 = input.LA(1);

    			if ((LA4_0==BOOL_ADD))
    			{
    				alt4=1;
    			}


    			} finally { DebugExitDecision(4); }
    			switch ( alt4 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:117:20: BOOL_ADD boolMult
    				{
    				DebugLocation(117, 28);
    				BOOL_ADD15=(IToken)Match(input,BOOL_ADD,Follow._BOOL_ADD_in_boolAdd602); 
    				BOOL_ADD15_tree = (object)adaptor.Create(BOOL_ADD15);
    				root_0 = (object)adaptor.BecomeRoot(BOOL_ADD15_tree, root_0);

    				DebugLocation(117, 30);
    				PushFollow(Follow._boolMult_in_boolAdd605);
    				boolMult16=boolMult();
    				PopFollow();

    				adaptor.AddChild(root_0, boolMult16.Tree);

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
        }
     	DebugLocation(118, 2);
    	} finally { DebugExitRule(GrammarFileName, "boolAdd"); }
    	return retval;

    }
    // $ANTLR end "boolAdd"

    public class boolElse_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_boolElse() {}
    protected virtual void Leave_boolElse() {}

    // $ANTLR start "boolElse"
    // Lang2.g:120:1: boolElse : boolAdd ( boolOperator boolAdd )* ;
    [GrammarRule("boolElse")]
    private Lang2Parser.boolElse_return boolElse()
    {

        Lang2Parser.boolElse_return retval = new Lang2Parser.boolElse_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.boolAdd_return boolAdd17 = default(Lang2Parser.boolAdd_return);
        Lang2Parser.boolOperator_return boolOperator18 = default(Lang2Parser.boolOperator_return);
        Lang2Parser.boolAdd_return boolAdd19 = default(Lang2Parser.boolAdd_return);


    	try { DebugEnterRule(GrammarFileName, "boolElse");
    	DebugLocation(120, 3);
    	try
    	{
    		// Lang2.g:120:10: ( boolAdd ( boolOperator boolAdd )* )
    		DebugEnterAlt(1);
    		// Lang2.g:120:12: boolAdd ( boolOperator boolAdd )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(120, 12);
    		PushFollow(Follow._boolAdd_in_boolElse618);
    		boolAdd17=boolAdd();
    		PopFollow();

    		adaptor.AddChild(root_0, boolAdd17.Tree);
    		DebugLocation(120, 19);
    		// Lang2.g:120:19: ( boolOperator boolAdd )*
    		try { DebugEnterSubRule(5);
    		while (true)
    		{
    			int alt5=2;
    			try { DebugEnterDecision(5, decisionCanBacktrack[5]);
    			int LA5_0 = input.LA(1);

    			if (((LA5_0>=LESS && LA5_0<=MORE)))
    			{
    				alt5=1;
    			}


    			} finally { DebugExitDecision(5); }
    			switch ( alt5 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:120:20: boolOperator boolAdd
    				{
    				DebugLocation(120, 32);
    				PushFollow(Follow._boolOperator_in_boolElse620);
    				boolOperator18=boolOperator();
    				PopFollow();

    				root_0 = (object)adaptor.BecomeRoot(boolOperator18.Tree, root_0);
    				DebugLocation(120, 34);
    				PushFollow(Follow._boolAdd_in_boolElse623);
    				boolAdd19=boolAdd();
    				PopFollow();

    				adaptor.AddChild(root_0, boolAdd19.Tree);

    				}
    				break;

    			default:
    				goto loop5;
    			}
    		}

    		loop5:
    			;

    		} finally { DebugExitSubRule(5); }


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
        }
     	DebugLocation(121, 3);
    	} finally { DebugExitRule(GrammarFileName, "boolElse"); }
    	return retval;

    }
    // $ANTLR end "boolElse"

    public class boolNegative_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_boolNegative() {}
    protected virtual void Leave_boolNegative() {}

    // $ANTLR start "boolNegative"
    // Lang2.g:123:1: boolNegative : boolElse ( NOT boolElse )* ;
    [GrammarRule("boolNegative")]
    private Lang2Parser.boolNegative_return boolNegative()
    {

        Lang2Parser.boolNegative_return retval = new Lang2Parser.boolNegative_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken NOT21=null;
        Lang2Parser.boolElse_return boolElse20 = default(Lang2Parser.boolElse_return);
        Lang2Parser.boolElse_return boolElse22 = default(Lang2Parser.boolElse_return);

        object NOT21_tree=null;

    	try { DebugEnterRule(GrammarFileName, "boolNegative");
    	DebugLocation(123, 3);
    	try
    	{
    		// Lang2.g:123:14: ( boolElse ( NOT boolElse )* )
    		DebugEnterAlt(1);
    		// Lang2.g:123:16: boolElse ( NOT boolElse )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(123, 16);
    		PushFollow(Follow._boolElse_in_boolNegative637);
    		boolElse20=boolElse();
    		PopFollow();

    		adaptor.AddChild(root_0, boolElse20.Tree);
    		DebugLocation(123, 25);
    		// Lang2.g:123:25: ( NOT boolElse )*
    		try { DebugEnterSubRule(6);
    		while (true)
    		{
    			int alt6=2;
    			try { DebugEnterDecision(6, decisionCanBacktrack[6]);
    			int LA6_0 = input.LA(1);

    			if ((LA6_0==NOT))
    			{
    				alt6=1;
    			}


    			} finally { DebugExitDecision(6); }
    			switch ( alt6 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:123:26: NOT boolElse
    				{
    				DebugLocation(123, 29);
    				NOT21=(IToken)Match(input,NOT,Follow._NOT_in_boolNegative640); 
    				NOT21_tree = (object)adaptor.Create(NOT21);
    				root_0 = (object)adaptor.BecomeRoot(NOT21_tree, root_0);

    				DebugLocation(123, 31);
    				PushFollow(Follow._boolElse_in_boolNegative643);
    				boolElse22=boolElse();
    				PopFollow();

    				adaptor.AddChild(root_0, boolElse22.Tree);

    				}
    				break;

    			default:
    				goto loop6;
    			}
    		}

    		loop6:
    			;

    		} finally { DebugExitSubRule(6); }


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
        }
     	DebugLocation(124, 3);
    	} finally { DebugExitRule(GrammarFileName, "boolNegative"); }
    	return retval;

    }
    // $ANTLR end "boolNegative"

    public class useDiv_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_useDiv() {}
    protected virtual void Leave_useDiv() {}

    // $ANTLR start "useDiv"
    // Lang2.g:126:1: useDiv : boolNegative ( ( DIV | MOD ) '(' boolNegative ')' )* ;
    [GrammarRule("useDiv")]
    private Lang2Parser.useDiv_return useDiv()
    {

        Lang2Parser.useDiv_return retval = new Lang2Parser.useDiv_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken set24=null;
        IToken char_literal25=null;
        IToken char_literal27=null;
        Lang2Parser.boolNegative_return boolNegative23 = default(Lang2Parser.boolNegative_return);
        Lang2Parser.boolNegative_return boolNegative26 = default(Lang2Parser.boolNegative_return);

        object set24_tree=null;
        object char_literal25_tree=null;
        object char_literal27_tree=null;

    	try { DebugEnterRule(GrammarFileName, "useDiv");
    	DebugLocation(126, 2);
    	try
    	{
    		// Lang2.g:126:8: ( boolNegative ( ( DIV | MOD ) '(' boolNegative ')' )* )
    		DebugEnterAlt(1);
    		// Lang2.g:126:10: boolNegative ( ( DIV | MOD ) '(' boolNegative ')' )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(126, 10);
    		PushFollow(Follow._boolNegative_in_useDiv657);
    		boolNegative23=boolNegative();
    		PopFollow();

    		adaptor.AddChild(root_0, boolNegative23.Tree);
    		DebugLocation(126, 22);
    		// Lang2.g:126:22: ( ( DIV | MOD ) '(' boolNegative ')' )*
    		try { DebugEnterSubRule(7);
    		while (true)
    		{
    			int alt7=2;
    			try { DebugEnterDecision(7, decisionCanBacktrack[7]);
    			int LA7_0 = input.LA(1);

    			if (((LA7_0>=DIV && LA7_0<=MOD)))
    			{
    				alt7=1;
    			}


    			} finally { DebugExitDecision(7); }
    			switch ( alt7 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:126:23: ( DIV | MOD ) '(' boolNegative ')'
    				{
    				DebugLocation(126, 23);
    				set24=(IToken)input.LT(1);
    				set24=(IToken)input.LT(1);
    				if ((input.LA(1)>=DIV && input.LA(1)<=MOD))
    				{
    					input.Consume();
    					root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set24), root_0);
    					state.errorRecovery=false;
    				}
    				else
    				{
    					MismatchedSetException mse = new MismatchedSetException(null,input);
    					DebugRecognitionException(mse);
    					throw mse;
    				}

    				DebugLocation(126, 37);
    				char_literal25=(IToken)Match(input,56,Follow._56_in_useDiv666); 
    				DebugLocation(126, 39);
    				PushFollow(Follow._boolNegative_in_useDiv669);
    				boolNegative26=boolNegative();
    				PopFollow();

    				adaptor.AddChild(root_0, boolNegative26.Tree);
    				DebugLocation(126, 55);
    				char_literal27=(IToken)Match(input,57,Follow._57_in_useDiv671); 

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
        }
     	DebugLocation(127, 2);
    	} finally { DebugExitRule(GrammarFileName, "useDiv"); }
    	return retval;

    }
    // $ANTLR end "useDiv"

    public class mathMult_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_mathMult() {}
    protected virtual void Leave_mathMult() {}

    // $ANTLR start "mathMult"
    // Lang2.g:129:1: mathMult : useDiv ( ( MULT | DIVIDE ) useDiv )* ;
    [GrammarRule("mathMult")]
    private Lang2Parser.mathMult_return mathMult()
    {

        Lang2Parser.mathMult_return retval = new Lang2Parser.mathMult_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken set29=null;
        Lang2Parser.useDiv_return useDiv28 = default(Lang2Parser.useDiv_return);
        Lang2Parser.useDiv_return useDiv30 = default(Lang2Parser.useDiv_return);

        object set29_tree=null;

    	try { DebugEnterRule(GrammarFileName, "mathMult");
    	DebugLocation(129, 1);
    	try
    	{
    		// Lang2.g:130:2: ( useDiv ( ( MULT | DIVIDE ) useDiv )* )
    		DebugEnterAlt(1);
    		// Lang2.g:130:4: useDiv ( ( MULT | DIVIDE ) useDiv )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(130, 4);
    		PushFollow(Follow._useDiv_in_mathMult688);
    		useDiv28=useDiv();
    		PopFollow();

    		adaptor.AddChild(root_0, useDiv28.Tree);
    		DebugLocation(130, 10);
    		// Lang2.g:130:10: ( ( MULT | DIVIDE ) useDiv )*
    		try { DebugEnterSubRule(8);
    		while (true)
    		{
    			int alt8=2;
    			try { DebugEnterDecision(8, decisionCanBacktrack[8]);
    			int LA8_0 = input.LA(1);

    			if (((LA8_0>=MULT && LA8_0<=DIVIDE)))
    			{
    				alt8=1;
    			}


    			} finally { DebugExitDecision(8); }
    			switch ( alt8 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:130:11: ( MULT | DIVIDE ) useDiv
    				{
    				DebugLocation(130, 11);
    				set29=(IToken)input.LT(1);
    				set29=(IToken)input.LT(1);
    				if ((input.LA(1)>=MULT && input.LA(1)<=DIVIDE))
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

    				DebugLocation(130, 25);
    				PushFollow(Follow._useDiv_in_mathMult696);
    				useDiv30=useDiv();
    				PopFollow();

    				adaptor.AddChild(root_0, useDiv30.Tree);

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
        }
     	DebugLocation(131, 1);
    	} finally { DebugExitRule(GrammarFileName, "mathMult"); }
    	return retval;

    }
    // $ANTLR end "mathMult"

    public class mathAdd_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_mathAdd() {}
    protected virtual void Leave_mathAdd() {}

    // $ANTLR start "mathAdd"
    // Lang2.g:133:1: mathAdd : mathMult ( ( ADD | REM ) mathMult )* ;
    [GrammarRule("mathAdd")]
    private Lang2Parser.mathAdd_return mathAdd()
    {

        Lang2Parser.mathAdd_return retval = new Lang2Parser.mathAdd_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken set32=null;
        Lang2Parser.mathMult_return mathMult31 = default(Lang2Parser.mathMult_return);
        Lang2Parser.mathMult_return mathMult33 = default(Lang2Parser.mathMult_return);

        object set32_tree=null;

    	try { DebugEnterRule(GrammarFileName, "mathAdd");
    	DebugLocation(133, 1);
    	try
    	{
    		// Lang2.g:133:9: ( mathMult ( ( ADD | REM ) mathMult )* )
    		DebugEnterAlt(1);
    		// Lang2.g:133:11: mathMult ( ( ADD | REM ) mathMult )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(133, 11);
    		PushFollow(Follow._mathMult_in_mathAdd709);
    		mathMult31=mathMult();
    		PopFollow();

    		adaptor.AddChild(root_0, mathMult31.Tree);
    		DebugLocation(133, 19);
    		// Lang2.g:133:19: ( ( ADD | REM ) mathMult )*
    		try { DebugEnterSubRule(9);
    		while (true)
    		{
    			int alt9=2;
    			try { DebugEnterDecision(9, decisionCanBacktrack[9]);
    			int LA9_0 = input.LA(1);

    			if (((LA9_0>=ADD && LA9_0<=REM)))
    			{
    				alt9=1;
    			}


    			} finally { DebugExitDecision(9); }
    			switch ( alt9 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:133:20: ( ADD | REM ) mathMult
    				{
    				DebugLocation(133, 20);
    				set32=(IToken)input.LT(1);
    				set32=(IToken)input.LT(1);
    				if ((input.LA(1)>=ADD && input.LA(1)<=REM))
    				{
    					input.Consume();
    					root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set32), root_0);
    					state.errorRecovery=false;
    				}
    				else
    				{
    					MismatchedSetException mse = new MismatchedSetException(null,input);
    					DebugRecognitionException(mse);
    					throw mse;
    				}

    				DebugLocation(133, 30);
    				PushFollow(Follow._mathMult_in_mathAdd717);
    				mathMult33=mathMult();
    				PopFollow();

    				adaptor.AddChild(root_0, mathMult33.Tree);

    				}
    				break;

    			default:
    				goto loop9;
    			}
    		}

    		loop9:
    			;

    		} finally { DebugExitSubRule(9); }


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
        }
     	DebugLocation(134, 1);
    	} finally { DebugExitRule(GrammarFileName, "mathAdd"); }
    	return retval;

    }
    // $ANTLR end "mathAdd"

    public class mathExpr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_mathExpr() {}
    protected virtual void Leave_mathExpr() {}

    // $ANTLR start "mathExpr"
    // Lang2.g:136:1: mathExpr : mathAdd ;
    [GrammarRule("mathExpr")]
    private Lang2Parser.mathExpr_return mathExpr()
    {

        Lang2Parser.mathExpr_return retval = new Lang2Parser.mathExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.mathAdd_return mathAdd34 = default(Lang2Parser.mathAdd_return);


    	try { DebugEnterRule(GrammarFileName, "mathExpr");
    	DebugLocation(136, 1);
    	try
    	{
    		// Lang2.g:137:2: ( mathAdd )
    		DebugEnterAlt(1);
    		// Lang2.g:137:4: mathAdd
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(137, 4);
    		PushFollow(Follow._mathAdd_in_mathExpr731);
    		mathAdd34=mathAdd();
    		PopFollow();

    		adaptor.AddChild(root_0, mathAdd34.Tree);

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
        }
     	DebugLocation(138, 1);
    	} finally { DebugExitRule(GrammarFileName, "mathExpr"); }
    	return retval;

    }
    // $ANTLR end "mathExpr"

    public class bodyOper_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_bodyOper() {}
    protected virtual void Leave_bodyOper() {}

    // $ANTLR start "bodyOper"
    // Lang2.g:142:1: bodyOper : ( expressions | assExpr OP_END | conditionExpr | loopExpr );
    [GrammarRule("bodyOper")]
    private Lang2Parser.bodyOper_return bodyOper()
    {

        Lang2Parser.bodyOper_return retval = new Lang2Parser.bodyOper_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken OP_END37=null;
        Lang2Parser.expressions_return expressions35 = default(Lang2Parser.expressions_return);
        Lang2Parser.assExpr_return assExpr36 = default(Lang2Parser.assExpr_return);
        Lang2Parser.conditionExpr_return conditionExpr38 = default(Lang2Parser.conditionExpr_return);
        Lang2Parser.loopExpr_return loopExpr39 = default(Lang2Parser.loopExpr_return);

        object OP_END37_tree=null;

    	try { DebugEnterRule(GrammarFileName, "bodyOper");
    	DebugLocation(142, 4);
    	try
    	{
    		// Lang2.g:142:10: ( expressions | assExpr OP_END | conditionExpr | loopExpr )
    		int alt10=4;
    		try { DebugEnterDecision(10, decisionCanBacktrack[10]);
    		switch (input.LA(1))
    		{
    		case VAR:
    		case CHAR:
    		case INT:
    		case FALSE:
    		case TRUE:
    		case 56:
    			{
    			alt10=1;
    			}
    			break;
    		case VARIABLE:
    			{
    			int LA10_2 = input.LA(2);

    			if ((LA10_2==56))
    			{
    				alt10=1;
    			}
    			else if ((LA10_2==ASSIGN))
    			{
    				alt10=2;
    			}
    			else
    			{
    				NoViableAltException nvae = new NoViableAltException("", 10, 2, input);

    				DebugRecognitionException(nvae);
    				throw nvae;
    			}
    			}
    			break;
    		case IF:
    			{
    			alt10=3;
    			}
    			break;
    		case WHILE:
    		case FOR:
    			{
    			alt10=4;
    			}
    			break;
    		default:
    			{
    				NoViableAltException nvae = new NoViableAltException("", 10, 0, input);

    				DebugRecognitionException(nvae);
    				throw nvae;
    			}
    		}

    		} finally { DebugExitDecision(10); }
    		switch (alt10)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Lang2.g:142:12: expressions
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(142, 12);
    			PushFollow(Follow._expressions_in_bodyOper745);
    			expressions35=expressions();
    			PopFollow();

    			adaptor.AddChild(root_0, expressions35.Tree);

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Lang2.g:143:6: assExpr OP_END
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(143, 6);
    			PushFollow(Follow._assExpr_in_bodyOper752);
    			assExpr36=assExpr();
    			PopFollow();

    			adaptor.AddChild(root_0, assExpr36.Tree);
    			DebugLocation(143, 20);
    			OP_END37=(IToken)Match(input,OP_END,Follow._OP_END_in_bodyOper754); 

    			}
    			break;
    		case 3:
    			DebugEnterAlt(3);
    			// Lang2.g:144:6: conditionExpr
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(144, 6);
    			PushFollow(Follow._conditionExpr_in_bodyOper762);
    			conditionExpr38=conditionExpr();
    			PopFollow();

    			adaptor.AddChild(root_0, conditionExpr38.Tree);

    			}
    			break;
    		case 4:
    			DebugEnterAlt(4);
    			// Lang2.g:145:6: loopExpr
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(145, 6);
    			PushFollow(Follow._loopExpr_in_bodyOper769);
    			loopExpr39=loopExpr();
    			PopFollow();

    			adaptor.AddChild(root_0, loopExpr39.Tree);

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
        }
     	DebugLocation(146, 4);
    	} finally { DebugExitRule(GrammarFileName, "bodyOper"); }
    	return retval;

    }
    // $ANTLR end "bodyOper"

    public class expressions_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_expressions() {}
    protected virtual void Leave_expressions() {}

    // $ANTLR start "expressions"
    // Lang2.g:148:1: expressions : mathExpr ;
    [GrammarRule("expressions")]
    private Lang2Parser.expressions_return expressions()
    {

        Lang2Parser.expressions_return retval = new Lang2Parser.expressions_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.mathExpr_return mathExpr40 = default(Lang2Parser.mathExpr_return);


    	try { DebugEnterRule(GrammarFileName, "expressions");
    	DebugLocation(148, 4);
    	try
    	{
    		// Lang2.g:148:13: ( mathExpr )
    		DebugEnterAlt(1);
    		// Lang2.g:148:15: mathExpr
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(148, 15);
    		PushFollow(Follow._mathExpr_in_expressions782);
    		mathExpr40=mathExpr();
    		PopFollow();

    		adaptor.AddChild(root_0, mathExpr40.Tree);

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
        }
     	DebugLocation(149, 4);
    	} finally { DebugExitRule(GrammarFileName, "expressions"); }
    	return retval;

    }
    // $ANTLR end "expressions"

    public class funcCallArgs_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_funcCallArgs() {}
    protected virtual void Leave_funcCallArgs() {}

    // $ANTLR start "funcCallArgs"
    // Lang2.g:150:1: funcCallArgs : VARIABLE ( ',' VARIABLE )* ;
    [GrammarRule("funcCallArgs")]
    private Lang2Parser.funcCallArgs_return funcCallArgs()
    {

        Lang2Parser.funcCallArgs_return retval = new Lang2Parser.funcCallArgs_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken VARIABLE41=null;
        IToken char_literal42=null;
        IToken VARIABLE43=null;

        object VARIABLE41_tree=null;
        object char_literal42_tree=null;
        object VARIABLE43_tree=null;

    	try { DebugEnterRule(GrammarFileName, "funcCallArgs");
    	DebugLocation(150, 4);
    	try
    	{
    		// Lang2.g:150:14: ( VARIABLE ( ',' VARIABLE )* )
    		DebugEnterAlt(1);
    		// Lang2.g:150:17: VARIABLE ( ',' VARIABLE )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(150, 17);
    		VARIABLE41=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_funcCallArgs796); 
    		VARIABLE41_tree = (object)adaptor.Create(VARIABLE41);
    		adaptor.AddChild(root_0, VARIABLE41_tree);

    		DebugLocation(150, 25);
    		// Lang2.g:150:25: ( ',' VARIABLE )*
    		try { DebugEnterSubRule(11);
    		while (true)
    		{
    			int alt11=2;
    			try { DebugEnterDecision(11, decisionCanBacktrack[11]);
    			int LA11_0 = input.LA(1);

    			if ((LA11_0==58))
    			{
    				alt11=1;
    			}


    			} finally { DebugExitDecision(11); }
    			switch ( alt11 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:150:26: ',' VARIABLE
    				{
    				DebugLocation(150, 26);
    				char_literal42=(IToken)Match(input,58,Follow._58_in_funcCallArgs798); 
    				char_literal42_tree = (object)adaptor.Create(char_literal42);
    				adaptor.AddChild(root_0, char_literal42_tree);

    				DebugLocation(150, 30);
    				VARIABLE43=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_funcCallArgs800); 
    				VARIABLE43_tree = (object)adaptor.Create(VARIABLE43);
    				adaptor.AddChild(root_0, VARIABLE43_tree);


    				}
    				break;

    			default:
    				goto loop11;
    			}
    		}

    		loop11:
    			;

    		} finally { DebugExitSubRule(11); }


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
        }
     	DebugLocation(151, 4);
    	} finally { DebugExitRule(GrammarFileName, "funcCallArgs"); }
    	return retval;

    }
    // $ANTLR end "funcCallArgs"

    public class funcCallArgsW_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_funcCallArgsW() {}
    protected virtual void Leave_funcCallArgsW() {}

    // $ANTLR start "funcCallArgsW"
    // Lang2.g:152:1: funcCallArgsW : funcCallArgs -> ^( FUNC_CALL_ARGS funcCallArgs ) ;
    [GrammarRule("funcCallArgsW")]
    private Lang2Parser.funcCallArgsW_return funcCallArgsW()
    {

        Lang2Parser.funcCallArgsW_return retval = new Lang2Parser.funcCallArgsW_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.funcCallArgs_return funcCallArgs44 = default(Lang2Parser.funcCallArgs_return);

        RewriteRuleSubtreeStream stream_funcCallArgs=new RewriteRuleSubtreeStream(adaptor,"rule funcCallArgs");
    	try { DebugEnterRule(GrammarFileName, "funcCallArgsW");
    	DebugLocation(152, 4);
    	try
    	{
    		// Lang2.g:152:15: ( funcCallArgs -> ^( FUNC_CALL_ARGS funcCallArgs ) )
    		DebugEnterAlt(1);
    		// Lang2.g:152:17: funcCallArgs
    		{
    		DebugLocation(152, 17);
    		PushFollow(Follow._funcCallArgs_in_funcCallArgsW815);
    		funcCallArgs44=funcCallArgs();
    		PopFollow();

    		stream_funcCallArgs.Add(funcCallArgs44.Tree);


    		{
    		// AST REWRITE
    		// elements: funcCallArgs
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 152:30: -> ^( FUNC_CALL_ARGS funcCallArgs )
    		{
    			DebugLocation(152, 33);
    			// Lang2.g:152:33: ^( FUNC_CALL_ARGS funcCallArgs )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(152, 35);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_CALL_ARGS, "FUNC_CALL_ARGS"), root_1);

    			DebugLocation(152, 50);
    			adaptor.AddChild(root_1, stream_funcCallArgs.NextTree());

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
        }
     	DebugLocation(153, 4);
    	} finally { DebugExitRule(GrammarFileName, "funcCallArgsW"); }
    	return retval;

    }
    // $ANTLR end "funcCallArgsW"

    public class funcCall_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_funcCall() {}
    protected virtual void Leave_funcCall() {}

    // $ANTLR start "funcCall"
    // Lang2.g:155:1: funcCall : VARIABLE '(' ( funcCallArgsW )? ')' OP_END -> ^( FUNC_CALL VARIABLE ( funcCallArgsW )? ) ;
    [GrammarRule("funcCall")]
    private Lang2Parser.funcCall_return funcCall()
    {

        Lang2Parser.funcCall_return retval = new Lang2Parser.funcCall_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken VARIABLE45=null;
        IToken char_literal46=null;
        IToken char_literal48=null;
        IToken OP_END49=null;
        Lang2Parser.funcCallArgsW_return funcCallArgsW47 = default(Lang2Parser.funcCallArgsW_return);

        object VARIABLE45_tree=null;
        object char_literal46_tree=null;
        object char_literal48_tree=null;
        object OP_END49_tree=null;
        RewriteRuleITokenStream stream_57=new RewriteRuleITokenStream(adaptor,"token 57");
        RewriteRuleITokenStream stream_56=new RewriteRuleITokenStream(adaptor,"token 56");
        RewriteRuleITokenStream stream_VARIABLE=new RewriteRuleITokenStream(adaptor,"token VARIABLE");
        RewriteRuleITokenStream stream_OP_END=new RewriteRuleITokenStream(adaptor,"token OP_END");
        RewriteRuleSubtreeStream stream_funcCallArgsW=new RewriteRuleSubtreeStream(adaptor,"rule funcCallArgsW");
    	try { DebugEnterRule(GrammarFileName, "funcCall");
    	DebugLocation(155, 3);
    	try
    	{
    		// Lang2.g:155:10: ( VARIABLE '(' ( funcCallArgsW )? ')' OP_END -> ^( FUNC_CALL VARIABLE ( funcCallArgsW )? ) )
    		DebugEnterAlt(1);
    		// Lang2.g:155:12: VARIABLE '(' ( funcCallArgsW )? ')' OP_END
    		{
    		DebugLocation(155, 12);
    		VARIABLE45=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_funcCall836);  
    		stream_VARIABLE.Add(VARIABLE45);

    		DebugLocation(155, 24);
    		char_literal46=(IToken)Match(input,56,Follow._56_in_funcCall838);  
    		stream_56.Add(char_literal46);

    		DebugLocation(155, 26);
    		// Lang2.g:155:26: ( funcCallArgsW )?
    		int alt12=2;
    		try { DebugEnterSubRule(12);
    		try { DebugEnterDecision(12, decisionCanBacktrack[12]);
    		int LA12_0 = input.LA(1);

    		if ((LA12_0==VARIABLE))
    		{
    			alt12=1;
    		}
    		} finally { DebugExitDecision(12); }
    		switch (alt12)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Lang2.g:155:26: funcCallArgsW
    			{
    			DebugLocation(155, 26);
    			PushFollow(Follow._funcCallArgsW_in_funcCall841);
    			funcCallArgsW47=funcCallArgsW();
    			PopFollow();

    			stream_funcCallArgsW.Add(funcCallArgsW47.Tree);

    			}
    			break;

    		}
    		} finally { DebugExitSubRule(12); }

    		DebugLocation(155, 44);
    		char_literal48=(IToken)Match(input,57,Follow._57_in_funcCall844);  
    		stream_57.Add(char_literal48);

    		DebugLocation(155, 46);
    		OP_END49=(IToken)Match(input,OP_END,Follow._OP_END_in_funcCall847);  
    		stream_OP_END.Add(OP_END49);



    		{
    		// AST REWRITE
    		// elements: VARIABLE, funcCallArgsW
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 155:53: -> ^( FUNC_CALL VARIABLE ( funcCallArgsW )? )
    		{
    			DebugLocation(155, 56);
    			// Lang2.g:155:56: ^( FUNC_CALL VARIABLE ( funcCallArgsW )? )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(155, 58);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_CALL, "FUNC_CALL"), root_1);

    			DebugLocation(155, 68);
    			adaptor.AddChild(root_1, stream_VARIABLE.NextNode());
    			DebugLocation(155, 77);
    			// Lang2.g:155:77: ( funcCallArgsW )?
    			if ( stream_funcCallArgsW.HasNext )
    			{
    				DebugLocation(155, 77);
    				adaptor.AddChild(root_1, stream_funcCallArgsW.NextTree());

    			}
    			stream_funcCallArgsW.Reset();

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
        }
     	DebugLocation(156, 3);
    	} finally { DebugExitRule(GrammarFileName, "funcCall"); }
    	return retval;

    }
    // $ANTLR end "funcCall"

    public class argDeclExpr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_argDeclExpr() {}
    protected virtual void Leave_argDeclExpr() {}

    // $ANTLR start "argDeclExpr"
    // Lang2.g:158:1: argDeclExpr : '(' argDeclMany ')' -> ^( FUNC_PROC_ARGS argDeclMany ) ;
    [GrammarRule("argDeclExpr")]
    private Lang2Parser.argDeclExpr_return argDeclExpr()
    {

        Lang2Parser.argDeclExpr_return retval = new Lang2Parser.argDeclExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken char_literal50=null;
        IToken char_literal52=null;
        Lang2Parser.argDeclMany_return argDeclMany51 = default(Lang2Parser.argDeclMany_return);

        object char_literal50_tree=null;
        object char_literal52_tree=null;
        RewriteRuleITokenStream stream_57=new RewriteRuleITokenStream(adaptor,"token 57");
        RewriteRuleITokenStream stream_56=new RewriteRuleITokenStream(adaptor,"token 56");
        RewriteRuleSubtreeStream stream_argDeclMany=new RewriteRuleSubtreeStream(adaptor,"rule argDeclMany");
    	try { DebugEnterRule(GrammarFileName, "argDeclExpr");
    	DebugLocation(158, 3);
    	try
    	{
    		// Lang2.g:158:13: ( '(' argDeclMany ')' -> ^( FUNC_PROC_ARGS argDeclMany ) )
    		DebugEnterAlt(1);
    		// Lang2.g:158:15: '(' argDeclMany ')'
    		{
    		DebugLocation(158, 18);
    		char_literal50=(IToken)Match(input,56,Follow._56_in_argDeclExpr871);  
    		stream_56.Add(char_literal50);

    		DebugLocation(158, 20);
    		PushFollow(Follow._argDeclMany_in_argDeclExpr874);
    		argDeclMany51=argDeclMany();
    		PopFollow();

    		stream_argDeclMany.Add(argDeclMany51.Tree);
    		DebugLocation(158, 34);
    		char_literal52=(IToken)Match(input,57,Follow._57_in_argDeclExpr875);  
    		stream_57.Add(char_literal52);



    		{
    		// AST REWRITE
    		// elements: argDeclMany
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 158:36: -> ^( FUNC_PROC_ARGS argDeclMany )
    		{
    			DebugLocation(158, 39);
    			// Lang2.g:158:39: ^( FUNC_PROC_ARGS argDeclMany )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(158, 41);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_PROC_ARGS, "FUNC_PROC_ARGS"), root_1);

    			DebugLocation(158, 56);
    			adaptor.AddChild(root_1, stream_argDeclMany.NextTree());

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
        }
     	DebugLocation(159, 3);
    	} finally { DebugExitRule(GrammarFileName, "argDeclExpr"); }
    	return retval;

    }
    // $ANTLR end "argDeclExpr"

    public class retTypeExpr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_retTypeExpr() {}
    protected virtual void Leave_retTypeExpr() {}

    // $ANTLR start "retTypeExpr"
    // Lang2.g:161:1: retTypeExpr : ( T_INT | T_BOOL | T_CHAR ) ;
    [GrammarRule("retTypeExpr")]
    private Lang2Parser.retTypeExpr_return retTypeExpr()
    {

        Lang2Parser.retTypeExpr_return retval = new Lang2Parser.retTypeExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken set53=null;

        object set53_tree=null;

    	try { DebugEnterRule(GrammarFileName, "retTypeExpr");
    	DebugLocation(161, 3);
    	try
    	{
    		// Lang2.g:161:13: ( ( T_INT | T_BOOL | T_CHAR ) )
    		DebugEnterAlt(1);
    		// Lang2.g:161:15: ( T_INT | T_BOOL | T_CHAR )
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(161, 15);
    		set53=(IToken)input.LT(1);
    		if ((input.LA(1)>=T_CHAR && input.LA(1)<=T_INT))
    		{
    			input.Consume();
    			adaptor.AddChild(root_0, (object)adaptor.Create(set53));
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
        }
     	DebugLocation(162, 3);
    	} finally { DebugExitRule(GrammarFileName, "retTypeExpr"); }
    	return retval;

    }
    // $ANTLR end "retTypeExpr"

    public class retTypeExprWrap_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_retTypeExprWrap() {}
    protected virtual void Leave_retTypeExprWrap() {}

    // $ANTLR start "retTypeExprWrap"
    // Lang2.g:164:1: retTypeExprWrap : retTypeExpr -> ^( FUNC_PROC_RET_TYPE retTypeExpr ) ;
    [GrammarRule("retTypeExprWrap")]
    private Lang2Parser.retTypeExprWrap_return retTypeExprWrap()
    {

        Lang2Parser.retTypeExprWrap_return retval = new Lang2Parser.retTypeExprWrap_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.retTypeExpr_return retTypeExpr54 = default(Lang2Parser.retTypeExpr_return);

        RewriteRuleSubtreeStream stream_retTypeExpr=new RewriteRuleSubtreeStream(adaptor,"rule retTypeExpr");
    	try { DebugEnterRule(GrammarFileName, "retTypeExprWrap");
    	DebugLocation(164, 4);
    	try
    	{
    		// Lang2.g:164:17: ( retTypeExpr -> ^( FUNC_PROC_RET_TYPE retTypeExpr ) )
    		DebugEnterAlt(1);
    		// Lang2.g:164:19: retTypeExpr
    		{
    		DebugLocation(164, 19);
    		PushFollow(Follow._retTypeExpr_in_retTypeExprWrap914);
    		retTypeExpr54=retTypeExpr();
    		PopFollow();

    		stream_retTypeExpr.Add(retTypeExpr54.Tree);


    		{
    		// AST REWRITE
    		// elements: retTypeExpr
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 164:31: -> ^( FUNC_PROC_RET_TYPE retTypeExpr )
    		{
    			DebugLocation(164, 34);
    			// Lang2.g:164:34: ^( FUNC_PROC_RET_TYPE retTypeExpr )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(164, 36);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_PROC_RET_TYPE, "FUNC_PROC_RET_TYPE"), root_1);

    			DebugLocation(164, 55);
    			adaptor.AddChild(root_1, stream_retTypeExpr.NextTree());

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
        }
     	DebugLocation(165, 4);
    	} finally { DebugExitRule(GrammarFileName, "retTypeExprWrap"); }
    	return retval;

    }
    // $ANTLR end "retTypeExprWrap"

    public class funcDeclare_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_funcDeclare() {}
    protected virtual void Leave_funcDeclare() {}

    // $ANTLR start "funcDeclare"
    // Lang2.g:167:1: funcDeclare : FUNCTION VARIABLE argDeclExpr ':' retTypeExprWrap OP_END bodyExpr -> ^( FUNC_DECL argDeclExpr retTypeExprWrap bodyExpr ) ;
    [GrammarRule("funcDeclare")]
    private Lang2Parser.funcDeclare_return funcDeclare()
    {

        Lang2Parser.funcDeclare_return retval = new Lang2Parser.funcDeclare_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken FUNCTION55=null;
        IToken VARIABLE56=null;
        IToken char_literal58=null;
        IToken OP_END60=null;
        Lang2Parser.argDeclExpr_return argDeclExpr57 = default(Lang2Parser.argDeclExpr_return);
        Lang2Parser.retTypeExprWrap_return retTypeExprWrap59 = default(Lang2Parser.retTypeExprWrap_return);
        Lang2Parser.bodyExpr_return bodyExpr61 = default(Lang2Parser.bodyExpr_return);

        object FUNCTION55_tree=null;
        object VARIABLE56_tree=null;
        object char_literal58_tree=null;
        object OP_END60_tree=null;
        RewriteRuleITokenStream stream_FUNCTION=new RewriteRuleITokenStream(adaptor,"token FUNCTION");
        RewriteRuleITokenStream stream_59=new RewriteRuleITokenStream(adaptor,"token 59");
        RewriteRuleITokenStream stream_VARIABLE=new RewriteRuleITokenStream(adaptor,"token VARIABLE");
        RewriteRuleITokenStream stream_OP_END=new RewriteRuleITokenStream(adaptor,"token OP_END");
        RewriteRuleSubtreeStream stream_argDeclExpr=new RewriteRuleSubtreeStream(adaptor,"rule argDeclExpr");
        RewriteRuleSubtreeStream stream_bodyExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodyExpr");
        RewriteRuleSubtreeStream stream_retTypeExprWrap=new RewriteRuleSubtreeStream(adaptor,"rule retTypeExprWrap");
    	try { DebugEnterRule(GrammarFileName, "funcDeclare");
    	DebugLocation(167, 3);
    	try
    	{
    		// Lang2.g:167:12: ( FUNCTION VARIABLE argDeclExpr ':' retTypeExprWrap OP_END bodyExpr -> ^( FUNC_DECL argDeclExpr retTypeExprWrap bodyExpr ) )
    		DebugEnterAlt(1);
    		// Lang2.g:167:14: FUNCTION VARIABLE argDeclExpr ':' retTypeExprWrap OP_END bodyExpr
    		{
    		DebugLocation(167, 14);
    		FUNCTION55=(IToken)Match(input,FUNCTION,Follow._FUNCTION_in_funcDeclare934);  
    		stream_FUNCTION.Add(FUNCTION55);

    		DebugLocation(167, 23);
    		VARIABLE56=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_funcDeclare936);  
    		stream_VARIABLE.Add(VARIABLE56);

    		DebugLocation(167, 32);
    		PushFollow(Follow._argDeclExpr_in_funcDeclare938);
    		argDeclExpr57=argDeclExpr();
    		PopFollow();

    		stream_argDeclExpr.Add(argDeclExpr57.Tree);
    		DebugLocation(167, 43);
    		char_literal58=(IToken)Match(input,59,Follow._59_in_funcDeclare939);  
    		stream_59.Add(char_literal58);

    		DebugLocation(167, 47);
    		PushFollow(Follow._retTypeExprWrap_in_funcDeclare941);
    		retTypeExprWrap59=retTypeExprWrap();
    		PopFollow();

    		stream_retTypeExprWrap.Add(retTypeExprWrap59.Tree);
    		DebugLocation(167, 69);
    		OP_END60=(IToken)Match(input,OP_END,Follow._OP_END_in_funcDeclare943);  
    		stream_OP_END.Add(OP_END60);

    		DebugLocation(167, 72);
    		PushFollow(Follow._bodyExpr_in_funcDeclare947);
    		bodyExpr61=bodyExpr();
    		PopFollow();

    		stream_bodyExpr.Add(bodyExpr61.Tree);


    		{
    		// AST REWRITE
    		// elements: argDeclExpr, bodyExpr, retTypeExprWrap
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 167:81: -> ^( FUNC_DECL argDeclExpr retTypeExprWrap bodyExpr )
    		{
    			DebugLocation(167, 84);
    			// Lang2.g:167:84: ^( FUNC_DECL argDeclExpr retTypeExprWrap bodyExpr )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(167, 86);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_DECL, "FUNC_DECL"), root_1);

    			DebugLocation(167, 96);
    			adaptor.AddChild(root_1, stream_argDeclExpr.NextTree());
    			DebugLocation(167, 108);
    			adaptor.AddChild(root_1, stream_retTypeExprWrap.NextTree());
    			DebugLocation(167, 124);
    			adaptor.AddChild(root_1, stream_bodyExpr.NextTree());

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
        }
     	DebugLocation(168, 3);
    	} finally { DebugExitRule(GrammarFileName, "funcDeclare"); }
    	return retval;

    }
    // $ANTLR end "funcDeclare"

    public class procedureDeclare_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_procedureDeclare() {}
    protected virtual void Leave_procedureDeclare() {}

    // $ANTLR start "procedureDeclare"
    // Lang2.g:170:1: procedureDeclare : PROCEDURE VARIABLE argDeclExpr OP_END bodyExpr -> ^( PROC_DECL VARIABLE argDeclExpr bodyExpr ) ;
    [GrammarRule("procedureDeclare")]
    private Lang2Parser.procedureDeclare_return procedureDeclare()
    {

        Lang2Parser.procedureDeclare_return retval = new Lang2Parser.procedureDeclare_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken PROCEDURE62=null;
        IToken VARIABLE63=null;
        IToken OP_END65=null;
        Lang2Parser.argDeclExpr_return argDeclExpr64 = default(Lang2Parser.argDeclExpr_return);
        Lang2Parser.bodyExpr_return bodyExpr66 = default(Lang2Parser.bodyExpr_return);

        object PROCEDURE62_tree=null;
        object VARIABLE63_tree=null;
        object OP_END65_tree=null;
        RewriteRuleITokenStream stream_VARIABLE=new RewriteRuleITokenStream(adaptor,"token VARIABLE");
        RewriteRuleITokenStream stream_OP_END=new RewriteRuleITokenStream(adaptor,"token OP_END");
        RewriteRuleITokenStream stream_PROCEDURE=new RewriteRuleITokenStream(adaptor,"token PROCEDURE");
        RewriteRuleSubtreeStream stream_argDeclExpr=new RewriteRuleSubtreeStream(adaptor,"rule argDeclExpr");
        RewriteRuleSubtreeStream stream_bodyExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodyExpr");
    	try { DebugEnterRule(GrammarFileName, "procedureDeclare");
    	DebugLocation(170, 4);
    	try
    	{
    		// Lang2.g:170:17: ( PROCEDURE VARIABLE argDeclExpr OP_END bodyExpr -> ^( PROC_DECL VARIABLE argDeclExpr bodyExpr ) )
    		DebugEnterAlt(1);
    		// Lang2.g:170:19: PROCEDURE VARIABLE argDeclExpr OP_END bodyExpr
    		{
    		DebugLocation(170, 19);
    		PROCEDURE62=(IToken)Match(input,PROCEDURE,Follow._PROCEDURE_in_procedureDeclare970);  
    		stream_PROCEDURE.Add(PROCEDURE62);

    		DebugLocation(170, 29);
    		VARIABLE63=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_procedureDeclare972);  
    		stream_VARIABLE.Add(VARIABLE63);

    		DebugLocation(170, 38);
    		PushFollow(Follow._argDeclExpr_in_procedureDeclare974);
    		argDeclExpr64=argDeclExpr();
    		PopFollow();

    		stream_argDeclExpr.Add(argDeclExpr64.Tree);
    		DebugLocation(170, 50);
    		OP_END65=(IToken)Match(input,OP_END,Follow._OP_END_in_procedureDeclare976);  
    		stream_OP_END.Add(OP_END65);

    		DebugLocation(170, 57);
    		PushFollow(Follow._bodyExpr_in_procedureDeclare978);
    		bodyExpr66=bodyExpr();
    		PopFollow();

    		stream_bodyExpr.Add(bodyExpr66.Tree);


    		{
    		// AST REWRITE
    		// elements: bodyExpr, VARIABLE, argDeclExpr
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 170:66: -> ^( PROC_DECL VARIABLE argDeclExpr bodyExpr )
    		{
    			DebugLocation(170, 69);
    			// Lang2.g:170:69: ^( PROC_DECL VARIABLE argDeclExpr bodyExpr )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(170, 71);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PROC_DECL, "PROC_DECL"), root_1);

    			DebugLocation(170, 81);
    			adaptor.AddChild(root_1, stream_VARIABLE.NextNode());
    			DebugLocation(170, 90);
    			adaptor.AddChild(root_1, stream_argDeclExpr.NextTree());
    			DebugLocation(170, 102);
    			adaptor.AddChild(root_1, stream_bodyExpr.NextTree());

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
        }
     	DebugLocation(171, 4);
    	} finally { DebugExitRule(GrammarFileName, "procedureDeclare"); }
    	return retval;

    }
    // $ANTLR end "procedureDeclare"

    public class conditionElseExpr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_conditionElseExpr() {}
    protected virtual void Leave_conditionElseExpr() {}

    // $ANTLR start "conditionElseExpr"
    // Lang2.g:175:1: conditionElseExpr : ELSE bodyExpr -> ^( ELSE bodyExpr ) ;
    [GrammarRule("conditionElseExpr")]
    private Lang2Parser.conditionElseExpr_return conditionElseExpr()
    {

        Lang2Parser.conditionElseExpr_return retval = new Lang2Parser.conditionElseExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken ELSE67=null;
        Lang2Parser.bodyExpr_return bodyExpr68 = default(Lang2Parser.bodyExpr_return);

        object ELSE67_tree=null;
        RewriteRuleITokenStream stream_ELSE=new RewriteRuleITokenStream(adaptor,"token ELSE");
        RewriteRuleSubtreeStream stream_bodyExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodyExpr");
    	try { DebugEnterRule(GrammarFileName, "conditionElseExpr");
    	DebugLocation(175, 5);
    	try
    	{
    		// Lang2.g:175:19: ( ELSE bodyExpr -> ^( ELSE bodyExpr ) )
    		DebugEnterAlt(1);
    		// Lang2.g:175:21: ELSE bodyExpr
    		{
    		DebugLocation(175, 25);
    		ELSE67=(IToken)Match(input,ELSE,Follow._ELSE_in_conditionElseExpr1005);  
    		stream_ELSE.Add(ELSE67);

    		DebugLocation(175, 27);
    		PushFollow(Follow._bodyExpr_in_conditionElseExpr1008);
    		bodyExpr68=bodyExpr();
    		PopFollow();

    		stream_bodyExpr.Add(bodyExpr68.Tree);


    		{
    		// AST REWRITE
    		// elements: ELSE, bodyExpr
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 175:36: -> ^( ELSE bodyExpr )
    		{
    			DebugLocation(175, 39);
    			// Lang2.g:175:39: ^( ELSE bodyExpr )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(175, 41);
    			root_1 = (object)adaptor.BecomeRoot(stream_ELSE.NextNode(), root_1);

    			DebugLocation(175, 46);
    			adaptor.AddChild(root_1, stream_bodyExpr.NextTree());

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
        }
     	DebugLocation(176, 5);
    	} finally { DebugExitRule(GrammarFileName, "conditionElseExpr"); }
    	return retval;

    }
    // $ANTLR end "conditionElseExpr"

    public class condExpr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_condExpr() {}
    protected virtual void Leave_condExpr() {}

    // $ANTLR start "condExpr"
    // Lang2.g:177:1: condExpr : '(' mathExpr ')' -> ^( CONDITION mathExpr ) ;
    [GrammarRule("condExpr")]
    private Lang2Parser.condExpr_return condExpr()
    {

        Lang2Parser.condExpr_return retval = new Lang2Parser.condExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken char_literal69=null;
        IToken char_literal71=null;
        Lang2Parser.mathExpr_return mathExpr70 = default(Lang2Parser.mathExpr_return);

        object char_literal69_tree=null;
        object char_literal71_tree=null;
        RewriteRuleITokenStream stream_57=new RewriteRuleITokenStream(adaptor,"token 57");
        RewriteRuleITokenStream stream_56=new RewriteRuleITokenStream(adaptor,"token 56");
        RewriteRuleSubtreeStream stream_mathExpr=new RewriteRuleSubtreeStream(adaptor,"rule mathExpr");
    	try { DebugEnterRule(GrammarFileName, "condExpr");
    	DebugLocation(177, 3);
    	try
    	{
    		// Lang2.g:177:10: ( '(' mathExpr ')' -> ^( CONDITION mathExpr ) )
    		DebugEnterAlt(1);
    		// Lang2.g:177:12: '(' mathExpr ')'
    		{
    		DebugLocation(177, 15);
    		char_literal69=(IToken)Match(input,56,Follow._56_in_condExpr1029);  
    		stream_56.Add(char_literal69);

    		DebugLocation(177, 17);
    		PushFollow(Follow._mathExpr_in_condExpr1032);
    		mathExpr70=mathExpr();
    		PopFollow();

    		stream_mathExpr.Add(mathExpr70.Tree);
    		DebugLocation(177, 29);
    		char_literal71=(IToken)Match(input,57,Follow._57_in_condExpr1034);  
    		stream_57.Add(char_literal71);



    		{
    		// AST REWRITE
    		// elements: mathExpr
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 177:31: -> ^( CONDITION mathExpr )
    		{
    			DebugLocation(177, 34);
    			// Lang2.g:177:34: ^( CONDITION mathExpr )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(177, 36);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(CONDITION, "CONDITION"), root_1);

    			DebugLocation(177, 46);
    			adaptor.AddChild(root_1, stream_mathExpr.NextTree());

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
        }
     	DebugLocation(178, 3);
    	} finally { DebugExitRule(GrammarFileName, "condExpr"); }
    	return retval;

    }
    // $ANTLR end "condExpr"

    public class conditionExpr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_conditionExpr() {}
    protected virtual void Leave_conditionExpr() {}

    // $ANTLR start "conditionExpr"
    // Lang2.g:179:1: conditionExpr : IF condExpr THEN bodyExpr ( conditionElseExpr )? -> ^( IF condExpr bodyExpr ( conditionElseExpr )? ) ;
    [GrammarRule("conditionExpr")]
    private Lang2Parser.conditionExpr_return conditionExpr()
    {

        Lang2Parser.conditionExpr_return retval = new Lang2Parser.conditionExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken IF72=null;
        IToken THEN74=null;
        Lang2Parser.condExpr_return condExpr73 = default(Lang2Parser.condExpr_return);
        Lang2Parser.bodyExpr_return bodyExpr75 = default(Lang2Parser.bodyExpr_return);
        Lang2Parser.conditionElseExpr_return conditionElseExpr76 = default(Lang2Parser.conditionElseExpr_return);

        object IF72_tree=null;
        object THEN74_tree=null;
        RewriteRuleITokenStream stream_THEN=new RewriteRuleITokenStream(adaptor,"token THEN");
        RewriteRuleITokenStream stream_IF=new RewriteRuleITokenStream(adaptor,"token IF");
        RewriteRuleSubtreeStream stream_condExpr=new RewriteRuleSubtreeStream(adaptor,"rule condExpr");
        RewriteRuleSubtreeStream stream_conditionElseExpr=new RewriteRuleSubtreeStream(adaptor,"rule conditionElseExpr");
        RewriteRuleSubtreeStream stream_bodyExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodyExpr");
    	try { DebugEnterRule(GrammarFileName, "conditionExpr");
    	DebugLocation(179, 1);
    	try
    	{
    		// Lang2.g:179:14: ( IF condExpr THEN bodyExpr ( conditionElseExpr )? -> ^( IF condExpr bodyExpr ( conditionElseExpr )? ) )
    		DebugEnterAlt(1);
    		// Lang2.g:179:16: IF condExpr THEN bodyExpr ( conditionElseExpr )?
    		{
    		DebugLocation(179, 16);
    		IF72=(IToken)Match(input,IF,Follow._IF_in_conditionExpr1053);  
    		stream_IF.Add(IF72);

    		DebugLocation(179, 19);
    		PushFollow(Follow._condExpr_in_conditionExpr1055);
    		condExpr73=condExpr();
    		PopFollow();

    		stream_condExpr.Add(condExpr73.Tree);
    		DebugLocation(179, 32);
    		THEN74=(IToken)Match(input,THEN,Follow._THEN_in_conditionExpr1057);  
    		stream_THEN.Add(THEN74);

    		DebugLocation(179, 34);
    		PushFollow(Follow._bodyExpr_in_conditionExpr1060);
    		bodyExpr75=bodyExpr();
    		PopFollow();

    		stream_bodyExpr.Add(bodyExpr75.Tree);
    		DebugLocation(179, 43);
    		// Lang2.g:179:43: ( conditionElseExpr )?
    		int alt13=2;
    		try { DebugEnterSubRule(13);
    		try { DebugEnterDecision(13, decisionCanBacktrack[13]);
    		int LA13_0 = input.LA(1);

    		if ((LA13_0==ELSE))
    		{
    			alt13=1;
    		}
    		} finally { DebugExitDecision(13); }
    		switch (alt13)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Lang2.g:179:43: conditionElseExpr
    			{
    			DebugLocation(179, 43);
    			PushFollow(Follow._conditionElseExpr_in_conditionExpr1062);
    			conditionElseExpr76=conditionElseExpr();
    			PopFollow();

    			stream_conditionElseExpr.Add(conditionElseExpr76.Tree);

    			}
    			break;

    		}
    		} finally { DebugExitSubRule(13); }



    		{
    		// AST REWRITE
    		// elements: conditionElseExpr, bodyExpr, condExpr, IF
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 179:62: -> ^( IF condExpr bodyExpr ( conditionElseExpr )? )
    		{
    			DebugLocation(179, 65);
    			// Lang2.g:179:65: ^( IF condExpr bodyExpr ( conditionElseExpr )? )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(179, 67);
    			root_1 = (object)adaptor.BecomeRoot(stream_IF.NextNode(), root_1);

    			DebugLocation(179, 70);
    			adaptor.AddChild(root_1, stream_condExpr.NextTree());
    			DebugLocation(179, 79);
    			adaptor.AddChild(root_1, stream_bodyExpr.NextTree());
    			DebugLocation(179, 88);
    			// Lang2.g:179:88: ( conditionElseExpr )?
    			if ( stream_conditionElseExpr.HasNext )
    			{
    				DebugLocation(179, 88);
    				adaptor.AddChild(root_1, stream_conditionElseExpr.NextTree());

    			}
    			stream_conditionElseExpr.Reset();

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
        }
     	DebugLocation(180, 1);
    	} finally { DebugExitRule(GrammarFileName, "conditionExpr"); }
    	return retval;

    }
    // $ANTLR end "conditionExpr"

    public class forExpr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_forExpr() {}
    protected virtual void Leave_forExpr() {}

    // $ANTLR start "forExpr"
    // Lang2.g:183:1: forExpr : assExpr TO expressions ;
    [GrammarRule("forExpr")]
    private Lang2Parser.forExpr_return forExpr()
    {

        Lang2Parser.forExpr_return retval = new Lang2Parser.forExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken TO78=null;
        Lang2Parser.assExpr_return assExpr77 = default(Lang2Parser.assExpr_return);
        Lang2Parser.expressions_return expressions79 = default(Lang2Parser.expressions_return);

        object TO78_tree=null;

    	try { DebugEnterRule(GrammarFileName, "forExpr");
    	DebugLocation(183, 2);
    	try
    	{
    		// Lang2.g:183:9: ( assExpr TO expressions )
    		DebugEnterAlt(1);
    		// Lang2.g:183:12: assExpr TO expressions
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(183, 12);
    		PushFollow(Follow._assExpr_in_forExpr1088);
    		assExpr77=assExpr();
    		PopFollow();

    		adaptor.AddChild(root_0, assExpr77.Tree);
    		DebugLocation(183, 22);
    		TO78=(IToken)Match(input,TO,Follow._TO_in_forExpr1090); 
    		TO78_tree = (object)adaptor.Create(TO78);
    		root_0 = (object)adaptor.BecomeRoot(TO78_tree, root_0);

    		DebugLocation(183, 24);
    		PushFollow(Follow._expressions_in_forExpr1093);
    		expressions79=expressions();
    		PopFollow();

    		adaptor.AddChild(root_0, expressions79.Tree);

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
        }
     	DebugLocation(184, 2);
    	} finally { DebugExitRule(GrammarFileName, "forExpr"); }
    	return retval;

    }
    // $ANTLR end "forExpr"

    public class loopExpr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_loopExpr() {}
    protected virtual void Leave_loopExpr() {}

    // $ANTLR start "loopExpr"
    // Lang2.g:185:1: loopExpr : ( WHILE condExpr DO bodyExpr -> ^( WHILE condExpr bodyExpr ) | FOR forExpr DO bodyExpr -> ^( FOR forExpr bodyExpr ) );
    [GrammarRule("loopExpr")]
    private Lang2Parser.loopExpr_return loopExpr()
    {

        Lang2Parser.loopExpr_return retval = new Lang2Parser.loopExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken WHILE80=null;
        IToken DO82=null;
        IToken FOR84=null;
        IToken DO86=null;
        Lang2Parser.condExpr_return condExpr81 = default(Lang2Parser.condExpr_return);
        Lang2Parser.bodyExpr_return bodyExpr83 = default(Lang2Parser.bodyExpr_return);
        Lang2Parser.forExpr_return forExpr85 = default(Lang2Parser.forExpr_return);
        Lang2Parser.bodyExpr_return bodyExpr87 = default(Lang2Parser.bodyExpr_return);

        object WHILE80_tree=null;
        object DO82_tree=null;
        object FOR84_tree=null;
        object DO86_tree=null;
        RewriteRuleITokenStream stream_FOR=new RewriteRuleITokenStream(adaptor,"token FOR");
        RewriteRuleITokenStream stream_DO=new RewriteRuleITokenStream(adaptor,"token DO");
        RewriteRuleITokenStream stream_WHILE=new RewriteRuleITokenStream(adaptor,"token WHILE");
        RewriteRuleSubtreeStream stream_condExpr=new RewriteRuleSubtreeStream(adaptor,"rule condExpr");
        RewriteRuleSubtreeStream stream_bodyExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodyExpr");
        RewriteRuleSubtreeStream stream_forExpr=new RewriteRuleSubtreeStream(adaptor,"rule forExpr");
    	try { DebugEnterRule(GrammarFileName, "loopExpr");
    	DebugLocation(185, 2);
    	try
    	{
    		// Lang2.g:185:9: ( WHILE condExpr DO bodyExpr -> ^( WHILE condExpr bodyExpr ) | FOR forExpr DO bodyExpr -> ^( FOR forExpr bodyExpr ) )
    		int alt14=2;
    		try { DebugEnterDecision(14, decisionCanBacktrack[14]);
    		int LA14_0 = input.LA(1);

    		if ((LA14_0==WHILE))
    		{
    			alt14=1;
    		}
    		else if ((LA14_0==FOR))
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
    			// Lang2.g:185:11: WHILE condExpr DO bodyExpr
    			{
    			DebugLocation(185, 11);
    			WHILE80=(IToken)Match(input,WHILE,Follow._WHILE_in_loopExpr1102);  
    			stream_WHILE.Add(WHILE80);

    			DebugLocation(185, 17);
    			PushFollow(Follow._condExpr_in_loopExpr1104);
    			condExpr81=condExpr();
    			PopFollow();

    			stream_condExpr.Add(condExpr81.Tree);
    			DebugLocation(185, 28);
    			DO82=(IToken)Match(input,DO,Follow._DO_in_loopExpr1106);  
    			stream_DO.Add(DO82);

    			DebugLocation(185, 30);
    			PushFollow(Follow._bodyExpr_in_loopExpr1109);
    			bodyExpr83=bodyExpr();
    			PopFollow();

    			stream_bodyExpr.Add(bodyExpr83.Tree);


    			{
    			// AST REWRITE
    			// elements: WHILE, bodyExpr, condExpr
    			// token labels: 
    			// rule labels: retval
    			// token list labels: 
    			// rule list labels: 
    			// wildcard labels: 
    			retval.Tree = root_0;
    			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    			root_0 = (object)adaptor.Nil();
    			// 185:39: -> ^( WHILE condExpr bodyExpr )
    			{
    				DebugLocation(185, 42);
    				// Lang2.g:185:42: ^( WHILE condExpr bodyExpr )
    				{
    				object root_1 = (object)adaptor.Nil();
    				DebugLocation(185, 44);
    				root_1 = (object)adaptor.BecomeRoot(stream_WHILE.NextNode(), root_1);

    				DebugLocation(185, 50);
    				adaptor.AddChild(root_1, stream_condExpr.NextTree());
    				DebugLocation(185, 59);
    				adaptor.AddChild(root_1, stream_bodyExpr.NextTree());

    				adaptor.AddChild(root_0, root_1);
    				}

    			}

    			retval.Tree = root_0;
    			}

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Lang2.g:186:5: FOR forExpr DO bodyExpr
    			{
    			DebugLocation(186, 5);
    			FOR84=(IToken)Match(input,FOR,Follow._FOR_in_loopExpr1125);  
    			stream_FOR.Add(FOR84);

    			DebugLocation(186, 9);
    			PushFollow(Follow._forExpr_in_loopExpr1127);
    			forExpr85=forExpr();
    			PopFollow();

    			stream_forExpr.Add(forExpr85.Tree);
    			DebugLocation(186, 17);
    			DO86=(IToken)Match(input,DO,Follow._DO_in_loopExpr1129);  
    			stream_DO.Add(DO86);

    			DebugLocation(186, 20);
    			PushFollow(Follow._bodyExpr_in_loopExpr1131);
    			bodyExpr87=bodyExpr();
    			PopFollow();

    			stream_bodyExpr.Add(bodyExpr87.Tree);


    			{
    			// AST REWRITE
    			// elements: FOR, bodyExpr, forExpr
    			// token labels: 
    			// rule labels: retval
    			// token list labels: 
    			// rule list labels: 
    			// wildcard labels: 
    			retval.Tree = root_0;
    			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    			root_0 = (object)adaptor.Nil();
    			// 186:29: -> ^( FOR forExpr bodyExpr )
    			{
    				DebugLocation(186, 32);
    				// Lang2.g:186:32: ^( FOR forExpr bodyExpr )
    				{
    				object root_1 = (object)adaptor.Nil();
    				DebugLocation(186, 34);
    				root_1 = (object)adaptor.BecomeRoot(stream_FOR.NextNode(), root_1);

    				DebugLocation(186, 38);
    				adaptor.AddChild(root_1, stream_forExpr.NextTree());
    				DebugLocation(186, 46);
    				adaptor.AddChild(root_1, stream_bodyExpr.NextTree());

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
        }
     	DebugLocation(187, 2);
    	} finally { DebugExitRule(GrammarFileName, "loopExpr"); }
    	return retval;

    }
    // $ANTLR end "loopExpr"

    public class assExpr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_assExpr() {}
    protected virtual void Leave_assExpr() {}

    // $ANTLR start "assExpr"
    // Lang2.g:189:1: assExpr : VARIABLE ASSIGN expressions ;
    [GrammarRule("assExpr")]
    private Lang2Parser.assExpr_return assExpr()
    {

        Lang2Parser.assExpr_return retval = new Lang2Parser.assExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken VARIABLE88=null;
        IToken ASSIGN89=null;
        Lang2Parser.expressions_return expressions90 = default(Lang2Parser.expressions_return);

        object VARIABLE88_tree=null;
        object ASSIGN89_tree=null;

    	try { DebugEnterRule(GrammarFileName, "assExpr");
    	DebugLocation(189, 1);
    	try
    	{
    		// Lang2.g:189:9: ( VARIABLE ASSIGN expressions )
    		DebugEnterAlt(1);
    		// Lang2.g:189:12: VARIABLE ASSIGN expressions
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(189, 12);
    		VARIABLE88=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_assExpr1154); 
    		VARIABLE88_tree = (object)adaptor.Create(VARIABLE88);
    		adaptor.AddChild(root_0, VARIABLE88_tree);

    		DebugLocation(189, 27);
    		ASSIGN89=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assExpr1156); 
    		ASSIGN89_tree = (object)adaptor.Create(ASSIGN89);
    		root_0 = (object)adaptor.BecomeRoot(ASSIGN89_tree, root_0);

    		DebugLocation(189, 29);
    		PushFollow(Follow._expressions_in_assExpr1159);
    		expressions90=expressions();
    		PopFollow();

    		adaptor.AddChild(root_0, expressions90.Tree);

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
        }
     	DebugLocation(190, 1);
    	} finally { DebugExitRule(GrammarFileName, "assExpr"); }
    	return retval;

    }
    // $ANTLR end "assExpr"

    public class argTypeDecl_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_argTypeDecl() {}
    protected virtual void Leave_argTypeDecl() {}

    // $ANTLR start "argTypeDecl"
    // Lang2.g:192:1: argTypeDecl : typeDecl -> ^( TYPE_DECL typeDecl ) ;
    [GrammarRule("argTypeDecl")]
    private Lang2Parser.argTypeDecl_return argTypeDecl()
    {

        Lang2Parser.argTypeDecl_return retval = new Lang2Parser.argTypeDecl_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.typeDecl_return typeDecl91 = default(Lang2Parser.typeDecl_return);

        RewriteRuleSubtreeStream stream_typeDecl=new RewriteRuleSubtreeStream(adaptor,"rule typeDecl");
    	try { DebugEnterRule(GrammarFileName, "argTypeDecl");
    	DebugLocation(192, 3);
    	try
    	{
    		// Lang2.g:192:13: ( typeDecl -> ^( TYPE_DECL typeDecl ) )
    		DebugEnterAlt(1);
    		// Lang2.g:192:15: typeDecl
    		{
    		DebugLocation(192, 15);
    		PushFollow(Follow._typeDecl_in_argTypeDecl1169);
    		typeDecl91=typeDecl();
    		PopFollow();

    		stream_typeDecl.Add(typeDecl91.Tree);


    		{
    		// AST REWRITE
    		// elements: typeDecl
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 192:24: -> ^( TYPE_DECL typeDecl )
    		{
    			DebugLocation(192, 27);
    			// Lang2.g:192:27: ^( TYPE_DECL typeDecl )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(192, 29);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(TYPE_DECL, "TYPE_DECL"), root_1);

    			DebugLocation(192, 39);
    			adaptor.AddChild(root_1, stream_typeDecl.NextTree());

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
        }
     	DebugLocation(193, 3);
    	} finally { DebugExitRule(GrammarFileName, "argTypeDecl"); }
    	return retval;

    }
    // $ANTLR end "argTypeDecl"

    public class argDecl_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_argDecl() {}
    protected virtual void Leave_argDecl() {}

    // $ANTLR start "argDecl"
    // Lang2.g:195:1: argDecl : ( VAR )? VARIABLE ( ',' VARIABLE )* ':' argTypeDecl ;
    [GrammarRule("argDecl")]
    private Lang2Parser.argDecl_return argDecl()
    {

        Lang2Parser.argDecl_return retval = new Lang2Parser.argDecl_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken VAR92=null;
        IToken VARIABLE93=null;
        IToken char_literal94=null;
        IToken VARIABLE95=null;
        IToken char_literal96=null;
        Lang2Parser.argTypeDecl_return argTypeDecl97 = default(Lang2Parser.argTypeDecl_return);

        object VAR92_tree=null;
        object VARIABLE93_tree=null;
        object char_literal94_tree=null;
        object VARIABLE95_tree=null;
        object char_literal96_tree=null;

    	try { DebugEnterRule(GrammarFileName, "argDecl");
    	DebugLocation(195, 2);
    	try
    	{
    		// Lang2.g:195:9: ( ( VAR )? VARIABLE ( ',' VARIABLE )* ':' argTypeDecl )
    		DebugEnterAlt(1);
    		// Lang2.g:195:11: ( VAR )? VARIABLE ( ',' VARIABLE )* ':' argTypeDecl
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(195, 11);
    		// Lang2.g:195:11: ( VAR )?
    		int alt15=2;
    		try { DebugEnterSubRule(15);
    		try { DebugEnterDecision(15, decisionCanBacktrack[15]);
    		int LA15_0 = input.LA(1);

    		if ((LA15_0==VAR))
    		{
    			alt15=1;
    		}
    		} finally { DebugExitDecision(15); }
    		switch (alt15)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Lang2.g:195:11: VAR
    			{
    			DebugLocation(195, 11);
    			VAR92=(IToken)Match(input,VAR,Follow._VAR_in_argDecl1189); 
    			VAR92_tree = (object)adaptor.Create(VAR92);
    			adaptor.AddChild(root_0, VAR92_tree);


    			}
    			break;

    		}
    		} finally { DebugExitSubRule(15); }

    		DebugLocation(195, 16);
    		VARIABLE93=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_argDecl1192); 
    		VARIABLE93_tree = (object)adaptor.Create(VARIABLE93);
    		adaptor.AddChild(root_0, VARIABLE93_tree);

    		DebugLocation(195, 24);
    		// Lang2.g:195:24: ( ',' VARIABLE )*
    		try { DebugEnterSubRule(16);
    		while (true)
    		{
    			int alt16=2;
    			try { DebugEnterDecision(16, decisionCanBacktrack[16]);
    			int LA16_0 = input.LA(1);

    			if ((LA16_0==58))
    			{
    				alt16=1;
    			}


    			} finally { DebugExitDecision(16); }
    			switch ( alt16 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:195:25: ',' VARIABLE
    				{
    				DebugLocation(195, 28);
    				char_literal94=(IToken)Match(input,58,Follow._58_in_argDecl1194); 
    				DebugLocation(195, 30);
    				VARIABLE95=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_argDecl1197); 
    				VARIABLE95_tree = (object)adaptor.Create(VARIABLE95);
    				adaptor.AddChild(root_0, VARIABLE95_tree);


    				}
    				break;

    			default:
    				goto loop16;
    			}
    		}

    		loop16:
    			;

    		} finally { DebugExitSubRule(16); }

    		DebugLocation(195, 44);
    		char_literal96=(IToken)Match(input,59,Follow._59_in_argDecl1201); 
    		DebugLocation(195, 46);
    		PushFollow(Follow._argTypeDecl_in_argDecl1204);
    		argTypeDecl97=argTypeDecl();
    		PopFollow();

    		adaptor.AddChild(root_0, argTypeDecl97.Tree);

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
        }
     	DebugLocation(196, 2);
    	} finally { DebugExitRule(GrammarFileName, "argDecl"); }
    	return retval;

    }
    // $ANTLR end "argDecl"

    public class argDeclManyW_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_argDeclManyW() {}
    protected virtual void Leave_argDeclManyW() {}

    // $ANTLR start "argDeclManyW"
    // Lang2.g:198:1: argDeclManyW : argDecl ( ',' argDecl )* ;
    [GrammarRule("argDeclManyW")]
    private Lang2Parser.argDeclManyW_return argDeclManyW()
    {

        Lang2Parser.argDeclManyW_return retval = new Lang2Parser.argDeclManyW_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken char_literal99=null;
        Lang2Parser.argDecl_return argDecl98 = default(Lang2Parser.argDecl_return);
        Lang2Parser.argDecl_return argDecl100 = default(Lang2Parser.argDecl_return);

        object char_literal99_tree=null;

    	try { DebugEnterRule(GrammarFileName, "argDeclManyW");
    	DebugLocation(198, 3);
    	try
    	{
    		// Lang2.g:198:14: ( argDecl ( ',' argDecl )* )
    		DebugEnterAlt(1);
    		// Lang2.g:198:16: argDecl ( ',' argDecl )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(198, 16);
    		PushFollow(Follow._argDecl_in_argDeclManyW1215);
    		argDecl98=argDecl();
    		PopFollow();

    		adaptor.AddChild(root_0, argDecl98.Tree);
    		DebugLocation(198, 23);
    		// Lang2.g:198:23: ( ',' argDecl )*
    		try { DebugEnterSubRule(17);
    		while (true)
    		{
    			int alt17=2;
    			try { DebugEnterDecision(17, decisionCanBacktrack[17]);
    			int LA17_0 = input.LA(1);

    			if ((LA17_0==58))
    			{
    				alt17=1;
    			}


    			} finally { DebugExitDecision(17); }
    			switch ( alt17 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:198:24: ',' argDecl
    				{
    				DebugLocation(198, 27);
    				char_literal99=(IToken)Match(input,58,Follow._58_in_argDeclManyW1217); 
    				DebugLocation(198, 29);
    				PushFollow(Follow._argDecl_in_argDeclManyW1220);
    				argDecl100=argDecl();
    				PopFollow();

    				adaptor.AddChild(root_0, argDecl100.Tree);

    				}
    				break;

    			default:
    				goto loop17;
    			}
    		}

    		loop17:
    			;

    		} finally { DebugExitSubRule(17); }


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
        }
     	DebugLocation(199, 3);
    	} finally { DebugExitRule(GrammarFileName, "argDeclManyW"); }
    	return retval;

    }
    // $ANTLR end "argDeclManyW"

    public class argDeclMany_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_argDeclMany() {}
    protected virtual void Leave_argDeclMany() {}

    // $ANTLR start "argDeclMany"
    // Lang2.g:200:1: argDeclMany : argDeclManyW -> ^( VAR_DECL argDeclManyW ) ;
    [GrammarRule("argDeclMany")]
    private Lang2Parser.argDeclMany_return argDeclMany()
    {

        Lang2Parser.argDeclMany_return retval = new Lang2Parser.argDeclMany_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.argDeclManyW_return argDeclManyW101 = default(Lang2Parser.argDeclManyW_return);

        RewriteRuleSubtreeStream stream_argDeclManyW=new RewriteRuleSubtreeStream(adaptor,"rule argDeclManyW");
    	try { DebugEnterRule(GrammarFileName, "argDeclMany");
    	DebugLocation(200, 3);
    	try
    	{
    		// Lang2.g:200:13: ( argDeclManyW -> ^( VAR_DECL argDeclManyW ) )
    		DebugEnterAlt(1);
    		// Lang2.g:200:15: argDeclManyW
    		{
    		DebugLocation(200, 15);
    		PushFollow(Follow._argDeclManyW_in_argDeclMany1233);
    		argDeclManyW101=argDeclManyW();
    		PopFollow();

    		stream_argDeclManyW.Add(argDeclManyW101.Tree);


    		{
    		// AST REWRITE
    		// elements: argDeclManyW
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 200:28: -> ^( VAR_DECL argDeclManyW )
    		{
    			DebugLocation(200, 31);
    			// Lang2.g:200:31: ^( VAR_DECL argDeclManyW )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(200, 33);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VAR_DECL, "VAR_DECL"), root_1);

    			DebugLocation(200, 42);
    			adaptor.AddChild(root_1, stream_argDeclManyW.NextTree());

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
        }
     	DebugLocation(201, 3);
    	} finally { DebugExitRule(GrammarFileName, "argDeclMany"); }
    	return retval;

    }
    // $ANTLR end "argDeclMany"

    public class typeDecl_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_typeDecl() {}
    protected virtual void Leave_typeDecl() {}

    // $ANTLR start "typeDecl"
    // Lang2.g:202:1: typeDecl : ( T_INT | T_CHAR | T_BOOL );
    [GrammarRule("typeDecl")]
    private Lang2Parser.typeDecl_return typeDecl()
    {

        Lang2Parser.typeDecl_return retval = new Lang2Parser.typeDecl_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken set102=null;

        object set102_tree=null;

    	try { DebugEnterRule(GrammarFileName, "typeDecl");
    	DebugLocation(202, 30);
    	try
    	{
    		// Lang2.g:202:10: ( T_INT | T_CHAR | T_BOOL )
    		DebugEnterAlt(1);
    		// Lang2.g:
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(202, 10);
    		set102=(IToken)input.LT(1);
    		if ((input.LA(1)>=T_CHAR && input.LA(1)<=T_INT))
    		{
    			input.Consume();
    			adaptor.AddChild(root_0, (object)adaptor.Create(set102));
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
        }
     	DebugLocation(202, 30);
    	} finally { DebugExitRule(GrammarFileName, "typeDecl"); }
    	return retval;

    }
    // $ANTLR end "typeDecl"

    public class varTypeDecl_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_varTypeDecl() {}
    protected virtual void Leave_varTypeDecl() {}

    // $ANTLR start "varTypeDecl"
    // Lang2.g:205:1: varTypeDecl : typeDecl OP_END -> ^( TYPE_DECL typeDecl ) ;
    [GrammarRule("varTypeDecl")]
    private Lang2Parser.varTypeDecl_return varTypeDecl()
    {

        Lang2Parser.varTypeDecl_return retval = new Lang2Parser.varTypeDecl_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken OP_END104=null;
        Lang2Parser.typeDecl_return typeDecl103 = default(Lang2Parser.typeDecl_return);

        object OP_END104_tree=null;
        RewriteRuleITokenStream stream_OP_END=new RewriteRuleITokenStream(adaptor,"token OP_END");
        RewriteRuleSubtreeStream stream_typeDecl=new RewriteRuleSubtreeStream(adaptor,"rule typeDecl");
    	try { DebugEnterRule(GrammarFileName, "varTypeDecl");
    	DebugLocation(205, 3);
    	try
    	{
    		// Lang2.g:205:13: ( typeDecl OP_END -> ^( TYPE_DECL typeDecl ) )
    		DebugEnterAlt(1);
    		// Lang2.g:205:15: typeDecl OP_END
    		{
    		DebugLocation(205, 15);
    		PushFollow(Follow._typeDecl_in_varTypeDecl1265);
    		typeDecl103=typeDecl();
    		PopFollow();

    		stream_typeDecl.Add(typeDecl103.Tree);
    		DebugLocation(205, 24);
    		OP_END104=(IToken)Match(input,OP_END,Follow._OP_END_in_varTypeDecl1267);  
    		stream_OP_END.Add(OP_END104);



    		{
    		// AST REWRITE
    		// elements: typeDecl
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 205:31: -> ^( TYPE_DECL typeDecl )
    		{
    			DebugLocation(205, 34);
    			// Lang2.g:205:34: ^( TYPE_DECL typeDecl )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(205, 36);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(TYPE_DECL, "TYPE_DECL"), root_1);

    			DebugLocation(205, 46);
    			adaptor.AddChild(root_1, stream_typeDecl.NextTree());

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
        }
     	DebugLocation(206, 3);
    	} finally { DebugExitRule(GrammarFileName, "varTypeDecl"); }
    	return retval;

    }
    // $ANTLR end "varTypeDecl"

    public class varDecl2_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_varDecl2() {}
    protected virtual void Leave_varDecl2() {}

    // $ANTLR start "varDecl2"
    // Lang2.g:209:1: varDecl2 : VARIABLE ( ',' VARIABLE )* ;
    [GrammarRule("varDecl2")]
    private Lang2Parser.varDecl2_return varDecl2()
    {

        Lang2Parser.varDecl2_return retval = new Lang2Parser.varDecl2_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken VARIABLE105=null;
        IToken char_literal106=null;
        IToken VARIABLE107=null;

        object VARIABLE105_tree=null;
        object char_literal106_tree=null;
        object VARIABLE107_tree=null;

    	try { DebugEnterRule(GrammarFileName, "varDecl2");
    	DebugLocation(209, 35);
    	try
    	{
    		// Lang2.g:209:10: ( VARIABLE ( ',' VARIABLE )* )
    		DebugEnterAlt(1);
    		// Lang2.g:209:12: VARIABLE ( ',' VARIABLE )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(209, 12);
    		VARIABLE105=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_varDecl21288); 
    		VARIABLE105_tree = (object)adaptor.Create(VARIABLE105);
    		adaptor.AddChild(root_0, VARIABLE105_tree);

    		DebugLocation(209, 20);
    		// Lang2.g:209:20: ( ',' VARIABLE )*
    		try { DebugEnterSubRule(18);
    		while (true)
    		{
    			int alt18=2;
    			try { DebugEnterDecision(18, decisionCanBacktrack[18]);
    			int LA18_0 = input.LA(1);

    			if ((LA18_0==58))
    			{
    				alt18=1;
    			}


    			} finally { DebugExitDecision(18); }
    			switch ( alt18 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:209:21: ',' VARIABLE
    				{
    				DebugLocation(209, 24);
    				char_literal106=(IToken)Match(input,58,Follow._58_in_varDecl21290); 
    				DebugLocation(209, 26);
    				VARIABLE107=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_varDecl21293); 
    				VARIABLE107_tree = (object)adaptor.Create(VARIABLE107);
    				adaptor.AddChild(root_0, VARIABLE107_tree);


    				}
    				break;

    			default:
    				goto loop18;
    			}
    		}

    		loop18:
    			;

    		} finally { DebugExitSubRule(18); }


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
        }
     	DebugLocation(209, 35);
    	} finally { DebugExitRule(GrammarFileName, "varDecl2"); }
    	return retval;

    }
    // $ANTLR end "varDecl2"

    public class varDecl_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_varDecl() {}
    protected virtual void Leave_varDecl() {}

    // $ANTLR start "varDecl"
    // Lang2.g:211:1: varDecl : varDecl2 ;
    [GrammarRule("varDecl")]
    private Lang2Parser.varDecl_return varDecl()
    {

        Lang2Parser.varDecl_return retval = new Lang2Parser.varDecl_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.varDecl2_return varDecl2108 = default(Lang2Parser.varDecl2_return);


    	try { DebugEnterRule(GrammarFileName, "varDecl");
    	DebugLocation(211, 2);
    	try
    	{
    		// Lang2.g:211:9: ( varDecl2 )
    		DebugEnterAlt(1);
    		// Lang2.g:211:11: varDecl2
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(211, 11);
    		PushFollow(Follow._varDecl2_in_varDecl1303);
    		varDecl2108=varDecl2();
    		PopFollow();

    		adaptor.AddChild(root_0, varDecl2108.Tree);

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
        }
     	DebugLocation(212, 2);
    	} finally { DebugExitRule(GrammarFileName, "varDecl"); }
    	return retval;

    }
    // $ANTLR end "varDecl"

    public class varDecl12W_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_varDecl12W() {}
    protected virtual void Leave_varDecl12W() {}

    // $ANTLR start "varDecl12W"
    // Lang2.g:213:1: varDecl12W : varDecl ':' varTypeDecl ;
    [GrammarRule("varDecl12W")]
    private Lang2Parser.varDecl12W_return varDecl12W()
    {

        Lang2Parser.varDecl12W_return retval = new Lang2Parser.varDecl12W_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken char_literal110=null;
        Lang2Parser.varDecl_return varDecl109 = default(Lang2Parser.varDecl_return);
        Lang2Parser.varTypeDecl_return varTypeDecl111 = default(Lang2Parser.varTypeDecl_return);

        object char_literal110_tree=null;

    	try { DebugEnterRule(GrammarFileName, "varDecl12W");
    	DebugLocation(213, 3);
    	try
    	{
    		// Lang2.g:213:12: ( varDecl ':' varTypeDecl )
    		DebugEnterAlt(1);
    		// Lang2.g:213:14: varDecl ':' varTypeDecl
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(213, 14);
    		PushFollow(Follow._varDecl_in_varDecl12W1313);
    		varDecl109=varDecl();
    		PopFollow();

    		adaptor.AddChild(root_0, varDecl109.Tree);
    		DebugLocation(213, 25);
    		char_literal110=(IToken)Match(input,59,Follow._59_in_varDecl12W1315); 
    		DebugLocation(213, 27);
    		PushFollow(Follow._varTypeDecl_in_varDecl12W1318);
    		varTypeDecl111=varTypeDecl();
    		PopFollow();

    		adaptor.AddChild(root_0, varTypeDecl111.Tree);

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
        }
     	DebugLocation(214, 3);
    	} finally { DebugExitRule(GrammarFileName, "varDecl12W"); }
    	return retval;

    }
    // $ANTLR end "varDecl12W"

    public class varDeclW_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_varDeclW() {}
    protected virtual void Leave_varDeclW() {}

    // $ANTLR start "varDeclW"
    // Lang2.g:215:1: varDeclW : VAR ( varDecl12W )+ -> ^( VAR_DECL ( varDecl12W )+ ) ;
    [GrammarRule("varDeclW")]
    private Lang2Parser.varDeclW_return varDeclW()
    {

        Lang2Parser.varDeclW_return retval = new Lang2Parser.varDeclW_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken VAR112=null;
        Lang2Parser.varDecl12W_return varDecl12W113 = default(Lang2Parser.varDecl12W_return);

        object VAR112_tree=null;
        RewriteRuleITokenStream stream_VAR=new RewriteRuleITokenStream(adaptor,"token VAR");
        RewriteRuleSubtreeStream stream_varDecl12W=new RewriteRuleSubtreeStream(adaptor,"rule varDecl12W");
    	try { DebugEnterRule(GrammarFileName, "varDeclW");
    	DebugLocation(215, 3);
    	try
    	{
    		// Lang2.g:215:10: ( VAR ( varDecl12W )+ -> ^( VAR_DECL ( varDecl12W )+ ) )
    		DebugEnterAlt(1);
    		// Lang2.g:215:12: VAR ( varDecl12W )+
    		{
    		DebugLocation(215, 12);
    		VAR112=(IToken)Match(input,VAR,Follow._VAR_in_varDeclW1330);  
    		stream_VAR.Add(VAR112);

    		DebugLocation(215, 16);
    		// Lang2.g:215:16: ( varDecl12W )+
    		int cnt19=0;
    		try { DebugEnterSubRule(19);
    		while (true)
    		{
    			int alt19=2;
    			try { DebugEnterDecision(19, decisionCanBacktrack[19]);
    			int LA19_0 = input.LA(1);

    			if ((LA19_0==VARIABLE))
    			{
    				alt19=1;
    			}


    			} finally { DebugExitDecision(19); }
    			switch (alt19)
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:215:16: varDecl12W
    				{
    				DebugLocation(215, 16);
    				PushFollow(Follow._varDecl12W_in_varDeclW1332);
    				varDecl12W113=varDecl12W();
    				PopFollow();

    				stream_varDecl12W.Add(varDecl12W113.Tree);

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



    		{
    		// AST REWRITE
    		// elements: varDecl12W
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 215:28: -> ^( VAR_DECL ( varDecl12W )+ )
    		{
    			DebugLocation(215, 31);
    			// Lang2.g:215:31: ^( VAR_DECL ( varDecl12W )+ )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(215, 33);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VAR_DECL, "VAR_DECL"), root_1);

    			DebugLocation(215, 42);
    			if ( !(stream_varDecl12W.HasNext) )
    			{
    				throw new RewriteEarlyExitException();
    			}
    			while ( stream_varDecl12W.HasNext )
    			{
    				DebugLocation(215, 42);
    				adaptor.AddChild(root_1, stream_varDecl12W.NextTree());

    			}
    			stream_varDecl12W.Reset();

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
        }
     	DebugLocation(216, 3);
    	} finally { DebugExitRule(GrammarFileName, "varDeclW"); }
    	return retval;

    }
    // $ANTLR end "varDeclW"

    public class bodyExpr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_bodyExpr() {}
    protected virtual void Leave_bodyExpr() {}

    // $ANTLR start "bodyExpr"
    // Lang2.g:220:1: bodyExpr : BEGIN ( bodyOper )+ END OP_END -> ^( BODY_EXPR ( bodyOper )+ ) ;
    [GrammarRule("bodyExpr")]
    private Lang2Parser.bodyExpr_return bodyExpr()
    {

        Lang2Parser.bodyExpr_return retval = new Lang2Parser.bodyExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken BEGIN114=null;
        IToken END116=null;
        IToken OP_END117=null;
        Lang2Parser.bodyOper_return bodyOper115 = default(Lang2Parser.bodyOper_return);

        object BEGIN114_tree=null;
        object END116_tree=null;
        object OP_END117_tree=null;
        RewriteRuleITokenStream stream_OP_END=new RewriteRuleITokenStream(adaptor,"token OP_END");
        RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
        RewriteRuleITokenStream stream_BEGIN=new RewriteRuleITokenStream(adaptor,"token BEGIN");
        RewriteRuleSubtreeStream stream_bodyOper=new RewriteRuleSubtreeStream(adaptor,"rule bodyOper");
    	try { DebugEnterRule(GrammarFileName, "bodyExpr");
    	DebugLocation(220, 3);
    	try
    	{
    		// Lang2.g:220:10: ( BEGIN ( bodyOper )+ END OP_END -> ^( BODY_EXPR ( bodyOper )+ ) )
    		DebugEnterAlt(1);
    		// Lang2.g:220:12: BEGIN ( bodyOper )+ END OP_END
    		{
    		DebugLocation(220, 17);
    		BEGIN114=(IToken)Match(input,BEGIN,Follow._BEGIN_in_bodyExpr1357);  
    		stream_BEGIN.Add(BEGIN114);

    		DebugLocation(220, 19);
    		// Lang2.g:220:19: ( bodyOper )+
    		int cnt20=0;
    		try { DebugEnterSubRule(20);
    		while (true)
    		{
    			int alt20=2;
    			try { DebugEnterDecision(20, decisionCanBacktrack[20]);
    			int LA20_0 = input.LA(1);

    			if ((LA20_0==WHILE||LA20_0==FOR||LA20_0==VAR||LA20_0==IF||(LA20_0>=CHAR && LA20_0<=TRUE)||LA20_0==VARIABLE||LA20_0==56))
    			{
    				alt20=1;
    			}


    			} finally { DebugExitDecision(20); }
    			switch (alt20)
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:220:19: bodyOper
    				{
    				DebugLocation(220, 19);
    				PushFollow(Follow._bodyOper_in_bodyExpr1360);
    				bodyOper115=bodyOper();
    				PopFollow();

    				stream_bodyOper.Add(bodyOper115.Tree);

    				}
    				break;

    			default:
    				if (cnt20 >= 1)
    					goto loop20;

    				EarlyExitException eee20 = new EarlyExitException( 20, input );
    				DebugRecognitionException(eee20);
    				throw eee20;
    			}
    			cnt20++;
    		}
    		loop20:
    			;

    		} finally { DebugExitSubRule(20); }

    		DebugLocation(220, 32);
    		END116=(IToken)Match(input,END,Follow._END_in_bodyExpr1363);  
    		stream_END.Add(END116);

    		DebugLocation(220, 40);
    		OP_END117=(IToken)Match(input,OP_END,Follow._OP_END_in_bodyExpr1366);  
    		stream_OP_END.Add(OP_END117);



    		{
    		// AST REWRITE
    		// elements: bodyOper
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 220:42: -> ^( BODY_EXPR ( bodyOper )+ )
    		{
    			DebugLocation(220, 45);
    			// Lang2.g:220:45: ^( BODY_EXPR ( bodyOper )+ )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(220, 47);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BODY_EXPR, "BODY_EXPR"), root_1);

    			DebugLocation(220, 57);
    			if ( !(stream_bodyOper.HasNext) )
    			{
    				throw new RewriteEarlyExitException();
    			}
    			while ( stream_bodyOper.HasNext )
    			{
    				DebugLocation(220, 57);
    				adaptor.AddChild(root_1, stream_bodyOper.NextTree());

    			}
    			stream_bodyOper.Reset();

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
        }
     	DebugLocation(221, 3);
    	} finally { DebugExitRule(GrammarFileName, "bodyExpr"); }
    	return retval;

    }
    // $ANTLR end "bodyExpr"

    public class func_proc_expr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_func_proc_expr() {}
    protected virtual void Leave_func_proc_expr() {}

    // $ANTLR start "func_proc_expr"
    // Lang2.g:223:1: func_proc_expr : ( funcDeclare | procedureDeclare );
    [GrammarRule("func_proc_expr")]
    private Lang2Parser.func_proc_expr_return func_proc_expr()
    {

        Lang2Parser.func_proc_expr_return retval = new Lang2Parser.func_proc_expr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.funcDeclare_return funcDeclare118 = default(Lang2Parser.funcDeclare_return);
        Lang2Parser.procedureDeclare_return procedureDeclare119 = default(Lang2Parser.procedureDeclare_return);


    	try { DebugEnterRule(GrammarFileName, "func_proc_expr");
    	DebugLocation(223, 46);
    	try
    	{
    		// Lang2.g:223:16: ( funcDeclare | procedureDeclare )
    		int alt21=2;
    		try { DebugEnterDecision(21, decisionCanBacktrack[21]);
    		int LA21_0 = input.LA(1);

    		if ((LA21_0==FUNCTION))
    		{
    			alt21=1;
    		}
    		else if ((LA21_0==PROCEDURE))
    		{
    			alt21=2;
    		}
    		else
    		{
    			NoViableAltException nvae = new NoViableAltException("", 21, 0, input);

    			DebugRecognitionException(nvae);
    			throw nvae;
    		}
    		} finally { DebugExitDecision(21); }
    		switch (alt21)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Lang2.g:223:18: funcDeclare
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(223, 18);
    			PushFollow(Follow._funcDeclare_in_func_proc_expr1388);
    			funcDeclare118=funcDeclare();
    			PopFollow();

    			adaptor.AddChild(root_0, funcDeclare118.Tree);

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Lang2.g:223:30: procedureDeclare
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(223, 30);
    			PushFollow(Follow._procedureDeclare_in_func_proc_expr1390);
    			procedureDeclare119=procedureDeclare();
    			PopFollow();

    			adaptor.AddChild(root_0, procedureDeclare119.Tree);

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
        }
     	DebugLocation(223, 46);
    	} finally { DebugExitRule(GrammarFileName, "func_proc_expr"); }
    	return retval;

    }
    // $ANTLR end "func_proc_expr"

    public class fpExprW_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_fpExprW() {}
    protected virtual void Leave_fpExprW() {}

    // $ANTLR start "fpExprW"
    // Lang2.g:225:1: fpExprW : ( func_proc_expr )* -> ^( FUNC_PROC_EXPR ( func_proc_expr )* ) ;
    [GrammarRule("fpExprW")]
    private Lang2Parser.fpExprW_return fpExprW()
    {

        Lang2Parser.fpExprW_return retval = new Lang2Parser.fpExprW_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.func_proc_expr_return func_proc_expr120 = default(Lang2Parser.func_proc_expr_return);

        RewriteRuleSubtreeStream stream_func_proc_expr=new RewriteRuleSubtreeStream(adaptor,"rule func_proc_expr");
    	try { DebugEnterRule(GrammarFileName, "fpExprW");
    	DebugLocation(225, 62);
    	try
    	{
    		// Lang2.g:225:9: ( ( func_proc_expr )* -> ^( FUNC_PROC_EXPR ( func_proc_expr )* ) )
    		DebugEnterAlt(1);
    		// Lang2.g:225:11: ( func_proc_expr )*
    		{
    		DebugLocation(225, 11);
    		// Lang2.g:225:11: ( func_proc_expr )*
    		try { DebugEnterSubRule(22);
    		while (true)
    		{
    			int alt22=2;
    			try { DebugEnterDecision(22, decisionCanBacktrack[22]);
    			int LA22_0 = input.LA(1);

    			if (((LA22_0>=FUNCTION && LA22_0<=PROCEDURE)))
    			{
    				alt22=1;
    			}


    			} finally { DebugExitDecision(22); }
    			switch ( alt22 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:225:11: func_proc_expr
    				{
    				DebugLocation(225, 11);
    				PushFollow(Follow._func_proc_expr_in_fpExprW1399);
    				func_proc_expr120=func_proc_expr();
    				PopFollow();

    				stream_func_proc_expr.Add(func_proc_expr120.Tree);

    				}
    				break;

    			default:
    				goto loop22;
    			}
    		}

    		loop22:
    			;

    		} finally { DebugExitSubRule(22); }



    		{
    		// AST REWRITE
    		// elements: func_proc_expr
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 225:27: -> ^( FUNC_PROC_EXPR ( func_proc_expr )* )
    		{
    			DebugLocation(225, 30);
    			// Lang2.g:225:30: ^( FUNC_PROC_EXPR ( func_proc_expr )* )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(225, 32);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_PROC_EXPR, "FUNC_PROC_EXPR"), root_1);

    			DebugLocation(225, 47);
    			// Lang2.g:225:47: ( func_proc_expr )*
    			while ( stream_func_proc_expr.HasNext )
    			{
    				DebugLocation(225, 47);
    				adaptor.AddChild(root_1, stream_func_proc_expr.NextTree());

    			}
    			stream_func_proc_expr.Reset();

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
        }
     	DebugLocation(225, 62);
    	} finally { DebugExitRule(GrammarFileName, "fpExprW"); }
    	return retval;

    }
    // $ANTLR end "fpExprW"

    public class expr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_expr() {}
    protected virtual void Leave_expr() {}

    // $ANTLR start "expr"
    // Lang2.g:227:1: expr : PROGRAM VARIABLE OP_END ( varDeclW )? fpExprW bodyExpr -> ^( PROGRAM VARIABLE ( varDeclW )? fpExprW bodyExpr ) ;
    [GrammarRule("expr")]
    private Lang2Parser.expr_return expr()
    {

        Lang2Parser.expr_return retval = new Lang2Parser.expr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken PROGRAM121=null;
        IToken VARIABLE122=null;
        IToken OP_END123=null;
        Lang2Parser.varDeclW_return varDeclW124 = default(Lang2Parser.varDeclW_return);
        Lang2Parser.fpExprW_return fpExprW125 = default(Lang2Parser.fpExprW_return);
        Lang2Parser.bodyExpr_return bodyExpr126 = default(Lang2Parser.bodyExpr_return);

        object PROGRAM121_tree=null;
        object VARIABLE122_tree=null;
        object OP_END123_tree=null;
        RewriteRuleITokenStream stream_PROGRAM=new RewriteRuleITokenStream(adaptor,"token PROGRAM");
        RewriteRuleITokenStream stream_VARIABLE=new RewriteRuleITokenStream(adaptor,"token VARIABLE");
        RewriteRuleITokenStream stream_OP_END=new RewriteRuleITokenStream(adaptor,"token OP_END");
        RewriteRuleSubtreeStream stream_varDeclW=new RewriteRuleSubtreeStream(adaptor,"rule varDeclW");
        RewriteRuleSubtreeStream stream_bodyExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodyExpr");
        RewriteRuleSubtreeStream stream_fpExprW=new RewriteRuleSubtreeStream(adaptor,"rule fpExprW");
    	try { DebugEnterRule(GrammarFileName, "expr");
    	DebugLocation(227, 1);
    	try
    	{
    		// Lang2.g:227:6: ( PROGRAM VARIABLE OP_END ( varDeclW )? fpExprW bodyExpr -> ^( PROGRAM VARIABLE ( varDeclW )? fpExprW bodyExpr ) )
    		DebugEnterAlt(1);
    		// Lang2.g:227:9: PROGRAM VARIABLE OP_END ( varDeclW )? fpExprW bodyExpr
    		{
    		DebugLocation(227, 9);
    		PROGRAM121=(IToken)Match(input,PROGRAM,Follow._PROGRAM_in_expr1418);  
    		stream_PROGRAM.Add(PROGRAM121);

    		DebugLocation(227, 17);
    		VARIABLE122=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_expr1420);  
    		stream_VARIABLE.Add(VARIABLE122);

    		DebugLocation(227, 32);
    		OP_END123=(IToken)Match(input,OP_END,Follow._OP_END_in_expr1422);  
    		stream_OP_END.Add(OP_END123);

    		DebugLocation(227, 34);
    		// Lang2.g:227:34: ( varDeclW )?
    		int alt23=2;
    		try { DebugEnterSubRule(23);
    		try { DebugEnterDecision(23, decisionCanBacktrack[23]);
    		int LA23_0 = input.LA(1);

    		if ((LA23_0==VAR))
    		{
    			alt23=1;
    		}
    		} finally { DebugExitDecision(23); }
    		switch (alt23)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Lang2.g:227:34: varDeclW
    			{
    			DebugLocation(227, 34);
    			PushFollow(Follow._varDeclW_in_expr1425);
    			varDeclW124=varDeclW();
    			PopFollow();

    			stream_varDeclW.Add(varDeclW124.Tree);

    			}
    			break;

    		}
    		} finally { DebugExitSubRule(23); }

    		DebugLocation(227, 44);
    		PushFollow(Follow._fpExprW_in_expr1428);
    		fpExprW125=fpExprW();
    		PopFollow();

    		stream_fpExprW.Add(fpExprW125.Tree);
    		DebugLocation(227, 52);
    		PushFollow(Follow._bodyExpr_in_expr1430);
    		bodyExpr126=bodyExpr();
    		PopFollow();

    		stream_bodyExpr.Add(bodyExpr126.Tree);


    		{
    		// AST REWRITE
    		// elements: VARIABLE, bodyExpr, fpExprW, PROGRAM, varDeclW
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 227:61: -> ^( PROGRAM VARIABLE ( varDeclW )? fpExprW bodyExpr )
    		{
    			DebugLocation(227, 64);
    			// Lang2.g:227:64: ^( PROGRAM VARIABLE ( varDeclW )? fpExprW bodyExpr )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(227, 66);
    			root_1 = (object)adaptor.BecomeRoot(stream_PROGRAM.NextNode(), root_1);

    			DebugLocation(227, 74);
    			adaptor.AddChild(root_1, stream_VARIABLE.NextNode());
    			DebugLocation(227, 83);
    			// Lang2.g:227:83: ( varDeclW )?
    			if ( stream_varDeclW.HasNext )
    			{
    				DebugLocation(227, 83);
    				adaptor.AddChild(root_1, stream_varDeclW.NextTree());

    			}
    			stream_varDeclW.Reset();
    			DebugLocation(227, 93);
    			adaptor.AddChild(root_1, stream_fpExprW.NextTree());
    			DebugLocation(227, 101);
    			adaptor.AddChild(root_1, stream_bodyExpr.NextTree());

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
        }
     	DebugLocation(228, 1);
    	} finally { DebugExitRule(GrammarFileName, "expr"); }
    	return retval;

    }
    // $ANTLR end "expr"

    public class program_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_program() {}
    protected virtual void Leave_program() {}

    // $ANTLR start "program"
    // Lang2.g:230:1: program : ( expr )+ ;
    [GrammarRule("program")]
    private Lang2Parser.program_return program()
    {

        Lang2Parser.program_return retval = new Lang2Parser.program_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.expr_return expr127 = default(Lang2Parser.expr_return);


    	try { DebugEnterRule(GrammarFileName, "program");
    	DebugLocation(230, 16);
    	try
    	{
    		// Lang2.g:230:8: ( ( expr )+ )
    		DebugEnterAlt(1);
    		// Lang2.g:230:10: ( expr )+
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(230, 10);
    		// Lang2.g:230:10: ( expr )+
    		int cnt24=0;
    		try { DebugEnterSubRule(24);
    		while (true)
    		{
    			int alt24=2;
    			try { DebugEnterDecision(24, decisionCanBacktrack[24]);
    			int LA24_0 = input.LA(1);

    			if ((LA24_0==PROGRAM))
    			{
    				alt24=1;
    			}


    			} finally { DebugExitDecision(24); }
    			switch (alt24)
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:230:10: expr
    				{
    				DebugLocation(230, 10);
    				PushFollow(Follow._expr_in_program1455);
    				expr127=expr();
    				PopFollow();

    				adaptor.AddChild(root_0, expr127.Tree);

    				}
    				break;

    			default:
    				if (cnt24 >= 1)
    					goto loop24;

    				EarlyExitException eee24 = new EarlyExitException( 24, input );
    				DebugRecognitionException(eee24);
    				throw eee24;
    			}
    			cnt24++;
    		}
    		loop24:
    			;

    		} finally { DebugExitSubRule(24); }


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
        }
     	DebugLocation(230, 16);
    	} finally { DebugExitRule(GrammarFileName, "program"); }
    	return retval;

    }
    // $ANTLR end "program"

    public class result_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_result() {}
    protected virtual void Leave_result() {}

    // $ANTLR start "result"
    // Lang2.g:231:1: result : program EOF -> ^( PROGRAM program ) ;
    [GrammarRule("result")]
    private Lang2Parser.result_return result()
    {

        Lang2Parser.result_return retval = new Lang2Parser.result_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken EOF129=null;
        Lang2Parser.program_return program128 = default(Lang2Parser.program_return);

        object EOF129_tree=null;
        RewriteRuleITokenStream stream_EOF=new RewriteRuleITokenStream(adaptor,"token EOF");
        RewriteRuleSubtreeStream stream_program=new RewriteRuleSubtreeStream(adaptor,"rule program");
    	try { DebugEnterRule(GrammarFileName, "result");
    	DebugLocation(231, 41);
    	try
    	{
    		// Lang2.g:231:7: ( program EOF -> ^( PROGRAM program ) )
    		DebugEnterAlt(1);
    		// Lang2.g:231:9: program EOF
    		{
    		DebugLocation(231, 9);
    		PushFollow(Follow._program_in_result1464);
    		program128=program();
    		PopFollow();

    		stream_program.Add(program128.Tree);
    		DebugLocation(231, 17);
    		EOF129=(IToken)Match(input,EOF,Follow._EOF_in_result1466);  
    		stream_EOF.Add(EOF129);



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
    		// 231:21: -> ^( PROGRAM program )
    		{
    			DebugLocation(231, 24);
    			// Lang2.g:231:24: ^( PROGRAM program )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(231, 26);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PROGRAM, "PROGRAM"), root_1);

    			DebugLocation(231, 34);
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
        }
     	DebugLocation(231, 41);
    	} finally { DebugExitRule(GrammarFileName, "result"); }
    	return retval;

    }
    // $ANTLR end "result"

    public class execute_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_execute() {}
    protected virtual void Leave_execute() {}

    // $ANTLR start "execute"
    // Lang2.g:232:8: public execute : result ;
    [GrammarRule("execute")]
    public Lang2Parser.execute_return execute()
    {

        Lang2Parser.execute_return retval = new Lang2Parser.execute_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.result_return result130 = default(Lang2Parser.result_return);


    	try { DebugEnterRule(GrammarFileName, "execute");
    	DebugLocation(232, 23);
    	try
    	{
    		// Lang2.g:232:15: ( result )
    		DebugEnterAlt(1);
    		// Lang2.g:232:18: result
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(232, 18);
    		PushFollow(Follow._result_in_execute1483);
    		result130=result();
    		PopFollow();

    		adaptor.AddChild(root_0, result130.Tree);

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
        }
     	DebugLocation(232, 23);
    	} finally { DebugExitRule(GrammarFileName, "execute"); }
    	return retval;

    }
    // $ANTLR end "execute"

	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _set_in_boolOperator0 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _56_in_mathGroup530 = new BitSet(new ulong[]{0x010010000F040000UL});
		public static readonly BitSet _mathExpr_in_mathGroup532 = new BitSet(new ulong[]{0x030010000F040000UL});
		public static readonly BitSet _57_in_mathGroup534 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _INT_in_mathGroup541 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VAR_in_mathGroup547 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _CHAR_in_mathGroup553 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _FALSE_in_mathGroup559 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _TRUE_in_mathGroup563 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _funcCall_in_mathGroup569 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _mathGroup_in_boolMult581 = new BitSet(new ulong[]{0x0000008000000002UL});
		public static readonly BitSet _BOOL_MULT_in_boolMult583 = new BitSet(new ulong[]{0x010010000F040000UL});
		public static readonly BitSet _mathGroup_in_boolMult586 = new BitSet(new ulong[]{0x0000008000000002UL});
		public static readonly BitSet _boolMult_in_boolAdd600 = new BitSet(new ulong[]{0x0000010000000002UL});
		public static readonly BitSet _BOOL_ADD_in_boolAdd602 = new BitSet(new ulong[]{0x010010000F040000UL});
		public static readonly BitSet _boolMult_in_boolAdd605 = new BitSet(new ulong[]{0x0000010000000002UL});
		public static readonly BitSet _boolAdd_in_boolElse618 = new BitSet(new ulong[]{0x00F8000000000002UL});
		public static readonly BitSet _boolOperator_in_boolElse620 = new BitSet(new ulong[]{0x010010000F040000UL});
		public static readonly BitSet _boolAdd_in_boolElse623 = new BitSet(new ulong[]{0x00F8000000000002UL});
		public static readonly BitSet _boolElse_in_boolNegative637 = new BitSet(new ulong[]{0x0000000000010002UL});
		public static readonly BitSet _NOT_in_boolNegative640 = new BitSet(new ulong[]{0x010010000F040000UL});
		public static readonly BitSet _boolElse_in_boolNegative643 = new BitSet(new ulong[]{0x0000000000010002UL});
		public static readonly BitSet _boolNegative_in_useDiv657 = new BitSet(new ulong[]{0x000000000000C002UL});
		public static readonly BitSet _set_in_useDiv659 = new BitSet(new ulong[]{0x0100000000000000UL});
		public static readonly BitSet _56_in_useDiv666 = new BitSet(new ulong[]{0x010010000F040000UL});
		public static readonly BitSet _boolNegative_in_useDiv669 = new BitSet(new ulong[]{0x0200000000000000UL});
		public static readonly BitSet _57_in_useDiv671 = new BitSet(new ulong[]{0x000000000000C002UL});
		public static readonly BitSet _useDiv_in_mathMult688 = new BitSet(new ulong[]{0x0001800000000002UL});
		public static readonly BitSet _set_in_mathMult690 = new BitSet(new ulong[]{0x010010000F040000UL});
		public static readonly BitSet _useDiv_in_mathMult696 = new BitSet(new ulong[]{0x0001800000000002UL});
		public static readonly BitSet _mathMult_in_mathAdd709 = new BitSet(new ulong[]{0x0000600000000002UL});
		public static readonly BitSet _set_in_mathAdd711 = new BitSet(new ulong[]{0x010010000F040000UL});
		public static readonly BitSet _mathMult_in_mathAdd717 = new BitSet(new ulong[]{0x0000600000000002UL});
		public static readonly BitSet _mathAdd_in_mathExpr731 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _expressions_in_bodyOper745 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _assExpr_in_bodyOper752 = new BitSet(new ulong[]{0x0000040000000000UL});
		public static readonly BitSet _OP_END_in_bodyOper754 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _conditionExpr_in_bodyOper762 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _loopExpr_in_bodyOper769 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _mathExpr_in_expressions782 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VARIABLE_in_funcCallArgs796 = new BitSet(new ulong[]{0x0400000000000002UL});
		public static readonly BitSet _58_in_funcCallArgs798 = new BitSet(new ulong[]{0x0000100000000000UL});
		public static readonly BitSet _VARIABLE_in_funcCallArgs800 = new BitSet(new ulong[]{0x0400000000000002UL});
		public static readonly BitSet _funcCallArgs_in_funcCallArgsW815 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VARIABLE_in_funcCall836 = new BitSet(new ulong[]{0x0100000000000000UL});
		public static readonly BitSet _56_in_funcCall838 = new BitSet(new ulong[]{0x0200100000000000UL});
		public static readonly BitSet _funcCallArgsW_in_funcCall841 = new BitSet(new ulong[]{0x0200000000000000UL});
		public static readonly BitSet _57_in_funcCall844 = new BitSet(new ulong[]{0x0000040000000000UL});
		public static readonly BitSet _OP_END_in_funcCall847 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _56_in_argDeclExpr871 = new BitSet(new ulong[]{0x0000100000040000UL});
		public static readonly BitSet _argDeclMany_in_argDeclExpr874 = new BitSet(new ulong[]{0x0200000000000000UL});
		public static readonly BitSet _57_in_argDeclExpr875 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _set_in_retTypeExpr896 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _retTypeExpr_in_retTypeExprWrap914 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _FUNCTION_in_funcDeclare934 = new BitSet(new ulong[]{0x0000100000000000UL});
		public static readonly BitSet _VARIABLE_in_funcDeclare936 = new BitSet(new ulong[]{0x0100000000000000UL});
		public static readonly BitSet _argDeclExpr_in_funcDeclare938 = new BitSet(new ulong[]{0x0800000000000000UL});
		public static readonly BitSet _59_in_funcDeclare939 = new BitSet(new ulong[]{0x0000000000380000UL});
		public static readonly BitSet _retTypeExprWrap_in_funcDeclare941 = new BitSet(new ulong[]{0x0000040000000000UL});
		public static readonly BitSet _OP_END_in_funcDeclare943 = new BitSet(new ulong[]{0x0000000000000400UL});
		public static readonly BitSet _bodyExpr_in_funcDeclare947 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _PROCEDURE_in_procedureDeclare970 = new BitSet(new ulong[]{0x0000100000000000UL});
		public static readonly BitSet _VARIABLE_in_procedureDeclare972 = new BitSet(new ulong[]{0x0100000000000000UL});
		public static readonly BitSet _argDeclExpr_in_procedureDeclare974 = new BitSet(new ulong[]{0x0000040000000000UL});
		public static readonly BitSet _OP_END_in_procedureDeclare976 = new BitSet(new ulong[]{0x0000000000000400UL});
		public static readonly BitSet _bodyExpr_in_procedureDeclare978 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _ELSE_in_conditionElseExpr1005 = new BitSet(new ulong[]{0x0000000000000400UL});
		public static readonly BitSet _bodyExpr_in_conditionElseExpr1008 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _56_in_condExpr1029 = new BitSet(new ulong[]{0x010010000F040000UL});
		public static readonly BitSet _mathExpr_in_condExpr1032 = new BitSet(new ulong[]{0x0200000000000000UL});
		public static readonly BitSet _57_in_condExpr1034 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _IF_in_conditionExpr1053 = new BitSet(new ulong[]{0x0100000000000000UL});
		public static readonly BitSet _condExpr_in_conditionExpr1055 = new BitSet(new ulong[]{0x0000000000001000UL});
		public static readonly BitSet _THEN_in_conditionExpr1057 = new BitSet(new ulong[]{0x0000000000000400UL});
		public static readonly BitSet _bodyExpr_in_conditionExpr1060 = new BitSet(new ulong[]{0x0000000000002002UL});
		public static readonly BitSet _conditionElseExpr_in_conditionExpr1062 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _assExpr_in_forExpr1088 = new BitSet(new ulong[]{0x0000000000020000UL});
		public static readonly BitSet _TO_in_forExpr1090 = new BitSet(new ulong[]{0x010010000F040000UL});
		public static readonly BitSet _expressions_in_forExpr1093 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _WHILE_in_loopExpr1102 = new BitSet(new ulong[]{0x0100000000000000UL});
		public static readonly BitSet _condExpr_in_loopExpr1104 = new BitSet(new ulong[]{0x0000000000000040UL});
		public static readonly BitSet _DO_in_loopExpr1106 = new BitSet(new ulong[]{0x0000000000000400UL});
		public static readonly BitSet _bodyExpr_in_loopExpr1109 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _FOR_in_loopExpr1125 = new BitSet(new ulong[]{0x0000100000000000UL});
		public static readonly BitSet _forExpr_in_loopExpr1127 = new BitSet(new ulong[]{0x0000000000000040UL});
		public static readonly BitSet _DO_in_loopExpr1129 = new BitSet(new ulong[]{0x0000000000000400UL});
		public static readonly BitSet _bodyExpr_in_loopExpr1131 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VARIABLE_in_assExpr1154 = new BitSet(new ulong[]{0x0002000000000000UL});
		public static readonly BitSet _ASSIGN_in_assExpr1156 = new BitSet(new ulong[]{0x010010000F040000UL});
		public static readonly BitSet _expressions_in_assExpr1159 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _typeDecl_in_argTypeDecl1169 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VAR_in_argDecl1189 = new BitSet(new ulong[]{0x0000100000000000UL});
		public static readonly BitSet _VARIABLE_in_argDecl1192 = new BitSet(new ulong[]{0x0C00000000000000UL});
		public static readonly BitSet _58_in_argDecl1194 = new BitSet(new ulong[]{0x0000100000000000UL});
		public static readonly BitSet _VARIABLE_in_argDecl1197 = new BitSet(new ulong[]{0x0C00000000000000UL});
		public static readonly BitSet _59_in_argDecl1201 = new BitSet(new ulong[]{0x0000000000380000UL});
		public static readonly BitSet _argTypeDecl_in_argDecl1204 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _argDecl_in_argDeclManyW1215 = new BitSet(new ulong[]{0x0400000000000002UL});
		public static readonly BitSet _58_in_argDeclManyW1217 = new BitSet(new ulong[]{0x0000100000040000UL});
		public static readonly BitSet _argDecl_in_argDeclManyW1220 = new BitSet(new ulong[]{0x0400000000000002UL});
		public static readonly BitSet _argDeclManyW_in_argDeclMany1233 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _set_in_typeDecl0 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _typeDecl_in_varTypeDecl1265 = new BitSet(new ulong[]{0x0000040000000000UL});
		public static readonly BitSet _OP_END_in_varTypeDecl1267 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VARIABLE_in_varDecl21288 = new BitSet(new ulong[]{0x0400000000000002UL});
		public static readonly BitSet _58_in_varDecl21290 = new BitSet(new ulong[]{0x0000100000000000UL});
		public static readonly BitSet _VARIABLE_in_varDecl21293 = new BitSet(new ulong[]{0x0400000000000002UL});
		public static readonly BitSet _varDecl2_in_varDecl1303 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _varDecl_in_varDecl12W1313 = new BitSet(new ulong[]{0x0800000000000000UL});
		public static readonly BitSet _59_in_varDecl12W1315 = new BitSet(new ulong[]{0x0000000000380000UL});
		public static readonly BitSet _varTypeDecl_in_varDecl12W1318 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VAR_in_varDeclW1330 = new BitSet(new ulong[]{0x0000100000000000UL});
		public static readonly BitSet _varDecl12W_in_varDeclW1332 = new BitSet(new ulong[]{0x0000100000000002UL});
		public static readonly BitSet _BEGIN_in_bodyExpr1357 = new BitSet(new ulong[]{0x010010000F4400A0UL});
		public static readonly BitSet _bodyOper_in_bodyExpr1360 = new BitSet(new ulong[]{0x010010000F4408A0UL});
		public static readonly BitSet _END_in_bodyExpr1363 = new BitSet(new ulong[]{0x0000040000000000UL});
		public static readonly BitSet _OP_END_in_bodyExpr1366 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _funcDeclare_in_func_proc_expr1388 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _procedureDeclare_in_func_proc_expr1390 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _func_proc_expr_in_fpExprW1399 = new BitSet(new ulong[]{0x0000000000000302UL});
		public static readonly BitSet _PROGRAM_in_expr1418 = new BitSet(new ulong[]{0x0000100000000000UL});
		public static readonly BitSet _VARIABLE_in_expr1420 = new BitSet(new ulong[]{0x0000040000000000UL});
		public static readonly BitSet _OP_END_in_expr1422 = new BitSet(new ulong[]{0x0000000000040300UL});
		public static readonly BitSet _varDeclW_in_expr1425 = new BitSet(new ulong[]{0x0000000000040300UL});
		public static readonly BitSet _fpExprW_in_expr1428 = new BitSet(new ulong[]{0x0000000000000400UL});
		public static readonly BitSet _bodyExpr_in_expr1430 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _expr_in_program1455 = new BitSet(new ulong[]{0x0000000000000012UL});
		public static readonly BitSet _program_in_result1464 = new BitSet(new ulong[]{0x0000000000000000UL});
		public static readonly BitSet _EOF_in_result1466 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _result_in_execute1483 = new BitSet(new ulong[]{0x0000000000000002UL});

	}
	#endregion Follow sets
}
}