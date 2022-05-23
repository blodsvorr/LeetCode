/**
 * Forward declaration of guess API.
 * @param {number} num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * var guess = function(num) {}
 */

/**
 * @param {number} n
 * @return {number}
 */
var guessNumber = function(n) {
	var min = 1 ;
	var max = n ;
	var focus ;

	while ( max - min >= 0 ) {
    focus = getFocus(min, max) ;
		if ( guess(focus) === 0 ) { return focus ;}
		if ( guess(focus) === 1 ) { min = focus + 1 ;}
		if ( guess(focus) === -1 ) { max = focus - 1 ;}
	}

	return null ;
};

var getFocus = function(min, max) {
	var difference = max - min ;
 	return  min + ( ( difference + difference % 2 ) / 2 ) ;
};
