// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using Machine.Specifications;

namespace Markdownesque.Specifications.CompilerSpecs.EmphasisSpecs
{
	[Subject(typeof(Compiler))]
	public class when_paragraph_with_trailing_emphasis_is_compiled : compiler_spec
	{
		static string output;
		Because of = () => output = compiler.Compile(string.Format("Paragraph with trailing *emphasis.*"));

		It should_return_html_paragraph_containing_trailing_emphasis =
			() => output.ShouldEqual("<p>Paragraph with trailing <em>emphasis.</em></p>");
	}
}