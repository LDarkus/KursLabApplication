using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
namespace KursLabTRPK.Model
{
    public class Technical_inspection
    {
        public int id { get; set; }
        public int idServiceBook { get; set; }
        public DateTime date_event { get; set; }
        public int TypeTO { get; set; }
        public string TypeTOtext;
        public int mileage { get; set; }
        public String masterFIO { get; set; }

        public Waybill waybill;
        public Technical_inspection(int id, int idServiceBook, DateTime date, int type, int mileage, string fio, Waybill w)
        {
            this.id = id;
            date_event = date;
            TypeTO = type;
            this.mileage = mileage;
            masterFIO = fio;
            this.idServiceBook = idServiceBook;
            waybill = w;
        }
    
       
        
    }
}
