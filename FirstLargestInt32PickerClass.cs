namespace CodinGameSolutions
{
	using System;
	/// <summary>
	/// Picks the first of the Largest Int32 Class
	/// Author: Mark
	/// </summary>
	public sealed class FirstLargestInt32PickerClass : FirstLargestInt32Picker
	{
		public FirstLargestInt32PickerClass()
		{
			this.InitializeComponent();
		}
		public FirstLargestInt32PickerClass(Int32 firstValue)
		{
			this.InitializeComponent();
			this.candidateIndex += 1;
			this.SetIndexAndValue(firstValue);
		}
		#region Public Properties
		#endregion
		public Int32 Value { get; private set; }
		public Int32 ValueIndex { get; private set; }
		#region Public Methods
		#endregion
		public void Compare(Int32 candidateValue)
		{
			this.candidateIndex += 1;

			if (candidateValue > this.Value)
			{
				this.SetIndexAndValue(candidateValue);
			}
		}
		#region Private Methods
		#endregion
		private void InitializeComponent()
		{
			this.candidateIndex = -1;
			this.ValueIndex = -1;
			this.Value = Int32.MinValue;
		}
		public void Reset()
		{
			this.InitializeComponent();
		}
		private void SetIndexAndValue(Int32 newValue)
		{
			this.ValueIndex = this.candidateIndex;
			this.Value = newValue;
		}
		#region Private Fields
		#endregion
		private Int32 candidateIndex;
	}
}
