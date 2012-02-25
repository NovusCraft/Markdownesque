// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

namespace Markdownesque.Analysis.Tokens
{
	internal sealed class LineBreakToken : Token
	{
		internal override string Render()
		{
			return "<br />";
		}
	}
}