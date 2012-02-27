// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

namespace Markdownesque.Analysis.Tokens
{
	internal sealed class StrongToken : Token
	{
		public override string ToString()
		{
			return string.Format("<strong>{0}", Closed ? "</strong>" : string.Empty);
		}
	}
}