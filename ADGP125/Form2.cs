﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADGP125
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Enemy_Click(object sender, EventArgs e)
        {

        }

        private void CombatButton_Click(object sender, EventArgs e)
        {
            HealthLabel state = new HealthLabel();
            this.Hide();
            state.Show();
        }
    }
}
