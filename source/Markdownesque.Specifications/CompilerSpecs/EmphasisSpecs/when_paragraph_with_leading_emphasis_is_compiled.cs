// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using Machine.Specifications;

namespace Markdownesque.Specifications.CompilerSpecs.EmphasisSpecs
{
	[Subject(typeof(Compiler))]
	public class when_paragraph_with_leading_emphasis_is_compiled : compiler_spec
	{
		static string output;
		Because of = () => output = compiler.Compile(string.Format("*Paragraph* with leading emphasis."));

		It should_return_html_paragraph_containing_leading_emphasis =
			() => output.ShouldEqual("<p><em>Paragraph</em> with leading emphasis.</p>");
	}
}