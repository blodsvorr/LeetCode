function myPow(x: number, n: number): number {
	if ( n === 0 ) { return 1 ;}
	if ( x === 1 ) { return 1 ;}
	if ( x === -1 ) { return ( n % 2 === 0 ? 1 : -1 ) ;}

	var pow = n;
	var ans = x ;
	var ng = ( n < 0 ? true : false )

	if ( ng ) { pow = 0 - n ;}

	for ( pow ; pow > 1 ; pow -- ) { ans *= x ;}

	if ( ng ) { ans = 1/ans ;}

	return ans ;
};
