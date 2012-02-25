// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

namespace Markdownesque.Analysis
{
	internal abstract class BlockToken : Token
	{
		protected BlockToken(string tagName)
		{
			TagName = tagName;
		}

		internal string TagName { get; private set; }
	}
}