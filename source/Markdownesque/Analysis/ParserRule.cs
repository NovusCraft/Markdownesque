// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

namespace Markdownesque.Analysis
{
	internal abstract class ParserRule
	{
		internal abstract bool AppliesTo(char character, ref Token parentToken, ref Token previousToken);
		internal abstract bool Apply(char character, ref Token parentToken, ref Token previousToken);
	}
}