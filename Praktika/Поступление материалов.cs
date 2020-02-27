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
    public partial class Поступление_материалов : Form
    {
        Model1 db = new Model1();
        public Поступление_материалов()
        {
            InitializeComponent();
        }

        private void Поступление_материалов_Load(object sender, EventArgs e)
        {
            фактпоступленияматериаловBindingSource.DataSource = db.Факт_поступления_материалов.ToList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            фактпоступленияматериаловBindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            фактпоступленияматериаловBindingSource.MovePrevious();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Заданы не все данные");
                return;
            }
            Факт_поступления_материалов м = new Факт_поступления_материалов();
            м.Номер_поставки = textBox1.Text;
            м.Закупаемый_материал = textBox2.Text;
            м.Количество = textBox3.Text;
            м.Закупочная_цена = textBox4.Text;
            м.Сумма = textBox5.Text;
            db.Факт_поступления_материалов.Add(м);
            try
            {
                db.SaveChanges();
                MessageBox.Show("Успешно!");
                фактпоступленияматериаловBindingSource.DataSource = db.Факт_поступления_материалов.ToList();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox3.Text);
                double b = Convert.ToDouble(textBox4.Text);
                double g = a * b;
                textBox5.Text = g.ToString();
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click (object sender, EventArgs e)
        {
            Изменить изм = new Изменить();
            Факт_поступления_материалов rg = (Факт_поступления_материалов)фактпоступленияматериаловBindingSource.Current;
            изм.db = db;
            изм.rg = rg;
            DialogResult dr = изм.ShowDialog();
            if (dr == DialogResult.OK)
            {
                фактпоступленияматериаловBindingSource.DataSource = db.Факт_поступления_материалов.ToList();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Факт_поступления_материалов rl = (Факт_поступления_материалов)фактпоступленияматериаловBindingSource.Current;
            DialogResult dr = MessageBox.Show(
                "Вы действительно хотите удалить поставку №" + rl.Номер_поставки.ToString() + "?",
                "Удаление поставки", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                db.Факт_поступления_материалов.Remove(rl);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Поставка успешно удалена");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                фактпоступленияматериаловBindingSource.DataSource = db.Факт_поступления_материалов.ToList();
            }
        }
    }
}
