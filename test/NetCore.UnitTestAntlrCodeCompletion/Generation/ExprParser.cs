//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from f:\Private\NetCore.AntlrCodeCompletion\test\NetCore.UnitTestAntlrCodeCompletion\Grammar\Expr.g4 by ANTLR 4.7.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Grammar {
using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.1")]
[System.CLSCompliant(false)]
public partial class ExprParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		VAR=1, LET=2, PLUS=3, MINUS=4, MULTIPLY=5, DIVIDE=6, EQUAL=7, OPEN_PAR=8, 
		CLOSE_PAR=9, ID=10, WS=11;
	public const int
		RULE_expression = 0, RULE_assignment = 1, RULE_simpleExpression = 2, RULE_variableRef = 3, 
		RULE_functionRef = 4;
	public static readonly string[] ruleNames = {
		"expression", "assignment", "simpleExpression", "variableRef", "functionRef"
	};

	private static readonly string[] _LiteralNames = {
		null, null, null, "'+'", "'-'", "'*'", "'/'", "'='", "'('", "')'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "VAR", "LET", "PLUS", "MINUS", "MULTIPLY", "DIVIDE", "EQUAL", "OPEN_PAR", 
		"CLOSE_PAR", "ID", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Expr.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static ExprParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public ExprParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public ExprParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}
	public partial class ExpressionContext : ParserRuleContext {
		public AssignmentContext assignment() {
			return GetRuleContext<AssignmentContext>(0);
		}
		public SimpleExpressionContext simpleExpression() {
			return GetRuleContext<SimpleExpressionContext>(0);
		}
		public ExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expression; } }
		public override void EnterRule(IParseTreeListener listener) {
			IExprListener typedListener = listener as IExprListener;
			if (typedListener != null) typedListener.EnterExpression(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IExprListener typedListener = listener as IExprListener;
			if (typedListener != null) typedListener.ExitExpression(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IExprVisitor<TResult> typedVisitor = visitor as IExprVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitExpression(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExpressionContext expression() {
		ExpressionContext _localctx = new ExpressionContext(Context, State);
		EnterRule(_localctx, 0, RULE_expression);
		try {
			State = 12;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case VAR:
			case LET:
				EnterOuterAlt(_localctx, 1);
				{
				State = 10; assignment();
				}
				break;
			case ID:
				EnterOuterAlt(_localctx, 2);
				{
				State = 11; simpleExpression(0);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class AssignmentContext : ParserRuleContext {
		public ITerminalNode ID() { return GetToken(ExprParser.ID, 0); }
		public ITerminalNode EQUAL() { return GetToken(ExprParser.EQUAL, 0); }
		public SimpleExpressionContext simpleExpression() {
			return GetRuleContext<SimpleExpressionContext>(0);
		}
		public ITerminalNode VAR() { return GetToken(ExprParser.VAR, 0); }
		public ITerminalNode LET() { return GetToken(ExprParser.LET, 0); }
		public AssignmentContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_assignment; } }
		public override void EnterRule(IParseTreeListener listener) {
			IExprListener typedListener = listener as IExprListener;
			if (typedListener != null) typedListener.EnterAssignment(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IExprListener typedListener = listener as IExprListener;
			if (typedListener != null) typedListener.ExitAssignment(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IExprVisitor<TResult> typedVisitor = visitor as IExprVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAssignment(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public AssignmentContext assignment() {
		AssignmentContext _localctx = new AssignmentContext(Context, State);
		EnterRule(_localctx, 2, RULE_assignment);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 14;
			_la = TokenStream.LA(1);
			if ( !(_la==VAR || _la==LET) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			State = 15; Match(ID);
			State = 16; Match(EQUAL);
			State = 17; simpleExpression(0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class SimpleExpressionContext : ParserRuleContext {
		public VariableRefContext variableRef() {
			return GetRuleContext<VariableRefContext>(0);
		}
		public FunctionRefContext functionRef() {
			return GetRuleContext<FunctionRefContext>(0);
		}
		public SimpleExpressionContext[] simpleExpression() {
			return GetRuleContexts<SimpleExpressionContext>();
		}
		public SimpleExpressionContext simpleExpression(int i) {
			return GetRuleContext<SimpleExpressionContext>(i);
		}
		public ITerminalNode PLUS() { return GetToken(ExprParser.PLUS, 0); }
		public ITerminalNode MINUS() { return GetToken(ExprParser.MINUS, 0); }
		public ITerminalNode MULTIPLY() { return GetToken(ExprParser.MULTIPLY, 0); }
		public ITerminalNode DIVIDE() { return GetToken(ExprParser.DIVIDE, 0); }
		public SimpleExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_simpleExpression; } }
		public override void EnterRule(IParseTreeListener listener) {
			IExprListener typedListener = listener as IExprListener;
			if (typedListener != null) typedListener.EnterSimpleExpression(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IExprListener typedListener = listener as IExprListener;
			if (typedListener != null) typedListener.ExitSimpleExpression(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IExprVisitor<TResult> typedVisitor = visitor as IExprVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitSimpleExpression(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public SimpleExpressionContext simpleExpression() {
		return simpleExpression(0);
	}

	private SimpleExpressionContext simpleExpression(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		SimpleExpressionContext _localctx = new SimpleExpressionContext(Context, _parentState);
		SimpleExpressionContext _prevctx = _localctx;
		int _startState = 4;
		EnterRecursionRule(_localctx, 4, RULE_simpleExpression, _p);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 22;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,1,Context) ) {
			case 1:
				{
				State = 20; variableRef();
				}
				break;
			case 2:
				{
				State = 21; functionRef();
				}
				break;
			}
			Context.Stop = TokenStream.LT(-1);
			State = 32;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,3,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 30;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,2,Context) ) {
					case 1:
						{
						_localctx = new SimpleExpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_simpleExpression);
						State = 24;
						if (!(Precpred(Context, 4))) throw new FailedPredicateException(this, "Precpred(Context, 4)");
						State = 25;
						_la = TokenStream.LA(1);
						if ( !(_la==PLUS || _la==MINUS) ) {
						ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						State = 26; simpleExpression(5);
						}
						break;
					case 2:
						{
						_localctx = new SimpleExpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_simpleExpression);
						State = 27;
						if (!(Precpred(Context, 3))) throw new FailedPredicateException(this, "Precpred(Context, 3)");
						State = 28;
						_la = TokenStream.LA(1);
						if ( !(_la==MULTIPLY || _la==DIVIDE) ) {
						ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						State = 29; simpleExpression(4);
						}
						break;
					}
					} 
				}
				State = 34;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,3,Context);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public partial class VariableRefContext : ParserRuleContext {
		public ITerminalNode ID() { return GetToken(ExprParser.ID, 0); }
		public VariableRefContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_variableRef; } }
		public override void EnterRule(IParseTreeListener listener) {
			IExprListener typedListener = listener as IExprListener;
			if (typedListener != null) typedListener.EnterVariableRef(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IExprListener typedListener = listener as IExprListener;
			if (typedListener != null) typedListener.ExitVariableRef(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IExprVisitor<TResult> typedVisitor = visitor as IExprVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitVariableRef(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public VariableRefContext variableRef() {
		VariableRefContext _localctx = new VariableRefContext(Context, State);
		EnterRule(_localctx, 6, RULE_variableRef);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 35; Match(ID);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class FunctionRefContext : ParserRuleContext {
		public ITerminalNode ID() { return GetToken(ExprParser.ID, 0); }
		public ITerminalNode OPEN_PAR() { return GetToken(ExprParser.OPEN_PAR, 0); }
		public ITerminalNode CLOSE_PAR() { return GetToken(ExprParser.CLOSE_PAR, 0); }
		public FunctionRefContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_functionRef; } }
		public override void EnterRule(IParseTreeListener listener) {
			IExprListener typedListener = listener as IExprListener;
			if (typedListener != null) typedListener.EnterFunctionRef(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IExprListener typedListener = listener as IExprListener;
			if (typedListener != null) typedListener.ExitFunctionRef(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IExprVisitor<TResult> typedVisitor = visitor as IExprVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFunctionRef(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public FunctionRefContext functionRef() {
		FunctionRefContext _localctx = new FunctionRefContext(Context, State);
		EnterRule(_localctx, 8, RULE_functionRef);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 37; Match(ID);
			State = 38; Match(OPEN_PAR);
			State = 39; Match(CLOSE_PAR);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 2: return simpleExpression_sempred((SimpleExpressionContext)_localctx, predIndex);
		}
		return true;
	}
	private bool simpleExpression_sempred(SimpleExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(Context, 4);
		case 1: return Precpred(Context, 3);
		}
		return true;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\r', ',', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', '\t', 
		'\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x4', '\x6', 
		'\t', '\x6', '\x3', '\x2', '\x3', '\x2', '\x5', '\x2', '\xF', '\n', '\x2', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x5', '\x4', '\x19', '\n', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\a', '\x4', '!', '\n', '\x4', '\f', '\x4', '\xE', 
		'\x4', '$', '\v', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x2', '\x3', '\x6', 
		'\a', '\x2', '\x4', '\x6', '\b', '\n', '\x2', '\x5', '\x3', '\x2', '\x3', 
		'\x4', '\x3', '\x2', '\x5', '\x6', '\x3', '\x2', '\a', '\b', '\x2', '*', 
		'\x2', '\xE', '\x3', '\x2', '\x2', '\x2', '\x4', '\x10', '\x3', '\x2', 
		'\x2', '\x2', '\x6', '\x18', '\x3', '\x2', '\x2', '\x2', '\b', '%', '\x3', 
		'\x2', '\x2', '\x2', '\n', '\'', '\x3', '\x2', '\x2', '\x2', '\f', '\xF', 
		'\x5', '\x4', '\x3', '\x2', '\r', '\xF', '\x5', '\x6', '\x4', '\x2', '\xE', 
		'\f', '\x3', '\x2', '\x2', '\x2', '\xE', '\r', '\x3', '\x2', '\x2', '\x2', 
		'\xF', '\x3', '\x3', '\x2', '\x2', '\x2', '\x10', '\x11', '\t', '\x2', 
		'\x2', '\x2', '\x11', '\x12', '\a', '\f', '\x2', '\x2', '\x12', '\x13', 
		'\a', '\t', '\x2', '\x2', '\x13', '\x14', '\x5', '\x6', '\x4', '\x2', 
		'\x14', '\x5', '\x3', '\x2', '\x2', '\x2', '\x15', '\x16', '\b', '\x4', 
		'\x1', '\x2', '\x16', '\x19', '\x5', '\b', '\x5', '\x2', '\x17', '\x19', 
		'\x5', '\n', '\x6', '\x2', '\x18', '\x15', '\x3', '\x2', '\x2', '\x2', 
		'\x18', '\x17', '\x3', '\x2', '\x2', '\x2', '\x19', '\"', '\x3', '\x2', 
		'\x2', '\x2', '\x1A', '\x1B', '\f', '\x6', '\x2', '\x2', '\x1B', '\x1C', 
		'\t', '\x3', '\x2', '\x2', '\x1C', '!', '\x5', '\x6', '\x4', '\a', '\x1D', 
		'\x1E', '\f', '\x5', '\x2', '\x2', '\x1E', '\x1F', '\t', '\x4', '\x2', 
		'\x2', '\x1F', '!', '\x5', '\x6', '\x4', '\x6', ' ', '\x1A', '\x3', '\x2', 
		'\x2', '\x2', ' ', '\x1D', '\x3', '\x2', '\x2', '\x2', '!', '$', '\x3', 
		'\x2', '\x2', '\x2', '\"', ' ', '\x3', '\x2', '\x2', '\x2', '\"', '#', 
		'\x3', '\x2', '\x2', '\x2', '#', '\a', '\x3', '\x2', '\x2', '\x2', '$', 
		'\"', '\x3', '\x2', '\x2', '\x2', '%', '&', '\a', '\f', '\x2', '\x2', 
		'&', '\t', '\x3', '\x2', '\x2', '\x2', '\'', '(', '\a', '\f', '\x2', '\x2', 
		'(', ')', '\a', '\n', '\x2', '\x2', ')', '*', '\a', '\v', '\x2', '\x2', 
		'*', '\v', '\x3', '\x2', '\x2', '\x2', '\x6', '\xE', '\x18', ' ', '\"',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace Grammar