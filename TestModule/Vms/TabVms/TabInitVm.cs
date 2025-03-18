using System.Collections.ObjectModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TestModule.Controls;
using TestModule.Model;
using TestModule.Model.ImClass;
using TestModule.Model.Interface;
using TestModule.Module;
using TestModule.Module.Coordinator;
using TestModule.Module.Internal.Base;

namespace TestModule.Vms.TabVms;

public class TabInitVm :ObservableObject
{
	private DeckControlVm _initDeckVm;
	private readonly IDeckCoordinator _deckCoordinator;
	private readonly IDeckPublisher _deckPublisher;


	public TabInitVm(IDeckCoordinator deckCoordinator, IDeckPublisher deckPublisher)
	{
		_deckCoordinator = deckCoordinator;
		_deckPublisher = deckPublisher;
		AddListen();
	}

	private void AddListen()
	{
		_deckPublisher.InitDeckGot += DeckPublisherOnInitDeckGot;
	}

	private void DeckPublisherOnInitDeckGot(object? sender, DeckEvenArgs e)
	{
		var deck = e.Deck;
		InitDeckVm = new DeckControlVm(deck);
	}

	public DeckControlVm InitDeckVm
	{
		get => _initDeckVm;
		set => SetProperty(ref _initDeckVm, value);
	}

	public ICommand ViewLoadCommand => new RelayCommand(() =>
	{	
		_deckCoordinator.GetInitDeck(this, "底板");
		
	});
}