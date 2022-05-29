using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KursLabTRPK.Model;

namespace KursLabTRPK.Controller
{
    public partial class Service_book : Form
    {
        DB db;
        Service_Book service_Book;
        private string user;

        public Service_book(DB db,Service_Book sBook, string user)
        {
            InitializeComponent();
            dateTime.Format = DateTimePickerFormat.Custom;
            dateTime.CustomFormat = "yyyy";
            
            this.db = db;
            service_Book = sBook;
            tbMark.Text = service_Book.car.model;
            dateTime.Value= service_Book.car.year_release;
            tbGosNumber.Text = service_Book.car.state_number;
            tbVINNumber.Text = service_Book.car.VIN_number;
            tbEngine.Text = service_Book.car.engine_capacity.ToString();
            tbMileage.Text = service_Book.car.mileage.ToString();
            tbFIO.Text = service_Book.car_Owner.FIO;
            tbDriveLicense.Text = service_Book.car_Owner.driver_license;
            tbNumberPhone.Text = service_Book.car_Owner.phone_number;
            RefreshTable();
            if (user == "user")
                bAddTO.Visible = false;
            this.user = user;

        }
        //Метод для перерисовки таблицы
        private void RefreshTable()
        {

            int number = 1;
            Table.Rows.Clear();
            service_Book.technical_Inspections.ForEach(TO =>
            {
                switch (TO.TypeTO)
                {
                    case 1:
                        TO.TypeTOtext = "Межсервисное";
                        break;
                    case 2:
                        TO.TypeTOtext = "Годовое";
                        break;
                    case 3:
                        TO.TypeTOtext = "Гарантийное";
                        break;
                }
                Table.Rows.Add(number, TO.mileage, TO.date_event.ToString().Substring(0,10),TO.TypeTOtext,TO.masterFIO);
                number++;
            });
        }
        //Метод для добавления ТО
        private void bAddTO_Click(object sender, EventArgs e)
        {
            Form form = new AddNewTO(db,service_Book);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.Cancel)
                RefreshTable();
        }

        
        //Открытие формы поиска сервисной книжки
        private void toolStripMenuItem_Search_Book_Click(object sender, EventArgs e)
        {
            Form form = new Search_service_book(db,user);
            this.Hide();
            form.ShowDialog();
            DialogResult = DialogResult.OK;
        }
        //Открытие формы просмотра ТО, после двйоного клика по строчке таблицы, интересующего ТО
        private void GetTOHistory(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Table.Rows.Count > 0 && e.RowIndex >= 0)
            {
                var value = e.RowIndex;
                Form form = new History_technical_inspection(service_Book,value);
                form.ShowDialog();
                
                
            }
        }
        //Сформировать акт, используя данные последнего ТО
        private void ToolStripMenuItem_Form_AKT_Click(object sender, EventArgs e)
        {
            int count=service_Book.technical_Inspections.Count();
            if(service_Book.FormAKT(count-1))
                MessageBox.Show("Акт успешно сформирован");
        }
        //Закрыть приложение
        private void Service_book_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
