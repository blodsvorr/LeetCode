using System ;

public class Solution {

  public bool IsBoomerang( int[][] points ) {

		bool isTrue = false ;
		double dividend = points[0][1] - points[1][1] ;
		double divisor = points[0][0] - points[1][0] ;

		 	if ( divisor == 0 ) {
				if ( dividend != 0 ) {
					if ( points[2][0] != points[0][0] )
						isTrue = true ;
				}
			}
			else if ( dividend == 0 ) {
				if ( points[2][1] != points[0][1] )
					isTrue = true ;
			}
			else {
				int x = points[1][0] ;
				int y = points[1][1] ;
				int x1 = points[2][0] ;
				int y1 = points[2][1] ;

				if ( divisor * (y - y1) != dividend * (x - x1) )
					isTrue = true ;
			}

		return isTrue ;

    }  // END ISBOOMERANG METHOD

	// MAIN METHOD FOR TESTING
	public static void Main ( string[] args ) {

		int[][][] arr =
		{
			new int[][]
			{
				new int[]	{1,1},
				new int[] {2,3},
				new int[] {3,2}
			} ,
			new int[][]
			{
				new int[]	{1,1},
				new int[] {2,2},
				new int[] {3,3}
			} ,
			new int[][]
			{
				new int[]	{0,0},
				new int[] {0,2},
				new int[] {2,1}
			} ,
			new int[][]
			{
				new int[]	{0,1},
				new int[] {0,1},
				new int[] {2,1}
			} ,
			new int[][]
			{
				new int[]	{1,0},
				new int[] {1,1},
				new int[] {1,0}
			} ,
			new int[][]
			{
				new int[]	{1,0},
				new int[] {1,2},
				new int[] {0,1}
			} ,
			new int[][]
			{
				new int[]	{75, 76},
				new int[] {19,4},
				new int[] {40,31}
			} ,
		} ;

		Solution s = new Solution() ;

		foreach (  int[][] triad in arr ) {
			foreach ( int[] intArr in triad ) {
				for ( int i = 0 ; i <= 1 ; i++ ) {
					Console.Write( ( i == 0 ) ? "[ " + intArr[i] + " , " : intArr[i] + " ]" ) ;
				}
				Console.Write( "   " ) ;
			}
			Console.WriteLine( "" ) ;
			Console.WriteLine( s.IsBoomerang(triad) ) ;
			Console.WriteLine( "" ) ;
		}

	}  // END MAIN METHOD

}  // END SOLUTION CLASS
