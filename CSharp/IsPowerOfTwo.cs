public class Solution {
    public bool IsPowerOfTwo(int n) {
        int x = n ;
        bool isPow2 ;
        if ( n == 0 )
          isPow2 = false ;
        else
        {
          while ( x > 0 && x % 2 == 0 )
          {
            x /= 2 ;
          }
          isPow2 = ( x == 0 ) ? true : ( x == 1 ) ? true : false ;
        }
        return isPow2 ;
    }
}
