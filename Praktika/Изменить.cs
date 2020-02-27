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
    public partial class Изменить : Form
    {
        public Model1 db = new Model1();
        public Факт_поступления_материалов rg { get; set; }
        public Изменить()
        {
            InitializeComponent();
        }  

        private void button1_Click(object sender, EventArgs e)
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
                MessageBox.Show("Ошибка");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rg.Номер_поставки = textBox1.Text;
            rg.Закупаемый_материал = textBox2.Text;
            rg.Количество = textBox3.Text;
            rg.Закупочная_цена = textBox4.Text;
            rg.Сумма = textBox5.Text;
            try
            {
                db.SaveChanges();
                MessageBox.Show("Данные успешно изменены");
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Поступление_материалов ф = new Поступление_материалов();
            ф.Show();
        }

        private void Изменить_Load(object sender, EventArgs e)
        {
            textBox1.Text = rg.Номер_поставки;
            textBox2.Text = rg.Закупаемый_материал;
            textBox3.Text = rg.Количество;
            textBox4.Text = rg.Закупочная_цена;
            textBox5.Text = "";
        }
    }
}
