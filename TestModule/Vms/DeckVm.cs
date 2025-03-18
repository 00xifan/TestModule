using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestModule.Model;
using TestModule.Model.ImClass;
using TestModule.Model.Interface;

namespace TestModule.Vms;

public class DeckVm : ObservableObject
{
	private double _xLength;
	private double _yLength;
	private ObservableCollection<CellVm> _cellVms = new();

	public DeckVm(IDeck deck)
	{
		XLength = deck.DeckX;
		YLength = deck.DeckY;
		var cells = new ObservableCollection<CellVm>();
		foreach (var cell in deck.Cells)
		{
			cells.Add(new CellVm(cell));
		}
		CellVms = cells;
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