using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlat02
{
	internal class Ember
	{

		//1. Adattag
		private string nev;
		private string szulDatum;
		private string szulHely;

		//2. konstruktor
		public Ember(string nev, string szulDatum, string szulHely)
		{
			this.nev = nev;
			this.szulDatum = szulDatum;
			this.szulHely = szulHely;
		}
		//3. Property
		public string Nev { get => nev; set => nev = value; }
		public string SzulDatum { get => szulDatum; }
		public string SzulHely { get => szulHely; }
		public int SzulEv

		{
			get
			{
				return int.Parse(this.szulDatum.Substring(0, 4));
			}
		}
		public int SzulHo
		{
			get
			{
				return int.Parse(this.szulDatum.Split('.')[1]);
			}
		}
		public int SzulNap
		{
			get
			{
				return int.Parse(this.szulDatum.Split('.')[2]);
			}
		}

		
		//4. egyéb metódusok

		//szuletési év kell visszaadni--> int
		public int GetSzulEv()
		{
			//string[] reszek = this.szulDatum.Split('.');
			//return int.Parse(reszek[0]);

			//vagy
			//return Convert.ToInt32(this.szulDatum.Split('.')[0]);

			//vagy
			return int.Parse(this.szulDatum.Substring(0, 4));
		}
		public int Eletkor()
		{
			int aktEv = DateTime.Now.Year;
			return aktEv - SzulEv;
		}






		//5. ToString
		public override string ToString()
		{
			return $"{this.nev} {this.szulDatum} {this.szulHely} ";
		}
	}
}
