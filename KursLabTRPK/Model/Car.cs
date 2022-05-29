using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursLabTRPK.Model
{
    public class Car
    {
       public int id { get; set; }
       public String model { get; set; }

        public DateTime year_release { get; set; }
        public String state_number { get; set; }
        public double engine_capacity { get; set; }
        public String VIN_number { get; set; }
        public int mileage { get; set; }

        public Car(int id,string model,DateTime year,string state,double engine,string VIN,int mileage)
        {
            this.id = id;
            this.model = model;
            year_release = year;
            engine_capacity = engine;
            VIN_number = VIN;
            this.mileage = mileage;
            state_number = state;
        }

    }
}
