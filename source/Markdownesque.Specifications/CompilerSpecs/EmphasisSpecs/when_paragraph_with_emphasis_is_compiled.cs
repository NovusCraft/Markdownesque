// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using Machine.Specifications;

namespace Markdownesque.Specifications.CompilerSpecs.EmphasisSpecs
{
	[Subject(typeof(Compiler))]
	public class when_paragraph_with_emphasis_is_compiled : compiler_spec
	{
		static string output;
		Because of = () => output = compiler.Compile(string.Format("Paragraph *with* *extra* emphasis."));

		It should_return_html_paragraph_containing_emphasis =
			() => output.ShouldEqual("<p>Paragraph <em>with</em> <em>extra</em> emphasis.</p>");
	}
}