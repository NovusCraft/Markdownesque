// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using System;
using System.IO;

namespace Markdownesque.Analysis
{
	internal sealed class TokenCreator
	{
		readonly Func<Token, StringReader, bool> _conditions;
		readonly Func<Token, StringReader, Token> _tokenCreationExpression;

		internal TokenCreator(Func<Token, StringReader, bool> conditions, Func<Token, StringReader, Token> tokenCreationExpression)
		{
			_conditions = conditions;
			_tokenCreationExpression = tokenCreationExpression;
		}

		internal bool MatchesConditions(Token previousToken, StringReader reader)
		{
			return _conditions(previousToken, reader);
		}

		internal Token CreateToken(Token previousToken, StringReader reader)
		{
			return _tokenCreationExpression(previousToken, reader);
		}
	}
}