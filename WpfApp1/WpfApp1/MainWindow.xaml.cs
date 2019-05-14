using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WpfApp1
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

		private void uxPostalCode_SelectionChanged(object sender, RoutedEventArgs e)
		{
			Regex regex1 = new Regex("^[0-9]{5}$");
			Regex regex2 = new Regex("^[0-9]{5}-[0-9]{4}$");
			Regex regex3 = new Regex("^[A-Z][0-9][A-Z][0-9][A-Z][0-9]$");
			if (regex1.IsMatch(uxPostalCode.Text) || regex2.IsMatch(uxPostalCode.Text) || regex3.IsMatch(uxPostalCode.Text))
			{
				btnSubmit.IsEnabled = true;
			}
			else
			{
				btnSubmit.IsEnabled = false;
			}
		}
	}
}
