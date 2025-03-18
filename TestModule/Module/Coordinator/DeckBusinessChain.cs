using TestModule.Model.ImClass;
using TestModule.Module.Internal;
using TestModule.Module.Internal.Base;

namespace TestModule.Module.Coordinator;

public class DeckBusinessChain : IDeckBusinessChain
{
	private readonly IDeckEventRaiser _eventRaiser;
	public DeckBusinessChain(IDeckEventRaiser eventRaiser)
	{
		_eventRaiser = eventRaiser;
	}

	public async Task GetInitDeck(object? sender, string deckName)
	{
		try
		{
			//var deck = new Deck();
			//var initDeck = deck.InitDeck();

			//_eventRaiser.OnInitDeckGot(sender, new DeckEvenArgs(initDeck));
			//await Task.CompletedTask;
			var action = new Action(() =>
			{
				var deck = new Deck();
				var initDeck = deck.InitDeck();

				_eventRaiser.OnInitDeckGot(sender, new DeckEvenArgs(initDeck));
			});

			await Task.Run(action);
		}
		catch (Exception ex)
		{
			Console.WriteLine($"初始化Deck失败: {ex.Message}");
			throw;
		}
	}
}