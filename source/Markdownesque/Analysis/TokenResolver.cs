// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Markdownesque.Analysis.Tokens;

namespace Markdownesque.Analysis
{
	internal sealed class TokenResolver
	{
		readonly IList<TokenCreator> _map;

		internal TokenResolver()
		{
			_map = new List<TokenCreator>
			{
				// <p>
				new TokenCreator((previousToken, reader) => previousToken == null,
				                 (previousToken, reader) => new BeginBlockToken(tagName: "p")),
				// </p>
				new TokenCreator((previousToken, reader) => reader.EndOfString(),
				                 (previousToken, reader) => new EndBlockToken(tagName: "p")),
				// <br />
				new TokenCreator((previousToken, reader) => reader.EndOfString() == false && reader.NextCharIs('\n'),
				                 (previousToken, reader) =>
				                 {
				                 	reader.Advance();
				                 	return new LineBreakToken();
				                 }),
				// plain text
				new TokenCreator((previousToken, reader) => previousToken != null && reader.EndOfString() == false,
				                 (previousToken, reader) =>
				                 {
				                 	var sb = new StringBuilder();
				                 	int charCode;
				                 	while ((charCode = reader.Peek()) > -1)
				                 	{
				                 		var character = Convert.ToChar(charCode);

				                 		if (character == '\n')
				                 			break;

				                 		sb.Append(character);
				                 		reader.Advance();
				                 	}

				                 	return new LiteralStringToken(sb.ToString());
				                 })
			};
		}

		internal Token Resolve(Token previousToken, StringReader reader)
		{
			var tokenCreator = _map.First(t => t.MatchesConditions(previousToken, reader));

			return tokenCreator.CreateToken(previousToken, reader);
		}
	}
}