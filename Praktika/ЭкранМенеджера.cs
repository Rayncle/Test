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
    public partial class ЭкранМенеджера : Form
    {
        public ЭкранМенеджера()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form izd = new Изделия();
            izd.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form zak = new Заказы();
            zak.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form vh = new Вход();
            vh.Visible = true;
            this.Close();
        }
    }
}
