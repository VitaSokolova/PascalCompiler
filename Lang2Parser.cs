// $ANTLR 3.3 Nov 30, 2010 12:50:56 Lang2.g 2016-11-21 16:18:47

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
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "PROGRAM", "WHILE", "DO", "FOR", "FUNCTION", "PROCEDURE", "BEGIN", "END", "THEN", "ELSE", "DIV", "MOD", "NOT", "TO", "VAR", "T_CHAR", "T_BOOL", "T_INT", "IF", "BOOL", "CHAR", "INT", "FALSE", "TRUE", "VAR_DECL", "BODY_EXPR", "VAR_EXPR", "FUNC_PROC_EXPR", "PROC_DECL", "FUNC_DECL", "FUNC_CALL", "FUNC_CALL_ARGS", "FUNC_PROC_ARGS", "FUNC_PROC_RET_TYPE", "TYPE_DECL", "BOOL_MULT", "BOOL_ADD", "CONDITION", "ARRAY", "OF", "ARR_DECL", "RANGE", "ARR_CALL", "OP_END", "WS", "VARIABLE", "ADD", "REM", "MULT", "DIVIDE", "ASSIGN", "GREATER", "LESS", "EQUAL", "LESS_OR_EQUAL", "GREATER_OR_EQUAL", "MORE", "'['", "'..'", "']'", "'('", "')'", "','", "':'"
	};
	public const int EOF=-1;
	public const int T__61=61;
	public const int T__62=62;
	public const int T__63=63;
	public const int T__64=64;
	public const int T__65=65;
	public const int T__66=66;
	public const int T__67=67;
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
	public const int ARRAY=42;
	public const int OF=43;
	public const int ARR_DECL=44;
	public const int RANGE=45;
	public const int ARR_CALL=46;
	public const int OP_END=47;
	public const int WS=48;
	public const int VARIABLE=49;
	public const int ADD=50;
	public const int REM=51;
	public const int MULT=52;
	public const int DIVIDE=53;
	public const int ASSIGN=54;
	public const int GREATER=55;
	public const int LESS=56;
	public const int EQUAL=57;
	public const int LESS_OR_EQUAL=58;
	public const int GREATER_OR_EQUAL=59;
	public const int MORE=60;

	// delegates
	// delegators

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				false, false, false, false, false, false, false, false, false, false, 
				false, false, false, false, false, false, false, false, false, false, 
				false, false, false, false, false, false, false, false, false
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

    public class arrayRange_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_arrayRange() {}
    protected virtual void Leave_arrayRange() {}

    // $ANTLR start "arrayRange"
    // Lang2.g:82:1: arrayRange : '[' expressions '..' expressions ']' -> ^( RANGE expressions expressions ) ;
    [GrammarRule("arrayRange")]
    private Lang2Parser.arrayRange_return arrayRange()
    {

        Lang2Parser.arrayRange_return retval = new Lang2Parser.arrayRange_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken char_literal1=null;
        IToken string_literal3=null;
        IToken char_literal5=null;
        Lang2Parser.expressions_return expressions2 = default(Lang2Parser.expressions_return);
        Lang2Parser.expressions_return expressions4 = default(Lang2Parser.expressions_return);

        object char_literal1_tree=null;
        object string_literal3_tree=null;
        object char_literal5_tree=null;
        RewriteRuleITokenStream stream_62=new RewriteRuleITokenStream(adaptor,"token 62");
        RewriteRuleITokenStream stream_63=new RewriteRuleITokenStream(adaptor,"token 63");
        RewriteRuleITokenStream stream_61=new RewriteRuleITokenStream(adaptor,"token 61");
        RewriteRuleSubtreeStream stream_expressions=new RewriteRuleSubtreeStream(adaptor,"rule expressions");
    	try { DebugEnterRule(GrammarFileName, "arrayRange");
    	DebugLocation(82, 3);
    	try
    	{
    		// Lang2.g:82:12: ( '[' expressions '..' expressions ']' -> ^( RANGE expressions expressions ) )
    		DebugEnterAlt(1);
    		// Lang2.g:82:14: '[' expressions '..' expressions ']'
    		{
    		DebugLocation(82, 14);
    		char_literal1=(IToken)Match(input,61,Follow._61_in_arrayRange429);  
    		stream_61.Add(char_literal1);

    		DebugLocation(82, 17);
    		PushFollow(Follow._expressions_in_arrayRange430);
    		expressions2=expressions();
    		PopFollow();

    		stream_expressions.Add(expressions2.Tree);
    		DebugLocation(82, 29);
    		string_literal3=(IToken)Match(input,62,Follow._62_in_arrayRange432);  
    		stream_62.Add(string_literal3);

    		DebugLocation(82, 34);
    		PushFollow(Follow._expressions_in_arrayRange434);
    		expressions4=expressions();
    		PopFollow();

    		stream_expressions.Add(expressions4.Tree);
    		DebugLocation(82, 45);
    		char_literal5=(IToken)Match(input,63,Follow._63_in_arrayRange435);  
    		stream_63.Add(char_literal5);



    		{
    		// AST REWRITE
    		// elements: expressions, expressions
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 82:49: -> ^( RANGE expressions expressions )
    		{
    			DebugLocation(82, 52);
    			// Lang2.g:82:52: ^( RANGE expressions expressions )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(82, 54);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(RANGE, "RANGE"), root_1);

    			DebugLocation(82, 60);
    			adaptor.AddChild(root_1, stream_expressions.NextTree());
    			DebugLocation(82, 72);
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
        }
     	DebugLocation(83, 3);
    	} finally { DebugExitRule(GrammarFileName, "arrayRange"); }
    	return retval;

    }
    // $ANTLR end "arrayRange"

    public class arrayTypeDecl_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_arrayTypeDecl() {}
    protected virtual void Leave_arrayTypeDecl() {}

    // $ANTLR start "arrayTypeDecl"
    // Lang2.g:84:1: arrayTypeDecl : OF typeDecl -> ^( TYPE_DECL typeDecl ) ;
    [GrammarRule("arrayTypeDecl")]
    private Lang2Parser.arrayTypeDecl_return arrayTypeDecl()
    {

        Lang2Parser.arrayTypeDecl_return retval = new Lang2Parser.arrayTypeDecl_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken OF6=null;
        Lang2Parser.typeDecl_return typeDecl7 = default(Lang2Parser.typeDecl_return);

        object OF6_tree=null;
        RewriteRuleITokenStream stream_OF=new RewriteRuleITokenStream(adaptor,"token OF");
        RewriteRuleSubtreeStream stream_typeDecl=new RewriteRuleSubtreeStream(adaptor,"rule typeDecl");
    	try { DebugEnterRule(GrammarFileName, "arrayTypeDecl");
    	DebugLocation(84, 4);
    	try
    	{
    		// Lang2.g:84:15: ( OF typeDecl -> ^( TYPE_DECL typeDecl ) )
    		DebugEnterAlt(1);
    		// Lang2.g:84:17: OF typeDecl
    		{
    		DebugLocation(84, 17);
    		OF6=(IToken)Match(input,OF,Follow._OF_in_arrayTypeDecl456);  
    		stream_OF.Add(OF6);

    		DebugLocation(84, 20);
    		PushFollow(Follow._typeDecl_in_arrayTypeDecl458);
    		typeDecl7=typeDecl();
    		PopFollow();

    		stream_typeDecl.Add(typeDecl7.Tree);


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
    		// 84:29: -> ^( TYPE_DECL typeDecl )
    		{
    			DebugLocation(84, 32);
    			// Lang2.g:84:32: ^( TYPE_DECL typeDecl )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(84, 34);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(TYPE_DECL, "TYPE_DECL"), root_1);

    			DebugLocation(84, 44);
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
     	DebugLocation(85, 4);
    	} finally { DebugExitRule(GrammarFileName, "arrayTypeDecl"); }
    	return retval;

    }
    // $ANTLR end "arrayTypeDecl"

    public class arrayDecl_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_arrayDecl() {}
    protected virtual void Leave_arrayDecl() {}

    // $ANTLR start "arrayDecl"
    // Lang2.g:86:1: arrayDecl : ARRAY arrayRange arrayTypeDecl -> ^( ARR_DECL arrayRange arrayTypeDecl ) ;
    [GrammarRule("arrayDecl")]
    private Lang2Parser.arrayDecl_return arrayDecl()
    {

        Lang2Parser.arrayDecl_return retval = new Lang2Parser.arrayDecl_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken ARRAY8=null;
        Lang2Parser.arrayRange_return arrayRange9 = default(Lang2Parser.arrayRange_return);
        Lang2Parser.arrayTypeDecl_return arrayTypeDecl10 = default(Lang2Parser.arrayTypeDecl_return);

        object ARRAY8_tree=null;
        RewriteRuleITokenStream stream_ARRAY=new RewriteRuleITokenStream(adaptor,"token ARRAY");
        RewriteRuleSubtreeStream stream_arrayTypeDecl=new RewriteRuleSubtreeStream(adaptor,"rule arrayTypeDecl");
        RewriteRuleSubtreeStream stream_arrayRange=new RewriteRuleSubtreeStream(adaptor,"rule arrayRange");
    	try { DebugEnterRule(GrammarFileName, "arrayDecl");
    	DebugLocation(86, 3);
    	try
    	{
    		// Lang2.g:86:11: ( ARRAY arrayRange arrayTypeDecl -> ^( ARR_DECL arrayRange arrayTypeDecl ) )
    		DebugEnterAlt(1);
    		// Lang2.g:86:14: ARRAY arrayRange arrayTypeDecl
    		{
    		DebugLocation(86, 14);
    		ARRAY8=(IToken)Match(input,ARRAY,Follow._ARRAY_in_arrayDecl479);  
    		stream_ARRAY.Add(ARRAY8);

    		DebugLocation(86, 20);
    		PushFollow(Follow._arrayRange_in_arrayDecl481);
    		arrayRange9=arrayRange();
    		PopFollow();

    		stream_arrayRange.Add(arrayRange9.Tree);
    		DebugLocation(86, 31);
    		PushFollow(Follow._arrayTypeDecl_in_arrayDecl483);
    		arrayTypeDecl10=arrayTypeDecl();
    		PopFollow();

    		stream_arrayTypeDecl.Add(arrayTypeDecl10.Tree);


    		{
    		// AST REWRITE
    		// elements: arrayRange, arrayTypeDecl
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 86:45: -> ^( ARR_DECL arrayRange arrayTypeDecl )
    		{
    			DebugLocation(86, 48);
    			// Lang2.g:86:48: ^( ARR_DECL arrayRange arrayTypeDecl )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(86, 50);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARR_DECL, "ARR_DECL"), root_1);

    			DebugLocation(86, 59);
    			adaptor.AddChild(root_1, stream_arrayRange.NextTree());
    			DebugLocation(86, 70);
    			adaptor.AddChild(root_1, stream_arrayTypeDecl.NextTree());

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
     	DebugLocation(87, 3);
    	} finally { DebugExitRule(GrammarFileName, "arrayDecl"); }
    	return retval;

    }
    // $ANTLR end "arrayDecl"

    public class arrayCall_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_arrayCall() {}
    protected virtual void Leave_arrayCall() {}

    // $ANTLR start "arrayCall"
    // Lang2.g:89:1: arrayCall : VARIABLE '[' expressions ']' -> ^( ARR_CALL VARIABLE expressions ) ;
    [GrammarRule("arrayCall")]
    private Lang2Parser.arrayCall_return arrayCall()
    {

        Lang2Parser.arrayCall_return retval = new Lang2Parser.arrayCall_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken VARIABLE11=null;
        IToken char_literal12=null;
        IToken char_literal14=null;
        Lang2Parser.expressions_return expressions13 = default(Lang2Parser.expressions_return);

        object VARIABLE11_tree=null;
        object char_literal12_tree=null;
        object char_literal14_tree=null;
        RewriteRuleITokenStream stream_VARIABLE=new RewriteRuleITokenStream(adaptor,"token VARIABLE");
        RewriteRuleITokenStream stream_63=new RewriteRuleITokenStream(adaptor,"token 63");
        RewriteRuleITokenStream stream_61=new RewriteRuleITokenStream(adaptor,"token 61");
        RewriteRuleSubtreeStream stream_expressions=new RewriteRuleSubtreeStream(adaptor,"rule expressions");
    	try { DebugEnterRule(GrammarFileName, "arrayCall");
    	DebugLocation(89, 3);
    	try
    	{
    		// Lang2.g:89:11: ( VARIABLE '[' expressions ']' -> ^( ARR_CALL VARIABLE expressions ) )
    		DebugEnterAlt(1);
    		// Lang2.g:89:13: VARIABLE '[' expressions ']'
    		{
    		DebugLocation(89, 13);
    		VARIABLE11=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_arrayCall506);  
    		stream_VARIABLE.Add(VARIABLE11);

    		DebugLocation(89, 22);
    		char_literal12=(IToken)Match(input,61,Follow._61_in_arrayCall508);  
    		stream_61.Add(char_literal12);

    		DebugLocation(89, 25);
    		PushFollow(Follow._expressions_in_arrayCall509);
    		expressions13=expressions();
    		PopFollow();

    		stream_expressions.Add(expressions13.Tree);
    		DebugLocation(89, 36);
    		char_literal14=(IToken)Match(input,63,Follow._63_in_arrayCall510);  
    		stream_63.Add(char_literal14);



    		{
    		// AST REWRITE
    		// elements: expressions, VARIABLE
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 89:40: -> ^( ARR_CALL VARIABLE expressions )
    		{
    			DebugLocation(89, 43);
    			// Lang2.g:89:43: ^( ARR_CALL VARIABLE expressions )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(89, 45);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARR_CALL, "ARR_CALL"), root_1);

    			DebugLocation(89, 54);
    			adaptor.AddChild(root_1, stream_VARIABLE.NextNode());
    			DebugLocation(89, 63);
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
        }
     	DebugLocation(90, 3);
    	} finally { DebugExitRule(GrammarFileName, "arrayCall"); }
    	return retval;

    }
    // $ANTLR end "arrayCall"

    public class boolOperator_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_boolOperator() {}
    protected virtual void Leave_boolOperator() {}

    // $ANTLR start "boolOperator"
    // Lang2.g:117:1: boolOperator : ( MORE | LESS | EQUAL | LESS_OR_EQUAL | GREATER_OR_EQUAL );
    [GrammarRule("boolOperator")]
    private Lang2Parser.boolOperator_return boolOperator()
    {

        Lang2Parser.boolOperator_return retval = new Lang2Parser.boolOperator_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken set15=null;

        object set15_tree=null;

    	try { DebugEnterRule(GrammarFileName, "boolOperator");
    	DebugLocation(117, 3);
    	try
    	{
    		// Lang2.g:117:13: ( MORE | LESS | EQUAL | LESS_OR_EQUAL | GREATER_OR_EQUAL )
    		DebugEnterAlt(1);
    		// Lang2.g:
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(117, 13);
    		set15=(IToken)input.LT(1);
    		if ((input.LA(1)>=LESS && input.LA(1)<=MORE))
    		{
    			input.Consume();
    			adaptor.AddChild(root_0, (object)adaptor.Create(set15));
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
     	DebugLocation(118, 3);
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
    // Lang2.g:121:1: mathGroup : ( '(' ( expressions )+ ')' | INT | VARIABLE | CHAR | FALSE | TRUE | funcCall );
    [GrammarRule("mathGroup")]
    private Lang2Parser.mathGroup_return mathGroup()
    {

        Lang2Parser.mathGroup_return retval = new Lang2Parser.mathGroup_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken char_literal16=null;
        IToken char_literal18=null;
        IToken INT19=null;
        IToken VARIABLE20=null;
        IToken CHAR21=null;
        IToken FALSE22=null;
        IToken TRUE23=null;
        Lang2Parser.expressions_return expressions17 = default(Lang2Parser.expressions_return);
        Lang2Parser.funcCall_return funcCall24 = default(Lang2Parser.funcCall_return);

        object char_literal16_tree=null;
        object char_literal18_tree=null;
        object INT19_tree=null;
        object VARIABLE20_tree=null;
        object CHAR21_tree=null;
        object FALSE22_tree=null;
        object TRUE23_tree=null;

    	try { DebugEnterRule(GrammarFileName, "mathGroup");
    	DebugLocation(121, 2);
    	try
    	{
    		// Lang2.g:121:11: ( '(' ( expressions )+ ')' | INT | VARIABLE | CHAR | FALSE | TRUE | funcCall )
    		int alt2=7;
    		try { DebugEnterDecision(2, decisionCanBacktrack[2]);
    		try
    		{
    			alt2 = dfa2.Predict(input);
    		}
    		catch (NoViableAltException nvae)
    		{
    			DebugRecognitionException(nvae);
    			throw;
    		}
    		} finally { DebugExitDecision(2); }
    		switch (alt2)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Lang2.g:121:13: '(' ( expressions )+ ')'
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(121, 16);
    			char_literal16=(IToken)Match(input,64,Follow._64_in_mathGroup660); 
    			DebugLocation(121, 17);
    			// Lang2.g:121:17: ( expressions )+
    			int cnt1=0;
    			try { DebugEnterSubRule(1);
    			while (true)
    			{
    				int alt1=2;
    				try { DebugEnterDecision(1, decisionCanBacktrack[1]);
    				int LA1_0 = input.LA(1);

    				if (((LA1_0>=CHAR && LA1_0<=TRUE)||LA1_0==VARIABLE||LA1_0==64))
    				{
    					alt1=1;
    				}


    				} finally { DebugExitDecision(1); }
    				switch (alt1)
    				{
    				case 1:
    					DebugEnterAlt(1);
    					// Lang2.g:121:17: expressions
    					{
    					DebugLocation(121, 17);
    					PushFollow(Follow._expressions_in_mathGroup662);
    					expressions17=expressions();
    					PopFollow();

    					adaptor.AddChild(root_0, expressions17.Tree);

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

    			DebugLocation(121, 32);
    			char_literal18=(IToken)Match(input,65,Follow._65_in_mathGroup664); 

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Lang2.g:122:5: INT
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(122, 5);
    			INT19=(IToken)Match(input,INT,Follow._INT_in_mathGroup671); 
    			INT19_tree = (object)adaptor.Create(INT19);
    			adaptor.AddChild(root_0, INT19_tree);


    			}
    			break;
    		case 3:
    			DebugEnterAlt(3);
    			// Lang2.g:123:5: VARIABLE
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(123, 5);
    			VARIABLE20=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_mathGroup677); 
    			VARIABLE20_tree = (object)adaptor.Create(VARIABLE20);
    			adaptor.AddChild(root_0, VARIABLE20_tree);


    			}
    			break;
    		case 4:
    			DebugEnterAlt(4);
    			// Lang2.g:124:5: CHAR
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(124, 5);
    			CHAR21=(IToken)Match(input,CHAR,Follow._CHAR_in_mathGroup683); 
    			CHAR21_tree = (object)adaptor.Create(CHAR21);
    			adaptor.AddChild(root_0, CHAR21_tree);


    			}
    			break;
    		case 5:
    			DebugEnterAlt(5);
    			// Lang2.g:125:5: FALSE
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(125, 5);
    			FALSE22=(IToken)Match(input,FALSE,Follow._FALSE_in_mathGroup689); 
    			FALSE22_tree = (object)adaptor.Create(FALSE22);
    			adaptor.AddChild(root_0, FALSE22_tree);


    			}
    			break;
    		case 6:
    			DebugEnterAlt(6);
    			// Lang2.g:125:13: TRUE
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(125, 13);
    			TRUE23=(IToken)Match(input,TRUE,Follow._TRUE_in_mathGroup693); 
    			TRUE23_tree = (object)adaptor.Create(TRUE23);
    			adaptor.AddChild(root_0, TRUE23_tree);


    			}
    			break;
    		case 7:
    			DebugEnterAlt(7);
    			// Lang2.g:126:5: funcCall
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(126, 5);
    			PushFollow(Follow._funcCall_in_mathGroup699);
    			funcCall24=funcCall();
    			PopFollow();

    			adaptor.AddChild(root_0, funcCall24.Tree);

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
     	DebugLocation(127, 2);
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
    // Lang2.g:130:1: boolMult : mathGroup ( BOOL_MULT mathGroup )* ;
    [GrammarRule("boolMult")]
    private Lang2Parser.boolMult_return boolMult()
    {

        Lang2Parser.boolMult_return retval = new Lang2Parser.boolMult_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken BOOL_MULT26=null;
        Lang2Parser.mathGroup_return mathGroup25 = default(Lang2Parser.mathGroup_return);
        Lang2Parser.mathGroup_return mathGroup27 = default(Lang2Parser.mathGroup_return);

        object BOOL_MULT26_tree=null;

    	try { DebugEnterRule(GrammarFileName, "boolMult");
    	DebugLocation(130, 3);
    	try
    	{
    		// Lang2.g:130:10: ( mathGroup ( BOOL_MULT mathGroup )* )
    		DebugEnterAlt(1);
    		// Lang2.g:130:12: mathGroup ( BOOL_MULT mathGroup )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(130, 12);
    		PushFollow(Follow._mathGroup_in_boolMult711);
    		mathGroup25=mathGroup();
    		PopFollow();

    		adaptor.AddChild(root_0, mathGroup25.Tree);
    		DebugLocation(130, 21);
    		// Lang2.g:130:21: ( BOOL_MULT mathGroup )*
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
    				// Lang2.g:130:22: BOOL_MULT mathGroup
    				{
    				DebugLocation(130, 31);
    				BOOL_MULT26=(IToken)Match(input,BOOL_MULT,Follow._BOOL_MULT_in_boolMult713); 
    				BOOL_MULT26_tree = (object)adaptor.Create(BOOL_MULT26);
    				root_0 = (object)adaptor.BecomeRoot(BOOL_MULT26_tree, root_0);

    				DebugLocation(130, 33);
    				PushFollow(Follow._mathGroup_in_boolMult716);
    				mathGroup27=mathGroup();
    				PopFollow();

    				adaptor.AddChild(root_0, mathGroup27.Tree);

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
     	DebugLocation(131, 3);
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
    // Lang2.g:133:1: boolAdd : boolMult ( BOOL_ADD boolMult )* ;
    [GrammarRule("boolAdd")]
    private Lang2Parser.boolAdd_return boolAdd()
    {

        Lang2Parser.boolAdd_return retval = new Lang2Parser.boolAdd_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken BOOL_ADD29=null;
        Lang2Parser.boolMult_return boolMult28 = default(Lang2Parser.boolMult_return);
        Lang2Parser.boolMult_return boolMult30 = default(Lang2Parser.boolMult_return);

        object BOOL_ADD29_tree=null;

    	try { DebugEnterRule(GrammarFileName, "boolAdd");
    	DebugLocation(133, 2);
    	try
    	{
    		// Lang2.g:133:9: ( boolMult ( BOOL_ADD boolMult )* )
    		DebugEnterAlt(1);
    		// Lang2.g:133:11: boolMult ( BOOL_ADD boolMult )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(133, 11);
    		PushFollow(Follow._boolMult_in_boolAdd730);
    		boolMult28=boolMult();
    		PopFollow();

    		adaptor.AddChild(root_0, boolMult28.Tree);
    		DebugLocation(133, 19);
    		// Lang2.g:133:19: ( BOOL_ADD boolMult )*
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
    				// Lang2.g:133:20: BOOL_ADD boolMult
    				{
    				DebugLocation(133, 28);
    				BOOL_ADD29=(IToken)Match(input,BOOL_ADD,Follow._BOOL_ADD_in_boolAdd732); 
    				BOOL_ADD29_tree = (object)adaptor.Create(BOOL_ADD29);
    				root_0 = (object)adaptor.BecomeRoot(BOOL_ADD29_tree, root_0);

    				DebugLocation(133, 30);
    				PushFollow(Follow._boolMult_in_boolAdd735);
    				boolMult30=boolMult();
    				PopFollow();

    				adaptor.AddChild(root_0, boolMult30.Tree);

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
     	DebugLocation(134, 2);
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
    // Lang2.g:136:1: boolElse : boolAdd ( boolOperator boolAdd )* ;
    [GrammarRule("boolElse")]
    private Lang2Parser.boolElse_return boolElse()
    {

        Lang2Parser.boolElse_return retval = new Lang2Parser.boolElse_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.boolAdd_return boolAdd31 = default(Lang2Parser.boolAdd_return);
        Lang2Parser.boolOperator_return boolOperator32 = default(Lang2Parser.boolOperator_return);
        Lang2Parser.boolAdd_return boolAdd33 = default(Lang2Parser.boolAdd_return);


    	try { DebugEnterRule(GrammarFileName, "boolElse");
    	DebugLocation(136, 3);
    	try
    	{
    		// Lang2.g:136:10: ( boolAdd ( boolOperator boolAdd )* )
    		DebugEnterAlt(1);
    		// Lang2.g:136:12: boolAdd ( boolOperator boolAdd )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(136, 12);
    		PushFollow(Follow._boolAdd_in_boolElse748);
    		boolAdd31=boolAdd();
    		PopFollow();

    		adaptor.AddChild(root_0, boolAdd31.Tree);
    		DebugLocation(136, 19);
    		// Lang2.g:136:19: ( boolOperator boolAdd )*
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
    				// Lang2.g:136:20: boolOperator boolAdd
    				{
    				DebugLocation(136, 32);
    				PushFollow(Follow._boolOperator_in_boolElse750);
    				boolOperator32=boolOperator();
    				PopFollow();

    				root_0 = (object)adaptor.BecomeRoot(boolOperator32.Tree, root_0);
    				DebugLocation(136, 34);
    				PushFollow(Follow._boolAdd_in_boolElse753);
    				boolAdd33=boolAdd();
    				PopFollow();

    				adaptor.AddChild(root_0, boolAdd33.Tree);

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
     	DebugLocation(137, 3);
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
    // Lang2.g:139:1: boolNegative : boolElse ( NOT boolElse )* ;
    [GrammarRule("boolNegative")]
    private Lang2Parser.boolNegative_return boolNegative()
    {

        Lang2Parser.boolNegative_return retval = new Lang2Parser.boolNegative_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken NOT35=null;
        Lang2Parser.boolElse_return boolElse34 = default(Lang2Parser.boolElse_return);
        Lang2Parser.boolElse_return boolElse36 = default(Lang2Parser.boolElse_return);

        object NOT35_tree=null;

    	try { DebugEnterRule(GrammarFileName, "boolNegative");
    	DebugLocation(139, 3);
    	try
    	{
    		// Lang2.g:139:14: ( boolElse ( NOT boolElse )* )
    		DebugEnterAlt(1);
    		// Lang2.g:139:16: boolElse ( NOT boolElse )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(139, 16);
    		PushFollow(Follow._boolElse_in_boolNegative767);
    		boolElse34=boolElse();
    		PopFollow();

    		adaptor.AddChild(root_0, boolElse34.Tree);
    		DebugLocation(139, 25);
    		// Lang2.g:139:25: ( NOT boolElse )*
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
    				// Lang2.g:139:26: NOT boolElse
    				{
    				DebugLocation(139, 29);
    				NOT35=(IToken)Match(input,NOT,Follow._NOT_in_boolNegative770); 
    				NOT35_tree = (object)adaptor.Create(NOT35);
    				root_0 = (object)adaptor.BecomeRoot(NOT35_tree, root_0);

    				DebugLocation(139, 31);
    				PushFollow(Follow._boolElse_in_boolNegative773);
    				boolElse36=boolElse();
    				PopFollow();

    				adaptor.AddChild(root_0, boolElse36.Tree);

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
     	DebugLocation(140, 3);
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
    // Lang2.g:142:1: useDiv : boolNegative ( ( DIV | MOD ) '(' boolNegative ')' )* ;
    [GrammarRule("useDiv")]
    private Lang2Parser.useDiv_return useDiv()
    {

        Lang2Parser.useDiv_return retval = new Lang2Parser.useDiv_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken set38=null;
        IToken char_literal39=null;
        IToken char_literal41=null;
        Lang2Parser.boolNegative_return boolNegative37 = default(Lang2Parser.boolNegative_return);
        Lang2Parser.boolNegative_return boolNegative40 = default(Lang2Parser.boolNegative_return);

        object set38_tree=null;
        object char_literal39_tree=null;
        object char_literal41_tree=null;

    	try { DebugEnterRule(GrammarFileName, "useDiv");
    	DebugLocation(142, 2);
    	try
    	{
    		// Lang2.g:142:8: ( boolNegative ( ( DIV | MOD ) '(' boolNegative ')' )* )
    		DebugEnterAlt(1);
    		// Lang2.g:142:10: boolNegative ( ( DIV | MOD ) '(' boolNegative ')' )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(142, 10);
    		PushFollow(Follow._boolNegative_in_useDiv787);
    		boolNegative37=boolNegative();
    		PopFollow();

    		adaptor.AddChild(root_0, boolNegative37.Tree);
    		DebugLocation(142, 22);
    		// Lang2.g:142:22: ( ( DIV | MOD ) '(' boolNegative ')' )*
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
    				// Lang2.g:142:23: ( DIV | MOD ) '(' boolNegative ')'
    				{
    				DebugLocation(142, 23);
    				set38=(IToken)input.LT(1);
    				set38=(IToken)input.LT(1);
    				if ((input.LA(1)>=DIV && input.LA(1)<=MOD))
    				{
    					input.Consume();
    					root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set38), root_0);
    					state.errorRecovery=false;
    				}
    				else
    				{
    					MismatchedSetException mse = new MismatchedSetException(null,input);
    					DebugRecognitionException(mse);
    					throw mse;
    				}

    				DebugLocation(142, 37);
    				char_literal39=(IToken)Match(input,64,Follow._64_in_useDiv796); 
    				DebugLocation(142, 39);
    				PushFollow(Follow._boolNegative_in_useDiv799);
    				boolNegative40=boolNegative();
    				PopFollow();

    				adaptor.AddChild(root_0, boolNegative40.Tree);
    				DebugLocation(142, 55);
    				char_literal41=(IToken)Match(input,65,Follow._65_in_useDiv801); 

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
     	DebugLocation(143, 2);
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
    // Lang2.g:145:1: mathMult : useDiv ( ( MULT | DIVIDE ) useDiv )* ;
    [GrammarRule("mathMult")]
    private Lang2Parser.mathMult_return mathMult()
    {

        Lang2Parser.mathMult_return retval = new Lang2Parser.mathMult_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken set43=null;
        Lang2Parser.useDiv_return useDiv42 = default(Lang2Parser.useDiv_return);
        Lang2Parser.useDiv_return useDiv44 = default(Lang2Parser.useDiv_return);

        object set43_tree=null;

    	try { DebugEnterRule(GrammarFileName, "mathMult");
    	DebugLocation(145, 1);
    	try
    	{
    		// Lang2.g:146:2: ( useDiv ( ( MULT | DIVIDE ) useDiv )* )
    		DebugEnterAlt(1);
    		// Lang2.g:146:4: useDiv ( ( MULT | DIVIDE ) useDiv )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(146, 4);
    		PushFollow(Follow._useDiv_in_mathMult818);
    		useDiv42=useDiv();
    		PopFollow();

    		adaptor.AddChild(root_0, useDiv42.Tree);
    		DebugLocation(146, 10);
    		// Lang2.g:146:10: ( ( MULT | DIVIDE ) useDiv )*
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
    				// Lang2.g:146:11: ( MULT | DIVIDE ) useDiv
    				{
    				DebugLocation(146, 11);
    				set43=(IToken)input.LT(1);
    				set43=(IToken)input.LT(1);
    				if ((input.LA(1)>=MULT && input.LA(1)<=DIVIDE))
    				{
    					input.Consume();
    					root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set43), root_0);
    					state.errorRecovery=false;
    				}
    				else
    				{
    					MismatchedSetException mse = new MismatchedSetException(null,input);
    					DebugRecognitionException(mse);
    					throw mse;
    				}

    				DebugLocation(146, 25);
    				PushFollow(Follow._useDiv_in_mathMult826);
    				useDiv44=useDiv();
    				PopFollow();

    				adaptor.AddChild(root_0, useDiv44.Tree);

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
     	DebugLocation(147, 1);
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
    // Lang2.g:149:1: mathAdd : mathMult ( ( ADD | REM ) mathMult )* ;
    [GrammarRule("mathAdd")]
    private Lang2Parser.mathAdd_return mathAdd()
    {

        Lang2Parser.mathAdd_return retval = new Lang2Parser.mathAdd_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken set46=null;
        Lang2Parser.mathMult_return mathMult45 = default(Lang2Parser.mathMult_return);
        Lang2Parser.mathMult_return mathMult47 = default(Lang2Parser.mathMult_return);

        object set46_tree=null;

    	try { DebugEnterRule(GrammarFileName, "mathAdd");
    	DebugLocation(149, 1);
    	try
    	{
    		// Lang2.g:149:9: ( mathMult ( ( ADD | REM ) mathMult )* )
    		DebugEnterAlt(1);
    		// Lang2.g:149:11: mathMult ( ( ADD | REM ) mathMult )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(149, 11);
    		PushFollow(Follow._mathMult_in_mathAdd839);
    		mathMult45=mathMult();
    		PopFollow();

    		adaptor.AddChild(root_0, mathMult45.Tree);
    		DebugLocation(149, 19);
    		// Lang2.g:149:19: ( ( ADD | REM ) mathMult )*
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
    				// Lang2.g:149:20: ( ADD | REM ) mathMult
    				{
    				DebugLocation(149, 20);
    				set46=(IToken)input.LT(1);
    				set46=(IToken)input.LT(1);
    				if ((input.LA(1)>=ADD && input.LA(1)<=REM))
    				{
    					input.Consume();
    					root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set46), root_0);
    					state.errorRecovery=false;
    				}
    				else
    				{
    					MismatchedSetException mse = new MismatchedSetException(null,input);
    					DebugRecognitionException(mse);
    					throw mse;
    				}

    				DebugLocation(149, 30);
    				PushFollow(Follow._mathMult_in_mathAdd847);
    				mathMult47=mathMult();
    				PopFollow();

    				adaptor.AddChild(root_0, mathMult47.Tree);

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
     	DebugLocation(150, 1);
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
    // Lang2.g:152:1: mathExpr : mathAdd ;
    [GrammarRule("mathExpr")]
    private Lang2Parser.mathExpr_return mathExpr()
    {

        Lang2Parser.mathExpr_return retval = new Lang2Parser.mathExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.mathAdd_return mathAdd48 = default(Lang2Parser.mathAdd_return);


    	try { DebugEnterRule(GrammarFileName, "mathExpr");
    	DebugLocation(152, 1);
    	try
    	{
    		// Lang2.g:153:2: ( mathAdd )
    		DebugEnterAlt(1);
    		// Lang2.g:153:4: mathAdd
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(153, 4);
    		PushFollow(Follow._mathAdd_in_mathExpr861);
    		mathAdd48=mathAdd();
    		PopFollow();

    		adaptor.AddChild(root_0, mathAdd48.Tree);

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
     	DebugLocation(154, 1);
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
    // Lang2.g:158:1: bodyOper : ( assExpr OP_END | conditionExpr | loopExpr | funcCall );
    [GrammarRule("bodyOper")]
    private Lang2Parser.bodyOper_return bodyOper()
    {

        Lang2Parser.bodyOper_return retval = new Lang2Parser.bodyOper_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken OP_END50=null;
        Lang2Parser.assExpr_return assExpr49 = default(Lang2Parser.assExpr_return);
        Lang2Parser.conditionExpr_return conditionExpr51 = default(Lang2Parser.conditionExpr_return);
        Lang2Parser.loopExpr_return loopExpr52 = default(Lang2Parser.loopExpr_return);
        Lang2Parser.funcCall_return funcCall53 = default(Lang2Parser.funcCall_return);

        object OP_END50_tree=null;

    	try { DebugEnterRule(GrammarFileName, "bodyOper");
    	DebugLocation(158, 4);
    	try
    	{
    		// Lang2.g:158:10: ( assExpr OP_END | conditionExpr | loopExpr | funcCall )
    		int alt10=4;
    		try { DebugEnterDecision(10, decisionCanBacktrack[10]);
    		switch (input.LA(1))
    		{
    		case VARIABLE:
    			{
    			int LA10_1 = input.LA(2);

    			if ((LA10_1==ASSIGN||LA10_1==61))
    			{
    				alt10=1;
    			}
    			else if ((LA10_1==64))
    			{
    				alt10=4;
    			}
    			else
    			{
    				NoViableAltException nvae = new NoViableAltException("", 10, 1, input);

    				DebugRecognitionException(nvae);
    				throw nvae;
    			}
    			}
    			break;
    		case IF:
    			{
    			alt10=2;
    			}
    			break;
    		case WHILE:
    		case FOR:
    			{
    			alt10=3;
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
    			// Lang2.g:158:12: assExpr OP_END
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(158, 12);
    			PushFollow(Follow._assExpr_in_bodyOper875);
    			assExpr49=assExpr();
    			PopFollow();

    			adaptor.AddChild(root_0, assExpr49.Tree);
    			DebugLocation(158, 26);
    			OP_END50=(IToken)Match(input,OP_END,Follow._OP_END_in_bodyOper877); 

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Lang2.g:159:6: conditionExpr
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(159, 6);
    			PushFollow(Follow._conditionExpr_in_bodyOper885);
    			conditionExpr51=conditionExpr();
    			PopFollow();

    			adaptor.AddChild(root_0, conditionExpr51.Tree);

    			}
    			break;
    		case 3:
    			DebugEnterAlt(3);
    			// Lang2.g:160:6: loopExpr
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(160, 6);
    			PushFollow(Follow._loopExpr_in_bodyOper892);
    			loopExpr52=loopExpr();
    			PopFollow();

    			adaptor.AddChild(root_0, loopExpr52.Tree);

    			}
    			break;
    		case 4:
    			DebugEnterAlt(4);
    			// Lang2.g:161:6: funcCall
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(161, 6);
    			PushFollow(Follow._funcCall_in_bodyOper899);
    			funcCall53=funcCall();
    			PopFollow();

    			adaptor.AddChild(root_0, funcCall53.Tree);

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
     	DebugLocation(162, 4);
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
    // Lang2.g:164:1: expressions : ( mathExpr | arrayCall );
    [GrammarRule("expressions")]
    private Lang2Parser.expressions_return expressions()
    {

        Lang2Parser.expressions_return retval = new Lang2Parser.expressions_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.mathExpr_return mathExpr54 = default(Lang2Parser.mathExpr_return);
        Lang2Parser.arrayCall_return arrayCall55 = default(Lang2Parser.arrayCall_return);


    	try { DebugEnterRule(GrammarFileName, "expressions");
    	DebugLocation(164, 4);
    	try
    	{
    		// Lang2.g:164:13: ( mathExpr | arrayCall )
    		int alt11=2;
    		try { DebugEnterDecision(11, decisionCanBacktrack[11]);
    		int LA11_0 = input.LA(1);

    		if (((LA11_0>=CHAR && LA11_0<=TRUE)||LA11_0==64))
    		{
    			alt11=1;
    		}
    		else if ((LA11_0==VARIABLE))
    		{
    			int LA11_2 = input.LA(2);

    			if ((LA11_2==DO||LA11_2==THEN||(LA11_2>=DIV && LA11_2<=TO)||(LA11_2>=CHAR && LA11_2<=TRUE)||(LA11_2>=BOOL_MULT && LA11_2<=BOOL_ADD)||LA11_2==OP_END||(LA11_2>=VARIABLE && LA11_2<=DIVIDE)||(LA11_2>=LESS && LA11_2<=MORE)||(LA11_2>=62 && LA11_2<=65)))
    			{
    				alt11=1;
    			}
    			else if ((LA11_2==61))
    			{
    				alt11=2;
    			}
    			else
    			{
    				NoViableAltException nvae = new NoViableAltException("", 11, 2, input);

    				DebugRecognitionException(nvae);
    				throw nvae;
    			}
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
    			// Lang2.g:164:15: mathExpr
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(164, 15);
    			PushFollow(Follow._mathExpr_in_expressions912);
    			mathExpr54=mathExpr();
    			PopFollow();

    			adaptor.AddChild(root_0, mathExpr54.Tree);

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Lang2.g:165:6: arrayCall
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(165, 6);
    			PushFollow(Follow._arrayCall_in_expressions919);
    			arrayCall55=arrayCall();
    			PopFollow();

    			adaptor.AddChild(root_0, arrayCall55.Tree);

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
     	DebugLocation(166, 4);
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
    // Lang2.g:167:1: funcCallArgs : VARIABLE ( ',' VARIABLE )* ;
    [GrammarRule("funcCallArgs")]
    private Lang2Parser.funcCallArgs_return funcCallArgs()
    {

        Lang2Parser.funcCallArgs_return retval = new Lang2Parser.funcCallArgs_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken VARIABLE56=null;
        IToken char_literal57=null;
        IToken VARIABLE58=null;

        object VARIABLE56_tree=null;
        object char_literal57_tree=null;
        object VARIABLE58_tree=null;

    	try { DebugEnterRule(GrammarFileName, "funcCallArgs");
    	DebugLocation(167, 4);
    	try
    	{
    		// Lang2.g:167:14: ( VARIABLE ( ',' VARIABLE )* )
    		DebugEnterAlt(1);
    		// Lang2.g:167:17: VARIABLE ( ',' VARIABLE )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(167, 17);
    		VARIABLE56=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_funcCallArgs932); 
    		VARIABLE56_tree = (object)adaptor.Create(VARIABLE56);
    		adaptor.AddChild(root_0, VARIABLE56_tree);

    		DebugLocation(167, 25);
    		// Lang2.g:167:25: ( ',' VARIABLE )*
    		try { DebugEnterSubRule(12);
    		while (true)
    		{
    			int alt12=2;
    			try { DebugEnterDecision(12, decisionCanBacktrack[12]);
    			int LA12_0 = input.LA(1);

    			if ((LA12_0==66))
    			{
    				alt12=1;
    			}


    			} finally { DebugExitDecision(12); }
    			switch ( alt12 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:167:26: ',' VARIABLE
    				{
    				DebugLocation(167, 26);
    				char_literal57=(IToken)Match(input,66,Follow._66_in_funcCallArgs934); 
    				char_literal57_tree = (object)adaptor.Create(char_literal57);
    				adaptor.AddChild(root_0, char_literal57_tree);

    				DebugLocation(167, 30);
    				VARIABLE58=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_funcCallArgs936); 
    				VARIABLE58_tree = (object)adaptor.Create(VARIABLE58);
    				adaptor.AddChild(root_0, VARIABLE58_tree);


    				}
    				break;

    			default:
    				goto loop12;
    			}
    		}

    		loop12:
    			;

    		} finally { DebugExitSubRule(12); }


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
     	DebugLocation(168, 4);
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
    // Lang2.g:169:1: funcCallArgsW : funcCallArgs -> ^( FUNC_CALL_ARGS funcCallArgs ) ;
    [GrammarRule("funcCallArgsW")]
    private Lang2Parser.funcCallArgsW_return funcCallArgsW()
    {

        Lang2Parser.funcCallArgsW_return retval = new Lang2Parser.funcCallArgsW_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.funcCallArgs_return funcCallArgs59 = default(Lang2Parser.funcCallArgs_return);

        RewriteRuleSubtreeStream stream_funcCallArgs=new RewriteRuleSubtreeStream(adaptor,"rule funcCallArgs");
    	try { DebugEnterRule(GrammarFileName, "funcCallArgsW");
    	DebugLocation(169, 4);
    	try
    	{
    		// Lang2.g:169:15: ( funcCallArgs -> ^( FUNC_CALL_ARGS funcCallArgs ) )
    		DebugEnterAlt(1);
    		// Lang2.g:169:17: funcCallArgs
    		{
    		DebugLocation(169, 17);
    		PushFollow(Follow._funcCallArgs_in_funcCallArgsW951);
    		funcCallArgs59=funcCallArgs();
    		PopFollow();

    		stream_funcCallArgs.Add(funcCallArgs59.Tree);


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
    		// 169:30: -> ^( FUNC_CALL_ARGS funcCallArgs )
    		{
    			DebugLocation(169, 33);
    			// Lang2.g:169:33: ^( FUNC_CALL_ARGS funcCallArgs )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(169, 35);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_CALL_ARGS, "FUNC_CALL_ARGS"), root_1);

    			DebugLocation(169, 50);
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
     	DebugLocation(170, 4);
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
    // Lang2.g:172:1: funcCall : VARIABLE '(' ( funcCallArgsW )? ')' OP_END -> ^( FUNC_CALL VARIABLE ( funcCallArgsW )? ) ;
    [GrammarRule("funcCall")]
    private Lang2Parser.funcCall_return funcCall()
    {

        Lang2Parser.funcCall_return retval = new Lang2Parser.funcCall_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken VARIABLE60=null;
        IToken char_literal61=null;
        IToken char_literal63=null;
        IToken OP_END64=null;
        Lang2Parser.funcCallArgsW_return funcCallArgsW62 = default(Lang2Parser.funcCallArgsW_return);

        object VARIABLE60_tree=null;
        object char_literal61_tree=null;
        object char_literal63_tree=null;
        object OP_END64_tree=null;
        RewriteRuleITokenStream stream_VARIABLE=new RewriteRuleITokenStream(adaptor,"token VARIABLE");
        RewriteRuleITokenStream stream_OP_END=new RewriteRuleITokenStream(adaptor,"token OP_END");
        RewriteRuleITokenStream stream_64=new RewriteRuleITokenStream(adaptor,"token 64");
        RewriteRuleITokenStream stream_65=new RewriteRuleITokenStream(adaptor,"token 65");
        RewriteRuleSubtreeStream stream_funcCallArgsW=new RewriteRuleSubtreeStream(adaptor,"rule funcCallArgsW");
    	try { DebugEnterRule(GrammarFileName, "funcCall");
    	DebugLocation(172, 3);
    	try
    	{
    		// Lang2.g:172:10: ( VARIABLE '(' ( funcCallArgsW )? ')' OP_END -> ^( FUNC_CALL VARIABLE ( funcCallArgsW )? ) )
    		DebugEnterAlt(1);
    		// Lang2.g:172:12: VARIABLE '(' ( funcCallArgsW )? ')' OP_END
    		{
    		DebugLocation(172, 12);
    		VARIABLE60=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_funcCall972);  
    		stream_VARIABLE.Add(VARIABLE60);

    		DebugLocation(172, 24);
    		char_literal61=(IToken)Match(input,64,Follow._64_in_funcCall974);  
    		stream_64.Add(char_literal61);

    		DebugLocation(172, 26);
    		// Lang2.g:172:26: ( funcCallArgsW )?
    		int alt13=2;
    		try { DebugEnterSubRule(13);
    		try { DebugEnterDecision(13, decisionCanBacktrack[13]);
    		int LA13_0 = input.LA(1);

    		if ((LA13_0==VARIABLE))
    		{
    			alt13=1;
    		}
    		} finally { DebugExitDecision(13); }
    		switch (alt13)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Lang2.g:172:26: funcCallArgsW
    			{
    			DebugLocation(172, 26);
    			PushFollow(Follow._funcCallArgsW_in_funcCall977);
    			funcCallArgsW62=funcCallArgsW();
    			PopFollow();

    			stream_funcCallArgsW.Add(funcCallArgsW62.Tree);

    			}
    			break;

    		}
    		} finally { DebugExitSubRule(13); }

    		DebugLocation(172, 44);
    		char_literal63=(IToken)Match(input,65,Follow._65_in_funcCall980);  
    		stream_65.Add(char_literal63);

    		DebugLocation(172, 46);
    		OP_END64=(IToken)Match(input,OP_END,Follow._OP_END_in_funcCall983);  
    		stream_OP_END.Add(OP_END64);



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
    		// 172:53: -> ^( FUNC_CALL VARIABLE ( funcCallArgsW )? )
    		{
    			DebugLocation(172, 56);
    			// Lang2.g:172:56: ^( FUNC_CALL VARIABLE ( funcCallArgsW )? )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(172, 58);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_CALL, "FUNC_CALL"), root_1);

    			DebugLocation(172, 68);
    			adaptor.AddChild(root_1, stream_VARIABLE.NextNode());
    			DebugLocation(172, 77);
    			// Lang2.g:172:77: ( funcCallArgsW )?
    			if ( stream_funcCallArgsW.HasNext )
    			{
    				DebugLocation(172, 77);
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
     	DebugLocation(173, 3);
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
    // Lang2.g:175:1: argDeclExpr : '(' argDeclMany ')' -> ^( FUNC_PROC_ARGS argDeclMany ) ;
    [GrammarRule("argDeclExpr")]
    private Lang2Parser.argDeclExpr_return argDeclExpr()
    {

        Lang2Parser.argDeclExpr_return retval = new Lang2Parser.argDeclExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken char_literal65=null;
        IToken char_literal67=null;
        Lang2Parser.argDeclMany_return argDeclMany66 = default(Lang2Parser.argDeclMany_return);

        object char_literal65_tree=null;
        object char_literal67_tree=null;
        RewriteRuleITokenStream stream_64=new RewriteRuleITokenStream(adaptor,"token 64");
        RewriteRuleITokenStream stream_65=new RewriteRuleITokenStream(adaptor,"token 65");
        RewriteRuleSubtreeStream stream_argDeclMany=new RewriteRuleSubtreeStream(adaptor,"rule argDeclMany");
    	try { DebugEnterRule(GrammarFileName, "argDeclExpr");
    	DebugLocation(175, 3);
    	try
    	{
    		// Lang2.g:175:13: ( '(' argDeclMany ')' -> ^( FUNC_PROC_ARGS argDeclMany ) )
    		DebugEnterAlt(1);
    		// Lang2.g:175:15: '(' argDeclMany ')'
    		{
    		DebugLocation(175, 18);
    		char_literal65=(IToken)Match(input,64,Follow._64_in_argDeclExpr1007);  
    		stream_64.Add(char_literal65);

    		DebugLocation(175, 20);
    		PushFollow(Follow._argDeclMany_in_argDeclExpr1010);
    		argDeclMany66=argDeclMany();
    		PopFollow();

    		stream_argDeclMany.Add(argDeclMany66.Tree);
    		DebugLocation(175, 34);
    		char_literal67=(IToken)Match(input,65,Follow._65_in_argDeclExpr1011);  
    		stream_65.Add(char_literal67);



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
    		// 175:36: -> ^( FUNC_PROC_ARGS argDeclMany )
    		{
    			DebugLocation(175, 39);
    			// Lang2.g:175:39: ^( FUNC_PROC_ARGS argDeclMany )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(175, 41);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_PROC_ARGS, "FUNC_PROC_ARGS"), root_1);

    			DebugLocation(175, 56);
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
     	DebugLocation(176, 3);
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
    // Lang2.g:178:1: retTypeExpr : ( T_INT | T_BOOL | T_CHAR | arrayDecl ) ;
    [GrammarRule("retTypeExpr")]
    private Lang2Parser.retTypeExpr_return retTypeExpr()
    {

        Lang2Parser.retTypeExpr_return retval = new Lang2Parser.retTypeExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken T_INT68=null;
        IToken T_BOOL69=null;
        IToken T_CHAR70=null;
        Lang2Parser.arrayDecl_return arrayDecl71 = default(Lang2Parser.arrayDecl_return);

        object T_INT68_tree=null;
        object T_BOOL69_tree=null;
        object T_CHAR70_tree=null;

    	try { DebugEnterRule(GrammarFileName, "retTypeExpr");
    	DebugLocation(178, 3);
    	try
    	{
    		// Lang2.g:178:13: ( ( T_INT | T_BOOL | T_CHAR | arrayDecl ) )
    		DebugEnterAlt(1);
    		// Lang2.g:178:15: ( T_INT | T_BOOL | T_CHAR | arrayDecl )
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(178, 15);
    		// Lang2.g:178:15: ( T_INT | T_BOOL | T_CHAR | arrayDecl )
    		int alt14=4;
    		try { DebugEnterSubRule(14);
    		try { DebugEnterDecision(14, decisionCanBacktrack[14]);
    		switch (input.LA(1))
    		{
    		case T_INT:
    			{
    			alt14=1;
    			}
    			break;
    		case T_BOOL:
    			{
    			alt14=2;
    			}
    			break;
    		case T_CHAR:
    			{
    			alt14=3;
    			}
    			break;
    		case ARRAY:
    			{
    			alt14=4;
    			}
    			break;
    		default:
    			{
    				NoViableAltException nvae = new NoViableAltException("", 14, 0, input);

    				DebugRecognitionException(nvae);
    				throw nvae;
    			}
    		}

    		} finally { DebugExitDecision(14); }
    		switch (alt14)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Lang2.g:178:16: T_INT
    			{
    			DebugLocation(178, 16);
    			T_INT68=(IToken)Match(input,T_INT,Follow._T_INT_in_retTypeExpr1033); 
    			T_INT68_tree = (object)adaptor.Create(T_INT68);
    			adaptor.AddChild(root_0, T_INT68_tree);


    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Lang2.g:178:22: T_BOOL
    			{
    			DebugLocation(178, 22);
    			T_BOOL69=(IToken)Match(input,T_BOOL,Follow._T_BOOL_in_retTypeExpr1035); 
    			T_BOOL69_tree = (object)adaptor.Create(T_BOOL69);
    			adaptor.AddChild(root_0, T_BOOL69_tree);


    			}
    			break;
    		case 3:
    			DebugEnterAlt(3);
    			// Lang2.g:178:29: T_CHAR
    			{
    			DebugLocation(178, 29);
    			T_CHAR70=(IToken)Match(input,T_CHAR,Follow._T_CHAR_in_retTypeExpr1037); 
    			T_CHAR70_tree = (object)adaptor.Create(T_CHAR70);
    			adaptor.AddChild(root_0, T_CHAR70_tree);


    			}
    			break;
    		case 4:
    			DebugEnterAlt(4);
    			// Lang2.g:178:36: arrayDecl
    			{
    			DebugLocation(178, 36);
    			PushFollow(Follow._arrayDecl_in_retTypeExpr1039);
    			arrayDecl71=arrayDecl();
    			PopFollow();

    			adaptor.AddChild(root_0, arrayDecl71.Tree);

    			}
    			break;

    		}
    		} finally { DebugExitSubRule(14); }


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
     	DebugLocation(179, 3);
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
    // Lang2.g:181:1: retTypeExprWrap : retTypeExpr -> ^( FUNC_PROC_RET_TYPE retTypeExpr ) ;
    [GrammarRule("retTypeExprWrap")]
    private Lang2Parser.retTypeExprWrap_return retTypeExprWrap()
    {

        Lang2Parser.retTypeExprWrap_return retval = new Lang2Parser.retTypeExprWrap_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.retTypeExpr_return retTypeExpr72 = default(Lang2Parser.retTypeExpr_return);

        RewriteRuleSubtreeStream stream_retTypeExpr=new RewriteRuleSubtreeStream(adaptor,"rule retTypeExpr");
    	try { DebugEnterRule(GrammarFileName, "retTypeExprWrap");
    	DebugLocation(181, 4);
    	try
    	{
    		// Lang2.g:181:17: ( retTypeExpr -> ^( FUNC_PROC_RET_TYPE retTypeExpr ) )
    		DebugEnterAlt(1);
    		// Lang2.g:181:19: retTypeExpr
    		{
    		DebugLocation(181, 19);
    		PushFollow(Follow._retTypeExpr_in_retTypeExprWrap1052);
    		retTypeExpr72=retTypeExpr();
    		PopFollow();

    		stream_retTypeExpr.Add(retTypeExpr72.Tree);


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
    		// 181:31: -> ^( FUNC_PROC_RET_TYPE retTypeExpr )
    		{
    			DebugLocation(181, 34);
    			// Lang2.g:181:34: ^( FUNC_PROC_RET_TYPE retTypeExpr )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(181, 36);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_PROC_RET_TYPE, "FUNC_PROC_RET_TYPE"), root_1);

    			DebugLocation(181, 55);
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
     	DebugLocation(182, 4);
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
    // Lang2.g:184:1: funcDeclare : FUNCTION VARIABLE argDeclExpr ':' retTypeExprWrap OP_END bodyExpr -> ^( FUNC_DECL VARIABLE argDeclExpr retTypeExprWrap bodyExpr ) ;
    [GrammarRule("funcDeclare")]
    private Lang2Parser.funcDeclare_return funcDeclare()
    {

        Lang2Parser.funcDeclare_return retval = new Lang2Parser.funcDeclare_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken FUNCTION73=null;
        IToken VARIABLE74=null;
        IToken char_literal76=null;
        IToken OP_END78=null;
        Lang2Parser.argDeclExpr_return argDeclExpr75 = default(Lang2Parser.argDeclExpr_return);
        Lang2Parser.retTypeExprWrap_return retTypeExprWrap77 = default(Lang2Parser.retTypeExprWrap_return);
        Lang2Parser.bodyExpr_return bodyExpr79 = default(Lang2Parser.bodyExpr_return);

        object FUNCTION73_tree=null;
        object VARIABLE74_tree=null;
        object char_literal76_tree=null;
        object OP_END78_tree=null;
        RewriteRuleITokenStream stream_67=new RewriteRuleITokenStream(adaptor,"token 67");
        RewriteRuleITokenStream stream_FUNCTION=new RewriteRuleITokenStream(adaptor,"token FUNCTION");
        RewriteRuleITokenStream stream_VARIABLE=new RewriteRuleITokenStream(adaptor,"token VARIABLE");
        RewriteRuleITokenStream stream_OP_END=new RewriteRuleITokenStream(adaptor,"token OP_END");
        RewriteRuleSubtreeStream stream_argDeclExpr=new RewriteRuleSubtreeStream(adaptor,"rule argDeclExpr");
        RewriteRuleSubtreeStream stream_bodyExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodyExpr");
        RewriteRuleSubtreeStream stream_retTypeExprWrap=new RewriteRuleSubtreeStream(adaptor,"rule retTypeExprWrap");
    	try { DebugEnterRule(GrammarFileName, "funcDeclare");
    	DebugLocation(184, 3);
    	try
    	{
    		// Lang2.g:184:12: ( FUNCTION VARIABLE argDeclExpr ':' retTypeExprWrap OP_END bodyExpr -> ^( FUNC_DECL VARIABLE argDeclExpr retTypeExprWrap bodyExpr ) )
    		DebugEnterAlt(1);
    		// Lang2.g:184:14: FUNCTION VARIABLE argDeclExpr ':' retTypeExprWrap OP_END bodyExpr
    		{
    		DebugLocation(184, 14);
    		FUNCTION73=(IToken)Match(input,FUNCTION,Follow._FUNCTION_in_funcDeclare1072);  
    		stream_FUNCTION.Add(FUNCTION73);

    		DebugLocation(184, 23);
    		VARIABLE74=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_funcDeclare1074);  
    		stream_VARIABLE.Add(VARIABLE74);

    		DebugLocation(184, 32);
    		PushFollow(Follow._argDeclExpr_in_funcDeclare1076);
    		argDeclExpr75=argDeclExpr();
    		PopFollow();

    		stream_argDeclExpr.Add(argDeclExpr75.Tree);
    		DebugLocation(184, 43);
    		char_literal76=(IToken)Match(input,67,Follow._67_in_funcDeclare1077);  
    		stream_67.Add(char_literal76);

    		DebugLocation(184, 47);
    		PushFollow(Follow._retTypeExprWrap_in_funcDeclare1079);
    		retTypeExprWrap77=retTypeExprWrap();
    		PopFollow();

    		stream_retTypeExprWrap.Add(retTypeExprWrap77.Tree);
    		DebugLocation(184, 69);
    		OP_END78=(IToken)Match(input,OP_END,Follow._OP_END_in_funcDeclare1081);  
    		stream_OP_END.Add(OP_END78);

    		DebugLocation(184, 72);
    		PushFollow(Follow._bodyExpr_in_funcDeclare1085);
    		bodyExpr79=bodyExpr();
    		PopFollow();

    		stream_bodyExpr.Add(bodyExpr79.Tree);


    		{
    		// AST REWRITE
    		// elements: bodyExpr, VARIABLE, retTypeExprWrap, argDeclExpr
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 184:81: -> ^( FUNC_DECL VARIABLE argDeclExpr retTypeExprWrap bodyExpr )
    		{
    			DebugLocation(184, 84);
    			// Lang2.g:184:84: ^( FUNC_DECL VARIABLE argDeclExpr retTypeExprWrap bodyExpr )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(184, 86);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_DECL, "FUNC_DECL"), root_1);

    			DebugLocation(184, 96);
    			adaptor.AddChild(root_1, stream_VARIABLE.NextNode());
    			DebugLocation(184, 105);
    			adaptor.AddChild(root_1, stream_argDeclExpr.NextTree());
    			DebugLocation(184, 117);
    			adaptor.AddChild(root_1, stream_retTypeExprWrap.NextTree());
    			DebugLocation(184, 133);
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
     	DebugLocation(185, 3);
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
    // Lang2.g:187:1: procedureDeclare : PROCEDURE VARIABLE argDeclExpr OP_END bodyExpr -> ^( PROC_DECL VARIABLE argDeclExpr bodyExpr ) ;
    [GrammarRule("procedureDeclare")]
    private Lang2Parser.procedureDeclare_return procedureDeclare()
    {

        Lang2Parser.procedureDeclare_return retval = new Lang2Parser.procedureDeclare_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken PROCEDURE80=null;
        IToken VARIABLE81=null;
        IToken OP_END83=null;
        Lang2Parser.argDeclExpr_return argDeclExpr82 = default(Lang2Parser.argDeclExpr_return);
        Lang2Parser.bodyExpr_return bodyExpr84 = default(Lang2Parser.bodyExpr_return);

        object PROCEDURE80_tree=null;
        object VARIABLE81_tree=null;
        object OP_END83_tree=null;
        RewriteRuleITokenStream stream_VARIABLE=new RewriteRuleITokenStream(adaptor,"token VARIABLE");
        RewriteRuleITokenStream stream_OP_END=new RewriteRuleITokenStream(adaptor,"token OP_END");
        RewriteRuleITokenStream stream_PROCEDURE=new RewriteRuleITokenStream(adaptor,"token PROCEDURE");
        RewriteRuleSubtreeStream stream_argDeclExpr=new RewriteRuleSubtreeStream(adaptor,"rule argDeclExpr");
        RewriteRuleSubtreeStream stream_bodyExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodyExpr");
    	try { DebugEnterRule(GrammarFileName, "procedureDeclare");
    	DebugLocation(187, 4);
    	try
    	{
    		// Lang2.g:187:17: ( PROCEDURE VARIABLE argDeclExpr OP_END bodyExpr -> ^( PROC_DECL VARIABLE argDeclExpr bodyExpr ) )
    		DebugEnterAlt(1);
    		// Lang2.g:187:19: PROCEDURE VARIABLE argDeclExpr OP_END bodyExpr
    		{
    		DebugLocation(187, 19);
    		PROCEDURE80=(IToken)Match(input,PROCEDURE,Follow._PROCEDURE_in_procedureDeclare1110);  
    		stream_PROCEDURE.Add(PROCEDURE80);

    		DebugLocation(187, 29);
    		VARIABLE81=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_procedureDeclare1112);  
    		stream_VARIABLE.Add(VARIABLE81);

    		DebugLocation(187, 38);
    		PushFollow(Follow._argDeclExpr_in_procedureDeclare1114);
    		argDeclExpr82=argDeclExpr();
    		PopFollow();

    		stream_argDeclExpr.Add(argDeclExpr82.Tree);
    		DebugLocation(187, 50);
    		OP_END83=(IToken)Match(input,OP_END,Follow._OP_END_in_procedureDeclare1116);  
    		stream_OP_END.Add(OP_END83);

    		DebugLocation(187, 57);
    		PushFollow(Follow._bodyExpr_in_procedureDeclare1118);
    		bodyExpr84=bodyExpr();
    		PopFollow();

    		stream_bodyExpr.Add(bodyExpr84.Tree);


    		{
    		// AST REWRITE
    		// elements: argDeclExpr, bodyExpr, VARIABLE
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 187:66: -> ^( PROC_DECL VARIABLE argDeclExpr bodyExpr )
    		{
    			DebugLocation(187, 69);
    			// Lang2.g:187:69: ^( PROC_DECL VARIABLE argDeclExpr bodyExpr )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(187, 71);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PROC_DECL, "PROC_DECL"), root_1);

    			DebugLocation(187, 81);
    			adaptor.AddChild(root_1, stream_VARIABLE.NextNode());
    			DebugLocation(187, 90);
    			adaptor.AddChild(root_1, stream_argDeclExpr.NextTree());
    			DebugLocation(187, 102);
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
     	DebugLocation(188, 4);
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
    // Lang2.g:192:1: conditionElseExpr : ELSE bodyExpr -> ^( ELSE bodyExpr ) ;
    [GrammarRule("conditionElseExpr")]
    private Lang2Parser.conditionElseExpr_return conditionElseExpr()
    {

        Lang2Parser.conditionElseExpr_return retval = new Lang2Parser.conditionElseExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken ELSE85=null;
        Lang2Parser.bodyExpr_return bodyExpr86 = default(Lang2Parser.bodyExpr_return);

        object ELSE85_tree=null;
        RewriteRuleITokenStream stream_ELSE=new RewriteRuleITokenStream(adaptor,"token ELSE");
        RewriteRuleSubtreeStream stream_bodyExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodyExpr");
    	try { DebugEnterRule(GrammarFileName, "conditionElseExpr");
    	DebugLocation(192, 5);
    	try
    	{
    		// Lang2.g:192:19: ( ELSE bodyExpr -> ^( ELSE bodyExpr ) )
    		DebugEnterAlt(1);
    		// Lang2.g:192:21: ELSE bodyExpr
    		{
    		DebugLocation(192, 25);
    		ELSE85=(IToken)Match(input,ELSE,Follow._ELSE_in_conditionElseExpr1145);  
    		stream_ELSE.Add(ELSE85);

    		DebugLocation(192, 27);
    		PushFollow(Follow._bodyExpr_in_conditionElseExpr1148);
    		bodyExpr86=bodyExpr();
    		PopFollow();

    		stream_bodyExpr.Add(bodyExpr86.Tree);


    		{
    		// AST REWRITE
    		// elements: bodyExpr, ELSE
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 192:36: -> ^( ELSE bodyExpr )
    		{
    			DebugLocation(192, 39);
    			// Lang2.g:192:39: ^( ELSE bodyExpr )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(192, 41);
    			root_1 = (object)adaptor.BecomeRoot(stream_ELSE.NextNode(), root_1);

    			DebugLocation(192, 46);
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
     	DebugLocation(193, 5);
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
    // Lang2.g:194:1: condExpr : expressions -> ^( CONDITION expressions ) ;
    [GrammarRule("condExpr")]
    private Lang2Parser.condExpr_return condExpr()
    {

        Lang2Parser.condExpr_return retval = new Lang2Parser.condExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.expressions_return expressions87 = default(Lang2Parser.expressions_return);

        RewriteRuleSubtreeStream stream_expressions=new RewriteRuleSubtreeStream(adaptor,"rule expressions");
    	try { DebugEnterRule(GrammarFileName, "condExpr");
    	DebugLocation(194, 3);
    	try
    	{
    		// Lang2.g:194:10: ( expressions -> ^( CONDITION expressions ) )
    		DebugEnterAlt(1);
    		// Lang2.g:194:13: expressions
    		{
    		DebugLocation(194, 13);
    		PushFollow(Follow._expressions_in_condExpr1170);
    		expressions87=expressions();
    		PopFollow();

    		stream_expressions.Add(expressions87.Tree);


    		{
    		// AST REWRITE
    		// elements: expressions
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 194:26: -> ^( CONDITION expressions )
    		{
    			DebugLocation(194, 29);
    			// Lang2.g:194:29: ^( CONDITION expressions )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(194, 31);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(CONDITION, "CONDITION"), root_1);

    			DebugLocation(194, 41);
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
        }
     	DebugLocation(195, 3);
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
    // Lang2.g:196:1: conditionExpr : IF condExpr THEN bodyExpr ( conditionElseExpr )? -> ^( IF condExpr bodyExpr ( conditionElseExpr )? ) ;
    [GrammarRule("conditionExpr")]
    private Lang2Parser.conditionExpr_return conditionExpr()
    {

        Lang2Parser.conditionExpr_return retval = new Lang2Parser.conditionExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken IF88=null;
        IToken THEN90=null;
        Lang2Parser.condExpr_return condExpr89 = default(Lang2Parser.condExpr_return);
        Lang2Parser.bodyExpr_return bodyExpr91 = default(Lang2Parser.bodyExpr_return);
        Lang2Parser.conditionElseExpr_return conditionElseExpr92 = default(Lang2Parser.conditionElseExpr_return);

        object IF88_tree=null;
        object THEN90_tree=null;
        RewriteRuleITokenStream stream_THEN=new RewriteRuleITokenStream(adaptor,"token THEN");
        RewriteRuleITokenStream stream_IF=new RewriteRuleITokenStream(adaptor,"token IF");
        RewriteRuleSubtreeStream stream_condExpr=new RewriteRuleSubtreeStream(adaptor,"rule condExpr");
        RewriteRuleSubtreeStream stream_conditionElseExpr=new RewriteRuleSubtreeStream(adaptor,"rule conditionElseExpr");
        RewriteRuleSubtreeStream stream_bodyExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodyExpr");
    	try { DebugEnterRule(GrammarFileName, "conditionExpr");
    	DebugLocation(196, 1);
    	try
    	{
    		// Lang2.g:196:14: ( IF condExpr THEN bodyExpr ( conditionElseExpr )? -> ^( IF condExpr bodyExpr ( conditionElseExpr )? ) )
    		DebugEnterAlt(1);
    		// Lang2.g:196:16: IF condExpr THEN bodyExpr ( conditionElseExpr )?
    		{
    		DebugLocation(196, 16);
    		IF88=(IToken)Match(input,IF,Follow._IF_in_conditionExpr1189);  
    		stream_IF.Add(IF88);

    		DebugLocation(196, 19);
    		PushFollow(Follow._condExpr_in_conditionExpr1191);
    		condExpr89=condExpr();
    		PopFollow();

    		stream_condExpr.Add(condExpr89.Tree);
    		DebugLocation(196, 32);
    		THEN90=(IToken)Match(input,THEN,Follow._THEN_in_conditionExpr1193);  
    		stream_THEN.Add(THEN90);

    		DebugLocation(196, 34);
    		PushFollow(Follow._bodyExpr_in_conditionExpr1196);
    		bodyExpr91=bodyExpr();
    		PopFollow();

    		stream_bodyExpr.Add(bodyExpr91.Tree);
    		DebugLocation(196, 43);
    		// Lang2.g:196:43: ( conditionElseExpr )?
    		int alt15=2;
    		try { DebugEnterSubRule(15);
    		try { DebugEnterDecision(15, decisionCanBacktrack[15]);
    		int LA15_0 = input.LA(1);

    		if ((LA15_0==ELSE))
    		{
    			alt15=1;
    		}
    		} finally { DebugExitDecision(15); }
    		switch (alt15)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Lang2.g:196:43: conditionElseExpr
    			{
    			DebugLocation(196, 43);
    			PushFollow(Follow._conditionElseExpr_in_conditionExpr1198);
    			conditionElseExpr92=conditionElseExpr();
    			PopFollow();

    			stream_conditionElseExpr.Add(conditionElseExpr92.Tree);

    			}
    			break;

    		}
    		} finally { DebugExitSubRule(15); }



    		{
    		// AST REWRITE
    		// elements: condExpr, conditionElseExpr, IF, bodyExpr
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 196:62: -> ^( IF condExpr bodyExpr ( conditionElseExpr )? )
    		{
    			DebugLocation(196, 65);
    			// Lang2.g:196:65: ^( IF condExpr bodyExpr ( conditionElseExpr )? )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(196, 67);
    			root_1 = (object)adaptor.BecomeRoot(stream_IF.NextNode(), root_1);

    			DebugLocation(196, 70);
    			adaptor.AddChild(root_1, stream_condExpr.NextTree());
    			DebugLocation(196, 79);
    			adaptor.AddChild(root_1, stream_bodyExpr.NextTree());
    			DebugLocation(196, 88);
    			// Lang2.g:196:88: ( conditionElseExpr )?
    			if ( stream_conditionElseExpr.HasNext )
    			{
    				DebugLocation(196, 88);
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
     	DebugLocation(197, 1);
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
    // Lang2.g:200:1: forExpr : assExpr TO expressions ;
    [GrammarRule("forExpr")]
    private Lang2Parser.forExpr_return forExpr()
    {

        Lang2Parser.forExpr_return retval = new Lang2Parser.forExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken TO94=null;
        Lang2Parser.assExpr_return assExpr93 = default(Lang2Parser.assExpr_return);
        Lang2Parser.expressions_return expressions95 = default(Lang2Parser.expressions_return);

        object TO94_tree=null;

    	try { DebugEnterRule(GrammarFileName, "forExpr");
    	DebugLocation(200, 2);
    	try
    	{
    		// Lang2.g:200:9: ( assExpr TO expressions )
    		DebugEnterAlt(1);
    		// Lang2.g:200:12: assExpr TO expressions
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(200, 12);
    		PushFollow(Follow._assExpr_in_forExpr1224);
    		assExpr93=assExpr();
    		PopFollow();

    		adaptor.AddChild(root_0, assExpr93.Tree);
    		DebugLocation(200, 22);
    		TO94=(IToken)Match(input,TO,Follow._TO_in_forExpr1226); 
    		TO94_tree = (object)adaptor.Create(TO94);
    		root_0 = (object)adaptor.BecomeRoot(TO94_tree, root_0);

    		DebugLocation(200, 24);
    		PushFollow(Follow._expressions_in_forExpr1229);
    		expressions95=expressions();
    		PopFollow();

    		adaptor.AddChild(root_0, expressions95.Tree);

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
     	DebugLocation(201, 2);
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
    // Lang2.g:202:1: loopExpr : ( WHILE condExpr DO bodyExpr -> ^( WHILE condExpr bodyExpr ) | FOR forExpr DO bodyExpr -> ^( FOR forExpr bodyExpr ) );
    [GrammarRule("loopExpr")]
    private Lang2Parser.loopExpr_return loopExpr()
    {

        Lang2Parser.loopExpr_return retval = new Lang2Parser.loopExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken WHILE96=null;
        IToken DO98=null;
        IToken FOR100=null;
        IToken DO102=null;
        Lang2Parser.condExpr_return condExpr97 = default(Lang2Parser.condExpr_return);
        Lang2Parser.bodyExpr_return bodyExpr99 = default(Lang2Parser.bodyExpr_return);
        Lang2Parser.forExpr_return forExpr101 = default(Lang2Parser.forExpr_return);
        Lang2Parser.bodyExpr_return bodyExpr103 = default(Lang2Parser.bodyExpr_return);

        object WHILE96_tree=null;
        object DO98_tree=null;
        object FOR100_tree=null;
        object DO102_tree=null;
        RewriteRuleITokenStream stream_FOR=new RewriteRuleITokenStream(adaptor,"token FOR");
        RewriteRuleITokenStream stream_DO=new RewriteRuleITokenStream(adaptor,"token DO");
        RewriteRuleITokenStream stream_WHILE=new RewriteRuleITokenStream(adaptor,"token WHILE");
        RewriteRuleSubtreeStream stream_condExpr=new RewriteRuleSubtreeStream(adaptor,"rule condExpr");
        RewriteRuleSubtreeStream stream_bodyExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodyExpr");
        RewriteRuleSubtreeStream stream_forExpr=new RewriteRuleSubtreeStream(adaptor,"rule forExpr");
    	try { DebugEnterRule(GrammarFileName, "loopExpr");
    	DebugLocation(202, 2);
    	try
    	{
    		// Lang2.g:202:9: ( WHILE condExpr DO bodyExpr -> ^( WHILE condExpr bodyExpr ) | FOR forExpr DO bodyExpr -> ^( FOR forExpr bodyExpr ) )
    		int alt16=2;
    		try { DebugEnterDecision(16, decisionCanBacktrack[16]);
    		int LA16_0 = input.LA(1);

    		if ((LA16_0==WHILE))
    		{
    			alt16=1;
    		}
    		else if ((LA16_0==FOR))
    		{
    			alt16=2;
    		}
    		else
    		{
    			NoViableAltException nvae = new NoViableAltException("", 16, 0, input);

    			DebugRecognitionException(nvae);
    			throw nvae;
    		}
    		} finally { DebugExitDecision(16); }
    		switch (alt16)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Lang2.g:202:11: WHILE condExpr DO bodyExpr
    			{
    			DebugLocation(202, 11);
    			WHILE96=(IToken)Match(input,WHILE,Follow._WHILE_in_loopExpr1238);  
    			stream_WHILE.Add(WHILE96);

    			DebugLocation(202, 17);
    			PushFollow(Follow._condExpr_in_loopExpr1240);
    			condExpr97=condExpr();
    			PopFollow();

    			stream_condExpr.Add(condExpr97.Tree);
    			DebugLocation(202, 28);
    			DO98=(IToken)Match(input,DO,Follow._DO_in_loopExpr1242);  
    			stream_DO.Add(DO98);

    			DebugLocation(202, 30);
    			PushFollow(Follow._bodyExpr_in_loopExpr1245);
    			bodyExpr99=bodyExpr();
    			PopFollow();

    			stream_bodyExpr.Add(bodyExpr99.Tree);


    			{
    			// AST REWRITE
    			// elements: condExpr, bodyExpr, WHILE
    			// token labels: 
    			// rule labels: retval
    			// token list labels: 
    			// rule list labels: 
    			// wildcard labels: 
    			retval.Tree = root_0;
    			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    			root_0 = (object)adaptor.Nil();
    			// 202:39: -> ^( WHILE condExpr bodyExpr )
    			{
    				DebugLocation(202, 42);
    				// Lang2.g:202:42: ^( WHILE condExpr bodyExpr )
    				{
    				object root_1 = (object)adaptor.Nil();
    				DebugLocation(202, 44);
    				root_1 = (object)adaptor.BecomeRoot(stream_WHILE.NextNode(), root_1);

    				DebugLocation(202, 50);
    				adaptor.AddChild(root_1, stream_condExpr.NextTree());
    				DebugLocation(202, 59);
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
    			// Lang2.g:203:5: FOR forExpr DO bodyExpr
    			{
    			DebugLocation(203, 5);
    			FOR100=(IToken)Match(input,FOR,Follow._FOR_in_loopExpr1261);  
    			stream_FOR.Add(FOR100);

    			DebugLocation(203, 9);
    			PushFollow(Follow._forExpr_in_loopExpr1263);
    			forExpr101=forExpr();
    			PopFollow();

    			stream_forExpr.Add(forExpr101.Tree);
    			DebugLocation(203, 17);
    			DO102=(IToken)Match(input,DO,Follow._DO_in_loopExpr1265);  
    			stream_DO.Add(DO102);

    			DebugLocation(203, 20);
    			PushFollow(Follow._bodyExpr_in_loopExpr1267);
    			bodyExpr103=bodyExpr();
    			PopFollow();

    			stream_bodyExpr.Add(bodyExpr103.Tree);


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
    			// 203:29: -> ^( FOR forExpr bodyExpr )
    			{
    				DebugLocation(203, 32);
    				// Lang2.g:203:32: ^( FOR forExpr bodyExpr )
    				{
    				object root_1 = (object)adaptor.Nil();
    				DebugLocation(203, 34);
    				root_1 = (object)adaptor.BecomeRoot(stream_FOR.NextNode(), root_1);

    				DebugLocation(203, 38);
    				adaptor.AddChild(root_1, stream_forExpr.NextTree());
    				DebugLocation(203, 46);
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
     	DebugLocation(204, 2);
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
    // Lang2.g:206:1: assExpr : ( VARIABLE ASSIGN expressions | arrayCall ASSIGN expressions );
    [GrammarRule("assExpr")]
    private Lang2Parser.assExpr_return assExpr()
    {

        Lang2Parser.assExpr_return retval = new Lang2Parser.assExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken VARIABLE104=null;
        IToken ASSIGN105=null;
        IToken ASSIGN108=null;
        Lang2Parser.expressions_return expressions106 = default(Lang2Parser.expressions_return);
        Lang2Parser.arrayCall_return arrayCall107 = default(Lang2Parser.arrayCall_return);
        Lang2Parser.expressions_return expressions109 = default(Lang2Parser.expressions_return);

        object VARIABLE104_tree=null;
        object ASSIGN105_tree=null;
        object ASSIGN108_tree=null;

    	try { DebugEnterRule(GrammarFileName, "assExpr");
    	DebugLocation(206, 1);
    	try
    	{
    		// Lang2.g:206:9: ( VARIABLE ASSIGN expressions | arrayCall ASSIGN expressions )
    		int alt17=2;
    		try { DebugEnterDecision(17, decisionCanBacktrack[17]);
    		int LA17_0 = input.LA(1);

    		if ((LA17_0==VARIABLE))
    		{
    			int LA17_1 = input.LA(2);

    			if ((LA17_1==ASSIGN))
    			{
    				alt17=1;
    			}
    			else if ((LA17_1==61))
    			{
    				alt17=2;
    			}
    			else
    			{
    				NoViableAltException nvae = new NoViableAltException("", 17, 1, input);

    				DebugRecognitionException(nvae);
    				throw nvae;
    			}
    		}
    		else
    		{
    			NoViableAltException nvae = new NoViableAltException("", 17, 0, input);

    			DebugRecognitionException(nvae);
    			throw nvae;
    		}
    		} finally { DebugExitDecision(17); }
    		switch (alt17)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Lang2.g:206:12: VARIABLE ASSIGN expressions
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(206, 12);
    			VARIABLE104=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_assExpr1290); 
    			VARIABLE104_tree = (object)adaptor.Create(VARIABLE104);
    			adaptor.AddChild(root_0, VARIABLE104_tree);

    			DebugLocation(206, 27);
    			ASSIGN105=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assExpr1292); 
    			ASSIGN105_tree = (object)adaptor.Create(ASSIGN105);
    			root_0 = (object)adaptor.BecomeRoot(ASSIGN105_tree, root_0);

    			DebugLocation(206, 29);
    			PushFollow(Follow._expressions_in_assExpr1295);
    			expressions106=expressions();
    			PopFollow();

    			adaptor.AddChild(root_0, expressions106.Tree);

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Lang2.g:207:5: arrayCall ASSIGN expressions
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(207, 5);
    			PushFollow(Follow._arrayCall_in_assExpr1301);
    			arrayCall107=arrayCall();
    			PopFollow();

    			adaptor.AddChild(root_0, arrayCall107.Tree);
    			DebugLocation(207, 21);
    			ASSIGN108=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assExpr1303); 
    			ASSIGN108_tree = (object)adaptor.Create(ASSIGN108);
    			root_0 = (object)adaptor.BecomeRoot(ASSIGN108_tree, root_0);

    			DebugLocation(207, 23);
    			PushFollow(Follow._expressions_in_assExpr1306);
    			expressions109=expressions();
    			PopFollow();

    			adaptor.AddChild(root_0, expressions109.Tree);

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
     	DebugLocation(208, 1);
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
    // Lang2.g:210:1: argTypeDecl : typeDecl -> ^( TYPE_DECL typeDecl ) ;
    [GrammarRule("argTypeDecl")]
    private Lang2Parser.argTypeDecl_return argTypeDecl()
    {

        Lang2Parser.argTypeDecl_return retval = new Lang2Parser.argTypeDecl_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.typeDecl_return typeDecl110 = default(Lang2Parser.typeDecl_return);

        RewriteRuleSubtreeStream stream_typeDecl=new RewriteRuleSubtreeStream(adaptor,"rule typeDecl");
    	try { DebugEnterRule(GrammarFileName, "argTypeDecl");
    	DebugLocation(210, 3);
    	try
    	{
    		// Lang2.g:210:13: ( typeDecl -> ^( TYPE_DECL typeDecl ) )
    		DebugEnterAlt(1);
    		// Lang2.g:210:15: typeDecl
    		{
    		DebugLocation(210, 15);
    		PushFollow(Follow._typeDecl_in_argTypeDecl1316);
    		typeDecl110=typeDecl();
    		PopFollow();

    		stream_typeDecl.Add(typeDecl110.Tree);


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
    		// 210:24: -> ^( TYPE_DECL typeDecl )
    		{
    			DebugLocation(210, 27);
    			// Lang2.g:210:27: ^( TYPE_DECL typeDecl )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(210, 29);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(TYPE_DECL, "TYPE_DECL"), root_1);

    			DebugLocation(210, 39);
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
     	DebugLocation(211, 3);
    	} finally { DebugExitRule(GrammarFileName, "argTypeDecl"); }
    	return retval;

    }
    // $ANTLR end "argTypeDecl"

    public class partArgDecl_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_partArgDecl() {}
    protected virtual void Leave_partArgDecl() {}

    // $ANTLR start "partArgDecl"
    // Lang2.g:213:1: partArgDecl : VARIABLE ( ',' VARIABLE )* ;
    [GrammarRule("partArgDecl")]
    private Lang2Parser.partArgDecl_return partArgDecl()
    {

        Lang2Parser.partArgDecl_return retval = new Lang2Parser.partArgDecl_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken VARIABLE111=null;
        IToken char_literal112=null;
        IToken VARIABLE113=null;

        object VARIABLE111_tree=null;
        object char_literal112_tree=null;
        object VARIABLE113_tree=null;

    	try { DebugEnterRule(GrammarFileName, "partArgDecl");
    	DebugLocation(213, 37);
    	try
    	{
    		// Lang2.g:213:12: ( VARIABLE ( ',' VARIABLE )* )
    		DebugEnterAlt(1);
    		// Lang2.g:213:14: VARIABLE ( ',' VARIABLE )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(213, 14);
    		VARIABLE111=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_partArgDecl1335); 
    		VARIABLE111_tree = (object)adaptor.Create(VARIABLE111);
    		adaptor.AddChild(root_0, VARIABLE111_tree);

    		DebugLocation(213, 22);
    		// Lang2.g:213:22: ( ',' VARIABLE )*
    		try { DebugEnterSubRule(18);
    		while (true)
    		{
    			int alt18=2;
    			try { DebugEnterDecision(18, decisionCanBacktrack[18]);
    			int LA18_0 = input.LA(1);

    			if ((LA18_0==66))
    			{
    				alt18=1;
    			}


    			} finally { DebugExitDecision(18); }
    			switch ( alt18 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:213:23: ',' VARIABLE
    				{
    				DebugLocation(213, 26);
    				char_literal112=(IToken)Match(input,66,Follow._66_in_partArgDecl1337); 
    				DebugLocation(213, 28);
    				VARIABLE113=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_partArgDecl1340); 
    				VARIABLE113_tree = (object)adaptor.Create(VARIABLE113);
    				adaptor.AddChild(root_0, VARIABLE113_tree);


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
     	DebugLocation(213, 37);
    	} finally { DebugExitRule(GrammarFileName, "partArgDecl"); }
    	return retval;

    }
    // $ANTLR end "partArgDecl"

    public class argDecl_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_argDecl() {}
    protected virtual void Leave_argDecl() {}

    // $ANTLR start "argDecl"
    // Lang2.g:215:1: argDecl : ( VARIABLE ( ',' VARIABLE )* ':' argTypeDecl | VAR partArgDecl ':' argTypeDecl -> ^( VAR partArgDecl argTypeDecl ) );
    [GrammarRule("argDecl")]
    private Lang2Parser.argDecl_return argDecl()
    {

        Lang2Parser.argDecl_return retval = new Lang2Parser.argDecl_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken VARIABLE114=null;
        IToken char_literal115=null;
        IToken VARIABLE116=null;
        IToken char_literal117=null;
        IToken VAR119=null;
        IToken char_literal121=null;
        Lang2Parser.argTypeDecl_return argTypeDecl118 = default(Lang2Parser.argTypeDecl_return);
        Lang2Parser.partArgDecl_return partArgDecl120 = default(Lang2Parser.partArgDecl_return);
        Lang2Parser.argTypeDecl_return argTypeDecl122 = default(Lang2Parser.argTypeDecl_return);

        object VARIABLE114_tree=null;
        object char_literal115_tree=null;
        object VARIABLE116_tree=null;
        object char_literal117_tree=null;
        object VAR119_tree=null;
        object char_literal121_tree=null;
        RewriteRuleITokenStream stream_67=new RewriteRuleITokenStream(adaptor,"token 67");
        RewriteRuleITokenStream stream_VAR=new RewriteRuleITokenStream(adaptor,"token VAR");
        RewriteRuleSubtreeStream stream_partArgDecl=new RewriteRuleSubtreeStream(adaptor,"rule partArgDecl");
        RewriteRuleSubtreeStream stream_argTypeDecl=new RewriteRuleSubtreeStream(adaptor,"rule argTypeDecl");
    	try { DebugEnterRule(GrammarFileName, "argDecl");
    	DebugLocation(215, 2);
    	try
    	{
    		// Lang2.g:215:9: ( VARIABLE ( ',' VARIABLE )* ':' argTypeDecl | VAR partArgDecl ':' argTypeDecl -> ^( VAR partArgDecl argTypeDecl ) )
    		int alt20=2;
    		try { DebugEnterDecision(20, decisionCanBacktrack[20]);
    		int LA20_0 = input.LA(1);

    		if ((LA20_0==VARIABLE))
    		{
    			alt20=1;
    		}
    		else if ((LA20_0==VAR))
    		{
    			alt20=2;
    		}
    		else
    		{
    			NoViableAltException nvae = new NoViableAltException("", 20, 0, input);

    			DebugRecognitionException(nvae);
    			throw nvae;
    		}
    		} finally { DebugExitDecision(20); }
    		switch (alt20)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Lang2.g:215:11: VARIABLE ( ',' VARIABLE )* ':' argTypeDecl
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(215, 11);
    			VARIABLE114=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_argDecl1350); 
    			VARIABLE114_tree = (object)adaptor.Create(VARIABLE114);
    			adaptor.AddChild(root_0, VARIABLE114_tree);

    			DebugLocation(215, 19);
    			// Lang2.g:215:19: ( ',' VARIABLE )*
    			try { DebugEnterSubRule(19);
    			while (true)
    			{
    				int alt19=2;
    				try { DebugEnterDecision(19, decisionCanBacktrack[19]);
    				int LA19_0 = input.LA(1);

    				if ((LA19_0==66))
    				{
    					alt19=1;
    				}


    				} finally { DebugExitDecision(19); }
    				switch ( alt19 )
    				{
    				case 1:
    					DebugEnterAlt(1);
    					// Lang2.g:215:20: ',' VARIABLE
    					{
    					DebugLocation(215, 23);
    					char_literal115=(IToken)Match(input,66,Follow._66_in_argDecl1352); 
    					DebugLocation(215, 25);
    					VARIABLE116=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_argDecl1355); 
    					VARIABLE116_tree = (object)adaptor.Create(VARIABLE116);
    					adaptor.AddChild(root_0, VARIABLE116_tree);


    					}
    					break;

    				default:
    					goto loop19;
    				}
    			}

    			loop19:
    				;

    			} finally { DebugExitSubRule(19); }

    			DebugLocation(215, 39);
    			char_literal117=(IToken)Match(input,67,Follow._67_in_argDecl1359); 
    			DebugLocation(215, 41);
    			PushFollow(Follow._argTypeDecl_in_argDecl1362);
    			argTypeDecl118=argTypeDecl();
    			PopFollow();

    			adaptor.AddChild(root_0, argTypeDecl118.Tree);

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Lang2.g:216:5: VAR partArgDecl ':' argTypeDecl
    			{
    			DebugLocation(216, 5);
    			VAR119=(IToken)Match(input,VAR,Follow._VAR_in_argDecl1368);  
    			stream_VAR.Add(VAR119);

    			DebugLocation(216, 9);
    			PushFollow(Follow._partArgDecl_in_argDecl1370);
    			partArgDecl120=partArgDecl();
    			PopFollow();

    			stream_partArgDecl.Add(partArgDecl120.Tree);
    			DebugLocation(216, 23);
    			char_literal121=(IToken)Match(input,67,Follow._67_in_argDecl1371);  
    			stream_67.Add(char_literal121);

    			DebugLocation(216, 25);
    			PushFollow(Follow._argTypeDecl_in_argDecl1374);
    			argTypeDecl122=argTypeDecl();
    			PopFollow();

    			stream_argTypeDecl.Add(argTypeDecl122.Tree);


    			{
    			// AST REWRITE
    			// elements: VAR, partArgDecl, argTypeDecl
    			// token labels: 
    			// rule labels: retval
    			// token list labels: 
    			// rule list labels: 
    			// wildcard labels: 
    			retval.Tree = root_0;
    			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    			root_0 = (object)adaptor.Nil();
    			// 216:37: -> ^( VAR partArgDecl argTypeDecl )
    			{
    				DebugLocation(216, 40);
    				// Lang2.g:216:40: ^( VAR partArgDecl argTypeDecl )
    				{
    				object root_1 = (object)adaptor.Nil();
    				DebugLocation(216, 42);
    				root_1 = (object)adaptor.BecomeRoot(stream_VAR.NextNode(), root_1);

    				DebugLocation(216, 46);
    				adaptor.AddChild(root_1, stream_partArgDecl.NextTree());
    				DebugLocation(216, 58);
    				adaptor.AddChild(root_1, stream_argTypeDecl.NextTree());

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
     	DebugLocation(217, 2);
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
    // Lang2.g:219:1: argDeclManyW : argDecl ( ',' argDecl )* ;
    [GrammarRule("argDeclManyW")]
    private Lang2Parser.argDeclManyW_return argDeclManyW()
    {

        Lang2Parser.argDeclManyW_return retval = new Lang2Parser.argDeclManyW_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken char_literal124=null;
        Lang2Parser.argDecl_return argDecl123 = default(Lang2Parser.argDecl_return);
        Lang2Parser.argDecl_return argDecl125 = default(Lang2Parser.argDecl_return);

        object char_literal124_tree=null;

    	try { DebugEnterRule(GrammarFileName, "argDeclManyW");
    	DebugLocation(219, 3);
    	try
    	{
    		// Lang2.g:219:14: ( argDecl ( ',' argDecl )* )
    		DebugEnterAlt(1);
    		// Lang2.g:219:16: argDecl ( ',' argDecl )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(219, 16);
    		PushFollow(Follow._argDecl_in_argDeclManyW1395);
    		argDecl123=argDecl();
    		PopFollow();

    		adaptor.AddChild(root_0, argDecl123.Tree);
    		DebugLocation(219, 23);
    		// Lang2.g:219:23: ( ',' argDecl )*
    		try { DebugEnterSubRule(21);
    		while (true)
    		{
    			int alt21=2;
    			try { DebugEnterDecision(21, decisionCanBacktrack[21]);
    			int LA21_0 = input.LA(1);

    			if ((LA21_0==66))
    			{
    				alt21=1;
    			}


    			} finally { DebugExitDecision(21); }
    			switch ( alt21 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:219:24: ',' argDecl
    				{
    				DebugLocation(219, 27);
    				char_literal124=(IToken)Match(input,66,Follow._66_in_argDeclManyW1397); 
    				DebugLocation(219, 29);
    				PushFollow(Follow._argDecl_in_argDeclManyW1400);
    				argDecl125=argDecl();
    				PopFollow();

    				adaptor.AddChild(root_0, argDecl125.Tree);

    				}
    				break;

    			default:
    				goto loop21;
    			}
    		}

    		loop21:
    			;

    		} finally { DebugExitSubRule(21); }


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
     	DebugLocation(220, 3);
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
    // Lang2.g:221:1: argDeclMany : argDeclManyW -> ^( VAR_DECL argDeclManyW ) ;
    [GrammarRule("argDeclMany")]
    private Lang2Parser.argDeclMany_return argDeclMany()
    {

        Lang2Parser.argDeclMany_return retval = new Lang2Parser.argDeclMany_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.argDeclManyW_return argDeclManyW126 = default(Lang2Parser.argDeclManyW_return);

        RewriteRuleSubtreeStream stream_argDeclManyW=new RewriteRuleSubtreeStream(adaptor,"rule argDeclManyW");
    	try { DebugEnterRule(GrammarFileName, "argDeclMany");
    	DebugLocation(221, 3);
    	try
    	{
    		// Lang2.g:221:13: ( argDeclManyW -> ^( VAR_DECL argDeclManyW ) )
    		DebugEnterAlt(1);
    		// Lang2.g:221:15: argDeclManyW
    		{
    		DebugLocation(221, 15);
    		PushFollow(Follow._argDeclManyW_in_argDeclMany1413);
    		argDeclManyW126=argDeclManyW();
    		PopFollow();

    		stream_argDeclManyW.Add(argDeclManyW126.Tree);


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
    		// 221:28: -> ^( VAR_DECL argDeclManyW )
    		{
    			DebugLocation(221, 31);
    			// Lang2.g:221:31: ^( VAR_DECL argDeclManyW )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(221, 33);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VAR_DECL, "VAR_DECL"), root_1);

    			DebugLocation(221, 42);
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
     	DebugLocation(222, 3);
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
    // Lang2.g:223:1: typeDecl : ( T_INT | T_CHAR | T_BOOL );
    [GrammarRule("typeDecl")]
    private Lang2Parser.typeDecl_return typeDecl()
    {

        Lang2Parser.typeDecl_return retval = new Lang2Parser.typeDecl_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken set127=null;

        object set127_tree=null;

    	try { DebugEnterRule(GrammarFileName, "typeDecl");
    	DebugLocation(223, 30);
    	try
    	{
    		// Lang2.g:223:10: ( T_INT | T_CHAR | T_BOOL )
    		DebugEnterAlt(1);
    		// Lang2.g:
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(223, 10);
    		set127=(IToken)input.LT(1);
    		if ((input.LA(1)>=T_CHAR && input.LA(1)<=T_INT))
    		{
    			input.Consume();
    			adaptor.AddChild(root_0, (object)adaptor.Create(set127));
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
     	DebugLocation(223, 30);
    	} finally { DebugExitRule(GrammarFileName, "typeDecl"); }
    	return retval;

    }
    // $ANTLR end "typeDecl"

    public class varTypeDeclW_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_varTypeDeclW() {}
    protected virtual void Leave_varTypeDeclW() {}

    // $ANTLR start "varTypeDeclW"
    // Lang2.g:226:1: varTypeDeclW : ( typeDecl | arrayDecl );
    [GrammarRule("varTypeDeclW")]
    private Lang2Parser.varTypeDeclW_return varTypeDeclW()
    {

        Lang2Parser.varTypeDeclW_return retval = new Lang2Parser.varTypeDeclW_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.typeDecl_return typeDecl128 = default(Lang2Parser.typeDecl_return);
        Lang2Parser.arrayDecl_return arrayDecl129 = default(Lang2Parser.arrayDecl_return);


    	try { DebugEnterRule(GrammarFileName, "varTypeDeclW");
    	DebugLocation(226, 4);
    	try
    	{
    		// Lang2.g:226:14: ( typeDecl | arrayDecl )
    		int alt22=2;
    		try { DebugEnterDecision(22, decisionCanBacktrack[22]);
    		int LA22_0 = input.LA(1);

    		if (((LA22_0>=T_CHAR && LA22_0<=T_INT)))
    		{
    			alt22=1;
    		}
    		else if ((LA22_0==ARRAY))
    		{
    			alt22=2;
    		}
    		else
    		{
    			NoViableAltException nvae = new NoViableAltException("", 22, 0, input);

    			DebugRecognitionException(nvae);
    			throw nvae;
    		}
    		} finally { DebugExitDecision(22); }
    		switch (alt22)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Lang2.g:226:16: typeDecl
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(226, 16);
    			PushFollow(Follow._typeDecl_in_varTypeDeclW1445);
    			typeDecl128=typeDecl();
    			PopFollow();

    			adaptor.AddChild(root_0, typeDecl128.Tree);

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Lang2.g:226:25: arrayDecl
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(226, 25);
    			PushFollow(Follow._arrayDecl_in_varTypeDeclW1447);
    			arrayDecl129=arrayDecl();
    			PopFollow();

    			adaptor.AddChild(root_0, arrayDecl129.Tree);

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
     	DebugLocation(227, 4);
    	} finally { DebugExitRule(GrammarFileName, "varTypeDeclW"); }
    	return retval;

    }
    // $ANTLR end "varTypeDeclW"

    public class varTypeDecl_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_varTypeDecl() {}
    protected virtual void Leave_varTypeDecl() {}

    // $ANTLR start "varTypeDecl"
    // Lang2.g:229:1: varTypeDecl : varTypeDeclW OP_END -> ^( TYPE_DECL varTypeDeclW ) ;
    [GrammarRule("varTypeDecl")]
    private Lang2Parser.varTypeDecl_return varTypeDecl()
    {

        Lang2Parser.varTypeDecl_return retval = new Lang2Parser.varTypeDecl_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken OP_END131=null;
        Lang2Parser.varTypeDeclW_return varTypeDeclW130 = default(Lang2Parser.varTypeDeclW_return);

        object OP_END131_tree=null;
        RewriteRuleITokenStream stream_OP_END=new RewriteRuleITokenStream(adaptor,"token OP_END");
        RewriteRuleSubtreeStream stream_varTypeDeclW=new RewriteRuleSubtreeStream(adaptor,"rule varTypeDeclW");
    	try { DebugEnterRule(GrammarFileName, "varTypeDecl");
    	DebugLocation(229, 3);
    	try
    	{
    		// Lang2.g:229:13: ( varTypeDeclW OP_END -> ^( TYPE_DECL varTypeDeclW ) )
    		DebugEnterAlt(1);
    		// Lang2.g:229:15: varTypeDeclW OP_END
    		{
    		DebugLocation(229, 15);
    		PushFollow(Follow._varTypeDeclW_in_varTypeDecl1460);
    		varTypeDeclW130=varTypeDeclW();
    		PopFollow();

    		stream_varTypeDeclW.Add(varTypeDeclW130.Tree);
    		DebugLocation(229, 28);
    		OP_END131=(IToken)Match(input,OP_END,Follow._OP_END_in_varTypeDecl1462);  
    		stream_OP_END.Add(OP_END131);



    		{
    		// AST REWRITE
    		// elements: varTypeDeclW
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 229:35: -> ^( TYPE_DECL varTypeDeclW )
    		{
    			DebugLocation(229, 38);
    			// Lang2.g:229:38: ^( TYPE_DECL varTypeDeclW )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(229, 40);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(TYPE_DECL, "TYPE_DECL"), root_1);

    			DebugLocation(229, 50);
    			adaptor.AddChild(root_1, stream_varTypeDeclW.NextTree());

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
     	DebugLocation(230, 3);
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
    // Lang2.g:233:1: varDecl2 : VARIABLE ( ',' VARIABLE )* ;
    [GrammarRule("varDecl2")]
    private Lang2Parser.varDecl2_return varDecl2()
    {

        Lang2Parser.varDecl2_return retval = new Lang2Parser.varDecl2_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken VARIABLE132=null;
        IToken char_literal133=null;
        IToken VARIABLE134=null;

        object VARIABLE132_tree=null;
        object char_literal133_tree=null;
        object VARIABLE134_tree=null;

    	try { DebugEnterRule(GrammarFileName, "varDecl2");
    	DebugLocation(233, 35);
    	try
    	{
    		// Lang2.g:233:10: ( VARIABLE ( ',' VARIABLE )* )
    		DebugEnterAlt(1);
    		// Lang2.g:233:12: VARIABLE ( ',' VARIABLE )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(233, 12);
    		VARIABLE132=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_varDecl21483); 
    		VARIABLE132_tree = (object)adaptor.Create(VARIABLE132);
    		adaptor.AddChild(root_0, VARIABLE132_tree);

    		DebugLocation(233, 20);
    		// Lang2.g:233:20: ( ',' VARIABLE )*
    		try { DebugEnterSubRule(23);
    		while (true)
    		{
    			int alt23=2;
    			try { DebugEnterDecision(23, decisionCanBacktrack[23]);
    			int LA23_0 = input.LA(1);

    			if ((LA23_0==66))
    			{
    				alt23=1;
    			}


    			} finally { DebugExitDecision(23); }
    			switch ( alt23 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:233:21: ',' VARIABLE
    				{
    				DebugLocation(233, 24);
    				char_literal133=(IToken)Match(input,66,Follow._66_in_varDecl21485); 
    				DebugLocation(233, 26);
    				VARIABLE134=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_varDecl21488); 
    				VARIABLE134_tree = (object)adaptor.Create(VARIABLE134);
    				adaptor.AddChild(root_0, VARIABLE134_tree);


    				}
    				break;

    			default:
    				goto loop23;
    			}
    		}

    		loop23:
    			;

    		} finally { DebugExitSubRule(23); }


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
     	DebugLocation(233, 35);
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
    // Lang2.g:235:1: varDecl : varDecl2 ;
    [GrammarRule("varDecl")]
    private Lang2Parser.varDecl_return varDecl()
    {

        Lang2Parser.varDecl_return retval = new Lang2Parser.varDecl_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.varDecl2_return varDecl2135 = default(Lang2Parser.varDecl2_return);


    	try { DebugEnterRule(GrammarFileName, "varDecl");
    	DebugLocation(235, 2);
    	try
    	{
    		// Lang2.g:235:9: ( varDecl2 )
    		DebugEnterAlt(1);
    		// Lang2.g:235:11: varDecl2
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(235, 11);
    		PushFollow(Follow._varDecl2_in_varDecl1498);
    		varDecl2135=varDecl2();
    		PopFollow();

    		adaptor.AddChild(root_0, varDecl2135.Tree);

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
     	DebugLocation(236, 2);
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
    // Lang2.g:237:1: varDecl12W : varDecl ':' varTypeDecl ;
    [GrammarRule("varDecl12W")]
    private Lang2Parser.varDecl12W_return varDecl12W()
    {

        Lang2Parser.varDecl12W_return retval = new Lang2Parser.varDecl12W_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken char_literal137=null;
        Lang2Parser.varDecl_return varDecl136 = default(Lang2Parser.varDecl_return);
        Lang2Parser.varTypeDecl_return varTypeDecl138 = default(Lang2Parser.varTypeDecl_return);

        object char_literal137_tree=null;

    	try { DebugEnterRule(GrammarFileName, "varDecl12W");
    	DebugLocation(237, 3);
    	try
    	{
    		// Lang2.g:237:12: ( varDecl ':' varTypeDecl )
    		DebugEnterAlt(1);
    		// Lang2.g:237:14: varDecl ':' varTypeDecl
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(237, 14);
    		PushFollow(Follow._varDecl_in_varDecl12W1508);
    		varDecl136=varDecl();
    		PopFollow();

    		adaptor.AddChild(root_0, varDecl136.Tree);
    		DebugLocation(237, 25);
    		char_literal137=(IToken)Match(input,67,Follow._67_in_varDecl12W1510); 
    		DebugLocation(237, 27);
    		PushFollow(Follow._varTypeDecl_in_varDecl12W1513);
    		varTypeDecl138=varTypeDecl();
    		PopFollow();

    		adaptor.AddChild(root_0, varTypeDecl138.Tree);

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
     	DebugLocation(238, 3);
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
    // Lang2.g:239:1: varDeclW : VAR ( ( varDecl12W )+ ) -> ^( VAR_DECL ( varDecl12W )+ ) ;
    [GrammarRule("varDeclW")]
    private Lang2Parser.varDeclW_return varDeclW()
    {

        Lang2Parser.varDeclW_return retval = new Lang2Parser.varDeclW_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken VAR139=null;
        Lang2Parser.varDecl12W_return varDecl12W140 = default(Lang2Parser.varDecl12W_return);

        object VAR139_tree=null;
        RewriteRuleITokenStream stream_VAR=new RewriteRuleITokenStream(adaptor,"token VAR");
        RewriteRuleSubtreeStream stream_varDecl12W=new RewriteRuleSubtreeStream(adaptor,"rule varDecl12W");
    	try { DebugEnterRule(GrammarFileName, "varDeclW");
    	DebugLocation(239, 3);
    	try
    	{
    		// Lang2.g:239:10: ( VAR ( ( varDecl12W )+ ) -> ^( VAR_DECL ( varDecl12W )+ ) )
    		DebugEnterAlt(1);
    		// Lang2.g:239:12: VAR ( ( varDecl12W )+ )
    		{
    		DebugLocation(239, 12);
    		VAR139=(IToken)Match(input,VAR,Follow._VAR_in_varDeclW1525);  
    		stream_VAR.Add(VAR139);

    		DebugLocation(239, 16);
    		// Lang2.g:239:16: ( ( varDecl12W )+ )
    		DebugEnterAlt(1);
    		// Lang2.g:239:17: ( varDecl12W )+
    		{
    		DebugLocation(239, 17);
    		// Lang2.g:239:17: ( varDecl12W )+
    		int cnt24=0;
    		try { DebugEnterSubRule(24);
    		while (true)
    		{
    			int alt24=2;
    			try { DebugEnterDecision(24, decisionCanBacktrack[24]);
    			int LA24_0 = input.LA(1);

    			if ((LA24_0==VARIABLE))
    			{
    				alt24=1;
    			}


    			} finally { DebugExitDecision(24); }
    			switch (alt24)
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:239:17: varDecl12W
    				{
    				DebugLocation(239, 17);
    				PushFollow(Follow._varDecl12W_in_varDeclW1528);
    				varDecl12W140=varDecl12W();
    				PopFollow();

    				stream_varDecl12W.Add(varDecl12W140.Tree);

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
    		// 239:30: -> ^( VAR_DECL ( varDecl12W )+ )
    		{
    			DebugLocation(239, 33);
    			// Lang2.g:239:33: ^( VAR_DECL ( varDecl12W )+ )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(239, 35);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VAR_DECL, "VAR_DECL"), root_1);

    			DebugLocation(239, 44);
    			if ( !(stream_varDecl12W.HasNext) )
    			{
    				throw new RewriteEarlyExitException();
    			}
    			while ( stream_varDecl12W.HasNext )
    			{
    				DebugLocation(239, 44);
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
     	DebugLocation(240, 3);
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
    // Lang2.g:244:1: bodyExpr : BEGIN ( bodyOper )* END OP_END -> ^( BODY_EXPR ( bodyOper )* ) ;
    [GrammarRule("bodyExpr")]
    private Lang2Parser.bodyExpr_return bodyExpr()
    {

        Lang2Parser.bodyExpr_return retval = new Lang2Parser.bodyExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken BEGIN141=null;
        IToken END143=null;
        IToken OP_END144=null;
        Lang2Parser.bodyOper_return bodyOper142 = default(Lang2Parser.bodyOper_return);

        object BEGIN141_tree=null;
        object END143_tree=null;
        object OP_END144_tree=null;
        RewriteRuleITokenStream stream_OP_END=new RewriteRuleITokenStream(adaptor,"token OP_END");
        RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
        RewriteRuleITokenStream stream_BEGIN=new RewriteRuleITokenStream(adaptor,"token BEGIN");
        RewriteRuleSubtreeStream stream_bodyOper=new RewriteRuleSubtreeStream(adaptor,"rule bodyOper");
    	try { DebugEnterRule(GrammarFileName, "bodyExpr");
    	DebugLocation(244, 3);
    	try
    	{
    		// Lang2.g:244:10: ( BEGIN ( bodyOper )* END OP_END -> ^( BODY_EXPR ( bodyOper )* ) )
    		DebugEnterAlt(1);
    		// Lang2.g:244:12: BEGIN ( bodyOper )* END OP_END
    		{
    		DebugLocation(244, 17);
    		BEGIN141=(IToken)Match(input,BEGIN,Follow._BEGIN_in_bodyExpr1554);  
    		stream_BEGIN.Add(BEGIN141);

    		DebugLocation(244, 19);
    		// Lang2.g:244:19: ( bodyOper )*
    		try { DebugEnterSubRule(25);
    		while (true)
    		{
    			int alt25=2;
    			try { DebugEnterDecision(25, decisionCanBacktrack[25]);
    			int LA25_0 = input.LA(1);

    			if ((LA25_0==WHILE||LA25_0==FOR||LA25_0==IF||LA25_0==VARIABLE))
    			{
    				alt25=1;
    			}


    			} finally { DebugExitDecision(25); }
    			switch ( alt25 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:244:19: bodyOper
    				{
    				DebugLocation(244, 19);
    				PushFollow(Follow._bodyOper_in_bodyExpr1557);
    				bodyOper142=bodyOper();
    				PopFollow();

    				stream_bodyOper.Add(bodyOper142.Tree);

    				}
    				break;

    			default:
    				goto loop25;
    			}
    		}

    		loop25:
    			;

    		} finally { DebugExitSubRule(25); }

    		DebugLocation(244, 32);
    		END143=(IToken)Match(input,END,Follow._END_in_bodyExpr1560);  
    		stream_END.Add(END143);

    		DebugLocation(244, 40);
    		OP_END144=(IToken)Match(input,OP_END,Follow._OP_END_in_bodyExpr1563);  
    		stream_OP_END.Add(OP_END144);



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
    		// 244:42: -> ^( BODY_EXPR ( bodyOper )* )
    		{
    			DebugLocation(244, 45);
    			// Lang2.g:244:45: ^( BODY_EXPR ( bodyOper )* )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(244, 47);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BODY_EXPR, "BODY_EXPR"), root_1);

    			DebugLocation(244, 57);
    			// Lang2.g:244:57: ( bodyOper )*
    			while ( stream_bodyOper.HasNext )
    			{
    				DebugLocation(244, 57);
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
     	DebugLocation(245, 3);
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
    // Lang2.g:247:1: func_proc_expr : ( funcDeclare | procedureDeclare );
    [GrammarRule("func_proc_expr")]
    private Lang2Parser.func_proc_expr_return func_proc_expr()
    {

        Lang2Parser.func_proc_expr_return retval = new Lang2Parser.func_proc_expr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.funcDeclare_return funcDeclare145 = default(Lang2Parser.funcDeclare_return);
        Lang2Parser.procedureDeclare_return procedureDeclare146 = default(Lang2Parser.procedureDeclare_return);


    	try { DebugEnterRule(GrammarFileName, "func_proc_expr");
    	DebugLocation(247, 46);
    	try
    	{
    		// Lang2.g:247:16: ( funcDeclare | procedureDeclare )
    		int alt26=2;
    		try { DebugEnterDecision(26, decisionCanBacktrack[26]);
    		int LA26_0 = input.LA(1);

    		if ((LA26_0==FUNCTION))
    		{
    			alt26=1;
    		}
    		else if ((LA26_0==PROCEDURE))
    		{
    			alt26=2;
    		}
    		else
    		{
    			NoViableAltException nvae = new NoViableAltException("", 26, 0, input);

    			DebugRecognitionException(nvae);
    			throw nvae;
    		}
    		} finally { DebugExitDecision(26); }
    		switch (alt26)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Lang2.g:247:18: funcDeclare
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(247, 18);
    			PushFollow(Follow._funcDeclare_in_func_proc_expr1585);
    			funcDeclare145=funcDeclare();
    			PopFollow();

    			adaptor.AddChild(root_0, funcDeclare145.Tree);

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Lang2.g:247:30: procedureDeclare
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(247, 30);
    			PushFollow(Follow._procedureDeclare_in_func_proc_expr1587);
    			procedureDeclare146=procedureDeclare();
    			PopFollow();

    			adaptor.AddChild(root_0, procedureDeclare146.Tree);

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
     	DebugLocation(247, 46);
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
    // Lang2.g:249:1: fpExprW : ( func_proc_expr )* -> ^( FUNC_PROC_EXPR ( func_proc_expr )* ) ;
    [GrammarRule("fpExprW")]
    private Lang2Parser.fpExprW_return fpExprW()
    {

        Lang2Parser.fpExprW_return retval = new Lang2Parser.fpExprW_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.func_proc_expr_return func_proc_expr147 = default(Lang2Parser.func_proc_expr_return);

        RewriteRuleSubtreeStream stream_func_proc_expr=new RewriteRuleSubtreeStream(adaptor,"rule func_proc_expr");
    	try { DebugEnterRule(GrammarFileName, "fpExprW");
    	DebugLocation(249, 62);
    	try
    	{
    		// Lang2.g:249:9: ( ( func_proc_expr )* -> ^( FUNC_PROC_EXPR ( func_proc_expr )* ) )
    		DebugEnterAlt(1);
    		// Lang2.g:249:11: ( func_proc_expr )*
    		{
    		DebugLocation(249, 11);
    		// Lang2.g:249:11: ( func_proc_expr )*
    		try { DebugEnterSubRule(27);
    		while (true)
    		{
    			int alt27=2;
    			try { DebugEnterDecision(27, decisionCanBacktrack[27]);
    			int LA27_0 = input.LA(1);

    			if (((LA27_0>=FUNCTION && LA27_0<=PROCEDURE)))
    			{
    				alt27=1;
    			}


    			} finally { DebugExitDecision(27); }
    			switch ( alt27 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:249:11: func_proc_expr
    				{
    				DebugLocation(249, 11);
    				PushFollow(Follow._func_proc_expr_in_fpExprW1596);
    				func_proc_expr147=func_proc_expr();
    				PopFollow();

    				stream_func_proc_expr.Add(func_proc_expr147.Tree);

    				}
    				break;

    			default:
    				goto loop27;
    			}
    		}

    		loop27:
    			;

    		} finally { DebugExitSubRule(27); }



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
    		// 249:27: -> ^( FUNC_PROC_EXPR ( func_proc_expr )* )
    		{
    			DebugLocation(249, 30);
    			// Lang2.g:249:30: ^( FUNC_PROC_EXPR ( func_proc_expr )* )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(249, 32);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_PROC_EXPR, "FUNC_PROC_EXPR"), root_1);

    			DebugLocation(249, 47);
    			// Lang2.g:249:47: ( func_proc_expr )*
    			while ( stream_func_proc_expr.HasNext )
    			{
    				DebugLocation(249, 47);
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
     	DebugLocation(249, 62);
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
    // Lang2.g:251:1: expr : PROGRAM VARIABLE OP_END ( varDeclW )? fpExprW bodyExpr -> ^( PROGRAM VARIABLE ( varDeclW )? fpExprW bodyExpr ) ;
    [GrammarRule("expr")]
    private Lang2Parser.expr_return expr()
    {

        Lang2Parser.expr_return retval = new Lang2Parser.expr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken PROGRAM148=null;
        IToken VARIABLE149=null;
        IToken OP_END150=null;
        Lang2Parser.varDeclW_return varDeclW151 = default(Lang2Parser.varDeclW_return);
        Lang2Parser.fpExprW_return fpExprW152 = default(Lang2Parser.fpExprW_return);
        Lang2Parser.bodyExpr_return bodyExpr153 = default(Lang2Parser.bodyExpr_return);

        object PROGRAM148_tree=null;
        object VARIABLE149_tree=null;
        object OP_END150_tree=null;
        RewriteRuleITokenStream stream_PROGRAM=new RewriteRuleITokenStream(adaptor,"token PROGRAM");
        RewriteRuleITokenStream stream_VARIABLE=new RewriteRuleITokenStream(adaptor,"token VARIABLE");
        RewriteRuleITokenStream stream_OP_END=new RewriteRuleITokenStream(adaptor,"token OP_END");
        RewriteRuleSubtreeStream stream_varDeclW=new RewriteRuleSubtreeStream(adaptor,"rule varDeclW");
        RewriteRuleSubtreeStream stream_bodyExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodyExpr");
        RewriteRuleSubtreeStream stream_fpExprW=new RewriteRuleSubtreeStream(adaptor,"rule fpExprW");
    	try { DebugEnterRule(GrammarFileName, "expr");
    	DebugLocation(251, 1);
    	try
    	{
    		// Lang2.g:251:6: ( PROGRAM VARIABLE OP_END ( varDeclW )? fpExprW bodyExpr -> ^( PROGRAM VARIABLE ( varDeclW )? fpExprW bodyExpr ) )
    		DebugEnterAlt(1);
    		// Lang2.g:251:9: PROGRAM VARIABLE OP_END ( varDeclW )? fpExprW bodyExpr
    		{
    		DebugLocation(251, 9);
    		PROGRAM148=(IToken)Match(input,PROGRAM,Follow._PROGRAM_in_expr1615);  
    		stream_PROGRAM.Add(PROGRAM148);

    		DebugLocation(251, 17);
    		VARIABLE149=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_expr1617);  
    		stream_VARIABLE.Add(VARIABLE149);

    		DebugLocation(251, 32);
    		OP_END150=(IToken)Match(input,OP_END,Follow._OP_END_in_expr1619);  
    		stream_OP_END.Add(OP_END150);

    		DebugLocation(251, 34);
    		// Lang2.g:251:34: ( varDeclW )?
    		int alt28=2;
    		try { DebugEnterSubRule(28);
    		try { DebugEnterDecision(28, decisionCanBacktrack[28]);
    		int LA28_0 = input.LA(1);

    		if ((LA28_0==VAR))
    		{
    			alt28=1;
    		}
    		} finally { DebugExitDecision(28); }
    		switch (alt28)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Lang2.g:251:34: varDeclW
    			{
    			DebugLocation(251, 34);
    			PushFollow(Follow._varDeclW_in_expr1622);
    			varDeclW151=varDeclW();
    			PopFollow();

    			stream_varDeclW.Add(varDeclW151.Tree);

    			}
    			break;

    		}
    		} finally { DebugExitSubRule(28); }

    		DebugLocation(251, 44);
    		PushFollow(Follow._fpExprW_in_expr1625);
    		fpExprW152=fpExprW();
    		PopFollow();

    		stream_fpExprW.Add(fpExprW152.Tree);
    		DebugLocation(251, 52);
    		PushFollow(Follow._bodyExpr_in_expr1627);
    		bodyExpr153=bodyExpr();
    		PopFollow();

    		stream_bodyExpr.Add(bodyExpr153.Tree);


    		{
    		// AST REWRITE
    		// elements: PROGRAM, VARIABLE, fpExprW, varDeclW, bodyExpr
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 251:61: -> ^( PROGRAM VARIABLE ( varDeclW )? fpExprW bodyExpr )
    		{
    			DebugLocation(251, 64);
    			// Lang2.g:251:64: ^( PROGRAM VARIABLE ( varDeclW )? fpExprW bodyExpr )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(251, 66);
    			root_1 = (object)adaptor.BecomeRoot(stream_PROGRAM.NextNode(), root_1);

    			DebugLocation(251, 74);
    			adaptor.AddChild(root_1, stream_VARIABLE.NextNode());
    			DebugLocation(251, 83);
    			// Lang2.g:251:83: ( varDeclW )?
    			if ( stream_varDeclW.HasNext )
    			{
    				DebugLocation(251, 83);
    				adaptor.AddChild(root_1, stream_varDeclW.NextTree());

    			}
    			stream_varDeclW.Reset();
    			DebugLocation(251, 93);
    			adaptor.AddChild(root_1, stream_fpExprW.NextTree());
    			DebugLocation(251, 101);
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
     	DebugLocation(252, 1);
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
    // Lang2.g:254:1: program : ( expr )+ ;
    [GrammarRule("program")]
    private Lang2Parser.program_return program()
    {

        Lang2Parser.program_return retval = new Lang2Parser.program_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.expr_return expr154 = default(Lang2Parser.expr_return);


    	try { DebugEnterRule(GrammarFileName, "program");
    	DebugLocation(254, 16);
    	try
    	{
    		// Lang2.g:254:8: ( ( expr )+ )
    		DebugEnterAlt(1);
    		// Lang2.g:254:10: ( expr )+
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(254, 10);
    		// Lang2.g:254:10: ( expr )+
    		int cnt29=0;
    		try { DebugEnterSubRule(29);
    		while (true)
    		{
    			int alt29=2;
    			try { DebugEnterDecision(29, decisionCanBacktrack[29]);
    			int LA29_0 = input.LA(1);

    			if ((LA29_0==PROGRAM))
    			{
    				alt29=1;
    			}


    			} finally { DebugExitDecision(29); }
    			switch (alt29)
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:254:10: expr
    				{
    				DebugLocation(254, 10);
    				PushFollow(Follow._expr_in_program1652);
    				expr154=expr();
    				PopFollow();

    				adaptor.AddChild(root_0, expr154.Tree);

    				}
    				break;

    			default:
    				if (cnt29 >= 1)
    					goto loop29;

    				EarlyExitException eee29 = new EarlyExitException( 29, input );
    				DebugRecognitionException(eee29);
    				throw eee29;
    			}
    			cnt29++;
    		}
    		loop29:
    			;

    		} finally { DebugExitSubRule(29); }


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
     	DebugLocation(254, 16);
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
    // Lang2.g:255:1: result : program EOF -> ^( PROGRAM program ) ;
    [GrammarRule("result")]
    private Lang2Parser.result_return result()
    {

        Lang2Parser.result_return retval = new Lang2Parser.result_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken EOF156=null;
        Lang2Parser.program_return program155 = default(Lang2Parser.program_return);

        object EOF156_tree=null;
        RewriteRuleITokenStream stream_EOF=new RewriteRuleITokenStream(adaptor,"token EOF");
        RewriteRuleSubtreeStream stream_program=new RewriteRuleSubtreeStream(adaptor,"rule program");
    	try { DebugEnterRule(GrammarFileName, "result");
    	DebugLocation(255, 41);
    	try
    	{
    		// Lang2.g:255:7: ( program EOF -> ^( PROGRAM program ) )
    		DebugEnterAlt(1);
    		// Lang2.g:255:9: program EOF
    		{
    		DebugLocation(255, 9);
    		PushFollow(Follow._program_in_result1661);
    		program155=program();
    		PopFollow();

    		stream_program.Add(program155.Tree);
    		DebugLocation(255, 17);
    		EOF156=(IToken)Match(input,EOF,Follow._EOF_in_result1663);  
    		stream_EOF.Add(EOF156);



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
    		// 255:21: -> ^( PROGRAM program )
    		{
    			DebugLocation(255, 24);
    			// Lang2.g:255:24: ^( PROGRAM program )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(255, 26);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PROGRAM, "PROGRAM"), root_1);

    			DebugLocation(255, 34);
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
     	DebugLocation(255, 41);
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
    // Lang2.g:256:8: public execute : result ;
    [GrammarRule("execute")]
    public Lang2Parser.execute_return execute()
    {

        Lang2Parser.execute_return retval = new Lang2Parser.execute_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.result_return result157 = default(Lang2Parser.result_return);


    	try { DebugEnterRule(GrammarFileName, "execute");
    	DebugLocation(256, 23);
    	try
    	{
    		// Lang2.g:256:15: ( result )
    		DebugEnterAlt(1);
    		// Lang2.g:256:18: result
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(256, 18);
    		PushFollow(Follow._result_in_execute1680);
    		result157=result();
    		PopFollow();

    		adaptor.AddChild(root_0, result157.Tree);

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
     	DebugLocation(256, 23);
    	} finally { DebugExitRule(GrammarFileName, "execute"); }
    	return retval;

    }
    // $ANTLR end "execute"

	#region DFA
	DFA2 dfa2;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa2 = new DFA2( this );
	}

	private class DFA2 : DFA
	{
		private const string DFA2_eotS =
			"\x0c\uffff";
		private const string DFA2_eofS =
			"\x0c\uffff";
		private const string DFA2_minS =
			"\x01\x18\x02\uffff\x01\x06\x03\uffff\x01\x18\x01\uffff\x01\x0e\x01\uffff"+
			"\x01\x0e";
		private const string DFA2_maxS =
			"\x01\x40\x02\uffff\x01\x41\x03\uffff\x01\x41\x01\uffff\x01\x42\x01\uffff"+
			"\x01\x41";
		private const string DFA2_acceptS =
			"\x01\uffff\x01\x01\x01\x02\x01\uffff\x01\x04\x01\x05\x01\x06\x01\uffff"+
			"\x01\x03\x01\uffff\x01\x07\x01\uffff";
		private const string DFA2_specialS =
			"\x0c\uffff}>";
		private static readonly string[] DFA2_transitionS =
			{
				"\x01\x04\x01\x02\x01\x05\x01\x06\x15\uffff\x01\x03\x0e\uffff\x01\x01",
				"",
				"",
				"\x01\x08\x05\uffff\x01\x08\x01\uffff\x04\x08\x06\uffff\x04\x08\x0b"+
				"\uffff\x02\x08\x06\uffff\x01\x08\x01\uffff\x05\x08\x02\uffff\x05\x08"+
				"\x01\uffff\x02\x08\x01\x07\x01\x08",
				"",
				"",
				"",
				"\x04\x08\x15\uffff\x01\x09\x0e\uffff\x01\x08\x01\x0a",
				"",
				"\x03\x08\x07\uffff\x04\x08\x0b\uffff\x02\x08\x08\uffff\x05\x08\x02"+
				"\uffff\x06\x08\x02\uffff\x01\x08\x01\x0b\x01\x0a",
				"",
				"\x03\x08\x07\uffff\x04\x08\x0b\uffff\x02\x08\x06\uffff\x01\x0a\x01"+
				"\uffff\x05\x08\x02\uffff\x05\x08\x03\uffff\x02\x08"
			};

		private static readonly short[] DFA2_eot = DFA.UnpackEncodedString(DFA2_eotS);
		private static readonly short[] DFA2_eof = DFA.UnpackEncodedString(DFA2_eofS);
		private static readonly char[] DFA2_min = DFA.UnpackEncodedStringToUnsignedChars(DFA2_minS);
		private static readonly char[] DFA2_max = DFA.UnpackEncodedStringToUnsignedChars(DFA2_maxS);
		private static readonly short[] DFA2_accept = DFA.UnpackEncodedString(DFA2_acceptS);
		private static readonly short[] DFA2_special = DFA.UnpackEncodedString(DFA2_specialS);
		private static readonly short[][] DFA2_transition;

		static DFA2()
		{
			int numStates = DFA2_transitionS.Length;
			DFA2_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA2_transition[i] = DFA.UnpackEncodedString(DFA2_transitionS[i]);
			}
		}

		public DFA2( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 2;
			this.eot = DFA2_eot;
			this.eof = DFA2_eof;
			this.min = DFA2_min;
			this.max = DFA2_max;
			this.accept = DFA2_accept;
			this.special = DFA2_special;
			this.transition = DFA2_transition;
		}

		public override string Description { get { return "121:1: mathGroup : ( '(' ( expressions )+ ')' | INT | VARIABLE | CHAR | FALSE | TRUE | funcCall );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}


	#endregion DFA

	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _61_in_arrayRange429 = new BitSet(new ulong[]{0x000200000F000000UL,0x0000000000000001UL});
		public static readonly BitSet _expressions_in_arrayRange430 = new BitSet(new ulong[]{0x4000000000000000UL});
		public static readonly BitSet _62_in_arrayRange432 = new BitSet(new ulong[]{0x000200000F000000UL,0x0000000000000001UL});
		public static readonly BitSet _expressions_in_arrayRange434 = new BitSet(new ulong[]{0x8000000000000000UL});
		public static readonly BitSet _63_in_arrayRange435 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _OF_in_arrayTypeDecl456 = new BitSet(new ulong[]{0x0000000000380000UL});
		public static readonly BitSet _typeDecl_in_arrayTypeDecl458 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _ARRAY_in_arrayDecl479 = new BitSet(new ulong[]{0x2000000000000000UL});
		public static readonly BitSet _arrayRange_in_arrayDecl481 = new BitSet(new ulong[]{0x0000080000000000UL});
		public static readonly BitSet _arrayTypeDecl_in_arrayDecl483 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VARIABLE_in_arrayCall506 = new BitSet(new ulong[]{0x2000000000000000UL});
		public static readonly BitSet _61_in_arrayCall508 = new BitSet(new ulong[]{0x000200000F000000UL,0x0000000000000001UL});
		public static readonly BitSet _expressions_in_arrayCall509 = new BitSet(new ulong[]{0x8000000000000000UL});
		public static readonly BitSet _63_in_arrayCall510 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _set_in_boolOperator0 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _64_in_mathGroup660 = new BitSet(new ulong[]{0x000200000F000000UL,0x0000000000000001UL});
		public static readonly BitSet _expressions_in_mathGroup662 = new BitSet(new ulong[]{0x000200000F000000UL,0x0000000000000003UL});
		public static readonly BitSet _65_in_mathGroup664 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _INT_in_mathGroup671 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VARIABLE_in_mathGroup677 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _CHAR_in_mathGroup683 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _FALSE_in_mathGroup689 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _TRUE_in_mathGroup693 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _funcCall_in_mathGroup699 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _mathGroup_in_boolMult711 = new BitSet(new ulong[]{0x0000008000000002UL});
		public static readonly BitSet _BOOL_MULT_in_boolMult713 = new BitSet(new ulong[]{0x000200000F000000UL,0x0000000000000001UL});
		public static readonly BitSet _mathGroup_in_boolMult716 = new BitSet(new ulong[]{0x0000008000000002UL});
		public static readonly BitSet _boolMult_in_boolAdd730 = new BitSet(new ulong[]{0x0000010000000002UL});
		public static readonly BitSet _BOOL_ADD_in_boolAdd732 = new BitSet(new ulong[]{0x000200000F000000UL,0x0000000000000001UL});
		public static readonly BitSet _boolMult_in_boolAdd735 = new BitSet(new ulong[]{0x0000010000000002UL});
		public static readonly BitSet _boolAdd_in_boolElse748 = new BitSet(new ulong[]{0x1F00000000000002UL});
		public static readonly BitSet _boolOperator_in_boolElse750 = new BitSet(new ulong[]{0x000200000F000000UL,0x0000000000000001UL});
		public static readonly BitSet _boolAdd_in_boolElse753 = new BitSet(new ulong[]{0x1F00000000000002UL});
		public static readonly BitSet _boolElse_in_boolNegative767 = new BitSet(new ulong[]{0x0000000000010002UL});
		public static readonly BitSet _NOT_in_boolNegative770 = new BitSet(new ulong[]{0x000200000F000000UL,0x0000000000000001UL});
		public static readonly BitSet _boolElse_in_boolNegative773 = new BitSet(new ulong[]{0x0000000000010002UL});
		public static readonly BitSet _boolNegative_in_useDiv787 = new BitSet(new ulong[]{0x000000000000C002UL});
		public static readonly BitSet _set_in_useDiv789 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000001UL});
		public static readonly BitSet _64_in_useDiv796 = new BitSet(new ulong[]{0x000200000F000000UL,0x0000000000000001UL});
		public static readonly BitSet _boolNegative_in_useDiv799 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000002UL});
		public static readonly BitSet _65_in_useDiv801 = new BitSet(new ulong[]{0x000000000000C002UL});
		public static readonly BitSet _useDiv_in_mathMult818 = new BitSet(new ulong[]{0x0030000000000002UL});
		public static readonly BitSet _set_in_mathMult820 = new BitSet(new ulong[]{0x000200000F000000UL,0x0000000000000001UL});
		public static readonly BitSet _useDiv_in_mathMult826 = new BitSet(new ulong[]{0x0030000000000002UL});
		public static readonly BitSet _mathMult_in_mathAdd839 = new BitSet(new ulong[]{0x000C000000000002UL});
		public static readonly BitSet _set_in_mathAdd841 = new BitSet(new ulong[]{0x000200000F000000UL,0x0000000000000001UL});
		public static readonly BitSet _mathMult_in_mathAdd847 = new BitSet(new ulong[]{0x000C000000000002UL});
		public static readonly BitSet _mathAdd_in_mathExpr861 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _assExpr_in_bodyOper875 = new BitSet(new ulong[]{0x0000800000000000UL});
		public static readonly BitSet _OP_END_in_bodyOper877 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _conditionExpr_in_bodyOper885 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _loopExpr_in_bodyOper892 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _funcCall_in_bodyOper899 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _mathExpr_in_expressions912 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _arrayCall_in_expressions919 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VARIABLE_in_funcCallArgs932 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000004UL});
		public static readonly BitSet _66_in_funcCallArgs934 = new BitSet(new ulong[]{0x0002000000000000UL});
		public static readonly BitSet _VARIABLE_in_funcCallArgs936 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000004UL});
		public static readonly BitSet _funcCallArgs_in_funcCallArgsW951 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VARIABLE_in_funcCall972 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000001UL});
		public static readonly BitSet _64_in_funcCall974 = new BitSet(new ulong[]{0x0002000000000000UL,0x0000000000000002UL});
		public static readonly BitSet _funcCallArgsW_in_funcCall977 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000002UL});
		public static readonly BitSet _65_in_funcCall980 = new BitSet(new ulong[]{0x0000800000000000UL});
		public static readonly BitSet _OP_END_in_funcCall983 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _64_in_argDeclExpr1007 = new BitSet(new ulong[]{0x0002000000040000UL});
		public static readonly BitSet _argDeclMany_in_argDeclExpr1010 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000002UL});
		public static readonly BitSet _65_in_argDeclExpr1011 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _T_INT_in_retTypeExpr1033 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _T_BOOL_in_retTypeExpr1035 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _T_CHAR_in_retTypeExpr1037 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _arrayDecl_in_retTypeExpr1039 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _retTypeExpr_in_retTypeExprWrap1052 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _FUNCTION_in_funcDeclare1072 = new BitSet(new ulong[]{0x0002000000000000UL});
		public static readonly BitSet _VARIABLE_in_funcDeclare1074 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000001UL});
		public static readonly BitSet _argDeclExpr_in_funcDeclare1076 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000008UL});
		public static readonly BitSet _67_in_funcDeclare1077 = new BitSet(new ulong[]{0x0000040000380000UL});
		public static readonly BitSet _retTypeExprWrap_in_funcDeclare1079 = new BitSet(new ulong[]{0x0000800000000000UL});
		public static readonly BitSet _OP_END_in_funcDeclare1081 = new BitSet(new ulong[]{0x0000000000000400UL});
		public static readonly BitSet _bodyExpr_in_funcDeclare1085 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _PROCEDURE_in_procedureDeclare1110 = new BitSet(new ulong[]{0x0002000000000000UL});
		public static readonly BitSet _VARIABLE_in_procedureDeclare1112 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000001UL});
		public static readonly BitSet _argDeclExpr_in_procedureDeclare1114 = new BitSet(new ulong[]{0x0000800000000000UL});
		public static readonly BitSet _OP_END_in_procedureDeclare1116 = new BitSet(new ulong[]{0x0000000000000400UL});
		public static readonly BitSet _bodyExpr_in_procedureDeclare1118 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _ELSE_in_conditionElseExpr1145 = new BitSet(new ulong[]{0x0000000000000400UL});
		public static readonly BitSet _bodyExpr_in_conditionElseExpr1148 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _expressions_in_condExpr1170 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _IF_in_conditionExpr1189 = new BitSet(new ulong[]{0x000200000F000000UL,0x0000000000000001UL});
		public static readonly BitSet _condExpr_in_conditionExpr1191 = new BitSet(new ulong[]{0x0000000000001000UL});
		public static readonly BitSet _THEN_in_conditionExpr1193 = new BitSet(new ulong[]{0x0000000000000400UL});
		public static readonly BitSet _bodyExpr_in_conditionExpr1196 = new BitSet(new ulong[]{0x0000000000002002UL});
		public static readonly BitSet _conditionElseExpr_in_conditionExpr1198 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _assExpr_in_forExpr1224 = new BitSet(new ulong[]{0x0000000000020000UL});
		public static readonly BitSet _TO_in_forExpr1226 = new BitSet(new ulong[]{0x000200000F000000UL,0x0000000000000001UL});
		public static readonly BitSet _expressions_in_forExpr1229 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _WHILE_in_loopExpr1238 = new BitSet(new ulong[]{0x000200000F000000UL,0x0000000000000001UL});
		public static readonly BitSet _condExpr_in_loopExpr1240 = new BitSet(new ulong[]{0x0000000000000040UL});
		public static readonly BitSet _DO_in_loopExpr1242 = new BitSet(new ulong[]{0x0000000000000400UL});
		public static readonly BitSet _bodyExpr_in_loopExpr1245 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _FOR_in_loopExpr1261 = new BitSet(new ulong[]{0x000200000F000000UL,0x0000000000000001UL});
		public static readonly BitSet _forExpr_in_loopExpr1263 = new BitSet(new ulong[]{0x0000000000000040UL});
		public static readonly BitSet _DO_in_loopExpr1265 = new BitSet(new ulong[]{0x0000000000000400UL});
		public static readonly BitSet _bodyExpr_in_loopExpr1267 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VARIABLE_in_assExpr1290 = new BitSet(new ulong[]{0x0040000000000000UL});
		public static readonly BitSet _ASSIGN_in_assExpr1292 = new BitSet(new ulong[]{0x000200000F000000UL,0x0000000000000001UL});
		public static readonly BitSet _expressions_in_assExpr1295 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _arrayCall_in_assExpr1301 = new BitSet(new ulong[]{0x0040000000000000UL});
		public static readonly BitSet _ASSIGN_in_assExpr1303 = new BitSet(new ulong[]{0x000200000F000000UL,0x0000000000000001UL});
		public static readonly BitSet _expressions_in_assExpr1306 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _typeDecl_in_argTypeDecl1316 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VARIABLE_in_partArgDecl1335 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000004UL});
		public static readonly BitSet _66_in_partArgDecl1337 = new BitSet(new ulong[]{0x0002000000000000UL});
		public static readonly BitSet _VARIABLE_in_partArgDecl1340 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000004UL});
		public static readonly BitSet _VARIABLE_in_argDecl1350 = new BitSet(new ulong[]{0x0000000000000000UL,0x000000000000000CUL});
		public static readonly BitSet _66_in_argDecl1352 = new BitSet(new ulong[]{0x0002000000000000UL});
		public static readonly BitSet _VARIABLE_in_argDecl1355 = new BitSet(new ulong[]{0x0000000000000000UL,0x000000000000000CUL});
		public static readonly BitSet _67_in_argDecl1359 = new BitSet(new ulong[]{0x0000000000380000UL});
		public static readonly BitSet _argTypeDecl_in_argDecl1362 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VAR_in_argDecl1368 = new BitSet(new ulong[]{0x0002000000000000UL});
		public static readonly BitSet _partArgDecl_in_argDecl1370 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000008UL});
		public static readonly BitSet _67_in_argDecl1371 = new BitSet(new ulong[]{0x0000000000380000UL});
		public static readonly BitSet _argTypeDecl_in_argDecl1374 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _argDecl_in_argDeclManyW1395 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000004UL});
		public static readonly BitSet _66_in_argDeclManyW1397 = new BitSet(new ulong[]{0x0002000000040000UL});
		public static readonly BitSet _argDecl_in_argDeclManyW1400 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000004UL});
		public static readonly BitSet _argDeclManyW_in_argDeclMany1413 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _set_in_typeDecl0 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _typeDecl_in_varTypeDeclW1445 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _arrayDecl_in_varTypeDeclW1447 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _varTypeDeclW_in_varTypeDecl1460 = new BitSet(new ulong[]{0x0000800000000000UL});
		public static readonly BitSet _OP_END_in_varTypeDecl1462 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VARIABLE_in_varDecl21483 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000004UL});
		public static readonly BitSet _66_in_varDecl21485 = new BitSet(new ulong[]{0x0002000000000000UL});
		public static readonly BitSet _VARIABLE_in_varDecl21488 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000004UL});
		public static readonly BitSet _varDecl2_in_varDecl1498 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _varDecl_in_varDecl12W1508 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000008UL});
		public static readonly BitSet _67_in_varDecl12W1510 = new BitSet(new ulong[]{0x0000040000380000UL});
		public static readonly BitSet _varTypeDecl_in_varDecl12W1513 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VAR_in_varDeclW1525 = new BitSet(new ulong[]{0x0002000000000000UL});
		public static readonly BitSet _varDecl12W_in_varDeclW1528 = new BitSet(new ulong[]{0x0002000000000002UL});
		public static readonly BitSet _BEGIN_in_bodyExpr1554 = new BitSet(new ulong[]{0x000200000F4008A0UL,0x0000000000000001UL});
		public static readonly BitSet _bodyOper_in_bodyExpr1557 = new BitSet(new ulong[]{0x000200000F4008A0UL,0x0000000000000001UL});
		public static readonly BitSet _END_in_bodyExpr1560 = new BitSet(new ulong[]{0x0000800000000000UL});
		public static readonly BitSet _OP_END_in_bodyExpr1563 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _funcDeclare_in_func_proc_expr1585 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _procedureDeclare_in_func_proc_expr1587 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _func_proc_expr_in_fpExprW1596 = new BitSet(new ulong[]{0x0000000000000302UL});
		public static readonly BitSet _PROGRAM_in_expr1615 = new BitSet(new ulong[]{0x0002000000000000UL});
		public static readonly BitSet _VARIABLE_in_expr1617 = new BitSet(new ulong[]{0x0000800000000000UL});
		public static readonly BitSet _OP_END_in_expr1619 = new BitSet(new ulong[]{0x0000000000040300UL});
		public static readonly BitSet _varDeclW_in_expr1622 = new BitSet(new ulong[]{0x0000000000040300UL});
		public static readonly BitSet _fpExprW_in_expr1625 = new BitSet(new ulong[]{0x0000000000000400UL});
		public static readonly BitSet _bodyExpr_in_expr1627 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _expr_in_program1652 = new BitSet(new ulong[]{0x0000000000000012UL});
		public static readonly BitSet _program_in_result1661 = new BitSet(new ulong[]{0x0000000000000000UL});
		public static readonly BitSet _EOF_in_result1663 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _result_in_execute1680 = new BitSet(new ulong[]{0x0000000000000002UL});

	}
	#endregion Follow sets
}
}