// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using System.Collections.Generic;
using System.IO;
using Markdownesque.Analysis.Tokens;

namespace Markdownesque.Analysis
{
	internal sealed class Parser
	{
		readonly TokenResolver _tokenResolver;

		internal Parser()
		{
			_tokenResolver = new TokenResolver();
		}

		internal IList<Token> Parse(string source)
		{
			if (string.IsNullOrEmpty(source))
				return new List<Token>();

			var tokens = new List<Token>();
			Token previousToken = null;

			using (var reader = new StringReader(source))
			{
				do
				{
					var token = _tokenResolver.Resolve(previousToken, reader);
					tokens.Add(token);
					previousToken = token;
				} while (reader.EndOfString() == false || (previousToken is EndBlockToken) == false);
			}

			return tokens;
		}
	}
}