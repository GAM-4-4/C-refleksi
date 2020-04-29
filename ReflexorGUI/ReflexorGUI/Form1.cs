﻿using System;
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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //na pritisak gumba otvara se novi prozor
            Game1 f2 = new Game1();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Game2 f3 = new Game2();
            f3.ShowDialog();
        }
    }
}
