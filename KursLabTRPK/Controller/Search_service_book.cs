using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KursLabTRPK.Controller;
using KursLabTRPK.Model;

namespace KursLabTRPK.Controller
{
    public partial class Search_service_book : Form
    {
        DB db;
        string user;
        public Search_service_book(DB db,string user)
        {
            InitializeComponent();
            cbCriterion.SelectedIndex = 0;
            this.db = db;
            this.user = user;
            if (user == "user")
                bAddNewBook.Visible = false;

        }
        //Поиск сервисной книжки
        private void bSearch_Book_Click(object sender, EventArgs e)
        {
            if (tbNumber_Book.Text.Length != 0)
            {
                int id = db.SearchServiceBook(cbCriterion.Text, tbNumber_Book.Text);
                if (id!=0)
                {
                    Form form = new Service_book(db,db.GetServiceBook(id),user);
                    this.Hide();
                    form.ShowDialog();
                    tbNumber_Book.Clear();
                    if (form.DialogResult == DialogResult.OK)
                        this.Visible = true;

                }
                else
                {
                    MessageBox.Show("Сервисная книжка не найдена");
                }
            }
            else
            {
                MessageBox.Show("Введите номер книжки!","Ошибка");
            }
        }

        private void Search_service_book_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //Создать новую сервисную книжку
        private void bAddNewBook_Click(object sender, EventArgs e)
        {
            
            Form AddNewServiceBook = new AddNewServiceBook(db,user);
            AddNewServiceBook.ShowDialog();
            this.Hide();
            tbNumber_Book.Clear();
            if (AddNewServiceBook.DialogResult == DialogResult.OK)
                this.Visible = true;
        }

        
    }
}
