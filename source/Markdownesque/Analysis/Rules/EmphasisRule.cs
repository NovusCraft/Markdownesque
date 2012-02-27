// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using Markdownesque.Analysis.Tokens;

namespace Markdownesque.Analysis.Rules
{
	internal sealed class EmphasisRule : ParserRule
	{
		internal override bool AppliesTo(StringReader reader, ref Token parentToken, ref Token previousToken)
		{
			return reader.CurrentChar == '*' && reader.NextChar != '*';
		}

		internal override bool Apply(StringReader reader, ref Token parentToken, ref Token previousToken)
		{
			var previousEmphasisToken = FindAncestorToken(parentToken, token => token is EmphasisToken);
			if (previousEmphasisToken != null && previousEmphasisToken.Closed == false)
			{
				previousToken.Closed = true;
				parentToken = parentToken.Parent;
				previousToken = previousEmphasisToken;
			}
			else
			{
				var token = new EmphasisToken();
				parentToken.AddChild(token);
				parentToken = token;
				previousToken = token;
			}

			return true;
		}
	}
}