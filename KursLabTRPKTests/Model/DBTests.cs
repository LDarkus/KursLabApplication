using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using System;

namespace KursLabTRPK.Model.Tests
{
    [TestClass()]
    public class DBTests
    {

        [TestMethod()]
        public void Test_Connect_to_DB()
        {
            //Модульное тестирование: проверка подключения к бд
            //Параметры подключения к бд
            string host = "localhost";
            int port = 3306;
            string database = "db";
            string username = "root";
            string password = "";
            string SslMode = "none";
            //Строка подклчюения к бд
            String connString = "Server=" + host + ";Database=" + database
               + ";port=" + port + ";User Id=" + username + ";password=" + password + ";SslMode=" + SslMode;
            //Метод подключения к бд
            MySqlConnection conn = new MySqlConnection(connString);
            //Открываем соеденение
            conn.Open();
            //То что должно получится 
            String answer = "Open";
            //Проверка было ли открыто соединение
            Assert.AreEqual(answer, conn.State.ToString());
        }
    }
}
