// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

namespace Markdownesque.Analysis.Tokens
{
	internal sealed class EndBlockToken : BlockToken
	{
		internal EndBlockToken(string tagName) : base(tagName)
		{
		}

		internal override string Render()
		{
			return string.Format("</{0}>", TagName);
		}
	}
}