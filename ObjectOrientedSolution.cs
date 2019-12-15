namespace CodinGameSolutions
{
	using System;
	/// <summary>
	/// Object-oriented Solution
	/// Author: Mark
	/// </summary>
	class ObjectOrientedSolution
	{
		public void Main(String[] arguments)
		{
			FirstLargestInt32Picker highestMountainPicker = new FirstLargestInt32PickerClass();
			const Int32 numberOfMountains = 8;
			while (true)
			{
				highestMountainPicker.Reset();
				for (var mountainNumber = 0; mountainNumber < numberOfMountains; mountainNumber++)
				{
					var mountainHeight = Int32.Parse(Console.ReadLine());
					highestMountainPicker.Compare(mountainHeight);
				}
				Console.WriteLine(highestMountainPicker.ValueIndex);
			}
		}
	}
}
