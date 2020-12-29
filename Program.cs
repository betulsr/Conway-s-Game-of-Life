using System;
using static System.Console;

namespace Problem3
{
	// Class for GameOfLife
	static class GameOfLife
	{
		// Variable to store the grid
		static int[,] grid = new int[,]
						{
						{ 1, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
						{ 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
						{ 0, 1, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
						{ 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0},
						{ 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
						{ 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0},
						{ 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0},
						{ 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0},
						{ 1, 1, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0},
						{ 1, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
						{ 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0},
						{ 0, 1, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0},
						{ 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0},
						{ 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0},
						{ 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
						{ 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0},
						{ 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
						{ 1, 1, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0},
						{ 1, 1, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
						{ 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
						};
		
		
		// Variable to hold generation number
		static int generation = 1;
		
		// Prints the grid to the user
		public static void PrintGrid()
		{
			// Clears the console

			WriteLine();
			
			// Loop through every element and print it.
			for(int i = 0; i < grid.GetLength(0); i ++)
			{

				for(int j = 0; j < grid.GetLength(1); j ++)
				{
					
					// Designate the left boundary 
					if(j == 0 )
					{
						Write("|");
					}
					
					
					int val = grid[i,j];
					
					if (val == 1)
					{
						Write('#');
					}
					else
					{
						Write(' ');
					}
					
					// Designate the right boundary 
					if(j == grid.GetLength(1) -1)
					{
						Write("|");
					}
					
					
				}
				WriteLine();
			}
			WriteLine();
			WriteLine($"Generation: {generation}");
			WriteLine();
		}
		
		
		// Updates the grid according to GameOfLife ruleset.
		public static void Update()
		{
			// Padded grid to account for boundaries
			int[,] paddedGrid = new int[grid.GetLength(0)+2,grid.GetLength(1)+2];
			
			// New grid to be populated in the next generation
			int[,] newGrid = new int[grid.GetLength(0),grid.GetLength(1)];
			
			
			// Create a padded version of the grid, copy the data from the old grid to the padded one.
			for(int i = 1; i < paddedGrid.GetLength(0)-1; i ++)
			{
				for(int j = 1; j < paddedGrid.GetLength(1)-1; j ++)
				{
					paddedGrid[i,j] = grid[i-1,j-1];

				}
			}
			
			// Search every element in the grid
			for(int i = 0; i < grid.GetLength(0); i ++)
			{
				for(int j = 0; j < grid.GetLength(1); j ++)
				{
					
					// Check the status of each element
					int statusOfCell = grid[i,j];
					
					
					int numOfNeighbours = 0;
					
					// For each element, consider a neighbourhood and count the number of 1's in that neighbourhood
					for(int ni = -1; ni < 2; ni ++)
					{
						for(int nj = -1; nj < 2; nj ++)
						{


							// Don't want to consider the central element in the neighbourhood
							if (!(ni == 0 && nj == 0))
							{

								numOfNeighbours += paddedGrid[i+ni+1, j +nj + 1];
							}
						}
					}
					
					
					// Update the status of the new grid according to the rules of the game.
					if (statusOfCell == 1)
					{
						if (numOfNeighbours == 2 || numOfNeighbours == 3)
						{
							newGrid[i,j ] = 1;
						}
						else
						{
							newGrid[i,j ] = 0;
						}
					}
					else
					{
						if (numOfNeighbours == 3)
						{
							newGrid[i,j ] = 1;
						}
						else
						{
							newGrid[i,j ] = 0;
						}
					}
					
					
					
					
				}
			}
			
			// Assign the grid variable to the new grid and increment the generation variable.
			grid = newGrid;
			generation ++;
		}
		
	}
		
		
    class Program
    {

        static void Main(string[] args)
        {
			// Clear the console
			Clear();
			
			// Print the grid to the user.
			GameOfLife.PrintGrid();
			
			// Print some instructions
			WriteLine("Press ENTER for newer generation");
			// Update the grid everytime the user hits enter.
			while(ReadLine() == "")
			{
				// Update the board for next generation
				GameOfLife.Update();
				
				// Clear the console
				Clear();
				
				// Print the board again
				GameOfLife.PrintGrid();
				
				// Print some instruction
				WriteLine("Press ENTER for newer generation");
			}
            
        }
    }
}
