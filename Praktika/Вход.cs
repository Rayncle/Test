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
    public partial class Вход : Form
    {
        public static Вход VHOD { get; set; }
        public static Пользователь USER { get; set; }
        public Вход()
        {
            InitializeComponent();

        }
        Model1 db = new Model1();

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Нужно задать логин и пароль!");
                return;
            }

            Пользователь usr = db.Пользователь.Find(textBox1.Text);

            if ((usr != null) && (usr.Пароль == textBox2.Text))
            {

                USER = usr;
                VHOD = this;
                if (usr.Роль == "Директор")
                {
                    ЭкранДиректора dr = new ЭкранДиректора();
                    dr.Visible = true;
                    this.Hide();
                }
                else if (usr.Роль == "Менеджер")
                {
                    ЭкранМенеджера mn = new ЭкранМенеджера();
                    mn.Visible = true;
                    this.Hide();
                }
                else if (usr.Роль == "Заказчик")
                {
                    ЭкранЗаказчика zk = new ЭкранЗаказчика();
                    zk.Visible = true;
                    this.Hide();
                }
                else if (usr.Роль == "Кладовщик")
                {
                    ЭкранКладовщика kl = new ЭкранКладовщика();
                    kl.Visible = true;
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Такого пользователя не существует или неверно введен пароль!");
                textBox2.Text = "";
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Регистрация reg = new Регистрация();
            reg.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Вход_Load(object sender, EventArgs e)
        {

        }
    }
}
