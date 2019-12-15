namespace CodinGameSolutions
{
	using System;
	/// <summary>
	/// Typical Solution
	/// Author: Mark
	/// </summary>
	class TypicalSolution
	{
		public void Main(String[] arguments)
		{
			while (true)
			{
				var highestMountainIndex = 0;
				var highestMountainHeight = 0; 
				for (var index = 0; index < 8; index++)
				{
					var currentHeight = Int32.Parse(Console.ReadLine());
					if (currentHeight > highestMountainHeight)
					{
						highestMountainHeight = currentHeight;
						highestMountainIndex = index;
					}
				}
				Console.WriteLine(highestMountainIndex); // The index of the mountain to fire on.
			}
		}
	}
}
