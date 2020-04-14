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
        int time;
        bool ShrekJeVidljiv;
        private void Form2_Load(object sender, EventArgs e)
        {
            button1.Text = "REDI";
            slikaShreka.Hide();
            ShrekJeVidljiv = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TimerOdPritiska.Start();
            time = 0;
            button1.Text = "STISNI KAD VIDIŠ SHREKA";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            time += 1;
            label1.Text = time.ToString();
        }

        
    }
}
