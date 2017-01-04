// $ANTLR 3.3 Nov 30, 2010 12:50:56 Lang2.g 2017-01-04 19:22:02

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
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "PROGRAM", "WHILE", "DO", "FOR", "FUNCTION", "PROCEDURE", "BEGIN", "END", "THEN", "ELSE", "DIV", "MOD", "NOT", "TO", "VAR", "T_CHAR", "T_BOOL", "T_INT", "T_STRING", "IF", "BOOLEAN", "CHAR", "INT", "STRING", "FALSE", "TRUE", "VAR_DECL", "BODY_EXPR", "VAR_EXPR", "FUNC_PROC_EXPR", "PROC_DECL", "FUNC_DECL", "FUNC_CALL", "FUNC_CALL_ARGS", "FUNC_PROC_ARGS", "FUNC_PROC_RET_TYPE", "TYPE_DECL", "BOOL_MULT", "BOOL_ADD", "CONDITION", "ARRAY", "OF", "ARR_DECL", "RANGE", "ARR_CALL", "MAIN_BODY", "OP_END", "WS", "VARIABLE", "ADD", "REM", "MULT", "DIVIDE", "ASSIGN", "GREATER", "LESS", "EQUAL", "LESS_OR_EQUAL", "GREATER_OR_EQUAL", "MORE", "'['", "'..'", "']'", "'('", "')'", "','", "':'"
	};
	public const int EOF=-1;
	public const int T__64=64;
	public const int T__65=65;
	public const int T__66=66;
	public const int T__67=67;
	public const int T__68=68;
	public const int T__69=69;
	public const int T__70=70;
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
	public const int OP_END=50;
	public const int WS=51;
	public const int VARIABLE=52;
	public const int ADD=53;
	public const int REM=54;
	public const int MULT=55;
	public const int DIVIDE=56;
	public const int ASSIGN=57;
	public const int GREATER=58;
	public const int LESS=59;
	public const int EQUAL=60;
	public const int LESS_OR_EQUAL=61;
	public const int GREATER_OR_EQUAL=62;
	public const int MORE=63;

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
    // Lang2.g:90:1: arrayRange : '[' expressions '..' expressions ']' -> ^( RANGE expressions expressions ) ;
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
        RewriteRuleITokenStream stream_66=new RewriteRuleITokenStream(adaptor,"token 66");
        RewriteRuleITokenStream stream_64=new RewriteRuleITokenStream(adaptor,"token 64");
        RewriteRuleITokenStream stream_65=new RewriteRuleITokenStream(adaptor,"token 65");
        RewriteRuleSubtreeStream stream_expressions=new RewriteRuleSubtreeStream(adaptor,"rule expressions");
    	try { DebugEnterRule(GrammarFileName, "arrayRange");
    	DebugLocation(90, 3);
    	try
    	{
    		// Lang2.g:90:12: ( '[' expressions '..' expressions ']' -> ^( RANGE expressions expressions ) )
    		DebugEnterAlt(1);
    		// Lang2.g:90:14: '[' expressions '..' expressions ']'
    		{
    		DebugLocation(90, 14);
    		char_literal1=(IToken)Match(input,64,Follow._64_in_arrayRange483);  
    		stream_64.Add(char_literal1);

    		DebugLocation(90, 17);
    		PushFollow(Follow._expressions_in_arrayRange484);
    		expressions2=expressions();
    		PopFollow();

    		stream_expressions.Add(expressions2.Tree);
    		DebugLocation(90, 29);
    		string_literal3=(IToken)Match(input,65,Follow._65_in_arrayRange486);  
    		stream_65.Add(string_literal3);

    		DebugLocation(90, 34);
    		PushFollow(Follow._expressions_in_arrayRange488);
    		expressions4=expressions();
    		PopFollow();

    		stream_expressions.Add(expressions4.Tree);
    		DebugLocation(90, 45);
    		char_literal5=(IToken)Match(input,66,Follow._66_in_arrayRange489);  
    		stream_66.Add(char_literal5);



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
    		// 90:49: -> ^( RANGE expressions expressions )
    		{
    			DebugLocation(90, 52);
    			// Lang2.g:90:52: ^( RANGE expressions expressions )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(90, 54);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(RANGE, "RANGE"), root_1);

    			DebugLocation(90, 60);
    			adaptor.AddChild(root_1, stream_expressions.NextTree());
    			DebugLocation(90, 72);
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
     	DebugLocation(91, 3);
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
    // Lang2.g:92:1: arrayTypeDecl : OF typeDecl -> ^( TYPE_DECL typeDecl ) ;
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
    	DebugLocation(92, 4);
    	try
    	{
    		// Lang2.g:92:15: ( OF typeDecl -> ^( TYPE_DECL typeDecl ) )
    		DebugEnterAlt(1);
    		// Lang2.g:92:17: OF typeDecl
    		{
    		DebugLocation(92, 17);
    		OF6=(IToken)Match(input,OF,Follow._OF_in_arrayTypeDecl510);  
    		stream_OF.Add(OF6);

    		DebugLocation(92, 20);
    		PushFollow(Follow._typeDecl_in_arrayTypeDecl512);
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
    		// 92:29: -> ^( TYPE_DECL typeDecl )
    		{
    			DebugLocation(92, 32);
    			// Lang2.g:92:32: ^( TYPE_DECL typeDecl )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(92, 34);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(TYPE_DECL, "TYPE_DECL"), root_1);

    			DebugLocation(92, 44);
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
     	DebugLocation(93, 4);
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
    // Lang2.g:94:1: arrayDecl : ARRAY arrayRange arrayTypeDecl -> ^( ARR_DECL arrayRange arrayTypeDecl ) ;
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
    	DebugLocation(94, 3);
    	try
    	{
    		// Lang2.g:94:11: ( ARRAY arrayRange arrayTypeDecl -> ^( ARR_DECL arrayRange arrayTypeDecl ) )
    		DebugEnterAlt(1);
    		// Lang2.g:94:14: ARRAY arrayRange arrayTypeDecl
    		{
    		DebugLocation(94, 14);
    		ARRAY8=(IToken)Match(input,ARRAY,Follow._ARRAY_in_arrayDecl533);  
    		stream_ARRAY.Add(ARRAY8);

    		DebugLocation(94, 20);
    		PushFollow(Follow._arrayRange_in_arrayDecl535);
    		arrayRange9=arrayRange();
    		PopFollow();

    		stream_arrayRange.Add(arrayRange9.Tree);
    		DebugLocation(94, 31);
    		PushFollow(Follow._arrayTypeDecl_in_arrayDecl537);
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
    		// 94:45: -> ^( ARR_DECL arrayRange arrayTypeDecl )
    		{
    			DebugLocation(94, 48);
    			// Lang2.g:94:48: ^( ARR_DECL arrayRange arrayTypeDecl )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(94, 50);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARR_DECL, "ARR_DECL"), root_1);

    			DebugLocation(94, 59);
    			adaptor.AddChild(root_1, stream_arrayRange.NextTree());
    			DebugLocation(94, 70);
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
     	DebugLocation(95, 3);
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
    // Lang2.g:97:1: arrayCall : VARIABLE '[' expressions ']' -> ^( ARR_CALL VARIABLE expressions ) ;
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
        RewriteRuleITokenStream stream_66=new RewriteRuleITokenStream(adaptor,"token 66");
        RewriteRuleITokenStream stream_VARIABLE=new RewriteRuleITokenStream(adaptor,"token VARIABLE");
        RewriteRuleITokenStream stream_64=new RewriteRuleITokenStream(adaptor,"token 64");
        RewriteRuleSubtreeStream stream_expressions=new RewriteRuleSubtreeStream(adaptor,"rule expressions");
    	try { DebugEnterRule(GrammarFileName, "arrayCall");
    	DebugLocation(97, 3);
    	try
    	{
    		// Lang2.g:97:11: ( VARIABLE '[' expressions ']' -> ^( ARR_CALL VARIABLE expressions ) )
    		DebugEnterAlt(1);
    		// Lang2.g:97:13: VARIABLE '[' expressions ']'
    		{
    		DebugLocation(97, 13);
    		VARIABLE11=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_arrayCall560);  
    		stream_VARIABLE.Add(VARIABLE11);

    		DebugLocation(97, 22);
    		char_literal12=(IToken)Match(input,64,Follow._64_in_arrayCall562);  
    		stream_64.Add(char_literal12);

    		DebugLocation(97, 25);
    		PushFollow(Follow._expressions_in_arrayCall563);
    		expressions13=expressions();
    		PopFollow();

    		stream_expressions.Add(expressions13.Tree);
    		DebugLocation(97, 36);
    		char_literal14=(IToken)Match(input,66,Follow._66_in_arrayCall564);  
    		stream_66.Add(char_literal14);



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
    		// 97:40: -> ^( ARR_CALL VARIABLE expressions )
    		{
    			DebugLocation(97, 43);
    			// Lang2.g:97:43: ^( ARR_CALL VARIABLE expressions )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(97, 45);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ARR_CALL, "ARR_CALL"), root_1);

    			DebugLocation(97, 54);
    			adaptor.AddChild(root_1, stream_VARIABLE.NextNode());
    			DebugLocation(97, 63);
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
     	DebugLocation(98, 3);
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
    // Lang2.g:125:1: boolOperator : ( MORE | LESS | EQUAL | LESS_OR_EQUAL | GREATER_OR_EQUAL | GREATER );
    [GrammarRule("boolOperator")]
    private Lang2Parser.boolOperator_return boolOperator()
    {

        Lang2Parser.boolOperator_return retval = new Lang2Parser.boolOperator_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken set15=null;

        object set15_tree=null;

    	try { DebugEnterRule(GrammarFileName, "boolOperator");
    	DebugLocation(125, 3);
    	try
    	{
    		// Lang2.g:125:13: ( MORE | LESS | EQUAL | LESS_OR_EQUAL | GREATER_OR_EQUAL | GREATER )
    		DebugEnterAlt(1);
    		// Lang2.g:
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(125, 13);
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
     	DebugLocation(126, 3);
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
    // Lang2.g:129:1: mathGroup : ( '(' expressions ')' | INT | CHAR | BOOLEAN | STRING | VARIABLE | funcCall );
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
    	DebugLocation(129, 2);
    	try
    	{
    		// Lang2.g:129:11: ( '(' expressions ')' | INT | CHAR | BOOLEAN | STRING | VARIABLE | funcCall )
    		int alt1=7;
    		try { DebugEnterDecision(1, decisionCanBacktrack[1]);
    		switch (input.LA(1))
    		{
    		case 67:
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

    			if ((LA1_6==67))
    			{
    				alt1=7;
    			}
    			else if ((LA1_6==EOF||LA1_6==DO||LA1_6==THEN||(LA1_6>=DIV && LA1_6<=TO)||(LA1_6>=BOOL_MULT && LA1_6<=BOOL_ADD)||LA1_6==OP_END||(LA1_6>=ADD && LA1_6<=DIVIDE)||(LA1_6>=GREATER && LA1_6<=MORE)||(LA1_6>=65 && LA1_6<=66)||(LA1_6>=68 && LA1_6<=69)))
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
    			// Lang2.g:129:13: '(' expressions ')'
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(129, 16);
    			char_literal16=(IToken)Match(input,67,Follow._67_in_mathGroup716); 
    			DebugLocation(129, 17);
    			PushFollow(Follow._expressions_in_mathGroup718);
    			expressions17=expressions();
    			PopFollow();

    			adaptor.AddChild(root_0, expressions17.Tree);
    			DebugLocation(129, 31);
    			char_literal18=(IToken)Match(input,68,Follow._68_in_mathGroup719); 

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Lang2.g:130:5: INT
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(130, 5);
    			INT19=(IToken)Match(input,INT,Follow._INT_in_mathGroup726); 
    			INT19_tree = (object)adaptor.Create(INT19);
    			adaptor.AddChild(root_0, INT19_tree);


    			}
    			break;
    		case 3:
    			DebugEnterAlt(3);
    			// Lang2.g:131:5: CHAR
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(131, 5);
    			CHAR20=(IToken)Match(input,CHAR,Follow._CHAR_in_mathGroup732); 
    			CHAR20_tree = (object)adaptor.Create(CHAR20);
    			adaptor.AddChild(root_0, CHAR20_tree);


    			}
    			break;
    		case 4:
    			DebugEnterAlt(4);
    			// Lang2.g:132:5: BOOLEAN
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(132, 5);
    			BOOLEAN21=(IToken)Match(input,BOOLEAN,Follow._BOOLEAN_in_mathGroup738); 
    			BOOLEAN21_tree = (object)adaptor.Create(BOOLEAN21);
    			adaptor.AddChild(root_0, BOOLEAN21_tree);


    			}
    			break;
    		case 5:
    			DebugEnterAlt(5);
    			// Lang2.g:133:5: STRING
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(133, 5);
    			STRING22=(IToken)Match(input,STRING,Follow._STRING_in_mathGroup745); 
    			STRING22_tree = (object)adaptor.Create(STRING22);
    			adaptor.AddChild(root_0, STRING22_tree);


    			}
    			break;
    		case 6:
    			DebugEnterAlt(6);
    			// Lang2.g:134:5: VARIABLE
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(134, 5);
    			VARIABLE23=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_mathGroup751); 
    			VARIABLE23_tree = (object)adaptor.Create(VARIABLE23);
    			adaptor.AddChild(root_0, VARIABLE23_tree);


    			}
    			break;
    		case 7:
    			DebugEnterAlt(7);
    			// Lang2.g:135:5: funcCall
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(135, 5);
    			PushFollow(Follow._funcCall_in_mathGroup757);
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
     	DebugLocation(136, 2);
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
    // Lang2.g:139:1: boolMult : mathGroup ( BOOL_MULT mathGroup )* ;
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
    	DebugLocation(139, 3);
    	try
    	{
    		// Lang2.g:139:10: ( mathGroup ( BOOL_MULT mathGroup )* )
    		DebugEnterAlt(1);
    		// Lang2.g:139:12: mathGroup ( BOOL_MULT mathGroup )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(139, 12);
    		PushFollow(Follow._mathGroup_in_boolMult769);
    		mathGroup25=mathGroup();
    		PopFollow();

    		adaptor.AddChild(root_0, mathGroup25.Tree);
    		DebugLocation(139, 21);
    		// Lang2.g:139:21: ( BOOL_MULT mathGroup )*
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
    				// Lang2.g:139:22: BOOL_MULT mathGroup
    				{
    				DebugLocation(139, 31);
    				BOOL_MULT26=(IToken)Match(input,BOOL_MULT,Follow._BOOL_MULT_in_boolMult771); 
    				BOOL_MULT26_tree = (object)adaptor.Create(BOOL_MULT26);
    				root_0 = (object)adaptor.BecomeRoot(BOOL_MULT26_tree, root_0);

    				DebugLocation(139, 33);
    				PushFollow(Follow._mathGroup_in_boolMult774);
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
     	DebugLocation(140, 3);
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
    // Lang2.g:142:1: boolAdd : boolMult ( BOOL_ADD boolMult )* ;
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
    	DebugLocation(142, 2);
    	try
    	{
    		// Lang2.g:142:9: ( boolMult ( BOOL_ADD boolMult )* )
    		DebugEnterAlt(1);
    		// Lang2.g:142:11: boolMult ( BOOL_ADD boolMult )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(142, 11);
    		PushFollow(Follow._boolMult_in_boolAdd788);
    		boolMult28=boolMult();
    		PopFollow();

    		adaptor.AddChild(root_0, boolMult28.Tree);
    		DebugLocation(142, 19);
    		// Lang2.g:142:19: ( BOOL_ADD boolMult )*
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
    				// Lang2.g:142:20: BOOL_ADD boolMult
    				{
    				DebugLocation(142, 28);
    				BOOL_ADD29=(IToken)Match(input,BOOL_ADD,Follow._BOOL_ADD_in_boolAdd790); 
    				BOOL_ADD29_tree = (object)adaptor.Create(BOOL_ADD29);
    				root_0 = (object)adaptor.BecomeRoot(BOOL_ADD29_tree, root_0);

    				DebugLocation(142, 30);
    				PushFollow(Follow._boolMult_in_boolAdd793);
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
     	DebugLocation(143, 2);
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
    // Lang2.g:145:1: boolElse : boolAdd ( boolOperator boolAdd )* ;
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
    	DebugLocation(145, 3);
    	try
    	{
    		// Lang2.g:145:10: ( boolAdd ( boolOperator boolAdd )* )
    		DebugEnterAlt(1);
    		// Lang2.g:145:12: boolAdd ( boolOperator boolAdd )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(145, 12);
    		PushFollow(Follow._boolAdd_in_boolElse806);
    		boolAdd31=boolAdd();
    		PopFollow();

    		adaptor.AddChild(root_0, boolAdd31.Tree);
    		DebugLocation(145, 19);
    		// Lang2.g:145:19: ( boolOperator boolAdd )*
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
    				// Lang2.g:145:20: boolOperator boolAdd
    				{
    				DebugLocation(145, 32);
    				PushFollow(Follow._boolOperator_in_boolElse808);
    				boolOperator32=boolOperator();
    				PopFollow();

    				root_0 = (object)adaptor.BecomeRoot(boolOperator32.Tree, root_0);
    				DebugLocation(145, 34);
    				PushFollow(Follow._boolAdd_in_boolElse811);
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
     	DebugLocation(146, 3);
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
    // Lang2.g:148:1: boolNegative : boolElse ( NOT boolElse )* ;
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
    	DebugLocation(148, 3);
    	try
    	{
    		// Lang2.g:148:14: ( boolElse ( NOT boolElse )* )
    		DebugEnterAlt(1);
    		// Lang2.g:148:16: boolElse ( NOT boolElse )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(148, 16);
    		PushFollow(Follow._boolElse_in_boolNegative825);
    		boolElse34=boolElse();
    		PopFollow();

    		adaptor.AddChild(root_0, boolElse34.Tree);
    		DebugLocation(148, 25);
    		// Lang2.g:148:25: ( NOT boolElse )*
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
    				// Lang2.g:148:26: NOT boolElse
    				{
    				DebugLocation(148, 29);
    				NOT35=(IToken)Match(input,NOT,Follow._NOT_in_boolNegative828); 
    				NOT35_tree = (object)adaptor.Create(NOT35);
    				root_0 = (object)adaptor.BecomeRoot(NOT35_tree, root_0);

    				DebugLocation(148, 31);
    				PushFollow(Follow._boolElse_in_boolNegative831);
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
     	DebugLocation(149, 3);
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
    // Lang2.g:151:1: useDiv : boolNegative ( ( DIV | MOD ) '(' boolNegative ')' )* ;
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
    	DebugLocation(151, 2);
    	try
    	{
    		// Lang2.g:151:8: ( boolNegative ( ( DIV | MOD ) '(' boolNegative ')' )* )
    		DebugEnterAlt(1);
    		// Lang2.g:151:10: boolNegative ( ( DIV | MOD ) '(' boolNegative ')' )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(151, 10);
    		PushFollow(Follow._boolNegative_in_useDiv845);
    		boolNegative37=boolNegative();
    		PopFollow();

    		adaptor.AddChild(root_0, boolNegative37.Tree);
    		DebugLocation(151, 22);
    		// Lang2.g:151:22: ( ( DIV | MOD ) '(' boolNegative ')' )*
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
    				// Lang2.g:151:23: ( DIV | MOD ) '(' boolNegative ')'
    				{
    				DebugLocation(151, 23);
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

    				DebugLocation(151, 37);
    				char_literal39=(IToken)Match(input,67,Follow._67_in_useDiv854); 
    				DebugLocation(151, 39);
    				PushFollow(Follow._boolNegative_in_useDiv857);
    				boolNegative40=boolNegative();
    				PopFollow();

    				adaptor.AddChild(root_0, boolNegative40.Tree);
    				DebugLocation(151, 55);
    				char_literal41=(IToken)Match(input,68,Follow._68_in_useDiv859); 

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
     	DebugLocation(152, 2);
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
    // Lang2.g:154:1: mathMult : useDiv ( ( MULT | DIVIDE ) useDiv )* ;
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
    	DebugLocation(154, 1);
    	try
    	{
    		// Lang2.g:155:2: ( useDiv ( ( MULT | DIVIDE ) useDiv )* )
    		DebugEnterAlt(1);
    		// Lang2.g:155:4: useDiv ( ( MULT | DIVIDE ) useDiv )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(155, 4);
    		PushFollow(Follow._useDiv_in_mathMult876);
    		useDiv42=useDiv();
    		PopFollow();

    		adaptor.AddChild(root_0, useDiv42.Tree);
    		DebugLocation(155, 10);
    		// Lang2.g:155:10: ( ( MULT | DIVIDE ) useDiv )*
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
    				// Lang2.g:155:11: ( MULT | DIVIDE ) useDiv
    				{
    				DebugLocation(155, 11);
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

    				DebugLocation(155, 25);
    				PushFollow(Follow._useDiv_in_mathMult884);
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
     	DebugLocation(156, 1);
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
    // Lang2.g:158:1: mathAdd : mathMult ( ( ADD | REM ) mathMult )* ;
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
    	DebugLocation(158, 1);
    	try
    	{
    		// Lang2.g:158:9: ( mathMult ( ( ADD | REM ) mathMult )* )
    		DebugEnterAlt(1);
    		// Lang2.g:158:11: mathMult ( ( ADD | REM ) mathMult )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(158, 11);
    		PushFollow(Follow._mathMult_in_mathAdd897);
    		mathMult45=mathMult();
    		PopFollow();

    		adaptor.AddChild(root_0, mathMult45.Tree);
    		DebugLocation(158, 19);
    		// Lang2.g:158:19: ( ( ADD | REM ) mathMult )*
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
    				// Lang2.g:158:20: ( ADD | REM ) mathMult
    				{
    				DebugLocation(158, 20);
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

    				DebugLocation(158, 30);
    				PushFollow(Follow._mathMult_in_mathAdd905);
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
     	DebugLocation(159, 1);
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
    // Lang2.g:161:1: mathExpr : mathAdd ;
    [GrammarRule("mathExpr")]
    private Lang2Parser.mathExpr_return mathExpr()
    {

        Lang2Parser.mathExpr_return retval = new Lang2Parser.mathExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.mathAdd_return mathAdd48 = default(Lang2Parser.mathAdd_return);


    	try { DebugEnterRule(GrammarFileName, "mathExpr");
    	DebugLocation(161, 1);
    	try
    	{
    		// Lang2.g:162:2: ( mathAdd )
    		DebugEnterAlt(1);
    		// Lang2.g:162:4: mathAdd
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(162, 4);
    		PushFollow(Follow._mathAdd_in_mathExpr919);
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
     	DebugLocation(164, 1);
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
    // Lang2.g:168:1: bodyOper : ( assExpr OP_END | conditionExpr | loopExpr | funcCall OP_END );
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
    	DebugLocation(168, 4);
    	try
    	{
    		// Lang2.g:168:10: ( assExpr OP_END | conditionExpr | loopExpr | funcCall OP_END )
    		int alt9=4;
    		try { DebugEnterDecision(9, decisionCanBacktrack[9]);
    		switch (input.LA(1))
    		{
    		case VARIABLE:
    			{
    			int LA9_1 = input.LA(2);

    			if ((LA9_1==ASSIGN||LA9_1==64))
    			{
    				alt9=1;
    			}
    			else if ((LA9_1==67))
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
    			// Lang2.g:168:12: assExpr OP_END
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(168, 12);
    			PushFollow(Follow._assExpr_in_bodyOper934);
    			assExpr49=assExpr();
    			PopFollow();

    			adaptor.AddChild(root_0, assExpr49.Tree);
    			DebugLocation(168, 26);
    			OP_END50=(IToken)Match(input,OP_END,Follow._OP_END_in_bodyOper936); 

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Lang2.g:169:6: conditionExpr
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(169, 6);
    			PushFollow(Follow._conditionExpr_in_bodyOper944);
    			conditionExpr51=conditionExpr();
    			PopFollow();

    			adaptor.AddChild(root_0, conditionExpr51.Tree);

    			}
    			break;
    		case 3:
    			DebugEnterAlt(3);
    			// Lang2.g:170:6: loopExpr
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(170, 6);
    			PushFollow(Follow._loopExpr_in_bodyOper951);
    			loopExpr52=loopExpr();
    			PopFollow();

    			adaptor.AddChild(root_0, loopExpr52.Tree);

    			}
    			break;
    		case 4:
    			DebugEnterAlt(4);
    			// Lang2.g:171:6: funcCall OP_END
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(171, 6);
    			PushFollow(Follow._funcCall_in_bodyOper958);
    			funcCall53=funcCall();
    			PopFollow();

    			adaptor.AddChild(root_0, funcCall53.Tree);
    			DebugLocation(171, 21);
    			OP_END54=(IToken)Match(input,OP_END,Follow._OP_END_in_bodyOper960); 

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
     	DebugLocation(172, 4);
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
    // Lang2.g:174:1: expressions : ( mathExpr | arrayCall );
    [GrammarRule("expressions")]
    private Lang2Parser.expressions_return expressions()
    {

        Lang2Parser.expressions_return retval = new Lang2Parser.expressions_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.mathExpr_return mathExpr55 = default(Lang2Parser.mathExpr_return);
        Lang2Parser.arrayCall_return arrayCall56 = default(Lang2Parser.arrayCall_return);


    	try { DebugEnterRule(GrammarFileName, "expressions");
    	DebugLocation(174, 4);
    	try
    	{
    		// Lang2.g:174:13: ( mathExpr | arrayCall )
    		int alt10=2;
    		try { DebugEnterDecision(10, decisionCanBacktrack[10]);
    		int LA10_0 = input.LA(1);

    		if (((LA10_0>=BOOLEAN && LA10_0<=STRING)||LA10_0==67))
    		{
    			alt10=1;
    		}
    		else if ((LA10_0==VARIABLE))
    		{
    			int LA10_2 = input.LA(2);

    			if ((LA10_2==DO||LA10_2==THEN||(LA10_2>=DIV && LA10_2<=TO)||(LA10_2>=BOOL_MULT && LA10_2<=BOOL_ADD)||LA10_2==OP_END||(LA10_2>=ADD && LA10_2<=DIVIDE)||(LA10_2>=GREATER && LA10_2<=MORE)||(LA10_2>=65 && LA10_2<=68)))
    			{
    				alt10=1;
    			}
    			else if ((LA10_2==64))
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
    			// Lang2.g:174:15: mathExpr
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(174, 15);
    			PushFollow(Follow._mathExpr_in_expressions974);
    			mathExpr55=mathExpr();
    			PopFollow();

    			adaptor.AddChild(root_0, mathExpr55.Tree);

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Lang2.g:175:6: arrayCall
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(175, 6);
    			PushFollow(Follow._arrayCall_in_expressions981);
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
     	DebugLocation(176, 4);
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
    // Lang2.g:178:1: funcCallArgs : mathExpr ( ',' mathExpr )* ;
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
    	DebugLocation(178, 4);
    	try
    	{
    		// Lang2.g:178:14: ( mathExpr ( ',' mathExpr )* )
    		DebugEnterAlt(1);
    		// Lang2.g:178:17: mathExpr ( ',' mathExpr )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(178, 17);
    		PushFollow(Follow._mathExpr_in_funcCallArgs995);
    		mathExpr57=mathExpr();
    		PopFollow();

    		adaptor.AddChild(root_0, mathExpr57.Tree);
    		DebugLocation(178, 25);
    		// Lang2.g:178:25: ( ',' mathExpr )*
    		try { DebugEnterSubRule(11);
    		while (true)
    		{
    			int alt11=2;
    			try { DebugEnterDecision(11, decisionCanBacktrack[11]);
    			int LA11_0 = input.LA(1);

    			if ((LA11_0==69))
    			{
    				alt11=1;
    			}


    			} finally { DebugExitDecision(11); }
    			switch ( alt11 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:178:26: ',' mathExpr
    				{
    				DebugLocation(178, 29);
    				char_literal58=(IToken)Match(input,69,Follow._69_in_funcCallArgs997); 
    				DebugLocation(178, 31);
    				PushFollow(Follow._mathExpr_in_funcCallArgs1000);
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
     	DebugLocation(179, 4);
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
    // Lang2.g:180:1: funcCallArgsW : mathExpr ( ',' mathExpr )* -> ^( FUNC_CALL_ARGS mathExpr ( mathExpr )* ) ;
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
        RewriteRuleITokenStream stream_69=new RewriteRuleITokenStream(adaptor,"token 69");
        RewriteRuleSubtreeStream stream_mathExpr=new RewriteRuleSubtreeStream(adaptor,"rule mathExpr");
    	try { DebugEnterRule(GrammarFileName, "funcCallArgsW");
    	DebugLocation(180, 4);
    	try
    	{
    		// Lang2.g:180:15: ( mathExpr ( ',' mathExpr )* -> ^( FUNC_CALL_ARGS mathExpr ( mathExpr )* ) )
    		DebugEnterAlt(1);
    		// Lang2.g:180:17: mathExpr ( ',' mathExpr )*
    		{
    		DebugLocation(180, 17);
    		PushFollow(Follow._mathExpr_in_funcCallArgsW1015);
    		mathExpr60=mathExpr();
    		PopFollow();

    		stream_mathExpr.Add(mathExpr60.Tree);
    		DebugLocation(180, 25);
    		// Lang2.g:180:25: ( ',' mathExpr )*
    		try { DebugEnterSubRule(12);
    		while (true)
    		{
    			int alt12=2;
    			try { DebugEnterDecision(12, decisionCanBacktrack[12]);
    			int LA12_0 = input.LA(1);

    			if ((LA12_0==69))
    			{
    				alt12=1;
    			}


    			} finally { DebugExitDecision(12); }
    			switch ( alt12 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:180:26: ',' mathExpr
    				{
    				DebugLocation(180, 26);
    				char_literal61=(IToken)Match(input,69,Follow._69_in_funcCallArgsW1017);  
    				stream_69.Add(char_literal61);

    				DebugLocation(180, 30);
    				PushFollow(Follow._mathExpr_in_funcCallArgsW1019);
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
    		// 180:41: -> ^( FUNC_CALL_ARGS mathExpr ( mathExpr )* )
    		{
    			DebugLocation(180, 44);
    			// Lang2.g:180:44: ^( FUNC_CALL_ARGS mathExpr ( mathExpr )* )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(180, 46);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_CALL_ARGS, "FUNC_CALL_ARGS"), root_1);

    			DebugLocation(180, 61);
    			adaptor.AddChild(root_1, stream_mathExpr.NextTree());
    			DebugLocation(180, 70);
    			// Lang2.g:180:70: ( mathExpr )*
    			while ( stream_mathExpr.HasNext )
    			{
    				DebugLocation(180, 70);
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
     	DebugLocation(181, 4);
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
    // Lang2.g:183:1: funcCall : VARIABLE '(' ( funcCallArgsW )? ')' -> ^( FUNC_CALL VARIABLE ( funcCallArgsW )? ) ;
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
        RewriteRuleITokenStream stream_68=new RewriteRuleITokenStream(adaptor,"token 68");
        RewriteRuleITokenStream stream_VARIABLE=new RewriteRuleITokenStream(adaptor,"token VARIABLE");
        RewriteRuleSubtreeStream stream_funcCallArgsW=new RewriteRuleSubtreeStream(adaptor,"rule funcCallArgsW");
    	try { DebugEnterRule(GrammarFileName, "funcCall");
    	DebugLocation(183, 3);
    	try
    	{
    		// Lang2.g:183:10: ( VARIABLE '(' ( funcCallArgsW )? ')' -> ^( FUNC_CALL VARIABLE ( funcCallArgsW )? ) )
    		DebugEnterAlt(1);
    		// Lang2.g:183:12: VARIABLE '(' ( funcCallArgsW )? ')'
    		{
    		DebugLocation(183, 12);
    		VARIABLE63=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_funcCall1045);  
    		stream_VARIABLE.Add(VARIABLE63);

    		DebugLocation(183, 20);
    		char_literal64=(IToken)Match(input,67,Follow._67_in_funcCall1046);  
    		stream_67.Add(char_literal64);

    		DebugLocation(183, 24);
    		// Lang2.g:183:24: ( funcCallArgsW )?
    		int alt13=2;
    		try { DebugEnterSubRule(13);
    		try { DebugEnterDecision(13, decisionCanBacktrack[13]);
    		int LA13_0 = input.LA(1);

    		if (((LA13_0>=BOOLEAN && LA13_0<=STRING)||LA13_0==VARIABLE||LA13_0==67))
    		{
    			alt13=1;
    		}
    		} finally { DebugExitDecision(13); }
    		switch (alt13)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Lang2.g:183:24: funcCallArgsW
    			{
    			DebugLocation(183, 24);
    			PushFollow(Follow._funcCallArgsW_in_funcCall1048);
    			funcCallArgsW65=funcCallArgsW();
    			PopFollow();

    			stream_funcCallArgsW.Add(funcCallArgsW65.Tree);

    			}
    			break;

    		}
    		} finally { DebugExitSubRule(13); }

    		DebugLocation(183, 39);
    		char_literal66=(IToken)Match(input,68,Follow._68_in_funcCall1051);  
    		stream_68.Add(char_literal66);



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
    		// 183:43: -> ^( FUNC_CALL VARIABLE ( funcCallArgsW )? )
    		{
    			DebugLocation(183, 46);
    			// Lang2.g:183:46: ^( FUNC_CALL VARIABLE ( funcCallArgsW )? )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(183, 48);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_CALL, "FUNC_CALL"), root_1);

    			DebugLocation(183, 58);
    			adaptor.AddChild(root_1, stream_VARIABLE.NextNode());
    			DebugLocation(183, 67);
    			// Lang2.g:183:67: ( funcCallArgsW )?
    			if ( stream_funcCallArgsW.HasNext )
    			{
    				DebugLocation(183, 67);
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
     	DebugLocation(184, 3);
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
    // Lang2.g:186:1: argDeclExpr : '(' ( argDeclMany )? ')' -> ^( FUNC_PROC_ARGS ( argDeclMany )? ) ;
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
        RewriteRuleITokenStream stream_68=new RewriteRuleITokenStream(adaptor,"token 68");
        RewriteRuleSubtreeStream stream_argDeclMany=new RewriteRuleSubtreeStream(adaptor,"rule argDeclMany");
    	try { DebugEnterRule(GrammarFileName, "argDeclExpr");
    	DebugLocation(186, 3);
    	try
    	{
    		// Lang2.g:186:13: ( '(' ( argDeclMany )? ')' -> ^( FUNC_PROC_ARGS ( argDeclMany )? ) )
    		DebugEnterAlt(1);
    		// Lang2.g:186:15: '(' ( argDeclMany )? ')'
    		{
    		DebugLocation(186, 18);
    		char_literal67=(IToken)Match(input,67,Follow._67_in_argDeclExpr1075);  
    		stream_67.Add(char_literal67);

    		DebugLocation(186, 20);
    		// Lang2.g:186:20: ( argDeclMany )?
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
    			// Lang2.g:186:20: argDeclMany
    			{
    			DebugLocation(186, 20);
    			PushFollow(Follow._argDeclMany_in_argDeclExpr1078);
    			argDeclMany68=argDeclMany();
    			PopFollow();

    			stream_argDeclMany.Add(argDeclMany68.Tree);

    			}
    			break;

    		}
    		} finally { DebugExitSubRule(14); }

    		DebugLocation(186, 36);
    		char_literal69=(IToken)Match(input,68,Follow._68_in_argDeclExpr1081);  
    		stream_68.Add(char_literal69);



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
    		// 186:38: -> ^( FUNC_PROC_ARGS ( argDeclMany )? )
    		{
    			DebugLocation(186, 41);
    			// Lang2.g:186:41: ^( FUNC_PROC_ARGS ( argDeclMany )? )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(186, 43);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_PROC_ARGS, "FUNC_PROC_ARGS"), root_1);

    			DebugLocation(186, 58);
    			// Lang2.g:186:58: ( argDeclMany )?
    			if ( stream_argDeclMany.HasNext )
    			{
    				DebugLocation(186, 58);
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
     	DebugLocation(187, 3);
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
    // Lang2.g:189:1: retTypeExpr : ( T_INT | T_BOOL | T_CHAR | arrayDecl | T_STRING ) ;
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
    	DebugLocation(189, 3);
    	try
    	{
    		// Lang2.g:189:13: ( ( T_INT | T_BOOL | T_CHAR | arrayDecl | T_STRING ) )
    		DebugEnterAlt(1);
    		// Lang2.g:189:15: ( T_INT | T_BOOL | T_CHAR | arrayDecl | T_STRING )
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(189, 15);
    		// Lang2.g:189:15: ( T_INT | T_BOOL | T_CHAR | arrayDecl | T_STRING )
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
    			// Lang2.g:189:16: T_INT
    			{
    			DebugLocation(189, 16);
    			T_INT70=(IToken)Match(input,T_INT,Follow._T_INT_in_retTypeExpr1104); 
    			T_INT70_tree = (object)adaptor.Create(T_INT70);
    			adaptor.AddChild(root_0, T_INT70_tree);


    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Lang2.g:189:22: T_BOOL
    			{
    			DebugLocation(189, 22);
    			T_BOOL71=(IToken)Match(input,T_BOOL,Follow._T_BOOL_in_retTypeExpr1106); 
    			T_BOOL71_tree = (object)adaptor.Create(T_BOOL71);
    			adaptor.AddChild(root_0, T_BOOL71_tree);


    			}
    			break;
    		case 3:
    			DebugEnterAlt(3);
    			// Lang2.g:189:29: T_CHAR
    			{
    			DebugLocation(189, 29);
    			T_CHAR72=(IToken)Match(input,T_CHAR,Follow._T_CHAR_in_retTypeExpr1108); 
    			T_CHAR72_tree = (object)adaptor.Create(T_CHAR72);
    			adaptor.AddChild(root_0, T_CHAR72_tree);


    			}
    			break;
    		case 4:
    			DebugEnterAlt(4);
    			// Lang2.g:189:36: arrayDecl
    			{
    			DebugLocation(189, 36);
    			PushFollow(Follow._arrayDecl_in_retTypeExpr1110);
    			arrayDecl73=arrayDecl();
    			PopFollow();

    			adaptor.AddChild(root_0, arrayDecl73.Tree);

    			}
    			break;
    		case 5:
    			DebugEnterAlt(5);
    			// Lang2.g:189:46: T_STRING
    			{
    			DebugLocation(189, 46);
    			T_STRING74=(IToken)Match(input,T_STRING,Follow._T_STRING_in_retTypeExpr1112); 
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
     	DebugLocation(190, 3);
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
    // Lang2.g:192:1: retTypeExprWrap : retTypeExpr -> ^( FUNC_PROC_RET_TYPE retTypeExpr ) ;
    [GrammarRule("retTypeExprWrap")]
    private Lang2Parser.retTypeExprWrap_return retTypeExprWrap()
    {

        Lang2Parser.retTypeExprWrap_return retval = new Lang2Parser.retTypeExprWrap_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.retTypeExpr_return retTypeExpr75 = default(Lang2Parser.retTypeExpr_return);

        RewriteRuleSubtreeStream stream_retTypeExpr=new RewriteRuleSubtreeStream(adaptor,"rule retTypeExpr");
    	try { DebugEnterRule(GrammarFileName, "retTypeExprWrap");
    	DebugLocation(192, 4);
    	try
    	{
    		// Lang2.g:192:17: ( retTypeExpr -> ^( FUNC_PROC_RET_TYPE retTypeExpr ) )
    		DebugEnterAlt(1);
    		// Lang2.g:192:19: retTypeExpr
    		{
    		DebugLocation(192, 19);
    		PushFollow(Follow._retTypeExpr_in_retTypeExprWrap1125);
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
    		// 192:31: -> ^( FUNC_PROC_RET_TYPE retTypeExpr )
    		{
    			DebugLocation(192, 34);
    			// Lang2.g:192:34: ^( FUNC_PROC_RET_TYPE retTypeExpr )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(192, 36);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_PROC_RET_TYPE, "FUNC_PROC_RET_TYPE"), root_1);

    			DebugLocation(192, 55);
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
     	DebugLocation(193, 4);
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
    // Lang2.g:195:1: bodyFuncProcExpr : ( varDeclW )? bodyExpr ;
    [GrammarRule("bodyFuncProcExpr")]
    private Lang2Parser.bodyFuncProcExpr_return bodyFuncProcExpr()
    {

        Lang2Parser.bodyFuncProcExpr_return retval = new Lang2Parser.bodyFuncProcExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.varDeclW_return varDeclW76 = default(Lang2Parser.varDeclW_return);
        Lang2Parser.bodyExpr_return bodyExpr77 = default(Lang2Parser.bodyExpr_return);


    	try { DebugEnterRule(GrammarFileName, "bodyFuncProcExpr");
    	DebugLocation(195, 5);
    	try
    	{
    		// Lang2.g:195:18: ( ( varDeclW )? bodyExpr )
    		DebugEnterAlt(1);
    		// Lang2.g:195:20: ( varDeclW )? bodyExpr
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(195, 20);
    		// Lang2.g:195:20: ( varDeclW )?
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
    			// Lang2.g:195:20: varDeclW
    			{
    			DebugLocation(195, 20);
    			PushFollow(Follow._varDeclW_in_bodyFuncProcExpr1146);
    			varDeclW76=varDeclW();
    			PopFollow();

    			adaptor.AddChild(root_0, varDeclW76.Tree);

    			}
    			break;

    		}
    		} finally { DebugExitSubRule(16); }

    		DebugLocation(195, 30);
    		PushFollow(Follow._bodyExpr_in_bodyFuncProcExpr1149);
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
     	DebugLocation(196, 5);
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
    // Lang2.g:198:1: funcDeclare : FUNCTION VARIABLE argDeclExpr ':' retTypeExprWrap OP_END bodyFuncProcExpr -> ^( FUNC_DECL VARIABLE argDeclExpr retTypeExprWrap bodyFuncProcExpr ) ;
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
        RewriteRuleITokenStream stream_VARIABLE=new RewriteRuleITokenStream(adaptor,"token VARIABLE");
        RewriteRuleITokenStream stream_OP_END=new RewriteRuleITokenStream(adaptor,"token OP_END");
        RewriteRuleITokenStream stream_70=new RewriteRuleITokenStream(adaptor,"token 70");
        RewriteRuleSubtreeStream stream_argDeclExpr=new RewriteRuleSubtreeStream(adaptor,"rule argDeclExpr");
        RewriteRuleSubtreeStream stream_bodyFuncProcExpr=new RewriteRuleSubtreeStream(adaptor,"rule bodyFuncProcExpr");
        RewriteRuleSubtreeStream stream_retTypeExprWrap=new RewriteRuleSubtreeStream(adaptor,"rule retTypeExprWrap");
    	try { DebugEnterRule(GrammarFileName, "funcDeclare");
    	DebugLocation(198, 3);
    	try
    	{
    		// Lang2.g:198:12: ( FUNCTION VARIABLE argDeclExpr ':' retTypeExprWrap OP_END bodyFuncProcExpr -> ^( FUNC_DECL VARIABLE argDeclExpr retTypeExprWrap bodyFuncProcExpr ) )
    		DebugEnterAlt(1);
    		// Lang2.g:198:14: FUNCTION VARIABLE argDeclExpr ':' retTypeExprWrap OP_END bodyFuncProcExpr
    		{
    		DebugLocation(198, 14);
    		FUNCTION78=(IToken)Match(input,FUNCTION,Follow._FUNCTION_in_funcDeclare1162);  
    		stream_FUNCTION.Add(FUNCTION78);

    		DebugLocation(198, 23);
    		VARIABLE79=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_funcDeclare1164);  
    		stream_VARIABLE.Add(VARIABLE79);

    		DebugLocation(198, 32);
    		PushFollow(Follow._argDeclExpr_in_funcDeclare1166);
    		argDeclExpr80=argDeclExpr();
    		PopFollow();

    		stream_argDeclExpr.Add(argDeclExpr80.Tree);
    		DebugLocation(198, 43);
    		char_literal81=(IToken)Match(input,70,Follow._70_in_funcDeclare1167);  
    		stream_70.Add(char_literal81);

    		DebugLocation(198, 47);
    		PushFollow(Follow._retTypeExprWrap_in_funcDeclare1169);
    		retTypeExprWrap82=retTypeExprWrap();
    		PopFollow();

    		stream_retTypeExprWrap.Add(retTypeExprWrap82.Tree);
    		DebugLocation(198, 69);
    		OP_END83=(IToken)Match(input,OP_END,Follow._OP_END_in_funcDeclare1171);  
    		stream_OP_END.Add(OP_END83);

    		DebugLocation(198, 72);
    		PushFollow(Follow._bodyFuncProcExpr_in_funcDeclare1175);
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
    		// 198:89: -> ^( FUNC_DECL VARIABLE argDeclExpr retTypeExprWrap bodyFuncProcExpr )
    		{
    			DebugLocation(198, 92);
    			// Lang2.g:198:92: ^( FUNC_DECL VARIABLE argDeclExpr retTypeExprWrap bodyFuncProcExpr )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(198, 94);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_DECL, "FUNC_DECL"), root_1);

    			DebugLocation(198, 104);
    			adaptor.AddChild(root_1, stream_VARIABLE.NextNode());
    			DebugLocation(198, 113);
    			adaptor.AddChild(root_1, stream_argDeclExpr.NextTree());
    			DebugLocation(198, 125);
    			adaptor.AddChild(root_1, stream_retTypeExprWrap.NextTree());
    			DebugLocation(198, 141);
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
     	DebugLocation(199, 3);
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
    // Lang2.g:201:1: procedureDeclare : PROCEDURE VARIABLE argDeclExpr OP_END bodyFuncProcExpr -> ^( PROC_DECL VARIABLE argDeclExpr bodyFuncProcExpr ) ;
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
    	DebugLocation(201, 4);
    	try
    	{
    		// Lang2.g:201:17: ( PROCEDURE VARIABLE argDeclExpr OP_END bodyFuncProcExpr -> ^( PROC_DECL VARIABLE argDeclExpr bodyFuncProcExpr ) )
    		DebugEnterAlt(1);
    		// Lang2.g:201:19: PROCEDURE VARIABLE argDeclExpr OP_END bodyFuncProcExpr
    		{
    		DebugLocation(201, 19);
    		PROCEDURE85=(IToken)Match(input,PROCEDURE,Follow._PROCEDURE_in_procedureDeclare1200);  
    		stream_PROCEDURE.Add(PROCEDURE85);

    		DebugLocation(201, 29);
    		VARIABLE86=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_procedureDeclare1202);  
    		stream_VARIABLE.Add(VARIABLE86);

    		DebugLocation(201, 38);
    		PushFollow(Follow._argDeclExpr_in_procedureDeclare1204);
    		argDeclExpr87=argDeclExpr();
    		PopFollow();

    		stream_argDeclExpr.Add(argDeclExpr87.Tree);
    		DebugLocation(201, 50);
    		OP_END88=(IToken)Match(input,OP_END,Follow._OP_END_in_procedureDeclare1206);  
    		stream_OP_END.Add(OP_END88);

    		DebugLocation(201, 57);
    		PushFollow(Follow._bodyFuncProcExpr_in_procedureDeclare1208);
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
    		// 201:74: -> ^( PROC_DECL VARIABLE argDeclExpr bodyFuncProcExpr )
    		{
    			DebugLocation(201, 77);
    			// Lang2.g:201:77: ^( PROC_DECL VARIABLE argDeclExpr bodyFuncProcExpr )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(201, 79);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PROC_DECL, "PROC_DECL"), root_1);

    			DebugLocation(201, 89);
    			adaptor.AddChild(root_1, stream_VARIABLE.NextNode());
    			DebugLocation(201, 98);
    			adaptor.AddChild(root_1, stream_argDeclExpr.NextTree());
    			DebugLocation(201, 110);
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
     	DebugLocation(202, 4);
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
    // Lang2.g:206:1: conditionElseExpr : ELSE bodyExpr -> ^( ELSE bodyExpr ) ;
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
    	DebugLocation(206, 5);
    	try
    	{
    		// Lang2.g:206:19: ( ELSE bodyExpr -> ^( ELSE bodyExpr ) )
    		DebugEnterAlt(1);
    		// Lang2.g:206:21: ELSE bodyExpr
    		{
    		DebugLocation(206, 25);
    		ELSE90=(IToken)Match(input,ELSE,Follow._ELSE_in_conditionElseExpr1235);  
    		stream_ELSE.Add(ELSE90);

    		DebugLocation(206, 27);
    		PushFollow(Follow._bodyExpr_in_conditionElseExpr1238);
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
    		// 206:36: -> ^( ELSE bodyExpr )
    		{
    			DebugLocation(206, 39);
    			// Lang2.g:206:39: ^( ELSE bodyExpr )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(206, 41);
    			root_1 = (object)adaptor.BecomeRoot(stream_ELSE.NextNode(), root_1);

    			DebugLocation(206, 46);
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
     	DebugLocation(207, 5);
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
    // Lang2.g:208:1: condExpr : expressions -> ^( CONDITION expressions ) ;
    [GrammarRule("condExpr")]
    private Lang2Parser.condExpr_return condExpr()
    {

        Lang2Parser.condExpr_return retval = new Lang2Parser.condExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.expressions_return expressions92 = default(Lang2Parser.expressions_return);

        RewriteRuleSubtreeStream stream_expressions=new RewriteRuleSubtreeStream(adaptor,"rule expressions");
    	try { DebugEnterRule(GrammarFileName, "condExpr");
    	DebugLocation(208, 3);
    	try
    	{
    		// Lang2.g:208:10: ( expressions -> ^( CONDITION expressions ) )
    		DebugEnterAlt(1);
    		// Lang2.g:208:13: expressions
    		{
    		DebugLocation(208, 13);
    		PushFollow(Follow._expressions_in_condExpr1260);
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
    		// 208:26: -> ^( CONDITION expressions )
    		{
    			DebugLocation(208, 29);
    			// Lang2.g:208:29: ^( CONDITION expressions )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(208, 31);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(CONDITION, "CONDITION"), root_1);

    			DebugLocation(208, 41);
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
     	DebugLocation(209, 3);
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
    // Lang2.g:210:1: conditionExpr : IF condExpr THEN bodyExpr ( conditionElseExpr )? -> ^( IF condExpr bodyExpr ( conditionElseExpr )? ) ;
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
    	DebugLocation(210, 1);
    	try
    	{
    		// Lang2.g:210:14: ( IF condExpr THEN bodyExpr ( conditionElseExpr )? -> ^( IF condExpr bodyExpr ( conditionElseExpr )? ) )
    		DebugEnterAlt(1);
    		// Lang2.g:210:16: IF condExpr THEN bodyExpr ( conditionElseExpr )?
    		{
    		DebugLocation(210, 16);
    		IF93=(IToken)Match(input,IF,Follow._IF_in_conditionExpr1279);  
    		stream_IF.Add(IF93);

    		DebugLocation(210, 19);
    		PushFollow(Follow._condExpr_in_conditionExpr1281);
    		condExpr94=condExpr();
    		PopFollow();

    		stream_condExpr.Add(condExpr94.Tree);
    		DebugLocation(210, 32);
    		THEN95=(IToken)Match(input,THEN,Follow._THEN_in_conditionExpr1283);  
    		stream_THEN.Add(THEN95);

    		DebugLocation(210, 34);
    		PushFollow(Follow._bodyExpr_in_conditionExpr1286);
    		bodyExpr96=bodyExpr();
    		PopFollow();

    		stream_bodyExpr.Add(bodyExpr96.Tree);
    		DebugLocation(210, 43);
    		// Lang2.g:210:43: ( conditionElseExpr )?
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
    			// Lang2.g:210:43: conditionElseExpr
    			{
    			DebugLocation(210, 43);
    			PushFollow(Follow._conditionElseExpr_in_conditionExpr1288);
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
    		// 210:62: -> ^( IF condExpr bodyExpr ( conditionElseExpr )? )
    		{
    			DebugLocation(210, 65);
    			// Lang2.g:210:65: ^( IF condExpr bodyExpr ( conditionElseExpr )? )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(210, 67);
    			root_1 = (object)adaptor.BecomeRoot(stream_IF.NextNode(), root_1);

    			DebugLocation(210, 70);
    			adaptor.AddChild(root_1, stream_condExpr.NextTree());
    			DebugLocation(210, 79);
    			adaptor.AddChild(root_1, stream_bodyExpr.NextTree());
    			DebugLocation(210, 88);
    			// Lang2.g:210:88: ( conditionElseExpr )?
    			if ( stream_conditionElseExpr.HasNext )
    			{
    				DebugLocation(210, 88);
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
     	DebugLocation(211, 1);
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
    // Lang2.g:214:1: forExpr : assExpr TO expressions ;
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
    	DebugLocation(214, 2);
    	try
    	{
    		// Lang2.g:214:9: ( assExpr TO expressions )
    		DebugEnterAlt(1);
    		// Lang2.g:214:12: assExpr TO expressions
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(214, 12);
    		PushFollow(Follow._assExpr_in_forExpr1314);
    		assExpr98=assExpr();
    		PopFollow();

    		adaptor.AddChild(root_0, assExpr98.Tree);
    		DebugLocation(214, 22);
    		TO99=(IToken)Match(input,TO,Follow._TO_in_forExpr1316); 
    		TO99_tree = (object)adaptor.Create(TO99);
    		root_0 = (object)adaptor.BecomeRoot(TO99_tree, root_0);

    		DebugLocation(214, 24);
    		PushFollow(Follow._expressions_in_forExpr1319);
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
     	DebugLocation(215, 2);
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
    // Lang2.g:216:1: loopExpr : ( WHILE condExpr DO bodyExpr -> ^( WHILE condExpr bodyExpr ) | FOR forExpr DO bodyExpr -> ^( FOR forExpr bodyExpr ) );
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
    	DebugLocation(216, 2);
    	try
    	{
    		// Lang2.g:216:9: ( WHILE condExpr DO bodyExpr -> ^( WHILE condExpr bodyExpr ) | FOR forExpr DO bodyExpr -> ^( FOR forExpr bodyExpr ) )
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
    			// Lang2.g:216:11: WHILE condExpr DO bodyExpr
    			{
    			DebugLocation(216, 11);
    			WHILE101=(IToken)Match(input,WHILE,Follow._WHILE_in_loopExpr1328);  
    			stream_WHILE.Add(WHILE101);

    			DebugLocation(216, 17);
    			PushFollow(Follow._condExpr_in_loopExpr1330);
    			condExpr102=condExpr();
    			PopFollow();

    			stream_condExpr.Add(condExpr102.Tree);
    			DebugLocation(216, 28);
    			DO103=(IToken)Match(input,DO,Follow._DO_in_loopExpr1332);  
    			stream_DO.Add(DO103);

    			DebugLocation(216, 30);
    			PushFollow(Follow._bodyExpr_in_loopExpr1335);
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
    			// 216:39: -> ^( WHILE condExpr bodyExpr )
    			{
    				DebugLocation(216, 42);
    				// Lang2.g:216:42: ^( WHILE condExpr bodyExpr )
    				{
    				object root_1 = (object)adaptor.Nil();
    				DebugLocation(216, 44);
    				root_1 = (object)adaptor.BecomeRoot(stream_WHILE.NextNode(), root_1);

    				DebugLocation(216, 50);
    				adaptor.AddChild(root_1, stream_condExpr.NextTree());
    				DebugLocation(216, 59);
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
    			// Lang2.g:217:5: FOR forExpr DO bodyExpr
    			{
    			DebugLocation(217, 5);
    			FOR105=(IToken)Match(input,FOR,Follow._FOR_in_loopExpr1351);  
    			stream_FOR.Add(FOR105);

    			DebugLocation(217, 9);
    			PushFollow(Follow._forExpr_in_loopExpr1353);
    			forExpr106=forExpr();
    			PopFollow();

    			stream_forExpr.Add(forExpr106.Tree);
    			DebugLocation(217, 17);
    			DO107=(IToken)Match(input,DO,Follow._DO_in_loopExpr1355);  
    			stream_DO.Add(DO107);

    			DebugLocation(217, 20);
    			PushFollow(Follow._bodyExpr_in_loopExpr1357);
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
    			// 217:29: -> ^( FOR forExpr bodyExpr )
    			{
    				DebugLocation(217, 32);
    				// Lang2.g:217:32: ^( FOR forExpr bodyExpr )
    				{
    				object root_1 = (object)adaptor.Nil();
    				DebugLocation(217, 34);
    				root_1 = (object)adaptor.BecomeRoot(stream_FOR.NextNode(), root_1);

    				DebugLocation(217, 38);
    				adaptor.AddChild(root_1, stream_forExpr.NextTree());
    				DebugLocation(217, 46);
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
     	DebugLocation(218, 2);
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
    // Lang2.g:220:1: assExpr : ( VARIABLE ASSIGN expressions | arrayCall ASSIGN expressions );
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
    	DebugLocation(220, 1);
    	try
    	{
    		// Lang2.g:220:9: ( VARIABLE ASSIGN expressions | arrayCall ASSIGN expressions )
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
    			else if ((LA19_1==64))
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
    			// Lang2.g:220:12: VARIABLE ASSIGN expressions
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(220, 12);
    			VARIABLE109=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_assExpr1380); 
    			VARIABLE109_tree = (object)adaptor.Create(VARIABLE109);
    			adaptor.AddChild(root_0, VARIABLE109_tree);

    			DebugLocation(220, 27);
    			ASSIGN110=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assExpr1382); 
    			ASSIGN110_tree = (object)adaptor.Create(ASSIGN110);
    			root_0 = (object)adaptor.BecomeRoot(ASSIGN110_tree, root_0);

    			DebugLocation(220, 29);
    			PushFollow(Follow._expressions_in_assExpr1385);
    			expressions111=expressions();
    			PopFollow();

    			adaptor.AddChild(root_0, expressions111.Tree);

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Lang2.g:221:5: arrayCall ASSIGN expressions
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(221, 5);
    			PushFollow(Follow._arrayCall_in_assExpr1391);
    			arrayCall112=arrayCall();
    			PopFollow();

    			adaptor.AddChild(root_0, arrayCall112.Tree);
    			DebugLocation(221, 21);
    			ASSIGN113=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assExpr1393); 
    			ASSIGN113_tree = (object)adaptor.Create(ASSIGN113);
    			root_0 = (object)adaptor.BecomeRoot(ASSIGN113_tree, root_0);

    			DebugLocation(221, 23);
    			PushFollow(Follow._expressions_in_assExpr1396);
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
     	DebugLocation(222, 1);
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
    // Lang2.g:224:1: argTypeDecl : typeDecl -> ^( TYPE_DECL typeDecl ) ;
    [GrammarRule("argTypeDecl")]
    private Lang2Parser.argTypeDecl_return argTypeDecl()
    {

        Lang2Parser.argTypeDecl_return retval = new Lang2Parser.argTypeDecl_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.typeDecl_return typeDecl115 = default(Lang2Parser.typeDecl_return);

        RewriteRuleSubtreeStream stream_typeDecl=new RewriteRuleSubtreeStream(adaptor,"rule typeDecl");
    	try { DebugEnterRule(GrammarFileName, "argTypeDecl");
    	DebugLocation(224, 3);
    	try
    	{
    		// Lang2.g:224:13: ( typeDecl -> ^( TYPE_DECL typeDecl ) )
    		DebugEnterAlt(1);
    		// Lang2.g:224:15: typeDecl
    		{
    		DebugLocation(224, 15);
    		PushFollow(Follow._typeDecl_in_argTypeDecl1406);
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
    		// 224:24: -> ^( TYPE_DECL typeDecl )
    		{
    			DebugLocation(224, 27);
    			// Lang2.g:224:27: ^( TYPE_DECL typeDecl )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(224, 29);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(TYPE_DECL, "TYPE_DECL"), root_1);

    			DebugLocation(224, 39);
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
     	DebugLocation(225, 3);
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
    // Lang2.g:227:1: partArgDecl : VARIABLE ( ',' VARIABLE )* ;
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
    	DebugLocation(227, 37);
    	try
    	{
    		// Lang2.g:227:12: ( VARIABLE ( ',' VARIABLE )* )
    		DebugEnterAlt(1);
    		// Lang2.g:227:14: VARIABLE ( ',' VARIABLE )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(227, 14);
    		VARIABLE116=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_partArgDecl1425); 
    		VARIABLE116_tree = (object)adaptor.Create(VARIABLE116);
    		adaptor.AddChild(root_0, VARIABLE116_tree);

    		DebugLocation(227, 22);
    		// Lang2.g:227:22: ( ',' VARIABLE )*
    		try { DebugEnterSubRule(20);
    		while (true)
    		{
    			int alt20=2;
    			try { DebugEnterDecision(20, decisionCanBacktrack[20]);
    			int LA20_0 = input.LA(1);

    			if ((LA20_0==69))
    			{
    				alt20=1;
    			}


    			} finally { DebugExitDecision(20); }
    			switch ( alt20 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:227:23: ',' VARIABLE
    				{
    				DebugLocation(227, 26);
    				char_literal117=(IToken)Match(input,69,Follow._69_in_partArgDecl1427); 
    				DebugLocation(227, 28);
    				VARIABLE118=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_partArgDecl1430); 
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
     	DebugLocation(227, 37);
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
    // Lang2.g:229:1: argDecl : ( VARIABLE ( ',' VARIABLE )* ':' argTypeDecl | VAR partArgDecl ':' argTypeDecl -> ^( VAR partArgDecl argTypeDecl ) );
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
        RewriteRuleITokenStream stream_VAR=new RewriteRuleITokenStream(adaptor,"token VAR");
        RewriteRuleITokenStream stream_70=new RewriteRuleITokenStream(adaptor,"token 70");
        RewriteRuleSubtreeStream stream_partArgDecl=new RewriteRuleSubtreeStream(adaptor,"rule partArgDecl");
        RewriteRuleSubtreeStream stream_argTypeDecl=new RewriteRuleSubtreeStream(adaptor,"rule argTypeDecl");
    	try { DebugEnterRule(GrammarFileName, "argDecl");
    	DebugLocation(229, 2);
    	try
    	{
    		// Lang2.g:229:9: ( VARIABLE ( ',' VARIABLE )* ':' argTypeDecl | VAR partArgDecl ':' argTypeDecl -> ^( VAR partArgDecl argTypeDecl ) )
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
    			// Lang2.g:229:11: VARIABLE ( ',' VARIABLE )* ':' argTypeDecl
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(229, 11);
    			VARIABLE119=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_argDecl1440); 
    			VARIABLE119_tree = (object)adaptor.Create(VARIABLE119);
    			adaptor.AddChild(root_0, VARIABLE119_tree);

    			DebugLocation(229, 19);
    			// Lang2.g:229:19: ( ',' VARIABLE )*
    			try { DebugEnterSubRule(21);
    			while (true)
    			{
    				int alt21=2;
    				try { DebugEnterDecision(21, decisionCanBacktrack[21]);
    				int LA21_0 = input.LA(1);

    				if ((LA21_0==69))
    				{
    					alt21=1;
    				}


    				} finally { DebugExitDecision(21); }
    				switch ( alt21 )
    				{
    				case 1:
    					DebugEnterAlt(1);
    					// Lang2.g:229:20: ',' VARIABLE
    					{
    					DebugLocation(229, 23);
    					char_literal120=(IToken)Match(input,69,Follow._69_in_argDecl1442); 
    					DebugLocation(229, 25);
    					VARIABLE121=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_argDecl1445); 
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

    			DebugLocation(229, 39);
    			char_literal122=(IToken)Match(input,70,Follow._70_in_argDecl1449); 
    			DebugLocation(229, 41);
    			PushFollow(Follow._argTypeDecl_in_argDecl1452);
    			argTypeDecl123=argTypeDecl();
    			PopFollow();

    			adaptor.AddChild(root_0, argTypeDecl123.Tree);

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Lang2.g:230:5: VAR partArgDecl ':' argTypeDecl
    			{
    			DebugLocation(230, 5);
    			VAR124=(IToken)Match(input,VAR,Follow._VAR_in_argDecl1458);  
    			stream_VAR.Add(VAR124);

    			DebugLocation(230, 9);
    			PushFollow(Follow._partArgDecl_in_argDecl1460);
    			partArgDecl125=partArgDecl();
    			PopFollow();

    			stream_partArgDecl.Add(partArgDecl125.Tree);
    			DebugLocation(230, 23);
    			char_literal126=(IToken)Match(input,70,Follow._70_in_argDecl1461);  
    			stream_70.Add(char_literal126);

    			DebugLocation(230, 25);
    			PushFollow(Follow._argTypeDecl_in_argDecl1464);
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
    			// 230:37: -> ^( VAR partArgDecl argTypeDecl )
    			{
    				DebugLocation(230, 40);
    				// Lang2.g:230:40: ^( VAR partArgDecl argTypeDecl )
    				{
    				object root_1 = (object)adaptor.Nil();
    				DebugLocation(230, 42);
    				root_1 = (object)adaptor.BecomeRoot(stream_VAR.NextNode(), root_1);

    				DebugLocation(230, 46);
    				adaptor.AddChild(root_1, stream_partArgDecl.NextTree());
    				DebugLocation(230, 58);
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
     	DebugLocation(231, 2);
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
    // Lang2.g:233:1: argDeclManyW : argDecl ( ',' argDecl )* ;
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
    	DebugLocation(233, 3);
    	try
    	{
    		// Lang2.g:233:14: ( argDecl ( ',' argDecl )* )
    		DebugEnterAlt(1);
    		// Lang2.g:233:16: argDecl ( ',' argDecl )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(233, 16);
    		PushFollow(Follow._argDecl_in_argDeclManyW1485);
    		argDecl128=argDecl();
    		PopFollow();

    		adaptor.AddChild(root_0, argDecl128.Tree);
    		DebugLocation(233, 23);
    		// Lang2.g:233:23: ( ',' argDecl )*
    		try { DebugEnterSubRule(23);
    		while (true)
    		{
    			int alt23=2;
    			try { DebugEnterDecision(23, decisionCanBacktrack[23]);
    			int LA23_0 = input.LA(1);

    			if ((LA23_0==69))
    			{
    				alt23=1;
    			}


    			} finally { DebugExitDecision(23); }
    			switch ( alt23 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:233:24: ',' argDecl
    				{
    				DebugLocation(233, 27);
    				char_literal129=(IToken)Match(input,69,Follow._69_in_argDeclManyW1487); 
    				DebugLocation(233, 29);
    				PushFollow(Follow._argDecl_in_argDeclManyW1490);
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
     	DebugLocation(234, 3);
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
    // Lang2.g:235:1: argDeclMany : argDeclManyW -> ^( VAR_DECL argDeclManyW ) ;
    [GrammarRule("argDeclMany")]
    private Lang2Parser.argDeclMany_return argDeclMany()
    {

        Lang2Parser.argDeclMany_return retval = new Lang2Parser.argDeclMany_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.argDeclManyW_return argDeclManyW131 = default(Lang2Parser.argDeclManyW_return);

        RewriteRuleSubtreeStream stream_argDeclManyW=new RewriteRuleSubtreeStream(adaptor,"rule argDeclManyW");
    	try { DebugEnterRule(GrammarFileName, "argDeclMany");
    	DebugLocation(235, 3);
    	try
    	{
    		// Lang2.g:235:13: ( argDeclManyW -> ^( VAR_DECL argDeclManyW ) )
    		DebugEnterAlt(1);
    		// Lang2.g:235:15: argDeclManyW
    		{
    		DebugLocation(235, 15);
    		PushFollow(Follow._argDeclManyW_in_argDeclMany1503);
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
    		// 235:28: -> ^( VAR_DECL argDeclManyW )
    		{
    			DebugLocation(235, 31);
    			// Lang2.g:235:31: ^( VAR_DECL argDeclManyW )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(235, 33);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VAR_DECL, "VAR_DECL"), root_1);

    			DebugLocation(235, 42);
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
     	DebugLocation(236, 3);
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
    // Lang2.g:237:1: typeDecl : ( T_INT | T_CHAR | T_BOOL | T_STRING );
    [GrammarRule("typeDecl")]
    private Lang2Parser.typeDecl_return typeDecl()
    {

        Lang2Parser.typeDecl_return retval = new Lang2Parser.typeDecl_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken set132=null;

        object set132_tree=null;

    	try { DebugEnterRule(GrammarFileName, "typeDecl");
    	DebugLocation(237, 39);
    	try
    	{
    		// Lang2.g:237:10: ( T_INT | T_CHAR | T_BOOL | T_STRING )
    		DebugEnterAlt(1);
    		// Lang2.g:
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(237, 10);
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
     	DebugLocation(237, 39);
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
    // Lang2.g:240:1: varTypeDeclW : ( typeDecl | arrayDecl );
    [GrammarRule("varTypeDeclW")]
    private Lang2Parser.varTypeDeclW_return varTypeDeclW()
    {

        Lang2Parser.varTypeDeclW_return retval = new Lang2Parser.varTypeDeclW_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.typeDecl_return typeDecl133 = default(Lang2Parser.typeDecl_return);
        Lang2Parser.arrayDecl_return arrayDecl134 = default(Lang2Parser.arrayDecl_return);


    	try { DebugEnterRule(GrammarFileName, "varTypeDeclW");
    	DebugLocation(240, 4);
    	try
    	{
    		// Lang2.g:240:14: ( typeDecl | arrayDecl )
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
    			// Lang2.g:240:16: typeDecl
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(240, 16);
    			PushFollow(Follow._typeDecl_in_varTypeDeclW1537);
    			typeDecl133=typeDecl();
    			PopFollow();

    			adaptor.AddChild(root_0, typeDecl133.Tree);

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Lang2.g:240:25: arrayDecl
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(240, 25);
    			PushFollow(Follow._arrayDecl_in_varTypeDeclW1539);
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
     	DebugLocation(241, 4);
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
    // Lang2.g:243:1: varTypeDecl : varTypeDeclW OP_END -> ^( TYPE_DECL varTypeDeclW ) ;
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
    	DebugLocation(243, 3);
    	try
    	{
    		// Lang2.g:243:13: ( varTypeDeclW OP_END -> ^( TYPE_DECL varTypeDeclW ) )
    		DebugEnterAlt(1);
    		// Lang2.g:243:15: varTypeDeclW OP_END
    		{
    		DebugLocation(243, 15);
    		PushFollow(Follow._varTypeDeclW_in_varTypeDecl1552);
    		varTypeDeclW135=varTypeDeclW();
    		PopFollow();

    		stream_varTypeDeclW.Add(varTypeDeclW135.Tree);
    		DebugLocation(243, 28);
    		OP_END136=(IToken)Match(input,OP_END,Follow._OP_END_in_varTypeDecl1554);  
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
    		// 243:35: -> ^( TYPE_DECL varTypeDeclW )
    		{
    			DebugLocation(243, 38);
    			// Lang2.g:243:38: ^( TYPE_DECL varTypeDeclW )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(243, 40);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(TYPE_DECL, "TYPE_DECL"), root_1);

    			DebugLocation(243, 50);
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
     	DebugLocation(244, 3);
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
    // Lang2.g:247:1: varDecl2 : VARIABLE ( ',' VARIABLE )* ;
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
    	DebugLocation(247, 35);
    	try
    	{
    		// Lang2.g:247:10: ( VARIABLE ( ',' VARIABLE )* )
    		DebugEnterAlt(1);
    		// Lang2.g:247:12: VARIABLE ( ',' VARIABLE )*
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(247, 12);
    		VARIABLE137=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_varDecl21575); 
    		VARIABLE137_tree = (object)adaptor.Create(VARIABLE137);
    		adaptor.AddChild(root_0, VARIABLE137_tree);

    		DebugLocation(247, 20);
    		// Lang2.g:247:20: ( ',' VARIABLE )*
    		try { DebugEnterSubRule(25);
    		while (true)
    		{
    			int alt25=2;
    			try { DebugEnterDecision(25, decisionCanBacktrack[25]);
    			int LA25_0 = input.LA(1);

    			if ((LA25_0==69))
    			{
    				alt25=1;
    			}


    			} finally { DebugExitDecision(25); }
    			switch ( alt25 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:247:21: ',' VARIABLE
    				{
    				DebugLocation(247, 24);
    				char_literal138=(IToken)Match(input,69,Follow._69_in_varDecl21577); 
    				DebugLocation(247, 26);
    				VARIABLE139=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_varDecl21580); 
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
     	DebugLocation(247, 35);
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
    // Lang2.g:249:1: varDecl : varDecl2 ;
    [GrammarRule("varDecl")]
    private Lang2Parser.varDecl_return varDecl()
    {

        Lang2Parser.varDecl_return retval = new Lang2Parser.varDecl_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.varDecl2_return varDecl2140 = default(Lang2Parser.varDecl2_return);


    	try { DebugEnterRule(GrammarFileName, "varDecl");
    	DebugLocation(249, 2);
    	try
    	{
    		// Lang2.g:249:9: ( varDecl2 )
    		DebugEnterAlt(1);
    		// Lang2.g:249:11: varDecl2
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(249, 11);
    		PushFollow(Follow._varDecl2_in_varDecl1590);
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
     	DebugLocation(250, 2);
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
    // Lang2.g:251:1: varDecl12W : varDecl ':' varTypeDecl ;
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
    	DebugLocation(251, 3);
    	try
    	{
    		// Lang2.g:251:12: ( varDecl ':' varTypeDecl )
    		DebugEnterAlt(1);
    		// Lang2.g:251:14: varDecl ':' varTypeDecl
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(251, 14);
    		PushFollow(Follow._varDecl_in_varDecl12W1600);
    		varDecl141=varDecl();
    		PopFollow();

    		adaptor.AddChild(root_0, varDecl141.Tree);
    		DebugLocation(251, 25);
    		char_literal142=(IToken)Match(input,70,Follow._70_in_varDecl12W1602); 
    		DebugLocation(251, 27);
    		PushFollow(Follow._varTypeDecl_in_varDecl12W1605);
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
     	DebugLocation(252, 3);
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
    // Lang2.g:253:1: varDeclW : VAR ( ( varDecl12W )+ ) -> ^( VAR_DECL ( varDecl12W )+ ) ;
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
    	DebugLocation(253, 3);
    	try
    	{
    		// Lang2.g:253:10: ( VAR ( ( varDecl12W )+ ) -> ^( VAR_DECL ( varDecl12W )+ ) )
    		DebugEnterAlt(1);
    		// Lang2.g:253:12: VAR ( ( varDecl12W )+ )
    		{
    		DebugLocation(253, 12);
    		VAR144=(IToken)Match(input,VAR,Follow._VAR_in_varDeclW1617);  
    		stream_VAR.Add(VAR144);

    		DebugLocation(253, 16);
    		// Lang2.g:253:16: ( ( varDecl12W )+ )
    		DebugEnterAlt(1);
    		// Lang2.g:253:17: ( varDecl12W )+
    		{
    		DebugLocation(253, 17);
    		// Lang2.g:253:17: ( varDecl12W )+
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
    				// Lang2.g:253:17: varDecl12W
    				{
    				DebugLocation(253, 17);
    				PushFollow(Follow._varDecl12W_in_varDeclW1620);
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
    		// 253:30: -> ^( VAR_DECL ( varDecl12W )+ )
    		{
    			DebugLocation(253, 33);
    			// Lang2.g:253:33: ^( VAR_DECL ( varDecl12W )+ )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(253, 35);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VAR_DECL, "VAR_DECL"), root_1);

    			DebugLocation(253, 44);
    			if ( !(stream_varDecl12W.HasNext) )
    			{
    				throw new RewriteEarlyExitException();
    			}
    			while ( stream_varDecl12W.HasNext )
    			{
    				DebugLocation(253, 44);
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
     	DebugLocation(254, 3);
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
    // Lang2.g:258:1: bodyExpr : BEGIN ( bodyOper )* END OP_END -> ^( BODY_EXPR ( bodyOper )* ) ;
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
    	DebugLocation(258, 3);
    	try
    	{
    		// Lang2.g:258:10: ( BEGIN ( bodyOper )* END OP_END -> ^( BODY_EXPR ( bodyOper )* ) )
    		DebugEnterAlt(1);
    		// Lang2.g:258:12: BEGIN ( bodyOper )* END OP_END
    		{
    		DebugLocation(258, 17);
    		BEGIN146=(IToken)Match(input,BEGIN,Follow._BEGIN_in_bodyExpr1646);  
    		stream_BEGIN.Add(BEGIN146);

    		DebugLocation(258, 19);
    		// Lang2.g:258:19: ( bodyOper )*
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
    				// Lang2.g:258:19: bodyOper
    				{
    				DebugLocation(258, 19);
    				PushFollow(Follow._bodyOper_in_bodyExpr1649);
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

    		DebugLocation(258, 32);
    		END148=(IToken)Match(input,END,Follow._END_in_bodyExpr1652);  
    		stream_END.Add(END148);

    		DebugLocation(258, 40);
    		OP_END149=(IToken)Match(input,OP_END,Follow._OP_END_in_bodyExpr1655);  
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
    		// 258:42: -> ^( BODY_EXPR ( bodyOper )* )
    		{
    			DebugLocation(258, 45);
    			// Lang2.g:258:45: ^( BODY_EXPR ( bodyOper )* )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(258, 47);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BODY_EXPR, "BODY_EXPR"), root_1);

    			DebugLocation(258, 57);
    			// Lang2.g:258:57: ( bodyOper )*
    			while ( stream_bodyOper.HasNext )
    			{
    				DebugLocation(258, 57);
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
     	DebugLocation(259, 3);
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
    // Lang2.g:260:1: mainBodyExpr : BEGIN ( bodyOper )* END OP_END -> ^( MAIN_BODY ( bodyOper )* ) ;
    [GrammarRule("mainBodyExpr")]
    private Lang2Parser.mainBodyExpr_return mainBodyExpr()
    {

        Lang2Parser.mainBodyExpr_return retval = new Lang2Parser.mainBodyExpr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken BEGIN150=null;
        IToken END152=null;
        IToken OP_END153=null;
        Lang2Parser.bodyOper_return bodyOper151 = default(Lang2Parser.bodyOper_return);

        object BEGIN150_tree=null;
        object END152_tree=null;
        object OP_END153_tree=null;
        RewriteRuleITokenStream stream_OP_END=new RewriteRuleITokenStream(adaptor,"token OP_END");
        RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
        RewriteRuleITokenStream stream_BEGIN=new RewriteRuleITokenStream(adaptor,"token BEGIN");
        RewriteRuleSubtreeStream stream_bodyOper=new RewriteRuleSubtreeStream(adaptor,"rule bodyOper");
    	try { DebugEnterRule(GrammarFileName, "mainBodyExpr");
    	DebugLocation(260, 4);
    	try
    	{
    		// Lang2.g:260:14: ( BEGIN ( bodyOper )* END OP_END -> ^( MAIN_BODY ( bodyOper )* ) )
    		DebugEnterAlt(1);
    		// Lang2.g:260:16: BEGIN ( bodyOper )* END OP_END
    		{
    		DebugLocation(260, 21);
    		BEGIN150=(IToken)Match(input,BEGIN,Follow._BEGIN_in_mainBodyExpr1676);  
    		stream_BEGIN.Add(BEGIN150);

    		DebugLocation(260, 23);
    		// Lang2.g:260:23: ( bodyOper )*
    		try { DebugEnterSubRule(28);
    		while (true)
    		{
    			int alt28=2;
    			try { DebugEnterDecision(28, decisionCanBacktrack[28]);
    			int LA28_0 = input.LA(1);

    			if ((LA28_0==WHILE||LA28_0==FOR||LA28_0==IF||LA28_0==VARIABLE))
    			{
    				alt28=1;
    			}


    			} finally { DebugExitDecision(28); }
    			switch ( alt28 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:260:23: bodyOper
    				{
    				DebugLocation(260, 23);
    				PushFollow(Follow._bodyOper_in_mainBodyExpr1679);
    				bodyOper151=bodyOper();
    				PopFollow();

    				stream_bodyOper.Add(bodyOper151.Tree);

    				}
    				break;

    			default:
    				goto loop28;
    			}
    		}

    		loop28:
    			;

    		} finally { DebugExitSubRule(28); }

    		DebugLocation(260, 36);
    		END152=(IToken)Match(input,END,Follow._END_in_mainBodyExpr1682);  
    		stream_END.Add(END152);

    		DebugLocation(260, 38);
    		OP_END153=(IToken)Match(input,OP_END,Follow._OP_END_in_mainBodyExpr1685);  
    		stream_OP_END.Add(OP_END153);



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
    		// 260:45: -> ^( MAIN_BODY ( bodyOper )* )
    		{
    			DebugLocation(260, 48);
    			// Lang2.g:260:48: ^( MAIN_BODY ( bodyOper )* )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(260, 50);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(MAIN_BODY, "MAIN_BODY"), root_1);

    			DebugLocation(260, 60);
    			// Lang2.g:260:60: ( bodyOper )*
    			while ( stream_bodyOper.HasNext )
    			{
    				DebugLocation(260, 60);
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
     	DebugLocation(261, 4);
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
    // Lang2.g:262:1: func_proc_expr : ( funcDeclare | procedureDeclare );
    [GrammarRule("func_proc_expr")]
    private Lang2Parser.func_proc_expr_return func_proc_expr()
    {

        Lang2Parser.func_proc_expr_return retval = new Lang2Parser.func_proc_expr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.funcDeclare_return funcDeclare154 = default(Lang2Parser.funcDeclare_return);
        Lang2Parser.procedureDeclare_return procedureDeclare155 = default(Lang2Parser.procedureDeclare_return);


    	try { DebugEnterRule(GrammarFileName, "func_proc_expr");
    	DebugLocation(262, 46);
    	try
    	{
    		// Lang2.g:262:16: ( funcDeclare | procedureDeclare )
    		int alt29=2;
    		try { DebugEnterDecision(29, decisionCanBacktrack[29]);
    		int LA29_0 = input.LA(1);

    		if ((LA29_0==FUNCTION))
    		{
    			alt29=1;
    		}
    		else if ((LA29_0==PROCEDURE))
    		{
    			alt29=2;
    		}
    		else
    		{
    			NoViableAltException nvae = new NoViableAltException("", 29, 0, input);

    			DebugRecognitionException(nvae);
    			throw nvae;
    		}
    		} finally { DebugExitDecision(29); }
    		switch (alt29)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Lang2.g:262:18: funcDeclare
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(262, 18);
    			PushFollow(Follow._funcDeclare_in_func_proc_expr1706);
    			funcDeclare154=funcDeclare();
    			PopFollow();

    			adaptor.AddChild(root_0, funcDeclare154.Tree);

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// Lang2.g:262:30: procedureDeclare
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(262, 30);
    			PushFollow(Follow._procedureDeclare_in_func_proc_expr1708);
    			procedureDeclare155=procedureDeclare();
    			PopFollow();

    			adaptor.AddChild(root_0, procedureDeclare155.Tree);

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
     	DebugLocation(262, 46);
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
    // Lang2.g:264:1: fpExprW : ( func_proc_expr )* -> ^( FUNC_PROC_EXPR ( func_proc_expr )* ) ;
    [GrammarRule("fpExprW")]
    private Lang2Parser.fpExprW_return fpExprW()
    {

        Lang2Parser.fpExprW_return retval = new Lang2Parser.fpExprW_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.func_proc_expr_return func_proc_expr156 = default(Lang2Parser.func_proc_expr_return);

        RewriteRuleSubtreeStream stream_func_proc_expr=new RewriteRuleSubtreeStream(adaptor,"rule func_proc_expr");
    	try { DebugEnterRule(GrammarFileName, "fpExprW");
    	DebugLocation(264, 62);
    	try
    	{
    		// Lang2.g:264:9: ( ( func_proc_expr )* -> ^( FUNC_PROC_EXPR ( func_proc_expr )* ) )
    		DebugEnterAlt(1);
    		// Lang2.g:264:11: ( func_proc_expr )*
    		{
    		DebugLocation(264, 11);
    		// Lang2.g:264:11: ( func_proc_expr )*
    		try { DebugEnterSubRule(30);
    		while (true)
    		{
    			int alt30=2;
    			try { DebugEnterDecision(30, decisionCanBacktrack[30]);
    			int LA30_0 = input.LA(1);

    			if (((LA30_0>=FUNCTION && LA30_0<=PROCEDURE)))
    			{
    				alt30=1;
    			}


    			} finally { DebugExitDecision(30); }
    			switch ( alt30 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:264:11: func_proc_expr
    				{
    				DebugLocation(264, 11);
    				PushFollow(Follow._func_proc_expr_in_fpExprW1717);
    				func_proc_expr156=func_proc_expr();
    				PopFollow();

    				stream_func_proc_expr.Add(func_proc_expr156.Tree);

    				}
    				break;

    			default:
    				goto loop30;
    			}
    		}

    		loop30:
    			;

    		} finally { DebugExitSubRule(30); }



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
    		// 264:27: -> ^( FUNC_PROC_EXPR ( func_proc_expr )* )
    		{
    			DebugLocation(264, 30);
    			// Lang2.g:264:30: ^( FUNC_PROC_EXPR ( func_proc_expr )* )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(264, 32);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_PROC_EXPR, "FUNC_PROC_EXPR"), root_1);

    			DebugLocation(264, 47);
    			// Lang2.g:264:47: ( func_proc_expr )*
    			while ( stream_func_proc_expr.HasNext )
    			{
    				DebugLocation(264, 47);
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
     	DebugLocation(264, 62);
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
    // Lang2.g:266:1: wrapToBody : ( varDeclW )? fpExprW mainBodyExpr -> ^( BODY_EXPR ( varDeclW )? fpExprW mainBodyExpr ) ;
    [GrammarRule("wrapToBody")]
    private Lang2Parser.wrapToBody_return wrapToBody()
    {

        Lang2Parser.wrapToBody_return retval = new Lang2Parser.wrapToBody_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.varDeclW_return varDeclW157 = default(Lang2Parser.varDeclW_return);
        Lang2Parser.fpExprW_return fpExprW158 = default(Lang2Parser.fpExprW_return);
        Lang2Parser.mainBodyExpr_return mainBodyExpr159 = default(Lang2Parser.mainBodyExpr_return);

        RewriteRuleSubtreeStream stream_varDeclW=new RewriteRuleSubtreeStream(adaptor,"rule varDeclW");
        RewriteRuleSubtreeStream stream_mainBodyExpr=new RewriteRuleSubtreeStream(adaptor,"rule mainBodyExpr");
        RewriteRuleSubtreeStream stream_fpExprW=new RewriteRuleSubtreeStream(adaptor,"rule fpExprW");
    	try { DebugEnterRule(GrammarFileName, "wrapToBody");
    	DebugLocation(266, 3);
    	try
    	{
    		// Lang2.g:266:12: ( ( varDeclW )? fpExprW mainBodyExpr -> ^( BODY_EXPR ( varDeclW )? fpExprW mainBodyExpr ) )
    		DebugEnterAlt(1);
    		// Lang2.g:266:14: ( varDeclW )? fpExprW mainBodyExpr
    		{
    		DebugLocation(266, 14);
    		// Lang2.g:266:14: ( varDeclW )?
    		int alt31=2;
    		try { DebugEnterSubRule(31);
    		try { DebugEnterDecision(31, decisionCanBacktrack[31]);
    		int LA31_0 = input.LA(1);

    		if ((LA31_0==VAR))
    		{
    			alt31=1;
    		}
    		} finally { DebugExitDecision(31); }
    		switch (alt31)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// Lang2.g:266:14: varDeclW
    			{
    			DebugLocation(266, 14);
    			PushFollow(Follow._varDeclW_in_wrapToBody1735);
    			varDeclW157=varDeclW();
    			PopFollow();

    			stream_varDeclW.Add(varDeclW157.Tree);

    			}
    			break;

    		}
    		} finally { DebugExitSubRule(31); }

    		DebugLocation(266, 24);
    		PushFollow(Follow._fpExprW_in_wrapToBody1738);
    		fpExprW158=fpExprW();
    		PopFollow();

    		stream_fpExprW.Add(fpExprW158.Tree);
    		DebugLocation(266, 32);
    		PushFollow(Follow._mainBodyExpr_in_wrapToBody1740);
    		mainBodyExpr159=mainBodyExpr();
    		PopFollow();

    		stream_mainBodyExpr.Add(mainBodyExpr159.Tree);


    		{
    		// AST REWRITE
    		// elements: varDeclW, mainBodyExpr, fpExprW
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 266:45: -> ^( BODY_EXPR ( varDeclW )? fpExprW mainBodyExpr )
    		{
    			DebugLocation(266, 48);
    			// Lang2.g:266:48: ^( BODY_EXPR ( varDeclW )? fpExprW mainBodyExpr )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(266, 50);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BODY_EXPR, "BODY_EXPR"), root_1);

    			DebugLocation(266, 60);
    			// Lang2.g:266:60: ( varDeclW )?
    			if ( stream_varDeclW.HasNext )
    			{
    				DebugLocation(266, 60);
    				adaptor.AddChild(root_1, stream_varDeclW.NextTree());

    			}
    			stream_varDeclW.Reset();
    			DebugLocation(266, 70);
    			adaptor.AddChild(root_1, stream_fpExprW.NextTree());
    			DebugLocation(266, 78);
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
     	DebugLocation(267, 3);
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
    // Lang2.g:269:1: expr : PROGRAM VARIABLE OP_END wrapToBody -> ^( PROGRAM VARIABLE wrapToBody ) ;
    [GrammarRule("expr")]
    private Lang2Parser.expr_return expr()
    {

        Lang2Parser.expr_return retval = new Lang2Parser.expr_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken PROGRAM160=null;
        IToken VARIABLE161=null;
        IToken OP_END162=null;
        Lang2Parser.wrapToBody_return wrapToBody163 = default(Lang2Parser.wrapToBody_return);

        object PROGRAM160_tree=null;
        object VARIABLE161_tree=null;
        object OP_END162_tree=null;
        RewriteRuleITokenStream stream_PROGRAM=new RewriteRuleITokenStream(adaptor,"token PROGRAM");
        RewriteRuleITokenStream stream_VARIABLE=new RewriteRuleITokenStream(adaptor,"token VARIABLE");
        RewriteRuleITokenStream stream_OP_END=new RewriteRuleITokenStream(adaptor,"token OP_END");
        RewriteRuleSubtreeStream stream_wrapToBody=new RewriteRuleSubtreeStream(adaptor,"rule wrapToBody");
    	try { DebugEnterRule(GrammarFileName, "expr");
    	DebugLocation(269, 1);
    	try
    	{
    		// Lang2.g:269:6: ( PROGRAM VARIABLE OP_END wrapToBody -> ^( PROGRAM VARIABLE wrapToBody ) )
    		DebugEnterAlt(1);
    		// Lang2.g:269:9: PROGRAM VARIABLE OP_END wrapToBody
    		{
    		DebugLocation(269, 9);
    		PROGRAM160=(IToken)Match(input,PROGRAM,Follow._PROGRAM_in_expr1766);  
    		stream_PROGRAM.Add(PROGRAM160);

    		DebugLocation(269, 17);
    		VARIABLE161=(IToken)Match(input,VARIABLE,Follow._VARIABLE_in_expr1768);  
    		stream_VARIABLE.Add(VARIABLE161);

    		DebugLocation(269, 32);
    		OP_END162=(IToken)Match(input,OP_END,Follow._OP_END_in_expr1770);  
    		stream_OP_END.Add(OP_END162);

    		DebugLocation(269, 34);
    		PushFollow(Follow._wrapToBody_in_expr1773);
    		wrapToBody163=wrapToBody();
    		PopFollow();

    		stream_wrapToBody.Add(wrapToBody163.Tree);


    		{
    		// AST REWRITE
    		// elements: VARIABLE, wrapToBody, PROGRAM
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 269:45: -> ^( PROGRAM VARIABLE wrapToBody )
    		{
    			DebugLocation(269, 48);
    			// Lang2.g:269:48: ^( PROGRAM VARIABLE wrapToBody )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(269, 50);
    			root_1 = (object)adaptor.BecomeRoot(stream_PROGRAM.NextNode(), root_1);

    			DebugLocation(269, 58);
    			adaptor.AddChild(root_1, stream_VARIABLE.NextNode());
    			DebugLocation(269, 67);
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
     	DebugLocation(270, 1);
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
    // Lang2.g:272:1: program : ( expr )+ ;
    [GrammarRule("program")]
    private Lang2Parser.program_return program()
    {

        Lang2Parser.program_return retval = new Lang2Parser.program_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.expr_return expr164 = default(Lang2Parser.expr_return);


    	try { DebugEnterRule(GrammarFileName, "program");
    	DebugLocation(272, 16);
    	try
    	{
    		// Lang2.g:272:8: ( ( expr )+ )
    		DebugEnterAlt(1);
    		// Lang2.g:272:10: ( expr )+
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(272, 10);
    		// Lang2.g:272:10: ( expr )+
    		int cnt32=0;
    		try { DebugEnterSubRule(32);
    		while (true)
    		{
    			int alt32=2;
    			try { DebugEnterDecision(32, decisionCanBacktrack[32]);
    			int LA32_0 = input.LA(1);

    			if ((LA32_0==PROGRAM))
    			{
    				alt32=1;
    			}


    			} finally { DebugExitDecision(32); }
    			switch (alt32)
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// Lang2.g:272:10: expr
    				{
    				DebugLocation(272, 10);
    				PushFollow(Follow._expr_in_program1793);
    				expr164=expr();
    				PopFollow();

    				adaptor.AddChild(root_0, expr164.Tree);

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
        }
     	DebugLocation(272, 16);
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
    // Lang2.g:273:1: result : program EOF -> ^( PROGRAM program ) ;
    [GrammarRule("result")]
    private Lang2Parser.result_return result()
    {

        Lang2Parser.result_return retval = new Lang2Parser.result_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken EOF166=null;
        Lang2Parser.program_return program165 = default(Lang2Parser.program_return);

        object EOF166_tree=null;
        RewriteRuleITokenStream stream_EOF=new RewriteRuleITokenStream(adaptor,"token EOF");
        RewriteRuleSubtreeStream stream_program=new RewriteRuleSubtreeStream(adaptor,"rule program");
    	try { DebugEnterRule(GrammarFileName, "result");
    	DebugLocation(273, 41);
    	try
    	{
    		// Lang2.g:273:7: ( program EOF -> ^( PROGRAM program ) )
    		DebugEnterAlt(1);
    		// Lang2.g:273:9: program EOF
    		{
    		DebugLocation(273, 9);
    		PushFollow(Follow._program_in_result1802);
    		program165=program();
    		PopFollow();

    		stream_program.Add(program165.Tree);
    		DebugLocation(273, 17);
    		EOF166=(IToken)Match(input,EOF,Follow._EOF_in_result1804);  
    		stream_EOF.Add(EOF166);



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
    		// 273:21: -> ^( PROGRAM program )
    		{
    			DebugLocation(273, 24);
    			// Lang2.g:273:24: ^( PROGRAM program )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(273, 26);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PROGRAM, "PROGRAM"), root_1);

    			DebugLocation(273, 34);
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
     	DebugLocation(273, 41);
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
    // Lang2.g:274:8: public execute : result ;
    [GrammarRule("execute")]
    public Lang2Parser.execute_return execute()
    {

        Lang2Parser.execute_return retval = new Lang2Parser.execute_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        Lang2Parser.result_return result167 = default(Lang2Parser.result_return);


    	try { DebugEnterRule(GrammarFileName, "execute");
    	DebugLocation(274, 23);
    	try
    	{
    		// Lang2.g:274:15: ( result )
    		DebugEnterAlt(1);
    		// Lang2.g:274:18: result
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(274, 18);
    		PushFollow(Follow._result_in_execute1821);
    		result167=result();
    		PopFollow();

    		adaptor.AddChild(root_0, result167.Tree);

    		}

    		retval.Stop = (IToken)input.LT(-1);

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

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
     	DebugLocation(274, 23);
    	} finally { DebugExitRule(GrammarFileName, "execute"); }
    	return retval;

    }
    // $ANTLR end "execute"

	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _64_in_arrayRange483 = new BitSet(new ulong[]{0x001000000F000000UL,0x0000000000000008UL});
		public static readonly BitSet _expressions_in_arrayRange484 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000002UL});
		public static readonly BitSet _65_in_arrayRange486 = new BitSet(new ulong[]{0x001000000F000000UL,0x0000000000000008UL});
		public static readonly BitSet _expressions_in_arrayRange488 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
		public static readonly BitSet _66_in_arrayRange489 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _OF_in_arrayTypeDecl510 = new BitSet(new ulong[]{0x0000000000780000UL});
		public static readonly BitSet _typeDecl_in_arrayTypeDecl512 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _ARRAY_in_arrayDecl533 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000001UL});
		public static readonly BitSet _arrayRange_in_arrayDecl535 = new BitSet(new ulong[]{0x0000200000000000UL});
		public static readonly BitSet _arrayTypeDecl_in_arrayDecl537 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VARIABLE_in_arrayCall560 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000001UL});
		public static readonly BitSet _64_in_arrayCall562 = new BitSet(new ulong[]{0x001000000F000000UL,0x0000000000000008UL});
		public static readonly BitSet _expressions_in_arrayCall563 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000004UL});
		public static readonly BitSet _66_in_arrayCall564 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _set_in_boolOperator0 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _67_in_mathGroup716 = new BitSet(new ulong[]{0x001000000F000000UL,0x0000000000000008UL});
		public static readonly BitSet _expressions_in_mathGroup718 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000010UL});
		public static readonly BitSet _68_in_mathGroup719 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _INT_in_mathGroup726 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _CHAR_in_mathGroup732 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _BOOLEAN_in_mathGroup738 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _STRING_in_mathGroup745 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VARIABLE_in_mathGroup751 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _funcCall_in_mathGroup757 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _mathGroup_in_boolMult769 = new BitSet(new ulong[]{0x0000020000000002UL});
		public static readonly BitSet _BOOL_MULT_in_boolMult771 = new BitSet(new ulong[]{0x001000000F000000UL,0x0000000000000008UL});
		public static readonly BitSet _mathGroup_in_boolMult774 = new BitSet(new ulong[]{0x0000020000000002UL});
		public static readonly BitSet _boolMult_in_boolAdd788 = new BitSet(new ulong[]{0x0000040000000002UL});
		public static readonly BitSet _BOOL_ADD_in_boolAdd790 = new BitSet(new ulong[]{0x001000000F000000UL,0x0000000000000008UL});
		public static readonly BitSet _boolMult_in_boolAdd793 = new BitSet(new ulong[]{0x0000040000000002UL});
		public static readonly BitSet _boolAdd_in_boolElse806 = new BitSet(new ulong[]{0xFC00000000000002UL});
		public static readonly BitSet _boolOperator_in_boolElse808 = new BitSet(new ulong[]{0x001000000F000000UL,0x0000000000000008UL});
		public static readonly BitSet _boolAdd_in_boolElse811 = new BitSet(new ulong[]{0xFC00000000000002UL});
		public static readonly BitSet _boolElse_in_boolNegative825 = new BitSet(new ulong[]{0x0000000000010002UL});
		public static readonly BitSet _NOT_in_boolNegative828 = new BitSet(new ulong[]{0x001000000F000000UL,0x0000000000000008UL});
		public static readonly BitSet _boolElse_in_boolNegative831 = new BitSet(new ulong[]{0x0000000000010002UL});
		public static readonly BitSet _boolNegative_in_useDiv845 = new BitSet(new ulong[]{0x000000000000C002UL});
		public static readonly BitSet _set_in_useDiv847 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000008UL});
		public static readonly BitSet _67_in_useDiv854 = new BitSet(new ulong[]{0x001000000F000000UL,0x0000000000000008UL});
		public static readonly BitSet _boolNegative_in_useDiv857 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000010UL});
		public static readonly BitSet _68_in_useDiv859 = new BitSet(new ulong[]{0x000000000000C002UL});
		public static readonly BitSet _useDiv_in_mathMult876 = new BitSet(new ulong[]{0x0180000000000002UL});
		public static readonly BitSet _set_in_mathMult878 = new BitSet(new ulong[]{0x001000000F000000UL,0x0000000000000008UL});
		public static readonly BitSet _useDiv_in_mathMult884 = new BitSet(new ulong[]{0x0180000000000002UL});
		public static readonly BitSet _mathMult_in_mathAdd897 = new BitSet(new ulong[]{0x0060000000000002UL});
		public static readonly BitSet _set_in_mathAdd899 = new BitSet(new ulong[]{0x001000000F000000UL,0x0000000000000008UL});
		public static readonly BitSet _mathMult_in_mathAdd905 = new BitSet(new ulong[]{0x0060000000000002UL});
		public static readonly BitSet _mathAdd_in_mathExpr919 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _assExpr_in_bodyOper934 = new BitSet(new ulong[]{0x0004000000000000UL});
		public static readonly BitSet _OP_END_in_bodyOper936 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _conditionExpr_in_bodyOper944 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _loopExpr_in_bodyOper951 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _funcCall_in_bodyOper958 = new BitSet(new ulong[]{0x0004000000000000UL});
		public static readonly BitSet _OP_END_in_bodyOper960 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _mathExpr_in_expressions974 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _arrayCall_in_expressions981 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _mathExpr_in_funcCallArgs995 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000020UL});
		public static readonly BitSet _69_in_funcCallArgs997 = new BitSet(new ulong[]{0x001000000F000000UL,0x0000000000000008UL});
		public static readonly BitSet _mathExpr_in_funcCallArgs1000 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000020UL});
		public static readonly BitSet _mathExpr_in_funcCallArgsW1015 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000020UL});
		public static readonly BitSet _69_in_funcCallArgsW1017 = new BitSet(new ulong[]{0x001000000F000000UL,0x0000000000000008UL});
		public static readonly BitSet _mathExpr_in_funcCallArgsW1019 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000020UL});
		public static readonly BitSet _VARIABLE_in_funcCall1045 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000008UL});
		public static readonly BitSet _67_in_funcCall1046 = new BitSet(new ulong[]{0x001000000F000000UL,0x0000000000000018UL});
		public static readonly BitSet _funcCallArgsW_in_funcCall1048 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000010UL});
		public static readonly BitSet _68_in_funcCall1051 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _67_in_argDeclExpr1075 = new BitSet(new ulong[]{0x0010000000040000UL,0x0000000000000010UL});
		public static readonly BitSet _argDeclMany_in_argDeclExpr1078 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000010UL});
		public static readonly BitSet _68_in_argDeclExpr1081 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _T_INT_in_retTypeExpr1104 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _T_BOOL_in_retTypeExpr1106 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _T_CHAR_in_retTypeExpr1108 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _arrayDecl_in_retTypeExpr1110 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _T_STRING_in_retTypeExpr1112 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _retTypeExpr_in_retTypeExprWrap1125 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _varDeclW_in_bodyFuncProcExpr1146 = new BitSet(new ulong[]{0x0000000000000400UL});
		public static readonly BitSet _bodyExpr_in_bodyFuncProcExpr1149 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _FUNCTION_in_funcDeclare1162 = new BitSet(new ulong[]{0x0010000000000000UL});
		public static readonly BitSet _VARIABLE_in_funcDeclare1164 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000008UL});
		public static readonly BitSet _argDeclExpr_in_funcDeclare1166 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000040UL});
		public static readonly BitSet _70_in_funcDeclare1167 = new BitSet(new ulong[]{0x0000100000780000UL});
		public static readonly BitSet _retTypeExprWrap_in_funcDeclare1169 = new BitSet(new ulong[]{0x0004000000000000UL});
		public static readonly BitSet _OP_END_in_funcDeclare1171 = new BitSet(new ulong[]{0x0000000000040400UL});
		public static readonly BitSet _bodyFuncProcExpr_in_funcDeclare1175 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _PROCEDURE_in_procedureDeclare1200 = new BitSet(new ulong[]{0x0010000000000000UL});
		public static readonly BitSet _VARIABLE_in_procedureDeclare1202 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000008UL});
		public static readonly BitSet _argDeclExpr_in_procedureDeclare1204 = new BitSet(new ulong[]{0x0004000000000000UL});
		public static readonly BitSet _OP_END_in_procedureDeclare1206 = new BitSet(new ulong[]{0x0000000000040400UL});
		public static readonly BitSet _bodyFuncProcExpr_in_procedureDeclare1208 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _ELSE_in_conditionElseExpr1235 = new BitSet(new ulong[]{0x0000000000000400UL});
		public static readonly BitSet _bodyExpr_in_conditionElseExpr1238 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _expressions_in_condExpr1260 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _IF_in_conditionExpr1279 = new BitSet(new ulong[]{0x001000000F000000UL,0x0000000000000008UL});
		public static readonly BitSet _condExpr_in_conditionExpr1281 = new BitSet(new ulong[]{0x0000000000001000UL});
		public static readonly BitSet _THEN_in_conditionExpr1283 = new BitSet(new ulong[]{0x0000000000000400UL});
		public static readonly BitSet _bodyExpr_in_conditionExpr1286 = new BitSet(new ulong[]{0x0000000000002002UL});
		public static readonly BitSet _conditionElseExpr_in_conditionExpr1288 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _assExpr_in_forExpr1314 = new BitSet(new ulong[]{0x0000000000020000UL});
		public static readonly BitSet _TO_in_forExpr1316 = new BitSet(new ulong[]{0x001000000F000000UL,0x0000000000000008UL});
		public static readonly BitSet _expressions_in_forExpr1319 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _WHILE_in_loopExpr1328 = new BitSet(new ulong[]{0x001000000F000000UL,0x0000000000000008UL});
		public static readonly BitSet _condExpr_in_loopExpr1330 = new BitSet(new ulong[]{0x0000000000000040UL});
		public static readonly BitSet _DO_in_loopExpr1332 = new BitSet(new ulong[]{0x0000000000000400UL});
		public static readonly BitSet _bodyExpr_in_loopExpr1335 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _FOR_in_loopExpr1351 = new BitSet(new ulong[]{0x001000000F000000UL,0x0000000000000008UL});
		public static readonly BitSet _forExpr_in_loopExpr1353 = new BitSet(new ulong[]{0x0000000000000040UL});
		public static readonly BitSet _DO_in_loopExpr1355 = new BitSet(new ulong[]{0x0000000000000400UL});
		public static readonly BitSet _bodyExpr_in_loopExpr1357 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VARIABLE_in_assExpr1380 = new BitSet(new ulong[]{0x0200000000000000UL});
		public static readonly BitSet _ASSIGN_in_assExpr1382 = new BitSet(new ulong[]{0x001000000F000000UL,0x0000000000000008UL});
		public static readonly BitSet _expressions_in_assExpr1385 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _arrayCall_in_assExpr1391 = new BitSet(new ulong[]{0x0200000000000000UL});
		public static readonly BitSet _ASSIGN_in_assExpr1393 = new BitSet(new ulong[]{0x001000000F000000UL,0x0000000000000008UL});
		public static readonly BitSet _expressions_in_assExpr1396 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _typeDecl_in_argTypeDecl1406 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VARIABLE_in_partArgDecl1425 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000020UL});
		public static readonly BitSet _69_in_partArgDecl1427 = new BitSet(new ulong[]{0x0010000000000000UL});
		public static readonly BitSet _VARIABLE_in_partArgDecl1430 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000020UL});
		public static readonly BitSet _VARIABLE_in_argDecl1440 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000060UL});
		public static readonly BitSet _69_in_argDecl1442 = new BitSet(new ulong[]{0x0010000000000000UL});
		public static readonly BitSet _VARIABLE_in_argDecl1445 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000060UL});
		public static readonly BitSet _70_in_argDecl1449 = new BitSet(new ulong[]{0x0000000000780000UL});
		public static readonly BitSet _argTypeDecl_in_argDecl1452 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VAR_in_argDecl1458 = new BitSet(new ulong[]{0x0010000000000000UL});
		public static readonly BitSet _partArgDecl_in_argDecl1460 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000040UL});
		public static readonly BitSet _70_in_argDecl1461 = new BitSet(new ulong[]{0x0000000000780000UL});
		public static readonly BitSet _argTypeDecl_in_argDecl1464 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _argDecl_in_argDeclManyW1485 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000020UL});
		public static readonly BitSet _69_in_argDeclManyW1487 = new BitSet(new ulong[]{0x0010000000040000UL});
		public static readonly BitSet _argDecl_in_argDeclManyW1490 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000020UL});
		public static readonly BitSet _argDeclManyW_in_argDeclMany1503 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _set_in_typeDecl0 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _typeDecl_in_varTypeDeclW1537 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _arrayDecl_in_varTypeDeclW1539 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _varTypeDeclW_in_varTypeDecl1552 = new BitSet(new ulong[]{0x0004000000000000UL});
		public static readonly BitSet _OP_END_in_varTypeDecl1554 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VARIABLE_in_varDecl21575 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000020UL});
		public static readonly BitSet _69_in_varDecl21577 = new BitSet(new ulong[]{0x0010000000000000UL});
		public static readonly BitSet _VARIABLE_in_varDecl21580 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000020UL});
		public static readonly BitSet _varDecl2_in_varDecl1590 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _varDecl_in_varDecl12W1600 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000040UL});
		public static readonly BitSet _70_in_varDecl12W1602 = new BitSet(new ulong[]{0x0000100000780000UL});
		public static readonly BitSet _varTypeDecl_in_varDecl12W1605 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _VAR_in_varDeclW1617 = new BitSet(new ulong[]{0x0010000000000000UL});
		public static readonly BitSet _varDecl12W_in_varDeclW1620 = new BitSet(new ulong[]{0x0010000000000002UL});
		public static readonly BitSet _BEGIN_in_bodyExpr1646 = new BitSet(new ulong[]{0x001000000F8008A0UL,0x0000000000000008UL});
		public static readonly BitSet _bodyOper_in_bodyExpr1649 = new BitSet(new ulong[]{0x001000000F8008A0UL,0x0000000000000008UL});
		public static readonly BitSet _END_in_bodyExpr1652 = new BitSet(new ulong[]{0x0004000000000000UL});
		public static readonly BitSet _OP_END_in_bodyExpr1655 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _BEGIN_in_mainBodyExpr1676 = new BitSet(new ulong[]{0x001000000F8008A0UL,0x0000000000000008UL});
		public static readonly BitSet _bodyOper_in_mainBodyExpr1679 = new BitSet(new ulong[]{0x001000000F8008A0UL,0x0000000000000008UL});
		public static readonly BitSet _END_in_mainBodyExpr1682 = new BitSet(new ulong[]{0x0004000000000000UL});
		public static readonly BitSet _OP_END_in_mainBodyExpr1685 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _funcDeclare_in_func_proc_expr1706 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _procedureDeclare_in_func_proc_expr1708 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _func_proc_expr_in_fpExprW1717 = new BitSet(new ulong[]{0x0000000000000302UL});
		public static readonly BitSet _varDeclW_in_wrapToBody1735 = new BitSet(new ulong[]{0x0000000000000300UL});
		public static readonly BitSet _fpExprW_in_wrapToBody1738 = new BitSet(new ulong[]{0x0000000000000400UL});
		public static readonly BitSet _mainBodyExpr_in_wrapToBody1740 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _PROGRAM_in_expr1766 = new BitSet(new ulong[]{0x0010000000000000UL});
		public static readonly BitSet _VARIABLE_in_expr1768 = new BitSet(new ulong[]{0x0004000000000000UL});
		public static readonly BitSet _OP_END_in_expr1770 = new BitSet(new ulong[]{0x0000000000040300UL});
		public static readonly BitSet _wrapToBody_in_expr1773 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _expr_in_program1793 = new BitSet(new ulong[]{0x0000000000000012UL});
		public static readonly BitSet _program_in_result1802 = new BitSet(new ulong[]{0x0000000000000000UL});
		public static readonly BitSet _EOF_in_result1804 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _result_in_execute1821 = new BitSet(new ulong[]{0x0000000000000002UL});

	}
	#endregion Follow sets
}
}