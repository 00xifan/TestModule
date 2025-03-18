using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestModule.Module.Internal.Base;

public interface IDeckBusinessChain
{
	Task GetInitDeck(object? sender, string deckName);
}