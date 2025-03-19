using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Connection_Database
    {
        public SqlConnection Con = new SqlConnection("Data Source=HIEUPC;Initial Catalog=Đồ án 1 : Quản lý cửa hàng máy tính;Integrated Security=True");
    }


}

