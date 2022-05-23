public class Solution {
    public int MaxArea(int[] height) {
		int n = height.Length ;
		int a = 0 ;
		int x, y ;

		for ( int i = 0 ; i < n - 1 ; i++ )
		{
			for ( int j = i + 1 ; j < n ; j++ )
			{
				int compare = ( height[i] < height[j] ) ? height[i] : height[j] ;
				int width = j - i ;
				int currA = compare * width ;
				if ( currA > a )
				{
					x = i ;
					y = j ;
					a = currA ;
				}
			}
		}

		return a ;
    }
}
