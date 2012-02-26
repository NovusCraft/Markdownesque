// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using Machine.Specifications;

namespace Markdownesque.Specifications.CompilerSpecs.ParagraphSpecs
{
	[Subject(typeof(Compiler))]
	public class when_2_paragraphs_separated_by_line_break_are_compiled : compiler_spec
	{
		static string output;
		Because of = () => output = compiler.Compile(string.Format("Paragraph 1.\n\n\nParagraph 2."));

		It should_return_2_html_paragraphs_with_no_connecting_html_line_break =
			() => output.ShouldEqual("<p>Paragraph 1.</p><p>Paragraph 2.</p>");
	}
}