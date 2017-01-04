// $ANTLR 3.3 Nov 30, 2010 12:50:56 Lang2.g 2017-01-04 22:28:48

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
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "PROGRAM", "WHILE", "DO", "FOR", "FUNCTION", "PROCEDURE", "BEGIN", "END", "THEN", "ELSE", "DIV", "MOD", "NOT", "TO", "VAR", "T_CHAR", "T_BOOL", "T_INT", "T_STRING", "IF", "BOOLEAN", "CHAR", "INT", "STRING", "FALSE", "TRUE", "VAR_DECL", "BODY_EXPR", "VAR_EXPR", "FUNC_PROC_EXPR", "PROC_DECL", "FUNC_DECL", "FUNC_CALL", "FUNC_CALL_ARGS", "FUNC_PROC_ARGS", "FUNC_PROC_RET_TYPE", "TYPE_DECL", "BOOL_MULT", "BOOL_ADD", "CONDITION", "ARRAY", "OF", "ARR_DECL", "RANGE", "ARR_CALL", "MAIN_BODY", "VOID", "OP_END", "WS", "VARIABLE", "ADD", "REM", "MULT", "DIVIDE", "ASSIGN", "GREATER", "LESS", "EQUAL", "LESS_OR_EQUAL", "GREATER_OR_EQUAL", "MORE", "'['", "'..'", "']'", "'('", "')'", "','", "':'"
	};
	public const int EOF=-1;
	public const int T__65=65;
	public const int T__66=66;
	public const int T__67=67;
	public const int T__68=68;
	public const int T__69=69;
	public const int T__70=70;
	public const int T__71=71;
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
	public const int OP_END=51;
	public const int WS=52;
	public const int VARIABLE=53;
	public const int ADD=54;
	public const int REM=55;
	public const int MULT=56;
	public const int DIVIDE=57;
	public const int ASSIGN=58;
	public const int GREATER=59;
	public const int LESS=60;
	public const int EQUAL=61;
	public const int LESS_OR_EQUAL=62;
	public const int GREATER_OR_EQUAL=63;
	public const int MORE=64;

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
    // Lang2.g:91:1: arrayRange : '[' expressions '..' expressions ']' -> ^( RANGE expressions expressions ) ;
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
        RewriteRuleITokenStream stream_66=new RewriteRuleITokenStream(adaptor,"token 66");
        RewriteRuleITokenStream stream_65=new RewriteRuleITokenStream(adaptor,"token 65");
        RewriteRuleSubtreeStream stream_expressions=new RewriteRuleSubtreeStream(adaptor,"rule expressions");
    	try { DebugEnterRule(GrammarFileName, "arrayRange");
    	DebugLocation(91, 3);
    	try
    	{
    		// Lang2.g:91:12: ( '[' expressions '..' expressions ']' -> ^( RANGE expressions expressions ) )
    		DebugEnterAlt(1);
    		// Lang2.g:91:14: '[' expressions '..' expressions ']'
    		{
    		DebugLocation(91, 14);
    		char_literal1=(IToken)Match(input,65,Follow._65_in_arrayRange491);  
    		stream_65.Add(char_literal1);

    		DebugLocation(91, 17);
    		PushFollow(Follow._expressions_in_arrayRange492);
    		expressions2=expressions();
    		PopFollow();

    		stream_expressions.Add(expressions2.Tree);
    		DebugLocation(91, 29);
    		string_literal3=(IToken)Match(input,66,Follow._66_in_arrayRange494);  
    		stream_66.Add(string_literal3);

    		DebugLocation(91, 34);
    		PushFollow(Follow._expressions_in_arrayRange496);
    		expressions4=expressions();
    		PopFollow();

    		stream_expressions.Add(expressions4.Tree);
    		DebugLocation(91, 45);
    		char_literal5=(IToken)Match(input,67,Follow._67_in_arrayRange497);  
    		stream_67.Add(char_literal5);



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
    		// 91:49: -> ^( RANGE expressions expressions )
    		{
    			DebugLocation(91, 52);
    			// Lang2.g:91:52: ^( RANGE expressions expressions )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(91, 54);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(RANGE, "RANGE"), root_1);

    			DebugLocation(91, 60);
    			adaptor.AddChild(root_1, stream_expressions.NextTree());
    			DebugLocation(91, 72);
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
     	DebugLocation(92, 3);
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
    // Lang2.g:93:1: arrayTypeDecl : OF typeDecl -> ^( TYPE_DECL typeDecl ) ;
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
    	DebugLocation(93, 4);
    	try
    	{
    		// Lang2.g:93:15: ( OF typeDecl -> ^( TYPE_DECL typeDecl ) )
    		DebugEnterAlt(1);
    		// Lang2.g:93:17: OF typeDecl
    		{
    		DebugLocation(93, 17);
    		OF6=(IToken)Match(input,OF,Follow._OF_in_arrayTypeDecl518);  
    		stream_OF.Add(OF6);

    		DebugLocation(93, 20);
    		PushFollow(Follow._typeDecl_in_arrayTypeDecl520);
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
    		// 93:29: -> ^( TYPE_DECL typeDecl )
    		{
    			DebugLocation(93, 32);
    			// Lang2.g:93:32: ^( TYPE_DECL typeDecl )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(93, 34);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(TYPE_DECL, "TYPE_DECL"), root_1);

    			DebugLocation(93, 44);
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
     	DebugLocation(94, 4);
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
    // Lang2.g:95:1: arrayDecl : ARRAY arrayRange arrayTypeDecl -> ^( ARR_DECL arrayRange arrayTypeDecl ) ;
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
    	DebugLocation(95, 3);
    	try
    	{
    		// Lang2.g:95:11: ( ARRAY arrayRange arrayTypeDecl -> ^( ARR_DECL arrayRange arrayTypeDecl ) )
    		DebugEnterAlt(1);
    		// Lang2.g:95:14: ARRAY arrayRange arrayTypeDecl
    		{
    		DebugLocation(95, 14);
    		ARRAY8=(IToken)Match(input,ARRAY,Follow._ARRAY_in_arrayDecl541);  
    		stream_ARRAY.Add(ARRAY8);

    		DebugLocation(95, 20);
    		PushFollow(Follow._arrayRange_in_arrayDecl543);
    		arrayRange9=arrayRange();
    		PopFollow();

    		stream_arrayRange.Add(arrayRange9.Tree);
    		DebugLocation(95, 31);
    		PushFollow(Follow._arrayTypeDecl_in_arrayDecl545);
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
    		// 95:45: -> ^( ARR_DECL arrayRange arrayTypeDecl )
    		{
    			DebugLocation(95, 48);
    			// Lang2.g:95:48: ^( ARR_DECL arrayRange arrayTypeDecl )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(95, 50);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARR_DECL, "ARR_DECL"), root_1);

    			DebugLocation(95, 59);
    			adaptor.AddChild(root_1, stream_arrayRange.NextTree());
    			DebugLocation(95, 70);
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
     	DebugLocation(96, 3);
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
    // Lang2.g:98:1: arrayCall : VARIABLE '[' expressions ']' -> ^( ARR_CALL VARIABLE expressions ) ;
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
        RewriteRuleITokenStream stream_VARIABLE=new RewriteRuleITokenStream(adaptor,"token VARIABLE");
        RewriteRuleITokenStream stream_65=new RewriteRuleITokenStream(adaptor,"token 65");
        RewriteRuleSubtreeStream stream_expressions=new RewriteRuleSubtreeStream(adaptor,"rule expressions");
    	try { DebugEnterRule(GrammarFileName, "arrayCall");
    	DebugLocation(98, 3);
    	try
    	{
    		// Lang2.g:98:11: ( VARIABLE '[' expressions ']' -> ^( ARR_CALL VARIABLE expressions ) )
    		DebugEnterAlt(1);
    		// Lang2.g:98:13: VARIABLE '[' expressions ']'
    		{
    		DebugLocation(98, 13);
    		VARIABLE11=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_arrayCall568);  
    		stream_VARIABLE.Add(VARIABLE11);

    		DebugLocation(98, 22);
    		char_literal12=(IToken)Match(input,65,Follow._65_in_arrayCall570);  
    		stream_65.Add(char_literal12);

    		DebugLocation(98, 25);
    		PushFollow(Follow._expressions_in_arrayCall571);
    		expressions13=expressions();
    		PopFollow();

    		stream_expressions.Add(expressions13.Tree);
    		DebugLocation(98, 36);
    		char_literal14=(IToken)Match(input,67,Follow._67_in_arrayCall572);  
    		stream_67.Add(char_literal14);



    		{
    		// AST REWRITE
    		// elements: VARIABLE, expressions
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 98:40: -> ^( ARR_CALL VARIABLE expressions )
    		{
    			DebugLocation(98, 43);
    			// Lang2.g:98:43: ^( ARR_CALL VARIABLE expressions )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(98, 45);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARR_CALL, "ARR_CALL"), root_1);

    			DebugLocation(98, 54);
    			adaptor.AddChild(root_1, stream_VARIABLE.NextNode());
    			DebugLocation(98, 63);
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
     	DebugLocation(99, 3);
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
    // Lang2.g:126:1: boolOperator : ( MORE | LESS | EQUAL | LESS_OR_EQUAL | GREATER_OR_EQUAL | GREATER );
    [GrammarRule("boolOperator")]
    private Lang2Parser.boolOperator_return boolOperator()
    {

        Lang2Parser.boolOperator_return retval = new Lang2Parser.boolOperator_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken set15=null;

        object set15_tree=null;

    	try { DebugEnterRule(GrammarFileName, "boolOperator");
    	DebugLocation(126, 3);
    	try
    	{
    		// Lang2.g:126:13: ( MORE | LESS | EQUAL | LESS_OR_EQUAL | GREATER_OR_EQUAL | GREATER )
    		DebugEnterAlt(1);
    		// Lang2.g:
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(126, 13);
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
     	DebugLocation(127, 3);
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
    // Lang2.g:130:1: mathGroup : ( '(' expressions ')' | INT | CHAR | BOOLEAN | STRING | VARIABLE | funcCall );
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
    	DebugLocation(130, 2);
    	try
    	{
    		// Lang2.g:130:11: ( '(' expressions ')' | INT | CHAR | BOOLEAN | STRING | VARIABLE | funcCall )
    		int alt1=7;
    		try { DebugEnterDecision(1, decisionCanBacktrack[1]);
    		switch (input.LA(1))
    		{
    		case 68:
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

    			if ((LA1_6==68))
    			{
    				alt1=7;
    			}
    			else if ((LA1_6==EOF||LA1_6==DO||LA1_6==THEN||(LA1_6>=DIV && LA1_6<=TO)||(LA1_6>=BOOL_MULT && LA1_6<=BOOL_ADD)||LA1_6==OP_END||(LA1_6>=ADD && LA1_6<=DIVIDE)||(LA1_6>=GREATER && LA1_6<=MORE)||(LA1_6>=66 && LA1_6<=67)||(LA1_6>=69 && LA1_6<=70)))
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
    			// Lang2.g:130:13: '(' expressions ')'
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(130, 16);
    			char_literal16=(IToken)Match(input,68,Follow._68_in_mathGroup724); 
    			DebugLocation(130, 17);
    			PushFollow(Follow._expressions_in_mathGroup726);
    			expressions17=expressions();
    			PopFollow();

    			adaptor.AddChild(root_0, expressions17.Tree);
    			DebugLocation(130, 31);
    			char_literal18=(IToken)Match(input,69,Follow._69_in_mathGroup727); 

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Lang2.g:131:5: INT
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(131, 5);
    			INT19=(IToken)Match(input,INT,Follow._INT_in_mathGroup734); 
    			INT19_tree = (object)adaptor.Create(INT19);
    			adaptor.AddChild(root_0, INT19_tree);


    			}
    			break;
    		case 3:
    			DebugEnterAlt(3);
    			// Lang2.g:132:5: CHAR
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(132, 5);
    			CHAR20=(IToken)Match(input,CHAR,Follow._CHAR_in_mathGroup740); 
    			CHAR20_tree = (object)adaptor.Create(CHAR20);
    			adaptor.AddChild(root_0, CHAR20_tree);


    			}
    			break;
    		case 4:
    			DebugEnterAlt(4);
    			// Lang2.g:133:5: BOOLEAN
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(133, 5);
    			BOOLEAN21=(IToken)Match(input,BOOLEAN,Follow._BOOLEAN_in_mathGroup746); 
    			BOOLEAN21_tree = (object)adaptor.Create(BOOLEAN21);
    			adaptor.AddChild(root_0, BOOLEAN21_tree);


    			}
    			break;
    		case 5:
    			DebugEnterAlt(5);
    			// Lang2.g:134:5: STRING
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(134, 5);
    			STRING22=(IToken)Match(input,STRING,Follow._STRING_in_mathGroup753); 
    			STRING22_tree = (object)adaptor.Create(STRING22);
    			adaptor.AddChild(root_0, STRING22_tree);


    			}
    			break;
    		case 6:
    			DebugEnterAlt(6);
    			// Lang2.g:135:5: VARIABLE
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(135, 5);
    			VARIABLE23=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_mathGroup759); 
    			VARIABLE23_tree = (object)adaptor.Create(VARIABLE23);
    			adaptor.AddChild(root_0, VARIABLE23_tree);


    			}
    			break;
    		case 7:
    			DebugEnterAlt(7);
    			// Lang2.g:136:5: funcCall
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(136, 5);
    			PushFollow(Follow._funcCall_in_mathGroup765);
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
     	DebugLocation(137, 2);
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
    // Lang2.g:140:1: boolMult : mathGroup ( BOOL_MULT mathGroup )* ;
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
    	DebugLocation(140, 3);
    	try
    	{
    		// Lang2.g:140:10: ( mathGroup ( BOOL_MULT mathGroup )* )
    		DebugEnterAlt(1);
    		// Lang2.g:140:12: mathGroup ( BOOL_MULT mathGroup )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(140, 12);
    		PushFollow(Follow._mathGroup_in_boolMult777);
    		mathGroup25=mathGroup();
    		PopFollow();

    		adaptor.AddChild(root_0, mathGroup25.Tree);
    		DebugLocation(140, 21);
    		// Lang2.g:140:21: ( BOOL_MULT mathGroup )*
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
    				// Lang2.g:140:22: BOOL_MULT mathGroup
    				{
    				DebugLocation(140, 31);
    				BOOL_MULT26=(IToken)Match(input,BOOL_MULT,Follow._BOOL_MULT_in_boolMult779); 
    				BOOL_MULT26_tree = (object)adaptor.Create(BOOL_MULT26);
    				root_0 = (object)adaptor.BecomeRoot(BOOL_MULT26_tree, root_0);

    				DebugLocation(140, 33);
    				PushFollow(Follow._mathGroup_in_boolMult782);
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
     	DebugLocation(141, 3);
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
    // Lang2.g:143:1: boolAdd : boolMult ( BOOL_ADD boolMult )* ;
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
    	DebugLocation(143, 2);
    	try
    	{
    		// Lang2.g:143:9: ( boolMult ( BOOL_ADD boolMult )* )
    		DebugEnterAlt(1);
    		// Lang2.g:143:11: boolMult ( BOOL_ADD boolMult )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(143, 11);
    		PushFollow(Follow._boolMult_in_boolAdd796);
    		boolMult28=boolMult();
    		PopFollow();

    		adaptor.AddChild(root_0, boolMult28.Tree);
    		DebugLocation(143, 19);
    		// Lang2.g:143:19: ( BOOL_ADD boolMult )*
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
    				// Lang2.g:143:20: BOOL_ADD boolMult
    				{
    				DebugLocation(143, 28);
    				BOOL_ADD29=(IToken)Match(input,BOOL_ADD,Follow._BOOL_ADD_in_boolAdd798); 
    				BOOL_ADD29_tree = (object)adaptor.Create(BOOL_ADD29);
    				root_0 = (object)adaptor.BecomeRoot(BOOL_ADD29_tree, root_0);

    				DebugLocation(143, 30);
    				PushFollow(Follow._boolMult_in_boolAdd801);
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
     	DebugLocation(144, 2);
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
    // Lang2.g:146:1: boolElse : boolAdd ( boolOperator boolAdd )* ;
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
    	DebugLocation(146, 3);
    	try
    	{
    		// Lang2.g:146:10: ( boolAdd ( boolOperator boolAdd )* )
    		DebugEnterAlt(1);
    		// Lang2.g:146:12: boolAdd ( boolOperator boolAdd )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(146, 12);
    		PushFollow(Follow._boolAdd_in_boolElse814);
    		boolAdd31=boolAdd();
    		PopFollow();

    		adaptor.AddChild(root_0, boolAdd31.Tree);
    		DebugLocation(146, 19);
    		// Lang2.g:146:19: ( boolOperator boolAdd )*
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
    				// Lang2.g:146:20: boolOperator boolAdd
    				{
    				DebugLocation(146, 32);
    				PushFollow(Follow._boolOperator_in_boolElse816);
    				boolOperator32=boolOperator();
    				PopFollow();

    				root_0 = (object)adaptor.BecomeRoot(boolOperator32.Tree, root_0);
    				DebugLocation(146, 34);
    				PushFollow(Follow._boolAdd_in_boolElse819);
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
     	DebugLocation(147, 3);
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
    // Lang2.g:149:1: boolNegative : boolElse ( NOT boolElse )* ;
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
    	DebugLocation(149, 3);
    	try
    	{
    		// Lang2.g:149:14: ( boolElse ( NOT boolElse )* )
    		DebugEnterAlt(1);
    		// Lang2.g:149:16: boolElse ( NOT boolElse )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(149, 16);
    		PushFollow(Follow._boolElse_in_boolNegative833);
    		boolElse34=boolElse();
    		PopFollow();

    		adaptor.AddChild(root_0, boolElse34.Tree);
    		DebugLocation(149, 25);
    		// Lang2.g:149:25: ( NOT boolElse )*
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
    				// Lang2.g:149:26: NOT boolElse
    				{
    				DebugLocation(149, 29);
    				NOT35=(IToken)Match(input,NOT,Follow._NOT_in_boolNegative836); 
    				NOT35_tree = (object)adaptor.Create(NOT35);
    				root_0 = (object)adaptor.BecomeRoot(NOT35_tree, root_0);

    				DebugLocation(149, 31);
    				PushFollow(Follow._boolElse_in_boolNegative839);
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
     	DebugLocation(150, 3);
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
    // Lang2.g:152:1: useDiv : boolNegative ( ( DIV | MOD ) '(' boolNegative ')' )* ;
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
    	DebugLocation(152, 2);
    	try
    	{
    		// Lang2.g:152:8: ( boolNegative ( ( DIV | MOD ) '(' boolNegative ')' )* )
    		DebugEnterAlt(1);
    		// Lang2.g:152:10: boolNegative ( ( DIV | MOD ) '(' boolNegative ')' )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(152, 10);
    		PushFollow(Follow._boolNegative_in_useDiv853);
    		boolNegative37=boolNegative();
    		PopFollow();

    		adaptor.AddChild(root_0, boolNegative37.Tree);
    		DebugLocation(152, 22);
    		// Lang2.g:152:22: ( ( DIV | MOD ) '(' boolNegative ')' )*
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
    				// Lang2.g:152:23: ( DIV | MOD ) '(' boolNegative ')'
    				{
    				DebugLocation(152, 23);
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

    				DebugLocation(152, 37);
    				char_literal39=(IToken)Match(input,68,Follow._68_in_useDiv862); 
    				DebugLocation(152, 39);
    				PushFollow(Follow._boolNegative_in_useDiv865);
    				boolNegative40=boolNegative();
    				PopFollow();

    				adaptor.AddChild(root_0, boolNegative40.Tree);
    				DebugLocation(152, 55);
    				char_literal41=(IToken)Match(input,69,Follow._69_in_useDiv867); 

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
     	DebugLocation(153, 2);
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
    // Lang2.g:155:1: mathMult : useDiv ( ( MULT | DIVIDE ) useDiv )* ;
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
    	DebugLocation(155, 1);
    	try
    	{
    		// Lang2.g:156:2: ( useDiv ( ( MULT | DIVIDE ) useDiv )* )
    		DebugEnterAlt(1);
    		// Lang2.g:156:4: useDiv ( ( MULT | DIVIDE ) useDiv )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(156, 4);
    		PushFollow(Follow._useDiv_in_mathMult884);
    		useDiv42=useDiv();
    		PopFollow();

    		adaptor.AddChild(root_0, useDiv42.Tree);
    		DebugLocation(156, 10);
    		// Lang2.g:156:10: ( ( MULT | DIVIDE ) useDiv )*
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
    				// Lang2.g:156:11: ( MULT | DIVIDE ) useDiv
    				{
    				DebugLocation(156, 11);
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

    				DebugLocation(156, 25);
    				PushFollow(Follow._useDiv_in_mathMult892);
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
     	DebugLocation(157, 1);
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
    // Lang2.g:159:1: mathAdd : mathMult ( ( ADD | REM ) mathMult )* ;
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
    	DebugLocation(159, 1);
    	try
    	{
    		// Lang2.g:159:9: ( mathMult ( ( ADD | REM ) mathMult )* )
    		DebugEnterAlt(1);
    		// Lang2.g:159:11: mathMult ( ( ADD | REM ) mathMult )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(159, 11);
    		PushFollow(Follow._mathMult_in_mathAdd905);
    		mathMult45=mathMult();
    		PopFollow();

    		adaptor.AddChild(root_0, mathMult45.Tree);
    		DebugLocation(159, 19);
    		// Lang2.g:159:19: ( ( ADD | REM ) mathMult )*
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
    				// Lang2.g:159:20: ( ADD | REM ) mathMult
    				{
    				DebugLocation(159, 20);
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

    				DebugLocation(159, 30);
    				PushFollow(Follow._mathMult_in_mathAdd913);
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
     	DebugLocation(160, 1);
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
    // Lang2.g:162:1: mathExpr : mathAdd ;
    [GrammarRule("mathExpr")]
    private Lang2Parser.mathExpr_return mathExpr()
    {

        Lang2Parser.mathExpr_return retval = new Lang2Parser.mathExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.mathAdd_return mathAdd48 = default(Lang2Parser.mathAdd_return);


    	try { DebugEnterRule(GrammarFileName, "mathExpr");
    	DebugLocation(162, 1);
    	try
    	{
    		// Lang2.g:163:2: ( mathAdd )
    		DebugEnterAlt(1);
    		// Lang2.g:163:4: mathAdd
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(163, 4);
    		PushFollow(Follow._mathAdd_in_mathExpr927);
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
     	DebugLocation(165, 1);
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
    // Lang2.g:169:1: bodyOper : ( assExpr OP_END | conditionExpr | loopExpr | funcCall OP_END );
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
    	DebugLocation(169, 4);
    	try
    	{
    		// Lang2.g:169:10: ( assExpr OP_END | conditionExpr | loopExpr | funcCall OP_END )
    		int alt9=4;
    		try { DebugEnterDecision(9, decisionCanBacktrack[9]);
    		switch (input.LA(1))
    		{
    		case VARIABLE:
    			{
    			int LA9_1 = input.LA(2);

    			if ((LA9_1==ASSIGN||LA9_1==65))
    			{
    				alt9=1;
    			}
    			else if ((LA9_1==68))
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
    			// Lang2.g:169:12: assExpr OP_END
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(169, 12);
    			PushFollow(Follow._assExpr_in_bodyOper942);
    			assExpr49=assExpr();
    			PopFollow();

    			adaptor.AddChild(root_0, assExpr49.Tree);
    			DebugLocation(169, 26);
    			OP_END50=(IToken)Match(input,OP_END,Follow._OP_END_in_bodyOper944); 

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Lang2.g:170:6: conditionExpr
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(170, 6);
    			PushFollow(Follow._conditionExpr_in_bodyOper952);
    			conditionExpr51=conditionExpr();
    			PopFollow();

    			adaptor.AddChild(root_0, conditionExpr51.Tree);

    			}
    			break;
    		case 3:
    			DebugEnterAlt(3);
    			// Lang2.g:171:6: loopExpr
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(171, 6);
    			PushFollow(Follow._loopExpr_in_bodyOper959);
    			loopExpr52=loopExpr();
    			PopFollow();

    			adaptor.AddChild(root_0, loopExpr52.Tree);

    			}
    			break;
    		case 4:
    			DebugEnterAlt(4);
    			// Lang2.g:172:6: funcCall OP_END
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(172, 6);
    			PushFollow(Follow._funcCall_in_bodyOper966);
    			funcCall53=funcCall();
    			PopFollow();

    			adaptor.AddChild(root_0, funcCall53.Tree);
    			DebugLocation(172, 21);
    			OP_END54=(IToken)Match(input,OP_END,Follow._OP_END_in_bodyOper968); 

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
     	DebugLocation(173, 4);
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
    // Lang2.g:175:1: expressions : ( mathExpr | arrayCall );
    [GrammarRule("expressions")]
    private Lang2Parser.expressions_return expressions()
    {

        Lang2Parser.expressions_return retval = new Lang2Parser.expressions_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.mathExpr_return mathExpr55 = default(Lang2Parser.mathExpr_return);
        Lang2Parser.arrayCall_return arrayCall56 = default(Lang2Parser.arrayCall_return);


    	try { DebugEnterRule(GrammarFileName, "expressions");
    	DebugLocation(175, 4);
    	try
    	{
    		// Lang2.g:175:13: ( mathExpr | arrayCall )
    		int alt10=2;
    		try { DebugEnterDecision(10, decisionCanBacktrack[10]);
    		int LA10_0 = input.LA(1);

    		if (((LA10_0>=BOOLEAN && LA10_0<=STRING)||LA10_0==68))
    		{
    			alt10=1;
    		}
    		else if ((LA10_0==VARIABLE))
    		{
    			int LA10_2 = input.LA(2);

    			if ((LA10_2==DO||LA10_2==THEN||(LA10_2>=DIV && LA10_2<=TO)||(LA10_2>=BOOL_MULT && LA10_2<=BOOL_ADD)||LA10_2==OP_END||(LA10_2>=ADD && LA10_2<=DIVIDE)||(LA10_2>=GREATER && LA10_2<=MORE)||(LA10_2>=66 && LA10_2<=69)))
    			{
    				alt10=1;
    			}
    			else if ((LA10_2==65))
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
    			// Lang2.g:175:15: mathExpr
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(175, 15);
    			PushFollow(Follow._mathExpr_in_expressions982);
    			mathExpr55=mathExpr();
    			PopFollow();

    			adaptor.AddChild(root_0, mathExpr55.Tree);

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Lang2.g:176:6: arrayCall
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(176, 6);
    			PushFollow(Follow._arrayCall_in_expressions989);
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
     	DebugLocation(177, 4);
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
    // Lang2.g:179:1: funcCallArgs : mathExpr ( ',' mathExpr )* ;
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
    	DebugLocation(179, 4);
    	try
    	{
    		// Lang2.g:179:14: ( mathExpr ( ',' mathExpr )* )
    		DebugEnterAlt(1);
    		// Lang2.g:179:17: mathExpr ( ',' mathExpr )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(179, 17);
    		PushFollow(Follow._mathExpr_in_funcCallArgs1003);
    		mathExpr57=mathExpr();
    		PopFollow();

    		adaptor.AddChild(root_0, mathExpr57.Tree);
    		DebugLocation(179, 25);
    		// Lang2.g:179:25: ( ',' mathExpr )*
    		try { DebugEnterSubRule(11);
    		while (true)
    		{
    			int alt11=2;
    			try { DebugEnterDecision(11, decisionCanBacktrack[11]);
    			int LA11_0 = input.LA(1);

    			if ((LA11_0==70))
    			{
    				alt11=1;
    			}


    			} finally { DebugExitDecision(11); }
    			switch ( alt11 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:179:26: ',' mathExpr
    				{
    				DebugLocation(179, 29);
    				char_literal58=(IToken)Match(input,70,Follow._70_in_funcCallArgs1005); 
    				DebugLocation(179, 31);
    				PushFollow(Follow._mathExpr_in_funcCallArgs1008);
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
     	DebugLocation(180, 4);
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
    // Lang2.g:181:1: funcCallArgsW : mathExpr ( ',' mathExpr )* -> ^( FUNC_CALL_ARGS mathExpr ( mathExpr )* ) ;
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
        RewriteRuleITokenStream stream_70=new RewriteRuleITokenStream(adaptor,"token 70");
        RewriteRuleSubtreeStream stream_mathExpr=new RewriteRuleSubtreeStream(adaptor,"rule mathExpr");
    	try { DebugEnterRule(GrammarFileName, "funcCallArgsW");
    	DebugLocation(181, 4);
    	try
    	{
    		// Lang2.g:181:15: ( mathExpr ( ',' mathExpr )* -> ^( FUNC_CALL_ARGS mathExpr ( mathExpr )* ) )
    		DebugEnterAlt(1);
    		// Lang2.g:181:17: mathExpr ( ',' mathExpr )*
    		{
    		DebugLocation(181, 17);
    		PushFollow(Follow._mathExpr_in_funcCallArgsW1023);
    		mathExpr60=mathExpr();
    		PopFollow();

    		stream_mathExpr.Add(mathExpr60.Tree);
    		DebugLocation(181, 25);
    		// Lang2.g:181:25: ( ',' mathExpr )*
    		try { DebugEnterSubRule(12);
    		while (true)
    		{
    			int alt12=2;
    			try { DebugEnterDecision(12, decisionCanBacktrack[12]);
    			int LA12_0 = input.LA(1);

    			if ((LA12_0==70))
    			{
    				alt12=1;
    			}


    			} finally { DebugExitDecision(12); }
    			switch ( alt12 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:181:26: ',' mathExpr
    				{
    				DebugLocation(181, 26);
    				char_literal61=(IToken)Match(input,70,Follow._70_in_funcCallArgsW1025);  
    				stream_70.Add(char_literal61);

    				DebugLocation(181, 30);
    				PushFollow(Follow._mathExpr_in_funcCallArgsW1027);
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
    		// 181:41: -> ^( FUNC_CALL_ARGS mathExpr ( mathExpr )* )
    		{
    			DebugLocation(181, 44);
    			// Lang2.g:181:44: ^( FUNC_CALL_ARGS mathExpr ( mathExpr )* )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(181, 46);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_CALL_ARGS, "FUNC_CALL_ARGS"), root_1);

    			DebugLocation(181, 61);
    			adaptor.AddChild(root_1, stream_mathExpr.NextTree());
    			DebugLocation(181, 70);
    			// Lang2.g:181:70: ( mathExpr )*
    			while ( stream_mathExpr.HasNext )
    			{
    				DebugLocation(181, 70);
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
     	DebugLocation(182, 4);
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
    // Lang2.g:184:1: funcCall : VARIABLE '(' ( funcCallArgsW )? ')' -> ^( FUNC_CALL VARIABLE ( funcCallArgsW )? ) ;
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
        RewriteRuleITokenStream stream_69=new RewriteRuleITokenStream(adaptor,"token 69");
        RewriteRuleITokenStream stream_68=new RewriteRuleITokenStream(adaptor,"token 68");
        RewriteRuleITokenStream stream_VARIABLE=new RewriteRuleITokenStream(adaptor,"token VARIABLE");
        RewriteRuleSubtreeStream stream_funcCallArgsW=new RewriteRuleSubtreeStream(adaptor,"rule funcCallArgsW");
    	try { DebugEnterRule(GrammarFileName, "funcCall");
    	DebugLocation(184, 3);
    	try
    	{
    		// Lang2.g:184:10: ( VARIABLE '(' ( funcCallArgsW )? ')' -> ^( FUNC_CALL VARIABLE ( funcCallArgsW )? ) )
    		DebugEnterAlt(1);
    		// Lang2.g:184:12: VARIABLE '(' ( funcCallArgsW )? ')'
    		{
    		DebugLocation(184, 12);
    		VARIABLE63=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_funcCall1053);  
    		stream_VARIABLE.Add(VARIABLE63);

    		DebugLocation(184, 20);
    		char_literal64=(IToken)Match(input,68,Follow._68_in_funcCall1054);  
    		stream_68.Add(char_literal64);

    		DebugLocation(184, 24);
    		// Lang2.g:184:24: ( funcCallArgsW )?
    		int alt13=2;
    		try { DebugEnterSubRule(13);
    		try { DebugEnterDecision(13, decisionCanBacktrack[13]);
    		int LA13_0 = input.LA(1);

    		if (((LA13_0>=BOOLEAN && LA13_0<=STRING)||LA13_0==VARIABLE||LA13_0==68))
    		{
    			alt13=1;
    		}
    		} finally { DebugExitDecision(13); }
    		switch (alt13)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Lang2.g:184:24: funcCallArgsW
    			{
    			DebugLocation(184, 24);
    			PushFollow(Follow._funcCallArgsW_in_funcCall1056);
    			funcCallArgsW65=funcCallArgsW();
    			PopFollow();

    			stream_funcCallArgsW.Add(funcCallArgsW65.Tree);

    			}
    			break;

    		}
    		} finally { DebugExitSubRule(13); }

    		DebugLocation(184, 39);
    		char_literal66=(IToken)Match(input,69,Follow._69_in_funcCall1059);  
    		stream_69.Add(char_literal66);



    		{
    		// AST REWRITE
    		// elements: funcCallArgsW, VARIABLE
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 184:43: -> ^( FUNC_CALL VARIABLE ( funcCallArgsW )? )
    		{
    			DebugLocation(184, 46);
    			// Lang2.g:184:46: ^( FUNC_CALL VARIABLE ( funcCallArgsW )? )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(184, 48);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_CALL, "FUNC_CALL"), root_1);

    			DebugLocation(184, 58);
    			adaptor.AddChild(root_1, stream_VARIABLE.NextNode());
    			DebugLocation(184, 67);
    			// Lang2.g:184:67: ( funcCallArgsW )?
    			if ( stream_funcCallArgsW.HasNext )
    			{
    				DebugLocation(184, 67);
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
     	DebugLocation(185, 3);
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
    // Lang2.g:187:1: argDeclExpr : '(' ( argDeclMany )? ')' -> ^( FUNC_PROC_ARGS ( argDeclMany )? ) ;
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
        RewriteRuleITokenStream stream_69=new RewriteRuleITokenStream(adaptor,"token 69");
        RewriteRuleITokenStream stream_68=new RewriteRuleITokenStream(adaptor,"token 68");
        RewriteRuleSubtreeStream stream_argDeclMany=new RewriteRuleSubtreeStream(adaptor,"rule argDeclMany");
    	try { DebugEnterRule(GrammarFileName, "argDeclExpr");
    	DebugLocation(187, 3);
    	try
    	{
    		// Lang2.g:187:13: ( '(' ( argDeclMany )? ')' -> ^( FUNC_PROC_ARGS ( argDeclMany )? ) )
    		DebugEnterAlt(1);
    		// Lang2.g:187:15: '(' ( argDeclMany )? ')'
    		{
    		DebugLocation(187, 18);
    		char_literal67=(IToken)Match(input,68,Follow._68_in_argDeclExpr1083);  
    		stream_68.Add(char_literal67);

    		DebugLocation(187, 20);
    		// Lang2.g:187:20: ( argDeclMany )?
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
    			// Lang2.g:187:20: argDeclMany
    			{
    			DebugLocation(187, 20);
    			PushFollow(Follow._argDeclMany_in_argDeclExpr1086);
    			argDeclMany68=argDeclMany();
    			PopFollow();

    			stream_argDeclMany.Add(argDeclMany68.Tree);

    			}
    			break;

    		}
    		} finally { DebugExitSubRule(14); }

    		DebugLocation(187, 36);
    		char_literal69=(IToken)Match(input,69,Follow._69_in_argDeclExpr1089);  
    		stream_69.Add(char_literal69);



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
    		// 187:38: -> ^( FUNC_PROC_ARGS ( argDeclMany )? )
    		{
    			DebugLocation(187, 41);
    			// Lang2.g:187:41: ^( FUNC_PROC_ARGS ( argDeclMany )? )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(187, 43);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_PROC_ARGS, "FUNC_PROC_ARGS"), root_1);

    			DebugLocation(187, 58);
    			// Lang2.g:187:58: ( argDeclMany )?
    			if ( stream_argDeclMany.HasNext )
    			{
    				DebugLocation(187, 58);
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
     	DebugLocation(188, 3);
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
    // Lang2.g:190:1: retTypeExpr : ( T_INT | T_BOOL | T_CHAR | T_STRING ) ;
    [GrammarRule("retTypeExpr")]
    private Lang2Parser.retTypeExpr_return retTypeExpr()
    {

        Lang2Parser.retTypeExpr_return retval = new Lang2Parser.retTypeExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken set70=null;

        object set70_tree=null;

    	try { DebugEnterRule(GrammarFileName, "retTypeExpr");
    	DebugLocation(190, 3);
    	try
    	{
    		// Lang2.g:190:13: ( ( T_INT | T_BOOL | T_CHAR | T_STRING ) )
    		DebugEnterAlt(1);
    		// Lang2.g:190:15: ( T_INT | T_BOOL | T_CHAR | T_STRING )
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(190, 15);
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
     	DebugLocation(191, 3);
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
    // Lang2.g:193:1: retTypeExprWrap : retTypeExpr -> ^( FUNC_PROC_RET_TYPE retTypeExpr ) ;
    [GrammarRule("retTypeExprWrap")]
    private Lang2Parser.retTypeExprWrap_return retTypeExprWrap()
    {

        Lang2Parser.retTypeExprWrap_return retval = new Lang2Parser.retTypeExprWrap_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.retTypeExpr_return retTypeExpr71 = default(Lang2Parser.retTypeExpr_return);

        RewriteRuleSubtreeStream stream_retTypeExpr=new RewriteRuleSubtreeStream(adaptor,"rule retTypeExpr");
    	try { DebugEnterRule(GrammarFileName, "retTypeExprWrap");
    	DebugLocation(193, 4);
    	try
    	{
    		// Lang2.g:193:17: ( retTypeExpr -> ^( FUNC_PROC_RET_TYPE retTypeExpr ) )
    		DebugEnterAlt(1);
    		// Lang2.g:193:19: retTypeExpr
    		{
    		DebugLocation(193, 19);
    		PushFollow(Follow._retTypeExpr_in_retTypeExprWrap1131);
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
    		// 193:31: -> ^( FUNC_PROC_RET_TYPE retTypeExpr )
    		{
    			DebugLocation(193, 34);
    			// Lang2.g:193:34: ^( FUNC_PROC_RET_TYPE retTypeExpr )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(193, 36);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_PROC_RET_TYPE, "FUNC_PROC_RET_TYPE"), root_1);

    			DebugLocation(193, 55);
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
     	DebugLocation(194, 4);
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
    // Lang2.g:196:1: bodyFuncProcExpr : ( varDeclW )? bodyExpr ;
    [GrammarRule("bodyFuncProcExpr")]
    private Lang2Parser.bodyFuncProcExpr_return bodyFuncProcExpr()
    {

        Lang2Parser.bodyFuncProcExpr_return retval = new Lang2Parser.bodyFuncProcExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.varDeclW_return varDeclW72 = default(Lang2Parser.varDeclW_return);
        Lang2Parser.bodyExpr_return bodyExpr73 = default(Lang2Parser.bodyExpr_return);


    	try { DebugEnterRule(GrammarFileName, "bodyFuncProcExpr");
    	DebugLocation(196, 5);
    	try
    	{
    		// Lang2.g:196:18: ( ( varDeclW )? bodyExpr )
    		DebugEnterAlt(1);
    		// Lang2.g:196:20: ( varDeclW )? bodyExpr
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(196, 20);
    		// Lang2.g:196:20: ( varDeclW )?
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
    			// Lang2.g:196:20: varDeclW
    			{
    			DebugLocation(196, 20);
    			PushFollow(Follow._varDeclW_in_bodyFuncProcExpr1152);
    			varDeclW72=varDeclW();
    			PopFollow();

    			adaptor.AddChild(root_0, varDeclW72.Tree);

    			}
    			break;

    		}
    		} finally { DebugExitSubRule(15); }

    		DebugLocation(196, 30);
    		PushFollow(Follow._bodyExpr_in_bodyFuncProcExpr1155);
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
     	DebugLocation(197, 5);
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
    // Lang2.g:199:1: funcDeclare : FUNCTION VARIABLE argDeclExpr ':' retTypeExprWrap OP_END bodyFuncProcExpr -> ^( FUNC_DECL VARIABLE argDeclExpr retTypeExprWrap bodyFuncProcExpr ) ;
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
        RewriteRuleITokenStream stream_71=new RewriteRuleITokenStream(adaptor,"token 71");
        RewriteRuleSubtreeStream stream_argDeclExpr=new RewriteRuleSubtreeStream(adaptor,"rule argDeclExpr");
        RewriteRuleSubtreeStream stream_bodyFuncProcExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodyFuncProcExpr");
        RewriteRuleSubtreeStream stream_retTypeExprWrap=new RewriteRuleSubtreeStream(adaptor,"rule retTypeExprWrap");
    	try { DebugEnterRule(GrammarFileName, "funcDeclare");
    	DebugLocation(199, 3);
    	try
    	{
    		// Lang2.g:199:12: ( FUNCTION VARIABLE argDeclExpr ':' retTypeExprWrap OP_END bodyFuncProcExpr -> ^( FUNC_DECL VARIABLE argDeclExpr retTypeExprWrap bodyFuncProcExpr ) )
    		DebugEnterAlt(1);
    		// Lang2.g:199:14: FUNCTION VARIABLE argDeclExpr ':' retTypeExprWrap OP_END bodyFuncProcExpr
    		{
    		DebugLocation(199, 14);
    		FUNCTION74=(IToken)Match(input,FUNCTION,Follow._FUNCTION_in_funcDeclare1168);  
    		stream_FUNCTION.Add(FUNCTION74);

    		DebugLocation(199, 23);
    		VARIABLE75=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_funcDeclare1170);  
    		stream_VARIABLE.Add(VARIABLE75);

    		DebugLocation(199, 32);
    		PushFollow(Follow._argDeclExpr_in_funcDeclare1172);
    		argDeclExpr76=argDeclExpr();
    		PopFollow();

    		stream_argDeclExpr.Add(argDeclExpr76.Tree);
    		DebugLocation(199, 43);
    		char_literal77=(IToken)Match(input,71,Follow._71_in_funcDeclare1173);  
    		stream_71.Add(char_literal77);

    		DebugLocation(199, 47);
    		PushFollow(Follow._retTypeExprWrap_in_funcDeclare1175);
    		retTypeExprWrap78=retTypeExprWrap();
    		PopFollow();

    		stream_retTypeExprWrap.Add(retTypeExprWrap78.Tree);
    		DebugLocation(199, 69);
    		OP_END79=(IToken)Match(input,OP_END,Follow._OP_END_in_funcDeclare1177);  
    		stream_OP_END.Add(OP_END79);

    		DebugLocation(199, 72);
    		PushFollow(Follow._bodyFuncProcExpr_in_funcDeclare1181);
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
    		// 199:89: -> ^( FUNC_DECL VARIABLE argDeclExpr retTypeExprWrap bodyFuncProcExpr )
    		{
    			DebugLocation(199, 92);
    			// Lang2.g:199:92: ^( FUNC_DECL VARIABLE argDeclExpr retTypeExprWrap bodyFuncProcExpr )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(199, 94);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_DECL, "FUNC_DECL"), root_1);

    			DebugLocation(199, 104);
    			adaptor.AddChild(root_1, stream_VARIABLE.NextNode());
    			DebugLocation(199, 113);
    			adaptor.AddChild(root_1, stream_argDeclExpr.NextTree());
    			DebugLocation(199, 125);
    			adaptor.AddChild(root_1, stream_retTypeExprWrap.NextTree());
    			DebugLocation(199, 141);
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
     	DebugLocation(200, 3);
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
    // Lang2.g:202:1: procedureDeclare : PROCEDURE VARIABLE argDeclExpr OP_END bodyFuncProcExpr -> ^( PROC_DECL VARIABLE argDeclExpr bodyFuncProcExpr ) ;
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
    	DebugLocation(202, 4);
    	try
    	{
    		// Lang2.g:202:17: ( PROCEDURE VARIABLE argDeclExpr OP_END bodyFuncProcExpr -> ^( PROC_DECL VARIABLE argDeclExpr bodyFuncProcExpr ) )
    		DebugEnterAlt(1);
    		// Lang2.g:202:19: PROCEDURE VARIABLE argDeclExpr OP_END bodyFuncProcExpr
    		{
    		DebugLocation(202, 19);
    		PROCEDURE81=(IToken)Match(input,PROCEDURE,Follow._PROCEDURE_in_procedureDeclare1206);  
    		stream_PROCEDURE.Add(PROCEDURE81);

    		DebugLocation(202, 29);
    		VARIABLE82=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_procedureDeclare1208);  
    		stream_VARIABLE.Add(VARIABLE82);

    		DebugLocation(202, 38);
    		PushFollow(Follow._argDeclExpr_in_procedureDeclare1210);
    		argDeclExpr83=argDeclExpr();
    		PopFollow();

    		stream_argDeclExpr.Add(argDeclExpr83.Tree);
    		DebugLocation(202, 50);
    		OP_END84=(IToken)Match(input,OP_END,Follow._OP_END_in_procedureDeclare1212);  
    		stream_OP_END.Add(OP_END84);

    		DebugLocation(202, 57);
    		PushFollow(Follow._bodyFuncProcExpr_in_procedureDeclare1214);
    		bodyFuncProcExpr85=bodyFuncProcExpr();
    		PopFollow();

    		stream_bodyFuncProcExpr.Add(bodyFuncProcExpr85.Tree);


    		{
    		// AST REWRITE
    		// elements: VARIABLE, bodyFuncProcExpr, argDeclExpr
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 202:74: -> ^( PROC_DECL VARIABLE argDeclExpr bodyFuncProcExpr )
    		{
    			DebugLocation(202, 77);
    			// Lang2.g:202:77: ^( PROC_DECL VARIABLE argDeclExpr bodyFuncProcExpr )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(202, 79);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PROC_DECL, "PROC_DECL"), root_1);

    			DebugLocation(202, 89);
    			adaptor.AddChild(root_1, stream_VARIABLE.NextNode());
    			DebugLocation(202, 98);
    			adaptor.AddChild(root_1, stream_argDeclExpr.NextTree());
    			DebugLocation(202, 110);
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
     	DebugLocation(203, 4);
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
    // Lang2.g:207:1: conditionElseExpr : ELSE bodyExpr -> ^( ELSE bodyExpr ) ;
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
    	DebugLocation(207, 5);
    	try
    	{
    		// Lang2.g:207:19: ( ELSE bodyExpr -> ^( ELSE bodyExpr ) )
    		DebugEnterAlt(1);
    		// Lang2.g:207:21: ELSE bodyExpr
    		{
    		DebugLocation(207, 25);
    		ELSE86=(IToken)Match(input,ELSE,Follow._ELSE_in_conditionElseExpr1241);  
    		stream_ELSE.Add(ELSE86);

    		DebugLocation(207, 27);
    		PushFollow(Follow._bodyExpr_in_conditionElseExpr1244);
    		bodyExpr87=bodyExpr();
    		PopFollow();

    		stream_bodyExpr.Add(bodyExpr87.Tree);


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
    		// 207:36: -> ^( ELSE bodyExpr )
    		{
    			DebugLocation(207, 39);
    			// Lang2.g:207:39: ^( ELSE bodyExpr )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(207, 41);
    			root_1 = (object)adaptor.BecomeRoot(stream_ELSE.NextNode(), root_1);

    			DebugLocation(207, 46);
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
     	DebugLocation(208, 5);
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
    // Lang2.g:209:1: condExpr : expressions -> ^( CONDITION expressions ) ;
    [GrammarRule("condExpr")]
    private Lang2Parser.condExpr_return condExpr()
    {

        Lang2Parser.condExpr_return retval = new Lang2Parser.condExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.expressions_return expressions88 = default(Lang2Parser.expressions_return);

        RewriteRuleSubtreeStream stream_expressions=new RewriteRuleSubtreeStream(adaptor,"rule expressions");
    	try { DebugEnterRule(GrammarFileName, "condExpr");
    	DebugLocation(209, 3);
    	try
    	{
    		// Lang2.g:209:10: ( expressions -> ^( CONDITION expressions ) )
    		DebugEnterAlt(1);
    		// Lang2.g:209:13: expressions
    		{
    		DebugLocation(209, 13);
    		PushFollow(Follow._expressions_in_condExpr1266);
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
    		// 209:26: -> ^( CONDITION expressions )
    		{
    			DebugLocation(209, 29);
    			// Lang2.g:209:29: ^( CONDITION expressions )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(209, 31);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(CONDITION, "CONDITION"), root_1);

    			DebugLocation(209, 41);
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
     	DebugLocation(210, 3);
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
    // Lang2.g:211:1: conditionExpr : IF condExpr THEN bodyExpr ( conditionElseExpr )? -> ^( IF condExpr bodyExpr ( conditionElseExpr )? ) ;
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
    	DebugLocation(211, 1);
    	try
    	{
    		// Lang2.g:211:14: ( IF condExpr THEN bodyExpr ( conditionElseExpr )? -> ^( IF condExpr bodyExpr ( conditionElseExpr )? ) )
    		DebugEnterAlt(1);
    		// Lang2.g:211:16: IF condExpr THEN bodyExpr ( conditionElseExpr )?
    		{
    		DebugLocation(211, 16);
    		IF89=(IToken)Match(input,IF,Follow._IF_in_conditionExpr1285);  
    		stream_IF.Add(IF89);

    		DebugLocation(211, 19);
    		PushFollow(Follow._condExpr_in_conditionExpr1287);
    		condExpr90=condExpr();
    		PopFollow();

    		stream_condExpr.Add(condExpr90.Tree);
    		DebugLocation(211, 32);
    		THEN91=(IToken)Match(input,THEN,Follow._THEN_in_conditionExpr1289);  
    		stream_THEN.Add(THEN91);

    		DebugLocation(211, 34);
    		PushFollow(Follow._bodyExpr_in_conditionExpr1292);
    		bodyExpr92=bodyExpr();
    		PopFollow();

    		stream_bodyExpr.Add(bodyExpr92.Tree);
    		DebugLocation(211, 43);
    		// Lang2.g:211:43: ( conditionElseExpr )?
    		int alt16=2;
    		try { DebugEnterSubRule(16);
    		try { DebugEnterDecision(16, decisionCanBacktrack[16]);
    		int LA16_0 = input.LA(1);

    		if ((LA16_0==ELSE))
    		{
    			alt16=1;
    		}
    		} finally { DebugExitDecision(16); }
    		switch (alt16)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Lang2.g:211:43: conditionElseExpr
    			{
    			DebugLocation(211, 43);
    			PushFollow(Follow._conditionElseExpr_in_conditionExpr1294);
    			conditionElseExpr93=conditionElseExpr();
    			PopFollow();

    			stream_conditionElseExpr.Add(conditionElseExpr93.Tree);

    			}
    			break;

    		}
    		} finally { DebugExitSubRule(16); }



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
    		// 211:62: -> ^( IF condExpr bodyExpr ( conditionElseExpr )? )
    		{
    			DebugLocation(211, 65);
    			// Lang2.g:211:65: ^( IF condExpr bodyExpr ( conditionElseExpr )? )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(211, 67);
    			root_1 = (object)adaptor.BecomeRoot(stream_IF.NextNode(), root_1);

    			DebugLocation(211, 70);
    			adaptor.AddChild(root_1, stream_condExpr.NextTree());
    			DebugLocation(211, 79);
    			adaptor.AddChild(root_1, stream_bodyExpr.NextTree());
    			DebugLocation(211, 88);
    			// Lang2.g:211:88: ( conditionElseExpr )?
    			if ( stream_conditionElseExpr.HasNext )
    			{
    				DebugLocation(211, 88);
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
     	DebugLocation(212, 1);
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
    // Lang2.g:215:1: forExpr : assExpr TO expressions ;
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
    	DebugLocation(215, 2);
    	try
    	{
    		// Lang2.g:215:9: ( assExpr TO expressions )
    		DebugEnterAlt(1);
    		// Lang2.g:215:12: assExpr TO expressions
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(215, 12);
    		PushFollow(Follow._assExpr_in_forExpr1320);
    		assExpr94=assExpr();
    		PopFollow();

    		adaptor.AddChild(root_0, assExpr94.Tree);
    		DebugLocation(215, 22);
    		TO95=(IToken)Match(input,TO,Follow._TO_in_forExpr1322); 
    		TO95_tree = (object)adaptor.Create(TO95);
    		root_0 = (object)adaptor.BecomeRoot(TO95_tree, root_0);

    		DebugLocation(215, 24);
    		PushFollow(Follow._expressions_in_forExpr1325);
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
     	DebugLocation(216, 2);
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
    // Lang2.g:217:1: loopExpr : ( WHILE condExpr DO bodyExpr -> ^( WHILE condExpr bodyExpr ) | FOR forExpr DO bodyExpr -> ^( FOR forExpr bodyExpr ) );
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
        Lang2Parser.condExpr_return condExpr98 = default(Lang2Parser.condExpr_return);
        Lang2Parser.bodyExpr_return bodyExpr100 = default(Lang2Parser.bodyExpr_return);
        Lang2Parser.forExpr_return forExpr102 = default(Lang2Parser.forExpr_return);
        Lang2Parser.bodyExpr_return bodyExpr104 = default(Lang2Parser.bodyExpr_return);

        object WHILE97_tree=null;
        object DO99_tree=null;
        object FOR101_tree=null;
        object DO103_tree=null;
        RewriteRuleITokenStream stream_FOR=new RewriteRuleITokenStream(adaptor,"token FOR");
        RewriteRuleITokenStream stream_DO=new RewriteRuleITokenStream(adaptor,"token DO");
        RewriteRuleITokenStream stream_WHILE=new RewriteRuleITokenStream(adaptor,"token WHILE");
        RewriteRuleSubtreeStream stream_condExpr=new RewriteRuleSubtreeStream(adaptor,"rule condExpr");
        RewriteRuleSubtreeStream stream_bodyExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodyExpr");
        RewriteRuleSubtreeStream stream_forExpr=new RewriteRuleSubtreeStream(adaptor,"rule forExpr");
    	try { DebugEnterRule(GrammarFileName, "loopExpr");
    	DebugLocation(217, 2);
    	try
    	{
    		// Lang2.g:217:9: ( WHILE condExpr DO bodyExpr -> ^( WHILE condExpr bodyExpr ) | FOR forExpr DO bodyExpr -> ^( FOR forExpr bodyExpr ) )
    		int alt17=2;
    		try { DebugEnterDecision(17, decisionCanBacktrack[17]);
    		int LA17_0 = input.LA(1);

    		if ((LA17_0==WHILE))
    		{
    			alt17=1;
    		}
    		else if ((LA17_0==FOR))
    		{
    			alt17=2;
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
    			// Lang2.g:217:11: WHILE condExpr DO bodyExpr
    			{
    			DebugLocation(217, 11);
    			WHILE97=(IToken)Match(input,WHILE,Follow._WHILE_in_loopExpr1334);  
    			stream_WHILE.Add(WHILE97);

    			DebugLocation(217, 17);
    			PushFollow(Follow._condExpr_in_loopExpr1336);
    			condExpr98=condExpr();
    			PopFollow();

    			stream_condExpr.Add(condExpr98.Tree);
    			DebugLocation(217, 28);
    			DO99=(IToken)Match(input,DO,Follow._DO_in_loopExpr1338);  
    			stream_DO.Add(DO99);

    			DebugLocation(217, 30);
    			PushFollow(Follow._bodyExpr_in_loopExpr1341);
    			bodyExpr100=bodyExpr();
    			PopFollow();

    			stream_bodyExpr.Add(bodyExpr100.Tree);


    			{
    			// AST REWRITE
    			// elements: condExpr, WHILE, bodyExpr
    			// token labels: 
    			// rule labels: retval
    			// token list labels: 
    			// rule list labels: 
    			// wildcard labels: 
    			retval.Tree = root_0;
    			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    			root_0 = (object)adaptor.Nil();
    			// 217:39: -> ^( WHILE condExpr bodyExpr )
    			{
    				DebugLocation(217, 42);
    				// Lang2.g:217:42: ^( WHILE condExpr bodyExpr )
    				{
    				object root_1 = (object)adaptor.Nil();
    				DebugLocation(217, 44);
    				root_1 = (object)adaptor.BecomeRoot(stream_WHILE.NextNode(), root_1);

    				DebugLocation(217, 50);
    				adaptor.AddChild(root_1, stream_condExpr.NextTree());
    				DebugLocation(217, 59);
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
    			// Lang2.g:218:5: FOR forExpr DO bodyExpr
    			{
    			DebugLocation(218, 5);
    			FOR101=(IToken)Match(input,FOR,Follow._FOR_in_loopExpr1357);  
    			stream_FOR.Add(FOR101);

    			DebugLocation(218, 9);
    			PushFollow(Follow._forExpr_in_loopExpr1359);
    			forExpr102=forExpr();
    			PopFollow();

    			stream_forExpr.Add(forExpr102.Tree);
    			DebugLocation(218, 17);
    			DO103=(IToken)Match(input,DO,Follow._DO_in_loopExpr1361);  
    			stream_DO.Add(DO103);

    			DebugLocation(218, 20);
    			PushFollow(Follow._bodyExpr_in_loopExpr1363);
    			bodyExpr104=bodyExpr();
    			PopFollow();

    			stream_bodyExpr.Add(bodyExpr104.Tree);


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
    			// 218:29: -> ^( FOR forExpr bodyExpr )
    			{
    				DebugLocation(218, 32);
    				// Lang2.g:218:32: ^( FOR forExpr bodyExpr )
    				{
    				object root_1 = (object)adaptor.Nil();
    				DebugLocation(218, 34);
    				root_1 = (object)adaptor.BecomeRoot(stream_FOR.NextNode(), root_1);

    				DebugLocation(218, 38);
    				adaptor.AddChild(root_1, stream_forExpr.NextTree());
    				DebugLocation(218, 46);
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
     	DebugLocation(219, 2);
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
    // Lang2.g:221:1: assExpr : ( VARIABLE ASSIGN expressions | arrayCall ASSIGN expressions );
    [GrammarRule("assExpr")]
    private Lang2Parser.assExpr_return assExpr()
    {

        Lang2Parser.assExpr_return retval = new Lang2Parser.assExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken VARIABLE105=null;
        IToken ASSIGN106=null;
        IToken ASSIGN109=null;
        Lang2Parser.expressions_return expressions107 = default(Lang2Parser.expressions_return);
        Lang2Parser.arrayCall_return arrayCall108 = default(Lang2Parser.arrayCall_return);
        Lang2Parser.expressions_return expressions110 = default(Lang2Parser.expressions_return);

        object VARIABLE105_tree=null;
        object ASSIGN106_tree=null;
        object ASSIGN109_tree=null;

    	try { DebugEnterRule(GrammarFileName, "assExpr");
    	DebugLocation(221, 1);
    	try
    	{
    		// Lang2.g:221:9: ( VARIABLE ASSIGN expressions | arrayCall ASSIGN expressions )
    		int alt18=2;
    		try { DebugEnterDecision(18, decisionCanBacktrack[18]);
    		int LA18_0 = input.LA(1);

    		if ((LA18_0==VARIABLE))
    		{
    			int LA18_1 = input.LA(2);

    			if ((LA18_1==ASSIGN))
    			{
    				alt18=1;
    			}
    			else if ((LA18_1==65))
    			{
    				alt18=2;
    			}
    			else
    			{
    				NoViableAltException nvae = new NoViableAltException("", 18, 1, input);

    				DebugRecognitionException(nvae);
    				throw nvae;
    			}
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
    			// Lang2.g:221:12: VARIABLE ASSIGN expressions
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(221, 12);
    			VARIABLE105=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_assExpr1386); 
    			VARIABLE105_tree = (object)adaptor.Create(VARIABLE105);
    			adaptor.AddChild(root_0, VARIABLE105_tree);

    			DebugLocation(221, 27);
    			ASSIGN106=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assExpr1388); 
    			ASSIGN106_tree = (object)adaptor.Create(ASSIGN106);
    			root_0 = (object)adaptor.BecomeRoot(ASSIGN106_tree, root_0);

    			DebugLocation(221, 29);
    			PushFollow(Follow._expressions_in_assExpr1391);
    			expressions107=expressions();
    			PopFollow();

    			adaptor.AddChild(root_0, expressions107.Tree);

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Lang2.g:222:5: arrayCall ASSIGN expressions
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(222, 5);
    			PushFollow(Follow._arrayCall_in_assExpr1397);
    			arrayCall108=arrayCall();
    			PopFollow();

    			adaptor.AddChild(root_0, arrayCall108.Tree);
    			DebugLocation(222, 21);
    			ASSIGN109=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assExpr1399); 
    			ASSIGN109_tree = (object)adaptor.Create(ASSIGN109);
    			root_0 = (object)adaptor.BecomeRoot(ASSIGN109_tree, root_0);

    			DebugLocation(222, 23);
    			PushFollow(Follow._expressions_in_assExpr1402);
    			expressions110=expressions();
    			PopFollow();

    			adaptor.AddChild(root_0, expressions110.Tree);

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
     	DebugLocation(223, 1);
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
    // Lang2.g:225:1: argTypeDecl : varTypeDeclW -> ^( TYPE_DECL varTypeDeclW ) ;
    [GrammarRule("argTypeDecl")]
    private Lang2Parser.argTypeDecl_return argTypeDecl()
    {

        Lang2Parser.argTypeDecl_return retval = new Lang2Parser.argTypeDecl_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.varTypeDeclW_return varTypeDeclW111 = default(Lang2Parser.varTypeDeclW_return);

        RewriteRuleSubtreeStream stream_varTypeDeclW=new RewriteRuleSubtreeStream(adaptor,"rule varTypeDeclW");
    	try { DebugEnterRule(GrammarFileName, "argTypeDecl");
    	DebugLocation(225, 3);
    	try
    	{
    		// Lang2.g:225:13: ( varTypeDeclW -> ^( TYPE_DECL varTypeDeclW ) )
    		DebugEnterAlt(1);
    		// Lang2.g:225:15: varTypeDeclW
    		{
    		DebugLocation(225, 15);
    		PushFollow(Follow._varTypeDeclW_in_argTypeDecl1412);
    		varTypeDeclW111=varTypeDeclW();
    		PopFollow();

    		stream_varTypeDeclW.Add(varTypeDeclW111.Tree);


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
    		// 225:28: -> ^( TYPE_DECL varTypeDeclW )
    		{
    			DebugLocation(225, 31);
    			// Lang2.g:225:31: ^( TYPE_DECL varTypeDeclW )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(225, 33);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(TYPE_DECL, "TYPE_DECL"), root_1);

    			DebugLocation(225, 43);
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
     	DebugLocation(226, 3);
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
    // Lang2.g:228:1: partArgDecl : VARIABLE ( ',' VARIABLE )* ;
    [GrammarRule("partArgDecl")]
    private Lang2Parser.partArgDecl_return partArgDecl()
    {

        Lang2Parser.partArgDecl_return retval = new Lang2Parser.partArgDecl_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken VARIABLE112=null;
        IToken char_literal113=null;
        IToken VARIABLE114=null;

        object VARIABLE112_tree=null;
        object char_literal113_tree=null;
        object VARIABLE114_tree=null;

    	try { DebugEnterRule(GrammarFileName, "partArgDecl");
    	DebugLocation(228, 37);
    	try
    	{
    		// Lang2.g:228:12: ( VARIABLE ( ',' VARIABLE )* )
    		DebugEnterAlt(1);
    		// Lang2.g:228:14: VARIABLE ( ',' VARIABLE )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(228, 14);
    		VARIABLE112=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_partArgDecl1431); 
    		VARIABLE112_tree = (object)adaptor.Create(VARIABLE112);
    		adaptor.AddChild(root_0, VARIABLE112_tree);

    		DebugLocation(228, 22);
    		// Lang2.g:228:22: ( ',' VARIABLE )*
    		try { DebugEnterSubRule(19);
    		while (true)
    		{
    			int alt19=2;
    			try { DebugEnterDecision(19, decisionCanBacktrack[19]);
    			int LA19_0 = input.LA(1);

    			if ((LA19_0==70))
    			{
    				alt19=1;
    			}


    			} finally { DebugExitDecision(19); }
    			switch ( alt19 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:228:23: ',' VARIABLE
    				{
    				DebugLocation(228, 26);
    				char_literal113=(IToken)Match(input,70,Follow._70_in_partArgDecl1433); 
    				DebugLocation(228, 28);
    				VARIABLE114=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_partArgDecl1436); 
    				VARIABLE114_tree = (object)adaptor.Create(VARIABLE114);
    				adaptor.AddChild(root_0, VARIABLE114_tree);


    				}
    				break;

    			default:
    				goto loop19;
    			}
    		}

    		loop19:
    			;

    		} finally { DebugExitSubRule(19); }


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
     	DebugLocation(228, 37);
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
    // Lang2.g:230:1: argDecl : ( VARIABLE ( ',' VARIABLE )* ':' argTypeDecl | VAR partArgDecl ':' argTypeDecl -> ^( VAR partArgDecl argTypeDecl ) );
    [GrammarRule("argDecl")]
    private Lang2Parser.argDecl_return argDecl()
    {

        Lang2Parser.argDecl_return retval = new Lang2Parser.argDecl_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken VARIABLE115=null;
        IToken char_literal116=null;
        IToken VARIABLE117=null;
        IToken char_literal118=null;
        IToken VAR120=null;
        IToken char_literal122=null;
        Lang2Parser.argTypeDecl_return argTypeDecl119 = default(Lang2Parser.argTypeDecl_return);
        Lang2Parser.partArgDecl_return partArgDecl121 = default(Lang2Parser.partArgDecl_return);
        Lang2Parser.argTypeDecl_return argTypeDecl123 = default(Lang2Parser.argTypeDecl_return);

        object VARIABLE115_tree=null;
        object char_literal116_tree=null;
        object VARIABLE117_tree=null;
        object char_literal118_tree=null;
        object VAR120_tree=null;
        object char_literal122_tree=null;
        RewriteRuleITokenStream stream_VAR=new RewriteRuleITokenStream(adaptor,"token VAR");
        RewriteRuleITokenStream stream_71=new RewriteRuleITokenStream(adaptor,"token 71");
        RewriteRuleSubtreeStream stream_partArgDecl=new RewriteRuleSubtreeStream(adaptor,"rule partArgDecl");
        RewriteRuleSubtreeStream stream_argTypeDecl=new RewriteRuleSubtreeStream(adaptor,"rule argTypeDecl");
    	try { DebugEnterRule(GrammarFileName, "argDecl");
    	DebugLocation(230, 2);
    	try
    	{
    		// Lang2.g:230:9: ( VARIABLE ( ',' VARIABLE )* ':' argTypeDecl | VAR partArgDecl ':' argTypeDecl -> ^( VAR partArgDecl argTypeDecl ) )
    		int alt21=2;
    		try { DebugEnterDecision(21, decisionCanBacktrack[21]);
    		int LA21_0 = input.LA(1);

    		if ((LA21_0==VARIABLE))
    		{
    			alt21=1;
    		}
    		else if ((LA21_0==VAR))
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
    			// Lang2.g:230:11: VARIABLE ( ',' VARIABLE )* ':' argTypeDecl
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(230, 11);
    			VARIABLE115=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_argDecl1446); 
    			VARIABLE115_tree = (object)adaptor.Create(VARIABLE115);
    			adaptor.AddChild(root_0, VARIABLE115_tree);

    			DebugLocation(230, 19);
    			// Lang2.g:230:19: ( ',' VARIABLE )*
    			try { DebugEnterSubRule(20);
    			while (true)
    			{
    				int alt20=2;
    				try { DebugEnterDecision(20, decisionCanBacktrack[20]);
    				int LA20_0 = input.LA(1);

    				if ((LA20_0==70))
    				{
    					alt20=1;
    				}


    				} finally { DebugExitDecision(20); }
    				switch ( alt20 )
    				{
    				case 1:
    					DebugEnterAlt(1);
    					// Lang2.g:230:20: ',' VARIABLE
    					{
    					DebugLocation(230, 23);
    					char_literal116=(IToken)Match(input,70,Follow._70_in_argDecl1448); 
    					DebugLocation(230, 25);
    					VARIABLE117=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_argDecl1451); 
    					VARIABLE117_tree = (object)adaptor.Create(VARIABLE117);
    					adaptor.AddChild(root_0, VARIABLE117_tree);


    					}
    					break;

    				default:
    					goto loop20;
    				}
    			}

    			loop20:
    				;

    			} finally { DebugExitSubRule(20); }

    			DebugLocation(230, 39);
    			char_literal118=(IToken)Match(input,71,Follow._71_in_argDecl1455); 
    			DebugLocation(230, 41);
    			PushFollow(Follow._argTypeDecl_in_argDecl1458);
    			argTypeDecl119=argTypeDecl();
    			PopFollow();

    			adaptor.AddChild(root_0, argTypeDecl119.Tree);

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Lang2.g:231:5: VAR partArgDecl ':' argTypeDecl
    			{
    			DebugLocation(231, 5);
    			VAR120=(IToken)Match(input,VAR,Follow._VAR_in_argDecl1464);  
    			stream_VAR.Add(VAR120);

    			DebugLocation(231, 9);
    			PushFollow(Follow._partArgDecl_in_argDecl1466);
    			partArgDecl121=partArgDecl();
    			PopFollow();

    			stream_partArgDecl.Add(partArgDecl121.Tree);
    			DebugLocation(231, 23);
    			char_literal122=(IToken)Match(input,71,Follow._71_in_argDecl1467);  
    			stream_71.Add(char_literal122);

    			DebugLocation(231, 25);
    			PushFollow(Follow._argTypeDecl_in_argDecl1470);
    			argTypeDecl123=argTypeDecl();
    			PopFollow();

    			stream_argTypeDecl.Add(argTypeDecl123.Tree);


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
    			// 231:37: -> ^( VAR partArgDecl argTypeDecl )
    			{
    				DebugLocation(231, 40);
    				// Lang2.g:231:40: ^( VAR partArgDecl argTypeDecl )
    				{
    				object root_1 = (object)adaptor.Nil();
    				DebugLocation(231, 42);
    				root_1 = (object)adaptor.BecomeRoot(stream_VAR.NextNode(), root_1);

    				DebugLocation(231, 46);
    				adaptor.AddChild(root_1, stream_partArgDecl.NextTree());
    				DebugLocation(231, 58);
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
     	DebugLocation(232, 2);
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
    // Lang2.g:234:1: argDeclManyW : argDecl ( ',' argDecl )* ;
    [GrammarRule("argDeclManyW")]
    private Lang2Parser.argDeclManyW_return argDeclManyW()
    {

        Lang2Parser.argDeclManyW_return retval = new Lang2Parser.argDeclManyW_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken char_literal125=null;
        Lang2Parser.argDecl_return argDecl124 = default(Lang2Parser.argDecl_return);
        Lang2Parser.argDecl_return argDecl126 = default(Lang2Parser.argDecl_return);

        object char_literal125_tree=null;

    	try { DebugEnterRule(GrammarFileName, "argDeclManyW");
    	DebugLocation(234, 3);
    	try
    	{
    		// Lang2.g:234:14: ( argDecl ( ',' argDecl )* )
    		DebugEnterAlt(1);
    		// Lang2.g:234:16: argDecl ( ',' argDecl )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(234, 16);
    		PushFollow(Follow._argDecl_in_argDeclManyW1491);
    		argDecl124=argDecl();
    		PopFollow();

    		adaptor.AddChild(root_0, argDecl124.Tree);
    		DebugLocation(234, 23);
    		// Lang2.g:234:23: ( ',' argDecl )*
    		try { DebugEnterSubRule(22);
    		while (true)
    		{
    			int alt22=2;
    			try { DebugEnterDecision(22, decisionCanBacktrack[22]);
    			int LA22_0 = input.LA(1);

    			if ((LA22_0==70))
    			{
    				alt22=1;
    			}


    			} finally { DebugExitDecision(22); }
    			switch ( alt22 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:234:24: ',' argDecl
    				{
    				DebugLocation(234, 27);
    				char_literal125=(IToken)Match(input,70,Follow._70_in_argDeclManyW1493); 
    				DebugLocation(234, 29);
    				PushFollow(Follow._argDecl_in_argDeclManyW1496);
    				argDecl126=argDecl();
    				PopFollow();

    				adaptor.AddChild(root_0, argDecl126.Tree);

    				}
    				break;

    			default:
    				goto loop22;
    			}
    		}

    		loop22:
    			;

    		} finally { DebugExitSubRule(22); }


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
    // Lang2.g:236:1: argDeclMany : argDeclManyW -> ^( VAR_DECL argDeclManyW ) ;
    [GrammarRule("argDeclMany")]
    private Lang2Parser.argDeclMany_return argDeclMany()
    {

        Lang2Parser.argDeclMany_return retval = new Lang2Parser.argDeclMany_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.argDeclManyW_return argDeclManyW127 = default(Lang2Parser.argDeclManyW_return);

        RewriteRuleSubtreeStream stream_argDeclManyW=new RewriteRuleSubtreeStream(adaptor,"rule argDeclManyW");
    	try { DebugEnterRule(GrammarFileName, "argDeclMany");
    	DebugLocation(236, 3);
    	try
    	{
    		// Lang2.g:236:13: ( argDeclManyW -> ^( VAR_DECL argDeclManyW ) )
    		DebugEnterAlt(1);
    		// Lang2.g:236:15: argDeclManyW
    		{
    		DebugLocation(236, 15);
    		PushFollow(Follow._argDeclManyW_in_argDeclMany1509);
    		argDeclManyW127=argDeclManyW();
    		PopFollow();

    		stream_argDeclManyW.Add(argDeclManyW127.Tree);


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
    		// 236:28: -> ^( VAR_DECL argDeclManyW )
    		{
    			DebugLocation(236, 31);
    			// Lang2.g:236:31: ^( VAR_DECL argDeclManyW )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(236, 33);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VAR_DECL, "VAR_DECL"), root_1);

    			DebugLocation(236, 42);
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
     	DebugLocation(237, 3);
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
    // Lang2.g:238:1: typeDecl : ( T_INT | T_CHAR | T_BOOL | T_STRING );
    [GrammarRule("typeDecl")]
    private Lang2Parser.typeDecl_return typeDecl()
    {

        Lang2Parser.typeDecl_return retval = new Lang2Parser.typeDecl_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken set128=null;

        object set128_tree=null;

    	try { DebugEnterRule(GrammarFileName, "typeDecl");
    	DebugLocation(238, 39);
    	try
    	{
    		// Lang2.g:238:10: ( T_INT | T_CHAR | T_BOOL | T_STRING )
    		DebugEnterAlt(1);
    		// Lang2.g:
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(238, 10);
    		set128=(IToken)input.LT(1);
    		if ((input.LA(1)>=T_CHAR && input.LA(1)<=T_STRING))
    		{
    			input.Consume();
    			adaptor.AddChild(root_0, (object)adaptor.Create(set128));
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
     	DebugLocation(238, 39);
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
    // Lang2.g:241:1: varTypeDeclW : ( typeDecl | arrayDecl );
    [GrammarRule("varTypeDeclW")]
    private Lang2Parser.varTypeDeclW_return varTypeDeclW()
    {

        Lang2Parser.varTypeDeclW_return retval = new Lang2Parser.varTypeDeclW_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.typeDecl_return typeDecl129 = default(Lang2Parser.typeDecl_return);
        Lang2Parser.arrayDecl_return arrayDecl130 = default(Lang2Parser.arrayDecl_return);


    	try { DebugEnterRule(GrammarFileName, "varTypeDeclW");
    	DebugLocation(241, 4);
    	try
    	{
    		// Lang2.g:241:14: ( typeDecl | arrayDecl )
    		int alt23=2;
    		try { DebugEnterDecision(23, decisionCanBacktrack[23]);
    		int LA23_0 = input.LA(1);

    		if (((LA23_0>=T_CHAR && LA23_0<=T_STRING)))
    		{
    			alt23=1;
    		}
    		else if ((LA23_0==ARRAY))
    		{
    			alt23=2;
    		}
    		else
    		{
    			NoViableAltException nvae = new NoViableAltException("", 23, 0, input);

    			DebugRecognitionException(nvae);
    			throw nvae;
    		}
    		} finally { DebugExitDecision(23); }
    		switch (alt23)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Lang2.g:241:16: typeDecl
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(241, 16);
    			PushFollow(Follow._typeDecl_in_varTypeDeclW1543);
    			typeDecl129=typeDecl();
    			PopFollow();

    			adaptor.AddChild(root_0, typeDecl129.Tree);

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Lang2.g:241:25: arrayDecl
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(241, 25);
    			PushFollow(Follow._arrayDecl_in_varTypeDeclW1545);
    			arrayDecl130=arrayDecl();
    			PopFollow();

    			adaptor.AddChild(root_0, arrayDecl130.Tree);

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
     	DebugLocation(242, 4);
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
    // Lang2.g:244:1: varTypeDecl : varTypeDeclW OP_END -> ^( TYPE_DECL varTypeDeclW ) ;
    [GrammarRule("varTypeDecl")]
    private Lang2Parser.varTypeDecl_return varTypeDecl()
    {

        Lang2Parser.varTypeDecl_return retval = new Lang2Parser.varTypeDecl_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken OP_END132=null;
        Lang2Parser.varTypeDeclW_return varTypeDeclW131 = default(Lang2Parser.varTypeDeclW_return);

        object OP_END132_tree=null;
        RewriteRuleITokenStream stream_OP_END=new RewriteRuleITokenStream(adaptor,"token OP_END");
        RewriteRuleSubtreeStream stream_varTypeDeclW=new RewriteRuleSubtreeStream(adaptor,"rule varTypeDeclW");
    	try { DebugEnterRule(GrammarFileName, "varTypeDecl");
    	DebugLocation(244, 3);
    	try
    	{
    		// Lang2.g:244:13: ( varTypeDeclW OP_END -> ^( TYPE_DECL varTypeDeclW ) )
    		DebugEnterAlt(1);
    		// Lang2.g:244:15: varTypeDeclW OP_END
    		{
    		DebugLocation(244, 15);
    		PushFollow(Follow._varTypeDeclW_in_varTypeDecl1558);
    		varTypeDeclW131=varTypeDeclW();
    		PopFollow();

    		stream_varTypeDeclW.Add(varTypeDeclW131.Tree);
    		DebugLocation(244, 28);
    		OP_END132=(IToken)Match(input,OP_END,Follow._OP_END_in_varTypeDecl1560);  
    		stream_OP_END.Add(OP_END132);



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
    		// 244:35: -> ^( TYPE_DECL varTypeDeclW )
    		{
    			DebugLocation(244, 38);
    			// Lang2.g:244:38: ^( TYPE_DECL varTypeDeclW )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(244, 40);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(TYPE_DECL, "TYPE_DECL"), root_1);

    			DebugLocation(244, 50);
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
     	DebugLocation(245, 3);
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
    // Lang2.g:248:1: varDecl2 : VARIABLE ( ',' VARIABLE )* ;
    [GrammarRule("varDecl2")]
    private Lang2Parser.varDecl2_return varDecl2()
    {

        Lang2Parser.varDecl2_return retval = new Lang2Parser.varDecl2_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken VARIABLE133=null;
        IToken char_literal134=null;
        IToken VARIABLE135=null;

        object VARIABLE133_tree=null;
        object char_literal134_tree=null;
        object VARIABLE135_tree=null;

    	try { DebugEnterRule(GrammarFileName, "varDecl2");
    	DebugLocation(248, 35);
    	try
    	{
    		// Lang2.g:248:10: ( VARIABLE ( ',' VARIABLE )* )
    		DebugEnterAlt(1);
    		// Lang2.g:248:12: VARIABLE ( ',' VARIABLE )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(248, 12);
    		VARIABLE133=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_varDecl21581); 
    		VARIABLE133_tree = (object)adaptor.Create(VARIABLE133);
    		adaptor.AddChild(root_0, VARIABLE133_tree);

    		DebugLocation(248, 20);
    		// Lang2.g:248:20: ( ',' VARIABLE )*
    		try { DebugEnterSubRule(24);
    		while (true)
    		{
    			int alt24=2;
    			try { DebugEnterDecision(24, decisionCanBacktrack[24]);
    			int LA24_0 = input.LA(1);

    			if ((LA24_0==70))
    			{
    				alt24=1;
    			}


    			} finally { DebugExitDecision(24); }
    			switch ( alt24 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:248:21: ',' VARIABLE
    				{
    				DebugLocation(248, 24);
    				char_literal134=(IToken)Match(input,70,Follow._70_in_varDecl21583); 
    				DebugLocation(248, 26);
    				VARIABLE135=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_varDecl21586); 
    				VARIABLE135_tree = (object)adaptor.Create(VARIABLE135);
    				adaptor.AddChild(root_0, VARIABLE135_tree);


    				}
    				break;

    			default:
    				goto loop24;
    			}
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
     	DebugLocation(248, 35);
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
    // Lang2.g:250:1: varDecl : varDecl2 ;
    [GrammarRule("varDecl")]
    private Lang2Parser.varDecl_return varDecl()
    {

        Lang2Parser.varDecl_return retval = new Lang2Parser.varDecl_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.varDecl2_return varDecl2136 = default(Lang2Parser.varDecl2_return);


    	try { DebugEnterRule(GrammarFileName, "varDecl");
    	DebugLocation(250, 2);
    	try
    	{
    		// Lang2.g:250:9: ( varDecl2 )
    		DebugEnterAlt(1);
    		// Lang2.g:250:11: varDecl2
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(250, 11);
    		PushFollow(Follow._varDecl2_in_varDecl1596);
    		varDecl2136=varDecl2();
    		PopFollow();

    		adaptor.AddChild(root_0, varDecl2136.Tree);

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
     	DebugLocation(251, 2);
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
    // Lang2.g:252:1: varDecl12W : varDecl ':' varTypeDecl ;
    [GrammarRule("varDecl12W")]
    private Lang2Parser.varDecl12W_return varDecl12W()
    {

        Lang2Parser.varDecl12W_return retval = new Lang2Parser.varDecl12W_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken char_literal138=null;
        Lang2Parser.varDecl_return varDecl137 = default(Lang2Parser.varDecl_return);
        Lang2Parser.varTypeDecl_return varTypeDecl139 = default(Lang2Parser.varTypeDecl_return);

        object char_literal138_tree=null;

    	try { DebugEnterRule(GrammarFileName, "varDecl12W");
    	DebugLocation(252, 3);
    	try
    	{
    		// Lang2.g:252:12: ( varDecl ':' varTypeDecl )
    		DebugEnterAlt(1);
    		// Lang2.g:252:14: varDecl ':' varTypeDecl
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(252, 14);
    		PushFollow(Follow._varDecl_in_varDecl12W1606);
    		varDecl137=varDecl();
    		PopFollow();

    		adaptor.AddChild(root_0, varDecl137.Tree);
    		DebugLocation(252, 25);
    		char_literal138=(IToken)Match(input,71,Follow._71_in_varDecl12W1608); 
    		DebugLocation(252, 27);
    		PushFollow(Follow._varTypeDecl_in_varDecl12W1611);
    		varTypeDecl139=varTypeDecl();
    		PopFollow();

    		adaptor.AddChild(root_0, varTypeDecl139.Tree);

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
    // Lang2.g:254:1: varDeclW : VAR ( ( varDecl12W )+ ) -> ^( VAR_DECL ( varDecl12W )+ ) ;
    [GrammarRule("varDeclW")]
    private Lang2Parser.varDeclW_return varDeclW()
    {

        Lang2Parser.varDeclW_return retval = new Lang2Parser.varDeclW_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken VAR140=null;
        Lang2Parser.varDecl12W_return varDecl12W141 = default(Lang2Parser.varDecl12W_return);

        object VAR140_tree=null;
        RewriteRuleITokenStream stream_VAR=new RewriteRuleITokenStream(adaptor,"token VAR");
        RewriteRuleSubtreeStream stream_varDecl12W=new RewriteRuleSubtreeStream(adaptor,"rule varDecl12W");
    	try { DebugEnterRule(GrammarFileName, "varDeclW");
    	DebugLocation(254, 3);
    	try
    	{
    		// Lang2.g:254:10: ( VAR ( ( varDecl12W )+ ) -> ^( VAR_DECL ( varDecl12W )+ ) )
    		DebugEnterAlt(1);
    		// Lang2.g:254:12: VAR ( ( varDecl12W )+ )
    		{
    		DebugLocation(254, 12);
    		VAR140=(IToken)Match(input,VAR,Follow._VAR_in_varDeclW1623);  
    		stream_VAR.Add(VAR140);

    		DebugLocation(254, 16);
    		// Lang2.g:254:16: ( ( varDecl12W )+ )
    		DebugEnterAlt(1);
    		// Lang2.g:254:17: ( varDecl12W )+
    		{
    		DebugLocation(254, 17);
    		// Lang2.g:254:17: ( varDecl12W )+
    		int cnt25=0;
    		try { DebugEnterSubRule(25);
    		while (true)
    		{
    			int alt25=2;
    			try { DebugEnterDecision(25, decisionCanBacktrack[25]);
    			int LA25_0 = input.LA(1);

    			if ((LA25_0==VARIABLE))
    			{
    				alt25=1;
    			}


    			} finally { DebugExitDecision(25); }
    			switch (alt25)
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:254:17: varDecl12W
    				{
    				DebugLocation(254, 17);
    				PushFollow(Follow._varDecl12W_in_varDeclW1626);
    				varDecl12W141=varDecl12W();
    				PopFollow();

    				stream_varDecl12W.Add(varDecl12W141.Tree);

    				}
    				break;

    			default:
    				if (cnt25 >= 1)
    					goto loop25;

    				EarlyExitException eee25 = new EarlyExitException( 25, input );
    				DebugRecognitionException(eee25);
    				throw eee25;
    			}
    			cnt25++;
    		}
    		loop25:
    			;

    		} finally { DebugExitSubRule(25); }


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
    		// 254:30: -> ^( VAR_DECL ( varDecl12W )+ )
    		{
    			DebugLocation(254, 33);
    			// Lang2.g:254:33: ^( VAR_DECL ( varDecl12W )+ )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(254, 35);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VAR_DECL, "VAR_DECL"), root_1);

    			DebugLocation(254, 44);
    			if ( !(stream_varDecl12W.HasNext) )
    			{
    				throw new RewriteEarlyExitException();
    			}
    			while ( stream_varDecl12W.HasNext )
    			{
    				DebugLocation(254, 44);
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
     	DebugLocation(255, 3);
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
    // Lang2.g:259:1: bodyExpr : BEGIN ( bodyOper )* END OP_END -> ^( BODY_EXPR ( bodyOper )* ) ;
    [GrammarRule("bodyExpr")]
    private Lang2Parser.bodyExpr_return bodyExpr()
    {

        Lang2Parser.bodyExpr_return retval = new Lang2Parser.bodyExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken BEGIN142=null;
        IToken END144=null;
        IToken OP_END145=null;
        Lang2Parser.bodyOper_return bodyOper143 = default(Lang2Parser.bodyOper_return);

        object BEGIN142_tree=null;
        object END144_tree=null;
        object OP_END145_tree=null;
        RewriteRuleITokenStream stream_OP_END=new RewriteRuleITokenStream(adaptor,"token OP_END");
        RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
        RewriteRuleITokenStream stream_BEGIN=new RewriteRuleITokenStream(adaptor,"token BEGIN");
        RewriteRuleSubtreeStream stream_bodyOper=new RewriteRuleSubtreeStream(adaptor,"rule bodyOper");
    	try { DebugEnterRule(GrammarFileName, "bodyExpr");
    	DebugLocation(259, 3);
    	try
    	{
    		// Lang2.g:259:10: ( BEGIN ( bodyOper )* END OP_END -> ^( BODY_EXPR ( bodyOper )* ) )
    		DebugEnterAlt(1);
    		// Lang2.g:259:12: BEGIN ( bodyOper )* END OP_END
    		{
    		DebugLocation(259, 17);
    		BEGIN142=(IToken)Match(input,BEGIN,Follow._BEGIN_in_bodyExpr1652);  
    		stream_BEGIN.Add(BEGIN142);

    		DebugLocation(259, 19);
    		// Lang2.g:259:19: ( bodyOper )*
    		try { DebugEnterSubRule(26);
    		while (true)
    		{
    			int alt26=2;
    			try { DebugEnterDecision(26, decisionCanBacktrack[26]);
    			int LA26_0 = input.LA(1);

    			if ((LA26_0==WHILE||LA26_0==FOR||LA26_0==IF||LA26_0==VARIABLE))
    			{
    				alt26=1;
    			}


    			} finally { DebugExitDecision(26); }
    			switch ( alt26 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:259:19: bodyOper
    				{
    				DebugLocation(259, 19);
    				PushFollow(Follow._bodyOper_in_bodyExpr1655);
    				bodyOper143=bodyOper();
    				PopFollow();

    				stream_bodyOper.Add(bodyOper143.Tree);

    				}
    				break;

    			default:
    				goto loop26;
    			}
    		}

    		loop26:
    			;

    		} finally { DebugExitSubRule(26); }

    		DebugLocation(259, 32);
    		END144=(IToken)Match(input,END,Follow._END_in_bodyExpr1658);  
    		stream_END.Add(END144);

    		DebugLocation(259, 40);
    		OP_END145=(IToken)Match(input,OP_END,Follow._OP_END_in_bodyExpr1661);  
    		stream_OP_END.Add(OP_END145);



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
    		// 259:42: -> ^( BODY_EXPR ( bodyOper )* )
    		{
    			DebugLocation(259, 45);
    			// Lang2.g:259:45: ^( BODY_EXPR ( bodyOper )* )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(259, 47);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BODY_EXPR, "BODY_EXPR"), root_1);

    			DebugLocation(259, 57);
    			// Lang2.g:259:57: ( bodyOper )*
    			while ( stream_bodyOper.HasNext )
    			{
    				DebugLocation(259, 57);
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
     	DebugLocation(260, 3);
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
    // Lang2.g:261:1: mainBodyExpr : BEGIN ( bodyOper )* END OP_END -> ^( MAIN_BODY ( bodyOper )* ) ;
    [GrammarRule("mainBodyExpr")]
    private Lang2Parser.mainBodyExpr_return mainBodyExpr()
    {

        Lang2Parser.mainBodyExpr_return retval = new Lang2Parser.mainBodyExpr_return();
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
    	try { DebugEnterRule(GrammarFileName, "mainBodyExpr");
    	DebugLocation(261, 4);
    	try
    	{
    		// Lang2.g:261:14: ( BEGIN ( bodyOper )* END OP_END -> ^( MAIN_BODY ( bodyOper )* ) )
    		DebugEnterAlt(1);
    		// Lang2.g:261:16: BEGIN ( bodyOper )* END OP_END
    		{
    		DebugLocation(261, 21);
    		BEGIN146=(IToken)Match(input,BEGIN,Follow._BEGIN_in_mainBodyExpr1682);  
    		stream_BEGIN.Add(BEGIN146);

    		DebugLocation(261, 23);
    		// Lang2.g:261:23: ( bodyOper )*
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
    				// Lang2.g:261:23: bodyOper
    				{
    				DebugLocation(261, 23);
    				PushFollow(Follow._bodyOper_in_mainBodyExpr1685);
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

    		DebugLocation(261, 36);
    		END148=(IToken)Match(input,END,Follow._END_in_mainBodyExpr1688);  
    		stream_END.Add(END148);

    		DebugLocation(261, 38);
    		OP_END149=(IToken)Match(input,OP_END,Follow._OP_END_in_mainBodyExpr1691);  
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
    		// 261:45: -> ^( MAIN_BODY ( bodyOper )* )
    		{
    			DebugLocation(261, 48);
    			// Lang2.g:261:48: ^( MAIN_BODY ( bodyOper )* )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(261, 50);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(MAIN_BODY, "MAIN_BODY"), root_1);

    			DebugLocation(261, 60);
    			// Lang2.g:261:60: ( bodyOper )*
    			while ( stream_bodyOper.HasNext )
    			{
    				DebugLocation(261, 60);
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
     	DebugLocation(262, 4);
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
    // Lang2.g:263:1: func_proc_expr : ( funcDeclare | procedureDeclare );
    [GrammarRule("func_proc_expr")]
    private Lang2Parser.func_proc_expr_return func_proc_expr()
    {

        Lang2Parser.func_proc_expr_return retval = new Lang2Parser.func_proc_expr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.funcDeclare_return funcDeclare150 = default(Lang2Parser.funcDeclare_return);
        Lang2Parser.procedureDeclare_return procedureDeclare151 = default(Lang2Parser.procedureDeclare_return);


    	try { DebugEnterRule(GrammarFileName, "func_proc_expr");
    	DebugLocation(263, 46);
    	try
    	{
    		// Lang2.g:263:16: ( funcDeclare | procedureDeclare )
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
    			// Lang2.g:263:18: funcDeclare
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(263, 18);
    			PushFollow(Follow._funcDeclare_in_func_proc_expr1712);
    			funcDeclare150=funcDeclare();
    			PopFollow();

    			adaptor.AddChild(root_0, funcDeclare150.Tree);

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Lang2.g:263:30: procedureDeclare
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(263, 30);
    			PushFollow(Follow._procedureDeclare_in_func_proc_expr1714);
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
     	DebugLocation(263, 46);
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
    // Lang2.g:265:1: fpExprW : ( func_proc_expr )* -> ^( FUNC_PROC_EXPR ( func_proc_expr )* ) ;
    [GrammarRule("fpExprW")]
    private Lang2Parser.fpExprW_return fpExprW()
    {

        Lang2Parser.fpExprW_return retval = new Lang2Parser.fpExprW_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.func_proc_expr_return func_proc_expr152 = default(Lang2Parser.func_proc_expr_return);

        RewriteRuleSubtreeStream stream_func_proc_expr=new RewriteRuleSubtreeStream(adaptor,"rule func_proc_expr");
    	try { DebugEnterRule(GrammarFileName, "fpExprW");
    	DebugLocation(265, 62);
    	try
    	{
    		// Lang2.g:265:9: ( ( func_proc_expr )* -> ^( FUNC_PROC_EXPR ( func_proc_expr )* ) )
    		DebugEnterAlt(1);
    		// Lang2.g:265:11: ( func_proc_expr )*
    		{
    		DebugLocation(265, 11);
    		// Lang2.g:265:11: ( func_proc_expr )*
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
    				// Lang2.g:265:11: func_proc_expr
    				{
    				DebugLocation(265, 11);
    				PushFollow(Follow._func_proc_expr_in_fpExprW1723);
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
    		// 265:27: -> ^( FUNC_PROC_EXPR ( func_proc_expr )* )
    		{
    			DebugLocation(265, 30);
    			// Lang2.g:265:30: ^( FUNC_PROC_EXPR ( func_proc_expr )* )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(265, 32);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_PROC_EXPR, "FUNC_PROC_EXPR"), root_1);

    			DebugLocation(265, 47);
    			// Lang2.g:265:47: ( func_proc_expr )*
    			while ( stream_func_proc_expr.HasNext )
    			{
    				DebugLocation(265, 47);
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
     	DebugLocation(265, 62);
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
    // Lang2.g:267:1: wrapToBody : ( varDeclW )? fpExprW mainBodyExpr -> ^( BODY_EXPR ( varDeclW )? fpExprW mainBodyExpr ) ;
    [GrammarRule("wrapToBody")]
    private Lang2Parser.wrapToBody_return wrapToBody()
    {

        Lang2Parser.wrapToBody_return retval = new Lang2Parser.wrapToBody_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.varDeclW_return varDeclW153 = default(Lang2Parser.varDeclW_return);
        Lang2Parser.fpExprW_return fpExprW154 = default(Lang2Parser.fpExprW_return);
        Lang2Parser.mainBodyExpr_return mainBodyExpr155 = default(Lang2Parser.mainBodyExpr_return);

        RewriteRuleSubtreeStream stream_varDeclW=new RewriteRuleSubtreeStream(adaptor,"rule varDeclW");
        RewriteRuleSubtreeStream stream_mainBodyExpr=new RewriteRuleSubtreeStream(adaptor,"rule mainBodyExpr");
        RewriteRuleSubtreeStream stream_fpExprW=new RewriteRuleSubtreeStream(adaptor,"rule fpExprW");
    	try { DebugEnterRule(GrammarFileName, "wrapToBody");
    	DebugLocation(267, 3);
    	try
    	{
    		// Lang2.g:267:12: ( ( varDeclW )? fpExprW mainBodyExpr -> ^( BODY_EXPR ( varDeclW )? fpExprW mainBodyExpr ) )
    		DebugEnterAlt(1);
    		// Lang2.g:267:14: ( varDeclW )? fpExprW mainBodyExpr
    		{
    		DebugLocation(267, 14);
    		// Lang2.g:267:14: ( varDeclW )?
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
    			// Lang2.g:267:14: varDeclW
    			{
    			DebugLocation(267, 14);
    			PushFollow(Follow._varDeclW_in_wrapToBody1741);
    			varDeclW153=varDeclW();
    			PopFollow();

    			stream_varDeclW.Add(varDeclW153.Tree);

    			}
    			break;

    		}
    		} finally { DebugExitSubRule(30); }

    		DebugLocation(267, 24);
    		PushFollow(Follow._fpExprW_in_wrapToBody1744);
    		fpExprW154=fpExprW();
    		PopFollow();

    		stream_fpExprW.Add(fpExprW154.Tree);
    		DebugLocation(267, 32);
    		PushFollow(Follow._mainBodyExpr_in_wrapToBody1746);
    		mainBodyExpr155=mainBodyExpr();
    		PopFollow();

    		stream_mainBodyExpr.Add(mainBodyExpr155.Tree);


    		{
    		// AST REWRITE
    		// elements: mainBodyExpr, varDeclW, fpExprW
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 267:45: -> ^( BODY_EXPR ( varDeclW )? fpExprW mainBodyExpr )
    		{
    			DebugLocation(267, 48);
    			// Lang2.g:267:48: ^( BODY_EXPR ( varDeclW )? fpExprW mainBodyExpr )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(267, 50);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BODY_EXPR, "BODY_EXPR"), root_1);

    			DebugLocation(267, 60);
    			// Lang2.g:267:60: ( varDeclW )?
    			if ( stream_varDeclW.HasNext )
    			{
    				DebugLocation(267, 60);
    				adaptor.AddChild(root_1, stream_varDeclW.NextTree());

    			}
    			stream_varDeclW.Reset();
    			DebugLocation(267, 70);
    			adaptor.AddChild(root_1, stream_fpExprW.NextTree());
    			DebugLocation(267, 78);
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
     	DebugLocation(268, 3);
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
    // Lang2.g:270:1: expr : PROGRAM VARIABLE OP_END wrapToBody -> ^( PROGRAM VARIABLE wrapToBody ) ;
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
    	DebugLocation(270, 1);
    	try
    	{
    		// Lang2.g:270:6: ( PROGRAM VARIABLE OP_END wrapToBody -> ^( PROGRAM VARIABLE wrapToBody ) )
    		DebugEnterAlt(1);
    		// Lang2.g:270:9: PROGRAM VARIABLE OP_END wrapToBody
    		{
    		DebugLocation(270, 9);
    		PROGRAM156=(IToken)Match(input,PROGRAM,Follow._PROGRAM_in_expr1772);  
    		stream_PROGRAM.Add(PROGRAM156);

    		DebugLocation(270, 17);
    		VARIABLE157=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_expr1774);  
    		stream_VARIABLE.Add(VARIABLE157);

    		DebugLocation(270, 32);
    		OP_END158=(IToken)Match(input,OP_END,Follow._OP_END_in_expr1776);  
    		stream_OP_END.Add(OP_END158);

    		DebugLocation(270, 34);
    		PushFollow(Follow._wrapToBody_in_expr1779);
    		wrapToBody159=wrapToBody();
    		PopFollow();

    		stream_wrapToBody.Add(wrapToBody159.Tree);


    		{
    		// AST REWRITE
    		// elements: wrapToBody, VARIABLE, PROGRAM
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 270:45: -> ^( PROGRAM VARIABLE wrapToBody )
    		{
    			DebugLocation(270, 48);
    			// Lang2.g:270:48: ^( PROGRAM VARIABLE wrapToBody )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(270, 50);
    			root_1 = (object)adaptor.BecomeRoot(stream_PROGRAM.NextNode(), root_1);

    			DebugLocation(270, 58);
    			adaptor.AddChild(root_1, stream_VARIABLE.NextNode());
    			DebugLocation(270, 67);
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
     	DebugLocation(271, 1);
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
    // Lang2.g:273:1: program : ( expr )+ ;
    [GrammarRule("program")]
    private Lang2Parser.program_return program()
    {

        Lang2Parser.program_return retval = new Lang2Parser.program_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.expr_return expr160 = default(Lang2Parser.expr_return);


    	try { DebugEnterRule(GrammarFileName, "program");
    	DebugLocation(273, 16);
    	try
    	{
    		// Lang2.g:273:8: ( ( expr )+ )
    		DebugEnterAlt(1);
    		// Lang2.g:273:10: ( expr )+
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(273, 10);
    		// Lang2.g:273:10: ( expr )+
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
    				// Lang2.g:273:10: expr
    				{
    				DebugLocation(273, 10);
    				PushFollow(Follow._expr_in_program1799);
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
     	DebugLocation(273, 16);
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
    // Lang2.g:274:1: result : program EOF -> ^( PROGRAM program ) ;
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
    	DebugLocation(274, 41);
    	try
    	{
    		// Lang2.g:274:7: ( program EOF -> ^( PROGRAM program ) )
    		DebugEnterAlt(1);
    		// Lang2.g:274:9: program EOF
    		{
    		DebugLocation(274, 9);
    		PushFollow(Follow._program_in_result1808);
    		program161=program();
    		PopFollow();

    		stream_program.Add(program161.Tree);
    		DebugLocation(274, 17);
    		EOF162=(IToken)Match(input,EOF,Follow._EOF_in_result1810);  
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
    		// 274:21: -> ^( PROGRAM program )
    		{
    			DebugLocation(274, 24);
    			// Lang2.g:274:24: ^( PROGRAM program )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(274, 26);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PROGRAM, "PROGRAM"), root_1);

    			DebugLocation(274, 34);
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
     	DebugLocation(274, 41);
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
    // Lang2.g:275:8: public execute : result ;
    [GrammarRule("execute")]
    public Lang2Parser.execute_return execute()
    {

        Lang2Parser.execute_return retval = new Lang2Parser.execute_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.result_return result163 = default(Lang2Parser.result_return);


    	try { DebugEnterRule(GrammarFileName, "execute");
    	DebugLocation(275, 23);
    	try
    	{
    		// Lang2.g:275:15: ( result )
    		DebugEnterAlt(1);
    		// Lang2.g:275:18: result
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(275, 18);
    		PushFollow(Follow._result_in_execute1827);
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
     	DebugLocation(275, 23);
    	} finally { DebugExitRule(GrammarFileName, "execute"); }
    	return retval;

    }
    // $ANTLR end "execute"

	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _65_in_arrayRange491 = new BitSet(new ulong[]{0x002000000F000000UL,0x0000000000000010UL});
		public static readonly BitSet _expressions_in_arrayRange492 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
		public static readonly BitSet _66_in_arrayRange494 = new BitSet(new ulong[]{0x002000000F000000UL,0x0000000000000010UL});
		public static readonly BitSet _expressions_in_arrayRange496 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000008UL});
		public static readonly BitSet _67_in_arrayRange497 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _OF_in_arrayTypeDecl518 = new BitSet(new ulong[]{0x0000000000780000UL});
		public static readonly BitSet _typeDecl_in_arrayTypeDecl520 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _ARRAY_in_arrayDecl541 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000002UL});
		public static readonly BitSet _arrayRange_in_arrayDecl543 = new BitSet(new ulong[]{0x0000200000000000UL});
		public static readonly BitSet _arrayTypeDecl_in_arrayDecl545 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VARIABLE_in_arrayCall568 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000002UL});
		public static readonly BitSet _65_in_arrayCall570 = new BitSet(new ulong[]{0x002000000F000000UL,0x0000000000000010UL});
		public static readonly BitSet _expressions_in_arrayCall571 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000008UL});
		public static readonly BitSet _67_in_arrayCall572 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _set_in_boolOperator0 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _68_in_mathGroup724 = new BitSet(new ulong[]{0x002000000F000000UL,0x0000000000000010UL});
		public static readonly BitSet _expressions_in_mathGroup726 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
		public static readonly BitSet _69_in_mathGroup727 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _INT_in_mathGroup734 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _CHAR_in_mathGroup740 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _BOOLEAN_in_mathGroup746 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _STRING_in_mathGroup753 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VARIABLE_in_mathGroup759 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _funcCall_in_mathGroup765 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _mathGroup_in_boolMult777 = new BitSet(new ulong[]{0x0000020000000002UL});
		public static readonly BitSet _BOOL_MULT_in_boolMult779 = new BitSet(new ulong[]{0x002000000F000000UL,0x0000000000000010UL});
		public static readonly BitSet _mathGroup_in_boolMult782 = new BitSet(new ulong[]{0x0000020000000002UL});
		public static readonly BitSet _boolMult_in_boolAdd796 = new BitSet(new ulong[]{0x0000040000000002UL});
		public static readonly BitSet _BOOL_ADD_in_boolAdd798 = new BitSet(new ulong[]{0x002000000F000000UL,0x0000000000000010UL});
		public static readonly BitSet _boolMult_in_boolAdd801 = new BitSet(new ulong[]{0x0000040000000002UL});
		public static readonly BitSet _boolAdd_in_boolElse814 = new BitSet(new ulong[]{0xF800000000000002UL,0x0000000000000001UL});
		public static readonly BitSet _boolOperator_in_boolElse816 = new BitSet(new ulong[]{0x002000000F000000UL,0x0000000000000010UL});
		public static readonly BitSet _boolAdd_in_boolElse819 = new BitSet(new ulong[]{0xF800000000000002UL,0x0000000000000001UL});
		public static readonly BitSet _boolElse_in_boolNegative833 = new BitSet(new ulong[]{0x0000000000010002UL});
		public static readonly BitSet _NOT_in_boolNegative836 = new BitSet(new ulong[]{0x002000000F000000UL,0x0000000000000010UL});
		public static readonly BitSet _boolElse_in_boolNegative839 = new BitSet(new ulong[]{0x0000000000010002UL});
		public static readonly BitSet _boolNegative_in_useDiv853 = new BitSet(new ulong[]{0x000000000000C002UL});
		public static readonly BitSet _set_in_useDiv855 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000010UL});
		public static readonly BitSet _68_in_useDiv862 = new BitSet(new ulong[]{0x002000000F000000UL,0x0000000000000010UL});
		public static readonly BitSet _boolNegative_in_useDiv865 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
		public static readonly BitSet _69_in_useDiv867 = new BitSet(new ulong[]{0x000000000000C002UL});
		public static readonly BitSet _useDiv_in_mathMult884 = new BitSet(new ulong[]{0x0300000000000002UL});
		public static readonly BitSet _set_in_mathMult886 = new BitSet(new ulong[]{0x002000000F000000UL,0x0000000000000010UL});
		public static readonly BitSet _useDiv_in_mathMult892 = new BitSet(new ulong[]{0x0300000000000002UL});
		public static readonly BitSet _mathMult_in_mathAdd905 = new BitSet(new ulong[]{0x00C0000000000002UL});
		public static readonly BitSet _set_in_mathAdd907 = new BitSet(new ulong[]{0x002000000F000000UL,0x0000000000000010UL});
		public static readonly BitSet _mathMult_in_mathAdd913 = new BitSet(new ulong[]{0x00C0000000000002UL});
		public static readonly BitSet _mathAdd_in_mathExpr927 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _assExpr_in_bodyOper942 = new BitSet(new ulong[]{0x0008000000000000UL});
		public static readonly BitSet _OP_END_in_bodyOper944 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _conditionExpr_in_bodyOper952 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _loopExpr_in_bodyOper959 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _funcCall_in_bodyOper966 = new BitSet(new ulong[]{0x0008000000000000UL});
		public static readonly BitSet _OP_END_in_bodyOper968 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _mathExpr_in_expressions982 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _arrayCall_in_expressions989 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _mathExpr_in_funcCallArgs1003 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000040UL});
		public static readonly BitSet _70_in_funcCallArgs1005 = new BitSet(new ulong[]{0x002000000F000000UL,0x0000000000000010UL});
		public static readonly BitSet _mathExpr_in_funcCallArgs1008 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000040UL});
		public static readonly BitSet _mathExpr_in_funcCallArgsW1023 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000040UL});
		public static readonly BitSet _70_in_funcCallArgsW1025 = new BitSet(new ulong[]{0x002000000F000000UL,0x0000000000000010UL});
		public static readonly BitSet _mathExpr_in_funcCallArgsW1027 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000040UL});
		public static readonly BitSet _VARIABLE_in_funcCall1053 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000010UL});
		public static readonly BitSet _68_in_funcCall1054 = new BitSet(new ulong[]{0x002000000F000000UL,0x0000000000000030UL});
		public static readonly BitSet _funcCallArgsW_in_funcCall1056 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
		public static readonly BitSet _69_in_funcCall1059 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _68_in_argDeclExpr1083 = new BitSet(new ulong[]{0x0020000000040000UL,0x0000000000000020UL});
		public static readonly BitSet _argDeclMany_in_argDeclExpr1086 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
		public static readonly BitSet _69_in_argDeclExpr1089 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _set_in_retTypeExpr1111 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _retTypeExpr_in_retTypeExprWrap1131 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _varDeclW_in_bodyFuncProcExpr1152 = new BitSet(new ulong[]{0x0000000000000400UL});
		public static readonly BitSet _bodyExpr_in_bodyFuncProcExpr1155 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _FUNCTION_in_funcDeclare1168 = new BitSet(new ulong[]{0x0020000000000000UL});
		public static readonly BitSet _VARIABLE_in_funcDeclare1170 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000010UL});
		public static readonly BitSet _argDeclExpr_in_funcDeclare1172 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
		public static readonly BitSet _71_in_funcDeclare1173 = new BitSet(new ulong[]{0x0000000000780000UL});
		public static readonly BitSet _retTypeExprWrap_in_funcDeclare1175 = new BitSet(new ulong[]{0x0008000000000000UL});
		public static readonly BitSet _OP_END_in_funcDeclare1177 = new BitSet(new ulong[]{0x0000000000040400UL});
		public static readonly BitSet _bodyFuncProcExpr_in_funcDeclare1181 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _PROCEDURE_in_procedureDeclare1206 = new BitSet(new ulong[]{0x0020000000000000UL});
		public static readonly BitSet _VARIABLE_in_procedureDeclare1208 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000010UL});
		public static readonly BitSet _argDeclExpr_in_procedureDeclare1210 = new BitSet(new ulong[]{0x0008000000000000UL});
		public static readonly BitSet _OP_END_in_procedureDeclare1212 = new BitSet(new ulong[]{0x0000000000040400UL});
		public static readonly BitSet _bodyFuncProcExpr_in_procedureDeclare1214 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _ELSE_in_conditionElseExpr1241 = new BitSet(new ulong[]{0x0000000000000400UL});
		public static readonly BitSet _bodyExpr_in_conditionElseExpr1244 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _expressions_in_condExpr1266 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _IF_in_conditionExpr1285 = new BitSet(new ulong[]{0x002000000F000000UL,0x0000000000000010UL});
		public static readonly BitSet _condExpr_in_conditionExpr1287 = new BitSet(new ulong[]{0x0000000000001000UL});
		public static readonly BitSet _THEN_in_conditionExpr1289 = new BitSet(new ulong[]{0x0000000000000400UL});
		public static readonly BitSet _bodyExpr_in_conditionExpr1292 = new BitSet(new ulong[]{0x0000000000002002UL});
		public static readonly BitSet _conditionElseExpr_in_conditionExpr1294 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _assExpr_in_forExpr1320 = new BitSet(new ulong[]{0x0000000000020000UL});
		public static readonly BitSet _TO_in_forExpr1322 = new BitSet(new ulong[]{0x002000000F000000UL,0x0000000000000010UL});
		public static readonly BitSet _expressions_in_forExpr1325 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _WHILE_in_loopExpr1334 = new BitSet(new ulong[]{0x002000000F000000UL,0x0000000000000010UL});
		public static readonly BitSet _condExpr_in_loopExpr1336 = new BitSet(new ulong[]{0x0000000000000040UL});
		public static readonly BitSet _DO_in_loopExpr1338 = new BitSet(new ulong[]{0x0000000000000400UL});
		public static readonly BitSet _bodyExpr_in_loopExpr1341 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _FOR_in_loopExpr1357 = new BitSet(new ulong[]{0x002000000F000000UL,0x0000000000000010UL});
		public static readonly BitSet _forExpr_in_loopExpr1359 = new BitSet(new ulong[]{0x0000000000000040UL});
		public static readonly BitSet _DO_in_loopExpr1361 = new BitSet(new ulong[]{0x0000000000000400UL});
		public static readonly BitSet _bodyExpr_in_loopExpr1363 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VARIABLE_in_assExpr1386 = new BitSet(new ulong[]{0x0400000000000000UL});
		public static readonly BitSet _ASSIGN_in_assExpr1388 = new BitSet(new ulong[]{0x002000000F000000UL,0x0000000000000010UL});
		public static readonly BitSet _expressions_in_assExpr1391 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _arrayCall_in_assExpr1397 = new BitSet(new ulong[]{0x0400000000000000UL});
		public static readonly BitSet _ASSIGN_in_assExpr1399 = new BitSet(new ulong[]{0x002000000F000000UL,0x0000000000000010UL});
		public static readonly BitSet _expressions_in_assExpr1402 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _varTypeDeclW_in_argTypeDecl1412 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VARIABLE_in_partArgDecl1431 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000040UL});
		public static readonly BitSet _70_in_partArgDecl1433 = new BitSet(new ulong[]{0x0020000000000000UL});
		public static readonly BitSet _VARIABLE_in_partArgDecl1436 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000040UL});
		public static readonly BitSet _VARIABLE_in_argDecl1446 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000000000C0UL});
		public static readonly BitSet _70_in_argDecl1448 = new BitSet(new ulong[]{0x0020000000000000UL});
		public static readonly BitSet _VARIABLE_in_argDecl1451 = new BitSet(new ulong[]{0x0000000000000000UL,0x00000000000000C0UL});
		public static readonly BitSet _71_in_argDecl1455 = new BitSet(new ulong[]{0x0000100000780000UL});
		public static readonly BitSet _argTypeDecl_in_argDecl1458 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VAR_in_argDecl1464 = new BitSet(new ulong[]{0x0020000000000000UL});
		public static readonly BitSet _partArgDecl_in_argDecl1466 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
		public static readonly BitSet _71_in_argDecl1467 = new BitSet(new ulong[]{0x0000100000780000UL});
		public static readonly BitSet _argTypeDecl_in_argDecl1470 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _argDecl_in_argDeclManyW1491 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000040UL});
		public static readonly BitSet _70_in_argDeclManyW1493 = new BitSet(new ulong[]{0x0020000000040000UL});
		public static readonly BitSet _argDecl_in_argDeclManyW1496 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000040UL});
		public static readonly BitSet _argDeclManyW_in_argDeclMany1509 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _set_in_typeDecl0 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _typeDecl_in_varTypeDeclW1543 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _arrayDecl_in_varTypeDeclW1545 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _varTypeDeclW_in_varTypeDecl1558 = new BitSet(new ulong[]{0x0008000000000000UL});
		public static readonly BitSet _OP_END_in_varTypeDecl1560 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VARIABLE_in_varDecl21581 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000040UL});
		public static readonly BitSet _70_in_varDecl21583 = new BitSet(new ulong[]{0x0020000000000000UL});
		public static readonly BitSet _VARIABLE_in_varDecl21586 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000040UL});
		public static readonly BitSet _varDecl2_in_varDecl1596 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _varDecl_in_varDecl12W1606 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
		public static readonly BitSet _71_in_varDecl12W1608 = new BitSet(new ulong[]{0x0000100000780000UL});
		public static readonly BitSet _varTypeDecl_in_varDecl12W1611 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VAR_in_varDeclW1623 = new BitSet(new ulong[]{0x0020000000000000UL});
		public static readonly BitSet _varDecl12W_in_varDeclW1626 = new BitSet(new ulong[]{0x0020000000000002UL});
		public static readonly BitSet _BEGIN_in_bodyExpr1652 = new BitSet(new ulong[]{0x002000000F8008A0UL,0x0000000000000010UL});
		public static readonly BitSet _bodyOper_in_bodyExpr1655 = new BitSet(new ulong[]{0x002000000F8008A0UL,0x0000000000000010UL});
		public static readonly BitSet _END_in_bodyExpr1658 = new BitSet(new ulong[]{0x0008000000000000UL});
		public static readonly BitSet _OP_END_in_bodyExpr1661 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _BEGIN_in_mainBodyExpr1682 = new BitSet(new ulong[]{0x002000000F8008A0UL,0x0000000000000010UL});
		public static readonly BitSet _bodyOper_in_mainBodyExpr1685 = new BitSet(new ulong[]{0x002000000F8008A0UL,0x0000000000000010UL});
		public static readonly BitSet _END_in_mainBodyExpr1688 = new BitSet(new ulong[]{0x0008000000000000UL});
		public static readonly BitSet _OP_END_in_mainBodyExpr1691 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _funcDeclare_in_func_proc_expr1712 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _procedureDeclare_in_func_proc_expr1714 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _func_proc_expr_in_fpExprW1723 = new BitSet(new ulong[]{0x0000000000000302UL});
		public static readonly BitSet _varDeclW_in_wrapToBody1741 = new BitSet(new ulong[]{0x0000000000000300UL});
		public static readonly BitSet _fpExprW_in_wrapToBody1744 = new BitSet(new ulong[]{0x0000000000000400UL});
		public static readonly BitSet _mainBodyExpr_in_wrapToBody1746 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _PROGRAM_in_expr1772 = new BitSet(new ulong[]{0x0020000000000000UL});
		public static readonly BitSet _VARIABLE_in_expr1774 = new BitSet(new ulong[]{0x0008000000000000UL});
		public static readonly BitSet _OP_END_in_expr1776 = new BitSet(new ulong[]{0x0000000000040300UL});
		public static readonly BitSet _wrapToBody_in_expr1779 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _expr_in_program1799 = new BitSet(new ulong[]{0x0000000000000012UL});
		public static readonly BitSet _program_in_result1808 = new BitSet(new ulong[]{0x0000000000000000UL});
		public static readonly BitSet _EOF_in_result1810 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _result_in_execute1827 = new BitSet(new ulong[]{0x0000000000000002UL});

	}
	#endregion Follow sets
}
}