// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

namespace Markdownesque.Analysis.Tokens
{
	internal sealed class BeginBlockToken : BlockToken
	{
		internal BeginBlockToken(string tagName) : base(tagName)
		{
		}

		internal override string Render()
		{
			return string.Format("<{0}>", TagName);
		}
	}
}