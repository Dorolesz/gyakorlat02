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
                Console.WriteLine(ex.Message);
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
		
		public int SzuletettHo(int honap)
		{
			int count = 0;
            foreach (Ember ember in lista)
            {
                if (ember.SzulHo == honap)
                {
					count++;
                }
            }
			return count;
        }

		public double AtlagEletkor()
		{
			int osszesEletkor = 0;
            foreach (Ember ember in lista)
            {
				osszesEletkor += ember.Eletkor();
            }
			return (double)osszesEletkor / lista.Count;
        }

		public double AtlagBMI()
		{
			double osszesBMI = 0;
            foreach (Ember ember in lista)
            {
				osszesBMI += ember.BMI();
            }
			return osszesBMI / lista.Count;
        }


		public string LegfiatalabbEmber()
		{
			Ember legfiatalabb = lista[0];
            foreach (Ember ember in lista)
            {
                if (ember.Eletkor() < legfiatalabb.Eletkor())
                {
                    legfiatalabb = ember;
                }
            }
			return legfiatalabb.Nev;
        }

		public int LegidosebbEmberSorszam()
		{
			int index = 0;
			for (int i = 1; i < lista.Count; i++)
			{
				if (lista[i].Eletkor() > lista[index].Eletkor())
				{
					index = i;
				}
			}
			return index;
		}
	}
}
