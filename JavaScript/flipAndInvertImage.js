/**
 * @param {number[][]} image
 * @return {number[][]}
 */
var flipAndInvertImage = function(image) {
    let side = image[0].length ;

    for ( var i = 0 ; i < side ; i++ ) {
      let l = 0 ;
      let r = side - 1 ;
      let hold ;

      while ( l < side / 2 ) {
        hold = image[i][l] ;
        image[i][l] = image[i][r] ;
        image[i][r] = hold ;
        l++ ;
        r-- ;
      }
    }

    for ( var i = 0 ; i < side ; i++ ) {
      for ( var j = 0 ; j < side ; j++ ) {
        image[i][j] = 1 - image[i][j] ;
      }
    }

    return image ;
};
