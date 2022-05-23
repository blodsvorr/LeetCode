var climbStairs = function(n) {
    var ctr = 0 ;

    function count ( n ) {
        var x = n ;

        if ( x <= 0 )
          { ctr += 0 ;}
        if ( x === 1 || x === 2 )
          { ctr += x ;}
        if ( x > 2 ) {
            count ( x - 1 ) ;
            count ( x - 2 ) ;
        }

        return ;
    };

      count (n) ;

      return ctr ;
};
