﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika
{
    public partial class ЭкранЗаказчика : Form
    {
        public ЭкранЗаказчика()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form vh = new Вход();
            vh.Visible = true;
            this.Close();
        }
    }
}
