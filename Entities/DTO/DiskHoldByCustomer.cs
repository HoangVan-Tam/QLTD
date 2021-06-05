using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO
{
    public class DiskHoldByCustomer
    {
        public int IdListRented { get; set; }
        public int IdDisk { get; set; }
        public int IdTitle { get; set; }
        public string NameTitle { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime ExpectedReturnDate { get; set; }
    }
}
