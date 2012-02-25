// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using System.Collections.Generic;
using System.Linq;
using System.Text;
using Markdownesque.Analysis;
using Markdownesque.Analysis.Tokens;
using Markdownesque.Emit.Renderers;

namespace Markdownesque.Emit
{
	internal sealed class Generator
	{
		readonly List<TokenRenderer> _renderers;

		internal Generator()
		{
			_renderers = new List<TokenRenderer>();
			_renderers.Add(new ParagraphRenderer());
			_renderers.Add(new LiteralRenderer());
			_renderers.Add(new LineBreakRenderer());
			_renderers.Add(new EmphasisRenderer());
		}

		internal string GenerateHtml(RootToken rootToken)
		{
			var renderTarget = new StringBuilder();
			Render(renderTarget, rootToken.Children);

			return renderTarget.ToString();
		}

		internal void Render(StringBuilder renderTarget, List<Token> tokens)
		{
			foreach (var token in tokens)
			{
				var renderer = _renderers.Single(r => r.CanRender(token));

				renderTarget.Append(renderer.RenderOpeningTag(token));
				Render(renderTarget, token.Children);
				renderTarget.Append(renderer.RenderClosingTag(token));
			}
		}

		public override string ToString()
		{
			return string.Format("{0} token renderers", _renderers.Count);
		}
	}
}