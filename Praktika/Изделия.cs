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
    public partial class Изделия : Form
    {
        Model1 db = new Model1();
        public Изделия()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Изделия_Load(object sender, EventArgs e)
        {
            изделиеBindingSource.DataSource = db.Изделие.ToList();
        }
    }
}
