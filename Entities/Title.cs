using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Title
    {
        [Key]
        [DisplayName("Mã Tiêu Đề")]
        public int IdTitle { get; set; }
        [Display(Order =-1)]
        public virtual DiskType DiskType { get; set; }
        [DisplayName("Mã Loại Đĩa")]
        public int? IdDiskType { get; set; }
        [DisplayName("Tên Tiêu Đề")]
        public string NameTitle { get; set; }
        [DisplayName("SL Trên Kệ")]
        public int? TotalDiskOnShelf { get; set; }
        [Display(Order = -1)]
        public ICollection<Disk> Disks { get; set; }
    }
}
