// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using System.Collections.Generic;

namespace Markdownesque.Analysis
{
	internal abstract class Token
	{
		internal Token()
		{
			Children = new List<Token>();
		}

		internal bool Closed { get; set; }
		internal Token Parent { get; private set; }
		internal List<Token> Children { get; private set; }

		internal void AddChild(Token token)
		{
			token.Parent = this;
			Children.Add(token);
		}

		internal void RemoveChild(Token token)
		{
			Children.Remove(token);
		}
	}
}