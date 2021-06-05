using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class MyDeTailOrder
    {
        [DisplayName("Mã Chi Tiết Đặt Trước")]
        public int IdDetailPreOrder { get; set; }
        [Display(Order =-1)]
        public int IdDisk { get; set; }
        [DisplayName("Tiêu Đề")]
        public string Title { get; set; }
    }
}
