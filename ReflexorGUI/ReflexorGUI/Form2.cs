using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics; // ovaj library smo dodali da možemo koristiti "Stopwatch" klasu
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReflexorGUI
{
    public partial class Game1 : Form
    {
        public Game1()
        {
            InitializeComponent();
        }
        long poeni;
        int PojavljivanjaShreka,TickoviOdPritiska,SljedecePojavljivanje;
        bool ShrekJeVidljiv,PrviKlik;
        Random RandomBroj= new Random();
        Stopwatch stoperica = new Stopwatch(); //uvodimo stopericu za preciznije mjerenje vremena

        private void Form2_Load(object sender, EventArgs e)
        {
            //na otvaranje novog prozora, inicijaliziramo brojne varijable
            TickoviOdPritiska = 0;
            PojavljivanjaShreka = 0;
            poeni = 0;
            button1.Text = "KRENI";
            slikaShreka.Hide();
            ShrekJeVidljiv = false;
            PrviKlik = false;
            PojavljivanjaText.Text = "0";
            //random number generator za određivanje sljedeceg povaljivanja slike
            SljedecePojavljivanje = RandomBroj.Next(100, 500);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (!ShrekJeVidljiv && PrviKlik)
            {
                //kažnjavamo klikove dok Shreka nema sa jednom kaznenom sekundom
                poeni += 1000;
                
            }
            else {
                //na točan pritisak resetiramo timere i postavljamo novo random vrijeme do sljedece pojave
                TickoviOdPritiska = 0;
                SljedecePojavljivanje= RandomBroj.Next(100, 500);
                ShrekJeVidljiv = false;
                poeni += stoperica.ElapsedMilliseconds;
                stoperica.Stop(); //zaustavljamo i resetiramo štopericu
                stoperica.Reset();
                if (PojavljivanjaShreka == 10)
                {
                    //nakon 10 klikova na sliku, igra zavrsava
                    Metronom.Stop();
                    MessageBox.Show("Bravo, sve si Shrekove poklikao u " + poeni + " milisekundi"+"\n" + "Tvoje vrijeme reakcije je u prosjeku bilo "+ poeni/10 + " milisekundi", "Igra gotova");
                }
                else
                {
                    slikaShreka.Hide();
                }  
            }
            if (!PrviKlik)
            {
                //na prvi klik samo započinjemo metronom, tj odbrojavamo prvu pojavu slike
                PrviKlik = true;
                Metronom.Start();
            }
            button1.Text = "STISNI KAD VIDIŠ SHREKA";
        }
        private void Metronom_Tick(object sender, EventArgs e)
        {
            TickoviOdPritiska++;
            ScoreBox.Text = poeni.ToString();
            if (!ShrekJeVidljiv && TickoviOdPritiska>=SljedecePojavljivanje){
                //ovdje određujemo kada se slika pojavljuje pomoću pseudorandom generatora
                ShrekJeVidljiv = true;
                slikaShreka.Show();
                stoperica.Start();
                PojavljivanjaShreka++;
                PojavljivanjaText.Text = PojavljivanjaShreka.ToString();
            }
        }

        
    }
}
