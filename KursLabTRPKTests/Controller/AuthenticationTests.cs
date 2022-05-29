using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KursLabTRPK.Tests
{
    [TestClass()]
    public class AuthenticationTests
    {
        [TestMethod()]
        public void AuntTest()
        {
            //Логин
            string login="GAI";
            //Пароль
            string password="1234";

            //Метод прроверки есть ли такой пользователь в бд, если есть возвращает права доступа пользователя
            string Line=Authentication.Aunt(login, password);
            //Что должно прийти на вход
            string answer = "user";
            //Сравнение результатов
            Assert.AreEqual(Line,answer);
        }

        
       
    }
}