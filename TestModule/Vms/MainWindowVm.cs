using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using TestModule.Module.Coordinator;
using TestModule.Module.FrontEnd;
using TestModule.Module.Internal;
using TestModule.Module.Internal.Base;
using TestModule.Vms.TabVms;

namespace TestModule.Vms;

public class MainWindowVm :ObservableObject
{
	private TabInitVm _tabInit;
	private TabUserVm _tabUser;
	private readonly DeckPublisher _deckPublisher;
	private readonly IDeckCoordinator _deckCoordinator;

	public MainWindowVm()
	{
		_deckPublisher = new DeckPublisher();
		_deckCoordinator = new DeckCoordinator(new DeckBusinessChain(_deckPublisher));
		TabInit = new TabInitVm(_deckCoordinator,_deckPublisher);
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