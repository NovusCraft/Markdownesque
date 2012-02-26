// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using Machine.Specifications;

namespace Markdownesque.Specifications.CompilerSpecs
{
	[Subject(typeof(Compiler))]
	public class when_article_is_compiled : compiler_spec
	{
		static readonly string markdown = "Standard paragraph." +
		                                  "\n\n" +
		                                  "\nParagraph with leading line break." +
		                                  "\n\n" +
										  "Paragraph with trailing line break.\n";

		static readonly string html = "<p>Standard paragraph.</p>" +
									  "<p>Paragraph with leading line break.</p>" +
									  "<p>Paragraph with trailing line break.</p>";

		static string output;
		Because of = () => output = compiler.Compile(markdown);

		It should_return_html =
			() => output.ShouldEqual(html);
	}
}