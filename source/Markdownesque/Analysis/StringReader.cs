// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

namespace Markdownesque.Analysis
{
	internal sealed class StringReader
	{
		readonly char[] _source;
		int _position = -1;

		internal StringReader(string source)
		{
			_source = source.ToCharArray();
		}

		internal char CurrentChar
		{
			get { return _source[_position]; }
		}

		internal char NextChar
		{
			get
			{
				var nextCharPosition = _position + 1;
				return nextCharPosition == _source.Length ? '\0' : _source[nextCharPosition];
			}
		}

		internal bool Advance()
		{
			return Advance(1);
		}

		internal bool Advance(int count)
		{
			_position += count;
			return _position != _source.Length;
		}
	}
}