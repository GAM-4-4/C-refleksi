using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics; //opet zbog stopwatcha
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ReflexorGUI
{
    public partial class Game2 : Form
    {
        // kreiramo random number generatore za poziciju mete
        Random X = new Random();
        Random Y = new Random();
        Stopwatch stoperica = new Stopwatch();
        int KlikoviNaMetu;
        long Vrijeme;
        double DecimalnoVrijeme;
        bool IgraPocela;
        public Game2()
        {
            InitializeComponent();
        }
        
        private void Game2_Load(object sender, EventArgs e)
        {
            KlikoviNaMetu = 0;
            IgraPocela = false;
        }

        private void SlikaMete_Click(object sender, EventArgs e)
        {
            if (!IgraPocela)
            {
                IgraPocela = true;
                stoperica.Start();
                label1.Hide();
                label2.Hide();
                label3.Hide();
            }
            else
            {
                KlikoviNaMetu++;
                if (KlikoviNaMetu >= 50)
                {
                    Vrijeme = stoperica.ElapsedMilliseconds;
                    stoperica.Stop();
                    stoperica.Reset();
                    DecimalnoVrijeme = (double)Vrijeme / (double)1000;
                    SlikaMete.Hide();
                    MessageBox.Show("Bravo, poklikao si sve mete u " + DecimalnoVrijeme + " sekundi","Kraj igre");
                }
            }
            SlikaMete.Location = new Point(X.Next() % 840, Y.Next() % 520);
        }
    }
}
