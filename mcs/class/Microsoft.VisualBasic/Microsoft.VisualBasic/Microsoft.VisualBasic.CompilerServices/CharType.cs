//
// CharType.cs
//
// Author:
//	Chris J Breisch (cjbreisch@altavista.net)
//	Dennis Hayes (dennish@raytek.com)
//
//	(C) 2002 Chris J Breisch
//	(C) Novell
//
  /* Copyright (c) 2002-2003 Mainsoft Corporation.
  *
  * Permission is hereby granted, free of charge, to any person obtaining a
  * copy of this software and associated documentation files (the "Software"),
  * to deal in the Software without restriction, including without limitation
  * the rights to use, copy, modify, merge, publish, distribute, sublicense,
  * and/or sell copies of the Software, and to permit persons to whom the
  * Software is furnished to do so, subject to the following conditions:
  * 
  * The above copyright notice and this permission notice shall be included in
  * all copies or substantial portions of the Software.
  * 
  * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
  * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
  * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
  * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
  * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
  * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
  * DEALINGS IN THE SOFTWARE.
  */

using System;

namespace Microsoft.VisualBasic.CompilerServices {
	[Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute] 
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)] 
	sealed public class CharType {
		/**
		   * The method converts given object to char by the following logic:
		   * 1. If input object is null - return '\0'
		   * 2. If input object is String - run FromString method 
		   * 3. Otherwise run .NET default conversion - Convert.ToChar
		   * @param value - The object that going to be converted
		   * @return char The char value that converted from the source object
		   * @see system.Convert#ToChar
		   */
		public static char FromObject(Object Value) {
			if (Value == null)
				return '\0';
			if (Value is string)
				return FromString((string)Value);
			//Mainsoft code creates a new execption, but that is just to convert from java execption to .net execption
			return Convert.ToChar(Value);
		}

		/**
		   * The method returns first character of the input string. If input string 
		   * is null or empty return it returns '\0'
		   * @param str - The string that converted to char
		   * @return char The value that extracted from the input string.
		   */
		public static char FromString(string Value) {
			if (Value == null || Value.Length == 0)return '\0';
			return Value.ToCharArray()[0];
		}
	}
}

