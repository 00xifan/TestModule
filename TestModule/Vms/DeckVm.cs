using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestModule.Model;
using TestModule.Model.ImClass;

namespace TestModule.Vms;

public class DeckVm : ObservableObject
{
	private double _xLength;
	private double _yLength;
	private ObservableCollection<CellVm> _cellVms = new();

	public DeckVm()
	{
		XLength = 800;
		YLength = 600;
		//初始化CellVms
		CellVms = new()
		{
			new CellVm()
			{
				PositionX = 100,
				PositionY = 60,
				BoxSizeX = 110,
				BoxSizeY = 90,
				X = 100,
				Y=50,
				Name = "p1",
				CellTypeEnum = CellEnum.Plate
			},
			new CellVm()
			{
				PositionX = 100,
				PositionY = 200,
				BoxSizeX = 110,
				BoxSizeY = 90,
				X = 80,
				Y=80,
				Name = "p2",
				CellTypeEnum = CellEnum.Device
			}, 
			
		};
	}

	public double XLength
	{
		get => _xLength;
		set => SetProperty(ref _xLength, value);
	}

	public double YLength
	{
		get => _yLength;
		set => SetProperty(ref _yLength, value);
	}

	public ObservableCollection<CellVm> CellVms
	{
		get => _cellVms;
		set => SetProperty(ref _cellVms, value);
	}
}