using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using TestModule.Controls;
using TestModule.Model;

namespace TestModule.Vms.TabVms;

public class TabInitVm :ObservableObject
{
	private DeckControlVm _initDeckVm;

	public TabInitVm()
	{
		//初始化底板布局
		InitDeckVm = new DeckControlVm();
	}

	public DeckControlVm InitDeckVm
	{
		get => _initDeckVm;
		set => SetProperty(ref _initDeckVm, value);
	}
	
}