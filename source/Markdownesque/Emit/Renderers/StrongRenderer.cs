// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using Markdownesque.Analysis;
using Markdownesque.Analysis.Tokens;

namespace Markdownesque.Emit.Renderers
{
	internal sealed class StrongRenderer : TokenRenderer
	{
		internal override bool CanRender(Token token)
		{
			return token is StrongToken;
		}

		internal override string RenderOpeningTag(Token token)
		{
			return "<strong>";
		}

		internal override string RenderClosingTag(Token token)
		{
			return "</strong>";
		}
	}
}