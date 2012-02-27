// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using Markdownesque.Analysis.Tokens;

namespace Markdownesque.Analysis.Rules
{
	internal sealed class StrongRule : ParserRule
	{
		internal override bool AppliesTo(StringReader reader, ref Token parentToken, ref Token previousToken)
		{
			return reader.CurrentChar == '*' && reader.NextChar == '*';
		}

		internal override bool Apply(StringReader reader, ref Token parentToken, ref Token previousToken)
		{
			var previousStrongToken = FindAncestorToken(parentToken, token => token is StrongToken);
			if (previousStrongToken != null && previousStrongToken.Closed == false)
			{
				previousToken.Closed = true;
				parentToken = parentToken.Parent;
				previousToken = previousStrongToken;
			}
			else
			{
				var token = new StrongToken();
				parentToken.AddChild(token);
				parentToken = token;
				previousToken = token;
			}

			reader.Advance();

			return true;
		}
	}
}