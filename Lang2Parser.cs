// $ANTLR 3.3 Nov 30, 2010 12:50:56 Lang2.g 2017-01-04 14:36:51

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
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "PROGRAM", "WHILE", "DO", "FOR", "FUNCTION", "PROCEDURE", "BEGIN", "END", "THEN", "ELSE", "DIV", "MOD", "NOT", "TO", "VAR", "T_CHAR", "T_BOOL", "T_INT", "T_STRING", "IF", "BOOLEAN", "CHAR", "INT", "STRING", "FALSE", "TRUE", "VAR_DECL", "BODY_EXPR", "VAR_EXPR", "FUNC_PROC_EXPR", "PROC_DECL", "FUNC_DECL", "FUNC_CALL", "FUNC_CALL_ARGS", "FUNC_PROC_ARGS", "FUNC_PROC_RET_TYPE", "TYPE_DECL", "BOOL_MULT", "BOOL_ADD", "CONDITION", "ARRAY", "OF", "ARR_DECL", "RANGE", "ARR_CALL", "OP_END", "WS", "VARIABLE", "ADD", "REM", "MULT", "DIVIDE", "ASSIGN", "GREATER", "LESS", "EQUAL", "LESS_OR_EQUAL", "GREATER_OR_EQUAL", "MORE", "'['", "'..'", "']'", "'('", "')'", "','", "':'"
	};
	public const int EOF=-1;
	public const int T__63=63;
	public const int T__64=64;
	public const int T__65=65;
	public const int T__66=66;
	public const int T__67=67;
	public const int T__68=68;
	public const int T__69=69;
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
	public const int T_STRING=22;
	public const int IF=23;
	public const int BOOLEAN=24;
	public const int CHAR=25;
	public const int INT=26;
	public const int STRING=27;
	public const int FALSE=28;
	public const int TRUE=29;
	public const int VAR_DECL=30;
	public const int BODY_EXPR=31;
	public const int VAR_EXPR=32;
	public const int FUNC_PROC_EXPR=33;
	public const int PROC_DECL=34;
	public const int FUNC_DECL=35;
	public const int FUNC_CALL=36;
	public const int FUNC_CALL_ARGS=37;
	public const int FUNC_PROC_ARGS=38;
	public const int FUNC_PROC_RET_TYPE=39;
	public const int TYPE_DECL=40;
	public const int BOOL_MULT=41;
	public const int BOOL_ADD=42;
	public const int CONDITION=43;
	public const int ARRAY=44;
	public const int OF=45;
	public const int ARR_DECL=46;
	public const int RANGE=47;
	public const int ARR_CALL=48;
	public const int OP_END=49;
	public const int WS=50;
	public const int VARIABLE=51;
	public const int ADD=52;
	public const int REM=53;
	public const int MULT=54;
	public const int DIVIDE=55;
	public const int ASSIGN=56;
	public const int GREATER=57;
	public const int LESS=58;
	public const int EQUAL=59;
	public const int LESS_OR_EQUAL=60;
	public const int GREATER_OR_EQUAL=61;
	public const int MORE=62;

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
				false
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
    // Lang2.g:89:1: arrayRange : '[' expressions '..' expressions ']' -> ^( RANGE expressions expressions ) ;
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
        RewriteRuleITokenStream stream_64=new RewriteRuleITokenStream(adaptor,"token 64");
        RewriteRuleITokenStream stream_65=new RewriteRuleITokenStream(adaptor,"token 65");
        RewriteRuleITokenStream stream_63=new RewriteRuleITokenStream(adaptor,"token 63");
        RewriteRuleSubtreeStream stream_expressions=new RewriteRuleSubtreeStream(adaptor,"rule expressions");
    	try { DebugEnterRule(GrammarFileName, "arrayRange");
    	DebugLocation(89, 3);
    	try
    	{
    		// Lang2.g:89:12: ( '[' expressions '..' expressions ']' -> ^( RANGE expressions expressions ) )
    		DebugEnterAlt(1);
    		// Lang2.g:89:14: '[' expressions '..' expressions ']'
    		{
    		DebugLocation(89, 14);
    		char_literal1=(IToken)Match(input,63,Follow._63_in_arrayRange479);  
    		stream_63.Add(char_literal1);

    		DebugLocation(89, 17);
    		PushFollow(Follow._expressions_in_arrayRange480);
    		expressions2=expressions();
    		PopFollow();

    		stream_expressions.Add(expressions2.Tree);
    		DebugLocation(89, 29);
    		string_literal3=(IToken)Match(input,64,Follow._64_in_arrayRange482);  
    		stream_64.Add(string_literal3);

    		DebugLocation(89, 34);
    		PushFollow(Follow._expressions_in_arrayRange484);
    		expressions4=expressions();
    		PopFollow();

    		stream_expressions.Add(expressions4.Tree);
    		DebugLocation(89, 45);
    		char_literal5=(IToken)Match(input,65,Follow._65_in_arrayRange485);  
    		stream_65.Add(char_literal5);



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
    		// 89:49: -> ^( RANGE expressions expressions )
    		{
    			DebugLocation(89, 52);
    			// Lang2.g:89:52: ^( RANGE expressions expressions )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(89, 54);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(RANGE, "RANGE"), root_1);

    			DebugLocation(89, 60);
    			adaptor.AddChild(root_1, stream_expressions.NextTree());
    			DebugLocation(89, 72);
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
    // Lang2.g:91:1: arrayTypeDecl : OF typeDecl -> ^( TYPE_DECL typeDecl ) ;
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
    	DebugLocation(91, 4);
    	try
    	{
    		// Lang2.g:91:15: ( OF typeDecl -> ^( TYPE_DECL typeDecl ) )
    		DebugEnterAlt(1);
    		// Lang2.g:91:17: OF typeDecl
    		{
    		DebugLocation(91, 17);
    		OF6=(IToken)Match(input,OF,Follow._OF_in_arrayTypeDecl506);  
    		stream_OF.Add(OF6);

    		DebugLocation(91, 20);
    		PushFollow(Follow._typeDecl_in_arrayTypeDecl508);
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
    		// 91:29: -> ^( TYPE_DECL typeDecl )
    		{
    			DebugLocation(91, 32);
    			// Lang2.g:91:32: ^( TYPE_DECL typeDecl )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(91, 34);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(TYPE_DECL, "TYPE_DECL"), root_1);

    			DebugLocation(91, 44);
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
     	DebugLocation(92, 4);
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
    // Lang2.g:93:1: arrayDecl : ARRAY arrayRange arrayTypeDecl -> ^( ARR_DECL arrayRange arrayTypeDecl ) ;
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
    	DebugLocation(93, 3);
    	try
    	{
    		// Lang2.g:93:11: ( ARRAY arrayRange arrayTypeDecl -> ^( ARR_DECL arrayRange arrayTypeDecl ) )
    		DebugEnterAlt(1);
    		// Lang2.g:93:14: ARRAY arrayRange arrayTypeDecl
    		{
    		DebugLocation(93, 14);
    		ARRAY8=(IToken)Match(input,ARRAY,Follow._ARRAY_in_arrayDecl529);  
    		stream_ARRAY.Add(ARRAY8);

    		DebugLocation(93, 20);
    		PushFollow(Follow._arrayRange_in_arrayDecl531);
    		arrayRange9=arrayRange();
    		PopFollow();

    		stream_arrayRange.Add(arrayRange9.Tree);
    		DebugLocation(93, 31);
    		PushFollow(Follow._arrayTypeDecl_in_arrayDecl533);
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
    		// 93:45: -> ^( ARR_DECL arrayRange arrayTypeDecl )
    		{
    			DebugLocation(93, 48);
    			// Lang2.g:93:48: ^( ARR_DECL arrayRange arrayTypeDecl )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(93, 50);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARR_DECL, "ARR_DECL"), root_1);

    			DebugLocation(93, 59);
    			adaptor.AddChild(root_1, stream_arrayRange.NextTree());
    			DebugLocation(93, 70);
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
     	DebugLocation(94, 3);
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
    // Lang2.g:96:1: arrayCall : VARIABLE '[' expressions ']' -> ^( ARR_CALL VARIABLE expressions ) ;
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
        RewriteRuleITokenStream stream_65=new RewriteRuleITokenStream(adaptor,"token 65");
        RewriteRuleITokenStream stream_63=new RewriteRuleITokenStream(adaptor,"token 63");
        RewriteRuleSubtreeStream stream_expressions=new RewriteRuleSubtreeStream(adaptor,"rule expressions");
    	try { DebugEnterRule(GrammarFileName, "arrayCall");
    	DebugLocation(96, 3);
    	try
    	{
    		// Lang2.g:96:11: ( VARIABLE '[' expressions ']' -> ^( ARR_CALL VARIABLE expressions ) )
    		DebugEnterAlt(1);
    		// Lang2.g:96:13: VARIABLE '[' expressions ']'
    		{
    		DebugLocation(96, 13);
    		VARIABLE11=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_arrayCall556);  
    		stream_VARIABLE.Add(VARIABLE11);

    		DebugLocation(96, 22);
    		char_literal12=(IToken)Match(input,63,Follow._63_in_arrayCall558);  
    		stream_63.Add(char_literal12);

    		DebugLocation(96, 25);
    		PushFollow(Follow._expressions_in_arrayCall559);
    		expressions13=expressions();
    		PopFollow();

    		stream_expressions.Add(expressions13.Tree);
    		DebugLocation(96, 36);
    		char_literal14=(IToken)Match(input,65,Follow._65_in_arrayCall560);  
    		stream_65.Add(char_literal14);



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
    		// 96:40: -> ^( ARR_CALL VARIABLE expressions )
    		{
    			DebugLocation(96, 43);
    			// Lang2.g:96:43: ^( ARR_CALL VARIABLE expressions )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(96, 45);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARR_CALL, "ARR_CALL"), root_1);

    			DebugLocation(96, 54);
    			adaptor.AddChild(root_1, stream_VARIABLE.NextNode());
    			DebugLocation(96, 63);
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
     	DebugLocation(97, 3);
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
    // Lang2.g:124:1: boolOperator : ( MORE | LESS | EQUAL | LESS_OR_EQUAL | GREATER_OR_EQUAL | GREATER );
    [GrammarRule("boolOperator")]
    private Lang2Parser.boolOperator_return boolOperator()
    {

        Lang2Parser.boolOperator_return retval = new Lang2Parser.boolOperator_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken set15=null;

        object set15_tree=null;

    	try { DebugEnterRule(GrammarFileName, "boolOperator");
    	DebugLocation(124, 3);
    	try
    	{
    		// Lang2.g:124:13: ( MORE | LESS | EQUAL | LESS_OR_EQUAL | GREATER_OR_EQUAL | GREATER )
    		DebugEnterAlt(1);
    		// Lang2.g:
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(124, 13);
    		set15=(IToken)input.LT(1);
    		if ((input.LA(1)>=GREATER && input.LA(1)<=MORE))
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
     	DebugLocation(125, 3);
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
    // Lang2.g:128:1: mathGroup : ( '(' expressions ')' | INT | CHAR | BOOLEAN | STRING | VARIABLE | funcCall );
    [GrammarRule("mathGroup")]
    private Lang2Parser.mathGroup_return mathGroup()
    {

        Lang2Parser.mathGroup_return retval = new Lang2Parser.mathGroup_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken char_literal16=null;
        IToken char_literal18=null;
        IToken INT19=null;
        IToken CHAR20=null;
        IToken BOOLEAN21=null;
        IToken STRING22=null;
        IToken VARIABLE23=null;
        Lang2Parser.expressions_return expressions17 = default(Lang2Parser.expressions_return);
        Lang2Parser.funcCall_return funcCall24 = default(Lang2Parser.funcCall_return);

        object char_literal16_tree=null;
        object char_literal18_tree=null;
        object INT19_tree=null;
        object CHAR20_tree=null;
        object BOOLEAN21_tree=null;
        object STRING22_tree=null;
        object VARIABLE23_tree=null;

    	try { DebugEnterRule(GrammarFileName, "mathGroup");
    	DebugLocation(128, 2);
    	try
    	{
    		// Lang2.g:128:11: ( '(' expressions ')' | INT | CHAR | BOOLEAN | STRING | VARIABLE | funcCall )
    		int alt1=7;
    		try { DebugEnterDecision(1, decisionCanBacktrack[1]);
    		switch (input.LA(1))
    		{
    		case 66:
    			{
    			alt1=1;
    			}
    			break;
    		case INT:
    			{
    			alt1=2;
    			}
    			break;
    		case CHAR:
    			{
    			alt1=3;
    			}
    			break;
    		case BOOLEAN:
    			{
    			alt1=4;
    			}
    			break;
    		case STRING:
    			{
    			alt1=5;
    			}
    			break;
    		case VARIABLE:
    			{
    			int LA1_6 = input.LA(2);

    			if ((LA1_6==66))
    			{
    				alt1=7;
    			}
    			else if ((LA1_6==EOF||LA1_6==DO||LA1_6==THEN||(LA1_6>=DIV && LA1_6<=TO)||(LA1_6>=BOOL_MULT && LA1_6<=BOOL_ADD)||LA1_6==OP_END||(LA1_6>=ADD && LA1_6<=DIVIDE)||(LA1_6>=GREATER && LA1_6<=MORE)||(LA1_6>=64 && LA1_6<=65)||(LA1_6>=67 && LA1_6<=68)))
    			{
    				alt1=6;
    			}
    			else
    			{
    				NoViableAltException nvae = new NoViableAltException("", 1, 6, input);

    				DebugRecognitionException(nvae);
    				throw nvae;
    			}
    			}
    			break;
    		default:
    			{
    				NoViableAltException nvae = new NoViableAltException("", 1, 0, input);

    				DebugRecognitionException(nvae);
    				throw nvae;
    			}
    		}

    		} finally { DebugExitDecision(1); }
    		switch (alt1)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Lang2.g:128:13: '(' expressions ')'
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(128, 16);
    			char_literal16=(IToken)Match(input,66,Follow._66_in_mathGroup712); 
    			DebugLocation(128, 17);
    			PushFollow(Follow._expressions_in_mathGroup714);
    			expressions17=expressions();
    			PopFollow();

    			adaptor.AddChild(root_0, expressions17.Tree);
    			DebugLocation(128, 31);
    			char_literal18=(IToken)Match(input,67,Follow._67_in_mathGroup715); 

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Lang2.g:129:5: INT
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(129, 5);
    			INT19=(IToken)Match(input,INT,Follow._INT_in_mathGroup722); 
    			INT19_tree = (object)adaptor.Create(INT19);
    			adaptor.AddChild(root_0, INT19_tree);


    			}
    			break;
    		case 3:
    			DebugEnterAlt(3);
    			// Lang2.g:130:5: CHAR
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(130, 5);
    			CHAR20=(IToken)Match(input,CHAR,Follow._CHAR_in_mathGroup728); 
    			CHAR20_tree = (object)adaptor.Create(CHAR20);
    			adaptor.AddChild(root_0, CHAR20_tree);


    			}
    			break;
    		case 4:
    			DebugEnterAlt(4);
    			// Lang2.g:131:5: BOOLEAN
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(131, 5);
    			BOOLEAN21=(IToken)Match(input,BOOLEAN,Follow._BOOLEAN_in_mathGroup734); 
    			BOOLEAN21_tree = (object)adaptor.Create(BOOLEAN21);
    			adaptor.AddChild(root_0, BOOLEAN21_tree);


    			}
    			break;
    		case 5:
    			DebugEnterAlt(5);
    			// Lang2.g:132:5: STRING
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(132, 5);
    			STRING22=(IToken)Match(input,STRING,Follow._STRING_in_mathGroup741); 
    			STRING22_tree = (object)adaptor.Create(STRING22);
    			adaptor.AddChild(root_0, STRING22_tree);


    			}
    			break;
    		case 6:
    			DebugEnterAlt(6);
    			// Lang2.g:133:5: VARIABLE
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(133, 5);
    			VARIABLE23=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_mathGroup747); 
    			VARIABLE23_tree = (object)adaptor.Create(VARIABLE23);
    			adaptor.AddChild(root_0, VARIABLE23_tree);


    			}
    			break;
    		case 7:
    			DebugEnterAlt(7);
    			// Lang2.g:134:5: funcCall
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(134, 5);
    			PushFollow(Follow._funcCall_in_mathGroup753);
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
     	DebugLocation(135, 2);
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
    // Lang2.g:138:1: boolMult : mathGroup ( BOOL_MULT mathGroup )* ;
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
    	DebugLocation(138, 3);
    	try
    	{
    		// Lang2.g:138:10: ( mathGroup ( BOOL_MULT mathGroup )* )
    		DebugEnterAlt(1);
    		// Lang2.g:138:12: mathGroup ( BOOL_MULT mathGroup )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(138, 12);
    		PushFollow(Follow._mathGroup_in_boolMult765);
    		mathGroup25=mathGroup();
    		PopFollow();

    		adaptor.AddChild(root_0, mathGroup25.Tree);
    		DebugLocation(138, 21);
    		// Lang2.g:138:21: ( BOOL_MULT mathGroup )*
    		try { DebugEnterSubRule(2);
    		while (true)
    		{
    			int alt2=2;
    			try { DebugEnterDecision(2, decisionCanBacktrack[2]);
    			int LA2_0 = input.LA(1);

    			if ((LA2_0==BOOL_MULT))
    			{
    				alt2=1;
    			}


    			} finally { DebugExitDecision(2); }
    			switch ( alt2 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:138:22: BOOL_MULT mathGroup
    				{
    				DebugLocation(138, 31);
    				BOOL_MULT26=(IToken)Match(input,BOOL_MULT,Follow._BOOL_MULT_in_boolMult767); 
    				BOOL_MULT26_tree = (object)adaptor.Create(BOOL_MULT26);
    				root_0 = (object)adaptor.BecomeRoot(BOOL_MULT26_tree, root_0);

    				DebugLocation(138, 33);
    				PushFollow(Follow._mathGroup_in_boolMult770);
    				mathGroup27=mathGroup();
    				PopFollow();

    				adaptor.AddChild(root_0, mathGroup27.Tree);

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
        }
     	DebugLocation(139, 3);
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
    // Lang2.g:141:1: boolAdd : boolMult ( BOOL_ADD boolMult )* ;
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
    	DebugLocation(141, 2);
    	try
    	{
    		// Lang2.g:141:9: ( boolMult ( BOOL_ADD boolMult )* )
    		DebugEnterAlt(1);
    		// Lang2.g:141:11: boolMult ( BOOL_ADD boolMult )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(141, 11);
    		PushFollow(Follow._boolMult_in_boolAdd784);
    		boolMult28=boolMult();
    		PopFollow();

    		adaptor.AddChild(root_0, boolMult28.Tree);
    		DebugLocation(141, 19);
    		// Lang2.g:141:19: ( BOOL_ADD boolMult )*
    		try { DebugEnterSubRule(3);
    		while (true)
    		{
    			int alt3=2;
    			try { DebugEnterDecision(3, decisionCanBacktrack[3]);
    			int LA3_0 = input.LA(1);

    			if ((LA3_0==BOOL_ADD))
    			{
    				alt3=1;
    			}


    			} finally { DebugExitDecision(3); }
    			switch ( alt3 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:141:20: BOOL_ADD boolMult
    				{
    				DebugLocation(141, 28);
    				BOOL_ADD29=(IToken)Match(input,BOOL_ADD,Follow._BOOL_ADD_in_boolAdd786); 
    				BOOL_ADD29_tree = (object)adaptor.Create(BOOL_ADD29);
    				root_0 = (object)adaptor.BecomeRoot(BOOL_ADD29_tree, root_0);

    				DebugLocation(141, 30);
    				PushFollow(Follow._boolMult_in_boolAdd789);
    				boolMult30=boolMult();
    				PopFollow();

    				adaptor.AddChild(root_0, boolMult30.Tree);

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
     	DebugLocation(142, 2);
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
    // Lang2.g:144:1: boolElse : boolAdd ( boolOperator boolAdd )* ;
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
    	DebugLocation(144, 3);
    	try
    	{
    		// Lang2.g:144:10: ( boolAdd ( boolOperator boolAdd )* )
    		DebugEnterAlt(1);
    		// Lang2.g:144:12: boolAdd ( boolOperator boolAdd )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(144, 12);
    		PushFollow(Follow._boolAdd_in_boolElse802);
    		boolAdd31=boolAdd();
    		PopFollow();

    		adaptor.AddChild(root_0, boolAdd31.Tree);
    		DebugLocation(144, 19);
    		// Lang2.g:144:19: ( boolOperator boolAdd )*
    		try { DebugEnterSubRule(4);
    		while (true)
    		{
    			int alt4=2;
    			try { DebugEnterDecision(4, decisionCanBacktrack[4]);
    			int LA4_0 = input.LA(1);

    			if (((LA4_0>=GREATER && LA4_0<=MORE)))
    			{
    				alt4=1;
    			}


    			} finally { DebugExitDecision(4); }
    			switch ( alt4 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:144:20: boolOperator boolAdd
    				{
    				DebugLocation(144, 32);
    				PushFollow(Follow._boolOperator_in_boolElse804);
    				boolOperator32=boolOperator();
    				PopFollow();

    				root_0 = (object)adaptor.BecomeRoot(boolOperator32.Tree, root_0);
    				DebugLocation(144, 34);
    				PushFollow(Follow._boolAdd_in_boolElse807);
    				boolAdd33=boolAdd();
    				PopFollow();

    				adaptor.AddChild(root_0, boolAdd33.Tree);

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
     	DebugLocation(145, 3);
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
    // Lang2.g:147:1: boolNegative : boolElse ( NOT boolElse )* ;
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
    	DebugLocation(147, 3);
    	try
    	{
    		// Lang2.g:147:14: ( boolElse ( NOT boolElse )* )
    		DebugEnterAlt(1);
    		// Lang2.g:147:16: boolElse ( NOT boolElse )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(147, 16);
    		PushFollow(Follow._boolElse_in_boolNegative821);
    		boolElse34=boolElse();
    		PopFollow();

    		adaptor.AddChild(root_0, boolElse34.Tree);
    		DebugLocation(147, 25);
    		// Lang2.g:147:25: ( NOT boolElse )*
    		try { DebugEnterSubRule(5);
    		while (true)
    		{
    			int alt5=2;
    			try { DebugEnterDecision(5, decisionCanBacktrack[5]);
    			int LA5_0 = input.LA(1);

    			if ((LA5_0==NOT))
    			{
    				alt5=1;
    			}


    			} finally { DebugExitDecision(5); }
    			switch ( alt5 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:147:26: NOT boolElse
    				{
    				DebugLocation(147, 29);
    				NOT35=(IToken)Match(input,NOT,Follow._NOT_in_boolNegative824); 
    				NOT35_tree = (object)adaptor.Create(NOT35);
    				root_0 = (object)adaptor.BecomeRoot(NOT35_tree, root_0);

    				DebugLocation(147, 31);
    				PushFollow(Follow._boolElse_in_boolNegative827);
    				boolElse36=boolElse();
    				PopFollow();

    				adaptor.AddChild(root_0, boolElse36.Tree);

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
     	DebugLocation(148, 3);
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
    // Lang2.g:150:1: useDiv : boolNegative ( ( DIV | MOD ) '(' boolNegative ')' )* ;
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
    	DebugLocation(150, 2);
    	try
    	{
    		// Lang2.g:150:8: ( boolNegative ( ( DIV | MOD ) '(' boolNegative ')' )* )
    		DebugEnterAlt(1);
    		// Lang2.g:150:10: boolNegative ( ( DIV | MOD ) '(' boolNegative ')' )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(150, 10);
    		PushFollow(Follow._boolNegative_in_useDiv841);
    		boolNegative37=boolNegative();
    		PopFollow();

    		adaptor.AddChild(root_0, boolNegative37.Tree);
    		DebugLocation(150, 22);
    		// Lang2.g:150:22: ( ( DIV | MOD ) '(' boolNegative ')' )*
    		try { DebugEnterSubRule(6);
    		while (true)
    		{
    			int alt6=2;
    			try { DebugEnterDecision(6, decisionCanBacktrack[6]);
    			int LA6_0 = input.LA(1);

    			if (((LA6_0>=DIV && LA6_0<=MOD)))
    			{
    				alt6=1;
    			}


    			} finally { DebugExitDecision(6); }
    			switch ( alt6 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:150:23: ( DIV | MOD ) '(' boolNegative ')'
    				{
    				DebugLocation(150, 23);
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

    				DebugLocation(150, 37);
    				char_literal39=(IToken)Match(input,66,Follow._66_in_useDiv850); 
    				DebugLocation(150, 39);
    				PushFollow(Follow._boolNegative_in_useDiv853);
    				boolNegative40=boolNegative();
    				PopFollow();

    				adaptor.AddChild(root_0, boolNegative40.Tree);
    				DebugLocation(150, 55);
    				char_literal41=(IToken)Match(input,67,Follow._67_in_useDiv855); 

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
     	DebugLocation(151, 2);
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
    // Lang2.g:153:1: mathMult : useDiv ( ( MULT | DIVIDE ) useDiv )* ;
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
    	DebugLocation(153, 1);
    	try
    	{
    		// Lang2.g:154:2: ( useDiv ( ( MULT | DIVIDE ) useDiv )* )
    		DebugEnterAlt(1);
    		// Lang2.g:154:4: useDiv ( ( MULT | DIVIDE ) useDiv )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(154, 4);
    		PushFollow(Follow._useDiv_in_mathMult872);
    		useDiv42=useDiv();
    		PopFollow();

    		adaptor.AddChild(root_0, useDiv42.Tree);
    		DebugLocation(154, 10);
    		// Lang2.g:154:10: ( ( MULT | DIVIDE ) useDiv )*
    		try { DebugEnterSubRule(7);
    		while (true)
    		{
    			int alt7=2;
    			try { DebugEnterDecision(7, decisionCanBacktrack[7]);
    			int LA7_0 = input.LA(1);

    			if (((LA7_0>=MULT && LA7_0<=DIVIDE)))
    			{
    				alt7=1;
    			}


    			} finally { DebugExitDecision(7); }
    			switch ( alt7 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:154:11: ( MULT | DIVIDE ) useDiv
    				{
    				DebugLocation(154, 11);
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

    				DebugLocation(154, 25);
    				PushFollow(Follow._useDiv_in_mathMult880);
    				useDiv44=useDiv();
    				PopFollow();

    				adaptor.AddChild(root_0, useDiv44.Tree);

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
     	DebugLocation(155, 1);
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
    // Lang2.g:157:1: mathAdd : mathMult ( ( ADD | REM ) mathMult )* ;
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
    	DebugLocation(157, 1);
    	try
    	{
    		// Lang2.g:157:9: ( mathMult ( ( ADD | REM ) mathMult )* )
    		DebugEnterAlt(1);
    		// Lang2.g:157:11: mathMult ( ( ADD | REM ) mathMult )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(157, 11);
    		PushFollow(Follow._mathMult_in_mathAdd893);
    		mathMult45=mathMult();
    		PopFollow();

    		adaptor.AddChild(root_0, mathMult45.Tree);
    		DebugLocation(157, 19);
    		// Lang2.g:157:19: ( ( ADD | REM ) mathMult )*
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
    				// Lang2.g:157:20: ( ADD | REM ) mathMult
    				{
    				DebugLocation(157, 20);
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

    				DebugLocation(157, 30);
    				PushFollow(Follow._mathMult_in_mathAdd901);
    				mathMult47=mathMult();
    				PopFollow();

    				adaptor.AddChild(root_0, mathMult47.Tree);

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
     	DebugLocation(158, 1);
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
    // Lang2.g:160:1: mathExpr : mathAdd ;
    [GrammarRule("mathExpr")]
    private Lang2Parser.mathExpr_return mathExpr()
    {

        Lang2Parser.mathExpr_return retval = new Lang2Parser.mathExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.mathAdd_return mathAdd48 = default(Lang2Parser.mathAdd_return);


    	try { DebugEnterRule(GrammarFileName, "mathExpr");
    	DebugLocation(160, 1);
    	try
    	{
    		// Lang2.g:161:2: ( mathAdd )
    		DebugEnterAlt(1);
    		// Lang2.g:161:4: mathAdd
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(161, 4);
    		PushFollow(Follow._mathAdd_in_mathExpr915);
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
     	DebugLocation(163, 1);
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
    // Lang2.g:167:1: bodyOper : ( assExpr OP_END | conditionExpr | loopExpr | funcCall OP_END );
    [GrammarRule("bodyOper")]
    private Lang2Parser.bodyOper_return bodyOper()
    {

        Lang2Parser.bodyOper_return retval = new Lang2Parser.bodyOper_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken OP_END50=null;
        IToken OP_END54=null;
        Lang2Parser.assExpr_return assExpr49 = default(Lang2Parser.assExpr_return);
        Lang2Parser.conditionExpr_return conditionExpr51 = default(Lang2Parser.conditionExpr_return);
        Lang2Parser.loopExpr_return loopExpr52 = default(Lang2Parser.loopExpr_return);
        Lang2Parser.funcCall_return funcCall53 = default(Lang2Parser.funcCall_return);

        object OP_END50_tree=null;
        object OP_END54_tree=null;

    	try { DebugEnterRule(GrammarFileName, "bodyOper");
    	DebugLocation(167, 4);
    	try
    	{
    		// Lang2.g:167:10: ( assExpr OP_END | conditionExpr | loopExpr | funcCall OP_END )
    		int alt9=4;
    		try { DebugEnterDecision(9, decisionCanBacktrack[9]);
    		switch (input.LA(1))
    		{
    		case VARIABLE:
    			{
    			int LA9_1 = input.LA(2);

    			if ((LA9_1==ASSIGN||LA9_1==63))
    			{
    				alt9=1;
    			}
    			else if ((LA9_1==66))
    			{
    				alt9=4;
    			}
    			else
    			{
    				NoViableAltException nvae = new NoViableAltException("", 9, 1, input);

    				DebugRecognitionException(nvae);
    				throw nvae;
    			}
    			}
    			break;
    		case IF:
    			{
    			alt9=2;
    			}
    			break;
    		case WHILE:
    		case FOR:
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
    			// Lang2.g:167:12: assExpr OP_END
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(167, 12);
    			PushFollow(Follow._assExpr_in_bodyOper930);
    			assExpr49=assExpr();
    			PopFollow();

    			adaptor.AddChild(root_0, assExpr49.Tree);
    			DebugLocation(167, 26);
    			OP_END50=(IToken)Match(input,OP_END,Follow._OP_END_in_bodyOper932); 

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Lang2.g:168:6: conditionExpr
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(168, 6);
    			PushFollow(Follow._conditionExpr_in_bodyOper940);
    			conditionExpr51=conditionExpr();
    			PopFollow();

    			adaptor.AddChild(root_0, conditionExpr51.Tree);

    			}
    			break;
    		case 3:
    			DebugEnterAlt(3);
    			// Lang2.g:169:6: loopExpr
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(169, 6);
    			PushFollow(Follow._loopExpr_in_bodyOper947);
    			loopExpr52=loopExpr();
    			PopFollow();

    			adaptor.AddChild(root_0, loopExpr52.Tree);

    			}
    			break;
    		case 4:
    			DebugEnterAlt(4);
    			// Lang2.g:170:6: funcCall OP_END
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(170, 6);
    			PushFollow(Follow._funcCall_in_bodyOper954);
    			funcCall53=funcCall();
    			PopFollow();

    			adaptor.AddChild(root_0, funcCall53.Tree);
    			DebugLocation(170, 21);
    			OP_END54=(IToken)Match(input,OP_END,Follow._OP_END_in_bodyOper956); 

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
     	DebugLocation(171, 4);
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
    // Lang2.g:173:1: expressions : ( mathExpr | arrayCall );
    [GrammarRule("expressions")]
    private Lang2Parser.expressions_return expressions()
    {

        Lang2Parser.expressions_return retval = new Lang2Parser.expressions_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.mathExpr_return mathExpr55 = default(Lang2Parser.mathExpr_return);
        Lang2Parser.arrayCall_return arrayCall56 = default(Lang2Parser.arrayCall_return);


    	try { DebugEnterRule(GrammarFileName, "expressions");
    	DebugLocation(173, 4);
    	try
    	{
    		// Lang2.g:173:13: ( mathExpr | arrayCall )
    		int alt10=2;
    		try { DebugEnterDecision(10, decisionCanBacktrack[10]);
    		int LA10_0 = input.LA(1);

    		if (((LA10_0>=BOOLEAN && LA10_0<=STRING)||LA10_0==66))
    		{
    			alt10=1;
    		}
    		else if ((LA10_0==VARIABLE))
    		{
    			int LA10_2 = input.LA(2);

    			if ((LA10_2==DO||LA10_2==THEN||(LA10_2>=DIV && LA10_2<=TO)||(LA10_2>=BOOL_MULT && LA10_2<=BOOL_ADD)||LA10_2==OP_END||(LA10_2>=ADD && LA10_2<=DIVIDE)||(LA10_2>=GREATER && LA10_2<=MORE)||(LA10_2>=64 && LA10_2<=67)))
    			{
    				alt10=1;
    			}
    			else if ((LA10_2==63))
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
    		else
    		{
    			NoViableAltException nvae = new NoViableAltException("", 10, 0, input);

    			DebugRecognitionException(nvae);
    			throw nvae;
    		}
    		} finally { DebugExitDecision(10); }
    		switch (alt10)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Lang2.g:173:15: mathExpr
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(173, 15);
    			PushFollow(Follow._mathExpr_in_expressions970);
    			mathExpr55=mathExpr();
    			PopFollow();

    			adaptor.AddChild(root_0, mathExpr55.Tree);

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Lang2.g:174:6: arrayCall
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(174, 6);
    			PushFollow(Follow._arrayCall_in_expressions977);
    			arrayCall56=arrayCall();
    			PopFollow();

    			adaptor.AddChild(root_0, arrayCall56.Tree);

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
     	DebugLocation(175, 4);
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
    // Lang2.g:177:1: funcCallArgs : mathExpr ( ',' mathExpr )* ;
    [GrammarRule("funcCallArgs")]
    private Lang2Parser.funcCallArgs_return funcCallArgs()
    {

        Lang2Parser.funcCallArgs_return retval = new Lang2Parser.funcCallArgs_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken char_literal58=null;
        Lang2Parser.mathExpr_return mathExpr57 = default(Lang2Parser.mathExpr_return);
        Lang2Parser.mathExpr_return mathExpr59 = default(Lang2Parser.mathExpr_return);

        object char_literal58_tree=null;

    	try { DebugEnterRule(GrammarFileName, "funcCallArgs");
    	DebugLocation(177, 4);
    	try
    	{
    		// Lang2.g:177:14: ( mathExpr ( ',' mathExpr )* )
    		DebugEnterAlt(1);
    		// Lang2.g:177:17: mathExpr ( ',' mathExpr )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(177, 17);
    		PushFollow(Follow._mathExpr_in_funcCallArgs991);
    		mathExpr57=mathExpr();
    		PopFollow();

    		adaptor.AddChild(root_0, mathExpr57.Tree);
    		DebugLocation(177, 25);
    		// Lang2.g:177:25: ( ',' mathExpr )*
    		try { DebugEnterSubRule(11);
    		while (true)
    		{
    			int alt11=2;
    			try { DebugEnterDecision(11, decisionCanBacktrack[11]);
    			int LA11_0 = input.LA(1);

    			if ((LA11_0==68))
    			{
    				alt11=1;
    			}


    			} finally { DebugExitDecision(11); }
    			switch ( alt11 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:177:26: ',' mathExpr
    				{
    				DebugLocation(177, 29);
    				char_literal58=(IToken)Match(input,68,Follow._68_in_funcCallArgs993); 
    				DebugLocation(177, 31);
    				PushFollow(Follow._mathExpr_in_funcCallArgs996);
    				mathExpr59=mathExpr();
    				PopFollow();

    				adaptor.AddChild(root_0, mathExpr59.Tree);

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
     	DebugLocation(178, 4);
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
    // Lang2.g:179:1: funcCallArgsW : mathExpr ( ',' mathExpr )* -> ^( FUNC_CALL_ARGS mathExpr ( mathExpr )* ) ;
    [GrammarRule("funcCallArgsW")]
    private Lang2Parser.funcCallArgsW_return funcCallArgsW()
    {

        Lang2Parser.funcCallArgsW_return retval = new Lang2Parser.funcCallArgsW_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken char_literal61=null;
        Lang2Parser.mathExpr_return mathExpr60 = default(Lang2Parser.mathExpr_return);
        Lang2Parser.mathExpr_return mathExpr62 = default(Lang2Parser.mathExpr_return);

        object char_literal61_tree=null;
        RewriteRuleITokenStream stream_68=new RewriteRuleITokenStream(adaptor,"token 68");
        RewriteRuleSubtreeStream stream_mathExpr=new RewriteRuleSubtreeStream(adaptor,"rule mathExpr");
    	try { DebugEnterRule(GrammarFileName, "funcCallArgsW");
    	DebugLocation(179, 4);
    	try
    	{
    		// Lang2.g:179:15: ( mathExpr ( ',' mathExpr )* -> ^( FUNC_CALL_ARGS mathExpr ( mathExpr )* ) )
    		DebugEnterAlt(1);
    		// Lang2.g:179:17: mathExpr ( ',' mathExpr )*
    		{
    		DebugLocation(179, 17);
    		PushFollow(Follow._mathExpr_in_funcCallArgsW1011);
    		mathExpr60=mathExpr();
    		PopFollow();

    		stream_mathExpr.Add(mathExpr60.Tree);
    		DebugLocation(179, 25);
    		// Lang2.g:179:25: ( ',' mathExpr )*
    		try { DebugEnterSubRule(12);
    		while (true)
    		{
    			int alt12=2;
    			try { DebugEnterDecision(12, decisionCanBacktrack[12]);
    			int LA12_0 = input.LA(1);

    			if ((LA12_0==68))
    			{
    				alt12=1;
    			}


    			} finally { DebugExitDecision(12); }
    			switch ( alt12 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:179:26: ',' mathExpr
    				{
    				DebugLocation(179, 26);
    				char_literal61=(IToken)Match(input,68,Follow._68_in_funcCallArgsW1013);  
    				stream_68.Add(char_literal61);

    				DebugLocation(179, 30);
    				PushFollow(Follow._mathExpr_in_funcCallArgsW1015);
    				mathExpr62=mathExpr();
    				PopFollow();

    				stream_mathExpr.Add(mathExpr62.Tree);

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
    		// elements: mathExpr, mathExpr
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 179:41: -> ^( FUNC_CALL_ARGS mathExpr ( mathExpr )* )
    		{
    			DebugLocation(179, 44);
    			// Lang2.g:179:44: ^( FUNC_CALL_ARGS mathExpr ( mathExpr )* )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(179, 46);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_CALL_ARGS, "FUNC_CALL_ARGS"), root_1);

    			DebugLocation(179, 61);
    			adaptor.AddChild(root_1, stream_mathExpr.NextTree());
    			DebugLocation(179, 70);
    			// Lang2.g:179:70: ( mathExpr )*
    			while ( stream_mathExpr.HasNext )
    			{
    				DebugLocation(179, 70);
    				adaptor.AddChild(root_1, stream_mathExpr.NextTree());

    			}
    			stream_mathExpr.Reset();

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
     	DebugLocation(180, 4);
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
    // Lang2.g:182:1: funcCall : VARIABLE '(' ( funcCallArgsW )? ')' -> ^( FUNC_CALL VARIABLE ( funcCallArgsW )? ) ;
    [GrammarRule("funcCall")]
    private Lang2Parser.funcCall_return funcCall()
    {

        Lang2Parser.funcCall_return retval = new Lang2Parser.funcCall_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken VARIABLE63=null;
        IToken char_literal64=null;
        IToken char_literal66=null;
        Lang2Parser.funcCallArgsW_return funcCallArgsW65 = default(Lang2Parser.funcCallArgsW_return);

        object VARIABLE63_tree=null;
        object char_literal64_tree=null;
        object char_literal66_tree=null;
        RewriteRuleITokenStream stream_67=new RewriteRuleITokenStream(adaptor,"token 67");
        RewriteRuleITokenStream stream_66=new RewriteRuleITokenStream(adaptor,"token 66");
        RewriteRuleITokenStream stream_VARIABLE=new RewriteRuleITokenStream(adaptor,"token VARIABLE");
        RewriteRuleSubtreeStream stream_funcCallArgsW=new RewriteRuleSubtreeStream(adaptor,"rule funcCallArgsW");
    	try { DebugEnterRule(GrammarFileName, "funcCall");
    	DebugLocation(182, 3);
    	try
    	{
    		// Lang2.g:182:10: ( VARIABLE '(' ( funcCallArgsW )? ')' -> ^( FUNC_CALL VARIABLE ( funcCallArgsW )? ) )
    		DebugEnterAlt(1);
    		// Lang2.g:182:12: VARIABLE '(' ( funcCallArgsW )? ')'
    		{
    		DebugLocation(182, 12);
    		VARIABLE63=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_funcCall1041);  
    		stream_VARIABLE.Add(VARIABLE63);

    		DebugLocation(182, 20);
    		char_literal64=(IToken)Match(input,66,Follow._66_in_funcCall1042);  
    		stream_66.Add(char_literal64);

    		DebugLocation(182, 24);
    		// Lang2.g:182:24: ( funcCallArgsW )?
    		int alt13=2;
    		try { DebugEnterSubRule(13);
    		try { DebugEnterDecision(13, decisionCanBacktrack[13]);
    		int LA13_0 = input.LA(1);

    		if (((LA13_0>=BOOLEAN && LA13_0<=STRING)||LA13_0==VARIABLE||LA13_0==66))
    		{
    			alt13=1;
    		}
    		} finally { DebugExitDecision(13); }
    		switch (alt13)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Lang2.g:182:24: funcCallArgsW
    			{
    			DebugLocation(182, 24);
    			PushFollow(Follow._funcCallArgsW_in_funcCall1044);
    			funcCallArgsW65=funcCallArgsW();
    			PopFollow();

    			stream_funcCallArgsW.Add(funcCallArgsW65.Tree);

    			}
    			break;

    		}
    		} finally { DebugExitSubRule(13); }

    		DebugLocation(182, 39);
    		char_literal66=(IToken)Match(input,67,Follow._67_in_funcCall1047);  
    		stream_67.Add(char_literal66);



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
    		// 182:43: -> ^( FUNC_CALL VARIABLE ( funcCallArgsW )? )
    		{
    			DebugLocation(182, 46);
    			// Lang2.g:182:46: ^( FUNC_CALL VARIABLE ( funcCallArgsW )? )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(182, 48);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_CALL, "FUNC_CALL"), root_1);

    			DebugLocation(182, 58);
    			adaptor.AddChild(root_1, stream_VARIABLE.NextNode());
    			DebugLocation(182, 67);
    			// Lang2.g:182:67: ( funcCallArgsW )?
    			if ( stream_funcCallArgsW.HasNext )
    			{
    				DebugLocation(182, 67);
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
     	DebugLocation(183, 3);
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
    // Lang2.g:185:1: argDeclExpr : '(' ( argDeclMany )? ')' -> ^( FUNC_PROC_ARGS ( argDeclMany )? ) ;
    [GrammarRule("argDeclExpr")]
    private Lang2Parser.argDeclExpr_return argDeclExpr()
    {

        Lang2Parser.argDeclExpr_return retval = new Lang2Parser.argDeclExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken char_literal67=null;
        IToken char_literal69=null;
        Lang2Parser.argDeclMany_return argDeclMany68 = default(Lang2Parser.argDeclMany_return);

        object char_literal67_tree=null;
        object char_literal69_tree=null;
        RewriteRuleITokenStream stream_67=new RewriteRuleITokenStream(adaptor,"token 67");
        RewriteRuleITokenStream stream_66=new RewriteRuleITokenStream(adaptor,"token 66");
        RewriteRuleSubtreeStream stream_argDeclMany=new RewriteRuleSubtreeStream(adaptor,"rule argDeclMany");
    	try { DebugEnterRule(GrammarFileName, "argDeclExpr");
    	DebugLocation(185, 3);
    	try
    	{
    		// Lang2.g:185:13: ( '(' ( argDeclMany )? ')' -> ^( FUNC_PROC_ARGS ( argDeclMany )? ) )
    		DebugEnterAlt(1);
    		// Lang2.g:185:15: '(' ( argDeclMany )? ')'
    		{
    		DebugLocation(185, 18);
    		char_literal67=(IToken)Match(input,66,Follow._66_in_argDeclExpr1071);  
    		stream_66.Add(char_literal67);

    		DebugLocation(185, 20);
    		// Lang2.g:185:20: ( argDeclMany )?
    		int alt14=2;
    		try { DebugEnterSubRule(14);
    		try { DebugEnterDecision(14, decisionCanBacktrack[14]);
    		int LA14_0 = input.LA(1);

    		if ((LA14_0==VAR||LA14_0==VARIABLE))
    		{
    			alt14=1;
    		}
    		} finally { DebugExitDecision(14); }
    		switch (alt14)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Lang2.g:185:20: argDeclMany
    			{
    			DebugLocation(185, 20);
    			PushFollow(Follow._argDeclMany_in_argDeclExpr1074);
    			argDeclMany68=argDeclMany();
    			PopFollow();

    			stream_argDeclMany.Add(argDeclMany68.Tree);

    			}
    			break;

    		}
    		} finally { DebugExitSubRule(14); }

    		DebugLocation(185, 36);
    		char_literal69=(IToken)Match(input,67,Follow._67_in_argDeclExpr1077);  
    		stream_67.Add(char_literal69);



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
    		// 185:38: -> ^( FUNC_PROC_ARGS ( argDeclMany )? )
    		{
    			DebugLocation(185, 41);
    			// Lang2.g:185:41: ^( FUNC_PROC_ARGS ( argDeclMany )? )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(185, 43);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_PROC_ARGS, "FUNC_PROC_ARGS"), root_1);

    			DebugLocation(185, 58);
    			// Lang2.g:185:58: ( argDeclMany )?
    			if ( stream_argDeclMany.HasNext )
    			{
    				DebugLocation(185, 58);
    				adaptor.AddChild(root_1, stream_argDeclMany.NextTree());

    			}
    			stream_argDeclMany.Reset();

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
     	DebugLocation(186, 3);
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
    // Lang2.g:188:1: retTypeExpr : ( T_INT | T_BOOL | T_CHAR | arrayDecl | T_STRING ) ;
    [GrammarRule("retTypeExpr")]
    private Lang2Parser.retTypeExpr_return retTypeExpr()
    {

        Lang2Parser.retTypeExpr_return retval = new Lang2Parser.retTypeExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken T_INT70=null;
        IToken T_BOOL71=null;
        IToken T_CHAR72=null;
        IToken T_STRING74=null;
        Lang2Parser.arrayDecl_return arrayDecl73 = default(Lang2Parser.arrayDecl_return);

        object T_INT70_tree=null;
        object T_BOOL71_tree=null;
        object T_CHAR72_tree=null;
        object T_STRING74_tree=null;

    	try { DebugEnterRule(GrammarFileName, "retTypeExpr");
    	DebugLocation(188, 3);
    	try
    	{
    		// Lang2.g:188:13: ( ( T_INT | T_BOOL | T_CHAR | arrayDecl | T_STRING ) )
    		DebugEnterAlt(1);
    		// Lang2.g:188:15: ( T_INT | T_BOOL | T_CHAR | arrayDecl | T_STRING )
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(188, 15);
    		// Lang2.g:188:15: ( T_INT | T_BOOL | T_CHAR | arrayDecl | T_STRING )
    		int alt15=5;
    		try { DebugEnterSubRule(15);
    		try { DebugEnterDecision(15, decisionCanBacktrack[15]);
    		switch (input.LA(1))
    		{
    		case T_INT:
    			{
    			alt15=1;
    			}
    			break;
    		case T_BOOL:
    			{
    			alt15=2;
    			}
    			break;
    		case T_CHAR:
    			{
    			alt15=3;
    			}
    			break;
    		case ARRAY:
    			{
    			alt15=4;
    			}
    			break;
    		case T_STRING:
    			{
    			alt15=5;
    			}
    			break;
    		default:
    			{
    				NoViableAltException nvae = new NoViableAltException("", 15, 0, input);

    				DebugRecognitionException(nvae);
    				throw nvae;
    			}
    		}

    		} finally { DebugExitDecision(15); }
    		switch (alt15)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Lang2.g:188:16: T_INT
    			{
    			DebugLocation(188, 16);
    			T_INT70=(IToken)Match(input,T_INT,Follow._T_INT_in_retTypeExpr1100); 
    			T_INT70_tree = (object)adaptor.Create(T_INT70);
    			adaptor.AddChild(root_0, T_INT70_tree);


    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Lang2.g:188:22: T_BOOL
    			{
    			DebugLocation(188, 22);
    			T_BOOL71=(IToken)Match(input,T_BOOL,Follow._T_BOOL_in_retTypeExpr1102); 
    			T_BOOL71_tree = (object)adaptor.Create(T_BOOL71);
    			adaptor.AddChild(root_0, T_BOOL71_tree);


    			}
    			break;
    		case 3:
    			DebugEnterAlt(3);
    			// Lang2.g:188:29: T_CHAR
    			{
    			DebugLocation(188, 29);
    			T_CHAR72=(IToken)Match(input,T_CHAR,Follow._T_CHAR_in_retTypeExpr1104); 
    			T_CHAR72_tree = (object)adaptor.Create(T_CHAR72);
    			adaptor.AddChild(root_0, T_CHAR72_tree);


    			}
    			break;
    		case 4:
    			DebugEnterAlt(4);
    			// Lang2.g:188:36: arrayDecl
    			{
    			DebugLocation(188, 36);
    			PushFollow(Follow._arrayDecl_in_retTypeExpr1106);
    			arrayDecl73=arrayDecl();
    			PopFollow();

    			adaptor.AddChild(root_0, arrayDecl73.Tree);

    			}
    			break;
    		case 5:
    			DebugEnterAlt(5);
    			// Lang2.g:188:46: T_STRING
    			{
    			DebugLocation(188, 46);
    			T_STRING74=(IToken)Match(input,T_STRING,Follow._T_STRING_in_retTypeExpr1108); 
    			T_STRING74_tree = (object)adaptor.Create(T_STRING74);
    			adaptor.AddChild(root_0, T_STRING74_tree);


    			}
    			break;

    		}
    		} finally { DebugExitSubRule(15); }


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
     	DebugLocation(189, 3);
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
    // Lang2.g:191:1: retTypeExprWrap : retTypeExpr -> ^( FUNC_PROC_RET_TYPE retTypeExpr ) ;
    [GrammarRule("retTypeExprWrap")]
    private Lang2Parser.retTypeExprWrap_return retTypeExprWrap()
    {

        Lang2Parser.retTypeExprWrap_return retval = new Lang2Parser.retTypeExprWrap_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.retTypeExpr_return retTypeExpr75 = default(Lang2Parser.retTypeExpr_return);

        RewriteRuleSubtreeStream stream_retTypeExpr=new RewriteRuleSubtreeStream(adaptor,"rule retTypeExpr");
    	try { DebugEnterRule(GrammarFileName, "retTypeExprWrap");
    	DebugLocation(191, 4);
    	try
    	{
    		// Lang2.g:191:17: ( retTypeExpr -> ^( FUNC_PROC_RET_TYPE retTypeExpr ) )
    		DebugEnterAlt(1);
    		// Lang2.g:191:19: retTypeExpr
    		{
    		DebugLocation(191, 19);
    		PushFollow(Follow._retTypeExpr_in_retTypeExprWrap1121);
    		retTypeExpr75=retTypeExpr();
    		PopFollow();

    		stream_retTypeExpr.Add(retTypeExpr75.Tree);


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
    		// 191:31: -> ^( FUNC_PROC_RET_TYPE retTypeExpr )
    		{
    			DebugLocation(191, 34);
    			// Lang2.g:191:34: ^( FUNC_PROC_RET_TYPE retTypeExpr )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(191, 36);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_PROC_RET_TYPE, "FUNC_PROC_RET_TYPE"), root_1);

    			DebugLocation(191, 55);
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
     	DebugLocation(192, 4);
    	} finally { DebugExitRule(GrammarFileName, "retTypeExprWrap"); }
    	return retval;

    }
    // $ANTLR end "retTypeExprWrap"

    public class bodyFuncProcExpr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_bodyFuncProcExpr() {}
    protected virtual void Leave_bodyFuncProcExpr() {}

    // $ANTLR start "bodyFuncProcExpr"
    // Lang2.g:194:1: bodyFuncProcExpr : ( varDeclW )? bodyExpr ;
    [GrammarRule("bodyFuncProcExpr")]
    private Lang2Parser.bodyFuncProcExpr_return bodyFuncProcExpr()
    {

        Lang2Parser.bodyFuncProcExpr_return retval = new Lang2Parser.bodyFuncProcExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.varDeclW_return varDeclW76 = default(Lang2Parser.varDeclW_return);
        Lang2Parser.bodyExpr_return bodyExpr77 = default(Lang2Parser.bodyExpr_return);


    	try { DebugEnterRule(GrammarFileName, "bodyFuncProcExpr");
    	DebugLocation(194, 5);
    	try
    	{
    		// Lang2.g:194:18: ( ( varDeclW )? bodyExpr )
    		DebugEnterAlt(1);
    		// Lang2.g:194:20: ( varDeclW )? bodyExpr
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(194, 20);
    		// Lang2.g:194:20: ( varDeclW )?
    		int alt16=2;
    		try { DebugEnterSubRule(16);
    		try { DebugEnterDecision(16, decisionCanBacktrack[16]);
    		int LA16_0 = input.LA(1);

    		if ((LA16_0==VAR))
    		{
    			alt16=1;
    		}
    		} finally { DebugExitDecision(16); }
    		switch (alt16)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Lang2.g:194:20: varDeclW
    			{
    			DebugLocation(194, 20);
    			PushFollow(Follow._varDeclW_in_bodyFuncProcExpr1142);
    			varDeclW76=varDeclW();
    			PopFollow();

    			adaptor.AddChild(root_0, varDeclW76.Tree);

    			}
    			break;

    		}
    		} finally { DebugExitSubRule(16); }

    		DebugLocation(194, 30);
    		PushFollow(Follow._bodyExpr_in_bodyFuncProcExpr1145);
    		bodyExpr77=bodyExpr();
    		PopFollow();

    		adaptor.AddChild(root_0, bodyExpr77.Tree);

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
     	DebugLocation(195, 5);
    	} finally { DebugExitRule(GrammarFileName, "bodyFuncProcExpr"); }
    	return retval;

    }
    // $ANTLR end "bodyFuncProcExpr"

    public class funcDeclare_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_funcDeclare() {}
    protected virtual void Leave_funcDeclare() {}

    // $ANTLR start "funcDeclare"
    // Lang2.g:197:1: funcDeclare : FUNCTION VARIABLE argDeclExpr ':' retTypeExprWrap OP_END bodyFuncProcExpr -> ^( FUNC_DECL VARIABLE argDeclExpr retTypeExprWrap bodyFuncProcExpr ) ;
    [GrammarRule("funcDeclare")]
    private Lang2Parser.funcDeclare_return funcDeclare()
    {

        Lang2Parser.funcDeclare_return retval = new Lang2Parser.funcDeclare_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken FUNCTION78=null;
        IToken VARIABLE79=null;
        IToken char_literal81=null;
        IToken OP_END83=null;
        Lang2Parser.argDeclExpr_return argDeclExpr80 = default(Lang2Parser.argDeclExpr_return);
        Lang2Parser.retTypeExprWrap_return retTypeExprWrap82 = default(Lang2Parser.retTypeExprWrap_return);
        Lang2Parser.bodyFuncProcExpr_return bodyFuncProcExpr84 = default(Lang2Parser.bodyFuncProcExpr_return);

        object FUNCTION78_tree=null;
        object VARIABLE79_tree=null;
        object char_literal81_tree=null;
        object OP_END83_tree=null;
        RewriteRuleITokenStream stream_FUNCTION=new RewriteRuleITokenStream(adaptor,"token FUNCTION");
        RewriteRuleITokenStream stream_69=new RewriteRuleITokenStream(adaptor,"token 69");
        RewriteRuleITokenStream stream_VARIABLE=new RewriteRuleITokenStream(adaptor,"token VARIABLE");
        RewriteRuleITokenStream stream_OP_END=new RewriteRuleITokenStream(adaptor,"token OP_END");
        RewriteRuleSubtreeStream stream_argDeclExpr=new RewriteRuleSubtreeStream(adaptor,"rule argDeclExpr");
        RewriteRuleSubtreeStream stream_bodyFuncProcExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodyFuncProcExpr");
        RewriteRuleSubtreeStream stream_retTypeExprWrap=new RewriteRuleSubtreeStream(adaptor,"rule retTypeExprWrap");
    	try { DebugEnterRule(GrammarFileName, "funcDeclare");
    	DebugLocation(197, 3);
    	try
    	{
    		// Lang2.g:197:12: ( FUNCTION VARIABLE argDeclExpr ':' retTypeExprWrap OP_END bodyFuncProcExpr -> ^( FUNC_DECL VARIABLE argDeclExpr retTypeExprWrap bodyFuncProcExpr ) )
    		DebugEnterAlt(1);
    		// Lang2.g:197:14: FUNCTION VARIABLE argDeclExpr ':' retTypeExprWrap OP_END bodyFuncProcExpr
    		{
    		DebugLocation(197, 14);
    		FUNCTION78=(IToken)Match(input,FUNCTION,Follow._FUNCTION_in_funcDeclare1158);  
    		stream_FUNCTION.Add(FUNCTION78);

    		DebugLocation(197, 23);
    		VARIABLE79=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_funcDeclare1160);  
    		stream_VARIABLE.Add(VARIABLE79);

    		DebugLocation(197, 32);
    		PushFollow(Follow._argDeclExpr_in_funcDeclare1162);
    		argDeclExpr80=argDeclExpr();
    		PopFollow();

    		stream_argDeclExpr.Add(argDeclExpr80.Tree);
    		DebugLocation(197, 43);
    		char_literal81=(IToken)Match(input,69,Follow._69_in_funcDeclare1163);  
    		stream_69.Add(char_literal81);

    		DebugLocation(197, 47);
    		PushFollow(Follow._retTypeExprWrap_in_funcDeclare1165);
    		retTypeExprWrap82=retTypeExprWrap();
    		PopFollow();

    		stream_retTypeExprWrap.Add(retTypeExprWrap82.Tree);
    		DebugLocation(197, 69);
    		OP_END83=(IToken)Match(input,OP_END,Follow._OP_END_in_funcDeclare1167);  
    		stream_OP_END.Add(OP_END83);

    		DebugLocation(197, 72);
    		PushFollow(Follow._bodyFuncProcExpr_in_funcDeclare1171);
    		bodyFuncProcExpr84=bodyFuncProcExpr();
    		PopFollow();

    		stream_bodyFuncProcExpr.Add(bodyFuncProcExpr84.Tree);


    		{
    		// AST REWRITE
    		// elements: VARIABLE, retTypeExprWrap, argDeclExpr, bodyFuncProcExpr
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 197:89: -> ^( FUNC_DECL VARIABLE argDeclExpr retTypeExprWrap bodyFuncProcExpr )
    		{
    			DebugLocation(197, 92);
    			// Lang2.g:197:92: ^( FUNC_DECL VARIABLE argDeclExpr retTypeExprWrap bodyFuncProcExpr )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(197, 94);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_DECL, "FUNC_DECL"), root_1);

    			DebugLocation(197, 104);
    			adaptor.AddChild(root_1, stream_VARIABLE.NextNode());
    			DebugLocation(197, 113);
    			adaptor.AddChild(root_1, stream_argDeclExpr.NextTree());
    			DebugLocation(197, 125);
    			adaptor.AddChild(root_1, stream_retTypeExprWrap.NextTree());
    			DebugLocation(197, 141);
    			adaptor.AddChild(root_1, stream_bodyFuncProcExpr.NextTree());

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
     	DebugLocation(198, 3);
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
    // Lang2.g:200:1: procedureDeclare : PROCEDURE VARIABLE argDeclExpr OP_END bodyFuncProcExpr -> ^( PROC_DECL VARIABLE argDeclExpr bodyFuncProcExpr ) ;
    [GrammarRule("procedureDeclare")]
    private Lang2Parser.procedureDeclare_return procedureDeclare()
    {

        Lang2Parser.procedureDeclare_return retval = new Lang2Parser.procedureDeclare_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken PROCEDURE85=null;
        IToken VARIABLE86=null;
        IToken OP_END88=null;
        Lang2Parser.argDeclExpr_return argDeclExpr87 = default(Lang2Parser.argDeclExpr_return);
        Lang2Parser.bodyFuncProcExpr_return bodyFuncProcExpr89 = default(Lang2Parser.bodyFuncProcExpr_return);

        object PROCEDURE85_tree=null;
        object VARIABLE86_tree=null;
        object OP_END88_tree=null;
        RewriteRuleITokenStream stream_VARIABLE=new RewriteRuleITokenStream(adaptor,"token VARIABLE");
        RewriteRuleITokenStream stream_OP_END=new RewriteRuleITokenStream(adaptor,"token OP_END");
        RewriteRuleITokenStream stream_PROCEDURE=new RewriteRuleITokenStream(adaptor,"token PROCEDURE");
        RewriteRuleSubtreeStream stream_argDeclExpr=new RewriteRuleSubtreeStream(adaptor,"rule argDeclExpr");
        RewriteRuleSubtreeStream stream_bodyFuncProcExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodyFuncProcExpr");
    	try { DebugEnterRule(GrammarFileName, "procedureDeclare");
    	DebugLocation(200, 4);
    	try
    	{
    		// Lang2.g:200:17: ( PROCEDURE VARIABLE argDeclExpr OP_END bodyFuncProcExpr -> ^( PROC_DECL VARIABLE argDeclExpr bodyFuncProcExpr ) )
    		DebugEnterAlt(1);
    		// Lang2.g:200:19: PROCEDURE VARIABLE argDeclExpr OP_END bodyFuncProcExpr
    		{
    		DebugLocation(200, 19);
    		PROCEDURE85=(IToken)Match(input,PROCEDURE,Follow._PROCEDURE_in_procedureDeclare1196);  
    		stream_PROCEDURE.Add(PROCEDURE85);

    		DebugLocation(200, 29);
    		VARIABLE86=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_procedureDeclare1198);  
    		stream_VARIABLE.Add(VARIABLE86);

    		DebugLocation(200, 38);
    		PushFollow(Follow._argDeclExpr_in_procedureDeclare1200);
    		argDeclExpr87=argDeclExpr();
    		PopFollow();

    		stream_argDeclExpr.Add(argDeclExpr87.Tree);
    		DebugLocation(200, 50);
    		OP_END88=(IToken)Match(input,OP_END,Follow._OP_END_in_procedureDeclare1202);  
    		stream_OP_END.Add(OP_END88);

    		DebugLocation(200, 57);
    		PushFollow(Follow._bodyFuncProcExpr_in_procedureDeclare1204);
    		bodyFuncProcExpr89=bodyFuncProcExpr();
    		PopFollow();

    		stream_bodyFuncProcExpr.Add(bodyFuncProcExpr89.Tree);


    		{
    		// AST REWRITE
    		// elements: bodyFuncProcExpr, argDeclExpr, VARIABLE
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 200:74: -> ^( PROC_DECL VARIABLE argDeclExpr bodyFuncProcExpr )
    		{
    			DebugLocation(200, 77);
    			// Lang2.g:200:77: ^( PROC_DECL VARIABLE argDeclExpr bodyFuncProcExpr )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(200, 79);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PROC_DECL, "PROC_DECL"), root_1);

    			DebugLocation(200, 89);
    			adaptor.AddChild(root_1, stream_VARIABLE.NextNode());
    			DebugLocation(200, 98);
    			adaptor.AddChild(root_1, stream_argDeclExpr.NextTree());
    			DebugLocation(200, 110);
    			adaptor.AddChild(root_1, stream_bodyFuncProcExpr.NextTree());

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
     	DebugLocation(201, 4);
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
    // Lang2.g:205:1: conditionElseExpr : ELSE bodyExpr -> ^( ELSE bodyExpr ) ;
    [GrammarRule("conditionElseExpr")]
    private Lang2Parser.conditionElseExpr_return conditionElseExpr()
    {

        Lang2Parser.conditionElseExpr_return retval = new Lang2Parser.conditionElseExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken ELSE90=null;
        Lang2Parser.bodyExpr_return bodyExpr91 = default(Lang2Parser.bodyExpr_return);

        object ELSE90_tree=null;
        RewriteRuleITokenStream stream_ELSE=new RewriteRuleITokenStream(adaptor,"token ELSE");
        RewriteRuleSubtreeStream stream_bodyExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodyExpr");
    	try { DebugEnterRule(GrammarFileName, "conditionElseExpr");
    	DebugLocation(205, 5);
    	try
    	{
    		// Lang2.g:205:19: ( ELSE bodyExpr -> ^( ELSE bodyExpr ) )
    		DebugEnterAlt(1);
    		// Lang2.g:205:21: ELSE bodyExpr
    		{
    		DebugLocation(205, 25);
    		ELSE90=(IToken)Match(input,ELSE,Follow._ELSE_in_conditionElseExpr1231);  
    		stream_ELSE.Add(ELSE90);

    		DebugLocation(205, 27);
    		PushFollow(Follow._bodyExpr_in_conditionElseExpr1234);
    		bodyExpr91=bodyExpr();
    		PopFollow();

    		stream_bodyExpr.Add(bodyExpr91.Tree);


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
    		// 205:36: -> ^( ELSE bodyExpr )
    		{
    			DebugLocation(205, 39);
    			// Lang2.g:205:39: ^( ELSE bodyExpr )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(205, 41);
    			root_1 = (object)adaptor.BecomeRoot(stream_ELSE.NextNode(), root_1);

    			DebugLocation(205, 46);
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
     	DebugLocation(206, 5);
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
    // Lang2.g:207:1: condExpr : expressions -> ^( CONDITION expressions ) ;
    [GrammarRule("condExpr")]
    private Lang2Parser.condExpr_return condExpr()
    {

        Lang2Parser.condExpr_return retval = new Lang2Parser.condExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.expressions_return expressions92 = default(Lang2Parser.expressions_return);

        RewriteRuleSubtreeStream stream_expressions=new RewriteRuleSubtreeStream(adaptor,"rule expressions");
    	try { DebugEnterRule(GrammarFileName, "condExpr");
    	DebugLocation(207, 3);
    	try
    	{
    		// Lang2.g:207:10: ( expressions -> ^( CONDITION expressions ) )
    		DebugEnterAlt(1);
    		// Lang2.g:207:13: expressions
    		{
    		DebugLocation(207, 13);
    		PushFollow(Follow._expressions_in_condExpr1256);
    		expressions92=expressions();
    		PopFollow();

    		stream_expressions.Add(expressions92.Tree);


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
    		// 207:26: -> ^( CONDITION expressions )
    		{
    			DebugLocation(207, 29);
    			// Lang2.g:207:29: ^( CONDITION expressions )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(207, 31);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(CONDITION, "CONDITION"), root_1);

    			DebugLocation(207, 41);
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
     	DebugLocation(208, 3);
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
    // Lang2.g:209:1: conditionExpr : IF condExpr THEN bodyExpr ( conditionElseExpr )? -> ^( IF condExpr bodyExpr ( conditionElseExpr )? ) ;
    [GrammarRule("conditionExpr")]
    private Lang2Parser.conditionExpr_return conditionExpr()
    {

        Lang2Parser.conditionExpr_return retval = new Lang2Parser.conditionExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken IF93=null;
        IToken THEN95=null;
        Lang2Parser.condExpr_return condExpr94 = default(Lang2Parser.condExpr_return);
        Lang2Parser.bodyExpr_return bodyExpr96 = default(Lang2Parser.bodyExpr_return);
        Lang2Parser.conditionElseExpr_return conditionElseExpr97 = default(Lang2Parser.conditionElseExpr_return);

        object IF93_tree=null;
        object THEN95_tree=null;
        RewriteRuleITokenStream stream_THEN=new RewriteRuleITokenStream(adaptor,"token THEN");
        RewriteRuleITokenStream stream_IF=new RewriteRuleITokenStream(adaptor,"token IF");
        RewriteRuleSubtreeStream stream_condExpr=new RewriteRuleSubtreeStream(adaptor,"rule condExpr");
        RewriteRuleSubtreeStream stream_conditionElseExpr=new RewriteRuleSubtreeStream(adaptor,"rule conditionElseExpr");
        RewriteRuleSubtreeStream stream_bodyExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodyExpr");
    	try { DebugEnterRule(GrammarFileName, "conditionExpr");
    	DebugLocation(209, 1);
    	try
    	{
    		// Lang2.g:209:14: ( IF condExpr THEN bodyExpr ( conditionElseExpr )? -> ^( IF condExpr bodyExpr ( conditionElseExpr )? ) )
    		DebugEnterAlt(1);
    		// Lang2.g:209:16: IF condExpr THEN bodyExpr ( conditionElseExpr )?
    		{
    		DebugLocation(209, 16);
    		IF93=(IToken)Match(input,IF,Follow._IF_in_conditionExpr1275);  
    		stream_IF.Add(IF93);

    		DebugLocation(209, 19);
    		PushFollow(Follow._condExpr_in_conditionExpr1277);
    		condExpr94=condExpr();
    		PopFollow();

    		stream_condExpr.Add(condExpr94.Tree);
    		DebugLocation(209, 32);
    		THEN95=(IToken)Match(input,THEN,Follow._THEN_in_conditionExpr1279);  
    		stream_THEN.Add(THEN95);

    		DebugLocation(209, 34);
    		PushFollow(Follow._bodyExpr_in_conditionExpr1282);
    		bodyExpr96=bodyExpr();
    		PopFollow();

    		stream_bodyExpr.Add(bodyExpr96.Tree);
    		DebugLocation(209, 43);
    		// Lang2.g:209:43: ( conditionElseExpr )?
    		int alt17=2;
    		try { DebugEnterSubRule(17);
    		try { DebugEnterDecision(17, decisionCanBacktrack[17]);
    		int LA17_0 = input.LA(1);

    		if ((LA17_0==ELSE))
    		{
    			alt17=1;
    		}
    		} finally { DebugExitDecision(17); }
    		switch (alt17)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Lang2.g:209:43: conditionElseExpr
    			{
    			DebugLocation(209, 43);
    			PushFollow(Follow._conditionElseExpr_in_conditionExpr1284);
    			conditionElseExpr97=conditionElseExpr();
    			PopFollow();

    			stream_conditionElseExpr.Add(conditionElseExpr97.Tree);

    			}
    			break;

    		}
    		} finally { DebugExitSubRule(17); }



    		{
    		// AST REWRITE
    		// elements: bodyExpr, IF, conditionElseExpr, condExpr
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 209:62: -> ^( IF condExpr bodyExpr ( conditionElseExpr )? )
    		{
    			DebugLocation(209, 65);
    			// Lang2.g:209:65: ^( IF condExpr bodyExpr ( conditionElseExpr )? )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(209, 67);
    			root_1 = (object)adaptor.BecomeRoot(stream_IF.NextNode(), root_1);

    			DebugLocation(209, 70);
    			adaptor.AddChild(root_1, stream_condExpr.NextTree());
    			DebugLocation(209, 79);
    			adaptor.AddChild(root_1, stream_bodyExpr.NextTree());
    			DebugLocation(209, 88);
    			// Lang2.g:209:88: ( conditionElseExpr )?
    			if ( stream_conditionElseExpr.HasNext )
    			{
    				DebugLocation(209, 88);
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
     	DebugLocation(210, 1);
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
    // Lang2.g:213:1: forExpr : assExpr TO expressions ;
    [GrammarRule("forExpr")]
    private Lang2Parser.forExpr_return forExpr()
    {

        Lang2Parser.forExpr_return retval = new Lang2Parser.forExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken TO99=null;
        Lang2Parser.assExpr_return assExpr98 = default(Lang2Parser.assExpr_return);
        Lang2Parser.expressions_return expressions100 = default(Lang2Parser.expressions_return);

        object TO99_tree=null;

    	try { DebugEnterRule(GrammarFileName, "forExpr");
    	DebugLocation(213, 2);
    	try
    	{
    		// Lang2.g:213:9: ( assExpr TO expressions )
    		DebugEnterAlt(1);
    		// Lang2.g:213:12: assExpr TO expressions
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(213, 12);
    		PushFollow(Follow._assExpr_in_forExpr1310);
    		assExpr98=assExpr();
    		PopFollow();

    		adaptor.AddChild(root_0, assExpr98.Tree);
    		DebugLocation(213, 22);
    		TO99=(IToken)Match(input,TO,Follow._TO_in_forExpr1312); 
    		TO99_tree = (object)adaptor.Create(TO99);
    		root_0 = (object)adaptor.BecomeRoot(TO99_tree, root_0);

    		DebugLocation(213, 24);
    		PushFollow(Follow._expressions_in_forExpr1315);
    		expressions100=expressions();
    		PopFollow();

    		adaptor.AddChild(root_0, expressions100.Tree);

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
     	DebugLocation(214, 2);
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
    // Lang2.g:215:1: loopExpr : ( WHILE condExpr DO bodyExpr -> ^( WHILE condExpr bodyExpr ) | FOR forExpr DO bodyExpr -> ^( FOR forExpr bodyExpr ) );
    [GrammarRule("loopExpr")]
    private Lang2Parser.loopExpr_return loopExpr()
    {

        Lang2Parser.loopExpr_return retval = new Lang2Parser.loopExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken WHILE101=null;
        IToken DO103=null;
        IToken FOR105=null;
        IToken DO107=null;
        Lang2Parser.condExpr_return condExpr102 = default(Lang2Parser.condExpr_return);
        Lang2Parser.bodyExpr_return bodyExpr104 = default(Lang2Parser.bodyExpr_return);
        Lang2Parser.forExpr_return forExpr106 = default(Lang2Parser.forExpr_return);
        Lang2Parser.bodyExpr_return bodyExpr108 = default(Lang2Parser.bodyExpr_return);

        object WHILE101_tree=null;
        object DO103_tree=null;
        object FOR105_tree=null;
        object DO107_tree=null;
        RewriteRuleITokenStream stream_FOR=new RewriteRuleITokenStream(adaptor,"token FOR");
        RewriteRuleITokenStream stream_DO=new RewriteRuleITokenStream(adaptor,"token DO");
        RewriteRuleITokenStream stream_WHILE=new RewriteRuleITokenStream(adaptor,"token WHILE");
        RewriteRuleSubtreeStream stream_condExpr=new RewriteRuleSubtreeStream(adaptor,"rule condExpr");
        RewriteRuleSubtreeStream stream_bodyExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodyExpr");
        RewriteRuleSubtreeStream stream_forExpr=new RewriteRuleSubtreeStream(adaptor,"rule forExpr");
    	try { DebugEnterRule(GrammarFileName, "loopExpr");
    	DebugLocation(215, 2);
    	try
    	{
    		// Lang2.g:215:9: ( WHILE condExpr DO bodyExpr -> ^( WHILE condExpr bodyExpr ) | FOR forExpr DO bodyExpr -> ^( FOR forExpr bodyExpr ) )
    		int alt18=2;
    		try { DebugEnterDecision(18, decisionCanBacktrack[18]);
    		int LA18_0 = input.LA(1);

    		if ((LA18_0==WHILE))
    		{
    			alt18=1;
    		}
    		else if ((LA18_0==FOR))
    		{
    			alt18=2;
    		}
    		else
    		{
    			NoViableAltException nvae = new NoViableAltException("", 18, 0, input);

    			DebugRecognitionException(nvae);
    			throw nvae;
    		}
    		} finally { DebugExitDecision(18); }
    		switch (alt18)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Lang2.g:215:11: WHILE condExpr DO bodyExpr
    			{
    			DebugLocation(215, 11);
    			WHILE101=(IToken)Match(input,WHILE,Follow._WHILE_in_loopExpr1324);  
    			stream_WHILE.Add(WHILE101);

    			DebugLocation(215, 17);
    			PushFollow(Follow._condExpr_in_loopExpr1326);
    			condExpr102=condExpr();
    			PopFollow();

    			stream_condExpr.Add(condExpr102.Tree);
    			DebugLocation(215, 28);
    			DO103=(IToken)Match(input,DO,Follow._DO_in_loopExpr1328);  
    			stream_DO.Add(DO103);

    			DebugLocation(215, 30);
    			PushFollow(Follow._bodyExpr_in_loopExpr1331);
    			bodyExpr104=bodyExpr();
    			PopFollow();

    			stream_bodyExpr.Add(bodyExpr104.Tree);


    			{
    			// AST REWRITE
    			// elements: WHILE, condExpr, bodyExpr
    			// token labels: 
    			// rule labels: retval
    			// token list labels: 
    			// rule list labels: 
    			// wildcard labels: 
    			retval.Tree = root_0;
    			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    			root_0 = (object)adaptor.Nil();
    			// 215:39: -> ^( WHILE condExpr bodyExpr )
    			{
    				DebugLocation(215, 42);
    				// Lang2.g:215:42: ^( WHILE condExpr bodyExpr )
    				{
    				object root_1 = (object)adaptor.Nil();
    				DebugLocation(215, 44);
    				root_1 = (object)adaptor.BecomeRoot(stream_WHILE.NextNode(), root_1);

    				DebugLocation(215, 50);
    				adaptor.AddChild(root_1, stream_condExpr.NextTree());
    				DebugLocation(215, 59);
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
    			// Lang2.g:216:5: FOR forExpr DO bodyExpr
    			{
    			DebugLocation(216, 5);
    			FOR105=(IToken)Match(input,FOR,Follow._FOR_in_loopExpr1347);  
    			stream_FOR.Add(FOR105);

    			DebugLocation(216, 9);
    			PushFollow(Follow._forExpr_in_loopExpr1349);
    			forExpr106=forExpr();
    			PopFollow();

    			stream_forExpr.Add(forExpr106.Tree);
    			DebugLocation(216, 17);
    			DO107=(IToken)Match(input,DO,Follow._DO_in_loopExpr1351);  
    			stream_DO.Add(DO107);

    			DebugLocation(216, 20);
    			PushFollow(Follow._bodyExpr_in_loopExpr1353);
    			bodyExpr108=bodyExpr();
    			PopFollow();

    			stream_bodyExpr.Add(bodyExpr108.Tree);


    			{
    			// AST REWRITE
    			// elements: bodyExpr, forExpr, FOR
    			// token labels: 
    			// rule labels: retval
    			// token list labels: 
    			// rule list labels: 
    			// wildcard labels: 
    			retval.Tree = root_0;
    			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    			root_0 = (object)adaptor.Nil();
    			// 216:29: -> ^( FOR forExpr bodyExpr )
    			{
    				DebugLocation(216, 32);
    				// Lang2.g:216:32: ^( FOR forExpr bodyExpr )
    				{
    				object root_1 = (object)adaptor.Nil();
    				DebugLocation(216, 34);
    				root_1 = (object)adaptor.BecomeRoot(stream_FOR.NextNode(), root_1);

    				DebugLocation(216, 38);
    				adaptor.AddChild(root_1, stream_forExpr.NextTree());
    				DebugLocation(216, 46);
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
     	DebugLocation(217, 2);
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
    // Lang2.g:219:1: assExpr : ( VARIABLE ASSIGN expressions | arrayCall ASSIGN expressions );
    [GrammarRule("assExpr")]
    private Lang2Parser.assExpr_return assExpr()
    {

        Lang2Parser.assExpr_return retval = new Lang2Parser.assExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken VARIABLE109=null;
        IToken ASSIGN110=null;
        IToken ASSIGN113=null;
        Lang2Parser.expressions_return expressions111 = default(Lang2Parser.expressions_return);
        Lang2Parser.arrayCall_return arrayCall112 = default(Lang2Parser.arrayCall_return);
        Lang2Parser.expressions_return expressions114 = default(Lang2Parser.expressions_return);

        object VARIABLE109_tree=null;
        object ASSIGN110_tree=null;
        object ASSIGN113_tree=null;

    	try { DebugEnterRule(GrammarFileName, "assExpr");
    	DebugLocation(219, 1);
    	try
    	{
    		// Lang2.g:219:9: ( VARIABLE ASSIGN expressions | arrayCall ASSIGN expressions )
    		int alt19=2;
    		try { DebugEnterDecision(19, decisionCanBacktrack[19]);
    		int LA19_0 = input.LA(1);

    		if ((LA19_0==VARIABLE))
    		{
    			int LA19_1 = input.LA(2);

    			if ((LA19_1==ASSIGN))
    			{
    				alt19=1;
    			}
    			else if ((LA19_1==63))
    			{
    				alt19=2;
    			}
    			else
    			{
    				NoViableAltException nvae = new NoViableAltException("", 19, 1, input);

    				DebugRecognitionException(nvae);
    				throw nvae;
    			}
    		}
    		else
    		{
    			NoViableAltException nvae = new NoViableAltException("", 19, 0, input);

    			DebugRecognitionException(nvae);
    			throw nvae;
    		}
    		} finally { DebugExitDecision(19); }
    		switch (alt19)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Lang2.g:219:12: VARIABLE ASSIGN expressions
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(219, 12);
    			VARIABLE109=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_assExpr1376); 
    			VARIABLE109_tree = (object)adaptor.Create(VARIABLE109);
    			adaptor.AddChild(root_0, VARIABLE109_tree);

    			DebugLocation(219, 27);
    			ASSIGN110=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assExpr1378); 
    			ASSIGN110_tree = (object)adaptor.Create(ASSIGN110);
    			root_0 = (object)adaptor.BecomeRoot(ASSIGN110_tree, root_0);

    			DebugLocation(219, 29);
    			PushFollow(Follow._expressions_in_assExpr1381);
    			expressions111=expressions();
    			PopFollow();

    			adaptor.AddChild(root_0, expressions111.Tree);

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Lang2.g:220:5: arrayCall ASSIGN expressions
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(220, 5);
    			PushFollow(Follow._arrayCall_in_assExpr1387);
    			arrayCall112=arrayCall();
    			PopFollow();

    			adaptor.AddChild(root_0, arrayCall112.Tree);
    			DebugLocation(220, 21);
    			ASSIGN113=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assExpr1389); 
    			ASSIGN113_tree = (object)adaptor.Create(ASSIGN113);
    			root_0 = (object)adaptor.BecomeRoot(ASSIGN113_tree, root_0);

    			DebugLocation(220, 23);
    			PushFollow(Follow._expressions_in_assExpr1392);
    			expressions114=expressions();
    			PopFollow();

    			adaptor.AddChild(root_0, expressions114.Tree);

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
     	DebugLocation(221, 1);
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
    // Lang2.g:223:1: argTypeDecl : typeDecl -> ^( TYPE_DECL typeDecl ) ;
    [GrammarRule("argTypeDecl")]
    private Lang2Parser.argTypeDecl_return argTypeDecl()
    {

        Lang2Parser.argTypeDecl_return retval = new Lang2Parser.argTypeDecl_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.typeDecl_return typeDecl115 = default(Lang2Parser.typeDecl_return);

        RewriteRuleSubtreeStream stream_typeDecl=new RewriteRuleSubtreeStream(adaptor,"rule typeDecl");
    	try { DebugEnterRule(GrammarFileName, "argTypeDecl");
    	DebugLocation(223, 3);
    	try
    	{
    		// Lang2.g:223:13: ( typeDecl -> ^( TYPE_DECL typeDecl ) )
    		DebugEnterAlt(1);
    		// Lang2.g:223:15: typeDecl
    		{
    		DebugLocation(223, 15);
    		PushFollow(Follow._typeDecl_in_argTypeDecl1402);
    		typeDecl115=typeDecl();
    		PopFollow();

    		stream_typeDecl.Add(typeDecl115.Tree);


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
    		// 223:24: -> ^( TYPE_DECL typeDecl )
    		{
    			DebugLocation(223, 27);
    			// Lang2.g:223:27: ^( TYPE_DECL typeDecl )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(223, 29);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(TYPE_DECL, "TYPE_DECL"), root_1);

    			DebugLocation(223, 39);
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
     	DebugLocation(224, 3);
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
    // Lang2.g:226:1: partArgDecl : VARIABLE ( ',' VARIABLE )* ;
    [GrammarRule("partArgDecl")]
    private Lang2Parser.partArgDecl_return partArgDecl()
    {

        Lang2Parser.partArgDecl_return retval = new Lang2Parser.partArgDecl_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken VARIABLE116=null;
        IToken char_literal117=null;
        IToken VARIABLE118=null;

        object VARIABLE116_tree=null;
        object char_literal117_tree=null;
        object VARIABLE118_tree=null;

    	try { DebugEnterRule(GrammarFileName, "partArgDecl");
    	DebugLocation(226, 37);
    	try
    	{
    		// Lang2.g:226:12: ( VARIABLE ( ',' VARIABLE )* )
    		DebugEnterAlt(1);
    		// Lang2.g:226:14: VARIABLE ( ',' VARIABLE )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(226, 14);
    		VARIABLE116=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_partArgDecl1421); 
    		VARIABLE116_tree = (object)adaptor.Create(VARIABLE116);
    		adaptor.AddChild(root_0, VARIABLE116_tree);

    		DebugLocation(226, 22);
    		// Lang2.g:226:22: ( ',' VARIABLE )*
    		try { DebugEnterSubRule(20);
    		while (true)
    		{
    			int alt20=2;
    			try { DebugEnterDecision(20, decisionCanBacktrack[20]);
    			int LA20_0 = input.LA(1);

    			if ((LA20_0==68))
    			{
    				alt20=1;
    			}


    			} finally { DebugExitDecision(20); }
    			switch ( alt20 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:226:23: ',' VARIABLE
    				{
    				DebugLocation(226, 26);
    				char_literal117=(IToken)Match(input,68,Follow._68_in_partArgDecl1423); 
    				DebugLocation(226, 28);
    				VARIABLE118=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_partArgDecl1426); 
    				VARIABLE118_tree = (object)adaptor.Create(VARIABLE118);
    				adaptor.AddChild(root_0, VARIABLE118_tree);


    				}
    				break;

    			default:
    				goto loop20;
    			}
    		}

    		loop20:
    			;

    		} finally { DebugExitSubRule(20); }


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
     	DebugLocation(226, 37);
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
    // Lang2.g:228:1: argDecl : ( VARIABLE ( ',' VARIABLE )* ':' argTypeDecl | VAR partArgDecl ':' argTypeDecl -> ^( VAR partArgDecl argTypeDecl ) );
    [GrammarRule("argDecl")]
    private Lang2Parser.argDecl_return argDecl()
    {

        Lang2Parser.argDecl_return retval = new Lang2Parser.argDecl_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken VARIABLE119=null;
        IToken char_literal120=null;
        IToken VARIABLE121=null;
        IToken char_literal122=null;
        IToken VAR124=null;
        IToken char_literal126=null;
        Lang2Parser.argTypeDecl_return argTypeDecl123 = default(Lang2Parser.argTypeDecl_return);
        Lang2Parser.partArgDecl_return partArgDecl125 = default(Lang2Parser.partArgDecl_return);
        Lang2Parser.argTypeDecl_return argTypeDecl127 = default(Lang2Parser.argTypeDecl_return);

        object VARIABLE119_tree=null;
        object char_literal120_tree=null;
        object VARIABLE121_tree=null;
        object char_literal122_tree=null;
        object VAR124_tree=null;
        object char_literal126_tree=null;
        RewriteRuleITokenStream stream_69=new RewriteRuleITokenStream(adaptor,"token 69");
        RewriteRuleITokenStream stream_VAR=new RewriteRuleITokenStream(adaptor,"token VAR");
        RewriteRuleSubtreeStream stream_partArgDecl=new RewriteRuleSubtreeStream(adaptor,"rule partArgDecl");
        RewriteRuleSubtreeStream stream_argTypeDecl=new RewriteRuleSubtreeStream(adaptor,"rule argTypeDecl");
    	try { DebugEnterRule(GrammarFileName, "argDecl");
    	DebugLocation(228, 2);
    	try
    	{
    		// Lang2.g:228:9: ( VARIABLE ( ',' VARIABLE )* ':' argTypeDecl | VAR partArgDecl ':' argTypeDecl -> ^( VAR partArgDecl argTypeDecl ) )
    		int alt22=2;
    		try { DebugEnterDecision(22, decisionCanBacktrack[22]);
    		int LA22_0 = input.LA(1);

    		if ((LA22_0==VARIABLE))
    		{
    			alt22=1;
    		}
    		else if ((LA22_0==VAR))
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
    			// Lang2.g:228:11: VARIABLE ( ',' VARIABLE )* ':' argTypeDecl
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(228, 11);
    			VARIABLE119=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_argDecl1436); 
    			VARIABLE119_tree = (object)adaptor.Create(VARIABLE119);
    			adaptor.AddChild(root_0, VARIABLE119_tree);

    			DebugLocation(228, 19);
    			// Lang2.g:228:19: ( ',' VARIABLE )*
    			try { DebugEnterSubRule(21);
    			while (true)
    			{
    				int alt21=2;
    				try { DebugEnterDecision(21, decisionCanBacktrack[21]);
    				int LA21_0 = input.LA(1);

    				if ((LA21_0==68))
    				{
    					alt21=1;
    				}


    				} finally { DebugExitDecision(21); }
    				switch ( alt21 )
    				{
    				case 1:
    					DebugEnterAlt(1);
    					// Lang2.g:228:20: ',' VARIABLE
    					{
    					DebugLocation(228, 23);
    					char_literal120=(IToken)Match(input,68,Follow._68_in_argDecl1438); 
    					DebugLocation(228, 25);
    					VARIABLE121=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_argDecl1441); 
    					VARIABLE121_tree = (object)adaptor.Create(VARIABLE121);
    					adaptor.AddChild(root_0, VARIABLE121_tree);


    					}
    					break;

    				default:
    					goto loop21;
    				}
    			}

    			loop21:
    				;

    			} finally { DebugExitSubRule(21); }

    			DebugLocation(228, 39);
    			char_literal122=(IToken)Match(input,69,Follow._69_in_argDecl1445); 
    			DebugLocation(228, 41);
    			PushFollow(Follow._argTypeDecl_in_argDecl1448);
    			argTypeDecl123=argTypeDecl();
    			PopFollow();

    			adaptor.AddChild(root_0, argTypeDecl123.Tree);

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Lang2.g:229:5: VAR partArgDecl ':' argTypeDecl
    			{
    			DebugLocation(229, 5);
    			VAR124=(IToken)Match(input,VAR,Follow._VAR_in_argDecl1454);  
    			stream_VAR.Add(VAR124);

    			DebugLocation(229, 9);
    			PushFollow(Follow._partArgDecl_in_argDecl1456);
    			partArgDecl125=partArgDecl();
    			PopFollow();

    			stream_partArgDecl.Add(partArgDecl125.Tree);
    			DebugLocation(229, 23);
    			char_literal126=(IToken)Match(input,69,Follow._69_in_argDecl1457);  
    			stream_69.Add(char_literal126);

    			DebugLocation(229, 25);
    			PushFollow(Follow._argTypeDecl_in_argDecl1460);
    			argTypeDecl127=argTypeDecl();
    			PopFollow();

    			stream_argTypeDecl.Add(argTypeDecl127.Tree);


    			{
    			// AST REWRITE
    			// elements: argTypeDecl, partArgDecl, VAR
    			// token labels: 
    			// rule labels: retval
    			// token list labels: 
    			// rule list labels: 
    			// wildcard labels: 
    			retval.Tree = root_0;
    			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    			root_0 = (object)adaptor.Nil();
    			// 229:37: -> ^( VAR partArgDecl argTypeDecl )
    			{
    				DebugLocation(229, 40);
    				// Lang2.g:229:40: ^( VAR partArgDecl argTypeDecl )
    				{
    				object root_1 = (object)adaptor.Nil();
    				DebugLocation(229, 42);
    				root_1 = (object)adaptor.BecomeRoot(stream_VAR.NextNode(), root_1);

    				DebugLocation(229, 46);
    				adaptor.AddChild(root_1, stream_partArgDecl.NextTree());
    				DebugLocation(229, 58);
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
     	DebugLocation(230, 2);
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
    // Lang2.g:232:1: argDeclManyW : argDecl ( ',' argDecl )* ;
    [GrammarRule("argDeclManyW")]
    private Lang2Parser.argDeclManyW_return argDeclManyW()
    {

        Lang2Parser.argDeclManyW_return retval = new Lang2Parser.argDeclManyW_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken char_literal129=null;
        Lang2Parser.argDecl_return argDecl128 = default(Lang2Parser.argDecl_return);
        Lang2Parser.argDecl_return argDecl130 = default(Lang2Parser.argDecl_return);

        object char_literal129_tree=null;

    	try { DebugEnterRule(GrammarFileName, "argDeclManyW");
    	DebugLocation(232, 3);
    	try
    	{
    		// Lang2.g:232:14: ( argDecl ( ',' argDecl )* )
    		DebugEnterAlt(1);
    		// Lang2.g:232:16: argDecl ( ',' argDecl )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(232, 16);
    		PushFollow(Follow._argDecl_in_argDeclManyW1481);
    		argDecl128=argDecl();
    		PopFollow();

    		adaptor.AddChild(root_0, argDecl128.Tree);
    		DebugLocation(232, 23);
    		// Lang2.g:232:23: ( ',' argDecl )*
    		try { DebugEnterSubRule(23);
    		while (true)
    		{
    			int alt23=2;
    			try { DebugEnterDecision(23, decisionCanBacktrack[23]);
    			int LA23_0 = input.LA(1);

    			if ((LA23_0==68))
    			{
    				alt23=1;
    			}


    			} finally { DebugExitDecision(23); }
    			switch ( alt23 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:232:24: ',' argDecl
    				{
    				DebugLocation(232, 27);
    				char_literal129=(IToken)Match(input,68,Follow._68_in_argDeclManyW1483); 
    				DebugLocation(232, 29);
    				PushFollow(Follow._argDecl_in_argDeclManyW1486);
    				argDecl130=argDecl();
    				PopFollow();

    				adaptor.AddChild(root_0, argDecl130.Tree);

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
     	DebugLocation(233, 3);
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
    // Lang2.g:234:1: argDeclMany : argDeclManyW -> ^( VAR_DECL argDeclManyW ) ;
    [GrammarRule("argDeclMany")]
    private Lang2Parser.argDeclMany_return argDeclMany()
    {

        Lang2Parser.argDeclMany_return retval = new Lang2Parser.argDeclMany_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.argDeclManyW_return argDeclManyW131 = default(Lang2Parser.argDeclManyW_return);

        RewriteRuleSubtreeStream stream_argDeclManyW=new RewriteRuleSubtreeStream(adaptor,"rule argDeclManyW");
    	try { DebugEnterRule(GrammarFileName, "argDeclMany");
    	DebugLocation(234, 3);
    	try
    	{
    		// Lang2.g:234:13: ( argDeclManyW -> ^( VAR_DECL argDeclManyW ) )
    		DebugEnterAlt(1);
    		// Lang2.g:234:15: argDeclManyW
    		{
    		DebugLocation(234, 15);
    		PushFollow(Follow._argDeclManyW_in_argDeclMany1499);
    		argDeclManyW131=argDeclManyW();
    		PopFollow();

    		stream_argDeclManyW.Add(argDeclManyW131.Tree);


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
    		// 234:28: -> ^( VAR_DECL argDeclManyW )
    		{
    			DebugLocation(234, 31);
    			// Lang2.g:234:31: ^( VAR_DECL argDeclManyW )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(234, 33);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VAR_DECL, "VAR_DECL"), root_1);

    			DebugLocation(234, 42);
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
     	DebugLocation(235, 3);
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
    // Lang2.g:236:1: typeDecl : ( T_INT | T_CHAR | T_BOOL | T_STRING );
    [GrammarRule("typeDecl")]
    private Lang2Parser.typeDecl_return typeDecl()
    {

        Lang2Parser.typeDecl_return retval = new Lang2Parser.typeDecl_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken set132=null;

        object set132_tree=null;

    	try { DebugEnterRule(GrammarFileName, "typeDecl");
    	DebugLocation(236, 39);
    	try
    	{
    		// Lang2.g:236:10: ( T_INT | T_CHAR | T_BOOL | T_STRING )
    		DebugEnterAlt(1);
    		// Lang2.g:
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(236, 10);
    		set132=(IToken)input.LT(1);
    		if ((input.LA(1)>=T_CHAR && input.LA(1)<=T_STRING))
    		{
    			input.Consume();
    			adaptor.AddChild(root_0, (object)adaptor.Create(set132));
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
     	DebugLocation(236, 39);
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
    // Lang2.g:239:1: varTypeDeclW : ( typeDecl | arrayDecl );
    [GrammarRule("varTypeDeclW")]
    private Lang2Parser.varTypeDeclW_return varTypeDeclW()
    {

        Lang2Parser.varTypeDeclW_return retval = new Lang2Parser.varTypeDeclW_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.typeDecl_return typeDecl133 = default(Lang2Parser.typeDecl_return);
        Lang2Parser.arrayDecl_return arrayDecl134 = default(Lang2Parser.arrayDecl_return);


    	try { DebugEnterRule(GrammarFileName, "varTypeDeclW");
    	DebugLocation(239, 4);
    	try
    	{
    		// Lang2.g:239:14: ( typeDecl | arrayDecl )
    		int alt24=2;
    		try { DebugEnterDecision(24, decisionCanBacktrack[24]);
    		int LA24_0 = input.LA(1);

    		if (((LA24_0>=T_CHAR && LA24_0<=T_STRING)))
    		{
    			alt24=1;
    		}
    		else if ((LA24_0==ARRAY))
    		{
    			alt24=2;
    		}
    		else
    		{
    			NoViableAltException nvae = new NoViableAltException("", 24, 0, input);

    			DebugRecognitionException(nvae);
    			throw nvae;
    		}
    		} finally { DebugExitDecision(24); }
    		switch (alt24)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Lang2.g:239:16: typeDecl
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(239, 16);
    			PushFollow(Follow._typeDecl_in_varTypeDeclW1533);
    			typeDecl133=typeDecl();
    			PopFollow();

    			adaptor.AddChild(root_0, typeDecl133.Tree);

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Lang2.g:239:25: arrayDecl
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(239, 25);
    			PushFollow(Follow._arrayDecl_in_varTypeDeclW1535);
    			arrayDecl134=arrayDecl();
    			PopFollow();

    			adaptor.AddChild(root_0, arrayDecl134.Tree);

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
     	DebugLocation(240, 4);
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
    // Lang2.g:242:1: varTypeDecl : varTypeDeclW OP_END -> ^( TYPE_DECL varTypeDeclW ) ;
    [GrammarRule("varTypeDecl")]
    private Lang2Parser.varTypeDecl_return varTypeDecl()
    {

        Lang2Parser.varTypeDecl_return retval = new Lang2Parser.varTypeDecl_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken OP_END136=null;
        Lang2Parser.varTypeDeclW_return varTypeDeclW135 = default(Lang2Parser.varTypeDeclW_return);

        object OP_END136_tree=null;
        RewriteRuleITokenStream stream_OP_END=new RewriteRuleITokenStream(adaptor,"token OP_END");
        RewriteRuleSubtreeStream stream_varTypeDeclW=new RewriteRuleSubtreeStream(adaptor,"rule varTypeDeclW");
    	try { DebugEnterRule(GrammarFileName, "varTypeDecl");
    	DebugLocation(242, 3);
    	try
    	{
    		// Lang2.g:242:13: ( varTypeDeclW OP_END -> ^( TYPE_DECL varTypeDeclW ) )
    		DebugEnterAlt(1);
    		// Lang2.g:242:15: varTypeDeclW OP_END
    		{
    		DebugLocation(242, 15);
    		PushFollow(Follow._varTypeDeclW_in_varTypeDecl1548);
    		varTypeDeclW135=varTypeDeclW();
    		PopFollow();

    		stream_varTypeDeclW.Add(varTypeDeclW135.Tree);
    		DebugLocation(242, 28);
    		OP_END136=(IToken)Match(input,OP_END,Follow._OP_END_in_varTypeDecl1550);  
    		stream_OP_END.Add(OP_END136);



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
    		// 242:35: -> ^( TYPE_DECL varTypeDeclW )
    		{
    			DebugLocation(242, 38);
    			// Lang2.g:242:38: ^( TYPE_DECL varTypeDeclW )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(242, 40);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(TYPE_DECL, "TYPE_DECL"), root_1);

    			DebugLocation(242, 50);
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
     	DebugLocation(243, 3);
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
    // Lang2.g:246:1: varDecl2 : VARIABLE ( ',' VARIABLE )* ;
    [GrammarRule("varDecl2")]
    private Lang2Parser.varDecl2_return varDecl2()
    {

        Lang2Parser.varDecl2_return retval = new Lang2Parser.varDecl2_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken VARIABLE137=null;
        IToken char_literal138=null;
        IToken VARIABLE139=null;

        object VARIABLE137_tree=null;
        object char_literal138_tree=null;
        object VARIABLE139_tree=null;

    	try { DebugEnterRule(GrammarFileName, "varDecl2");
    	DebugLocation(246, 35);
    	try
    	{
    		// Lang2.g:246:10: ( VARIABLE ( ',' VARIABLE )* )
    		DebugEnterAlt(1);
    		// Lang2.g:246:12: VARIABLE ( ',' VARIABLE )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(246, 12);
    		VARIABLE137=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_varDecl21571); 
    		VARIABLE137_tree = (object)adaptor.Create(VARIABLE137);
    		adaptor.AddChild(root_0, VARIABLE137_tree);

    		DebugLocation(246, 20);
    		// Lang2.g:246:20: ( ',' VARIABLE )*
    		try { DebugEnterSubRule(25);
    		while (true)
    		{
    			int alt25=2;
    			try { DebugEnterDecision(25, decisionCanBacktrack[25]);
    			int LA25_0 = input.LA(1);

    			if ((LA25_0==68))
    			{
    				alt25=1;
    			}


    			} finally { DebugExitDecision(25); }
    			switch ( alt25 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:246:21: ',' VARIABLE
    				{
    				DebugLocation(246, 24);
    				char_literal138=(IToken)Match(input,68,Follow._68_in_varDecl21573); 
    				DebugLocation(246, 26);
    				VARIABLE139=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_varDecl21576); 
    				VARIABLE139_tree = (object)adaptor.Create(VARIABLE139);
    				adaptor.AddChild(root_0, VARIABLE139_tree);


    				}
    				break;

    			default:
    				goto loop25;
    			}
    		}

    		loop25:
    			;

    		} finally { DebugExitSubRule(25); }


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
     	DebugLocation(246, 35);
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
    // Lang2.g:248:1: varDecl : varDecl2 ;
    [GrammarRule("varDecl")]
    private Lang2Parser.varDecl_return varDecl()
    {

        Lang2Parser.varDecl_return retval = new Lang2Parser.varDecl_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.varDecl2_return varDecl2140 = default(Lang2Parser.varDecl2_return);


    	try { DebugEnterRule(GrammarFileName, "varDecl");
    	DebugLocation(248, 2);
    	try
    	{
    		// Lang2.g:248:9: ( varDecl2 )
    		DebugEnterAlt(1);
    		// Lang2.g:248:11: varDecl2
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(248, 11);
    		PushFollow(Follow._varDecl2_in_varDecl1586);
    		varDecl2140=varDecl2();
    		PopFollow();

    		adaptor.AddChild(root_0, varDecl2140.Tree);

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
     	DebugLocation(249, 2);
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
    // Lang2.g:250:1: varDecl12W : varDecl ':' varTypeDecl ;
    [GrammarRule("varDecl12W")]
    private Lang2Parser.varDecl12W_return varDecl12W()
    {

        Lang2Parser.varDecl12W_return retval = new Lang2Parser.varDecl12W_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken char_literal142=null;
        Lang2Parser.varDecl_return varDecl141 = default(Lang2Parser.varDecl_return);
        Lang2Parser.varTypeDecl_return varTypeDecl143 = default(Lang2Parser.varTypeDecl_return);

        object char_literal142_tree=null;

    	try { DebugEnterRule(GrammarFileName, "varDecl12W");
    	DebugLocation(250, 3);
    	try
    	{
    		// Lang2.g:250:12: ( varDecl ':' varTypeDecl )
    		DebugEnterAlt(1);
    		// Lang2.g:250:14: varDecl ':' varTypeDecl
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(250, 14);
    		PushFollow(Follow._varDecl_in_varDecl12W1596);
    		varDecl141=varDecl();
    		PopFollow();

    		adaptor.AddChild(root_0, varDecl141.Tree);
    		DebugLocation(250, 25);
    		char_literal142=(IToken)Match(input,69,Follow._69_in_varDecl12W1598); 
    		DebugLocation(250, 27);
    		PushFollow(Follow._varTypeDecl_in_varDecl12W1601);
    		varTypeDecl143=varTypeDecl();
    		PopFollow();

    		adaptor.AddChild(root_0, varTypeDecl143.Tree);

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
     	DebugLocation(251, 3);
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
    // Lang2.g:252:1: varDeclW : VAR ( ( varDecl12W )+ ) -> ^( VAR_DECL ( varDecl12W )+ ) ;
    [GrammarRule("varDeclW")]
    private Lang2Parser.varDeclW_return varDeclW()
    {

        Lang2Parser.varDeclW_return retval = new Lang2Parser.varDeclW_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken VAR144=null;
        Lang2Parser.varDecl12W_return varDecl12W145 = default(Lang2Parser.varDecl12W_return);

        object VAR144_tree=null;
        RewriteRuleITokenStream stream_VAR=new RewriteRuleITokenStream(adaptor,"token VAR");
        RewriteRuleSubtreeStream stream_varDecl12W=new RewriteRuleSubtreeStream(adaptor,"rule varDecl12W");
    	try { DebugEnterRule(GrammarFileName, "varDeclW");
    	DebugLocation(252, 3);
    	try
    	{
    		// Lang2.g:252:10: ( VAR ( ( varDecl12W )+ ) -> ^( VAR_DECL ( varDecl12W )+ ) )
    		DebugEnterAlt(1);
    		// Lang2.g:252:12: VAR ( ( varDecl12W )+ )
    		{
    		DebugLocation(252, 12);
    		VAR144=(IToken)Match(input,VAR,Follow._VAR_in_varDeclW1613);  
    		stream_VAR.Add(VAR144);

    		DebugLocation(252, 16);
    		// Lang2.g:252:16: ( ( varDecl12W )+ )
    		DebugEnterAlt(1);
    		// Lang2.g:252:17: ( varDecl12W )+
    		{
    		DebugLocation(252, 17);
    		// Lang2.g:252:17: ( varDecl12W )+
    		int cnt26=0;
    		try { DebugEnterSubRule(26);
    		while (true)
    		{
    			int alt26=2;
    			try { DebugEnterDecision(26, decisionCanBacktrack[26]);
    			int LA26_0 = input.LA(1);

    			if ((LA26_0==VARIABLE))
    			{
    				alt26=1;
    			}


    			} finally { DebugExitDecision(26); }
    			switch (alt26)
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:252:17: varDecl12W
    				{
    				DebugLocation(252, 17);
    				PushFollow(Follow._varDecl12W_in_varDeclW1616);
    				varDecl12W145=varDecl12W();
    				PopFollow();

    				stream_varDecl12W.Add(varDecl12W145.Tree);

    				}
    				break;

    			default:
    				if (cnt26 >= 1)
    					goto loop26;

    				EarlyExitException eee26 = new EarlyExitException( 26, input );
    				DebugRecognitionException(eee26);
    				throw eee26;
    			}
    			cnt26++;
    		}
    		loop26:
    			;

    		} finally { DebugExitSubRule(26); }


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
    		// 252:30: -> ^( VAR_DECL ( varDecl12W )+ )
    		{
    			DebugLocation(252, 33);
    			// Lang2.g:252:33: ^( VAR_DECL ( varDecl12W )+ )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(252, 35);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VAR_DECL, "VAR_DECL"), root_1);

    			DebugLocation(252, 44);
    			if ( !(stream_varDecl12W.HasNext) )
    			{
    				throw new RewriteEarlyExitException();
    			}
    			while ( stream_varDecl12W.HasNext )
    			{
    				DebugLocation(252, 44);
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
     	DebugLocation(253, 3);
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
    // Lang2.g:257:1: bodyExpr : BEGIN ( bodyOper )* END OP_END -> ^( BODY_EXPR ( bodyOper )* ) ;
    [GrammarRule("bodyExpr")]
    private Lang2Parser.bodyExpr_return bodyExpr()
    {

        Lang2Parser.bodyExpr_return retval = new Lang2Parser.bodyExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken BEGIN146=null;
        IToken END148=null;
        IToken OP_END149=null;
        Lang2Parser.bodyOper_return bodyOper147 = default(Lang2Parser.bodyOper_return);

        object BEGIN146_tree=null;
        object END148_tree=null;
        object OP_END149_tree=null;
        RewriteRuleITokenStream stream_OP_END=new RewriteRuleITokenStream(adaptor,"token OP_END");
        RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
        RewriteRuleITokenStream stream_BEGIN=new RewriteRuleITokenStream(adaptor,"token BEGIN");
        RewriteRuleSubtreeStream stream_bodyOper=new RewriteRuleSubtreeStream(adaptor,"rule bodyOper");
    	try { DebugEnterRule(GrammarFileName, "bodyExpr");
    	DebugLocation(257, 3);
    	try
    	{
    		// Lang2.g:257:10: ( BEGIN ( bodyOper )* END OP_END -> ^( BODY_EXPR ( bodyOper )* ) )
    		DebugEnterAlt(1);
    		// Lang2.g:257:12: BEGIN ( bodyOper )* END OP_END
    		{
    		DebugLocation(257, 17);
    		BEGIN146=(IToken)Match(input,BEGIN,Follow._BEGIN_in_bodyExpr1642);  
    		stream_BEGIN.Add(BEGIN146);

    		DebugLocation(257, 19);
    		// Lang2.g:257:19: ( bodyOper )*
    		try { DebugEnterSubRule(27);
    		while (true)
    		{
    			int alt27=2;
    			try { DebugEnterDecision(27, decisionCanBacktrack[27]);
    			int LA27_0 = input.LA(1);

    			if ((LA27_0==WHILE||LA27_0==FOR||LA27_0==IF||LA27_0==VARIABLE))
    			{
    				alt27=1;
    			}


    			} finally { DebugExitDecision(27); }
    			switch ( alt27 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:257:19: bodyOper
    				{
    				DebugLocation(257, 19);
    				PushFollow(Follow._bodyOper_in_bodyExpr1645);
    				bodyOper147=bodyOper();
    				PopFollow();

    				stream_bodyOper.Add(bodyOper147.Tree);

    				}
    				break;

    			default:
    				goto loop27;
    			}
    		}

    		loop27:
    			;

    		} finally { DebugExitSubRule(27); }

    		DebugLocation(257, 32);
    		END148=(IToken)Match(input,END,Follow._END_in_bodyExpr1648);  
    		stream_END.Add(END148);

    		DebugLocation(257, 40);
    		OP_END149=(IToken)Match(input,OP_END,Follow._OP_END_in_bodyExpr1651);  
    		stream_OP_END.Add(OP_END149);



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
    		// 257:42: -> ^( BODY_EXPR ( bodyOper )* )
    		{
    			DebugLocation(257, 45);
    			// Lang2.g:257:45: ^( BODY_EXPR ( bodyOper )* )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(257, 47);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BODY_EXPR, "BODY_EXPR"), root_1);

    			DebugLocation(257, 57);
    			// Lang2.g:257:57: ( bodyOper )*
    			while ( stream_bodyOper.HasNext )
    			{
    				DebugLocation(257, 57);
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
     	DebugLocation(258, 3);
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
    // Lang2.g:260:1: func_proc_expr : ( funcDeclare | procedureDeclare );
    [GrammarRule("func_proc_expr")]
    private Lang2Parser.func_proc_expr_return func_proc_expr()
    {

        Lang2Parser.func_proc_expr_return retval = new Lang2Parser.func_proc_expr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.funcDeclare_return funcDeclare150 = default(Lang2Parser.funcDeclare_return);
        Lang2Parser.procedureDeclare_return procedureDeclare151 = default(Lang2Parser.procedureDeclare_return);


    	try { DebugEnterRule(GrammarFileName, "func_proc_expr");
    	DebugLocation(260, 46);
    	try
    	{
    		// Lang2.g:260:16: ( funcDeclare | procedureDeclare )
    		int alt28=2;
    		try { DebugEnterDecision(28, decisionCanBacktrack[28]);
    		int LA28_0 = input.LA(1);

    		if ((LA28_0==FUNCTION))
    		{
    			alt28=1;
    		}
    		else if ((LA28_0==PROCEDURE))
    		{
    			alt28=2;
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
    			// Lang2.g:260:18: funcDeclare
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(260, 18);
    			PushFollow(Follow._funcDeclare_in_func_proc_expr1673);
    			funcDeclare150=funcDeclare();
    			PopFollow();

    			adaptor.AddChild(root_0, funcDeclare150.Tree);

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Lang2.g:260:30: procedureDeclare
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(260, 30);
    			PushFollow(Follow._procedureDeclare_in_func_proc_expr1675);
    			procedureDeclare151=procedureDeclare();
    			PopFollow();

    			adaptor.AddChild(root_0, procedureDeclare151.Tree);

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
     	DebugLocation(260, 46);
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
    // Lang2.g:262:1: fpExprW : ( func_proc_expr )* -> ^( FUNC_PROC_EXPR ( func_proc_expr )* ) ;
    [GrammarRule("fpExprW")]
    private Lang2Parser.fpExprW_return fpExprW()
    {

        Lang2Parser.fpExprW_return retval = new Lang2Parser.fpExprW_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.func_proc_expr_return func_proc_expr152 = default(Lang2Parser.func_proc_expr_return);

        RewriteRuleSubtreeStream stream_func_proc_expr=new RewriteRuleSubtreeStream(adaptor,"rule func_proc_expr");
    	try { DebugEnterRule(GrammarFileName, "fpExprW");
    	DebugLocation(262, 62);
    	try
    	{
    		// Lang2.g:262:9: ( ( func_proc_expr )* -> ^( FUNC_PROC_EXPR ( func_proc_expr )* ) )
    		DebugEnterAlt(1);
    		// Lang2.g:262:11: ( func_proc_expr )*
    		{
    		DebugLocation(262, 11);
    		// Lang2.g:262:11: ( func_proc_expr )*
    		try { DebugEnterSubRule(29);
    		while (true)
    		{
    			int alt29=2;
    			try { DebugEnterDecision(29, decisionCanBacktrack[29]);
    			int LA29_0 = input.LA(1);

    			if (((LA29_0>=FUNCTION && LA29_0<=PROCEDURE)))
    			{
    				alt29=1;
    			}


    			} finally { DebugExitDecision(29); }
    			switch ( alt29 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:262:11: func_proc_expr
    				{
    				DebugLocation(262, 11);
    				PushFollow(Follow._func_proc_expr_in_fpExprW1684);
    				func_proc_expr152=func_proc_expr();
    				PopFollow();

    				stream_func_proc_expr.Add(func_proc_expr152.Tree);

    				}
    				break;

    			default:
    				goto loop29;
    			}
    		}

    		loop29:
    			;

    		} finally { DebugExitSubRule(29); }



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
    		// 262:27: -> ^( FUNC_PROC_EXPR ( func_proc_expr )* )
    		{
    			DebugLocation(262, 30);
    			// Lang2.g:262:30: ^( FUNC_PROC_EXPR ( func_proc_expr )* )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(262, 32);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_PROC_EXPR, "FUNC_PROC_EXPR"), root_1);

    			DebugLocation(262, 47);
    			// Lang2.g:262:47: ( func_proc_expr )*
    			while ( stream_func_proc_expr.HasNext )
    			{
    				DebugLocation(262, 47);
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
     	DebugLocation(262, 62);
    	} finally { DebugExitRule(GrammarFileName, "fpExprW"); }
    	return retval;

    }
    // $ANTLR end "fpExprW"

    public class wrapToBody_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_wrapToBody() {}
    protected virtual void Leave_wrapToBody() {}

    // $ANTLR start "wrapToBody"
    // Lang2.g:264:1: wrapToBody : ( varDeclW )? fpExprW bodyExpr -> ^( BODY_EXPR ( varDeclW )? fpExprW bodyExpr ) ;
    [GrammarRule("wrapToBody")]
    private Lang2Parser.wrapToBody_return wrapToBody()
    {

        Lang2Parser.wrapToBody_return retval = new Lang2Parser.wrapToBody_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.varDeclW_return varDeclW153 = default(Lang2Parser.varDeclW_return);
        Lang2Parser.fpExprW_return fpExprW154 = default(Lang2Parser.fpExprW_return);
        Lang2Parser.bodyExpr_return bodyExpr155 = default(Lang2Parser.bodyExpr_return);

        RewriteRuleSubtreeStream stream_varDeclW=new RewriteRuleSubtreeStream(adaptor,"rule varDeclW");
        RewriteRuleSubtreeStream stream_bodyExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodyExpr");
        RewriteRuleSubtreeStream stream_fpExprW=new RewriteRuleSubtreeStream(adaptor,"rule fpExprW");
    	try { DebugEnterRule(GrammarFileName, "wrapToBody");
    	DebugLocation(264, 82);
    	try
    	{
    		// Lang2.g:264:12: ( ( varDeclW )? fpExprW bodyExpr -> ^( BODY_EXPR ( varDeclW )? fpExprW bodyExpr ) )
    		DebugEnterAlt(1);
    		// Lang2.g:264:14: ( varDeclW )? fpExprW bodyExpr
    		{
    		DebugLocation(264, 14);
    		// Lang2.g:264:14: ( varDeclW )?
    		int alt30=2;
    		try { DebugEnterSubRule(30);
    		try { DebugEnterDecision(30, decisionCanBacktrack[30]);
    		int LA30_0 = input.LA(1);

    		if ((LA30_0==VAR))
    		{
    			alt30=1;
    		}
    		} finally { DebugExitDecision(30); }
    		switch (alt30)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Lang2.g:264:14: varDeclW
    			{
    			DebugLocation(264, 14);
    			PushFollow(Follow._varDeclW_in_wrapToBody1702);
    			varDeclW153=varDeclW();
    			PopFollow();

    			stream_varDeclW.Add(varDeclW153.Tree);

    			}
    			break;

    		}
    		} finally { DebugExitSubRule(30); }

    		DebugLocation(264, 24);
    		PushFollow(Follow._fpExprW_in_wrapToBody1705);
    		fpExprW154=fpExprW();
    		PopFollow();

    		stream_fpExprW.Add(fpExprW154.Tree);
    		DebugLocation(264, 32);
    		PushFollow(Follow._bodyExpr_in_wrapToBody1707);
    		bodyExpr155=bodyExpr();
    		PopFollow();

    		stream_bodyExpr.Add(bodyExpr155.Tree);


    		{
    		// AST REWRITE
    		// elements: fpExprW, bodyExpr, varDeclW
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 264:41: -> ^( BODY_EXPR ( varDeclW )? fpExprW bodyExpr )
    		{
    			DebugLocation(264, 44);
    			// Lang2.g:264:44: ^( BODY_EXPR ( varDeclW )? fpExprW bodyExpr )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(264, 46);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BODY_EXPR, "BODY_EXPR"), root_1);

    			DebugLocation(264, 56);
    			// Lang2.g:264:56: ( varDeclW )?
    			if ( stream_varDeclW.HasNext )
    			{
    				DebugLocation(264, 56);
    				adaptor.AddChild(root_1, stream_varDeclW.NextTree());

    			}
    			stream_varDeclW.Reset();
    			DebugLocation(264, 66);
    			adaptor.AddChild(root_1, stream_fpExprW.NextTree());
    			DebugLocation(264, 74);
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
     	DebugLocation(264, 82);
    	} finally { DebugExitRule(GrammarFileName, "wrapToBody"); }
    	return retval;

    }
    // $ANTLR end "wrapToBody"

    public class expr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_expr() {}
    protected virtual void Leave_expr() {}

    // $ANTLR start "expr"
    // Lang2.g:266:1: expr : PROGRAM VARIABLE OP_END wrapToBody -> ^( PROGRAM VARIABLE wrapToBody ) ;
    [GrammarRule("expr")]
    private Lang2Parser.expr_return expr()
    {

        Lang2Parser.expr_return retval = new Lang2Parser.expr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken PROGRAM156=null;
        IToken VARIABLE157=null;
        IToken OP_END158=null;
        Lang2Parser.wrapToBody_return wrapToBody159 = default(Lang2Parser.wrapToBody_return);

        object PROGRAM156_tree=null;
        object VARIABLE157_tree=null;
        object OP_END158_tree=null;
        RewriteRuleITokenStream stream_PROGRAM=new RewriteRuleITokenStream(adaptor,"token PROGRAM");
        RewriteRuleITokenStream stream_VARIABLE=new RewriteRuleITokenStream(adaptor,"token VARIABLE");
        RewriteRuleITokenStream stream_OP_END=new RewriteRuleITokenStream(adaptor,"token OP_END");
        RewriteRuleSubtreeStream stream_wrapToBody=new RewriteRuleSubtreeStream(adaptor,"rule wrapToBody");
    	try { DebugEnterRule(GrammarFileName, "expr");
    	DebugLocation(266, 1);
    	try
    	{
    		// Lang2.g:266:6: ( PROGRAM VARIABLE OP_END wrapToBody -> ^( PROGRAM VARIABLE wrapToBody ) )
    		DebugEnterAlt(1);
    		// Lang2.g:266:9: PROGRAM VARIABLE OP_END wrapToBody
    		{
    		DebugLocation(266, 9);
    		PROGRAM156=(IToken)Match(input,PROGRAM,Follow._PROGRAM_in_expr1729);  
    		stream_PROGRAM.Add(PROGRAM156);

    		DebugLocation(266, 17);
    		VARIABLE157=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_expr1731);  
    		stream_VARIABLE.Add(VARIABLE157);

    		DebugLocation(266, 32);
    		OP_END158=(IToken)Match(input,OP_END,Follow._OP_END_in_expr1733);  
    		stream_OP_END.Add(OP_END158);

    		DebugLocation(266, 34);
    		PushFollow(Follow._wrapToBody_in_expr1736);
    		wrapToBody159=wrapToBody();
    		PopFollow();

    		stream_wrapToBody.Add(wrapToBody159.Tree);


    		{
    		// AST REWRITE
    		// elements: VARIABLE, PROGRAM, wrapToBody
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 266:45: -> ^( PROGRAM VARIABLE wrapToBody )
    		{
    			DebugLocation(266, 48);
    			// Lang2.g:266:48: ^( PROGRAM VARIABLE wrapToBody )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(266, 50);
    			root_1 = (object)adaptor.BecomeRoot(stream_PROGRAM.NextNode(), root_1);

    			DebugLocation(266, 58);
    			adaptor.AddChild(root_1, stream_VARIABLE.NextNode());
    			DebugLocation(266, 67);
    			adaptor.AddChild(root_1, stream_wrapToBody.NextTree());

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
     	DebugLocation(267, 1);
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
    // Lang2.g:269:1: program : ( expr )+ ;
    [GrammarRule("program")]
    private Lang2Parser.program_return program()
    {

        Lang2Parser.program_return retval = new Lang2Parser.program_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.expr_return expr160 = default(Lang2Parser.expr_return);


    	try { DebugEnterRule(GrammarFileName, "program");
    	DebugLocation(269, 16);
    	try
    	{
    		// Lang2.g:269:8: ( ( expr )+ )
    		DebugEnterAlt(1);
    		// Lang2.g:269:10: ( expr )+
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(269, 10);
    		// Lang2.g:269:10: ( expr )+
    		int cnt31=0;
    		try { DebugEnterSubRule(31);
    		while (true)
    		{
    			int alt31=2;
    			try { DebugEnterDecision(31, decisionCanBacktrack[31]);
    			int LA31_0 = input.LA(1);

    			if ((LA31_0==PROGRAM))
    			{
    				alt31=1;
    			}


    			} finally { DebugExitDecision(31); }
    			switch (alt31)
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:269:10: expr
    				{
    				DebugLocation(269, 10);
    				PushFollow(Follow._expr_in_program1756);
    				expr160=expr();
    				PopFollow();

    				adaptor.AddChild(root_0, expr160.Tree);

    				}
    				break;

    			default:
    				if (cnt31 >= 1)
    					goto loop31;

    				EarlyExitException eee31 = new EarlyExitException( 31, input );
    				DebugRecognitionException(eee31);
    				throw eee31;
    			}
    			cnt31++;
    		}
    		loop31:
    			;

    		} finally { DebugExitSubRule(31); }


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
     	DebugLocation(269, 16);
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
    // Lang2.g:270:1: result : program EOF -> ^( PROGRAM program ) ;
    [GrammarRule("result")]
    private Lang2Parser.result_return result()
    {

        Lang2Parser.result_return retval = new Lang2Parser.result_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken EOF162=null;
        Lang2Parser.program_return program161 = default(Lang2Parser.program_return);

        object EOF162_tree=null;
        RewriteRuleITokenStream stream_EOF=new RewriteRuleITokenStream(adaptor,"token EOF");
        RewriteRuleSubtreeStream stream_program=new RewriteRuleSubtreeStream(adaptor,"rule program");
    	try { DebugEnterRule(GrammarFileName, "result");
    	DebugLocation(270, 41);
    	try
    	{
    		// Lang2.g:270:7: ( program EOF -> ^( PROGRAM program ) )
    		DebugEnterAlt(1);
    		// Lang2.g:270:9: program EOF
    		{
    		DebugLocation(270, 9);
    		PushFollow(Follow._program_in_result1765);
    		program161=program();
    		PopFollow();

    		stream_program.Add(program161.Tree);
    		DebugLocation(270, 17);
    		EOF162=(IToken)Match(input,EOF,Follow._EOF_in_result1767);  
    		stream_EOF.Add(EOF162);



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
    		// 270:21: -> ^( PROGRAM program )
    		{
    			DebugLocation(270, 24);
    			// Lang2.g:270:24: ^( PROGRAM program )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(270, 26);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PROGRAM, "PROGRAM"), root_1);

    			DebugLocation(270, 34);
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
     	DebugLocation(270, 41);
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
    // Lang2.g:271:8: public execute : result ;
    [GrammarRule("execute")]
    public Lang2Parser.execute_return execute()
    {

        Lang2Parser.execute_return retval = new Lang2Parser.execute_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.result_return result163 = default(Lang2Parser.result_return);


    	try { DebugEnterRule(GrammarFileName, "execute");
    	DebugLocation(271, 23);
    	try
    	{
    		// Lang2.g:271:15: ( result )
    		DebugEnterAlt(1);
    		// Lang2.g:271:18: result
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(271, 18);
    		PushFollow(Follow._result_in_execute1784);
    		result163=result();
    		PopFollow();

    		adaptor.AddChild(root_0, result163.Tree);

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
     	DebugLocation(271, 23);
    	} finally { DebugExitRule(GrammarFileName, "execute"); }
    	return retval;

    }
    // $ANTLR end "execute"

	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _63_in_arrayRange479 = new BitSet(new ulong[]{0x000800000F000000UL,0x0000000000000004UL});
		public static readonly BitSet _expressions_in_arrayRange480 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000001UL});
		public static readonly BitSet _64_in_arrayRange482 = new BitSet(new ulong[]{0x000800000F000000UL,0x0000000000000004UL});
		public static readonly BitSet _expressions_in_arrayRange484 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000002UL});
		public static readonly BitSet _65_in_arrayRange485 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _OF_in_arrayTypeDecl506 = new BitSet(new ulong[]{0x0000000000780000UL});
		public static readonly BitSet _typeDecl_in_arrayTypeDecl508 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _ARRAY_in_arrayDecl529 = new BitSet(new ulong[]{0x8000000000000000UL});
		public static readonly BitSet _arrayRange_in_arrayDecl531 = new BitSet(new ulong[]{0x0000200000000000UL});
		public static readonly BitSet _arrayTypeDecl_in_arrayDecl533 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VARIABLE_in_arrayCall556 = new BitSet(new ulong[]{0x8000000000000000UL});
		public static readonly BitSet _63_in_arrayCall558 = new BitSet(new ulong[]{0x000800000F000000UL,0x0000000000000004UL});
		public static readonly BitSet _expressions_in_arrayCall559 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000002UL});
		public static readonly BitSet _65_in_arrayCall560 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _set_in_boolOperator0 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _66_in_mathGroup712 = new BitSet(new ulong[]{0x000800000F000000UL,0x0000000000000004UL});
		public static readonly BitSet _expressions_in_mathGroup714 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000008UL});
		public static readonly BitSet _67_in_mathGroup715 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _INT_in_mathGroup722 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _CHAR_in_mathGroup728 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _BOOLEAN_in_mathGroup734 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _STRING_in_mathGroup741 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VARIABLE_in_mathGroup747 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _funcCall_in_mathGroup753 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _mathGroup_in_boolMult765 = new BitSet(new ulong[]{0x0000020000000002UL});
		public static readonly BitSet _BOOL_MULT_in_boolMult767 = new BitSet(new ulong[]{0x000800000F000000UL,0x0000000000000004UL});
		public static readonly BitSet _mathGroup_in_boolMult770 = new BitSet(new ulong[]{0x0000020000000002UL});
		public static readonly BitSet _boolMult_in_boolAdd784 = new BitSet(new ulong[]{0x0000040000000002UL});
		public static readonly BitSet _BOOL_ADD_in_boolAdd786 = new BitSet(new ulong[]{0x000800000F000000UL,0x0000000000000004UL});
		public static readonly BitSet _boolMult_in_boolAdd789 = new BitSet(new ulong[]{0x0000040000000002UL});
		public static readonly BitSet _boolAdd_in_boolElse802 = new BitSet(new ulong[]{0x7E00000000000002UL});
		public static readonly BitSet _boolOperator_in_boolElse804 = new BitSet(new ulong[]{0x000800000F000000UL,0x0000000000000004UL});
		public static readonly BitSet _boolAdd_in_boolElse807 = new BitSet(new ulong[]{0x7E00000000000002UL});
		public static readonly BitSet _boolElse_in_boolNegative821 = new BitSet(new ulong[]{0x0000000000010002UL});
		public static readonly BitSet _NOT_in_boolNegative824 = new BitSet(new ulong[]{0x000800000F000000UL,0x0000000000000004UL});
		public static readonly BitSet _boolElse_in_boolNegative827 = new BitSet(new ulong[]{0x0000000000010002UL});
		public static readonly BitSet _boolNegative_in_useDiv841 = new BitSet(new ulong[]{0x000000000000C002UL});
		public static readonly BitSet _set_in_useDiv843 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
		public static readonly BitSet _66_in_useDiv850 = new BitSet(new ulong[]{0x000800000F000000UL,0x0000000000000004UL});
		public static readonly BitSet _boolNegative_in_useDiv853 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000008UL});
		public static readonly BitSet _67_in_useDiv855 = new BitSet(new ulong[]{0x000000000000C002UL});
		public static readonly BitSet _useDiv_in_mathMult872 = new BitSet(new ulong[]{0x00C0000000000002UL});
		public static readonly BitSet _set_in_mathMult874 = new BitSet(new ulong[]{0x000800000F000000UL,0x0000000000000004UL});
		public static readonly BitSet _useDiv_in_mathMult880 = new BitSet(new ulong[]{0x00C0000000000002UL});
		public static readonly BitSet _mathMult_in_mathAdd893 = new BitSet(new ulong[]{0x0030000000000002UL});
		public static readonly BitSet _set_in_mathAdd895 = new BitSet(new ulong[]{0x000800000F000000UL,0x0000000000000004UL});
		public static readonly BitSet _mathMult_in_mathAdd901 = new BitSet(new ulong[]{0x0030000000000002UL});
		public static readonly BitSet _mathAdd_in_mathExpr915 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _assExpr_in_bodyOper930 = new BitSet(new ulong[]{0x0002000000000000UL});
		public static readonly BitSet _OP_END_in_bodyOper932 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _conditionExpr_in_bodyOper940 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _loopExpr_in_bodyOper947 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _funcCall_in_bodyOper954 = new BitSet(new ulong[]{0x0002000000000000UL});
		public static readonly BitSet _OP_END_in_bodyOper956 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _mathExpr_in_expressions970 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _arrayCall_in_expressions977 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _mathExpr_in_funcCallArgs991 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000010UL});
		public static readonly BitSet _68_in_funcCallArgs993 = new BitSet(new ulong[]{0x000800000F000000UL,0x0000000000000004UL});
		public static readonly BitSet _mathExpr_in_funcCallArgs996 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000010UL});
		public static readonly BitSet _mathExpr_in_funcCallArgsW1011 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000010UL});
		public static readonly BitSet _68_in_funcCallArgsW1013 = new BitSet(new ulong[]{0x000800000F000000UL,0x0000000000000004UL});
		public static readonly BitSet _mathExpr_in_funcCallArgsW1015 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000010UL});
		public static readonly BitSet _VARIABLE_in_funcCall1041 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
		public static readonly BitSet _66_in_funcCall1042 = new BitSet(new ulong[]{0x000800000F000000UL,0x000000000000000CUL});
		public static readonly BitSet _funcCallArgsW_in_funcCall1044 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000008UL});
		public static readonly BitSet _67_in_funcCall1047 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _66_in_argDeclExpr1071 = new BitSet(new ulong[]{0x0008000000040000UL,0x0000000000000008UL});
		public static readonly BitSet _argDeclMany_in_argDeclExpr1074 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000008UL});
		public static readonly BitSet _67_in_argDeclExpr1077 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _T_INT_in_retTypeExpr1100 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _T_BOOL_in_retTypeExpr1102 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _T_CHAR_in_retTypeExpr1104 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _arrayDecl_in_retTypeExpr1106 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _T_STRING_in_retTypeExpr1108 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _retTypeExpr_in_retTypeExprWrap1121 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _varDeclW_in_bodyFuncProcExpr1142 = new BitSet(new ulong[]{0x0000000000000400UL});
		public static readonly BitSet _bodyExpr_in_bodyFuncProcExpr1145 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _FUNCTION_in_funcDeclare1158 = new BitSet(new ulong[]{0x0008000000000000UL});
		public static readonly BitSet _VARIABLE_in_funcDeclare1160 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
		public static readonly BitSet _argDeclExpr_in_funcDeclare1162 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
		public static readonly BitSet _69_in_funcDeclare1163 = new BitSet(new ulong[]{0x0000100000780000UL});
		public static readonly BitSet _retTypeExprWrap_in_funcDeclare1165 = new BitSet(new ulong[]{0x0002000000000000UL});
		public static readonly BitSet _OP_END_in_funcDeclare1167 = new BitSet(new ulong[]{0x0000000000040400UL});
		public static readonly BitSet _bodyFuncProcExpr_in_funcDeclare1171 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _PROCEDURE_in_procedureDeclare1196 = new BitSet(new ulong[]{0x0008000000000000UL});
		public static readonly BitSet _VARIABLE_in_procedureDeclare1198 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
		public static readonly BitSet _argDeclExpr_in_procedureDeclare1200 = new BitSet(new ulong[]{0x0002000000000000UL});
		public static readonly BitSet _OP_END_in_procedureDeclare1202 = new BitSet(new ulong[]{0x0000000000040400UL});
		public static readonly BitSet _bodyFuncProcExpr_in_procedureDeclare1204 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _ELSE_in_conditionElseExpr1231 = new BitSet(new ulong[]{0x0000000000000400UL});
		public static readonly BitSet _bodyExpr_in_conditionElseExpr1234 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _expressions_in_condExpr1256 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _IF_in_conditionExpr1275 = new BitSet(new ulong[]{0x000800000F000000UL,0x0000000000000004UL});
		public static readonly BitSet _condExpr_in_conditionExpr1277 = new BitSet(new ulong[]{0x0000000000001000UL});
		public static readonly BitSet _THEN_in_conditionExpr1279 = new BitSet(new ulong[]{0x0000000000000400UL});
		public static readonly BitSet _bodyExpr_in_conditionExpr1282 = new BitSet(new ulong[]{0x0000000000002002UL});
		public static readonly BitSet _conditionElseExpr_in_conditionExpr1284 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _assExpr_in_forExpr1310 = new BitSet(new ulong[]{0x0000000000020000UL});
		public static readonly BitSet _TO_in_forExpr1312 = new BitSet(new ulong[]{0x000800000F000000UL,0x0000000000000004UL});
		public static readonly BitSet _expressions_in_forExpr1315 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _WHILE_in_loopExpr1324 = new BitSet(new ulong[]{0x000800000F000000UL,0x0000000000000004UL});
		public static readonly BitSet _condExpr_in_loopExpr1326 = new BitSet(new ulong[]{0x0000000000000040UL});
		public static readonly BitSet _DO_in_loopExpr1328 = new BitSet(new ulong[]{0x0000000000000400UL});
		public static readonly BitSet _bodyExpr_in_loopExpr1331 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _FOR_in_loopExpr1347 = new BitSet(new ulong[]{0x000800000F000000UL,0x0000000000000004UL});
		public static readonly BitSet _forExpr_in_loopExpr1349 = new BitSet(new ulong[]{0x0000000000000040UL});
		public static readonly BitSet _DO_in_loopExpr1351 = new BitSet(new ulong[]{0x0000000000000400UL});
		public static readonly BitSet _bodyExpr_in_loopExpr1353 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VARIABLE_in_assExpr1376 = new BitSet(new ulong[]{0x0100000000000000UL});
		public static readonly BitSet _ASSIGN_in_assExpr1378 = new BitSet(new ulong[]{0x000800000F000000UL,0x0000000000000004UL});
		public static readonly BitSet _expressions_in_assExpr1381 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _arrayCall_in_assExpr1387 = new BitSet(new ulong[]{0x0100000000000000UL});
		public static readonly BitSet _ASSIGN_in_assExpr1389 = new BitSet(new ulong[]{0x000800000F000000UL,0x0000000000000004UL});
		public static readonly BitSet _expressions_in_assExpr1392 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _typeDecl_in_argTypeDecl1402 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VARIABLE_in_partArgDecl1421 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000010UL});
		public static readonly BitSet _68_in_partArgDecl1423 = new BitSet(new ulong[]{0x0008000000000000UL});
		public static readonly BitSet _VARIABLE_in_partArgDecl1426 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000010UL});
		public static readonly BitSet _VARIABLE_in_argDecl1436 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000030UL});
		public static readonly BitSet _68_in_argDecl1438 = new BitSet(new ulong[]{0x0008000000000000UL});
		public static readonly BitSet _VARIABLE_in_argDecl1441 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000030UL});
		public static readonly BitSet _69_in_argDecl1445 = new BitSet(new ulong[]{0x0000000000780000UL});
		public static readonly BitSet _argTypeDecl_in_argDecl1448 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VAR_in_argDecl1454 = new BitSet(new ulong[]{0x0008000000000000UL});
		public static readonly BitSet _partArgDecl_in_argDecl1456 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
		public static readonly BitSet _69_in_argDecl1457 = new BitSet(new ulong[]{0x0000000000780000UL});
		public static readonly BitSet _argTypeDecl_in_argDecl1460 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _argDecl_in_argDeclManyW1481 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000010UL});
		public static readonly BitSet _68_in_argDeclManyW1483 = new BitSet(new ulong[]{0x0008000000040000UL});
		public static readonly BitSet _argDecl_in_argDeclManyW1486 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000010UL});
		public static readonly BitSet _argDeclManyW_in_argDeclMany1499 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _set_in_typeDecl0 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _typeDecl_in_varTypeDeclW1533 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _arrayDecl_in_varTypeDeclW1535 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _varTypeDeclW_in_varTypeDecl1548 = new BitSet(new ulong[]{0x0002000000000000UL});
		public static readonly BitSet _OP_END_in_varTypeDecl1550 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VARIABLE_in_varDecl21571 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000010UL});
		public static readonly BitSet _68_in_varDecl21573 = new BitSet(new ulong[]{0x0008000000000000UL});
		public static readonly BitSet _VARIABLE_in_varDecl21576 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000010UL});
		public static readonly BitSet _varDecl2_in_varDecl1586 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _varDecl_in_varDecl12W1596 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
		public static readonly BitSet _69_in_varDecl12W1598 = new BitSet(new ulong[]{0x0000100000780000UL});
		public static readonly BitSet _varTypeDecl_in_varDecl12W1601 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VAR_in_varDeclW1613 = new BitSet(new ulong[]{0x0008000000000000UL});
		public static readonly BitSet _varDecl12W_in_varDeclW1616 = new BitSet(new ulong[]{0x0008000000000002UL});
		public static readonly BitSet _BEGIN_in_bodyExpr1642 = new BitSet(new ulong[]{0x000800000F8008A0UL,0x0000000000000004UL});
		public static readonly BitSet _bodyOper_in_bodyExpr1645 = new BitSet(new ulong[]{0x000800000F8008A0UL,0x0000000000000004UL});
		public static readonly BitSet _END_in_bodyExpr1648 = new BitSet(new ulong[]{0x0002000000000000UL});
		public static readonly BitSet _OP_END_in_bodyExpr1651 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _funcDeclare_in_func_proc_expr1673 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _procedureDeclare_in_func_proc_expr1675 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _func_proc_expr_in_fpExprW1684 = new BitSet(new ulong[]{0x0000000000000302UL});
		public static readonly BitSet _varDeclW_in_wrapToBody1702 = new BitSet(new ulong[]{0x0000000000000300UL});
		public static readonly BitSet _fpExprW_in_wrapToBody1705 = new BitSet(new ulong[]{0x0000000000000400UL});
		public static readonly BitSet _bodyExpr_in_wrapToBody1707 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _PROGRAM_in_expr1729 = new BitSet(new ulong[]{0x0008000000000000UL});
		public static readonly BitSet _VARIABLE_in_expr1731 = new BitSet(new ulong[]{0x0002000000000000UL});
		public static readonly BitSet _OP_END_in_expr1733 = new BitSet(new ulong[]{0x0000000000040300UL});
		public static readonly BitSet _wrapToBody_in_expr1736 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _expr_in_program1756 = new BitSet(new ulong[]{0x0000000000000012UL});
		public static readonly BitSet _program_in_result1765 = new BitSet(new ulong[]{0x0000000000000000UL});
		public static readonly BitSet _EOF_in_result1767 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _result_in_execute1784 = new BitSet(new ulong[]{0x0000000000000002UL});

	}
	#endregion Follow sets
}
}