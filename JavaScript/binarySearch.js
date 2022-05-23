/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number}
 */

var search = function(nums, target) {
	var r = nums.length - 1 ;
	var l = 0 ;

	return binSearch ( nums, target , r , l ) ;
};

var binSearch = function ( nums, target , r , l ) {
	if ( r >= l ) {
		var mid = l + ( r - l - ( ( (r-l) % 2 === 0 ) ? 0 : 1 ) / 2 ) ;

		if ( nums[mid] === target ) {
			return mid ;
		}
		if ( nums[mid] > target ) {
			return binSearch ( nums, target , mid + 1 , l ) ;
		}
		return binSearch ( nums , target , r , mid - 1 ) ;
	}

	return -1 ;
};
