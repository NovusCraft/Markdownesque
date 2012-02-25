// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

namespace Markdownesque.Analysis.Tokens
{
	internal sealed class LiteralStringToken : Token
	{
		readonly string _content;

		internal LiteralStringToken(string content)
		{
			_content = content;
		}

		internal override string Render()
		{
			return _content;
		}
	}
}