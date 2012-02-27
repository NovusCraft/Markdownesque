// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using System;
using System.Linq;

namespace Markdownesque.Analysis
{
	internal abstract class ParserRule
	{
		internal abstract bool AppliesTo(StringReader reader, ref Token parentToken, ref Token previousToken);
		internal abstract bool Apply(StringReader reader, ref Token parentToken, ref Token previousToken);

		protected static Token FindAncestorToken(Token searchTarget, Func<Token, bool> predicate)
		{
			if (predicate(searchTarget))
				return searchTarget;

			return searchTarget.Parent != null ? FindAncestorToken(searchTarget.Parent, predicate) : null;
		}

		protected bool IsReservedCharacter(char currentChar)
		{
			return Configuration.ReservedChars.Contains(currentChar);
		}
	}
}