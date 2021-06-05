using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class ListRented
    {
        [Key]
        [DisplayName("Mã Đơn Thuê")]
        public int IdListRented { get; set; }
        [Display(Order = -1)]
        public virtual Disk Disk { get; set; }
        [DisplayName("Mã Đĩa")]
        public int? IdDisk { get; set; }
        [Display(Order = -1)]
        public virtual Customer Customer { get; set; }
        [DisplayName("Mã kHách Hàng")]
        public int? IdCustomer { get; set; }
        [DisplayName("Phí Trễ")]
        public double? LateFee { get; set; }
        [DisplayName("Ngày Thuê")]
        public DateTime? RentalDate { get; set; }
        [DisplayName("Ngày Trả Dự Kiến")]
        public DateTime? ExpectedReturnDate { get; set; }
        [DisplayName("Ngày Trả Thực Tế")]
        public DateTime? ActualReturnDate { get; set; }
        [DisplayName("Trạng Thái Đơn Thuê")]
        public string StatusOnBill { get; set; }
    }
}
