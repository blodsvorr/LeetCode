function searchInsert ( nums:number[] , target:number ): number
{
	var left:number = 0 ;
	var right:number = nums.length - 1 ;

	while ( right - left > 1 )
	{
		var mid:number = getMid ( left , right ) ;
		if ( nums[mid] === target )
			{ return  mid ;}
		if ( nums[mid] > target )
			{ right = mid ;}
		if ( nums[mid] < target )
			{ left = mid ;}
	}

	if ( target === nums[left] )
		{ return  left ;}
	if ( target === nums[right] )
		{ return  right ;}
	if ( target < nums[left] && target < nums[right] )
		{ return  0 ;}
	if ( target > nums[left] && target > nums[right] )
		{ return  nums.length ;}
	if ( target > nums[left] && target < nums[right] )
		{ return  right ;}

	function getMid ( left:number , right:number ): number
	{
		var diff:number = right - left ;
		var addend:number = ( diff % 2 === 0 ? 0 : 1 ) ;
		return  left + ( ( diff + addend ) / 2 ) ;
	};
};
