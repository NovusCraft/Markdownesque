// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using Markdownesque.Analysis;
using Markdownesque.Analysis.Tokens;

namespace Markdownesque.Emit.Renderers
{
	internal sealed class LiteralRenderer : TokenRenderer
	{
		internal override bool CanRender(Token token)
		{
			return token is LiteralToken;
		}

		internal override string RenderOpeningTag(Token token)
		{
			return ((LiteralToken)token).Content.ToString();
		}

		internal override string RenderClosingTag(Token token)
		{
			return string.Empty;
		}
	}
}