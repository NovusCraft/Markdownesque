// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using Machine.Specifications;

namespace Markdownesque.Specifications.CompilerSpecs.LineBreakSpecs
{
	[Subject(typeof(Compiler))]
	public class when_paragraph_with_line_breaks_is_compiled : compiler_spec
	{
		static string output;
		Because of = () => output = compiler.Compile(string.Format("Begin paragraph\nbreak\nend paragraph."));

		It should_return_html_paragraph_containing_html_line_breaks =
			() => output.ShouldEqual("<p>Begin paragraph<br />break<br />end paragraph.</p>");
	}
}