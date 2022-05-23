using System ;
using Exs ;

public class Solution {

    public static string NumberToWords(int num) {

		string[] _0_9 = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"} ;
		string[] _10_19 = {"ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};
		string[] _00_90 = {"", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"};
		string[] _000s = {"hundred", "thousand", "million", "billion"};

		string wordStr = "" ;
		int numHold = num ;
		int grpi = 0 ;

		do {
			int triDigit = numHold % 1000 ;
			int hundreds = triDigit / 100 ;
			int tens = (triDigit % 100) / 10 ;
			int ones = triDigit % 10 ;
			string addStr = "" ;

			if (hundreds > 0) {
				addStr = addStr.AddWord( _0_9[hundreds] ) ;
				addStr = addStr.AddWord( _000s[0] ) ;
			}

			if (tens != 1) {
				addStr = addStr.AddWord( _00_90[tens] ) ;
				if ( ones > 0 )
					addStr = addStr.AddWord ( _0_9[ones] ) ;
				else if ( num == 0 )
					addStr = _0_9[0] ;
			}
			else if (tens == 1)
				addStr = addStr.AddWord ( _10_19[ones] ) ;

			if ( triDigit > 0 && grpi > 0 )
				addStr = addStr.AddWord ( _000s[grpi] ) ;

			wordStr = wordStr.AddWord( addStr, false ) ;
			numHold = numHold / 1000 ;
			grpi ++ ;
		}
		while ( numHold > 0 ) ;

		return titleCase ( wordStr ) ;
	}

	private static string titleCase (string str) {
		int len = str.Length ;
		char[] chars = new char[len] ;
		for (int i = 0 ; i < len ; i++) {
			if ( i == 0 || Char.IsWhiteSpace(str, i-1) )
				chars[i] = Char.ToUpper(str[i]) ;
			else
				chars[i] = str[i] ;
		}
		string tCStr = new string (chars) ;
		return tCStr ;
	}

	public static void Main (string[] args) {
		string word = NumberToWords(100000010) ;
		string words0 = NumberToWords(1203985417) ;
		Console.WriteLine("  ") ;
		Console.WriteLine( word ) ;
		Console.WriteLine( words0 ) ;
		Console.WriteLine("  ") ;
		Console.WriteLine("  ") ;
		return ;
	}
}

namespace Exs {
	public static class Exteni {
		public static string AddWord ( this string str,
									   string word,
									   bool isRtoL = true ) {
			string newStr ;

			if ( !String.IsNullOrEmpty(str) ) {
				if ( !String.IsNullOrEmpty(word) ) {
					if (isRtoL)
						newStr = str + " " + word ;
					else
						newStr = word + " " + str ;
				}
				else
					newStr = str ;
			}
			else {
				if ( String.IsNullOrEmpty(word) )
					newStr = "" ;
				else
					newStr = word ;
			}

			return newStr ;
		}
	}
}
