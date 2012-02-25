// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using Markdownesque.Analysis;
using Markdownesque.Emit;
using Markdownesque.Optimisation;

namespace Markdownesque
{
	/// <summary>
	/// 	Compiles Markdownesque-formatted content to HTML.
	/// </summary>
	public sealed class Compiler
	{
		readonly Generator _generator;
		readonly Optimiser _optimiser;
		readonly Parser _parser;

		/// <summary>
		/// 	Instantiates <see cref="Compiler" /> .
		/// </summary>
		public Compiler()
		{
			_parser = new Parser();
			_optimiser = new Optimiser();
			_generator = new Generator();
		}

		/// <summary>
		/// 	Compiles Markdownesque-formatted <paramref name="source" /> to HTML.
		/// </summary>
		/// <param name="source"> Markdownesque-formatted content. </param>
		/// <returns> HTML compiled from Markdownesque-formatted <paramref name="source" /> . </returns>
		public string Compile(string source)
		{
			var rootToken = _parser.Parse(source);
			var optimisedRootToken = _optimiser.Optimise(rootToken);

			return _generator.GenerateHtml(optimisedRootToken);
		}
	}
}