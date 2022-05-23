using System ;

public class Solution {
	public int Search( int[] nums , int target ) {
		int min = 0, max = nums.Length - 1 ;
		int focus ;

		while ( max - min >= 0 ) {
      	focus = GetFocus( min , max ) ;
			if ( target == nums[focus] ) {return focus ;}
			if ( target < nums[focus] ) {max = focus - 1 ;}
			if ( target > nums[focus] ) {min = focus + 1 ;}
		}

		return -1 ;
	}  // END METHOD Search

	private static int GetFocus ( int min , int max ) {
		const int div = 2 ;
		int difference = max - min ;

		return min + ( difference + difference % div ) / div ;
	}  // END METHOD GetFocus

	// MAIN METHOD FOR TESTING
	public static void Main (string[] args) {
		int[] a0 = { 5 } ;
		int[] a1 = { 2, 5 } ;
		int[] a2 = { -1, 0, 3, 5, 9, 12 } ;
		int t_2 = 2 , t_5 = 5 ;

		Solution s = new Solution() ;

		Console.WriteLine( s.Search( a0 , t_2 ) ) ;
		Console.WriteLine( s.Search( a0 , t_5 ) ) ;
		Console.WriteLine( s.Search( a1 , t_5 ) ) ;
		Console.WriteLine( s.Search( a2 , t_5 ) ) ;
		Console.WriteLine( s.Search( a2 , t_2 ) ) ;

		return ;
	}  // END Main
}  // END CLASS Solution


/*
FIRST WORKING SOLUTION, SLIGHTLY SLOWER
	public int Search( int[] nums , int target ) {
		int min = 0, max = nums.Length - 1 ;
		int focus = GetFocus( min , max ) ;

		if ( target == nums[min] ) {return min ;}
		if ( target == nums[max] ) {return max ;}

		while ( max - min > 1 ) {
			if ( target == nums[focus] ) {return focus ;}
			if ( target < nums[focus] ) {max = focus ;}
			if ( target > nums[focus] ) {min = focus ;}

			focus = GetFocus( min , max ) ;
		}

		return -1 ;
	}
*/
