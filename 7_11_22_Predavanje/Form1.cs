using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_11_22_Predavanje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Posao p1 = new Posao();
            p1.OpisPosla = "pranje prozora";
            p1.PlacaPoSatu = 20.00;
            p1.BrojSati = 4.5;

            Posao p2 = new Posao();
            p2.OpisPosla = "anketiranje";
            p2.PlacaPoSatu = 14.50;
            p2.BrojSati = 8;

            Posao p3 = new Posao();
            p3 = p1 + p2;


            Ispis(p1);
            Ispis(p2);
            Ispis(p3);
             

        }
        void Ispis(Posao p)
        {

            label1.Text += String.Format("\nPosao: {0}, je plaćen {1:C} po satu za {2} sati rada.\nUkupno: {3:C}", p.OpisPosla, p.PlacaPoSatu, p.BrojSati, p.UkupnaPlaca);



        }
    }
}
