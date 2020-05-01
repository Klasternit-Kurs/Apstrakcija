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

			Radnik a = new Radnik();
			a.Ime = "Pera";
			a.Prezime = "Peric";
			a.Email = "pp@nesto.com";
			a.Tel = "0123456";
			a.Plata = 10000;
			a.AdresaStanovanja = new Adresa();
			a.AdresaStanovanja.Broj = "12";
			a.AdresaStanovanja.Grad = "Neki";
			a.AdresaStanovanja.Ulica = "Neka";
			a.AdresaStanovanja.Postanski = "123";

			Radnik b = new Radnik();
			b.Ime = "Pera";
			b.Prezime = "Peric";
			b.Email = "pp@nesto.com";
			b.Tel = "0123456";
			b.Plata = 10000;
			b.AdresaStanovanja = new Adresa();
			b.AdresaStanovanja.Broj = "12";
			b.AdresaStanovanja.Grad = "Neki";
			b.AdresaStanovanja.Ulica = "Neka";
			b.AdresaStanovanja.Postanski = "123";
			
		}
	}

	public abstract class Osoba
	{
		public string Ime { get; set; }
		public string Prezime { get; set; }

		public string ImeiPrezime { get => $"{Ime} {Prezime}"; }

		public string Email { get; set; }
		public string Tel { get; set; }
		public Adresa AdresaStanovanja { get; set; }
	}

	public class Adresa
	{
		public string Ulica { get; set; }
		public string Broj { get; set; }
		public string Grad { get; set; }
		public string Postanski { get; set; }
	}


	public class Radnik : Osoba
	{
		public decimal Plata { get; set; }

		public override string ToString() => $"{Ime}-{Prezime}-{Plata}";

		public override bool Equals(object obj)
		{
			if (obj is Radnik r && this.Email == r.Email && this.Tel == r.Tel && this.AdresaStanovanja.Equals(r.AdresaStanovanja))
				return true;
			else
				return false;
		}

		public override int GetHashCode() => Email.GetHashCode() * Tel.GetHashCode();
	}

	public class Klijent : Osoba
	{
		public decimal Dug { get; set; }
		public Adresa AdresaDostave { get; set; }
	}
}
