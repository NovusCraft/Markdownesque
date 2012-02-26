// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using Machine.Specifications;

namespace Markdownesque.Specifications.CompilerSpecs.LineBreakSpecs
{
	[Subject(typeof(Compiler))]
	public class when_paragraph_with_trailing_line_break_is_compiled : compiler_spec
	{
		static string output;
		Because of = () => output = compiler.Compile(string.Format("Paragraph with trailing line break.\n"));

		It should_return_html_paragraph_not_containing_html_line_break =
			() => output.ShouldEqual("<p>Paragraph with trailing line break.</p>");
	}
}