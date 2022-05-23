function peakIndexInMountainArray ( arr:number[] ):number
{
	var lo = 0 ;
	var hi = arr.length - 1 ;

  while ( lo < hi ) {
    var mid = lo + ( (hi-lo) - ( (hi-lo) % 2 === 0 ? 0 : 1 ) ) / 2 ;
    if ( arr[mid] < arr[mid+1] )
      { lo = mid + 1 ;}
    else
      { hi = mid ;}
  }

  return lo ;
};
