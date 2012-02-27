// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using Machine.Specifications;

namespace Markdownesque.Specifications.CompilerSpecs.StrongSpecs
{
	[Subject(typeof(Compiler))]
	public class when_paragraph_with_strong_containing_emphasis_is_compiled : compiler_spec
	{
		static string output;
		Because of = () => output = compiler.Compile(string.Format("Paragraph ***with* strong** containing emphasis."));

		It should_return_html_paragraph_containing_strong_containing_emphasis =
			() => output.ShouldEqual("<p>Paragraph <strong><em>with</em> strong</strong> containing emphasis.</p>");
	}
}