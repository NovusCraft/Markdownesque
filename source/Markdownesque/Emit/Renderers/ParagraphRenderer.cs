// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using Markdownesque.Analysis;
using Markdownesque.Analysis.Tokens;

namespace Markdownesque.Emit.Renderers
{
	internal sealed class ParagraphRenderer : TokenRenderer
	{
		internal override bool CanRender(Token token)
		{
			return token is ParagraphToken;
		}

		internal override string RenderOpeningTag(Token token)
		{
			return "<p>";
		}

		internal override string RenderClosingTag(Token token)
		{
			return "</p>";
		}
	}
}