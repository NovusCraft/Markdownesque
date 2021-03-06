// # Copyright � 2011-2012, Novus Craft
// # All rights reserved. 

using Markdownesque.Analysis.Tokens;

namespace Markdownesque.Analysis.Rules
{
	internal sealed class LiteralRule : ParserRule
	{
		internal override bool AppliesTo(StringReader reader, ref Token parentToken, ref Token previousToken)
		{
			return IsReservedCharacter(reader.CurrentChar) == false;
		}

		internal override bool Apply(StringReader reader, ref Token parentToken, ref Token previousToken)
		{
			var temp = previousToken as LiteralToken;
			if (temp != null)
			{
				temp.AddChar(reader.CurrentChar);
			}
			else
			{
				var token = new LiteralToken(reader.CurrentChar);
				parentToken.AddChild(token);
				previousToken = token;
			}

			return true;
		}
	}
}