// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using System.Linq;
using Markdownesque.Analysis.Tokens;

namespace Markdownesque.Analysis.Rules
{
	internal sealed class LiteralRule : ParserRule
	{
		internal override bool AppliesTo(char character, ref Token parentToken, ref Token previousToken)
		{
			return Configuration.ReservedChars.Contains(character) == false;
		}

		internal override bool Apply(char character, ref Token parentToken, ref Token previousToken)
		{
			var temp = previousToken as LiteralToken;
			if (temp != null)
			{
				temp.AddChar(character);
			}
			else
			{
				var token = new LiteralToken(character);
				parentToken.AddChild(token);
				previousToken = token;
			}

			return true;
		}
	}
}