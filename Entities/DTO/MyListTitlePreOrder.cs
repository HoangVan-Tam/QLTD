using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class MyListTitlePreOrder
    {
        [DisplayName("Mã Đơn Đặt")]
        public int IdListPreOrder { get; set; }
        [DisplayName("Mã Khách Hàng")]
        public int IdCustomer { get; set; }
        [DisplayName("Tên Khách Hàng")]
        public string NameCustomer { get; set; }
        [DisplayName("Tên Tiêu Đề")]
        public string NameTitle { get; set; }
        
    }
}
