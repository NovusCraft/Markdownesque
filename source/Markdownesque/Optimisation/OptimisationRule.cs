// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using Markdownesque.Analysis.Tokens;

namespace Markdownesque.Optimisation
{
	internal abstract class OptimisationRule
	{
		internal abstract void Apply(RootToken rootToken);
	}
}