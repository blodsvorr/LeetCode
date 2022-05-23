using System ;

public class Solution {

  public int ProjectionArea(int[][] grid) {
		int xyT = 0 , xzT = 0 , yzT = 0 , totalA = 0 ;
		int colLenG = 0 , gridLen = grid.Length ;

		foreach ( int[] colArr in grid ) {
			colLenG = Greater ( colLenG , colArr.Length ) ;
			int xzG = 0 ;
			foreach ( int elem in colArr ) {
				if ( elem > 0 )
					xyT ++ ;
				xzG = Greater ( xzG , elem ) ;
				}
			xzT += xzG ;
			}

		int[,] grid2d = new int[ colLenG,gridLen ] ;

		for ( int i = 0 ; i < gridLen ; i++ ) {
			for ( int j = 0 ; j < colLenG ; j++ )
				grid2d[ j,i ] = ( j < grid[i].Length ) ? grid[i][j] : 0 ;
		}

		for ( int i = 0 ; i < colLenG ; i++ ) {
			int yzG = 0 ;
			for ( int j = 0 ; j < gridLen ; j++ ) {
				yzG = Greater ( yzG , grid2d[ i,j ] ) ;
			}
			yzT += yzG ;
		}

		totalA = xyT + xzT + yzT ;

		return totalA ;

  }  // END METHOD ProjectionArea

	private static int Greater ( int n , int comp ) {
		return ( comp > n ) ? comp : n ;
	}  // END METHOD Greater

	public static void Main () {
		Solution s = new Solution () ;
		int[][] arr = {
			new int[] { 2,1 } ,
			new int[] { 0,3,2,4 } ,
			new int[] { 0,0,0,2 } ,
			new int[] { 4,2,3 } ,
		} ;

		s.ProjectionArea( arr ) ;

		return ;
	}  // END METHOD Main

}  // END CLASS Solution
