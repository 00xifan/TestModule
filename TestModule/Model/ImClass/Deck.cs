using TestModule.Model.Interface;

namespace TestModule.Model.ImClass
{
	public class Deck : IDeck
	{
		#region Implementation of IDeck

		public double DeckX { get; set; }
		public double DeckY { get; set; }
		public List<Cell> Cells { get; set; } = new();

		#endregion

	}
}
