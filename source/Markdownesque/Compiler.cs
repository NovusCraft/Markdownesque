// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using Markdownesque.Analysis;
using Markdownesque.Optimisation;

namespace Markdownesque
{
	public sealed class Compiler
	{
		readonly HtmlGenerator _generator;
		readonly Optimiser _optimiser;
		readonly Parser _parser;

		public Compiler()
		{
			_parser = new Parser();
			_optimiser = new Optimiser();
			_generator = new HtmlGenerator();
		}

		public string Compile(string source)
		{
			var tokens = _parser.Parse(source);
			var optimisedTokens = _optimiser.Optimise(tokens);
			return _generator.GenerateHtml(optimisedTokens);
		}
	}
}