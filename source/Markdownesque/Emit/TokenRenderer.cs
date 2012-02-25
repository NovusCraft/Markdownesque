// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using Markdownesque.Analysis;

namespace Markdownesque.Emit
{
	internal abstract class TokenRenderer
	{
		internal abstract bool CanRender(Token token);
		internal abstract string RenderOpeningTag(Token token);
		internal abstract string RenderClosingTag(Token token);
	}
}