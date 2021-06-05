using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO
{
    public class DiskInfoRent
    {
        [DisplayName("Mã Đĩa")]
        public int IdDisk { get; set; }
        [DisplayName("Tiêu Đề")]
        public string Title { get; set; }
        [DisplayName("Loại Đĩa")]
        public string TypeName { get; set; }
        [DisplayName("Thời Gian Thuê")]
        public int TimeRented { get; set; }
        [DisplayName("Phí Trễ")]
        public double LateFee { get; set; }
        [DisplayName("Giá Thuê")]
        public double Price { get; set; }
        [DisplayName("Trạng Thái Thuê")]
        public string DiskRentalStatus { get; set; }
    }
}
