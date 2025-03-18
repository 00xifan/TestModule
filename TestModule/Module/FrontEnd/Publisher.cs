using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestModule.Model.ImClass;
using TestModule.Model.Interface;
using TestModule.Module.Internal;
using TestModule.Module.Internal.Base;

namespace TestModule.Module.FrontEnd;
public class DeckPublisher : IDeckPublisher,IDeckEventRaiser
{
	#region Implementation of IDeckPublisher

	public event EventHandler<DeckEvenArgs>? InitDeckGot;

	#endregion

	#region Implementation of IDeckEventRaiser

	public void OnInitDeckGot(object? sender, DeckEvenArgs e)
	{
		InitDeckGot?.Invoke(sender, e);
	}

	#endregion
}