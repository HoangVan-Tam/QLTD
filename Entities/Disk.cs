using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Disk
    {

        [Key]
        [DisplayName("Mã Đĩa Bản Sao")]
        public int IdDisk { get; set; }
        [DisplayName("Trạng Thái Cho Thuê")]
        public string DiskRentalStatus { get; set; }
        [DisplayName("Trạng Thái Đĩa")]
        public string DiskStatus { get; set; }
        [DisplayName("Mã Tiêu Đề")]
        public int? IdTitle { get; set; }
        [Display(Order = -1)]
        public virtual Title Title { get; set; }
    }
}
