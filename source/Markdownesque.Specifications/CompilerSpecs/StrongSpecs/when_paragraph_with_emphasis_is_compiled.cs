// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using Machine.Specifications;

namespace Markdownesque.Specifications.CompilerSpecs.StrongSpecs
{
	[Subject(typeof(Compiler))]
	public class when_paragraph_with_strong_is_compiled : compiler_spec
	{
		static string output;
		Because of = () => output = compiler.Compile(string.Format("Paragraph **with** **extra** strong."));

		It should_return_html_paragraph_containing_strong =
			() => output.ShouldEqual("<p>Paragraph <strong>with</strong> <strong>extra</strong> strong.</p>");
	}
}