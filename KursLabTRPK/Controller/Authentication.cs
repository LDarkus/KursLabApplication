using KursLabTRPK.Controller;
using KursLabTRPK.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursLabTRPK
{
    public partial class Authentication : Form
    {
        private DB db=new DB();
        public Authentication()
        {
            InitializeComponent(); 
        }

        public void bAuthentication_Click(object sender, EventArgs e)
        {

            if (tBLogin.Text.Length!=0 && tBPassword.Text.Length!=0)
            {
                string user = db.getUser(tBLogin.Text, tBPassword.Text);
                if (user != "0")
                {
                    MessageBox.Show("Учетная запись была найдена");
                    DialogResult = DialogResult.OK;
                    Form form = new Search_service_book(db,user);
                    form.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Не верный логин или пароль, попробуйте еще раз!","Ошибка");
                }
            }
            else
            {
                MessageBox.Show("Не все поля были заполнены!", "Ошибка");
            }
            
        }

        public static string Aunt(string login, string password)
        {
            DB db = new DB();
            string i = db.getUser(login, password);
            return i;
        }

        private void tBLogin_TextChanged(object sender, EventArgs e)
        {

        }

        public string txtBoxLogin
        {
            get { return tBLogin.Text; }
            set { tBLogin.Text = value; }
        }

        public string txtBoxPassword
        {
            get { return tBPassword.Text; }
            set { tBPassword.Text = value; }
        }
    }
}
