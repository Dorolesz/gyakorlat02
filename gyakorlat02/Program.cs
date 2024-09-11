using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlat02
{
	internal class Program
	{


		static void Main(string[] args)
		{
			Dictionary<int, int> monthCounts = new Dictionary<int, int>();

			for (int i = 1; i <= 2; i++)
			{
				monthCounts[i] = 0;
			}

			Ember e1 = new Ember("Jancsi", "1920.02.02", "Erdő széle");
			Ember e2 = new Ember("Juliska", "1922.09.11", "Erdő széle");
			Ember e3 = new Ember("Vasorrú bába", "1887.09.11", "Erdő széle");

            Console.WriteLine(e1);
            Console.WriteLine(e2); 
            Console.WriteLine(e3);

			e1.Nev = "János";
            Console.WriteLine(e1);
            Console.WriteLine(e1.SzulHely);

            Console.WriteLine(e1.GetSzulEv()); //metódusonként hívom
            Console.WriteLine($"{e1.SzulEv}-{e1.SzulHo}");
            Console.WriteLine($"{e1.Nev} életkor: {e1.Eletkor()}");

			//----------------------------------------------------------------------

			Emberek emberek = new Emberek();
			emberek.Add(e1);
			emberek.Add(e2);
			emberek.Add(e3);

            Console.WriteLine(emberek);

            Console.WriteLine("\n--------------------------------------------------");

			Emberek emberek2 = new Emberek("emberek.txt");
            Console.WriteLine(emberek2);




			Console.ReadKey();
		}
	}
}
