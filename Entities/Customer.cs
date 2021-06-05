using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Customer
    {
        [Key]
        [DisplayName("Mã Khách Hàng")]
        public int IdCustomer { get; set; }
        [DisplayName("Địa Chỉ")]
        public string Address { get; set; }
        [DisplayName("Tên Khách Hàng")]
        public string CustomerName { get; set; }
        [DisplayName("Số Điện Thoại")]
        public string PhoneNumber { get; set; }
        public List<ListRented> ListRenteds { get; set; }
        public List<ListTitlePreOrder> ListTitlePreOrders { get; set; }
    }
}
