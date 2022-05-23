using System ;
using System.Collections.Generic ;

public class Solution {
    public static bool IsValid(string s) {
        bool isValid = true ;
		char[][] parens = {
			new char[] {'(', '{', '['},
			new char[] {')', '}', ']'}
		} ;
		List<int> stack = new List<int>() ;

		for ( int i = 0 ; i < s.Length && isValid ; i++ ) {
			for ( int j = 0 ; j < parens[0].Length ; j++) {
				if ( s[i] == parens[0][j] )
				{
					stack.Add( j ) ;
					break ;
				}
				else if ( s[i] == parens[1][j] ) {
					if ( stack.Count > 0 && stack[stack.Count - 1] == j )
						stack.RemoveAt( stack.Count - 1 ) ;
					else
						isValid = false ;
					break ;
				}
			}
		}
		if ( stack.Count > 0 )
			isValid = false ;

		return isValid ;
    }

	public static void Main (string[] args) {
		Console.WriteLine( IsValid("{{}}[](){{()(([][]))}()}[({}[(())])]") ) ;
		Console.WriteLine( IsValid( "]" ) ) ;
		Console.WriteLine( IsValid( "(([]){}{)}[]" ) ) ;
	}
}
