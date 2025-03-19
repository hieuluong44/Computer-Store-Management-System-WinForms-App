using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using BUS;
using DTO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DevExpress.XtraGrid.Views.Grid;
using Guna.UI2.WinForms;
using DevExpress.XtraCharts;
using DevExpress.Utils;

namespace FrmTrangChu.cs
{
    public partial class FrmQuanLyThongKeDoanhThu : DevExpress.XtraEditors.XtraUserControl
    {
        BUS_ThongKe thongKe = new BUS_ThongKe();
        public FrmQuanLyThongKeDoanhThu()
        {
            InitializeComponent();
        }
        private void dtgvDoanhThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtTongBan.Text = Convert.ToDecimal(dtgvDoanhThu[2, i].Value).ToString("N0");
            txtTongNhap.Text = Convert.ToDecimal(dtgvDoanhThu[3, i].Value).ToString("N0");
            txtTongLai.Text = Convert.ToDecimal(dtgvDoanhThu[4, i].Value).ToString("N0");
            txtSoLuongBan.Text = Convert.ToDecimal(dtgvDoanhThu[5, i].Value).ToString("N0");
            txtSoLuongNhap.Text = Convert.ToDecimal(dtgvDoanhThu[6, i].Value).ToString("N0");
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DateTime fromDate = FromDate.Value;
            DateTime toDate = ToDate.Value;
            DataTable dt = thongKe.ThongKeDoanhThu(fromDate, toDate);
            dtgvDoanhThu.DataSource = dt;

            // Truyền vào chart tổng bán
            Series Ban = new Series("Tổng bán", ViewType.Bar);
            Ban.DataSource = dt;
            Ban.ArgumentDataMember = "Từ ngày";
            Ban.ValueDataMembers.AddRange("Tổng bán");

            // Truyền vào chart tổng nhập
            Series Nhap = new Series("Tổng nhập", ViewType.Bar);
            Nhap.DataSource = dt;
            Nhap.ArgumentDataMember = "Từ ngày";
            Nhap.ValueDataMembers.AddRange("Tổng nhập");

            // Truyền vào chart tổng lãi
            Series Lai = new Series("Tổng lãi", ViewType.Bar);
            Lai.DataSource = dt;
            Lai.ArgumentDataMember = "Từ ngày";
            Lai.ValueDataMembers.AddRange("Tổng lãi");

            // Cấu hình ChartDoanhThu
            ChartDoanhThu.Series.Clear();
            ChartDoanhThu.Series.Add(Ban);
            ChartDoanhThu.Series.Add(Nhap);
            ChartDoanhThu.Series.Add(Lai);
            ChartDoanhThu.Titles.Clear();
            ChartDoanhThu.Titles.Add(new ChartTitle { Text = "Biểu đồ thống kê doanh thu" });

            // Tạo chuỗi "Tổng lãi" cho biểu đồ đường
            Series seriOrtSure = new Series("Tổng lãi", ViewType.Area);
            seriOrtSure.DataSource = dt;
            seriOrtSure.ArgumentDataMember = "Từ ngày";
            seriOrtSure.ValueDataMembers.AddRange("Tổng lãi");

            // Cấu hình ChartDoanhThu2
            ChartDoanhThu2.Series.Clear();
            ChartDoanhThu2.Series.Add(seriOrtSure);
            // Add ChartDoanhThu2 to the form
            this.Controls.Add(ChartDoanhThu2);
        }

        private void FrmQuanLyThongKeDoanhThu_Load(object sender, EventArgs e)
        {

        }
    }
}
