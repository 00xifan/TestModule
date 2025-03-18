namespace TestModule.Module.Internal.Base;

public interface IDeckPublisher
{
	event EventHandler<DeckEvenArgs> InitDeckGot;
}

public interface IDeckEventRaiser
{
	void OnInitDeckGot(object? sender, DeckEvenArgs e);
}