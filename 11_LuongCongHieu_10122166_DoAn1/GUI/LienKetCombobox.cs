using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using BUS;
using DTO;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Guna.UI2.WinForms;

namespace FrmTrangChu.cs
{
    public class LienKetCombobox
    {
        public void LienKet2DuLieu(DataTable dataTable, string displayMember, string ValueMember, Guna2ComboBox comboBox)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = ValueMember;
            comboBox.DataSource = bindingSource;
        }
        public void LienKet1DuLieu(DataTable dataTable, string displayMember, Guna2ComboBox comboBox)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            comboBox.DisplayMember = displayMember;
            comboBox.DataSource = bindingSource;
        }
    }
}
