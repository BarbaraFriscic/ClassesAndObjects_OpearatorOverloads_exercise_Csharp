using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _7_11_22_Predavanje
{
    internal class Posao
    {
		public string opisPosla;

		public string OpisPosla
		{
			get { return opisPosla; }
			set { opisPosla = value; }
		}

		public double brojSati;

		public double BrojSati
		{
			get { return brojSati; }
			set { 
				brojSati = value;
				ukupnaPlaca = placaPoSatu * brojSati;
			}

		}
		private double placaPoSatu;

		public double PlacaPoSatu
		{
			get { return placaPoSatu; }
			set { placaPoSatu = value; }
		}
		private double ukupnaPlaca;

		public double UkupnaPlaca
		{
			get { return ukupnaPlaca; }
			
		}
		public static Posao operator +(Posao p1, Posao p2)
		{
			Posao noviPosao = new Posao();
			noviPosao.opisPosla = p1.opisPosla + "i" + p2.opisPosla;
			noviPosao.brojSati = p1.brojSati + p2.brojSati;
			noviPosao.placaPoSatu = (p1.placaPoSatu + p2.placaPoSatu)/2;
			noviPosao.ukupnaPlaca = noviPosao.placaPoSatu * noviPosao.brojSati;
			return noviPosao;
		}




	}
}
