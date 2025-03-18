using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestModule.Model.ImClass;

namespace TestModule.Model.Interface
{
	public interface IDeck
    {
        double DeckX { get; set; }
        double DeckY { get; set; }
        List<Cell> Cells { get; set; }
        IDeck InitDeck();
    }
}

