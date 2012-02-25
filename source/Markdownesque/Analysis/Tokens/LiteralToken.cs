// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using System.Text;

namespace Markdownesque.Analysis.Tokens
{
	internal sealed class LiteralToken : Token
	{
		internal LiteralToken(char character)
		{
			Content = new StringBuilder();
			AddChar(character);
		}

		internal StringBuilder Content { get; private set; }

		internal void AddChar(char character)
		{
			Content.Append(character);
		}
	}
}