// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using Markdownesque.Analysis.Tokens;

namespace Markdownesque.Analysis.Rules
{
	internal sealed class LineBreakRule : ParserRule
	{
		internal override bool AppliesTo(char character, ref Token parentToken, ref Token previousToken)
		{
			return character == '\n';
		}

		internal override bool Apply(char character, ref Token parentToken, ref Token previousToken)
		{
			var token = new LineBreakToken();
			parentToken.AddChild(token);
			previousToken = token;

			return true;
		}
	}
}