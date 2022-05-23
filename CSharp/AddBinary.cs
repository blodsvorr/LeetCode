public class Solution {
    public string AddBinary(string a, string b) {
    	bool add1, add2 ;
    	char digSum ;
		string sum = "" ;
    	bool carry = false ;

		if ( a == null )
		{
			if ( b == null )
				sum = null ;
			else
				sum = b ;
		}
		else if ( a != null && b == null )
			sum = a ;
		else
		{
			int len = ( a.Length > b.Length ) ? a.Length : b.Length ;

			for ( int i = 0 ; i <= len ; i++ )
			{
				add1 = ( i < a.Length ) ? ( (a[a.Length-1-i] == '1') ? true : false ) : false ;
				add2 = ( i < b.Length ) ? ( (b[b.Length-1-i] == '1') ? true : false ) : false ;

				digSum = ( ( add1 ^ add2 ) ^ carry ) ? '1' : '0' ;
				carry = ( ( ( add1 ^ add2 ) & carry ) | ( add1 & add2 ) ) ? true : false ;

				sum = digSum + sum ;
			}
		}
		if ( sum[0] == '0' )
			sum = sum.Substring(1) ;
		return sum ;
    }

}
