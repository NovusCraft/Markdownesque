// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using System.Collections.Generic;
using Markdownesque.Analysis.Tokens;
using Markdownesque.Optimisation.Rules;

namespace Markdownesque.Optimisation
{
	internal sealed class Optimiser
	{
		readonly IList<OptimisationRule> _rules;

		internal Optimiser()
		{
			_rules = new List<OptimisationRule>();
			_rules.Add(new RemoveRedundantLineBreakRule());
		}

		internal RootToken Optimise(RootToken rootToken)
		{
			foreach (var optimisationRule in _rules)
				optimisationRule.Apply(rootToken);

			return rootToken;
		}

		public override string ToString()
		{
			return string.Format("{0} optimiser rules", _rules.Count);
		}
	}
}