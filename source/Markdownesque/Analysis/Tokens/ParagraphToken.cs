// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

namespace Markdownesque.Analysis.Tokens
{
	internal sealed class ParagraphToken : Token
	{
		public override string ToString()
		{
			return string.Format("<p>{0}", Closed ? "</p>" : string.Empty);
		}
	}
}