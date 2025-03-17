using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using TestModule.Vms;

namespace TestModule.Controls
{
	public class DeckControlVm : ObservableObject
	{
		private DeckVm _deckProperty;

		public DeckControlVm()
		{
			DeckProperty = new DeckVm();
		}

		public DeckVm DeckProperty
		{
			get => _deckProperty;
			set => SetProperty(ref _deckProperty, value);
		}

		#region Command
		public ICommand DoubleClickCommand { get; set; }

		public ICommand DropCommand { get; set; }

		public ICommand MouseEnterCommand { get; set; }

		public ICommand MouseLeaveCommand { get; set; }

		public ICommand ClickCommand { get; set; }

		public ICommand MouseLeftButtonDownCommand { get; set; }

		public ICommand ReplaceItemCommand { get; set; }

		public ICommand PreviewMouseLeftButtonUp { get; set; }
		#endregion
	}
}
