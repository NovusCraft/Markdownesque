// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using Markdownesque.Analysis.Tokens;

namespace Markdownesque.Analysis.Rules
{
	internal sealed class ParagraphRule : ParserRule
	{
		internal override bool AppliesTo(char character, ref Token parentToken, ref Token previousToken)
		{
			return previousToken == null || (previousToken is LineBreakToken && character == '\n');
		}

		internal override bool Apply(char character, ref Token parentToken, ref Token previousToken)
		{
			var token = new ParagraphToken();

			if (previousToken is LineBreakToken && character == '\n')
			{
				// remove existing LineBreakToken
				parentToken.RemoveChild(previousToken);

				parentToken.Parent.AddChild(token);
				parentToken = token;
				previousToken = token;
				return true;
			}

			parentToken.AddChild(token);
			parentToken = token;
			previousToken = token;
			return false;
		}
	}
}