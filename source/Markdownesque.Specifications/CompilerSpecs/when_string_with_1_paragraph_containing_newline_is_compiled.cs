// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using Machine.Specifications;

namespace Markdownesque.Specifications.CompilerSpecs
{
	[Subject(typeof(Compiler))]
	public class when_string_with_1_paragraph_containing_newline_is_compiled : compiler_spec
	{
		static string output;
		Because of = () => output = compiler.Compile(string.Format("text\nmore text"));

		It should_return_html_paragraph_containing_html_break =
			() => output.ShouldEqual("<p>text<br />more text</p>");
	}
}