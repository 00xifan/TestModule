using TestModule.Module.Internal.Base;

namespace TestModule.Module.Coordinator;

public class DeckCoordinator : IDeckCoordinator
{
	private readonly IDeckBusinessChain _deckBusinessChain;

	public DeckCoordinator(IDeckBusinessChain deckBusinessChain)
	{
		_deckBusinessChain = deckBusinessChain;
	}

	#region Implementation of IDeckCoordinator

	public async Task GetInitDeck(object? sender, string deckName) => await _deckBusinessChain.GetInitDeck(this,deckName);

	#endregion
}