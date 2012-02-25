// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using Markdownesque.Analysis.Tokens;

namespace Markdownesque.Analysis.Rules
{
	internal sealed class EmphasisRule : ParserRule
	{
		internal override bool AppliesTo(char character, ref Token parentToken, ref Token previousToken)
		{
			return character == '*';
		}

		internal override bool Apply(char character, ref Token parentToken, ref Token previousToken)
		{
			var token = new EmphasisToken();
			parentToken.AddChild(token);
			parentToken = token;
			previousToken = token;

			return true;
		}
	}
}