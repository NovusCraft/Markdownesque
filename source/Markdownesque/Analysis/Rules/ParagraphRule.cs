// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using Markdownesque.Analysis.Tokens;

namespace Markdownesque.Analysis.Rules
{
	internal sealed class ParagraphRule : ParserRule
	{
		internal override bool AppliesTo(StringReader reader, ref Token parentToken, ref Token previousToken)
		{
			return previousToken == null || (reader.CurrentChar == '\n' && reader.NextChar == '\n');
		}

		internal override bool Apply(StringReader reader, ref Token parentToken, ref Token previousToken)
		{
			var token = new ParagraphToken();

			if (reader.NextChar == '\n')
			{
				reader.Advance(2);
				parentToken.Parent.AddChild(token);
				parentToken = token;
			}
			else
			{
				parentToken.AddChild(token);
				parentToken = token;
			}

			previousToken = token;
			return false;
		}
	}
}