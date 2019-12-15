namespace CodinGameSolutions
{
	using System;
	/// <summary>
	/// Picks the first of the Largest Int32
	/// Author: Mark
	/// </summary>
	public interface FirstLargestInt32Picker
	{
		#region Properties
		#endregion
		Int32 ValueIndex { get; }
		Int32 Value { get; }
		#region Methods
		#endregion
		void Compare(Int32 candidateValue);
		void Reset();
	}
}
