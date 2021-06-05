using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class TitleOrder
    {
        [DisplayName("Mã Tiêu Đề")]
        public int IdTitle { get; set; }
        [DisplayName("Tên Tiêu Đề")]
        public string NameTitle { get; set; }
        [DisplayName("Loại Đĩa")]
        public string TitleType { get; set; }
    }
}
