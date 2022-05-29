using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursLabTRPK.Model
{
    public class Autopart
    {
        public int id { get; set; }
        public String name { get; set; }
        public int count { get; set; }
        public int price { get; set; }
        public Autopart(int id,string name,int count,int price) 
        {
            this.id = id;
            this.name = name;
            this.count = count;
            this.price = price;
        }
    }
}
