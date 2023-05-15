using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Avionika_Si;
using DatabaseAdapter;
using System.Data.SqlClient;

namespace Oborot_SI
{
    public partial class Authorization : Form
    {

        public Authorization()
        {
            InitializeComponent();
            //Width = Screen.PrimaryScreen.Bounds.Width;
            //Height = Screen.PrimaryScreen.Bounds.Height;
        }
        public static string Role = "";
        public int Attestacia;
        public static int Etalon;
        public static int ID_SI;
        public static int periodichnost;


        private void Authoriz_Button_Click(object sender, EventArgs e) //авторизация пользователя
        {
            StartApplication();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            loginBox.Text = Environment.UserName;
        }

        private void Authoriz_Button_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Password_Box_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void passwordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                StartApplication();
            }
        }

        void StartApplication()
        {
            if (Program.DbHelper.CheckUserCredentials(loginBox.Text, passwordBox.Text))
            {
                if (Program.DbHelper.CheckUserActivity(loginBox.Text))
                { 
                
                    MainMenu app = new MainMenu();
                    app.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Вход невозможен. Пользователь отключен.");
                }
            }
            else
            {
                MessageBox.Show("Введен неверный логин или пароль");
            }

        }
    }
}
