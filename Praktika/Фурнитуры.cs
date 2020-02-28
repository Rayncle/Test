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
    public partial class Фурнитуры : Form
    {
        Model1 db = new Model1();
        public Фурнитуры()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Фурнитуры_Load(object sender, EventArgs e)
        {
            фурнитураBindingSource.DataSource = db.Фурнитура.ToList();
        }
    }
}
