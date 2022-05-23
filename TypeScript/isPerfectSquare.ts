function isPerfectSquare(num: number): boolean {
  var adder = 1 ;
  var square = 0 ;

  while ( square < num ) {
    square += adder ;
    adder += 2 ;
  }

  return ( num === square ? true : false ) ;
};
