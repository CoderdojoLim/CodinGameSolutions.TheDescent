namespace CodinGameSolutions
{
	using System;
	/**
	 * The while loop represents the game.
	 * Each iteration represents a turn of the game
	 * where you are given inputs (the heights of the mountains)
	 * and where you have to print an output (the index of the mountain to fire on)
	 * The inputs you are given are automatically updated according to your last actions.
	 **/
	class InitialSkeletonCode
	{
		static void Main(String[] args)
		{
			// game loop
			while (true)
			{
				int maxHeight = 0;
				int maxHeighIndex = 0;
				for (int i = 0; i < 8; i++)
				{
					int mountainH = int.Parse(Console.ReadLine()); // represents the height of one mountain.
					if (mountainH > maxHeight)
					{
						maxHeighIndex = i;
						maxHeight = mountainH;
					}
				}
				// Write an action using Console.WriteLine()
				// To debug: Console.Error.WriteLine("Debug messages...");
				Console.WriteLine(maxHeighIndex); // The index of the mountain to fire on.
			}
		}
		// static int HighestMountainIndex(
	}
}