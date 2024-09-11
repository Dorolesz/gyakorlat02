using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlat02
{


	internal class Emberek
	{



	//adattag
	private List<Ember> lista;
		//konstruktor
		public Emberek()
		{
			lista = new List<Ember>();
		}
		public Emberek(string fajlNev)
		{
			lista = new List<Ember>();
			Fajlbeolvasas(fajlNev);
		}

		private void Fajlbeolvasas(string fajlNev)
		{
			try
			{
				StreamReader r = new StreamReader(fajlNev);
				while (!r.EndOfStream)
				{
					string[] sor = r.ReadLine().Split(';');
					string szulIdo = sor[1].Replace('-', '.');
					Ember e = new Ember(sor[0], szulIdo, sor[2]);
					Add(e);
				}


			}
			catch (Exception ex)
			{
			}
		}


		public void Add(Ember ember)
		{
			lista.Add(ember);
		}



		public override string ToString()
		{
			string s = "";
            foreach (Ember ember in lista)
            {
				s += ember + "\n";
            }
            return s;
		}


		//5. feladat
		


	}
}
