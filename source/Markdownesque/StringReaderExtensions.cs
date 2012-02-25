// # Copyright © 2011-2012, Novus Craft
// # All rights reserved. 

using System;
using System.IO;

namespace Markdownesque
{
	public static class StringReaderExtensions
	{
		public static bool EndOfString(this StringReader reader)
		{
			return reader.Peek() == -1;
		}

		public static bool NextCharIs(this StringReader reader, char expectedCharacter)
		{
			return Convert.ToChar(reader.Peek()) == expectedCharacter;
		}

		public static void Advance(this StringReader reader)
		{
			reader.Read(); // advance reader to the next character
		}
	}
}