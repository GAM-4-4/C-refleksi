using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        int poeni,VrijemeOdShreka,PojavljivanjaShreka,VrijemeOdPritiska,SljedecePojavljivanje;
        bool ShrekJeVidljiv,PrviKlik,IgraGotova;
        Random RandomBroj= new Random();
        private void Form2_Load(object sender, EventArgs e)
        {
            //na otvaranje novog prozora, inicijaliziramo brojne varijable
            VrijemeOdPritiska = 0;
            PojavljivanjaShreka = 0;
            poeni = 0;
            button1.Text = "REDI";
            slikaShreka.Hide();
            ShrekJeVidljiv = false;
            PrviKlik = false;
            PojavljivanjaText.Text = "0";
            IgraGotova = false;
            //random number generator za određivanje sljedeceg povaljivanja slike
            SljedecePojavljivanje=RandomBroj.Next(100, 500);
        }

        private void TimerOdShreka_Tick(object sender, EventArgs e)
        {
            //svaki "tick" povećavamo vrijeme od pojavljivanja slike
            /*
            Važna napomena: u C#, timeri nemaju baš pouzdano mjerenje vremena
            Iako bi timeri trebali "tickati" svaku stotinku, treba im ipak nešto više
            Sagledavamo druge opcije mjerenja vremena
            */
            VrijemeOdShreka++;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //zanemarite ovo
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ShrekJeVidljiv && PrviKlik)
            {
                //kažnjavamo klikove dok Shreka nema sa jednom kaznenom sekundom
                poeni += 100;
                
            }
            else {
                //na točan pritisak resetiramo timere i postavljamo novo random vrijeme do sljedece pojave
                VrijemeOdPritiska = 0;
                SljedecePojavljivanje= RandomBroj.Next(100, 500);
                TimerOdShreka.Stop();
                VrijemeOdShreka = 0;
                ShrekJeVidljiv = false;
                if (PojavljivanjaShreka == 10)
                {
                    //nakon 10 klikova na sliku, igra zavrsava
                    IgraGotova = true;
                    TimerOdShreka.Stop();
                    TimerOdPritiska.Stop();
                    MessageBox.Show("Bravo, sve si Shrekove poklikao u " + poeni + " stotinki", "Igra gotova");
                }
                else
                {
                    slikaShreka.Hide();
                }  
            }
            if (!PrviKlik)
            {
                //na prvi klik ništa ne radimo jer tim klikom korisnik samo označuje da je spreman
                PrviKlik = true;
            }
            TimerOdPritiska.Start();
            button1.Text = "STISNI KAD VIDIŠ SHREKA";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            VrijemeOdPritiska++;
            if (ShrekJeVidljiv && !IgraGotova)
            {
                //bodove povećavamo sve dok je slika vidljiva, ali gumb nije stisnut
                poeni++;
            }
            ScoreBox.Text = poeni.ToString();
            if (!ShrekJeVidljiv && VrijemeOdPritiska>=SljedecePojavljivanje){
                //ovdje određujemo kada se slika pojavljuje pomoću pseudorandom generatora
                ShrekJeVidljiv = true;
                slikaShreka.Show();
                TimerOdShreka.Start();
                PojavljivanjaShreka++;
                PojavljivanjaText.Text = PojavljivanjaShreka.ToString();
            }
        }

        
    }
}
