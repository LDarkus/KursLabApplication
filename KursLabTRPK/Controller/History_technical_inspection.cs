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
    public partial class History_technical_inspection : Form
    {
        private Service_Book service_Book;
        private int value; //id выбранного ТО

        public History_technical_inspection(Service_Book service,int value)
        {
            InitializeComponent();
            this.value = value;
            service_Book = service;
            //Заполнение таблицы запчастей
            for (int i = 0; i < service_Book.technical_Inspections[value].waybill.autoparts.Count; i++)
            {
                dataGridView1.Rows.Add(service_Book.technical_Inspections[value].waybill.autoparts[i].name, service_Book.technical_Inspections[value].waybill.autoparts[i].count, service_Book.technical_Inspections[value].waybill.autoparts[i].price);
                
                
            }
            string[] problem;
            problem = service_Book.technical_Inspections[value].waybill.problems.Split(';');
            //Добавляем список проблем
            for (int i = 0; i < problem.Length-1 ; i++)
            {
                dataGridView2.Rows.Add(problem[i]);
                
            }
            tbFIO.Text = service_Book.technical_Inspections[value].masterFIO;
            tbMileage.Text = service_Book.technical_Inspections[value].mileage.ToString();
            dateTime.Value = Convert.ToDateTime(service_Book.technical_Inspections[value].date_event.ToString().Substring(0, 10));
            cbType.SelectedIndex = service_Book.technical_Inspections[value].TypeTO -1;
        }
        //Формирование акта, из данных выбранного ТО
        private void FormingAKT_Click(object sender, EventArgs e)
        {
            if(service_Book.FormAKT(value))
                MessageBox.Show("Акт успешно сформирован");
            else
            {
                MessageBox.Show("Произошла ошибка при формировании");
            }
        }
    }
}
