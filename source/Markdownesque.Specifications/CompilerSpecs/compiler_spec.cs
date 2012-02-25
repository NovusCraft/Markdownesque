// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using Machine.Specifications;

namespace Markdownesque.Specifications.CompilerSpecs
{
	public abstract class compiler_spec
	{
		protected static Compiler compiler;

		Establish context = () => compiler = new Compiler();
	}
}