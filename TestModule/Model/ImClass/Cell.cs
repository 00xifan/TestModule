using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestModule.Model.Interface;

namespace TestModule.Model.ImClass;

public class Cell : ICell
{
	#region Implementation of ICell
	public double CellPositionX { get; set; }
	public double CellPositionY { get; set; }
	public double CellX { get; set; }
	public double CellY { get; set; }
	public double CellMarginX { get; set; }
	public double CellMarginY { get; set; }
	public string CellName { get; set; }
	public CellEnum CellEnum { get; set; }

	#endregion
}