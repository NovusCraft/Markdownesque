// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using Machine.Specifications;

namespace Markdownesque.Specifications.CompilerSpecs.ParagraphSpecs
{
	[Subject(typeof(Compiler))]
	public class when_paragraph_is_compiled : compiler_spec
	{
		static string output;
		Because of = () => output = compiler.Compile("Plain paragraph.");

		It should_return_html_paragraph =
			() => output.ShouldEqual("<p>Plain paragraph.</p>");
	}
}