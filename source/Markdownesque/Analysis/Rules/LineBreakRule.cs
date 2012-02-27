// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using Markdownesque.Analysis.Tokens;

namespace Markdownesque.Analysis.Rules
{
	internal sealed class LineBreakRule : ParserRule
	{
		internal override bool AppliesTo(StringReader reader, ref Token parentToken, ref Token previousToken)
		{
			return reader.CurrentChar == '\n';
		}

		internal override bool Apply(StringReader reader, ref Token parentToken, ref Token previousToken)
		{
			var token = new LineBreakToken();
			parentToken.AddChild(token);
			previousToken = token;

			return true;
		}
	}
}