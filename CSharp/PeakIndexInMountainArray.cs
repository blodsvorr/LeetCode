using System ;

public class Solution {
    public int PeakIndexInMountainArray ( int[] arr ) {
        int left = 0 , right = arr.Length - 1 ;
		return seek_R ( left , right , arr ) ;
    }

	public static int seek_R ( int left , int right , int[] arr ) {
		int mid = left + ( ( right - left ) / 2 ) ;
		if ( arr[mid] > arr[mid-1] && arr[mid] > arr[mid+1] ) {
			return mid ;
		}
		if ( arr[mid+1] > arr[mid] ) {
			return seek_R ( mid , right , arr ) ;
		}
		if ( arr[mid-1] > arr[mid] ) {
			return seek_R ( left , mid , arr ) ;
		}
		return -1 ;
	}

	// MAIN METHOD FOR TESTING
	public static void Main( string[] args ) {
		Solution s = new Solution () ;
		int[][] tests = new int[][] {
			new int[] { 0,1,0 } ,
			new int[] { 0,2,1,0 } ,
			new int[] { 0,10,5,2 } ,
			new int[] { 0,5,10,2 } ,
			new int[] { 55,59,63,99,97,94,84,81,79,66,40,38,33,23,22,21,17,9,7 } ,
			new int[] { 19,24,25,29,34,39,50,51,56,61,67,82,87,88,97,73,72,23 }
		} ;

		for ( int i = 0 ; i < tests.Length ; i++ ) {
			int[] test = tests[i] ;
			Console.WriteLine ( s.PeakIndexInMountainArray ( test ) ) ;
		}

	}
}
