using TestModule.Model.Interface;

namespace TestModule.Model.ImClass
{
	public class Deck : IDeck
	{
		#region Implementation of IDeck

		public double DeckX { get; set; }
		public double DeckY { get; set; }
		public List<Cell> Cells { get; set; } = new();
		public IDeck InitDeck()
		{
			var initDeck = new Deck
			{
				DeckX = 1400,
				DeckY = 700,
				Cells = new List<Cell>()
			};

			int columns = 5;
			int rows = 5;
			double cellWidth = 200;
			double cellHeight = 100;
			double marginX = 80;
			double marginY = 30;
			double initCellX = 20;
			double initCellY = 20;

			for (int row = 0; row < rows; row++)
			{
				for (int col = 0; col < columns; col++)
				{
					initDeck.Cells.Add(new Cell
					{
						CellX = cellWidth, 
						CellY = cellHeight,  
						CellMarginX = marginX,
						CellMarginY = marginY,
						
						CellName = $"P{row * columns + col + 1}",
						CellEnum = CellEnum.Plate,
						
						CellPositionX = initCellX + col * (cellWidth + marginX),
						CellPositionY = initCellX + row * (cellHeight + marginY)
					});
				}
			}
			return initDeck;
		}

		#endregion

	}
}
