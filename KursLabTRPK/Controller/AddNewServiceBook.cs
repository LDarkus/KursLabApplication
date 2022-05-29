using System;
using System.Windows.Forms;
using KursLabTRPK.Model;

namespace KursLabTRPK.Controller
{
    public partial class AddNewServiceBook : Form
    {
        private DB db;
        string user;
        public AddNewServiceBook(DB db, string user)
        {

            InitializeComponent();
            dateTime.Format = DateTimePickerFormat.Custom;
            dateTime.CustomFormat = "yyyy";
            dateTime.ShowUpDown = true;
            this.db = db;
            this.user = user;
        }

        

        private void Add_new_Service_Book_Click(object sender, EventArgs e)
        {
            //Проверка на заполнненость полей 
            int countTextbox = 0;
            foreach (Control t in  this.Controls)
            {
                if (t is CueTextBox && t.Text.Length==0) 
                {
                    countTextbox++;
                }         
            }
            //Если все поля заполненые, то выполняем
            if (countTextbox == 0)
            {
                int n;
                //Проверка полей на соответствие типов данных
                if (int.TryParse(tbMileage.Text, out n)&& decimal.TryParse(tbNumberPhone.Text, out decimal dd) && double.TryParse(tbEngine.Text, out double d))
                { Car car = new Car(0, tbMark.Text, dateTime.Value, tbGosNumber.Text, Convert.ToDouble(tbEngine.Text), tbVINNumber.Text, Convert.ToInt32(tbMileage.Text));
                    Car_owner car_Owner = new Car_owner(0, tbFIO.Text, tbDriveLicense.Text, tbNumberPhone.Text);
                    Service_Book service_Book = new Service_Book(-1, car, car_Owner);
                    //Добавление серивсной книжки
                    if (db.add_Service_Book(service_Book) == "OK")
                    {
                        service_Book.id = db.GetIdServiceBook();
                        MessageBox.Show("Сервисная книжка успешно создана");
                        this.Hide();
                        Form form = new Service_book(db, service_Book,user);
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("При создании произошла ошибка попробуйте еще раз");
                    }
                }
                else
                {
                    MessageBox.Show("В полях ниже должно быть записано числовое значение: \nОбъем двигателя \nНомер телефона; \nПробег","Ошибка");
                }

            }
            else
            {
                MessageBox.Show($"Не все поля были заполенны ","Ошибка");
            }

        }
    }
}
