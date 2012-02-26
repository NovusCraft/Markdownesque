// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using Machine.Specifications;

namespace Markdownesque.Specifications.CompilerSpecs.EmphasisSpecs
{
	[Subject(typeof(Compiler))]
	public class when_paragraph_with_emphasis_containing_line_break_is_compiled : compiler_spec
	{
		static string output;
		Because of = () => output = compiler.Compile(string.Format("Paragraph *with\nemphasis* containing line break."));

		It should_return_html_paragraph_containing_emphasis =
			() => output.ShouldEqual("<p>Paragraph <em>with<br />emphasis</em> containing line break.</p>");
	}
}