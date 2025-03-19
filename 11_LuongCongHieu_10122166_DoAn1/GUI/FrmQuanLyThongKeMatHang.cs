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

namespace FrmTrangChu.cs
{
    public partial class FrmQuanLyThongKeMatHang : DevExpress.XtraEditors.XtraUserControl
    {
        BUS_ThongKe thongKe = new BUS_ThongKe();
        public FrmQuanLyThongKeMatHang()
        {
            InitializeComponent();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            cboThongKe_SelectedIndexChanged(sender, e);
        }
        private void cboThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy giá trị đã chọn từ ComboBox
            string selectedOption = cboThongKe.SelectedItem.ToString();
            DateTime fromDate = FromDate.Value; // Lấy giá trị ngày tháng năm từ DateTimePicker
            DateTime toDate = ToDate.Value; // Ví dụ: ngày hiện tại

            switch (selectedOption)
            {
                case "Thống kê mặt hàng bán chạy":
                    DataTable dt = thongKe.HangBanChay(fromDate, toDate); // Truyền ngày tháng năm vào phương thức GetSalesReport
                    dtgvThongKeBanChay.DataSource = dt;
                    // Tạo một biểu đồ trống.
                    Series seriesTop10 = new Series("Top 10 Mặt hàng bán chạy", ViewType.Pie);
                    DataTable top10Items = dt.DefaultView.ToTable().AsEnumerable().Take(10).CopyToDataTable();

                    // Đổ dữ liệu vào loạt dữ liệu.
                    foreach (DataRow row in top10Items.Rows)
                    {
                        string itemName = row["Mã mặt hàng"].ToString();
                        double itemSales = Convert.ToDouble(row["Số lượng bán"]);
                        seriesTop10.Points.Add(new SeriesPoint(itemName, itemSales));
                    }

                    // Hiển thị tên mặt hàng bên phải trên biểu đồ
                    seriesTop10.Label.TextPattern = "{ A} : { VP}";
                    //{ V}: Hiển thị giá trị của từng phần trên biểu đồ.
                    //{ VP}: Hiển thị giá trị phần trăm của từng phần trên biểu đồ.
                    //{ A}: { V}
                    //hoặc { A}: { VP}: Kết hợp tên và giá trị(hoặc phần trăm) trên từng phần.

                    ChartMatHang.Series.Clear();// không lặp lại biểu đồ chart
                    ChartMatHang.Titles.Clear();// không lặp lại tên tiêu đề
                    ChartMatHang.Titles.Add(new ChartTitle { Text = "Top 10 mặt hàng bán chạy" });
                    // Thêm loạt dữ liệu vào biểu đồ.
                    ChartMatHang.Series.Add(seriesTop10);
                    break;
                case "Thống kê mặt hàng tồn kho":
                    DataTable dr = thongKe.HangTonKho(); // Truyền ngày tháng năm vào phương thức GetSalesReport
                    dtgvThongKeTonKho.DataSource = dr;
                    break;
                default:
                    break;
            }
        }
        private void dtgvThongKeTonKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo chỉ xử lý khi người dùng chọn một hàng hợp lệ
            {
                DataGridViewRow row = dtgvThongKeTonKho.Rows[e.RowIndex];
                txtIDMatHang.Text = row.Cells["Mã mặt hàng"].Value.ToString();
                txtTenMatHang.Text = row.Cells["Tên mặt hàng"].Value.ToString();
                txtSoLuongTon.Text = row.Cells["Số lượng tồn kho"].Value.ToString();
                txtSoLuongBan.Text = "";
            }
        }
        private void dtgvThongKeBanChay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo chỉ xử lý khi người dùng chọn một hàng hợp lệ
            {
                DataGridViewRow row = dtgvThongKeBanChay.Rows[e.RowIndex];
                txtIDMatHang.Text = row.Cells["Mã mặt hàng"].Value.ToString();
                txtTenMatHang.Text = row.Cells["Tên mặt hàng"].Value.ToString();
                txtSoLuongBan.Text = row.Cells["Số lượng bán"].Value.ToString();
                txtSoLuongTon.Text = "";
            }
        }
    }
}
