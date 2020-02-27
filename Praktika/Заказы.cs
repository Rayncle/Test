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
    public partial class Заказы : Form
    {
        Model1 db = new Model1();
        public Заказы()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Заказы_Load(object sender, EventArgs e)
        {
            заказBindingSource.DataSource = db.Заказ.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                db.SaveChanges();
                MessageBox.Show("Статус заказа был успешно изменён");
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
