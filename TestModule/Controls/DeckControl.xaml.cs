using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestModule.Controls
{
    /// <summary>
    /// DeckControl.xaml 的交互逻辑
    /// </summary>
    public partial class DeckControl : UserControl
    {
        public DeckControl()
        {
            InitializeComponent();
        }

        private void Button_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
	        if (e.ButtonState == MouseButtonState.Pressed && e.ChangedButton == MouseButton.Right)
	        {
		        e.Handled = true;
	        }
        }
	}
}
