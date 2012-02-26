// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using Markdownesque.Analysis;
using Markdownesque.Analysis.Tokens;

namespace Markdownesque.Optimisation.Rules
{
	internal sealed class RemoveRedundantLineBreakRule : OptimisationRule
	{
		internal override void Apply(RootToken rootToken)
		{
			ApplyImpl(rootToken);
		}

		void ApplyImpl(Token rootToken)
		{
			for (int i = 0; i < rootToken.Children.Count; i++)
			{
				var token = rootToken.Children[i];

				if (token is LineBreakToken
				    && (
				       	token.Parent.Children.IndexOf(token) == 0
				       	|| token.Parent.Children.IndexOf(token) == token.Parent.Children.Count - 1
				       )
					)
					token.Parent.RemoveChild(token);

				ApplyImpl(token);
			}
		}
	}
}