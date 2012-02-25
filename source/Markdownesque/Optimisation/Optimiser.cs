// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using System.Collections.Generic;
using Markdownesque.Analysis;
using Markdownesque.Optimisation.Rules;

namespace Markdownesque.Optimisation
{
	internal sealed class Optimiser
	{
		readonly IList<OptimisationRule> _optimisationRules;

		internal Optimiser()
		{
			_optimisationRules = new List<OptimisationRule>();
			_optimisationRules.Add(new LineBreakOptimisationRule());
		}

		internal IList<Token> Optimise(IList<Token> tokens)
		{
			var optimisedTokens = new List<Token>(tokens);

			foreach (var optimisationRule in _optimisationRules)
				optimisationRule.Execute(optimisedTokens);

			return optimisedTokens;
		}
	}
}