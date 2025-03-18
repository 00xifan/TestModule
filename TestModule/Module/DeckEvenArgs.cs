using TestModule.Model.Interface;

namespace TestModule.Module
{
	public class DeckEvenArgs : EventArgs
    {
        public IDeck Deck { get; }

        public DeckEvenArgs(IDeck deck)
        {
	        Deck = deck;
        }
    }
}
