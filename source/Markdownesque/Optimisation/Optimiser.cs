// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using System.Collections.Generic;
using Markdownesque.Analysis;
using Markdownesque.Analysis.Tokens;

namespace Markdownesque.Optimisation
{
	internal sealed class Optimiser
	{
		readonly IList<OptimisationRule> _rules;

		internal Optimiser()
		{
			_rules = new List<OptimisationRule>();
			_rules.Add(new MultipleLineBreakRule());
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