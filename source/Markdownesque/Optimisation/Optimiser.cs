// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using System.Collections.Generic;
using Markdownesque.Analysis;
using Markdownesque.Analysis.Tokens;

namespace Markdownesque.Optimisation
{
	internal sealed class Optimiser
	{
		readonly IList<OptimisationRule> _optimisationRules;

		internal Optimiser()
		{
			_optimisationRules = new List<OptimisationRule>();
			_optimisationRules.Add(new MultipleLineBreakRule());
		}

		internal RootToken Optimise(RootToken rootToken)
		{
			foreach (var optimisationRule in _optimisationRules)
				optimisationRule.Apply(rootToken);

			return rootToken;
		}
	}

	internal sealed class MultipleLineBreakRule : OptimisationRule
	{
		internal override void Apply(RootToken rootToken)
		{
			ApplyImpl(rootToken);
		}

		void ApplyImpl(Token rootToken)
		{
			for (int i = 0; i < rootToken.Children.Count; i++)
			{
				//var token = rootToken.Children[i];

				//if (IsLineBreakToken(token))
				//{
				//    var lineBreakTokenCount = 1;
				//    while (IsLineBreakToken(rootToken.Children[i + lineBreakTokenCount]))
				//        lineBreakTokenCount++;
				//}

				//ApplyImpl(token);
			}
		}

		static bool IsLineBreakToken(Token token)
		{
			return false; //return (token is ElementToken) && (token as ElementToken).ElementName == "br";
		}
	}
}