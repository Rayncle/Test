using System;
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
    public partial class ЭкранКладовщика : Form
    {
        public ЭкранКладовщика()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form cloth = new Ткани();
            cloth.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form fur = new Фурнитуры();
            fur.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form posmat = new Поступление_материалов();
            posmat.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form vh = new Вход();
            vh.Visible = true;
            this.Close();
        }
    }
}
