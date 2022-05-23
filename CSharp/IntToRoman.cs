using System;

public class Solution {
    public static string IntToRoman(int num) {
        int[] mcdu = new int[4] ;
        mcdu[0] = num % 10 ;
        mcdu[1] = (num / 10) % 10 ;
        mcdu[2] = (num / 100) % 10 ;
        mcdu[3] = (num / 1000) % 10 ;
        string roman = "" ;

        string[,] roms = new string[3, 10] {
            {"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"},
            {"", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"},
            {"", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"}
        } ;

        for (int i = mcdu[3] ; i > 0 ; i--) {
            roman += "M" ;
        }

        for (int i1 = 2 ; i1 >= 0 ; i1--) {
            roman += roms[i1,mcdu[i1]] ;
        }

        return roman ;
    }

    public static void Main (string[] args) {
        string test = IntToRoman(2964) ;
        Console.WriteLine(test) ;
        Console.WriteLine("") ;
        Console.WriteLine("") ;
    }

}
