using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace Praktika
{
    public partial class Регистрация : Form
    {
        public Регистрация()
        {
            InitializeComponent();
        }
        Model1 db = new Model1();

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Нужно задать все данные");
                return;
            }
            if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }
            if (comboBox1.Text != "Заказчик")
            {
                MessageBox.Show("Задана неверная роль");
                return;
            }
            Пользователь usr = db.Пользователь.Find(textBox1.Text);
            if (usr != null)
            {
                MessageBox.Show("Пользователь с таким логином уже есть");
                return;
            }
            usr = new Пользователь();
            usr.Логин = textBox1.Text;
            usr.Пароль = textBox2.Text;
            usr.Роль = comboBox1.Text;
            usr.Наименование = textBox5.Text;
            db.Пользователь.Add(usr);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Пользователь " + usr.Логин + " зарегистрирован");
            this.Close();
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Регистрация_Load(object sender, EventArgs e)
        {

        }
    }
}
