// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using Machine.Specifications;

namespace Markdownesque.Specifications.CompilerSpecs
{
	[Subject(typeof(Compiler))]
	public class when_string_with_1_paragraph_is_compiled : compiler_spec
	{
		static string output;
		Because of = () => output = compiler.Compile("text");

		It should_return_html_paragraph =
			() => output.ShouldEqual("<p>text</p>");
	}
}