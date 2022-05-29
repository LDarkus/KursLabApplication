using MySql.Data.MySqlClient;
using System;
using System.Data.Common;

namespace KursLabTRPK.Model
{
    public class DB
    {
        private string host = "localhost";
        private int port = 3306;
        private string database = "db";
        private string username = "root";
        private string password = "";
        private string SslMode = "none";
        private MySqlConnection conn;



        //---------------------------------------------------------------------------------------
        //Конструктор подключения к бд
        public DB()
        {
            // Connection String.
            String connString = "Server=" + host + ";Database=" + database
                + ";port=" + port + ";User Id=" + username + ";password=" + password + ";SslMode=" + SslMode;
            conn = new MySqlConnection(connString);
           
            
        }
        //Авторизация и определение прав доступа user либо admin
        public string getUser(string login, string password) 
        {
            string text = "0";
            try
            {
                conn.Open();
                
                DbDataReader req = new MySqlCommand("SELECT * FROM `users`", conn).ExecuteReader();
                while (req.Read())
                {
                    if (req.GetString(1) == login)
                    {
                        if (req.GetString(2) == password)
                        {
                            text = req.GetString(3);
                        }
                    }
                }
                req.Close();
                conn.Close();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message,"Ошибка подключения к БД");
            }
            return text;
        }
        //Запрос на доабвление новой сервисной книжки в БД
        public string add_Service_Book(Service_Book service_Book)
        {
            conn.Open();
            string query = "";
            String date = $"{service_Book.car.year_release.Year}-{service_Book.car.year_release.Month}-{service_Book.car.year_release.Day}";
            //Занесение информации об владельце автомобиля в бд
            query += String.Format("INSERT INTO car_owner(car_owner.FIO,car_owner.driver_license,car_owner.phone_number) VALUES ('{0}','{1}',{2});", service_Book.car_Owner.FIO,service_Book.car_Owner.driver_license,service_Book.car_Owner.phone_number);
            //Занесение информации об автомобиле в бд
            query += String.Format("INSERT INTO car(car.model,car.year_release,car.state_number,car.engine_capacity,car.VIN_number,car.mileage) VALUES('{0}','{1}','{2}',{3},'{4}',{5});", service_Book.car.model, date, service_Book.car.state_number, service_Book.car.engine_capacity, service_Book.car.VIN_number, service_Book.car.mileage);
            //Занесение информации в созданную сервисную книжку
            query += String.Format("INSERT INTO service_book(service_book.idCar_ovner,service_book.idCar) VALUES((SELECT car_owner.id FROM car_owner WHERE car_owner.FIO='{0}'),(SELECT car.id FROM car WHERE car.state_number='{1}'));", service_Book.car_Owner.FIO,service_Book.car.state_number);
            DbDataReader req;
            try
            {
                req = new MySqlCommand(query, conn).ExecuteReader();
                req.Close();
                conn.Close();
                return "OK";
                
            }
            catch (Exception e)
            {
                conn.Close();
                return e.Message;
            }
        }
        //Запрос на добавление нового технического осмотра
        public void Add_Techical_insp(Technical_inspection technical_Inspection)
        {
            conn.Open();
            string query = "";
            DateTime time = technical_Inspection.date_event;
            string data = $"{time.Year}-{time.Month}-{time.Day}";
           
            //Занесение информации об владельце автомобиля в бд
            query += String.Format("INSERT INTO technical_inspection(idService_book,idTypeTO,date_event,mileage,masterFIO)VALUES({0},{1},'{2}',{3},'{4}');", technical_Inspection.idServiceBook,technical_Inspection.TypeTO,data,technical_Inspection.mileage,technical_Inspection.masterFIO);
            //Занесение информации об автомобиле в бд
            query += String.Format("INSERT INTO waybill(idTechnical_inspection,price,problem_name) VALUES({0},{1},'{2}');",technical_Inspection.id,technical_Inspection.waybill.price,technical_Inspection.waybill.problems );
            //Занесение информации в созданную сервисную книжку

            technical_Inspection.waybill.autoparts.ForEach(autopart =>
            {
                query += String.Format("INSERT INTO autopart(idWaybill,name,count,price) VALUES({0},'{1}',{2},{3});", technical_Inspection.waybill.id,autopart.name,autopart.count,autopart.price);
            }
            );

            DbDataReader req;
            try
            {
                req = new MySqlCommand(query, conn).ExecuteReader();
                req.Close();
                conn.Close();

            }
            catch (Exception e)
            {
                conn.Close();
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }
        //Запрос на получение id последнего технического осмотра в бд
        public int GetIdTechical_insp()
        {
            int id = 0;
            try
            {
                conn.Open();

                DbDataReader req = new MySqlCommand("SELECT max(technical_inspection.id) from technical_inspection;", conn).ExecuteReader();
                while (req.Read())
                {
                    
                            id = Convert.ToInt32(req.GetString(0));
                        
                    
                }
                req.Close();
                conn.Close();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "Ошибка подключения к БД");
                conn.Close();
            }
            return id;
        }
        //Запрос на получение id послденей сервисной книжки в бд
        public int GetIdServiceBook()
        {
            int id = 0;
            try
            {
                conn.Open();

                DbDataReader req = new MySqlCommand("SELECT MAX(service_book.id) FROM service_book;", conn).ExecuteReader();
                while (req.Read())
                {

                    id = Convert.ToInt32(req.GetString(0));


                }
                req.Close();
                conn.Close();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "Ошибка подключения к БД");
                conn.Close();
            }
            return id;
        }
        //Запрос на получение id последней накладной в бд
        public int GetIdWaybill()
        {
            int id = 0;
            try
            {
                conn.Open();

                DbDataReader req = new MySqlCommand("SELECT max(waybill.id) from waybill;", conn).ExecuteReader();
                while (req.Read())
                {

                    id = Convert.ToInt32(req.GetString(0));


                }
                req.Close();
                conn.Close();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "Ошибка подключения к БД");
                conn.Close();
            }
            return id;
        }
        //Запрос на нахождение сервисной книжки по введенному критерию
        public int SearchServiceBook(string criterial, string number)
        {
            conn.Open();
            
            string query = "";
            query += "SELECT * FROM car INNER JOIN service_book on car.id=service_book.idCar ";
            if (criterial == "По Гос. номеру")
            {
                query += String.Format($"WHERE car.state_number='{number}'");
            }
            else
            {
                
                query += String.Format($"WHERE car.VIN_number='{number}'");

            }
            try
            {
                int id = 0;
                DbDataReader req = new MySqlCommand(query, conn).ExecuteReader();
                while (req.Read())
                {
                    id = Convert.ToInt32(req.GetString(7));
                }
                
                
                req.Close();
                conn.Close();

                return id;

            }
            catch (Exception e)
            {
                conn.Close();
                System.Windows.Forms.MessageBox.Show(e.Message);
                return 0;
            }
        }
        //Запрос на получение данных сервисной книжки
        public Service_Book GetServiceBook(int id)  
        {
            conn.Open();
            Service_Book service_Book=null; 
            try
            {
                string query1 = $"SELECT * FROM car INNER JOIN service_book on car.id=service_book.idCar INNER JOIN car_owner on service_book.idCar_ovner=car_owner.id WHERE service_book.id={id}";
                string query2 = $"SELECT * FROM technical_inspection join waybill on technical_inspection.id=waybill.idTechnical_inspection join service_book on  technical_inspection.idService_book=service_book.id WHERE service_book.id = {id}" ;
                string query3 = $"SELECT autopart.id,autopart.name,autopart.count,autopart.price,technical_inspection.id FROM technical_inspection join waybill on technical_inspection.id=waybill.idTechnical_inspection join autopart on waybill.id=autopart.idWaybill WHERE technical_inspection.idService_book={id}";
                //Выполнение первого запроса для заполнение обектов: сервисная книжка, владелец автомобиля, автомобиль
                DbDataReader req = new MySqlCommand(query1, conn).ExecuteReader();
                while (req.Read())
                {
                    service_Book = new Service_Book(id,new Car(req.GetInt32(0),req.GetString(1),Convert.ToDateTime(req.GetDateTime(2)),req.GetString(3),req.GetDouble(4),req.GetString(5),req.GetInt32(6)),new Car_owner(req.GetInt32(8),req.GetString(11),req.GetString(12),req.GetString(13)));
                }
                req.Close();
                req = new MySqlCommand(query2, conn).ExecuteReader();
                //Выполнение второго запроса для заполнение обектов: технический осмотр, накладная.
                while (req.Read())
                {
                    service_Book.technical_Inspections.Add(new Technical_inspection(req.GetInt32(0), req.GetInt32(1), req.GetDateTime(2), req.GetInt32(3), req.GetInt32(4), req.GetString(5),new Waybill(req.GetInt32(6),req.GetInt32(8),req.GetString(9))));
                } 
                req.Close();
               
                //Выполнение третьего запроса для заполнение обектов: запчасти.
                req = new MySqlCommand(query3, conn).ExecuteReader();
                while (req.Read())
                {
                    service_Book.technical_Inspections.ForEach(TI =>
                    {
                        if (TI.id == req.GetInt32(4))
                        {
                            TI.waybill.autoparts.Add(new Autopart(req.GetInt32(0),req.GetString(1),req.GetInt32(2),req.GetInt32(3)));
                        }
                    });
                }
                req.Close();
                conn.Close();

            }
            catch (Exception e)
            {
                conn.Close();
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            return service_Book;
        }
    }
}
