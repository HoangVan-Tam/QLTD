using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO
{
    public class TitleDTO
    {
        [Key]
        [DisplayName("Mã Tiêu Đề")]
        public int IdTitle { get; set; }
        [DisplayName("Mã Loại Đĩa")]
        public int? IdDiskType { get; set; }
        [DisplayName("Tên Tiêu Đề")]
        public string NameTitle { get; set; }
        [DisplayName("Tổng Số Lượng Đĩa")]
        public int? totalDisks { get; set; }
        [DisplayName("SL Trên Kệ")]
        public int? TotalDiskOnShelf { get; set; }
    }
}
