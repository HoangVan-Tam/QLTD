using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ReportTitle
    {
        [DisplayName("Tiêu Đề")]
        public string TitleName { get; set; }
        [DisplayName("Tổng Số Bản Sao")]
        public int? TongSoBanSao { get; set; }
        [DisplayName("Tổng Số Bản Sao Được Thuê")]
        public int? TongSoBanSaoDuocThue { get; set; }
        [DisplayName("Tổng Số Bản Sao Trong Kho")]
        public int? TongSoBanSaoTrongKho { get; set; }
        [DisplayName("Tổng Số Bản Sao Đang Chờ Xử Lí")]
        public int? TongSoDatTruocDangXuLi { get; set; }
        [DisplayName("Tổng Số Bản Sao Đặt Trước")]
        public int? TongSoBanSaoDuocDatTruoc { get; set; }
    }
}
