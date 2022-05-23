function myPow(x: number, n: number): number {
	let base = ( n < 0 ? (1/x) : x ) ;
	let pow = ( n < 0 ? -n : n ) ;

	return fastPow ( base , pow ) ;
};

function fastPow ( base:number , pow:number ) {
	if ( pow === 0 ) { return 1.0 ;}

	let isEven:boolean = ( pow % 2 === 0 ? true : false ) ;
	let halfPow:number = ( isEven ? pow : pow-1 ) / 2  ;
	let half:number = fastPow ( base , halfPow ) ;

 	return half * half * ( isEven ? 1 : base ) ;
};
