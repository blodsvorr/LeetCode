using System ;
using System.Collections.Generic ;

[Flags]
public enum D {
	N = 1,
	S = 2,
	E = 4,
	W = 8,
	NE = 5,
	NW = 9,
	SE = 6,
	SW = 10
}

public struct Cell {
	private int y ;
	private int x ;

	public Cell ( int y , int x ) {
		this.y = y ;
		this.x = x ;
	}

	public int Y {
		get { return y ;}
		set { y = value ;}
	}
	public int X {
		get { return x ;}
		set { x = value ;}
	}
}

public class Solution {
    public void GameOfLife ( int[][] board ) {
		Stack<int> stack = new Stack<int>() ;

		for ( int i = 0 ; i < board.Length ; i++ ) {
			for ( int j = 0 ; j < board[0].Length ; j++ ) {
				Cell cell = new Cell ( i , j ) ;
				Cell[] neighbors = GetNeighbors ( cell ) ;
				int liveTally = Tally ( board , neighbors ) ;
				int nextGenVal = NextGenVal ( board[i][j] , liveTally ) ;
				stack.Push ( nextGenVal ) ;
			}
		}

		for ( int i = board.Length - 1 ; i >= 0 ; i-- ) {
			for ( int j = board[0].Length - 1 ; j >= 0 ; j-- ) {
				board[i][j] = stack.Pop () ;
			}
		}
    }

	public static Cell GetNeighborYX ( Cell focusCell , D dir ) {
		Cell neighborCell = new Cell ( focusCell.Y , focusCell.X ) ;

		if ( (dir & D.N) == D.N ) { neighborCell.Y-- ;}
		if ( (dir & D.S) == D.S ) { neighborCell.Y++ ;}
		if ( (dir & D.E) == D.E ) { neighborCell.X++ ;}
		if ( (dir & D.W) == D.W ) { neighborCell.X-- ;}

		return neighborCell ;
	}

	public static Cell[] GetNeighbors ( Cell focusCell ) {
		const int NUM_OF_NEIGHBORS = 8 ;
		Cell[] neighbors = new Cell[8] ;
		var directions = Enum.GetValues ( typeof (D) ) ;

		int i = 0 ;
		foreach ( D d in directions ) {
			neighbors[i] = GetNeighborYX ( focusCell , d ) ;
			i++ ;}

		return neighbors ;
	}

	public static int Tally ( int[][] currBoard , Cell[] neighbors ) {
		int alive = 0 ;
		foreach ( Cell c in neighbors ) {
			if ( ( c.Y >= 0 && c.Y < currBoard.Length )
				 && ( c.X >= 0 && c.X < currBoard[0].Length ) )
				{ alive += ( currBoard[c.Y][c.X] == 1 ) ? 1 : 0 ;}
		}
		return alive ;
	}

	public static int NextGenVal ( int focusCellVal , int liveNeighbors ) {
		if ( focusCellVal == 1 ) {
			if ( liveNeighbors == 2 || liveNeighbors == 3 )
				{ return 1 ;}
			if ( liveNeighbors < 2 || liveNeighbors > 3 )
				{ return 0 ;}
		}

		if ( focusCellVal == 0 && liveNeighbors == 3 )
			{ return 1 ;}

		return 0 ;
	}

	public static void Main ( string[] args) {
		Cell c = new Cell ( 4, 8 ) ;
		Console.WriteLine( c.X + "  " + c.Y ) ;
		var NE = (D)5 ;
		Console.WriteLine( NE ) ;

		return ;
	}
}
