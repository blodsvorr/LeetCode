/** W I P 
 * @param {number[]} nums
 * @param {number} target
 * @return {number}
 */

let searchInsert = function(nums, target) {
	var min = 0 ;
	var max = nums.length - 1 ;
	var focus ;

	if ( nums.length === 0 ) {
		return 0 ;
	}

	// loop while min and max do not equal each other
	while ( max - min >= 0 ) {
		var difference = max - min ;
		// diff is even, focus set to last index of first half
		// diff is odd, focus set to middle index
		focus = min + (difference + difference % 2 ) / 2 ;

		// target equality check and min / max shifts
		if ( target === nums[focus] ) { return focus ;}
		if ( target < nums[focus] ) { max = focus - 1 ;}
		if ( target > nums[focus] ) { min = focus + 1 ;}
	}

	if ( target > nums[focus] ) {
		// if target between penult and last values of array
		if ( target < nums[focus+1] ) { return 1 ;}
		// if target greater than last value of array
			// if ( focus === nums.length - 1 ) { return nums.length ;}
		return nums.length ;
	}

	if ( target < nums[focus] ) {
		// if target between first and second values of array
		if ( target > nums[focus-1] ) { return nums.length - 1 ;}
		// if target less than first value of array
			// if ( focus === 0 ) { return 0 ;}
		return 0 ;
	}

	//return 0 ;
};

// test FUNCTION FOR TESTING
var test = function() {
	var a_t = [
		[[1,3,5,6], 5, 2] ,
		[[1,3,5,6], 2, 1] ,
		[[1,3,5,6], 7, 4] ,
		[[1,3,5,6], 6, 3] ,
		[[1,3,5], 2, 1] ,
		[[1,3,5], 4, 2] ,
		[[1,3,5], 0, 0] ,
		[[5], 2, 0] ,
		[[5], 5, 0] ,
		[[5], 12, 1] ,
		[[], 2, 0],
		[[1,2,4,6,7], 3, 2]
	] ;

	for ( var i = 0 ; i < a_t.length ; i++ ) {
		var nums = a_t[i][0] ;
		var target = a_t[i][1] ;
		var index_expect = a_t[i][2] ;
		var index_actual = searchInsert( nums, target ) ;
		var numsSTR = "[ " ;
		nums.forEach( el => numsSTR += el + ", " ) ;
		var subLen = numsSTR.length - 4 ;
		numsSTR.length > 2 ? numsSTR.substring( 0, subLen ) : 2 ;
		numsSTR += " ]" ;

		console.log (
			( ( i === 0 ) ? "\n\n___ O U T P U T ___\n\n" : "" )
			+ numsSTR + "       " + target
			+ "\n" + "Index_E:   " + index_expect
			+ "\n" + "Index_A:   " + index_actual + "\n"
			+ ( ( i === a_t.length - 1 ) ? "\n___ E N D _ O U T ___\n" : "" )
		) ;
	}

	return ;
};

test() ;
