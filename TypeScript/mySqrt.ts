function mySqrt(x: number): number {
	var adder = 1 ;
	var square = 0 ;
	var i = 0 ;

	while ( square < x ) {
		square += adder ;
  		adder += 2 ;
  		i ++ ;
	}

	return ( x === square ? i : i - 1 ) ;
};
