using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestModule.Model.Interface;

public interface ICell
{
	double CellPositionX { get; set; }
	double CellPositionY { get; set; }
	double CellX { get; set; }
	double CellY { get; set; }
	double CellMarginX { get; set; }
	double CellMarginY { get; set; }
	string CellName { get; set; }
	CellEnum CellEnum { get; set; }
}