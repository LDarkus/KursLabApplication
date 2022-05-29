using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursLabTRPK.Model
{
    public class Car_owner
    {
        public int id { get; set; }
        public String FIO { get; set; }
        public String driver_license { get; set; }
        public String phone_number { get; set; }

        public Car_owner(int id,string fio,string Drive_license,string Phone_number)
        {
            this.id = id;
            FIO = fio;
            driver_license = Drive_license;
            phone_number = Phone_number;
        }
    }
}
