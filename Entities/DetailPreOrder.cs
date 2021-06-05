using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class DetailPreOrder
    {
        [Key]
        [DisplayName("Mã Chi Tiết Đặt Trước")]
        public int IdDetailPreOrder { get; set; }
        [DisplayName("Mã Khách Hàng")]
        public int? IdCustomer { get; set; }
        [Display(Order = -1)]
        public virtual Customer Customer { get; set; }
        [DisplayName("Mã Đĩa Bản Sao")]
        public int? IdDisk { get; set; }
        [Display(Order = -1)]
        public virtual Disk Disk { get; set; }
        [DisplayName("Chấp Thuận")]
        public bool? Accepted { get; set; }
        [Display(Order = -1)]
        public virtual ListTitlePreOrder ListTitlePreOrder { get; set; }
        public int? IdListTitlePreOrder { get; set; }
    }
}
