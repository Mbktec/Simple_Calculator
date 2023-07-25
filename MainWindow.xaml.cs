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

namespace Calculator_Desktop
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			int First = Int32.Parse(txbFirstNumber.Text);
			int Second = Int32.Parse(txbTwoNumber.Text);
			lblResult_Som.Content = First + " +" + Second + " = " + (First + Second);
			lblResult_Mul.Content = First + " *" + Second + " = " + (First * Second);
			lblResult_Div.Content = First + " /" + Second + " = " + (First / Second);
		}
	}
}
