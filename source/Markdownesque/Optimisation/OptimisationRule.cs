// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using System.Collections.Generic;
using Markdownesque.Analysis;

namespace Markdownesque.Optimisation
{
	internal abstract class OptimisationRule
	{
		internal abstract void Execute(IList<Token> tokens);
	}
}