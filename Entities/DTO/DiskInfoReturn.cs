using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class DiskInfoReturn
    {
        [DisplayName("Mã Danh Sách Thuê")]
        public int IdListRented { get; set; }
        [DisplayName("Mã Đĩa")]
        public int IdDisk { get; set; }
        [DisplayName("Mã khách hàng")]
        public int IdCustomer { get; set; }
        [DisplayName("Tên Khách Hàng")]
        public string CustomerName { get; set; }
        [DisplayName("Số Điện Thoại")]
        public string PhoneNumber { get; set; }
        [DisplayName("Địa Chỉ")]
        public string Address { get; set; }
        [DisplayName("Tiêu Đề")]
        public string Title { get; set; }
        [DisplayName("Ngày thuê")]
        public DateTime RentedDate { get; set; }
        [DisplayName("Ngày trả dự kiến")]
        public DateTime ExpectedDate { get; set; }
       
    }
}
