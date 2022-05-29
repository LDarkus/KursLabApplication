using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
namespace KursLabTRPK.Model
{
    public class Service_Book
    {
        public int id { get; set; }
        public int idCar_owner { get; set; }
        public int idCar { get; set; }

        public List<Technical_inspection> technical_Inspections = new List<Technical_inspection>();
        public Car_owner car_Owner;
        public Car car;
        public Service_Book(int id , Car c,Car_owner car_O)
        {
            this.id = id;
            car = c;
            car_Owner = car_O;
        }

        public bool FormAKT(int value)
        {
            Technical_inspection TO = technical_Inspections[value] ;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "docx files(*.docx)|*.docx";
            sfd.DefaultExt = "docx";

            sfd.Title = "Сохранение сформированного Акта";
            if (sfd.ShowDialog() == DialogResult.Cancel)
                return false;
            // получаем выбранный файл
            string filename = sfd.FileName;
            // сохраняем текст в файл
            Word.Document doc = null;
            try
            {
                Word.Application app = new Word.Application();
                // Открываем документ
                File.WriteAllBytes(filename, File.ReadAllBytes(Directory.GetCurrentDirectory() + "/Shablon/shablon.docx"));
                doc = app.Documents.Open(filename);
                doc.Activate();

                //Добавляем информацию
                Word.Bookmarks wBook = doc.Bookmarks;
                Word.Range wRange;

                Word.Bookmark mark;
                //ФИО владельца авто
                mark = wBook[3];
                wRange = mark.Range;
                wRange.Text = car_Owner.FIO;

                //Водительское удостоверение
                mark = wBook[9];
                wRange = mark.Range;
                wRange.Text = car_Owner.driver_license;

                //Номер телефона
                mark = wBook[10];
                wRange = mark.Range;
                wRange.Text = car_Owner.phone_number;

                //Марка авто
                mark = wBook[6];
                wRange = mark.Range;
                wRange.Text = car.model;

                //Год выпуска
                mark = wBook[16];
                wRange = mark.Range;
                wRange.Text = car.year_release.ToString();

                //Гос номер
                mark = wBook[5];
                wRange = mark.Range;
                wRange.Text = car.state_number;

                //Вин Номер
                mark = wBook[15];
                wRange = mark.Range;
                wRange.Text = car.VIN_number;

                //Объем двигателя
                mark = wBook[2];
                wRange = mark.Range;
                wRange.Text = car.engine_capacity.ToString();

                //Пробег авто 
                mark = wBook[7];
                wRange = mark.Range;
                wRange.Text = car.mileage.ToString() ;

                //Дата проведения ТО
                mark = wBook[1];
                wRange = mark.Range;
                wRange.Text = TO.date_event.ToString() ;

                //ФИО мастера приемщика
                mark = wBook[4];
                wRange = mark.Range;
                wRange.Text = TO.masterFIO;

                //Пробег авто на момент прохождения ТО
                mark = wBook[8];
                wRange = mark.Range;
                wRange.Text = TO.mileage.ToString();

                //Тип проводимого ТО
                mark = wBook[14];
                wRange = mark.Range;
                wRange.Text = TO.TypeTOtext;

                //Общаяя цена ремонта
                mark = wBook[13];
                wRange = mark.Range;
                wRange.Text = TO.waybill.price.ToString();

                //Таблица запчастей

                mark = wBook[11];
                wRange = mark.Range;
                Word.Table table = doc.Tables.Add(wRange, TO.waybill.autoparts.Count + 1, 4);
                table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                table.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;



                table.Cell(1, 1).Range.Text = "№";
                table.Cell(1, 1).Width = 30;
                table.Cell(1, 2).Range.Text = "Наименование";
                table.Cell(1, 2).Width = 115;
                table.Cell(1, 3).Range.Text = "Количество";
                table.Cell(1, 3).Width = 115;
                table.Cell(1, 4).Range.Text = "Цена";
                table.Cell(1, 4).Width = 115;
                

                int number = 1;
                TO.waybill.autoparts.ForEach(autopart =>
                {
                    table.Cell(number + 1, 1).Range.Text = number.ToString();
                    table.Cell(number + 1, 1).Width = 30;
                    table.Cell(number + 1, 2).Range.Text = autopart.name;
                    table.Cell(number + 1, 2).Width = 115;
                    table.Cell(number + 1, 3).Range.Text = autopart.count.ToString();
                    table.Cell(number + 1, 3).Width = 115;
                    table.Cell(number + 1, 4).Range.Text = autopart.price.ToString();
                    table.Cell(number + 1, 4).Width = 115;

                    number++;
                });

                //Таблица проблем

                mark = wBook[12];
                wRange = mark.Range;
                table = doc.Tables.Add(wRange, TO.waybill.problem_name.Count + 1, 2);
                table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                table.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;



                table.Cell(1, 1).Range.Text = "№";
                table.Cell(1, 1).Width = 30;
                table.Cell(1, 2).Range.Text = "Наименование";
                table.Cell(1, 2).Width = 115;
                


                number = 1;
                TO.waybill.problem_name.ForEach(problem =>
                {
                    table.Cell(number + 1, 1).Range.Text = number.ToString();
                    table.Cell(number + 1, 1).Width = 30;
                    table.Cell(number + 1, 2).Range.Text = problem;
                    table.Cell(number + 1, 2).Width = 115;
                    number++;
                });
                doc.Close();
                doc = null;
               
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // Если произошла ошибка, то
                // закрываем документ и выводим информацию
                MessageBox.Show("Во время выполнения произошла ошибка!");
                return false;
            }
        }
    }
}
