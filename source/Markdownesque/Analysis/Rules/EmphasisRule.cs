// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using System;
using Markdownesque.Analysis.Tokens;

namespace Markdownesque.Analysis.Rules
{
	internal sealed class EmphasisRule : ParserRule
	{
		internal override bool AppliesTo(char character, ref Token parentToken, ref Token previousToken)
		{
			return character == '*';
		}

		internal override bool Apply(char character, ref Token parentToken, ref Token previousToken)
		{
			var previousEmphasisToken = FindAncestorToken(parentToken, token => token is EmphasisToken);
			if (previousEmphasisToken != null && previousEmphasisToken.Closed == false)
			{
				previousToken.Closed = true;
			}
			else
			{
				var token = new EmphasisToken();
				parentToken.AddChild(token);
				parentToken = token;
				previousToken = token;
			}

			return true;
		}

		static Token FindAncestorToken(Token searchTarget, Func<Token, bool> predicate)
		{
			if (predicate(searchTarget))
				return searchTarget;

			return searchTarget.Parent != null ? FindAncestorToken(searchTarget.Parent, predicate) : null;
		}
	}
}