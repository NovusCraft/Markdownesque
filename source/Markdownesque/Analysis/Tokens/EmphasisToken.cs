// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

namespace Markdownesque.Analysis.Tokens
{
	internal sealed class EmphasisToken : Token
	{
		public override string ToString()
		{
			return string.Format("<em>{0}", Closed ? "</em>" : string.Empty);
		}
	}
}