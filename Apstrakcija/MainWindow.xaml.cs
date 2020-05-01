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

namespace Apstrakcija
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
	}

	public abstract class Osoba
	{
		public string Ime { get; set; }
		public string Prezime { get; set; }

		public string ImeiPrezime { get => $"{Ime} {Prezime}"; }

		public string Email { get; set; }
		public string Tel { get; set; }
		public string Adresa { get; set; }
	}


	public class Radnik : Osoba
	{
		public decimal Plata { get; set; } 
	}

	public class Klijent : Osoba
	{
		public decimal Dug { get; set; }
	}
}
