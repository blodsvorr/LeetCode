/**
 * @param {string} a
 * @param {string} b
 * @return {string}
 */
var addBinary = function(a, b) {

	var adder = ( x , y , c ) =>
	{
		var digSum = '0' ;
		if ( ( x ^ y ) ^ c )
			{ digSum = '1' ;}
		var carr = 0 ;
		if ( (x & y) | ( ( (x ^ y) &  c ) ) )
	 		{ carr = 1 ;}
		return { s:digSum , c:carr } ;
	};

	let sum = "" ;
  	let aL = a.length ;
  	let bL = b.length ;

	var diff = Math.abs( aL - bL ) ;
	var leadingZs = "" ;

	if ( diff > 0 )
		{ for ( diff ; diff > 0 ; diff -- )
			{ leadingZs += '0' ;} }
	if ( aL > bL )
		{ b = leadingZs + b ;}
	if ( bL > aL )
		{ a = leadingZs + a ;}

  	let len = a.length ;

  	var carry = 0 ;
	for ( var i = len - 1 ; i >= 0 ; i-- ) {
		var digSumCarry = adder ( ~~a[i] , ~~b[i] , carry ) ;
		sum = digSumCarry['s'] + sum ;
		carry = digSumCarry['c'] ;
	}

	if ( carry === 1 )
		{ sum = '1' + sum ;}

	return sum ;

};

/**
 * @param {string} a
 * @param {string} b
 * @return {string}
 */
/*
var addBinary = function(a, b) {
    return (BigInt("0b"+a) + BigInt("0b"+b)).toString(2);
};
*/
