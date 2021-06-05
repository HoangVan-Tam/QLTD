using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ReportCustomer
    {
        [DisplayName("Mã Khách Hàng")]
        public int idCustomer { get; set; }
        [DisplayName("Tên Khách Hàng")]
        public string CustomerName { get; set; }
        [DisplayName("Địa Chỉ")]
        public string Address { get; set; }
        [DisplayName("Số điện thoại")]
        public string PhoneNumber { get; set; }
        [DisplayName("Số Đĩa Thuê")]
        public int TotalDiskRent { get; set; }
    }
}
