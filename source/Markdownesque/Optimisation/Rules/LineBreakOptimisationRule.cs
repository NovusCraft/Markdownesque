// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using System.Collections.Generic;
using Markdownesque.Analysis;
using Markdownesque.Analysis.Tokens;

namespace Markdownesque.Optimisation.Rules
{
	/// <summary>
	/// 	Replaces sequence of two or more <see cref="LineBreakToken" /> tokens with end-paragraph + begin-paragraph token pair.
	/// </summary>
	internal sealed class LineBreakOptimisationRule : OptimisationRule
	{
		internal override void Execute(IList<Token> tokens)
		{
			for (var i = 0; i < tokens.Count; i++)
			{
				// count sibling line break tokens
				Token token;
				var siblingLineBreakTokenCount = 0;
				
				do
				{
					var nextTokenIndex = i + siblingLineBreakTokenCount;
					token = nextTokenIndex >= tokens.Count ? null : tokens[nextTokenIndex];
					if (token is LineBreakToken)
						siblingLineBreakTokenCount++;

				} while (token is LineBreakToken);

				if (siblingLineBreakTokenCount > 1)
				{
					// remove sibling line break tokens
					for (int j = 0; j < siblingLineBreakTokenCount; j++)
						tokens.RemoveAt(i);

					// inject begin paragraph token
					tokens.Insert(i, new EndBlockToken(tagName: "p"));

					// inject end paragraph token
					tokens.Insert(i + 1, new BeginBlockToken(tagName: "p"));
				}
			}
		}
	}
}