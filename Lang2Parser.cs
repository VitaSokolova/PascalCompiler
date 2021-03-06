// $ANTLR 3.3 Nov 30, 2010 12:50:56 Lang2.g 2017-01-11 20:55:30

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
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "PROGRAM", "WHILE", "DO", "FOR", "FUNCTION", "PROCEDURE", "BEGIN", "END", "THEN", "ELSE", "DIV", "MOD", "NOT", "TO", "VAR", "T_CHAR", "T_BOOL", "T_INT", "T_STRING", "IF", "BOOLEAN", "CHAR", "INT", "STRING", "FALSE", "TRUE", "VAR_DECL", "BODY_EXPR", "VAR_EXPR", "FUNC_PROC_EXPR", "PROC_DECL", "FUNC_DECL", "FUNC_CALL", "FUNC_CALL_ARGS", "FUNC_PROC_ARGS", "FUNC_PROC_RET_TYPE", "TYPE_DECL", "BOOL_MULT", "BOOL_ADD", "CONDITION", "ARRAY", "OF", "ARR_DECL", "RANGE", "ARR_CALL", "MAIN_BODY", "VOID", "REPEAT", "UNTIL", "OP_END", "WS", "VARIABLE", "ADD", "REM", "MULT", "DIVIDE", "ASSIGN", "GREATER", "LESS", "EQUAL", "LESS_OR_EQUAL", "GREATER_OR_EQUAL", "MORE", "'['", "'..'", "']'", "'('", "')'", "','", "':'"
	};
	public const int EOF=-1;
	public const int T__67=67;
	public const int T__68=68;
	public const int T__69=69;
	public const int T__70=70;
	public const int T__71=71;
	public const int T__72=72;
	public const int T__73=73;
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
	public const int MAIN_BODY=49;
	public const int VOID=50;
	public const int REPEAT=51;
	public const int UNTIL=52;
	public const int OP_END=53;
	public const int WS=54;
	public const int VARIABLE=55;
	public const int ADD=56;
	public const int REM=57;
	public const int MULT=58;
	public const int DIVIDE=59;
	public const int ASSIGN=60;
	public const int GREATER=61;
	public const int LESS=62;
	public const int EQUAL=63;
	public const int LESS_OR_EQUAL=64;
	public const int GREATER_OR_EQUAL=65;
	public const int MORE=66;

	// delegates
	// delegators

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				false, false, false, false, false, false, false, false, false, false, 
				false, false, false, false, false, false, false, false, false, false, 
				false, false, false, false, false, false, false, false, false, false
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
    // Lang2.g:94:1: arrayRange : '[' expressions '..' expressions ']' -> ^( RANGE expressions expressions ) ;
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
        RewriteRuleITokenStream stream_67=new RewriteRuleITokenStream(adaptor,"token 67");
        RewriteRuleITokenStream stream_69=new RewriteRuleITokenStream(adaptor,"token 69");
        RewriteRuleITokenStream stream_68=new RewriteRuleITokenStream(adaptor,"token 68");
        RewriteRuleSubtreeStream stream_expressions=new RewriteRuleSubtreeStream(adaptor,"rule expressions");
    	try { DebugEnterRule(GrammarFileName, "arrayRange");
    	DebugLocation(94, 3);
    	try
    	{
    		// Lang2.g:94:12: ( '[' expressions '..' expressions ']' -> ^( RANGE expressions expressions ) )
    		DebugEnterAlt(1);
    		// Lang2.g:94:14: '[' expressions '..' expressions ']'
    		{
    		DebugLocation(94, 14);
    		char_literal1=(IToken)Match(input,67,Follow._67_in_arrayRange520);  
    		stream_67.Add(char_literal1);

    		DebugLocation(94, 17);
    		PushFollow(Follow._expressions_in_arrayRange521);
    		expressions2=expressions();
    		PopFollow();

    		stream_expressions.Add(expressions2.Tree);
    		DebugLocation(94, 29);
    		string_literal3=(IToken)Match(input,68,Follow._68_in_arrayRange523);  
    		stream_68.Add(string_literal3);

    		DebugLocation(94, 34);
    		PushFollow(Follow._expressions_in_arrayRange525);
    		expressions4=expressions();
    		PopFollow();

    		stream_expressions.Add(expressions4.Tree);
    		DebugLocation(94, 45);
    		char_literal5=(IToken)Match(input,69,Follow._69_in_arrayRange526);  
    		stream_69.Add(char_literal5);



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
    		// 94:49: -> ^( RANGE expressions expressions )
    		{
    			DebugLocation(94, 52);
    			// Lang2.g:94:52: ^( RANGE expressions expressions )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(94, 54);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(RANGE, "RANGE"), root_1);

    			DebugLocation(94, 60);
    			adaptor.AddChild(root_1, stream_expressions.NextTree());
    			DebugLocation(94, 72);
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
     	DebugLocation(95, 3);
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
    // Lang2.g:96:1: arrayTypeDecl : OF typeDecl -> ^( TYPE_DECL typeDecl ) ;
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
    	DebugLocation(96, 4);
    	try
    	{
    		// Lang2.g:96:15: ( OF typeDecl -> ^( TYPE_DECL typeDecl ) )
    		DebugEnterAlt(1);
    		// Lang2.g:96:17: OF typeDecl
    		{
    		DebugLocation(96, 17);
    		OF6=(IToken)Match(input,OF,Follow._OF_in_arrayTypeDecl547);  
    		stream_OF.Add(OF6);

    		DebugLocation(96, 20);
    		PushFollow(Follow._typeDecl_in_arrayTypeDecl549);
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
    		// 96:29: -> ^( TYPE_DECL typeDecl )
    		{
    			DebugLocation(96, 32);
    			// Lang2.g:96:32: ^( TYPE_DECL typeDecl )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(96, 34);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(TYPE_DECL, "TYPE_DECL"), root_1);

    			DebugLocation(96, 44);
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
     	DebugLocation(97, 4);
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
    // Lang2.g:98:1: arrayDecl : ARRAY arrayRange arrayTypeDecl -> ^( ARR_DECL arrayRange arrayTypeDecl ) ;
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
    	DebugLocation(98, 3);
    	try
    	{
    		// Lang2.g:98:11: ( ARRAY arrayRange arrayTypeDecl -> ^( ARR_DECL arrayRange arrayTypeDecl ) )
    		DebugEnterAlt(1);
    		// Lang2.g:98:14: ARRAY arrayRange arrayTypeDecl
    		{
    		DebugLocation(98, 14);
    		ARRAY8=(IToken)Match(input,ARRAY,Follow._ARRAY_in_arrayDecl570);  
    		stream_ARRAY.Add(ARRAY8);

    		DebugLocation(98, 20);
    		PushFollow(Follow._arrayRange_in_arrayDecl572);
    		arrayRange9=arrayRange();
    		PopFollow();

    		stream_arrayRange.Add(arrayRange9.Tree);
    		DebugLocation(98, 31);
    		PushFollow(Follow._arrayTypeDecl_in_arrayDecl574);
    		arrayTypeDecl10=arrayTypeDecl();
    		PopFollow();

    		stream_arrayTypeDecl.Add(arrayTypeDecl10.Tree);


    		{
    		// AST REWRITE
    		// elements: arrayTypeDecl, arrayRange
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 98:45: -> ^( ARR_DECL arrayRange arrayTypeDecl )
    		{
    			DebugLocation(98, 48);
    			// Lang2.g:98:48: ^( ARR_DECL arrayRange arrayTypeDecl )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(98, 50);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARR_DECL, "ARR_DECL"), root_1);

    			DebugLocation(98, 59);
    			adaptor.AddChild(root_1, stream_arrayRange.NextTree());
    			DebugLocation(98, 70);
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
     	DebugLocation(99, 3);
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
    // Lang2.g:101:1: arrayCall : VARIABLE '[' expressions ']' -> ^( ARR_CALL VARIABLE expressions ) ;
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
        RewriteRuleITokenStream stream_67=new RewriteRuleITokenStream(adaptor,"token 67");
        RewriteRuleITokenStream stream_69=new RewriteRuleITokenStream(adaptor,"token 69");
        RewriteRuleITokenStream stream_VARIABLE=new RewriteRuleITokenStream(adaptor,"token VARIABLE");
        RewriteRuleSubtreeStream stream_expressions=new RewriteRuleSubtreeStream(adaptor,"rule expressions");
    	try { DebugEnterRule(GrammarFileName, "arrayCall");
    	DebugLocation(101, 3);
    	try
    	{
    		// Lang2.g:101:11: ( VARIABLE '[' expressions ']' -> ^( ARR_CALL VARIABLE expressions ) )
    		DebugEnterAlt(1);
    		// Lang2.g:101:13: VARIABLE '[' expressions ']'
    		{
    		DebugLocation(101, 13);
    		VARIABLE11=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_arrayCall597);  
    		stream_VARIABLE.Add(VARIABLE11);

    		DebugLocation(101, 22);
    		char_literal12=(IToken)Match(input,67,Follow._67_in_arrayCall599);  
    		stream_67.Add(char_literal12);

    		DebugLocation(101, 25);
    		PushFollow(Follow._expressions_in_arrayCall600);
    		expressions13=expressions();
    		PopFollow();

    		stream_expressions.Add(expressions13.Tree);
    		DebugLocation(101, 36);
    		char_literal14=(IToken)Match(input,69,Follow._69_in_arrayCall601);  
    		stream_69.Add(char_literal14);



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
    		// 101:40: -> ^( ARR_CALL VARIABLE expressions )
    		{
    			DebugLocation(101, 43);
    			// Lang2.g:101:43: ^( ARR_CALL VARIABLE expressions )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(101, 45);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARR_CALL, "ARR_CALL"), root_1);

    			DebugLocation(101, 54);
    			adaptor.AddChild(root_1, stream_VARIABLE.NextNode());
    			DebugLocation(101, 63);
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
     	DebugLocation(102, 3);
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
    // Lang2.g:128:1: boolOperator : ( MORE | LESS | EQUAL | LESS_OR_EQUAL | GREATER_OR_EQUAL | GREATER );
    [GrammarRule("boolOperator")]
    private Lang2Parser.boolOperator_return boolOperator()
    {

        Lang2Parser.boolOperator_return retval = new Lang2Parser.boolOperator_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken set15=null;

        object set15_tree=null;

    	try { DebugEnterRule(GrammarFileName, "boolOperator");
    	DebugLocation(128, 3);
    	try
    	{
    		// Lang2.g:128:13: ( MORE | LESS | EQUAL | LESS_OR_EQUAL | GREATER_OR_EQUAL | GREATER )
    		DebugEnterAlt(1);
    		// Lang2.g:
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(128, 13);
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
     	DebugLocation(129, 3);
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
    // Lang2.g:132:1: mathGroup : ( '(' expressions ')' | INT | CHAR | BOOLEAN | STRING | VARIABLE | funcCall | arrayCall );
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
        Lang2Parser.arrayCall_return arrayCall25 = default(Lang2Parser.arrayCall_return);

        object char_literal16_tree=null;
        object char_literal18_tree=null;
        object INT19_tree=null;
        object CHAR20_tree=null;
        object BOOLEAN21_tree=null;
        object STRING22_tree=null;
        object VARIABLE23_tree=null;

    	try { DebugEnterRule(GrammarFileName, "mathGroup");
    	DebugLocation(132, 2);
    	try
    	{
    		// Lang2.g:132:11: ( '(' expressions ')' | INT | CHAR | BOOLEAN | STRING | VARIABLE | funcCall | arrayCall )
    		int alt1=8;
    		try { DebugEnterDecision(1, decisionCanBacktrack[1]);
    		try
    		{
    			alt1 = dfa1.Predict(input);
    		}
    		catch (NoViableAltException nvae)
    		{
    			DebugRecognitionException(nvae);
    			throw;
    		}
    		} finally { DebugExitDecision(1); }
    		switch (alt1)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Lang2.g:132:13: '(' expressions ')'
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(132, 16);
    			char_literal16=(IToken)Match(input,70,Follow._70_in_mathGroup752); 
    			DebugLocation(132, 17);
    			PushFollow(Follow._expressions_in_mathGroup754);
    			expressions17=expressions();
    			PopFollow();

    			adaptor.AddChild(root_0, expressions17.Tree);
    			DebugLocation(132, 31);
    			char_literal18=(IToken)Match(input,71,Follow._71_in_mathGroup755); 

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Lang2.g:133:5: INT
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(133, 5);
    			INT19=(IToken)Match(input,INT,Follow._INT_in_mathGroup762); 
    			INT19_tree = (object)adaptor.Create(INT19);
    			adaptor.AddChild(root_0, INT19_tree);


    			}
    			break;
    		case 3:
    			DebugEnterAlt(3);
    			// Lang2.g:134:5: CHAR
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(134, 5);
    			CHAR20=(IToken)Match(input,CHAR,Follow._CHAR_in_mathGroup768); 
    			CHAR20_tree = (object)adaptor.Create(CHAR20);
    			adaptor.AddChild(root_0, CHAR20_tree);


    			}
    			break;
    		case 4:
    			DebugEnterAlt(4);
    			// Lang2.g:135:5: BOOLEAN
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(135, 5);
    			BOOLEAN21=(IToken)Match(input,BOOLEAN,Follow._BOOLEAN_in_mathGroup774); 
    			BOOLEAN21_tree = (object)adaptor.Create(BOOLEAN21);
    			adaptor.AddChild(root_0, BOOLEAN21_tree);


    			}
    			break;
    		case 5:
    			DebugEnterAlt(5);
    			// Lang2.g:136:5: STRING
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(136, 5);
    			STRING22=(IToken)Match(input,STRING,Follow._STRING_in_mathGroup781); 
    			STRING22_tree = (object)adaptor.Create(STRING22);
    			adaptor.AddChild(root_0, STRING22_tree);


    			}
    			break;
    		case 6:
    			DebugEnterAlt(6);
    			// Lang2.g:137:5: VARIABLE
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(137, 5);
    			VARIABLE23=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_mathGroup787); 
    			VARIABLE23_tree = (object)adaptor.Create(VARIABLE23);
    			adaptor.AddChild(root_0, VARIABLE23_tree);


    			}
    			break;
    		case 7:
    			DebugEnterAlt(7);
    			// Lang2.g:138:5: funcCall
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(138, 5);
    			PushFollow(Follow._funcCall_in_mathGroup793);
    			funcCall24=funcCall();
    			PopFollow();

    			adaptor.AddChild(root_0, funcCall24.Tree);

    			}
    			break;
    		case 8:
    			DebugEnterAlt(8);
    			// Lang2.g:139:5: arrayCall
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(139, 5);
    			PushFollow(Follow._arrayCall_in_mathGroup799);
    			arrayCall25=arrayCall();
    			PopFollow();

    			adaptor.AddChild(root_0, arrayCall25.Tree);

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
     	DebugLocation(140, 2);
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
    // Lang2.g:143:1: boolMult : mathGroup ( BOOL_MULT mathGroup )* ;
    [GrammarRule("boolMult")]
    private Lang2Parser.boolMult_return boolMult()
    {

        Lang2Parser.boolMult_return retval = new Lang2Parser.boolMult_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken BOOL_MULT27=null;
        Lang2Parser.mathGroup_return mathGroup26 = default(Lang2Parser.mathGroup_return);
        Lang2Parser.mathGroup_return mathGroup28 = default(Lang2Parser.mathGroup_return);

        object BOOL_MULT27_tree=null;

    	try { DebugEnterRule(GrammarFileName, "boolMult");
    	DebugLocation(143, 3);
    	try
    	{
    		// Lang2.g:143:10: ( mathGroup ( BOOL_MULT mathGroup )* )
    		DebugEnterAlt(1);
    		// Lang2.g:143:12: mathGroup ( BOOL_MULT mathGroup )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(143, 12);
    		PushFollow(Follow._mathGroup_in_boolMult811);
    		mathGroup26=mathGroup();
    		PopFollow();

    		adaptor.AddChild(root_0, mathGroup26.Tree);
    		DebugLocation(143, 21);
    		// Lang2.g:143:21: ( BOOL_MULT mathGroup )*
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
    				// Lang2.g:143:22: BOOL_MULT mathGroup
    				{
    				DebugLocation(143, 31);
    				BOOL_MULT27=(IToken)Match(input,BOOL_MULT,Follow._BOOL_MULT_in_boolMult813); 
    				BOOL_MULT27_tree = (object)adaptor.Create(BOOL_MULT27);
    				root_0 = (object)adaptor.BecomeRoot(BOOL_MULT27_tree, root_0);

    				DebugLocation(143, 33);
    				PushFollow(Follow._mathGroup_in_boolMult816);
    				mathGroup28=mathGroup();
    				PopFollow();

    				adaptor.AddChild(root_0, mathGroup28.Tree);

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
     	DebugLocation(144, 3);
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
    // Lang2.g:146:1: boolAdd : boolMult ( BOOL_ADD boolMult )* ;
    [GrammarRule("boolAdd")]
    private Lang2Parser.boolAdd_return boolAdd()
    {

        Lang2Parser.boolAdd_return retval = new Lang2Parser.boolAdd_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken BOOL_ADD30=null;
        Lang2Parser.boolMult_return boolMult29 = default(Lang2Parser.boolMult_return);
        Lang2Parser.boolMult_return boolMult31 = default(Lang2Parser.boolMult_return);

        object BOOL_ADD30_tree=null;

    	try { DebugEnterRule(GrammarFileName, "boolAdd");
    	DebugLocation(146, 2);
    	try
    	{
    		// Lang2.g:146:9: ( boolMult ( BOOL_ADD boolMult )* )
    		DebugEnterAlt(1);
    		// Lang2.g:146:11: boolMult ( BOOL_ADD boolMult )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(146, 11);
    		PushFollow(Follow._boolMult_in_boolAdd830);
    		boolMult29=boolMult();
    		PopFollow();

    		adaptor.AddChild(root_0, boolMult29.Tree);
    		DebugLocation(146, 19);
    		// Lang2.g:146:19: ( BOOL_ADD boolMult )*
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
    				// Lang2.g:146:20: BOOL_ADD boolMult
    				{
    				DebugLocation(146, 28);
    				BOOL_ADD30=(IToken)Match(input,BOOL_ADD,Follow._BOOL_ADD_in_boolAdd832); 
    				BOOL_ADD30_tree = (object)adaptor.Create(BOOL_ADD30);
    				root_0 = (object)adaptor.BecomeRoot(BOOL_ADD30_tree, root_0);

    				DebugLocation(146, 30);
    				PushFollow(Follow._boolMult_in_boolAdd835);
    				boolMult31=boolMult();
    				PopFollow();

    				adaptor.AddChild(root_0, boolMult31.Tree);

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
     	DebugLocation(147, 2);
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
    // Lang2.g:149:1: boolElse : boolAdd ( boolOperator boolAdd )* ;
    [GrammarRule("boolElse")]
    private Lang2Parser.boolElse_return boolElse()
    {

        Lang2Parser.boolElse_return retval = new Lang2Parser.boolElse_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.boolAdd_return boolAdd32 = default(Lang2Parser.boolAdd_return);
        Lang2Parser.boolOperator_return boolOperator33 = default(Lang2Parser.boolOperator_return);
        Lang2Parser.boolAdd_return boolAdd34 = default(Lang2Parser.boolAdd_return);


    	try { DebugEnterRule(GrammarFileName, "boolElse");
    	DebugLocation(149, 3);
    	try
    	{
    		// Lang2.g:149:10: ( boolAdd ( boolOperator boolAdd )* )
    		DebugEnterAlt(1);
    		// Lang2.g:149:12: boolAdd ( boolOperator boolAdd )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(149, 12);
    		PushFollow(Follow._boolAdd_in_boolElse848);
    		boolAdd32=boolAdd();
    		PopFollow();

    		adaptor.AddChild(root_0, boolAdd32.Tree);
    		DebugLocation(149, 19);
    		// Lang2.g:149:19: ( boolOperator boolAdd )*
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
    				// Lang2.g:149:20: boolOperator boolAdd
    				{
    				DebugLocation(149, 32);
    				PushFollow(Follow._boolOperator_in_boolElse850);
    				boolOperator33=boolOperator();
    				PopFollow();

    				root_0 = (object)adaptor.BecomeRoot(boolOperator33.Tree, root_0);
    				DebugLocation(149, 34);
    				PushFollow(Follow._boolAdd_in_boolElse853);
    				boolAdd34=boolAdd();
    				PopFollow();

    				adaptor.AddChild(root_0, boolAdd34.Tree);

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
     	DebugLocation(150, 3);
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
    // Lang2.g:152:1: boolNegative : ( ( boolElse ) | ( NOT boolElse ) );
    [GrammarRule("boolNegative")]
    private Lang2Parser.boolNegative_return boolNegative()
    {

        Lang2Parser.boolNegative_return retval = new Lang2Parser.boolNegative_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken NOT36=null;
        Lang2Parser.boolElse_return boolElse35 = default(Lang2Parser.boolElse_return);
        Lang2Parser.boolElse_return boolElse37 = default(Lang2Parser.boolElse_return);

        object NOT36_tree=null;

    	try { DebugEnterRule(GrammarFileName, "boolNegative");
    	DebugLocation(152, 3);
    	try
    	{
    		// Lang2.g:152:14: ( ( boolElse ) | ( NOT boolElse ) )
    		int alt5=2;
    		try { DebugEnterDecision(5, decisionCanBacktrack[5]);
    		int LA5_0 = input.LA(1);

    		if (((LA5_0>=BOOLEAN && LA5_0<=STRING)||LA5_0==VARIABLE||LA5_0==70))
    		{
    			alt5=1;
    		}
    		else if ((LA5_0==NOT))
    		{
    			alt5=2;
    		}
    		else
    		{
    			NoViableAltException nvae = new NoViableAltException("", 5, 0, input);

    			DebugRecognitionException(nvae);
    			throw nvae;
    		}
    		} finally { DebugExitDecision(5); }
    		switch (alt5)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Lang2.g:152:16: ( boolElse )
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(152, 16);
    			// Lang2.g:152:16: ( boolElse )
    			DebugEnterAlt(1);
    			// Lang2.g:152:17: boolElse
    			{
    			DebugLocation(152, 17);
    			PushFollow(Follow._boolElse_in_boolNegative868);
    			boolElse35=boolElse();
    			PopFollow();

    			adaptor.AddChild(root_0, boolElse35.Tree);

    			}


    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Lang2.g:152:28: ( NOT boolElse )
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(152, 28);
    			// Lang2.g:152:28: ( NOT boolElse )
    			DebugEnterAlt(1);
    			// Lang2.g:152:29: NOT boolElse
    			{
    			DebugLocation(152, 32);
    			NOT36=(IToken)Match(input,NOT,Follow._NOT_in_boolNegative873); 
    			NOT36_tree = (object)adaptor.Create(NOT36);
    			root_0 = (object)adaptor.BecomeRoot(NOT36_tree, root_0);

    			DebugLocation(152, 34);
    			PushFollow(Follow._boolElse_in_boolNegative876);
    			boolElse37=boolElse();
    			PopFollow();

    			adaptor.AddChild(root_0, boolElse37.Tree);

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
     	DebugLocation(153, 3);
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
    // Lang2.g:155:1: useDiv : boolNegative ( ( DIV | MOD ) '(' boolNegative ')' )* ;
    [GrammarRule("useDiv")]
    private Lang2Parser.useDiv_return useDiv()
    {

        Lang2Parser.useDiv_return retval = new Lang2Parser.useDiv_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken set39=null;
        IToken char_literal40=null;
        IToken char_literal42=null;
        Lang2Parser.boolNegative_return boolNegative38 = default(Lang2Parser.boolNegative_return);
        Lang2Parser.boolNegative_return boolNegative41 = default(Lang2Parser.boolNegative_return);

        object set39_tree=null;
        object char_literal40_tree=null;
        object char_literal42_tree=null;

    	try { DebugEnterRule(GrammarFileName, "useDiv");
    	DebugLocation(155, 2);
    	try
    	{
    		// Lang2.g:155:8: ( boolNegative ( ( DIV | MOD ) '(' boolNegative ')' )* )
    		DebugEnterAlt(1);
    		// Lang2.g:155:10: boolNegative ( ( DIV | MOD ) '(' boolNegative ')' )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(155, 10);
    		PushFollow(Follow._boolNegative_in_useDiv889);
    		boolNegative38=boolNegative();
    		PopFollow();

    		adaptor.AddChild(root_0, boolNegative38.Tree);
    		DebugLocation(155, 22);
    		// Lang2.g:155:22: ( ( DIV | MOD ) '(' boolNegative ')' )*
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
    				// Lang2.g:155:23: ( DIV | MOD ) '(' boolNegative ')'
    				{
    				DebugLocation(155, 23);
    				set39=(IToken)input.LT(1);
    				set39=(IToken)input.LT(1);
    				if ((input.LA(1)>=DIV && input.LA(1)<=MOD))
    				{
    					input.Consume();
    					root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set39), root_0);
    					state.errorRecovery=false;
    				}
    				else
    				{
    					MismatchedSetException mse = new MismatchedSetException(null,input);
    					DebugRecognitionException(mse);
    					throw mse;
    				}

    				DebugLocation(155, 37);
    				char_literal40=(IToken)Match(input,70,Follow._70_in_useDiv898); 
    				DebugLocation(155, 39);
    				PushFollow(Follow._boolNegative_in_useDiv901);
    				boolNegative41=boolNegative();
    				PopFollow();

    				adaptor.AddChild(root_0, boolNegative41.Tree);
    				DebugLocation(155, 55);
    				char_literal42=(IToken)Match(input,71,Follow._71_in_useDiv903); 

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
     	DebugLocation(156, 2);
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
    // Lang2.g:158:1: mathMult : useDiv ( ( MULT | DIVIDE ) useDiv )* ;
    [GrammarRule("mathMult")]
    private Lang2Parser.mathMult_return mathMult()
    {

        Lang2Parser.mathMult_return retval = new Lang2Parser.mathMult_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken set44=null;
        Lang2Parser.useDiv_return useDiv43 = default(Lang2Parser.useDiv_return);
        Lang2Parser.useDiv_return useDiv45 = default(Lang2Parser.useDiv_return);

        object set44_tree=null;

    	try { DebugEnterRule(GrammarFileName, "mathMult");
    	DebugLocation(158, 1);
    	try
    	{
    		// Lang2.g:159:2: ( useDiv ( ( MULT | DIVIDE ) useDiv )* )
    		DebugEnterAlt(1);
    		// Lang2.g:159:4: useDiv ( ( MULT | DIVIDE ) useDiv )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(159, 4);
    		PushFollow(Follow._useDiv_in_mathMult920);
    		useDiv43=useDiv();
    		PopFollow();

    		adaptor.AddChild(root_0, useDiv43.Tree);
    		DebugLocation(159, 10);
    		// Lang2.g:159:10: ( ( MULT | DIVIDE ) useDiv )*
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
    				// Lang2.g:159:11: ( MULT | DIVIDE ) useDiv
    				{
    				DebugLocation(159, 11);
    				set44=(IToken)input.LT(1);
    				set44=(IToken)input.LT(1);
    				if ((input.LA(1)>=MULT && input.LA(1)<=DIVIDE))
    				{
    					input.Consume();
    					root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set44), root_0);
    					state.errorRecovery=false;
    				}
    				else
    				{
    					MismatchedSetException mse = new MismatchedSetException(null,input);
    					DebugRecognitionException(mse);
    					throw mse;
    				}

    				DebugLocation(159, 25);
    				PushFollow(Follow._useDiv_in_mathMult928);
    				useDiv45=useDiv();
    				PopFollow();

    				adaptor.AddChild(root_0, useDiv45.Tree);

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
     	DebugLocation(160, 1);
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
    // Lang2.g:162:1: mathAdd : mathMult ( ( ADD | REM ) mathMult )* ;
    [GrammarRule("mathAdd")]
    private Lang2Parser.mathAdd_return mathAdd()
    {

        Lang2Parser.mathAdd_return retval = new Lang2Parser.mathAdd_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken set47=null;
        Lang2Parser.mathMult_return mathMult46 = default(Lang2Parser.mathMult_return);
        Lang2Parser.mathMult_return mathMult48 = default(Lang2Parser.mathMult_return);

        object set47_tree=null;

    	try { DebugEnterRule(GrammarFileName, "mathAdd");
    	DebugLocation(162, 1);
    	try
    	{
    		// Lang2.g:162:9: ( mathMult ( ( ADD | REM ) mathMult )* )
    		DebugEnterAlt(1);
    		// Lang2.g:162:11: mathMult ( ( ADD | REM ) mathMult )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(162, 11);
    		PushFollow(Follow._mathMult_in_mathAdd941);
    		mathMult46=mathMult();
    		PopFollow();

    		adaptor.AddChild(root_0, mathMult46.Tree);
    		DebugLocation(162, 19);
    		// Lang2.g:162:19: ( ( ADD | REM ) mathMult )*
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
    				// Lang2.g:162:20: ( ADD | REM ) mathMult
    				{
    				DebugLocation(162, 20);
    				set47=(IToken)input.LT(1);
    				set47=(IToken)input.LT(1);
    				if ((input.LA(1)>=ADD && input.LA(1)<=REM))
    				{
    					input.Consume();
    					root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set47), root_0);
    					state.errorRecovery=false;
    				}
    				else
    				{
    					MismatchedSetException mse = new MismatchedSetException(null,input);
    					DebugRecognitionException(mse);
    					throw mse;
    				}

    				DebugLocation(162, 30);
    				PushFollow(Follow._mathMult_in_mathAdd949);
    				mathMult48=mathMult();
    				PopFollow();

    				adaptor.AddChild(root_0, mathMult48.Tree);

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
     	DebugLocation(163, 1);
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
    // Lang2.g:165:1: mathExpr : mathAdd ;
    [GrammarRule("mathExpr")]
    private Lang2Parser.mathExpr_return mathExpr()
    {

        Lang2Parser.mathExpr_return retval = new Lang2Parser.mathExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.mathAdd_return mathAdd49 = default(Lang2Parser.mathAdd_return);


    	try { DebugEnterRule(GrammarFileName, "mathExpr");
    	DebugLocation(165, 1);
    	try
    	{
    		// Lang2.g:166:2: ( mathAdd )
    		DebugEnterAlt(1);
    		// Lang2.g:166:4: mathAdd
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(166, 4);
    		PushFollow(Follow._mathAdd_in_mathExpr963);
    		mathAdd49=mathAdd();
    		PopFollow();

    		adaptor.AddChild(root_0, mathAdd49.Tree);

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
     	DebugLocation(168, 1);
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
    // Lang2.g:172:1: bodyOper : ( assExpr OP_END | conditionExpr | loopExpr | funcCall OP_END );
    [GrammarRule("bodyOper")]
    private Lang2Parser.bodyOper_return bodyOper()
    {

        Lang2Parser.bodyOper_return retval = new Lang2Parser.bodyOper_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken OP_END51=null;
        IToken OP_END55=null;
        Lang2Parser.assExpr_return assExpr50 = default(Lang2Parser.assExpr_return);
        Lang2Parser.conditionExpr_return conditionExpr52 = default(Lang2Parser.conditionExpr_return);
        Lang2Parser.loopExpr_return loopExpr53 = default(Lang2Parser.loopExpr_return);
        Lang2Parser.funcCall_return funcCall54 = default(Lang2Parser.funcCall_return);

        object OP_END51_tree=null;
        object OP_END55_tree=null;

    	try { DebugEnterRule(GrammarFileName, "bodyOper");
    	DebugLocation(172, 4);
    	try
    	{
    		// Lang2.g:172:10: ( assExpr OP_END | conditionExpr | loopExpr | funcCall OP_END )
    		int alt9=4;
    		try { DebugEnterDecision(9, decisionCanBacktrack[9]);
    		switch (input.LA(1))
    		{
    		case VARIABLE:
    			{
    			int LA9_1 = input.LA(2);

    			if ((LA9_1==ASSIGN||LA9_1==67))
    			{
    				alt9=1;
    			}
    			else if ((LA9_1==70))
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
    		case REPEAT:
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
    			// Lang2.g:172:12: assExpr OP_END
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(172, 12);
    			PushFollow(Follow._assExpr_in_bodyOper978);
    			assExpr50=assExpr();
    			PopFollow();

    			adaptor.AddChild(root_0, assExpr50.Tree);
    			DebugLocation(172, 26);
    			OP_END51=(IToken)Match(input,OP_END,Follow._OP_END_in_bodyOper980); 

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Lang2.g:173:6: conditionExpr
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(173, 6);
    			PushFollow(Follow._conditionExpr_in_bodyOper988);
    			conditionExpr52=conditionExpr();
    			PopFollow();

    			adaptor.AddChild(root_0, conditionExpr52.Tree);

    			}
    			break;
    		case 3:
    			DebugEnterAlt(3);
    			// Lang2.g:174:6: loopExpr
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(174, 6);
    			PushFollow(Follow._loopExpr_in_bodyOper995);
    			loopExpr53=loopExpr();
    			PopFollow();

    			adaptor.AddChild(root_0, loopExpr53.Tree);

    			}
    			break;
    		case 4:
    			DebugEnterAlt(4);
    			// Lang2.g:175:6: funcCall OP_END
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(175, 6);
    			PushFollow(Follow._funcCall_in_bodyOper1002);
    			funcCall54=funcCall();
    			PopFollow();

    			adaptor.AddChild(root_0, funcCall54.Tree);
    			DebugLocation(175, 21);
    			OP_END55=(IToken)Match(input,OP_END,Follow._OP_END_in_bodyOper1004); 

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
     	DebugLocation(176, 4);
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
    // Lang2.g:178:1: expressions : mathExpr ;
    [GrammarRule("expressions")]
    private Lang2Parser.expressions_return expressions()
    {

        Lang2Parser.expressions_return retval = new Lang2Parser.expressions_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.mathExpr_return mathExpr56 = default(Lang2Parser.mathExpr_return);


    	try { DebugEnterRule(GrammarFileName, "expressions");
    	DebugLocation(178, 4);
    	try
    	{
    		// Lang2.g:178:13: ( mathExpr )
    		DebugEnterAlt(1);
    		// Lang2.g:178:15: mathExpr
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(178, 15);
    		PushFollow(Follow._mathExpr_in_expressions1018);
    		mathExpr56=mathExpr();
    		PopFollow();

    		adaptor.AddChild(root_0, mathExpr56.Tree);

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
     	DebugLocation(179, 4);
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
    // Lang2.g:181:1: funcCallArgs : mathExpr ( ',' mathExpr )* ;
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
    	DebugLocation(181, 4);
    	try
    	{
    		// Lang2.g:181:14: ( mathExpr ( ',' mathExpr )* )
    		DebugEnterAlt(1);
    		// Lang2.g:181:17: mathExpr ( ',' mathExpr )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(181, 17);
    		PushFollow(Follow._mathExpr_in_funcCallArgs1032);
    		mathExpr57=mathExpr();
    		PopFollow();

    		adaptor.AddChild(root_0, mathExpr57.Tree);
    		DebugLocation(181, 25);
    		// Lang2.g:181:25: ( ',' mathExpr )*
    		try { DebugEnterSubRule(10);
    		while (true)
    		{
    			int alt10=2;
    			try { DebugEnterDecision(10, decisionCanBacktrack[10]);
    			int LA10_0 = input.LA(1);

    			if ((LA10_0==72))
    			{
    				alt10=1;
    			}


    			} finally { DebugExitDecision(10); }
    			switch ( alt10 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:181:26: ',' mathExpr
    				{
    				DebugLocation(181, 29);
    				char_literal58=(IToken)Match(input,72,Follow._72_in_funcCallArgs1034); 
    				DebugLocation(181, 31);
    				PushFollow(Follow._mathExpr_in_funcCallArgs1037);
    				mathExpr59=mathExpr();
    				PopFollow();

    				adaptor.AddChild(root_0, mathExpr59.Tree);

    				}
    				break;

    			default:
    				goto loop10;
    			}
    		}

    		loop10:
    			;

    		} finally { DebugExitSubRule(10); }


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
    // Lang2.g:183:1: funcCallArgsW : mathExpr ( ',' mathExpr )* -> ^( FUNC_CALL_ARGS mathExpr ( mathExpr )* ) ;
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
        RewriteRuleITokenStream stream_72=new RewriteRuleITokenStream(adaptor,"token 72");
        RewriteRuleSubtreeStream stream_mathExpr=new RewriteRuleSubtreeStream(adaptor,"rule mathExpr");
    	try { DebugEnterRule(GrammarFileName, "funcCallArgsW");
    	DebugLocation(183, 4);
    	try
    	{
    		// Lang2.g:183:15: ( mathExpr ( ',' mathExpr )* -> ^( FUNC_CALL_ARGS mathExpr ( mathExpr )* ) )
    		DebugEnterAlt(1);
    		// Lang2.g:183:17: mathExpr ( ',' mathExpr )*
    		{
    		DebugLocation(183, 17);
    		PushFollow(Follow._mathExpr_in_funcCallArgsW1052);
    		mathExpr60=mathExpr();
    		PopFollow();

    		stream_mathExpr.Add(mathExpr60.Tree);
    		DebugLocation(183, 25);
    		// Lang2.g:183:25: ( ',' mathExpr )*
    		try { DebugEnterSubRule(11);
    		while (true)
    		{
    			int alt11=2;
    			try { DebugEnterDecision(11, decisionCanBacktrack[11]);
    			int LA11_0 = input.LA(1);

    			if ((LA11_0==72))
    			{
    				alt11=1;
    			}


    			} finally { DebugExitDecision(11); }
    			switch ( alt11 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:183:26: ',' mathExpr
    				{
    				DebugLocation(183, 26);
    				char_literal61=(IToken)Match(input,72,Follow._72_in_funcCallArgsW1054);  
    				stream_72.Add(char_literal61);

    				DebugLocation(183, 30);
    				PushFollow(Follow._mathExpr_in_funcCallArgsW1056);
    				mathExpr62=mathExpr();
    				PopFollow();

    				stream_mathExpr.Add(mathExpr62.Tree);

    				}
    				break;

    			default:
    				goto loop11;
    			}
    		}

    		loop11:
    			;

    		} finally { DebugExitSubRule(11); }



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
    		// 183:41: -> ^( FUNC_CALL_ARGS mathExpr ( mathExpr )* )
    		{
    			DebugLocation(183, 44);
    			// Lang2.g:183:44: ^( FUNC_CALL_ARGS mathExpr ( mathExpr )* )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(183, 46);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_CALL_ARGS, "FUNC_CALL_ARGS"), root_1);

    			DebugLocation(183, 61);
    			adaptor.AddChild(root_1, stream_mathExpr.NextTree());
    			DebugLocation(183, 70);
    			// Lang2.g:183:70: ( mathExpr )*
    			while ( stream_mathExpr.HasNext )
    			{
    				DebugLocation(183, 70);
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
     	DebugLocation(184, 4);
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
    // Lang2.g:186:1: funcCall : VARIABLE '(' ( funcCallArgsW )? ')' -> ^( FUNC_CALL VARIABLE ( funcCallArgsW )? ) ;
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
        RewriteRuleITokenStream stream_VARIABLE=new RewriteRuleITokenStream(adaptor,"token VARIABLE");
        RewriteRuleITokenStream stream_70=new RewriteRuleITokenStream(adaptor,"token 70");
        RewriteRuleITokenStream stream_71=new RewriteRuleITokenStream(adaptor,"token 71");
        RewriteRuleSubtreeStream stream_funcCallArgsW=new RewriteRuleSubtreeStream(adaptor,"rule funcCallArgsW");
    	try { DebugEnterRule(GrammarFileName, "funcCall");
    	DebugLocation(186, 3);
    	try
    	{
    		// Lang2.g:186:10: ( VARIABLE '(' ( funcCallArgsW )? ')' -> ^( FUNC_CALL VARIABLE ( funcCallArgsW )? ) )
    		DebugEnterAlt(1);
    		// Lang2.g:186:12: VARIABLE '(' ( funcCallArgsW )? ')'
    		{
    		DebugLocation(186, 12);
    		VARIABLE63=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_funcCall1082);  
    		stream_VARIABLE.Add(VARIABLE63);

    		DebugLocation(186, 20);
    		char_literal64=(IToken)Match(input,70,Follow._70_in_funcCall1083);  
    		stream_70.Add(char_literal64);

    		DebugLocation(186, 24);
    		// Lang2.g:186:24: ( funcCallArgsW )?
    		int alt12=2;
    		try { DebugEnterSubRule(12);
    		try { DebugEnterDecision(12, decisionCanBacktrack[12]);
    		int LA12_0 = input.LA(1);

    		if ((LA12_0==NOT||(LA12_0>=BOOLEAN && LA12_0<=STRING)||LA12_0==VARIABLE||LA12_0==70))
    		{
    			alt12=1;
    		}
    		} finally { DebugExitDecision(12); }
    		switch (alt12)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Lang2.g:186:24: funcCallArgsW
    			{
    			DebugLocation(186, 24);
    			PushFollow(Follow._funcCallArgsW_in_funcCall1085);
    			funcCallArgsW65=funcCallArgsW();
    			PopFollow();

    			stream_funcCallArgsW.Add(funcCallArgsW65.Tree);

    			}
    			break;

    		}
    		} finally { DebugExitSubRule(12); }

    		DebugLocation(186, 39);
    		char_literal66=(IToken)Match(input,71,Follow._71_in_funcCall1088);  
    		stream_71.Add(char_literal66);



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
    		// 186:43: -> ^( FUNC_CALL VARIABLE ( funcCallArgsW )? )
    		{
    			DebugLocation(186, 46);
    			// Lang2.g:186:46: ^( FUNC_CALL VARIABLE ( funcCallArgsW )? )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(186, 48);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_CALL, "FUNC_CALL"), root_1);

    			DebugLocation(186, 58);
    			adaptor.AddChild(root_1, stream_VARIABLE.NextNode());
    			DebugLocation(186, 67);
    			// Lang2.g:186:67: ( funcCallArgsW )?
    			if ( stream_funcCallArgsW.HasNext )
    			{
    				DebugLocation(186, 67);
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
     	DebugLocation(187, 3);
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
    // Lang2.g:189:1: argDeclExpr : '(' ( argDeclMany )? ')' -> ^( FUNC_PROC_ARGS ( argDeclMany )? ) ;
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
        RewriteRuleITokenStream stream_70=new RewriteRuleITokenStream(adaptor,"token 70");
        RewriteRuleITokenStream stream_71=new RewriteRuleITokenStream(adaptor,"token 71");
        RewriteRuleSubtreeStream stream_argDeclMany=new RewriteRuleSubtreeStream(adaptor,"rule argDeclMany");
    	try { DebugEnterRule(GrammarFileName, "argDeclExpr");
    	DebugLocation(189, 3);
    	try
    	{
    		// Lang2.g:189:13: ( '(' ( argDeclMany )? ')' -> ^( FUNC_PROC_ARGS ( argDeclMany )? ) )
    		DebugEnterAlt(1);
    		// Lang2.g:189:15: '(' ( argDeclMany )? ')'
    		{
    		DebugLocation(189, 18);
    		char_literal67=(IToken)Match(input,70,Follow._70_in_argDeclExpr1112);  
    		stream_70.Add(char_literal67);

    		DebugLocation(189, 20);
    		// Lang2.g:189:20: ( argDeclMany )?
    		int alt13=2;
    		try { DebugEnterSubRule(13);
    		try { DebugEnterDecision(13, decisionCanBacktrack[13]);
    		int LA13_0 = input.LA(1);

    		if ((LA13_0==VAR||LA13_0==VARIABLE))
    		{
    			alt13=1;
    		}
    		} finally { DebugExitDecision(13); }
    		switch (alt13)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Lang2.g:189:20: argDeclMany
    			{
    			DebugLocation(189, 20);
    			PushFollow(Follow._argDeclMany_in_argDeclExpr1115);
    			argDeclMany68=argDeclMany();
    			PopFollow();

    			stream_argDeclMany.Add(argDeclMany68.Tree);

    			}
    			break;

    		}
    		} finally { DebugExitSubRule(13); }

    		DebugLocation(189, 36);
    		char_literal69=(IToken)Match(input,71,Follow._71_in_argDeclExpr1118);  
    		stream_71.Add(char_literal69);



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
    		// 189:38: -> ^( FUNC_PROC_ARGS ( argDeclMany )? )
    		{
    			DebugLocation(189, 41);
    			// Lang2.g:189:41: ^( FUNC_PROC_ARGS ( argDeclMany )? )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(189, 43);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_PROC_ARGS, "FUNC_PROC_ARGS"), root_1);

    			DebugLocation(189, 58);
    			// Lang2.g:189:58: ( argDeclMany )?
    			if ( stream_argDeclMany.HasNext )
    			{
    				DebugLocation(189, 58);
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
     	DebugLocation(190, 3);
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
    // Lang2.g:192:1: retTypeExpr : ( T_INT | T_BOOL | T_CHAR | T_STRING ) ;
    [GrammarRule("retTypeExpr")]
    private Lang2Parser.retTypeExpr_return retTypeExpr()
    {

        Lang2Parser.retTypeExpr_return retval = new Lang2Parser.retTypeExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken set70=null;

        object set70_tree=null;

    	try { DebugEnterRule(GrammarFileName, "retTypeExpr");
    	DebugLocation(192, 3);
    	try
    	{
    		// Lang2.g:192:13: ( ( T_INT | T_BOOL | T_CHAR | T_STRING ) )
    		DebugEnterAlt(1);
    		// Lang2.g:192:15: ( T_INT | T_BOOL | T_CHAR | T_STRING )
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(192, 15);
    		set70=(IToken)input.LT(1);
    		if ((input.LA(1)>=T_CHAR && input.LA(1)<=T_STRING))
    		{
    			input.Consume();
    			adaptor.AddChild(root_0, (object)adaptor.Create(set70));
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
     	DebugLocation(193, 3);
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
    // Lang2.g:195:1: retTypeExprWrap : retTypeExpr -> ^( FUNC_PROC_RET_TYPE retTypeExpr ) ;
    [GrammarRule("retTypeExprWrap")]
    private Lang2Parser.retTypeExprWrap_return retTypeExprWrap()
    {

        Lang2Parser.retTypeExprWrap_return retval = new Lang2Parser.retTypeExprWrap_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.retTypeExpr_return retTypeExpr71 = default(Lang2Parser.retTypeExpr_return);

        RewriteRuleSubtreeStream stream_retTypeExpr=new RewriteRuleSubtreeStream(adaptor,"rule retTypeExpr");
    	try { DebugEnterRule(GrammarFileName, "retTypeExprWrap");
    	DebugLocation(195, 4);
    	try
    	{
    		// Lang2.g:195:17: ( retTypeExpr -> ^( FUNC_PROC_RET_TYPE retTypeExpr ) )
    		DebugEnterAlt(1);
    		// Lang2.g:195:19: retTypeExpr
    		{
    		DebugLocation(195, 19);
    		PushFollow(Follow._retTypeExpr_in_retTypeExprWrap1160);
    		retTypeExpr71=retTypeExpr();
    		PopFollow();

    		stream_retTypeExpr.Add(retTypeExpr71.Tree);


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
    		// 195:31: -> ^( FUNC_PROC_RET_TYPE retTypeExpr )
    		{
    			DebugLocation(195, 34);
    			// Lang2.g:195:34: ^( FUNC_PROC_RET_TYPE retTypeExpr )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(195, 36);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_PROC_RET_TYPE, "FUNC_PROC_RET_TYPE"), root_1);

    			DebugLocation(195, 55);
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
     	DebugLocation(196, 4);
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
    // Lang2.g:198:1: bodyFuncProcExpr : ( varDeclW )? bodyExpr ;
    [GrammarRule("bodyFuncProcExpr")]
    private Lang2Parser.bodyFuncProcExpr_return bodyFuncProcExpr()
    {

        Lang2Parser.bodyFuncProcExpr_return retval = new Lang2Parser.bodyFuncProcExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.varDeclW_return varDeclW72 = default(Lang2Parser.varDeclW_return);
        Lang2Parser.bodyExpr_return bodyExpr73 = default(Lang2Parser.bodyExpr_return);


    	try { DebugEnterRule(GrammarFileName, "bodyFuncProcExpr");
    	DebugLocation(198, 5);
    	try
    	{
    		// Lang2.g:198:18: ( ( varDeclW )? bodyExpr )
    		DebugEnterAlt(1);
    		// Lang2.g:198:20: ( varDeclW )? bodyExpr
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(198, 20);
    		// Lang2.g:198:20: ( varDeclW )?
    		int alt14=2;
    		try { DebugEnterSubRule(14);
    		try { DebugEnterDecision(14, decisionCanBacktrack[14]);
    		int LA14_0 = input.LA(1);

    		if ((LA14_0==VAR))
    		{
    			alt14=1;
    		}
    		} finally { DebugExitDecision(14); }
    		switch (alt14)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Lang2.g:198:20: varDeclW
    			{
    			DebugLocation(198, 20);
    			PushFollow(Follow._varDeclW_in_bodyFuncProcExpr1181);
    			varDeclW72=varDeclW();
    			PopFollow();

    			adaptor.AddChild(root_0, varDeclW72.Tree);

    			}
    			break;

    		}
    		} finally { DebugExitSubRule(14); }

    		DebugLocation(198, 30);
    		PushFollow(Follow._bodyExpr_in_bodyFuncProcExpr1184);
    		bodyExpr73=bodyExpr();
    		PopFollow();

    		adaptor.AddChild(root_0, bodyExpr73.Tree);

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
     	DebugLocation(199, 5);
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
    // Lang2.g:201:1: funcDeclare : FUNCTION VARIABLE argDeclExpr ':' retTypeExprWrap OP_END bodyFuncProcExpr -> ^( FUNC_DECL VARIABLE argDeclExpr retTypeExprWrap bodyFuncProcExpr ) ;
    [GrammarRule("funcDeclare")]
    private Lang2Parser.funcDeclare_return funcDeclare()
    {

        Lang2Parser.funcDeclare_return retval = new Lang2Parser.funcDeclare_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken FUNCTION74=null;
        IToken VARIABLE75=null;
        IToken char_literal77=null;
        IToken OP_END79=null;
        Lang2Parser.argDeclExpr_return argDeclExpr76 = default(Lang2Parser.argDeclExpr_return);
        Lang2Parser.retTypeExprWrap_return retTypeExprWrap78 = default(Lang2Parser.retTypeExprWrap_return);
        Lang2Parser.bodyFuncProcExpr_return bodyFuncProcExpr80 = default(Lang2Parser.bodyFuncProcExpr_return);

        object FUNCTION74_tree=null;
        object VARIABLE75_tree=null;
        object char_literal77_tree=null;
        object OP_END79_tree=null;
        RewriteRuleITokenStream stream_FUNCTION=new RewriteRuleITokenStream(adaptor,"token FUNCTION");
        RewriteRuleITokenStream stream_VARIABLE=new RewriteRuleITokenStream(adaptor,"token VARIABLE");
        RewriteRuleITokenStream stream_OP_END=new RewriteRuleITokenStream(adaptor,"token OP_END");
        RewriteRuleITokenStream stream_73=new RewriteRuleITokenStream(adaptor,"token 73");
        RewriteRuleSubtreeStream stream_argDeclExpr=new RewriteRuleSubtreeStream(adaptor,"rule argDeclExpr");
        RewriteRuleSubtreeStream stream_bodyFuncProcExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodyFuncProcExpr");
        RewriteRuleSubtreeStream stream_retTypeExprWrap=new RewriteRuleSubtreeStream(adaptor,"rule retTypeExprWrap");
    	try { DebugEnterRule(GrammarFileName, "funcDeclare");
    	DebugLocation(201, 3);
    	try
    	{
    		// Lang2.g:201:12: ( FUNCTION VARIABLE argDeclExpr ':' retTypeExprWrap OP_END bodyFuncProcExpr -> ^( FUNC_DECL VARIABLE argDeclExpr retTypeExprWrap bodyFuncProcExpr ) )
    		DebugEnterAlt(1);
    		// Lang2.g:201:14: FUNCTION VARIABLE argDeclExpr ':' retTypeExprWrap OP_END bodyFuncProcExpr
    		{
    		DebugLocation(201, 14);
    		FUNCTION74=(IToken)Match(input,FUNCTION,Follow._FUNCTION_in_funcDeclare1197);  
    		stream_FUNCTION.Add(FUNCTION74);

    		DebugLocation(201, 23);
    		VARIABLE75=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_funcDeclare1199);  
    		stream_VARIABLE.Add(VARIABLE75);

    		DebugLocation(201, 32);
    		PushFollow(Follow._argDeclExpr_in_funcDeclare1201);
    		argDeclExpr76=argDeclExpr();
    		PopFollow();

    		stream_argDeclExpr.Add(argDeclExpr76.Tree);
    		DebugLocation(201, 43);
    		char_literal77=(IToken)Match(input,73,Follow._73_in_funcDeclare1202);  
    		stream_73.Add(char_literal77);

    		DebugLocation(201, 47);
    		PushFollow(Follow._retTypeExprWrap_in_funcDeclare1204);
    		retTypeExprWrap78=retTypeExprWrap();
    		PopFollow();

    		stream_retTypeExprWrap.Add(retTypeExprWrap78.Tree);
    		DebugLocation(201, 69);
    		OP_END79=(IToken)Match(input,OP_END,Follow._OP_END_in_funcDeclare1206);  
    		stream_OP_END.Add(OP_END79);

    		DebugLocation(201, 72);
    		PushFollow(Follow._bodyFuncProcExpr_in_funcDeclare1210);
    		bodyFuncProcExpr80=bodyFuncProcExpr();
    		PopFollow();

    		stream_bodyFuncProcExpr.Add(bodyFuncProcExpr80.Tree);


    		{
    		// AST REWRITE
    		// elements: retTypeExprWrap, argDeclExpr, bodyFuncProcExpr, VARIABLE
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 201:89: -> ^( FUNC_DECL VARIABLE argDeclExpr retTypeExprWrap bodyFuncProcExpr )
    		{
    			DebugLocation(201, 92);
    			// Lang2.g:201:92: ^( FUNC_DECL VARIABLE argDeclExpr retTypeExprWrap bodyFuncProcExpr )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(201, 94);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_DECL, "FUNC_DECL"), root_1);

    			DebugLocation(201, 104);
    			adaptor.AddChild(root_1, stream_VARIABLE.NextNode());
    			DebugLocation(201, 113);
    			adaptor.AddChild(root_1, stream_argDeclExpr.NextTree());
    			DebugLocation(201, 125);
    			adaptor.AddChild(root_1, stream_retTypeExprWrap.NextTree());
    			DebugLocation(201, 141);
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
     	DebugLocation(202, 3);
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
    // Lang2.g:204:1: procedureDeclare : PROCEDURE VARIABLE argDeclExpr OP_END bodyFuncProcExpr -> ^( PROC_DECL VARIABLE argDeclExpr bodyFuncProcExpr ) ;
    [GrammarRule("procedureDeclare")]
    private Lang2Parser.procedureDeclare_return procedureDeclare()
    {

        Lang2Parser.procedureDeclare_return retval = new Lang2Parser.procedureDeclare_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken PROCEDURE81=null;
        IToken VARIABLE82=null;
        IToken OP_END84=null;
        Lang2Parser.argDeclExpr_return argDeclExpr83 = default(Lang2Parser.argDeclExpr_return);
        Lang2Parser.bodyFuncProcExpr_return bodyFuncProcExpr85 = default(Lang2Parser.bodyFuncProcExpr_return);

        object PROCEDURE81_tree=null;
        object VARIABLE82_tree=null;
        object OP_END84_tree=null;
        RewriteRuleITokenStream stream_VARIABLE=new RewriteRuleITokenStream(adaptor,"token VARIABLE");
        RewriteRuleITokenStream stream_OP_END=new RewriteRuleITokenStream(adaptor,"token OP_END");
        RewriteRuleITokenStream stream_PROCEDURE=new RewriteRuleITokenStream(adaptor,"token PROCEDURE");
        RewriteRuleSubtreeStream stream_argDeclExpr=new RewriteRuleSubtreeStream(adaptor,"rule argDeclExpr");
        RewriteRuleSubtreeStream stream_bodyFuncProcExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodyFuncProcExpr");
    	try { DebugEnterRule(GrammarFileName, "procedureDeclare");
    	DebugLocation(204, 4);
    	try
    	{
    		// Lang2.g:204:17: ( PROCEDURE VARIABLE argDeclExpr OP_END bodyFuncProcExpr -> ^( PROC_DECL VARIABLE argDeclExpr bodyFuncProcExpr ) )
    		DebugEnterAlt(1);
    		// Lang2.g:204:19: PROCEDURE VARIABLE argDeclExpr OP_END bodyFuncProcExpr
    		{
    		DebugLocation(204, 19);
    		PROCEDURE81=(IToken)Match(input,PROCEDURE,Follow._PROCEDURE_in_procedureDeclare1235);  
    		stream_PROCEDURE.Add(PROCEDURE81);

    		DebugLocation(204, 29);
    		VARIABLE82=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_procedureDeclare1237);  
    		stream_VARIABLE.Add(VARIABLE82);

    		DebugLocation(204, 38);
    		PushFollow(Follow._argDeclExpr_in_procedureDeclare1239);
    		argDeclExpr83=argDeclExpr();
    		PopFollow();

    		stream_argDeclExpr.Add(argDeclExpr83.Tree);
    		DebugLocation(204, 50);
    		OP_END84=(IToken)Match(input,OP_END,Follow._OP_END_in_procedureDeclare1241);  
    		stream_OP_END.Add(OP_END84);

    		DebugLocation(204, 57);
    		PushFollow(Follow._bodyFuncProcExpr_in_procedureDeclare1243);
    		bodyFuncProcExpr85=bodyFuncProcExpr();
    		PopFollow();

    		stream_bodyFuncProcExpr.Add(bodyFuncProcExpr85.Tree);


    		{
    		// AST REWRITE
    		// elements: argDeclExpr, bodyFuncProcExpr, VARIABLE
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 204:74: -> ^( PROC_DECL VARIABLE argDeclExpr bodyFuncProcExpr )
    		{
    			DebugLocation(204, 77);
    			// Lang2.g:204:77: ^( PROC_DECL VARIABLE argDeclExpr bodyFuncProcExpr )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(204, 79);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PROC_DECL, "PROC_DECL"), root_1);

    			DebugLocation(204, 89);
    			adaptor.AddChild(root_1, stream_VARIABLE.NextNode());
    			DebugLocation(204, 98);
    			adaptor.AddChild(root_1, stream_argDeclExpr.NextTree());
    			DebugLocation(204, 110);
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
     	DebugLocation(205, 4);
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
    // Lang2.g:209:1: conditionElseExpr : ELSE bodyExpr -> ^( ELSE bodyExpr ) ;
    [GrammarRule("conditionElseExpr")]
    private Lang2Parser.conditionElseExpr_return conditionElseExpr()
    {

        Lang2Parser.conditionElseExpr_return retval = new Lang2Parser.conditionElseExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken ELSE86=null;
        Lang2Parser.bodyExpr_return bodyExpr87 = default(Lang2Parser.bodyExpr_return);

        object ELSE86_tree=null;
        RewriteRuleITokenStream stream_ELSE=new RewriteRuleITokenStream(adaptor,"token ELSE");
        RewriteRuleSubtreeStream stream_bodyExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodyExpr");
    	try { DebugEnterRule(GrammarFileName, "conditionElseExpr");
    	DebugLocation(209, 5);
    	try
    	{
    		// Lang2.g:209:19: ( ELSE bodyExpr -> ^( ELSE bodyExpr ) )
    		DebugEnterAlt(1);
    		// Lang2.g:209:21: ELSE bodyExpr
    		{
    		DebugLocation(209, 25);
    		ELSE86=(IToken)Match(input,ELSE,Follow._ELSE_in_conditionElseExpr1270);  
    		stream_ELSE.Add(ELSE86);

    		DebugLocation(209, 27);
    		PushFollow(Follow._bodyExpr_in_conditionElseExpr1273);
    		bodyExpr87=bodyExpr();
    		PopFollow();

    		stream_bodyExpr.Add(bodyExpr87.Tree);


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
    		// 209:36: -> ^( ELSE bodyExpr )
    		{
    			DebugLocation(209, 39);
    			// Lang2.g:209:39: ^( ELSE bodyExpr )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(209, 41);
    			root_1 = (object)adaptor.BecomeRoot(stream_ELSE.NextNode(), root_1);

    			DebugLocation(209, 46);
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
     	DebugLocation(210, 5);
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
    // Lang2.g:211:1: condExpr : expressions -> ^( CONDITION expressions ) ;
    [GrammarRule("condExpr")]
    private Lang2Parser.condExpr_return condExpr()
    {

        Lang2Parser.condExpr_return retval = new Lang2Parser.condExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.expressions_return expressions88 = default(Lang2Parser.expressions_return);

        RewriteRuleSubtreeStream stream_expressions=new RewriteRuleSubtreeStream(adaptor,"rule expressions");
    	try { DebugEnterRule(GrammarFileName, "condExpr");
    	DebugLocation(211, 3);
    	try
    	{
    		// Lang2.g:211:10: ( expressions -> ^( CONDITION expressions ) )
    		DebugEnterAlt(1);
    		// Lang2.g:211:13: expressions
    		{
    		DebugLocation(211, 13);
    		PushFollow(Follow._expressions_in_condExpr1295);
    		expressions88=expressions();
    		PopFollow();

    		stream_expressions.Add(expressions88.Tree);


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
    		// 211:26: -> ^( CONDITION expressions )
    		{
    			DebugLocation(211, 29);
    			// Lang2.g:211:29: ^( CONDITION expressions )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(211, 31);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(CONDITION, "CONDITION"), root_1);

    			DebugLocation(211, 41);
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
     	DebugLocation(212, 3);
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
    // Lang2.g:213:1: conditionExpr : IF condExpr THEN bodyExpr ( conditionElseExpr )? -> ^( IF condExpr bodyExpr ( conditionElseExpr )? ) ;
    [GrammarRule("conditionExpr")]
    private Lang2Parser.conditionExpr_return conditionExpr()
    {

        Lang2Parser.conditionExpr_return retval = new Lang2Parser.conditionExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken IF89=null;
        IToken THEN91=null;
        Lang2Parser.condExpr_return condExpr90 = default(Lang2Parser.condExpr_return);
        Lang2Parser.bodyExpr_return bodyExpr92 = default(Lang2Parser.bodyExpr_return);
        Lang2Parser.conditionElseExpr_return conditionElseExpr93 = default(Lang2Parser.conditionElseExpr_return);

        object IF89_tree=null;
        object THEN91_tree=null;
        RewriteRuleITokenStream stream_THEN=new RewriteRuleITokenStream(adaptor,"token THEN");
        RewriteRuleITokenStream stream_IF=new RewriteRuleITokenStream(adaptor,"token IF");
        RewriteRuleSubtreeStream stream_condExpr=new RewriteRuleSubtreeStream(adaptor,"rule condExpr");
        RewriteRuleSubtreeStream stream_conditionElseExpr=new RewriteRuleSubtreeStream(adaptor,"rule conditionElseExpr");
        RewriteRuleSubtreeStream stream_bodyExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodyExpr");
    	try { DebugEnterRule(GrammarFileName, "conditionExpr");
    	DebugLocation(213, 1);
    	try
    	{
    		// Lang2.g:213:14: ( IF condExpr THEN bodyExpr ( conditionElseExpr )? -> ^( IF condExpr bodyExpr ( conditionElseExpr )? ) )
    		DebugEnterAlt(1);
    		// Lang2.g:213:16: IF condExpr THEN bodyExpr ( conditionElseExpr )?
    		{
    		DebugLocation(213, 16);
    		IF89=(IToken)Match(input,IF,Follow._IF_in_conditionExpr1314);  
    		stream_IF.Add(IF89);

    		DebugLocation(213, 19);
    		PushFollow(Follow._condExpr_in_conditionExpr1316);
    		condExpr90=condExpr();
    		PopFollow();

    		stream_condExpr.Add(condExpr90.Tree);
    		DebugLocation(213, 32);
    		THEN91=(IToken)Match(input,THEN,Follow._THEN_in_conditionExpr1318);  
    		stream_THEN.Add(THEN91);

    		DebugLocation(213, 34);
    		PushFollow(Follow._bodyExpr_in_conditionExpr1321);
    		bodyExpr92=bodyExpr();
    		PopFollow();

    		stream_bodyExpr.Add(bodyExpr92.Tree);
    		DebugLocation(213, 43);
    		// Lang2.g:213:43: ( conditionElseExpr )?
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
    			// Lang2.g:213:43: conditionElseExpr
    			{
    			DebugLocation(213, 43);
    			PushFollow(Follow._conditionElseExpr_in_conditionExpr1323);
    			conditionElseExpr93=conditionElseExpr();
    			PopFollow();

    			stream_conditionElseExpr.Add(conditionElseExpr93.Tree);

    			}
    			break;

    		}
    		} finally { DebugExitSubRule(15); }



    		{
    		// AST REWRITE
    		// elements: conditionElseExpr, IF, condExpr, bodyExpr
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 213:62: -> ^( IF condExpr bodyExpr ( conditionElseExpr )? )
    		{
    			DebugLocation(213, 65);
    			// Lang2.g:213:65: ^( IF condExpr bodyExpr ( conditionElseExpr )? )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(213, 67);
    			root_1 = (object)adaptor.BecomeRoot(stream_IF.NextNode(), root_1);

    			DebugLocation(213, 70);
    			adaptor.AddChild(root_1, stream_condExpr.NextTree());
    			DebugLocation(213, 79);
    			adaptor.AddChild(root_1, stream_bodyExpr.NextTree());
    			DebugLocation(213, 88);
    			// Lang2.g:213:88: ( conditionElseExpr )?
    			if ( stream_conditionElseExpr.HasNext )
    			{
    				DebugLocation(213, 88);
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
     	DebugLocation(214, 1);
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
    // Lang2.g:217:1: forExpr : assExpr TO expressions ;
    [GrammarRule("forExpr")]
    private Lang2Parser.forExpr_return forExpr()
    {

        Lang2Parser.forExpr_return retval = new Lang2Parser.forExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken TO95=null;
        Lang2Parser.assExpr_return assExpr94 = default(Lang2Parser.assExpr_return);
        Lang2Parser.expressions_return expressions96 = default(Lang2Parser.expressions_return);

        object TO95_tree=null;

    	try { DebugEnterRule(GrammarFileName, "forExpr");
    	DebugLocation(217, 2);
    	try
    	{
    		// Lang2.g:217:9: ( assExpr TO expressions )
    		DebugEnterAlt(1);
    		// Lang2.g:217:12: assExpr TO expressions
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(217, 12);
    		PushFollow(Follow._assExpr_in_forExpr1349);
    		assExpr94=assExpr();
    		PopFollow();

    		adaptor.AddChild(root_0, assExpr94.Tree);
    		DebugLocation(217, 22);
    		TO95=(IToken)Match(input,TO,Follow._TO_in_forExpr1351); 
    		TO95_tree = (object)adaptor.Create(TO95);
    		root_0 = (object)adaptor.BecomeRoot(TO95_tree, root_0);

    		DebugLocation(217, 24);
    		PushFollow(Follow._expressions_in_forExpr1354);
    		expressions96=expressions();
    		PopFollow();

    		adaptor.AddChild(root_0, expressions96.Tree);

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
     	DebugLocation(218, 2);
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
    // Lang2.g:220:1: loopExpr : ( WHILE condExpr DO bodyExpr -> ^( WHILE condExpr bodyExpr ) | FOR forExpr DO bodyExpr -> ^( FOR forExpr bodyExpr ) | REPEAT bodyExpr UNTIL condExpr OP_END -> ^( REPEAT condExpr bodyExpr ) );
    [GrammarRule("loopExpr")]
    private Lang2Parser.loopExpr_return loopExpr()
    {

        Lang2Parser.loopExpr_return retval = new Lang2Parser.loopExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken WHILE97=null;
        IToken DO99=null;
        IToken FOR101=null;
        IToken DO103=null;
        IToken REPEAT105=null;
        IToken UNTIL107=null;
        IToken OP_END109=null;
        Lang2Parser.condExpr_return condExpr98 = default(Lang2Parser.condExpr_return);
        Lang2Parser.bodyExpr_return bodyExpr100 = default(Lang2Parser.bodyExpr_return);
        Lang2Parser.forExpr_return forExpr102 = default(Lang2Parser.forExpr_return);
        Lang2Parser.bodyExpr_return bodyExpr104 = default(Lang2Parser.bodyExpr_return);
        Lang2Parser.bodyExpr_return bodyExpr106 = default(Lang2Parser.bodyExpr_return);
        Lang2Parser.condExpr_return condExpr108 = default(Lang2Parser.condExpr_return);

        object WHILE97_tree=null;
        object DO99_tree=null;
        object FOR101_tree=null;
        object DO103_tree=null;
        object REPEAT105_tree=null;
        object UNTIL107_tree=null;
        object OP_END109_tree=null;
        RewriteRuleITokenStream stream_FOR=new RewriteRuleITokenStream(adaptor,"token FOR");
        RewriteRuleITokenStream stream_DO=new RewriteRuleITokenStream(adaptor,"token DO");
        RewriteRuleITokenStream stream_REPEAT=new RewriteRuleITokenStream(adaptor,"token REPEAT");
        RewriteRuleITokenStream stream_OP_END=new RewriteRuleITokenStream(adaptor,"token OP_END");
        RewriteRuleITokenStream stream_WHILE=new RewriteRuleITokenStream(adaptor,"token WHILE");
        RewriteRuleITokenStream stream_UNTIL=new RewriteRuleITokenStream(adaptor,"token UNTIL");
        RewriteRuleSubtreeStream stream_condExpr=new RewriteRuleSubtreeStream(adaptor,"rule condExpr");
        RewriteRuleSubtreeStream stream_bodyExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodyExpr");
        RewriteRuleSubtreeStream stream_forExpr=new RewriteRuleSubtreeStream(adaptor,"rule forExpr");
    	try { DebugEnterRule(GrammarFileName, "loopExpr");
    	DebugLocation(220, 2);
    	try
    	{
    		// Lang2.g:220:9: ( WHILE condExpr DO bodyExpr -> ^( WHILE condExpr bodyExpr ) | FOR forExpr DO bodyExpr -> ^( FOR forExpr bodyExpr ) | REPEAT bodyExpr UNTIL condExpr OP_END -> ^( REPEAT condExpr bodyExpr ) )
    		int alt16=3;
    		try { DebugEnterDecision(16, decisionCanBacktrack[16]);
    		switch (input.LA(1))
    		{
    		case WHILE:
    			{
    			alt16=1;
    			}
    			break;
    		case FOR:
    			{
    			alt16=2;
    			}
    			break;
    		case REPEAT:
    			{
    			alt16=3;
    			}
    			break;
    		default:
    			{
    				NoViableAltException nvae = new NoViableAltException("", 16, 0, input);

    				DebugRecognitionException(nvae);
    				throw nvae;
    			}
    		}

    		} finally { DebugExitDecision(16); }
    		switch (alt16)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Lang2.g:220:11: WHILE condExpr DO bodyExpr
    			{
    			DebugLocation(220, 11);
    			WHILE97=(IToken)Match(input,WHILE,Follow._WHILE_in_loopExpr1364);  
    			stream_WHILE.Add(WHILE97);

    			DebugLocation(220, 17);
    			PushFollow(Follow._condExpr_in_loopExpr1366);
    			condExpr98=condExpr();
    			PopFollow();

    			stream_condExpr.Add(condExpr98.Tree);
    			DebugLocation(220, 28);
    			DO99=(IToken)Match(input,DO,Follow._DO_in_loopExpr1368);  
    			stream_DO.Add(DO99);

    			DebugLocation(220, 30);
    			PushFollow(Follow._bodyExpr_in_loopExpr1371);
    			bodyExpr100=bodyExpr();
    			PopFollow();

    			stream_bodyExpr.Add(bodyExpr100.Tree);


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
    			// 220:39: -> ^( WHILE condExpr bodyExpr )
    			{
    				DebugLocation(220, 42);
    				// Lang2.g:220:42: ^( WHILE condExpr bodyExpr )
    				{
    				object root_1 = (object)adaptor.Nil();
    				DebugLocation(220, 44);
    				root_1 = (object)adaptor.BecomeRoot(stream_WHILE.NextNode(), root_1);

    				DebugLocation(220, 50);
    				adaptor.AddChild(root_1, stream_condExpr.NextTree());
    				DebugLocation(220, 59);
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
    			// Lang2.g:221:5: FOR forExpr DO bodyExpr
    			{
    			DebugLocation(221, 5);
    			FOR101=(IToken)Match(input,FOR,Follow._FOR_in_loopExpr1387);  
    			stream_FOR.Add(FOR101);

    			DebugLocation(221, 9);
    			PushFollow(Follow._forExpr_in_loopExpr1389);
    			forExpr102=forExpr();
    			PopFollow();

    			stream_forExpr.Add(forExpr102.Tree);
    			DebugLocation(221, 17);
    			DO103=(IToken)Match(input,DO,Follow._DO_in_loopExpr1391);  
    			stream_DO.Add(DO103);

    			DebugLocation(221, 20);
    			PushFollow(Follow._bodyExpr_in_loopExpr1393);
    			bodyExpr104=bodyExpr();
    			PopFollow();

    			stream_bodyExpr.Add(bodyExpr104.Tree);


    			{
    			// AST REWRITE
    			// elements: forExpr, bodyExpr, FOR
    			// token labels: 
    			// rule labels: retval
    			// token list labels: 
    			// rule list labels: 
    			// wildcard labels: 
    			retval.Tree = root_0;
    			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    			root_0 = (object)adaptor.Nil();
    			// 221:29: -> ^( FOR forExpr bodyExpr )
    			{
    				DebugLocation(221, 32);
    				// Lang2.g:221:32: ^( FOR forExpr bodyExpr )
    				{
    				object root_1 = (object)adaptor.Nil();
    				DebugLocation(221, 34);
    				root_1 = (object)adaptor.BecomeRoot(stream_FOR.NextNode(), root_1);

    				DebugLocation(221, 38);
    				adaptor.AddChild(root_1, stream_forExpr.NextTree());
    				DebugLocation(221, 46);
    				adaptor.AddChild(root_1, stream_bodyExpr.NextTree());

    				adaptor.AddChild(root_0, root_1);
    				}

    			}

    			retval.Tree = root_0;
    			}

    			}
    			break;
    		case 3:
    			DebugEnterAlt(3);
    			// Lang2.g:222:5: REPEAT bodyExpr UNTIL condExpr OP_END
    			{
    			DebugLocation(222, 5);
    			REPEAT105=(IToken)Match(input,REPEAT,Follow._REPEAT_in_loopExpr1409);  
    			stream_REPEAT.Add(REPEAT105);

    			DebugLocation(222, 12);
    			PushFollow(Follow._bodyExpr_in_loopExpr1411);
    			bodyExpr106=bodyExpr();
    			PopFollow();

    			stream_bodyExpr.Add(bodyExpr106.Tree);
    			DebugLocation(222, 21);
    			UNTIL107=(IToken)Match(input,UNTIL,Follow._UNTIL_in_loopExpr1413);  
    			stream_UNTIL.Add(UNTIL107);

    			DebugLocation(222, 27);
    			PushFollow(Follow._condExpr_in_loopExpr1415);
    			condExpr108=condExpr();
    			PopFollow();

    			stream_condExpr.Add(condExpr108.Tree);
    			DebugLocation(222, 36);
    			OP_END109=(IToken)Match(input,OP_END,Follow._OP_END_in_loopExpr1417);  
    			stream_OP_END.Add(OP_END109);



    			{
    			// AST REWRITE
    			// elements: REPEAT, condExpr, bodyExpr
    			// token labels: 
    			// rule labels: retval
    			// token list labels: 
    			// rule list labels: 
    			// wildcard labels: 
    			retval.Tree = root_0;
    			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    			root_0 = (object)adaptor.Nil();
    			// 222:43: -> ^( REPEAT condExpr bodyExpr )
    			{
    				DebugLocation(222, 46);
    				// Lang2.g:222:46: ^( REPEAT condExpr bodyExpr )
    				{
    				object root_1 = (object)adaptor.Nil();
    				DebugLocation(222, 48);
    				root_1 = (object)adaptor.BecomeRoot(stream_REPEAT.NextNode(), root_1);

    				DebugLocation(222, 55);
    				adaptor.AddChild(root_1, stream_condExpr.NextTree());
    				DebugLocation(222, 64);
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
     	DebugLocation(223, 2);
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
    // Lang2.g:225:1: assExpr : ( VARIABLE ASSIGN expressions | arrayCall ASSIGN expressions );
    [GrammarRule("assExpr")]
    private Lang2Parser.assExpr_return assExpr()
    {

        Lang2Parser.assExpr_return retval = new Lang2Parser.assExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken VARIABLE110=null;
        IToken ASSIGN111=null;
        IToken ASSIGN114=null;
        Lang2Parser.expressions_return expressions112 = default(Lang2Parser.expressions_return);
        Lang2Parser.arrayCall_return arrayCall113 = default(Lang2Parser.arrayCall_return);
        Lang2Parser.expressions_return expressions115 = default(Lang2Parser.expressions_return);

        object VARIABLE110_tree=null;
        object ASSIGN111_tree=null;
        object ASSIGN114_tree=null;

    	try { DebugEnterRule(GrammarFileName, "assExpr");
    	DebugLocation(225, 1);
    	try
    	{
    		// Lang2.g:225:9: ( VARIABLE ASSIGN expressions | arrayCall ASSIGN expressions )
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
    			else if ((LA17_1==67))
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
    			// Lang2.g:225:12: VARIABLE ASSIGN expressions
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(225, 12);
    			VARIABLE110=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_assExpr1440); 
    			VARIABLE110_tree = (object)adaptor.Create(VARIABLE110);
    			adaptor.AddChild(root_0, VARIABLE110_tree);

    			DebugLocation(225, 27);
    			ASSIGN111=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assExpr1442); 
    			ASSIGN111_tree = (object)adaptor.Create(ASSIGN111);
    			root_0 = (object)adaptor.BecomeRoot(ASSIGN111_tree, root_0);

    			DebugLocation(225, 29);
    			PushFollow(Follow._expressions_in_assExpr1445);
    			expressions112=expressions();
    			PopFollow();

    			adaptor.AddChild(root_0, expressions112.Tree);

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Lang2.g:226:5: arrayCall ASSIGN expressions
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(226, 5);
    			PushFollow(Follow._arrayCall_in_assExpr1451);
    			arrayCall113=arrayCall();
    			PopFollow();

    			adaptor.AddChild(root_0, arrayCall113.Tree);
    			DebugLocation(226, 21);
    			ASSIGN114=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assExpr1453); 
    			ASSIGN114_tree = (object)adaptor.Create(ASSIGN114);
    			root_0 = (object)adaptor.BecomeRoot(ASSIGN114_tree, root_0);

    			DebugLocation(226, 23);
    			PushFollow(Follow._expressions_in_assExpr1456);
    			expressions115=expressions();
    			PopFollow();

    			adaptor.AddChild(root_0, expressions115.Tree);

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
     	DebugLocation(227, 1);
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
    // Lang2.g:229:1: argTypeDecl : varTypeDeclW -> ^( TYPE_DECL varTypeDeclW ) ;
    [GrammarRule("argTypeDecl")]
    private Lang2Parser.argTypeDecl_return argTypeDecl()
    {

        Lang2Parser.argTypeDecl_return retval = new Lang2Parser.argTypeDecl_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.varTypeDeclW_return varTypeDeclW116 = default(Lang2Parser.varTypeDeclW_return);

        RewriteRuleSubtreeStream stream_varTypeDeclW=new RewriteRuleSubtreeStream(adaptor,"rule varTypeDeclW");
    	try { DebugEnterRule(GrammarFileName, "argTypeDecl");
    	DebugLocation(229, 3);
    	try
    	{
    		// Lang2.g:229:13: ( varTypeDeclW -> ^( TYPE_DECL varTypeDeclW ) )
    		DebugEnterAlt(1);
    		// Lang2.g:229:15: varTypeDeclW
    		{
    		DebugLocation(229, 15);
    		PushFollow(Follow._varTypeDeclW_in_argTypeDecl1466);
    		varTypeDeclW116=varTypeDeclW();
    		PopFollow();

    		stream_varTypeDeclW.Add(varTypeDeclW116.Tree);


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
    		// 229:28: -> ^( TYPE_DECL varTypeDeclW )
    		{
    			DebugLocation(229, 31);
    			// Lang2.g:229:31: ^( TYPE_DECL varTypeDeclW )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(229, 33);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(TYPE_DECL, "TYPE_DECL"), root_1);

    			DebugLocation(229, 43);
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
    // Lang2.g:232:1: partArgDecl : VARIABLE ( ',' VARIABLE )* ;
    [GrammarRule("partArgDecl")]
    private Lang2Parser.partArgDecl_return partArgDecl()
    {

        Lang2Parser.partArgDecl_return retval = new Lang2Parser.partArgDecl_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken VARIABLE117=null;
        IToken char_literal118=null;
        IToken VARIABLE119=null;

        object VARIABLE117_tree=null;
        object char_literal118_tree=null;
        object VARIABLE119_tree=null;

    	try { DebugEnterRule(GrammarFileName, "partArgDecl");
    	DebugLocation(232, 37);
    	try
    	{
    		// Lang2.g:232:12: ( VARIABLE ( ',' VARIABLE )* )
    		DebugEnterAlt(1);
    		// Lang2.g:232:14: VARIABLE ( ',' VARIABLE )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(232, 14);
    		VARIABLE117=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_partArgDecl1485); 
    		VARIABLE117_tree = (object)adaptor.Create(VARIABLE117);
    		adaptor.AddChild(root_0, VARIABLE117_tree);

    		DebugLocation(232, 22);
    		// Lang2.g:232:22: ( ',' VARIABLE )*
    		try { DebugEnterSubRule(18);
    		while (true)
    		{
    			int alt18=2;
    			try { DebugEnterDecision(18, decisionCanBacktrack[18]);
    			int LA18_0 = input.LA(1);

    			if ((LA18_0==72))
    			{
    				alt18=1;
    			}


    			} finally { DebugExitDecision(18); }
    			switch ( alt18 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:232:23: ',' VARIABLE
    				{
    				DebugLocation(232, 26);
    				char_literal118=(IToken)Match(input,72,Follow._72_in_partArgDecl1487); 
    				DebugLocation(232, 28);
    				VARIABLE119=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_partArgDecl1490); 
    				VARIABLE119_tree = (object)adaptor.Create(VARIABLE119);
    				adaptor.AddChild(root_0, VARIABLE119_tree);


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
     	DebugLocation(232, 37);
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
    // Lang2.g:234:1: argDecl : ( VARIABLE ( ',' VARIABLE )* ':' argTypeDecl | VAR partArgDecl ':' argTypeDecl -> ^( VAR partArgDecl argTypeDecl ) );
    [GrammarRule("argDecl")]
    private Lang2Parser.argDecl_return argDecl()
    {

        Lang2Parser.argDecl_return retval = new Lang2Parser.argDecl_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken VARIABLE120=null;
        IToken char_literal121=null;
        IToken VARIABLE122=null;
        IToken char_literal123=null;
        IToken VAR125=null;
        IToken char_literal127=null;
        Lang2Parser.argTypeDecl_return argTypeDecl124 = default(Lang2Parser.argTypeDecl_return);
        Lang2Parser.partArgDecl_return partArgDecl126 = default(Lang2Parser.partArgDecl_return);
        Lang2Parser.argTypeDecl_return argTypeDecl128 = default(Lang2Parser.argTypeDecl_return);

        object VARIABLE120_tree=null;
        object char_literal121_tree=null;
        object VARIABLE122_tree=null;
        object char_literal123_tree=null;
        object VAR125_tree=null;
        object char_literal127_tree=null;
        RewriteRuleITokenStream stream_VAR=new RewriteRuleITokenStream(adaptor,"token VAR");
        RewriteRuleITokenStream stream_73=new RewriteRuleITokenStream(adaptor,"token 73");
        RewriteRuleSubtreeStream stream_partArgDecl=new RewriteRuleSubtreeStream(adaptor,"rule partArgDecl");
        RewriteRuleSubtreeStream stream_argTypeDecl=new RewriteRuleSubtreeStream(adaptor,"rule argTypeDecl");
    	try { DebugEnterRule(GrammarFileName, "argDecl");
    	DebugLocation(234, 2);
    	try
    	{
    		// Lang2.g:234:9: ( VARIABLE ( ',' VARIABLE )* ':' argTypeDecl | VAR partArgDecl ':' argTypeDecl -> ^( VAR partArgDecl argTypeDecl ) )
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
    			// Lang2.g:234:11: VARIABLE ( ',' VARIABLE )* ':' argTypeDecl
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(234, 11);
    			VARIABLE120=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_argDecl1500); 
    			VARIABLE120_tree = (object)adaptor.Create(VARIABLE120);
    			adaptor.AddChild(root_0, VARIABLE120_tree);

    			DebugLocation(234, 19);
    			// Lang2.g:234:19: ( ',' VARIABLE )*
    			try { DebugEnterSubRule(19);
    			while (true)
    			{
    				int alt19=2;
    				try { DebugEnterDecision(19, decisionCanBacktrack[19]);
    				int LA19_0 = input.LA(1);

    				if ((LA19_0==72))
    				{
    					alt19=1;
    				}


    				} finally { DebugExitDecision(19); }
    				switch ( alt19 )
    				{
    				case 1:
    					DebugEnterAlt(1);
    					// Lang2.g:234:20: ',' VARIABLE
    					{
    					DebugLocation(234, 23);
    					char_literal121=(IToken)Match(input,72,Follow._72_in_argDecl1502); 
    					DebugLocation(234, 25);
    					VARIABLE122=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_argDecl1505); 
    					VARIABLE122_tree = (object)adaptor.Create(VARIABLE122);
    					adaptor.AddChild(root_0, VARIABLE122_tree);


    					}
    					break;

    				default:
    					goto loop19;
    				}
    			}

    			loop19:
    				;

    			} finally { DebugExitSubRule(19); }

    			DebugLocation(234, 39);
    			char_literal123=(IToken)Match(input,73,Follow._73_in_argDecl1509); 
    			DebugLocation(234, 41);
    			PushFollow(Follow._argTypeDecl_in_argDecl1512);
    			argTypeDecl124=argTypeDecl();
    			PopFollow();

    			adaptor.AddChild(root_0, argTypeDecl124.Tree);

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Lang2.g:235:5: VAR partArgDecl ':' argTypeDecl
    			{
    			DebugLocation(235, 5);
    			VAR125=(IToken)Match(input,VAR,Follow._VAR_in_argDecl1518);  
    			stream_VAR.Add(VAR125);

    			DebugLocation(235, 9);
    			PushFollow(Follow._partArgDecl_in_argDecl1520);
    			partArgDecl126=partArgDecl();
    			PopFollow();

    			stream_partArgDecl.Add(partArgDecl126.Tree);
    			DebugLocation(235, 23);
    			char_literal127=(IToken)Match(input,73,Follow._73_in_argDecl1521);  
    			stream_73.Add(char_literal127);

    			DebugLocation(235, 25);
    			PushFollow(Follow._argTypeDecl_in_argDecl1524);
    			argTypeDecl128=argTypeDecl();
    			PopFollow();

    			stream_argTypeDecl.Add(argTypeDecl128.Tree);


    			{
    			// AST REWRITE
    			// elements: argTypeDecl, VAR, partArgDecl
    			// token labels: 
    			// rule labels: retval
    			// token list labels: 
    			// rule list labels: 
    			// wildcard labels: 
    			retval.Tree = root_0;
    			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    			root_0 = (object)adaptor.Nil();
    			// 235:37: -> ^( VAR partArgDecl argTypeDecl )
    			{
    				DebugLocation(235, 40);
    				// Lang2.g:235:40: ^( VAR partArgDecl argTypeDecl )
    				{
    				object root_1 = (object)adaptor.Nil();
    				DebugLocation(235, 42);
    				root_1 = (object)adaptor.BecomeRoot(stream_VAR.NextNode(), root_1);

    				DebugLocation(235, 46);
    				adaptor.AddChild(root_1, stream_partArgDecl.NextTree());
    				DebugLocation(235, 58);
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
     	DebugLocation(236, 2);
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
    // Lang2.g:238:1: argDeclManyW : argDecl ( ',' argDecl )* ;
    [GrammarRule("argDeclManyW")]
    private Lang2Parser.argDeclManyW_return argDeclManyW()
    {

        Lang2Parser.argDeclManyW_return retval = new Lang2Parser.argDeclManyW_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken char_literal130=null;
        Lang2Parser.argDecl_return argDecl129 = default(Lang2Parser.argDecl_return);
        Lang2Parser.argDecl_return argDecl131 = default(Lang2Parser.argDecl_return);

        object char_literal130_tree=null;

    	try { DebugEnterRule(GrammarFileName, "argDeclManyW");
    	DebugLocation(238, 3);
    	try
    	{
    		// Lang2.g:238:14: ( argDecl ( ',' argDecl )* )
    		DebugEnterAlt(1);
    		// Lang2.g:238:16: argDecl ( ',' argDecl )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(238, 16);
    		PushFollow(Follow._argDecl_in_argDeclManyW1545);
    		argDecl129=argDecl();
    		PopFollow();

    		adaptor.AddChild(root_0, argDecl129.Tree);
    		DebugLocation(238, 23);
    		// Lang2.g:238:23: ( ',' argDecl )*
    		try { DebugEnterSubRule(21);
    		while (true)
    		{
    			int alt21=2;
    			try { DebugEnterDecision(21, decisionCanBacktrack[21]);
    			int LA21_0 = input.LA(1);

    			if ((LA21_0==72))
    			{
    				alt21=1;
    			}


    			} finally { DebugExitDecision(21); }
    			switch ( alt21 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:238:24: ',' argDecl
    				{
    				DebugLocation(238, 27);
    				char_literal130=(IToken)Match(input,72,Follow._72_in_argDeclManyW1547); 
    				DebugLocation(238, 29);
    				PushFollow(Follow._argDecl_in_argDeclManyW1550);
    				argDecl131=argDecl();
    				PopFollow();

    				adaptor.AddChild(root_0, argDecl131.Tree);

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
     	DebugLocation(239, 3);
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
    // Lang2.g:240:1: argDeclMany : argDeclManyW -> ^( VAR_DECL argDeclManyW ) ;
    [GrammarRule("argDeclMany")]
    private Lang2Parser.argDeclMany_return argDeclMany()
    {

        Lang2Parser.argDeclMany_return retval = new Lang2Parser.argDeclMany_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.argDeclManyW_return argDeclManyW132 = default(Lang2Parser.argDeclManyW_return);

        RewriteRuleSubtreeStream stream_argDeclManyW=new RewriteRuleSubtreeStream(adaptor,"rule argDeclManyW");
    	try { DebugEnterRule(GrammarFileName, "argDeclMany");
    	DebugLocation(240, 3);
    	try
    	{
    		// Lang2.g:240:13: ( argDeclManyW -> ^( VAR_DECL argDeclManyW ) )
    		DebugEnterAlt(1);
    		// Lang2.g:240:15: argDeclManyW
    		{
    		DebugLocation(240, 15);
    		PushFollow(Follow._argDeclManyW_in_argDeclMany1563);
    		argDeclManyW132=argDeclManyW();
    		PopFollow();

    		stream_argDeclManyW.Add(argDeclManyW132.Tree);


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
    		// 240:28: -> ^( VAR_DECL argDeclManyW )
    		{
    			DebugLocation(240, 31);
    			// Lang2.g:240:31: ^( VAR_DECL argDeclManyW )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(240, 33);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VAR_DECL, "VAR_DECL"), root_1);

    			DebugLocation(240, 42);
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
     	DebugLocation(241, 3);
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
    // Lang2.g:242:1: typeDecl : ( T_INT | T_CHAR | T_BOOL | T_STRING );
    [GrammarRule("typeDecl")]
    private Lang2Parser.typeDecl_return typeDecl()
    {

        Lang2Parser.typeDecl_return retval = new Lang2Parser.typeDecl_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken set133=null;

        object set133_tree=null;

    	try { DebugEnterRule(GrammarFileName, "typeDecl");
    	DebugLocation(242, 39);
    	try
    	{
    		// Lang2.g:242:10: ( T_INT | T_CHAR | T_BOOL | T_STRING )
    		DebugEnterAlt(1);
    		// Lang2.g:
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(242, 10);
    		set133=(IToken)input.LT(1);
    		if ((input.LA(1)>=T_CHAR && input.LA(1)<=T_STRING))
    		{
    			input.Consume();
    			adaptor.AddChild(root_0, (object)adaptor.Create(set133));
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
     	DebugLocation(242, 39);
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
    // Lang2.g:245:1: varTypeDeclW : ( typeDecl | arrayDecl );
    [GrammarRule("varTypeDeclW")]
    private Lang2Parser.varTypeDeclW_return varTypeDeclW()
    {

        Lang2Parser.varTypeDeclW_return retval = new Lang2Parser.varTypeDeclW_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.typeDecl_return typeDecl134 = default(Lang2Parser.typeDecl_return);
        Lang2Parser.arrayDecl_return arrayDecl135 = default(Lang2Parser.arrayDecl_return);


    	try { DebugEnterRule(GrammarFileName, "varTypeDeclW");
    	DebugLocation(245, 4);
    	try
    	{
    		// Lang2.g:245:14: ( typeDecl | arrayDecl )
    		int alt22=2;
    		try { DebugEnterDecision(22, decisionCanBacktrack[22]);
    		int LA22_0 = input.LA(1);

    		if (((LA22_0>=T_CHAR && LA22_0<=T_STRING)))
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
    			// Lang2.g:245:16: typeDecl
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(245, 16);
    			PushFollow(Follow._typeDecl_in_varTypeDeclW1597);
    			typeDecl134=typeDecl();
    			PopFollow();

    			adaptor.AddChild(root_0, typeDecl134.Tree);

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Lang2.g:245:25: arrayDecl
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(245, 25);
    			PushFollow(Follow._arrayDecl_in_varTypeDeclW1599);
    			arrayDecl135=arrayDecl();
    			PopFollow();

    			adaptor.AddChild(root_0, arrayDecl135.Tree);

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
     	DebugLocation(246, 4);
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
    // Lang2.g:248:1: varTypeDecl : varTypeDeclW OP_END -> ^( TYPE_DECL varTypeDeclW ) ;
    [GrammarRule("varTypeDecl")]
    private Lang2Parser.varTypeDecl_return varTypeDecl()
    {

        Lang2Parser.varTypeDecl_return retval = new Lang2Parser.varTypeDecl_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken OP_END137=null;
        Lang2Parser.varTypeDeclW_return varTypeDeclW136 = default(Lang2Parser.varTypeDeclW_return);

        object OP_END137_tree=null;
        RewriteRuleITokenStream stream_OP_END=new RewriteRuleITokenStream(adaptor,"token OP_END");
        RewriteRuleSubtreeStream stream_varTypeDeclW=new RewriteRuleSubtreeStream(adaptor,"rule varTypeDeclW");
    	try { DebugEnterRule(GrammarFileName, "varTypeDecl");
    	DebugLocation(248, 3);
    	try
    	{
    		// Lang2.g:248:13: ( varTypeDeclW OP_END -> ^( TYPE_DECL varTypeDeclW ) )
    		DebugEnterAlt(1);
    		// Lang2.g:248:15: varTypeDeclW OP_END
    		{
    		DebugLocation(248, 15);
    		PushFollow(Follow._varTypeDeclW_in_varTypeDecl1612);
    		varTypeDeclW136=varTypeDeclW();
    		PopFollow();

    		stream_varTypeDeclW.Add(varTypeDeclW136.Tree);
    		DebugLocation(248, 28);
    		OP_END137=(IToken)Match(input,OP_END,Follow._OP_END_in_varTypeDecl1614);  
    		stream_OP_END.Add(OP_END137);



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
    		// 248:35: -> ^( TYPE_DECL varTypeDeclW )
    		{
    			DebugLocation(248, 38);
    			// Lang2.g:248:38: ^( TYPE_DECL varTypeDeclW )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(248, 40);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(TYPE_DECL, "TYPE_DECL"), root_1);

    			DebugLocation(248, 50);
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
     	DebugLocation(249, 3);
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
    // Lang2.g:252:1: varDecl2 : VARIABLE ( ',' VARIABLE )* ;
    [GrammarRule("varDecl2")]
    private Lang2Parser.varDecl2_return varDecl2()
    {

        Lang2Parser.varDecl2_return retval = new Lang2Parser.varDecl2_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken VARIABLE138=null;
        IToken char_literal139=null;
        IToken VARIABLE140=null;

        object VARIABLE138_tree=null;
        object char_literal139_tree=null;
        object VARIABLE140_tree=null;

    	try { DebugEnterRule(GrammarFileName, "varDecl2");
    	DebugLocation(252, 35);
    	try
    	{
    		// Lang2.g:252:10: ( VARIABLE ( ',' VARIABLE )* )
    		DebugEnterAlt(1);
    		// Lang2.g:252:12: VARIABLE ( ',' VARIABLE )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(252, 12);
    		VARIABLE138=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_varDecl21635); 
    		VARIABLE138_tree = (object)adaptor.Create(VARIABLE138);
    		adaptor.AddChild(root_0, VARIABLE138_tree);

    		DebugLocation(252, 20);
    		// Lang2.g:252:20: ( ',' VARIABLE )*
    		try { DebugEnterSubRule(23);
    		while (true)
    		{
    			int alt23=2;
    			try { DebugEnterDecision(23, decisionCanBacktrack[23]);
    			int LA23_0 = input.LA(1);

    			if ((LA23_0==72))
    			{
    				alt23=1;
    			}


    			} finally { DebugExitDecision(23); }
    			switch ( alt23 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:252:21: ',' VARIABLE
    				{
    				DebugLocation(252, 24);
    				char_literal139=(IToken)Match(input,72,Follow._72_in_varDecl21637); 
    				DebugLocation(252, 26);
    				VARIABLE140=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_varDecl21640); 
    				VARIABLE140_tree = (object)adaptor.Create(VARIABLE140);
    				adaptor.AddChild(root_0, VARIABLE140_tree);


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
     	DebugLocation(252, 35);
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
    // Lang2.g:254:1: varDecl : varDecl2 ;
    [GrammarRule("varDecl")]
    private Lang2Parser.varDecl_return varDecl()
    {

        Lang2Parser.varDecl_return retval = new Lang2Parser.varDecl_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.varDecl2_return varDecl2141 = default(Lang2Parser.varDecl2_return);


    	try { DebugEnterRule(GrammarFileName, "varDecl");
    	DebugLocation(254, 2);
    	try
    	{
    		// Lang2.g:254:9: ( varDecl2 )
    		DebugEnterAlt(1);
    		// Lang2.g:254:11: varDecl2
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(254, 11);
    		PushFollow(Follow._varDecl2_in_varDecl1650);
    		varDecl2141=varDecl2();
    		PopFollow();

    		adaptor.AddChild(root_0, varDecl2141.Tree);

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
     	DebugLocation(255, 2);
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
    // Lang2.g:256:1: varDecl12W : varDecl ':' varTypeDecl ;
    [GrammarRule("varDecl12W")]
    private Lang2Parser.varDecl12W_return varDecl12W()
    {

        Lang2Parser.varDecl12W_return retval = new Lang2Parser.varDecl12W_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken char_literal143=null;
        Lang2Parser.varDecl_return varDecl142 = default(Lang2Parser.varDecl_return);
        Lang2Parser.varTypeDecl_return varTypeDecl144 = default(Lang2Parser.varTypeDecl_return);

        object char_literal143_tree=null;

    	try { DebugEnterRule(GrammarFileName, "varDecl12W");
    	DebugLocation(256, 3);
    	try
    	{
    		// Lang2.g:256:12: ( varDecl ':' varTypeDecl )
    		DebugEnterAlt(1);
    		// Lang2.g:256:14: varDecl ':' varTypeDecl
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(256, 14);
    		PushFollow(Follow._varDecl_in_varDecl12W1660);
    		varDecl142=varDecl();
    		PopFollow();

    		adaptor.AddChild(root_0, varDecl142.Tree);
    		DebugLocation(256, 25);
    		char_literal143=(IToken)Match(input,73,Follow._73_in_varDecl12W1662); 
    		DebugLocation(256, 27);
    		PushFollow(Follow._varTypeDecl_in_varDecl12W1665);
    		varTypeDecl144=varTypeDecl();
    		PopFollow();

    		adaptor.AddChild(root_0, varTypeDecl144.Tree);

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
     	DebugLocation(257, 3);
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
    // Lang2.g:258:1: varDeclW : VAR ( ( varDecl12W )+ ) -> ^( VAR_DECL ( varDecl12W )+ ) ;
    [GrammarRule("varDeclW")]
    private Lang2Parser.varDeclW_return varDeclW()
    {

        Lang2Parser.varDeclW_return retval = new Lang2Parser.varDeclW_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken VAR145=null;
        Lang2Parser.varDecl12W_return varDecl12W146 = default(Lang2Parser.varDecl12W_return);

        object VAR145_tree=null;
        RewriteRuleITokenStream stream_VAR=new RewriteRuleITokenStream(adaptor,"token VAR");
        RewriteRuleSubtreeStream stream_varDecl12W=new RewriteRuleSubtreeStream(adaptor,"rule varDecl12W");
    	try { DebugEnterRule(GrammarFileName, "varDeclW");
    	DebugLocation(258, 3);
    	try
    	{
    		// Lang2.g:258:10: ( VAR ( ( varDecl12W )+ ) -> ^( VAR_DECL ( varDecl12W )+ ) )
    		DebugEnterAlt(1);
    		// Lang2.g:258:12: VAR ( ( varDecl12W )+ )
    		{
    		DebugLocation(258, 12);
    		VAR145=(IToken)Match(input,VAR,Follow._VAR_in_varDeclW1677);  
    		stream_VAR.Add(VAR145);

    		DebugLocation(258, 16);
    		// Lang2.g:258:16: ( ( varDecl12W )+ )
    		DebugEnterAlt(1);
    		// Lang2.g:258:17: ( varDecl12W )+
    		{
    		DebugLocation(258, 17);
    		// Lang2.g:258:17: ( varDecl12W )+
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
    				// Lang2.g:258:17: varDecl12W
    				{
    				DebugLocation(258, 17);
    				PushFollow(Follow._varDecl12W_in_varDeclW1680);
    				varDecl12W146=varDecl12W();
    				PopFollow();

    				stream_varDecl12W.Add(varDecl12W146.Tree);

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
    		// 258:30: -> ^( VAR_DECL ( varDecl12W )+ )
    		{
    			DebugLocation(258, 33);
    			// Lang2.g:258:33: ^( VAR_DECL ( varDecl12W )+ )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(258, 35);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VAR_DECL, "VAR_DECL"), root_1);

    			DebugLocation(258, 44);
    			if ( !(stream_varDecl12W.HasNext) )
    			{
    				throw new RewriteEarlyExitException();
    			}
    			while ( stream_varDecl12W.HasNext )
    			{
    				DebugLocation(258, 44);
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
     	DebugLocation(259, 3);
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
    // Lang2.g:263:1: bodyExpr : BEGIN ( bodyOper )* END OP_END -> ^( BODY_EXPR ( bodyOper )* ) ;
    [GrammarRule("bodyExpr")]
    private Lang2Parser.bodyExpr_return bodyExpr()
    {

        Lang2Parser.bodyExpr_return retval = new Lang2Parser.bodyExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken BEGIN147=null;
        IToken END149=null;
        IToken OP_END150=null;
        Lang2Parser.bodyOper_return bodyOper148 = default(Lang2Parser.bodyOper_return);

        object BEGIN147_tree=null;
        object END149_tree=null;
        object OP_END150_tree=null;
        RewriteRuleITokenStream stream_OP_END=new RewriteRuleITokenStream(adaptor,"token OP_END");
        RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
        RewriteRuleITokenStream stream_BEGIN=new RewriteRuleITokenStream(adaptor,"token BEGIN");
        RewriteRuleSubtreeStream stream_bodyOper=new RewriteRuleSubtreeStream(adaptor,"rule bodyOper");
    	try { DebugEnterRule(GrammarFileName, "bodyExpr");
    	DebugLocation(263, 3);
    	try
    	{
    		// Lang2.g:263:10: ( BEGIN ( bodyOper )* END OP_END -> ^( BODY_EXPR ( bodyOper )* ) )
    		DebugEnterAlt(1);
    		// Lang2.g:263:12: BEGIN ( bodyOper )* END OP_END
    		{
    		DebugLocation(263, 17);
    		BEGIN147=(IToken)Match(input,BEGIN,Follow._BEGIN_in_bodyExpr1706);  
    		stream_BEGIN.Add(BEGIN147);

    		DebugLocation(263, 19);
    		// Lang2.g:263:19: ( bodyOper )*
    		try { DebugEnterSubRule(25);
    		while (true)
    		{
    			int alt25=2;
    			try { DebugEnterDecision(25, decisionCanBacktrack[25]);
    			int LA25_0 = input.LA(1);

    			if ((LA25_0==WHILE||LA25_0==FOR||LA25_0==IF||LA25_0==REPEAT||LA25_0==VARIABLE))
    			{
    				alt25=1;
    			}


    			} finally { DebugExitDecision(25); }
    			switch ( alt25 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:263:19: bodyOper
    				{
    				DebugLocation(263, 19);
    				PushFollow(Follow._bodyOper_in_bodyExpr1709);
    				bodyOper148=bodyOper();
    				PopFollow();

    				stream_bodyOper.Add(bodyOper148.Tree);

    				}
    				break;

    			default:
    				goto loop25;
    			}
    		}

    		loop25:
    			;

    		} finally { DebugExitSubRule(25); }

    		DebugLocation(263, 32);
    		END149=(IToken)Match(input,END,Follow._END_in_bodyExpr1712);  
    		stream_END.Add(END149);

    		DebugLocation(263, 40);
    		OP_END150=(IToken)Match(input,OP_END,Follow._OP_END_in_bodyExpr1715);  
    		stream_OP_END.Add(OP_END150);



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
    		// 263:42: -> ^( BODY_EXPR ( bodyOper )* )
    		{
    			DebugLocation(263, 45);
    			// Lang2.g:263:45: ^( BODY_EXPR ( bodyOper )* )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(263, 47);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BODY_EXPR, "BODY_EXPR"), root_1);

    			DebugLocation(263, 57);
    			// Lang2.g:263:57: ( bodyOper )*
    			while ( stream_bodyOper.HasNext )
    			{
    				DebugLocation(263, 57);
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
     	DebugLocation(264, 3);
    	} finally { DebugExitRule(GrammarFileName, "bodyExpr"); }
    	return retval;

    }
    // $ANTLR end "bodyExpr"

    public class mainBodyExpr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_mainBodyExpr() {}
    protected virtual void Leave_mainBodyExpr() {}

    // $ANTLR start "mainBodyExpr"
    // Lang2.g:265:1: mainBodyExpr : BEGIN ( bodyOper )* END OP_END -> ^( MAIN_BODY ( bodyOper )* ) ;
    [GrammarRule("mainBodyExpr")]
    private Lang2Parser.mainBodyExpr_return mainBodyExpr()
    {

        Lang2Parser.mainBodyExpr_return retval = new Lang2Parser.mainBodyExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken BEGIN151=null;
        IToken END153=null;
        IToken OP_END154=null;
        Lang2Parser.bodyOper_return bodyOper152 = default(Lang2Parser.bodyOper_return);

        object BEGIN151_tree=null;
        object END153_tree=null;
        object OP_END154_tree=null;
        RewriteRuleITokenStream stream_OP_END=new RewriteRuleITokenStream(adaptor,"token OP_END");
        RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
        RewriteRuleITokenStream stream_BEGIN=new RewriteRuleITokenStream(adaptor,"token BEGIN");
        RewriteRuleSubtreeStream stream_bodyOper=new RewriteRuleSubtreeStream(adaptor,"rule bodyOper");
    	try { DebugEnterRule(GrammarFileName, "mainBodyExpr");
    	DebugLocation(265, 4);
    	try
    	{
    		// Lang2.g:265:14: ( BEGIN ( bodyOper )* END OP_END -> ^( MAIN_BODY ( bodyOper )* ) )
    		DebugEnterAlt(1);
    		// Lang2.g:265:16: BEGIN ( bodyOper )* END OP_END
    		{
    		DebugLocation(265, 21);
    		BEGIN151=(IToken)Match(input,BEGIN,Follow._BEGIN_in_mainBodyExpr1736);  
    		stream_BEGIN.Add(BEGIN151);

    		DebugLocation(265, 23);
    		// Lang2.g:265:23: ( bodyOper )*
    		try { DebugEnterSubRule(26);
    		while (true)
    		{
    			int alt26=2;
    			try { DebugEnterDecision(26, decisionCanBacktrack[26]);
    			int LA26_0 = input.LA(1);

    			if ((LA26_0==WHILE||LA26_0==FOR||LA26_0==IF||LA26_0==REPEAT||LA26_0==VARIABLE))
    			{
    				alt26=1;
    			}


    			} finally { DebugExitDecision(26); }
    			switch ( alt26 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:265:23: bodyOper
    				{
    				DebugLocation(265, 23);
    				PushFollow(Follow._bodyOper_in_mainBodyExpr1739);
    				bodyOper152=bodyOper();
    				PopFollow();

    				stream_bodyOper.Add(bodyOper152.Tree);

    				}
    				break;

    			default:
    				goto loop26;
    			}
    		}

    		loop26:
    			;

    		} finally { DebugExitSubRule(26); }

    		DebugLocation(265, 36);
    		END153=(IToken)Match(input,END,Follow._END_in_mainBodyExpr1742);  
    		stream_END.Add(END153);

    		DebugLocation(265, 38);
    		OP_END154=(IToken)Match(input,OP_END,Follow._OP_END_in_mainBodyExpr1745);  
    		stream_OP_END.Add(OP_END154);



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
    		// 265:45: -> ^( MAIN_BODY ( bodyOper )* )
    		{
    			DebugLocation(265, 48);
    			// Lang2.g:265:48: ^( MAIN_BODY ( bodyOper )* )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(265, 50);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(MAIN_BODY, "MAIN_BODY"), root_1);

    			DebugLocation(265, 60);
    			// Lang2.g:265:60: ( bodyOper )*
    			while ( stream_bodyOper.HasNext )
    			{
    				DebugLocation(265, 60);
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
     	DebugLocation(266, 4);
    	} finally { DebugExitRule(GrammarFileName, "mainBodyExpr"); }
    	return retval;

    }
    // $ANTLR end "mainBodyExpr"

    public class func_proc_expr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_func_proc_expr() {}
    protected virtual void Leave_func_proc_expr() {}

    // $ANTLR start "func_proc_expr"
    // Lang2.g:267:1: func_proc_expr : ( funcDeclare | procedureDeclare );
    [GrammarRule("func_proc_expr")]
    private Lang2Parser.func_proc_expr_return func_proc_expr()
    {

        Lang2Parser.func_proc_expr_return retval = new Lang2Parser.func_proc_expr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.funcDeclare_return funcDeclare155 = default(Lang2Parser.funcDeclare_return);
        Lang2Parser.procedureDeclare_return procedureDeclare156 = default(Lang2Parser.procedureDeclare_return);


    	try { DebugEnterRule(GrammarFileName, "func_proc_expr");
    	DebugLocation(267, 46);
    	try
    	{
    		// Lang2.g:267:16: ( funcDeclare | procedureDeclare )
    		int alt27=2;
    		try { DebugEnterDecision(27, decisionCanBacktrack[27]);
    		int LA27_0 = input.LA(1);

    		if ((LA27_0==FUNCTION))
    		{
    			alt27=1;
    		}
    		else if ((LA27_0==PROCEDURE))
    		{
    			alt27=2;
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
    			// Lang2.g:267:18: funcDeclare
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(267, 18);
    			PushFollow(Follow._funcDeclare_in_func_proc_expr1766);
    			funcDeclare155=funcDeclare();
    			PopFollow();

    			adaptor.AddChild(root_0, funcDeclare155.Tree);

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Lang2.g:267:30: procedureDeclare
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(267, 30);
    			PushFollow(Follow._procedureDeclare_in_func_proc_expr1768);
    			procedureDeclare156=procedureDeclare();
    			PopFollow();

    			adaptor.AddChild(root_0, procedureDeclare156.Tree);

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
     	DebugLocation(267, 46);
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
    // Lang2.g:269:1: fpExprW : ( func_proc_expr )* -> ^( FUNC_PROC_EXPR ( func_proc_expr )* ) ;
    [GrammarRule("fpExprW")]
    private Lang2Parser.fpExprW_return fpExprW()
    {

        Lang2Parser.fpExprW_return retval = new Lang2Parser.fpExprW_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.func_proc_expr_return func_proc_expr157 = default(Lang2Parser.func_proc_expr_return);

        RewriteRuleSubtreeStream stream_func_proc_expr=new RewriteRuleSubtreeStream(adaptor,"rule func_proc_expr");
    	try { DebugEnterRule(GrammarFileName, "fpExprW");
    	DebugLocation(269, 62);
    	try
    	{
    		// Lang2.g:269:9: ( ( func_proc_expr )* -> ^( FUNC_PROC_EXPR ( func_proc_expr )* ) )
    		DebugEnterAlt(1);
    		// Lang2.g:269:11: ( func_proc_expr )*
    		{
    		DebugLocation(269, 11);
    		// Lang2.g:269:11: ( func_proc_expr )*
    		try { DebugEnterSubRule(28);
    		while (true)
    		{
    			int alt28=2;
    			try { DebugEnterDecision(28, decisionCanBacktrack[28]);
    			int LA28_0 = input.LA(1);

    			if (((LA28_0>=FUNCTION && LA28_0<=PROCEDURE)))
    			{
    				alt28=1;
    			}


    			} finally { DebugExitDecision(28); }
    			switch ( alt28 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:269:11: func_proc_expr
    				{
    				DebugLocation(269, 11);
    				PushFollow(Follow._func_proc_expr_in_fpExprW1777);
    				func_proc_expr157=func_proc_expr();
    				PopFollow();

    				stream_func_proc_expr.Add(func_proc_expr157.Tree);

    				}
    				break;

    			default:
    				goto loop28;
    			}
    		}

    		loop28:
    			;

    		} finally { DebugExitSubRule(28); }



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
    		// 269:27: -> ^( FUNC_PROC_EXPR ( func_proc_expr )* )
    		{
    			DebugLocation(269, 30);
    			// Lang2.g:269:30: ^( FUNC_PROC_EXPR ( func_proc_expr )* )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(269, 32);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_PROC_EXPR, "FUNC_PROC_EXPR"), root_1);

    			DebugLocation(269, 47);
    			// Lang2.g:269:47: ( func_proc_expr )*
    			while ( stream_func_proc_expr.HasNext )
    			{
    				DebugLocation(269, 47);
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
     	DebugLocation(269, 62);
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
    // Lang2.g:271:1: wrapToBody : ( varDeclW )? fpExprW mainBodyExpr -> ^( BODY_EXPR ( varDeclW )? fpExprW mainBodyExpr ) ;
    [GrammarRule("wrapToBody")]
    private Lang2Parser.wrapToBody_return wrapToBody()
    {

        Lang2Parser.wrapToBody_return retval = new Lang2Parser.wrapToBody_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.varDeclW_return varDeclW158 = default(Lang2Parser.varDeclW_return);
        Lang2Parser.fpExprW_return fpExprW159 = default(Lang2Parser.fpExprW_return);
        Lang2Parser.mainBodyExpr_return mainBodyExpr160 = default(Lang2Parser.mainBodyExpr_return);

        RewriteRuleSubtreeStream stream_varDeclW=new RewriteRuleSubtreeStream(adaptor,"rule varDeclW");
        RewriteRuleSubtreeStream stream_mainBodyExpr=new RewriteRuleSubtreeStream(adaptor,"rule mainBodyExpr");
        RewriteRuleSubtreeStream stream_fpExprW=new RewriteRuleSubtreeStream(adaptor,"rule fpExprW");
    	try { DebugEnterRule(GrammarFileName, "wrapToBody");
    	DebugLocation(271, 3);
    	try
    	{
    		// Lang2.g:271:12: ( ( varDeclW )? fpExprW mainBodyExpr -> ^( BODY_EXPR ( varDeclW )? fpExprW mainBodyExpr ) )
    		DebugEnterAlt(1);
    		// Lang2.g:271:14: ( varDeclW )? fpExprW mainBodyExpr
    		{
    		DebugLocation(271, 14);
    		// Lang2.g:271:14: ( varDeclW )?
    		int alt29=2;
    		try { DebugEnterSubRule(29);
    		try { DebugEnterDecision(29, decisionCanBacktrack[29]);
    		int LA29_0 = input.LA(1);

    		if ((LA29_0==VAR))
    		{
    			alt29=1;
    		}
    		} finally { DebugExitDecision(29); }
    		switch (alt29)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Lang2.g:271:14: varDeclW
    			{
    			DebugLocation(271, 14);
    			PushFollow(Follow._varDeclW_in_wrapToBody1795);
    			varDeclW158=varDeclW();
    			PopFollow();

    			stream_varDeclW.Add(varDeclW158.Tree);

    			}
    			break;

    		}
    		} finally { DebugExitSubRule(29); }

    		DebugLocation(271, 24);
    		PushFollow(Follow._fpExprW_in_wrapToBody1798);
    		fpExprW159=fpExprW();
    		PopFollow();

    		stream_fpExprW.Add(fpExprW159.Tree);
    		DebugLocation(271, 32);
    		PushFollow(Follow._mainBodyExpr_in_wrapToBody1800);
    		mainBodyExpr160=mainBodyExpr();
    		PopFollow();

    		stream_mainBodyExpr.Add(mainBodyExpr160.Tree);


    		{
    		// AST REWRITE
    		// elements: varDeclW, fpExprW, mainBodyExpr
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 271:45: -> ^( BODY_EXPR ( varDeclW )? fpExprW mainBodyExpr )
    		{
    			DebugLocation(271, 48);
    			// Lang2.g:271:48: ^( BODY_EXPR ( varDeclW )? fpExprW mainBodyExpr )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(271, 50);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BODY_EXPR, "BODY_EXPR"), root_1);

    			DebugLocation(271, 60);
    			// Lang2.g:271:60: ( varDeclW )?
    			if ( stream_varDeclW.HasNext )
    			{
    				DebugLocation(271, 60);
    				adaptor.AddChild(root_1, stream_varDeclW.NextTree());

    			}
    			stream_varDeclW.Reset();
    			DebugLocation(271, 70);
    			adaptor.AddChild(root_1, stream_fpExprW.NextTree());
    			DebugLocation(271, 78);
    			adaptor.AddChild(root_1, stream_mainBodyExpr.NextTree());

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
     	DebugLocation(272, 3);
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
    // Lang2.g:274:1: expr : PROGRAM VARIABLE OP_END wrapToBody -> ^( PROGRAM VARIABLE wrapToBody ) ;
    [GrammarRule("expr")]
    private Lang2Parser.expr_return expr()
    {

        Lang2Parser.expr_return retval = new Lang2Parser.expr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken PROGRAM161=null;
        IToken VARIABLE162=null;
        IToken OP_END163=null;
        Lang2Parser.wrapToBody_return wrapToBody164 = default(Lang2Parser.wrapToBody_return);

        object PROGRAM161_tree=null;
        object VARIABLE162_tree=null;
        object OP_END163_tree=null;
        RewriteRuleITokenStream stream_PROGRAM=new RewriteRuleITokenStream(adaptor,"token PROGRAM");
        RewriteRuleITokenStream stream_VARIABLE=new RewriteRuleITokenStream(adaptor,"token VARIABLE");
        RewriteRuleITokenStream stream_OP_END=new RewriteRuleITokenStream(adaptor,"token OP_END");
        RewriteRuleSubtreeStream stream_wrapToBody=new RewriteRuleSubtreeStream(adaptor,"rule wrapToBody");
    	try { DebugEnterRule(GrammarFileName, "expr");
    	DebugLocation(274, 1);
    	try
    	{
    		// Lang2.g:274:6: ( PROGRAM VARIABLE OP_END wrapToBody -> ^( PROGRAM VARIABLE wrapToBody ) )
    		DebugEnterAlt(1);
    		// Lang2.g:274:9: PROGRAM VARIABLE OP_END wrapToBody
    		{
    		DebugLocation(274, 9);
    		PROGRAM161=(IToken)Match(input,PROGRAM,Follow._PROGRAM_in_expr1826);  
    		stream_PROGRAM.Add(PROGRAM161);

    		DebugLocation(274, 17);
    		VARIABLE162=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_expr1828);  
    		stream_VARIABLE.Add(VARIABLE162);

    		DebugLocation(274, 32);
    		OP_END163=(IToken)Match(input,OP_END,Follow._OP_END_in_expr1830);  
    		stream_OP_END.Add(OP_END163);

    		DebugLocation(274, 34);
    		PushFollow(Follow._wrapToBody_in_expr1833);
    		wrapToBody164=wrapToBody();
    		PopFollow();

    		stream_wrapToBody.Add(wrapToBody164.Tree);


    		{
    		// AST REWRITE
    		// elements: wrapToBody, PROGRAM, VARIABLE
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 274:45: -> ^( PROGRAM VARIABLE wrapToBody )
    		{
    			DebugLocation(274, 48);
    			// Lang2.g:274:48: ^( PROGRAM VARIABLE wrapToBody )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(274, 50);
    			root_1 = (object)adaptor.BecomeRoot(stream_PROGRAM.NextNode(), root_1);

    			DebugLocation(274, 58);
    			adaptor.AddChild(root_1, stream_VARIABLE.NextNode());
    			DebugLocation(274, 67);
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
     	DebugLocation(275, 1);
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
    // Lang2.g:277:1: program : ( expr )+ ;
    [GrammarRule("program")]
    private Lang2Parser.program_return program()
    {

        Lang2Parser.program_return retval = new Lang2Parser.program_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.expr_return expr165 = default(Lang2Parser.expr_return);


    	try { DebugEnterRule(GrammarFileName, "program");
    	DebugLocation(277, 16);
    	try
    	{
    		// Lang2.g:277:8: ( ( expr )+ )
    		DebugEnterAlt(1);
    		// Lang2.g:277:10: ( expr )+
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(277, 10);
    		// Lang2.g:277:10: ( expr )+
    		int cnt30=0;
    		try { DebugEnterSubRule(30);
    		while (true)
    		{
    			int alt30=2;
    			try { DebugEnterDecision(30, decisionCanBacktrack[30]);
    			int LA30_0 = input.LA(1);

    			if ((LA30_0==PROGRAM))
    			{
    				alt30=1;
    			}


    			} finally { DebugExitDecision(30); }
    			switch (alt30)
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:277:10: expr
    				{
    				DebugLocation(277, 10);
    				PushFollow(Follow._expr_in_program1853);
    				expr165=expr();
    				PopFollow();

    				adaptor.AddChild(root_0, expr165.Tree);

    				}
    				break;

    			default:
    				if (cnt30 >= 1)
    					goto loop30;

    				EarlyExitException eee30 = new EarlyExitException( 30, input );
    				DebugRecognitionException(eee30);
    				throw eee30;
    			}
    			cnt30++;
    		}
    		loop30:
    			;

    		} finally { DebugExitSubRule(30); }


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
     	DebugLocation(277, 16);
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
    // Lang2.g:278:1: result : program EOF -> ^( PROGRAM program ) ;
    [GrammarRule("result")]
    private Lang2Parser.result_return result()
    {

        Lang2Parser.result_return retval = new Lang2Parser.result_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken EOF167=null;
        Lang2Parser.program_return program166 = default(Lang2Parser.program_return);

        object EOF167_tree=null;
        RewriteRuleITokenStream stream_EOF=new RewriteRuleITokenStream(adaptor,"token EOF");
        RewriteRuleSubtreeStream stream_program=new RewriteRuleSubtreeStream(adaptor,"rule program");
    	try { DebugEnterRule(GrammarFileName, "result");
    	DebugLocation(278, 41);
    	try
    	{
    		// Lang2.g:278:7: ( program EOF -> ^( PROGRAM program ) )
    		DebugEnterAlt(1);
    		// Lang2.g:278:9: program EOF
    		{
    		DebugLocation(278, 9);
    		PushFollow(Follow._program_in_result1862);
    		program166=program();
    		PopFollow();

    		stream_program.Add(program166.Tree);
    		DebugLocation(278, 17);
    		EOF167=(IToken)Match(input,EOF,Follow._EOF_in_result1864);  
    		stream_EOF.Add(EOF167);



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
    		// 278:21: -> ^( PROGRAM program )
    		{
    			DebugLocation(278, 24);
    			// Lang2.g:278:24: ^( PROGRAM program )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(278, 26);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PROGRAM, "PROGRAM"), root_1);

    			DebugLocation(278, 34);
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
     	DebugLocation(278, 41);
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
    // Lang2.g:279:8: public execute : result ;
    [GrammarRule("execute")]
    public Lang2Parser.execute_return execute()
    {

        Lang2Parser.execute_return retval = new Lang2Parser.execute_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.result_return result168 = default(Lang2Parser.result_return);


    	try { DebugEnterRule(GrammarFileName, "execute");
    	DebugLocation(279, 23);
    	try
    	{
    		// Lang2.g:279:15: ( result )
    		DebugEnterAlt(1);
    		// Lang2.g:279:18: result
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(279, 18);
    		PushFollow(Follow._result_in_execute1881);
    		result168=result();
    		PopFollow();

    		adaptor.AddChild(root_0, result168.Tree);

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
     	DebugLocation(279, 23);
    	} finally { DebugExitRule(GrammarFileName, "execute"); }
    	return retval;

    }
    // $ANTLR end "execute"

	#region DFA
	DFA1 dfa1;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa1 = new DFA1( this );
	}

	private class DFA1 : DFA
	{
		private const string DFA1_eotS =
			"\x0a\uffff";
		private const string DFA1_eofS =
			"\x06\uffff\x01\x09\x03\uffff";
		private const string DFA1_minS =
			"\x01\x18\x05\uffff\x01\x06\x03\uffff";
		private const string DFA1_maxS =
			"\x01\x46\x05\uffff\x01\x48\x03\uffff";
		private const string DFA1_acceptS =
			"\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01\uffff\x01\x07"+
			"\x01\x08\x01\x06";
		private const string DFA1_specialS =
			"\x0a\uffff}>";
		private static readonly string[] DFA1_transitionS =
			{
				"\x01\x04\x01\x03\x01\x02\x01\x05\x1b\uffff\x01\x06\x0e\uffff\x01\x01",
				"",
				"",
				"",
				"",
				"",
				"\x01\x09\x05\uffff\x01\x09\x01\uffff\x02\x09\x01\uffff\x01\x09\x17"+
				"\uffff\x02\x09\x0a\uffff\x01\x09\x02\uffff\x04\x09\x01\uffff\x06\x09"+
				"\x01\x08\x02\x09\x01\x07\x02\x09",
				"",
				"",
				""
			};

		private static readonly short[] DFA1_eot = DFA.UnpackEncodedString(DFA1_eotS);
		private static readonly short[] DFA1_eof = DFA.UnpackEncodedString(DFA1_eofS);
		private static readonly char[] DFA1_min = DFA.UnpackEncodedStringToUnsignedChars(DFA1_minS);
		private static readonly char[] DFA1_max = DFA.UnpackEncodedStringToUnsignedChars(DFA1_maxS);
		private static readonly short[] DFA1_accept = DFA.UnpackEncodedString(DFA1_acceptS);
		private static readonly short[] DFA1_special = DFA.UnpackEncodedString(DFA1_specialS);
		private static readonly short[][] DFA1_transition;

		static DFA1()
		{
			int numStates = DFA1_transitionS.Length;
			DFA1_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA1_transition[i] = DFA.UnpackEncodedString(DFA1_transitionS[i]);
			}
		}

		public DFA1( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 1;
			this.eot = DFA1_eot;
			this.eof = DFA1_eof;
			this.min = DFA1_min;
			this.max = DFA1_max;
			this.accept = DFA1_accept;
			this.special = DFA1_special;
			this.transition = DFA1_transition;
		}

		public override string Description { get { return "132:1: mathGroup : ( '(' expressions ')' | INT | CHAR | BOOLEAN | STRING | VARIABLE | funcCall | arrayCall );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}


	#endregion DFA

	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _67_in_arrayRange520 = new BitSet(new ulong[]{0x008000000F010000UL,0x0000000000000040UL});
		public static readonly BitSet _expressions_in_arrayRange521 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000010UL});
		public static readonly BitSet _68_in_arrayRange523 = new BitSet(new ulong[]{0x008000000F010000UL,0x0000000000000040UL});
		public static readonly BitSet _expressions_in_arrayRange525 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
		public static readonly BitSet _69_in_arrayRange526 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _OF_in_arrayTypeDecl547 = new BitSet(new ulong[]{0x0000000000780000UL});
		public static readonly BitSet _typeDecl_in_arrayTypeDecl549 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _ARRAY_in_arrayDecl570 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000008UL});
		public static readonly BitSet _arrayRange_in_arrayDecl572 = new BitSet(new ulong[]{0x0000200000000000UL});
		public static readonly BitSet _arrayTypeDecl_in_arrayDecl574 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VARIABLE_in_arrayCall597 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000008UL});
		public static readonly BitSet _67_in_arrayCall599 = new BitSet(new ulong[]{0x008000000F010000UL,0x0000000000000040UL});
		public static readonly BitSet _expressions_in_arrayCall600 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
		public static readonly BitSet _69_in_arrayCall601 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _set_in_boolOperator0 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _70_in_mathGroup752 = new BitSet(new ulong[]{0x008000000F010000UL,0x0000000000000040UL});
		public static readonly BitSet _expressions_in_mathGroup754 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
		public static readonly BitSet _71_in_mathGroup755 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _INT_in_mathGroup762 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _CHAR_in_mathGroup768 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _BOOLEAN_in_mathGroup774 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _STRING_in_mathGroup781 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VARIABLE_in_mathGroup787 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _funcCall_in_mathGroup793 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _arrayCall_in_mathGroup799 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _mathGroup_in_boolMult811 = new BitSet(new ulong[]{0x0000020000000002UL});
		public static readonly BitSet _BOOL_MULT_in_boolMult813 = new BitSet(new ulong[]{0x008000000F000000UL,0x0000000000000040UL});
		public static readonly BitSet _mathGroup_in_boolMult816 = new BitSet(new ulong[]{0x0000020000000002UL});
		public static readonly BitSet _boolMult_in_boolAdd830 = new BitSet(new ulong[]{0x0000040000000002UL});
		public static readonly BitSet _BOOL_ADD_in_boolAdd832 = new BitSet(new ulong[]{0x008000000F000000UL,0x0000000000000040UL});
		public static readonly BitSet _boolMult_in_boolAdd835 = new BitSet(new ulong[]{0x0000040000000002UL});
		public static readonly BitSet _boolAdd_in_boolElse848 = new BitSet(new ulong[]{0xE000000000000002UL,0x0000000000000007UL});
		public static readonly BitSet _boolOperator_in_boolElse850 = new BitSet(new ulong[]{0x008000000F000000UL,0x0000000000000040UL});
		public static readonly BitSet _boolAdd_in_boolElse853 = new BitSet(new ulong[]{0xE000000000000002UL,0x0000000000000007UL});
		public static readonly BitSet _boolElse_in_boolNegative868 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _NOT_in_boolNegative873 = new BitSet(new ulong[]{0x008000000F000000UL,0x0000000000000040UL});
		public static readonly BitSet _boolElse_in_boolNegative876 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _boolNegative_in_useDiv889 = new BitSet(new ulong[]{0x000000000000C002UL});
		public static readonly BitSet _set_in_useDiv891 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000040UL});
		public static readonly BitSet _70_in_useDiv898 = new BitSet(new ulong[]{0x008000000F010000UL,0x0000000000000040UL});
		public static readonly BitSet _boolNegative_in_useDiv901 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
		public static readonly BitSet _71_in_useDiv903 = new BitSet(new ulong[]{0x000000000000C002UL});
		public static readonly BitSet _useDiv_in_mathMult920 = new BitSet(new ulong[]{0x0C00000000000002UL});
		public static readonly BitSet _set_in_mathMult922 = new BitSet(new ulong[]{0x008000000F010000UL,0x0000000000000040UL});
		public static readonly BitSet _useDiv_in_mathMult928 = new BitSet(new ulong[]{0x0C00000000000002UL});
		public static readonly BitSet _mathMult_in_mathAdd941 = new BitSet(new ulong[]{0x0300000000000002UL});
		public static readonly BitSet _set_in_mathAdd943 = new BitSet(new ulong[]{0x008000000F010000UL,0x0000000000000040UL});
		public static readonly BitSet _mathMult_in_mathAdd949 = new BitSet(new ulong[]{0x0300000000000002UL});
		public static readonly BitSet _mathAdd_in_mathExpr963 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _assExpr_in_bodyOper978 = new BitSet(new ulong[]{0x0020000000000000UL});
		public static readonly BitSet _OP_END_in_bodyOper980 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _conditionExpr_in_bodyOper988 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _loopExpr_in_bodyOper995 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _funcCall_in_bodyOper1002 = new BitSet(new ulong[]{0x0020000000000000UL});
		public static readonly BitSet _OP_END_in_bodyOper1004 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _mathExpr_in_expressions1018 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _mathExpr_in_funcCallArgs1032 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000100UL});
		public static readonly BitSet _72_in_funcCallArgs1034 = new BitSet(new ulong[]{0x008000000F010000UL,0x0000000000000040UL});
		public static readonly BitSet _mathExpr_in_funcCallArgs1037 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000100UL});
		public static readonly BitSet _mathExpr_in_funcCallArgsW1052 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000100UL});
		public static readonly BitSet _72_in_funcCallArgsW1054 = new BitSet(new ulong[]{0x008000000F010000UL,0x0000000000000040UL});
		public static readonly BitSet _mathExpr_in_funcCallArgsW1056 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000100UL});
		public static readonly BitSet _VARIABLE_in_funcCall1082 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000040UL});
		public static readonly BitSet _70_in_funcCall1083 = new BitSet(new ulong[]{0x008000000F010000UL,0x00000000000000C0UL});
		public static readonly BitSet _funcCallArgsW_in_funcCall1085 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
		public static readonly BitSet _71_in_funcCall1088 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _70_in_argDeclExpr1112 = new BitSet(new ulong[]{0x0080000000040000UL,0x0000000000000080UL});
		public static readonly BitSet _argDeclMany_in_argDeclExpr1115 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
		public static readonly BitSet _71_in_argDeclExpr1118 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _set_in_retTypeExpr1140 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _retTypeExpr_in_retTypeExprWrap1160 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _varDeclW_in_bodyFuncProcExpr1181 = new BitSet(new ulong[]{0x0000000000000400UL});
		public static readonly BitSet _bodyExpr_in_bodyFuncProcExpr1184 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _FUNCTION_in_funcDeclare1197 = new BitSet(new ulong[]{0x0080000000000000UL});
		public static readonly BitSet _VARIABLE_in_funcDeclare1199 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000040UL});
		public static readonly BitSet _argDeclExpr_in_funcDeclare1201 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000200UL});
		public static readonly BitSet _73_in_funcDeclare1202 = new BitSet(new ulong[]{0x0000000000780000UL});
		public static readonly BitSet _retTypeExprWrap_in_funcDeclare1204 = new BitSet(new ulong[]{0x0020000000000000UL});
		public static readonly BitSet _OP_END_in_funcDeclare1206 = new BitSet(new ulong[]{0x0000000000040400UL});
		public static readonly BitSet _bodyFuncProcExpr_in_funcDeclare1210 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _PROCEDURE_in_procedureDeclare1235 = new BitSet(new ulong[]{0x0080000000000000UL});
		public static readonly BitSet _VARIABLE_in_procedureDeclare1237 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000040UL});
		public static readonly BitSet _argDeclExpr_in_procedureDeclare1239 = new BitSet(new ulong[]{0x0020000000000000UL});
		public static readonly BitSet _OP_END_in_procedureDeclare1241 = new BitSet(new ulong[]{0x0000000000040400UL});
		public static readonly BitSet _bodyFuncProcExpr_in_procedureDeclare1243 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _ELSE_in_conditionElseExpr1270 = new BitSet(new ulong[]{0x0000000000000400UL});
		public static readonly BitSet _bodyExpr_in_conditionElseExpr1273 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _expressions_in_condExpr1295 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _IF_in_conditionExpr1314 = new BitSet(new ulong[]{0x008000000F010000UL,0x0000000000000040UL});
		public static readonly BitSet _condExpr_in_conditionExpr1316 = new BitSet(new ulong[]{0x0000000000001000UL});
		public static readonly BitSet _THEN_in_conditionExpr1318 = new BitSet(new ulong[]{0x0000000000000400UL});
		public static readonly BitSet _bodyExpr_in_conditionExpr1321 = new BitSet(new ulong[]{0x0000000000002002UL});
		public static readonly BitSet _conditionElseExpr_in_conditionExpr1323 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _assExpr_in_forExpr1349 = new BitSet(new ulong[]{0x0000000000020000UL});
		public static readonly BitSet _TO_in_forExpr1351 = new BitSet(new ulong[]{0x008000000F010000UL,0x0000000000000040UL});
		public static readonly BitSet _expressions_in_forExpr1354 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _WHILE_in_loopExpr1364 = new BitSet(new ulong[]{0x008000000F010000UL,0x0000000000000040UL});
		public static readonly BitSet _condExpr_in_loopExpr1366 = new BitSet(new ulong[]{0x0000000000000040UL});
		public static readonly BitSet _DO_in_loopExpr1368 = new BitSet(new ulong[]{0x0000000000000400UL});
		public static readonly BitSet _bodyExpr_in_loopExpr1371 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _FOR_in_loopExpr1387 = new BitSet(new ulong[]{0x008000000F000000UL,0x0000000000000040UL});
		public static readonly BitSet _forExpr_in_loopExpr1389 = new BitSet(new ulong[]{0x0000000000000040UL});
		public static readonly BitSet _DO_in_loopExpr1391 = new BitSet(new ulong[]{0x0000000000000400UL});
		public static readonly BitSet _bodyExpr_in_loopExpr1393 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _REPEAT_in_loopExpr1409 = new BitSet(new ulong[]{0x0000000000000400UL});
		public static readonly BitSet _bodyExpr_in_loopExpr1411 = new BitSet(new ulong[]{0x0010000000000000UL});
		public static readonly BitSet _UNTIL_in_loopExpr1413 = new BitSet(new ulong[]{0x008000000F010000UL,0x0000000000000040UL});
		public static readonly BitSet _condExpr_in_loopExpr1415 = new BitSet(new ulong[]{0x0020000000000000UL});
		public static readonly BitSet _OP_END_in_loopExpr1417 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VARIABLE_in_assExpr1440 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _ASSIGN_in_assExpr1442 = new BitSet(new ulong[]{0x008000000F010000UL,0x0000000000000040UL});
		public static readonly BitSet _expressions_in_assExpr1445 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _arrayCall_in_assExpr1451 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _ASSIGN_in_assExpr1453 = new BitSet(new ulong[]{0x008000000F010000UL,0x0000000000000040UL});
		public static readonly BitSet _expressions_in_assExpr1456 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _varTypeDeclW_in_argTypeDecl1466 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VARIABLE_in_partArgDecl1485 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000100UL});
		public static readonly BitSet _72_in_partArgDecl1487 = new BitSet(new ulong[]{0x0080000000000000UL});
		public static readonly BitSet _VARIABLE_in_partArgDecl1490 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000100UL});
		public static readonly BitSet _VARIABLE_in_argDecl1500 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000300UL});
		public static readonly BitSet _72_in_argDecl1502 = new BitSet(new ulong[]{0x0080000000000000UL});
		public static readonly BitSet _VARIABLE_in_argDecl1505 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000300UL});
		public static readonly BitSet _73_in_argDecl1509 = new BitSet(new ulong[]{0x0000100000780000UL});
		public static readonly BitSet _argTypeDecl_in_argDecl1512 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VAR_in_argDecl1518 = new BitSet(new ulong[]{0x0080000000000000UL});
		public static readonly BitSet _partArgDecl_in_argDecl1520 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000200UL});
		public static readonly BitSet _73_in_argDecl1521 = new BitSet(new ulong[]{0x0000100000780000UL});
		public static readonly BitSet _argTypeDecl_in_argDecl1524 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _argDecl_in_argDeclManyW1545 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000100UL});
		public static readonly BitSet _72_in_argDeclManyW1547 = new BitSet(new ulong[]{0x0080000000040000UL});
		public static readonly BitSet _argDecl_in_argDeclManyW1550 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000100UL});
		public static readonly BitSet _argDeclManyW_in_argDeclMany1563 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _set_in_typeDecl0 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _typeDecl_in_varTypeDeclW1597 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _arrayDecl_in_varTypeDeclW1599 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _varTypeDeclW_in_varTypeDecl1612 = new BitSet(new ulong[]{0x0020000000000000UL});
		public static readonly BitSet _OP_END_in_varTypeDecl1614 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VARIABLE_in_varDecl21635 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000100UL});
		public static readonly BitSet _72_in_varDecl21637 = new BitSet(new ulong[]{0x0080000000000000UL});
		public static readonly BitSet _VARIABLE_in_varDecl21640 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000100UL});
		public static readonly BitSet _varDecl2_in_varDecl1650 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _varDecl_in_varDecl12W1660 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000200UL});
		public static readonly BitSet _73_in_varDecl12W1662 = new BitSet(new ulong[]{0x0000100000780000UL});
		public static readonly BitSet _varTypeDecl_in_varDecl12W1665 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VAR_in_varDeclW1677 = new BitSet(new ulong[]{0x0080000000000000UL});
		public static readonly BitSet _varDecl12W_in_varDeclW1680 = new BitSet(new ulong[]{0x0080000000000002UL});
		public static readonly BitSet _BEGIN_in_bodyExpr1706 = new BitSet(new ulong[]{0x008800000F8008A0UL,0x0000000000000040UL});
		public static readonly BitSet _bodyOper_in_bodyExpr1709 = new BitSet(new ulong[]{0x008800000F8008A0UL,0x0000000000000040UL});
		public static readonly BitSet _END_in_bodyExpr1712 = new BitSet(new ulong[]{0x0020000000000000UL});
		public static readonly BitSet _OP_END_in_bodyExpr1715 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _BEGIN_in_mainBodyExpr1736 = new BitSet(new ulong[]{0x008800000F8008A0UL,0x0000000000000040UL});
		public static readonly BitSet _bodyOper_in_mainBodyExpr1739 = new BitSet(new ulong[]{0x008800000F8008A0UL,0x0000000000000040UL});
		public static readonly BitSet _END_in_mainBodyExpr1742 = new BitSet(new ulong[]{0x0020000000000000UL});
		public static readonly BitSet _OP_END_in_mainBodyExpr1745 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _funcDeclare_in_func_proc_expr1766 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _procedureDeclare_in_func_proc_expr1768 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _func_proc_expr_in_fpExprW1777 = new BitSet(new ulong[]{0x0000000000000302UL});
		public static readonly BitSet _varDeclW_in_wrapToBody1795 = new BitSet(new ulong[]{0x0000000000000300UL});
		public static readonly BitSet _fpExprW_in_wrapToBody1798 = new BitSet(new ulong[]{0x0000000000000400UL});
		public static readonly BitSet _mainBodyExpr_in_wrapToBody1800 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _PROGRAM_in_expr1826 = new BitSet(new ulong[]{0x0080000000000000UL});
		public static readonly BitSet _VARIABLE_in_expr1828 = new BitSet(new ulong[]{0x0020000000000000UL});
		public static readonly BitSet _OP_END_in_expr1830 = new BitSet(new ulong[]{0x0000000000040300UL});
		public static readonly BitSet _wrapToBody_in_expr1833 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _expr_in_program1853 = new BitSet(new ulong[]{0x0000000000000012UL});
		public static readonly BitSet _program_in_result1862 = new BitSet(new ulong[]{0x0000000000000000UL});
		public static readonly BitSet _EOF_in_result1864 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _result_in_execute1881 = new BitSet(new ulong[]{0x0000000000000002UL});

	}
	#endregion Follow sets
}
}