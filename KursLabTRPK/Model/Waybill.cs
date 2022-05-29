using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursLabTRPK.Model
{
    public class Waybill
    {
        public int id { get; set; }
        public int price { get; set; }

        public List<string> problem_name;
        public List<Autopart> autoparts;
        public string problems;
        public Waybill(int id , int price,string prob)
        {
            this.id = id;
            this.price = price;
            problems = prob;
            autoparts = new List<Autopart>();
            
            problem_name= new List<string>();
            problem_name.InsertRange(0, problems.Split(';'));


        }
    }
}
