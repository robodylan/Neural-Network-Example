﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneticAlgorithims
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void clearFood_Click(object sender, EventArgs e)
        {
            Program.foods.Clear();
        }

        private void clearOrgan_Click(object sender, EventArgs e)
        {
            Program.organisms.Clear();
        }
    }
}