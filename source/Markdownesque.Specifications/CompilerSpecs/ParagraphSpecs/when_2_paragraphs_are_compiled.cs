// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using Machine.Specifications;

namespace Markdownesque.Specifications.CompilerSpecs.ParagraphSpecs
{
	[Subject(typeof(Compiler))]
	public class when_2_paragraphs_are_compiled : compiler_spec
	{
		static string output;
		Because of = () => output = compiler.Compile(string.Format("Paragraph 1.\n\nParagraph 2."));

		It should_return_2_html_paragraphs =
			() => output.ShouldEqual("<p>Paragraph 1.</p><p>Paragraph 2.</p>");
	}
}