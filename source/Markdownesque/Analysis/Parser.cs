// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using System.Collections.Generic;
using System.Linq;
using Markdownesque.Analysis.Rules;
using Markdownesque.Analysis.Tokens;

namespace Markdownesque.Analysis
{
	internal sealed class Parser
	{
		readonly List<ParserRule> _rules;

		internal Parser()
		{
			_rules = new List<ParserRule>();
			_rules.Add(new ParagraphRule());
			_rules.Add(new LiteralRule());
			_rules.Add(new LineBreakRule());
			_rules.Add(new EmphasisRule());
			_rules.Add(new StrongRule());
		}

		internal RootToken Parse(string source)
		{
			if (string.IsNullOrEmpty(source))
				return new RootToken();

			var rootToken = new RootToken();
			Token parentToken = rootToken;
			Token previousToken = null;

			var reader = new StringReader(source);
			while (reader.Advance())
			{
				bool evaluationComplete;
				do
				{
					var matchingRule = _rules.First(r => r.AppliesTo(reader, ref parentToken, ref previousToken));
					evaluationComplete = matchingRule.Apply(reader, ref parentToken, ref previousToken);
				} while (evaluationComplete == false);
			}

			return rootToken;
		}

		public override string ToString()
		{
			return string.Format("{0} parser rules", _rules.Count);
		}
	}
}