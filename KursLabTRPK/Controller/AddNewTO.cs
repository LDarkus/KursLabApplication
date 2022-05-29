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

namespace KursLabTRPK.Controller
{
    public partial class AddNewTO : Form
    {
        Service_Book service_Book;
        //Конструктор который на вход получает бд и найденную сервисную книжку
        public AddNewTO(DB db,Service_Book service)
        {
            InitializeComponent();
            this.db = db;
            service_Book = service;
            cbType.SelectedIndex = 0;
        }
        private DB db;
        //Добавление нового ТО 
        private void Add_new_TO_Click(object sender, EventArgs e)
        {
            //Проверка на заполненность всех полей
            int countTextbox = 0;
            foreach (Control t in this.Controls)
            {
                if (t is CueTextBox && t.Text.Length == 0) 
                {
                    countTextbox++;
                }
            }
            //Если пустых полей не найденно, то добавить новое ТО
            if (countTextbox == 0)
            {
                
                int Price = 0;
                Technical_inspection technical_Inspection = new Technical_inspection(db.GetIdTechical_insp()+1,service_Book.id,dateTime.Value,cbType.SelectedIndex+1,Convert.ToInt32(tbMileage.Text),tbFIO.Text,new Waybill(0,0,""));
                technical_Inspection.TypeTOtext = cbType.Text;
                List<Autopart> autoparts = new List<Autopart>();
                string problems = "";
                List<string> problem = new List<string>();
                //Добавляем список запчастей
                for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                {
                    autoparts.Add(new Autopart(-1,(dataGridView1[0, i].Value.ToString()), Convert.ToInt32((dataGridView1[1, i].Value.ToString())), 
                        Convert.ToInt32((dataGridView1[2, i].Value.ToString()))));
                    Price += Convert.ToInt32(dataGridView1[2, i].Value.ToString())
                        * Convert.ToInt32(dataGridView1[1, i].Value.ToString());
                }
                //Добавляем список проблем
                for (int i = 0; i < dataGridView2.Rows.Count-1; i++)
                {
                    problems += dataGridView2[0, i].Value.ToString() ;
                    problems+= i == (dataGridView2.Rows.Count - 2) ? "": ";";



                problems += ";";
                   
                    problem.Add(dataGridView2[0, i].Value.ToString());
                    //Первый столбец датагрида в лист
                }
                technical_Inspection.waybill = new Waybill(db.GetIdWaybill()+1,Price,problems);
                technical_Inspection.waybill.problem_name = problem;
                technical_Inspection.waybill.problems = problems;
                technical_Inspection.waybill.autoparts = autoparts;
                db.Add_Techical_insp(technical_Inspection);
                service_Book.technical_Inspections.Add(technical_Inspection);
                MessageBox.Show("Технический осмотр был успешно добавлен");
                foreach (Control t in this.Controls)
                {
                    if (t is CueTextBox )
                    {
                        t.Text = "";
                    }
                }
                
                DialogResult = DialogResult.Cancel;
                this.Close();

            }
            else
            {
                MessageBox.Show($"Не все поля были заполенны ", "Ошибка");
            }
        }
    }
}
