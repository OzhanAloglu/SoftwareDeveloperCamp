using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Order:IEntity
    {
        public int OrderId { get; set; }



        //Hazır veritabanı kullanıldı. Orada string formatında olduğu için burada string verildi.
        public string CustomerId { get; set; }


        public int EmployeeId { get; set; }
        public DateTime OrderDate { get; set; }      
        public string ShipCity { get; set; }
    }
}
