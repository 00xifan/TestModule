using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using TestModule.Vms.TabVms;

namespace TestModule.Vms;

public class MainWindowVm :ObservableObject
{
	private TabInitVm _tabInit;
	private TabUserVm _tabUser;

	public MainWindowVm()
	{
		TabInit = new TabInitVm();
		TabUser = new TabUserVm();
	}

	public TabInitVm TabInit
	{
		get => _tabInit;
		set => SetProperty(ref _tabInit, value);
	}

	public TabUserVm TabUser
	{
		get => _tabUser;
		set => SetProperty(ref _tabUser, value);
	}
}