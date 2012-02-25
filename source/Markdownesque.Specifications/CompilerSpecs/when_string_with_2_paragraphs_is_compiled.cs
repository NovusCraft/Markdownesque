// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using Machine.Specifications;

namespace Markdownesque.Specifications.CompilerSpecs
{
	[Subject(typeof(Compiler))]
	public class when_string_with_2_paragraphs_is_compiled : compiler_spec
	{
		static string output;
		Because of = () => output = compiler.Compile(string.Format("text1\n\ntext2"));

		It should_return_2_html_paragraphs =
			() => output.ShouldEqual("<p>text1</p><p>text2</p>");
	}
}