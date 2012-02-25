// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using Machine.Specifications;

namespace Markdownesque.Specifications.CompilerSpecs
{
	[Subject(typeof(Compiler))]
	public class when_empty_string_is_compiled : compiler_spec
	{
		static string output;
		Because of = () => output = compiler.Compile(string.Empty);

		It should_return_empty_string =
			() => output.ShouldEqual(string.Empty);
	}
}