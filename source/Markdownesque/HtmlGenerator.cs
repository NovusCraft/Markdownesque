// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using System.Collections.Generic;
using System.Text;
using Markdownesque.Analysis;

namespace Markdownesque
{
	internal sealed class HtmlGenerator
	{
		internal string GenerateHtml(IList<Token> tokens)
		{
			var sb = new StringBuilder();

			foreach (var token in tokens)
				sb.Append(token.Render());

			return sb.ToString();
		}
	}
}