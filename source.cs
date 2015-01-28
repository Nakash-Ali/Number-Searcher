using System;
using System.IO;

static class Program
{
	static string file = "numbers.csv";
	
	static void Main( )
	{
		StreamReader sr = new StreamReader( file );
		int numOfRows = sr.ReadLine( );
		int numOfCols = sr.ReadLine( );
		int max = 0;
		int min = 0;
		int[] numberArray = new int[ numOfCols ];
				
		while ( ! sr.EndOfStream )
		{
			string line = sr.ReadLine( );
			string[] words = line.Split( ',' );
			
			for ( int j = 0; j < numOfCols; j++ )
			{
				numberArray[ j ] = int.Parse( words[ j ] );
				if ( numberArray[ j ] > max ) max = numberArray [ j ];
				if ( numberArray[ j ] < min ) min = numberArray [ j ];
			}	
		}
		
		Console.WriteLine( "Max: {0}", max );
		Console.WriteLine( "Min: {0}", min );
		
		Console.Write( "Enter number to search: " );
		int searchNumber = int.Parse( Console.ReadLine () );
		int verticalIndex = 0;
		int firstVertical = -1;
		int firstHorizontal = -1;
		int lastVertical = -1;
		int lastHorizontal = -1;
		
		StreamReader sr2 = new StreamReader( file );
		while ( bool run = true | !sr2.EndOfStream )
		{
			string line = sr2.ReadLine( );
			string[] words = line.Split( ',' );
			
			for ( int j = 0; j < numOfCols; j++ )
			{
				numberArray[ j ] = int.Parse( words[ j ] );
				if ( numberArray[ j ] == searchNumber )
				{
					firstVertical = verticalIndex;
					firstHorizontal = j;
					run = false;
				}
			}	
			verticalIndex++
		}
		verticalIndex = 0;
		
		StreamReader sr3 = new StreamReader( file );
		while ( ! sr3.EndOfStream )
		{
			string line = sr3.ReadLine( );
			string[] words = line.Split( ',' );
			
			for ( int j = 0; j < numOfCols; j++ )
			{
				numberArray[ j ] = int.Parse( words[ j ] );
				if ( numberArray[ j ] == searchNumber )
				{
					lastVertical = verticalIndex;
					lastHorizontal = j;
				}
			}	
			verticalIndex++
		}
	}
}	