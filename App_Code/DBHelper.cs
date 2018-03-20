using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient; 

namespace DTSclient
{
    public class DBHelper
    {
        //创建连接数据库字符串Data Source=#########;Initial Catalog=#####;User ID=###;Password=########";
        //private string connString = "Data Source=######;Initial Catalog=JFPTC;User ID=GZptc2017;Password=#####";
        private string connString = "Data Source=######3;Initial Catalog=JFPTC;User ID=sa;Password=20120607";
        //private string connString = "Data Source=DESKTOP-A8ESEHG\\SQLEXPRESS;Initial Catalog=gzmtest20161227;User ID=sa;Password=666666";
        private SqlConnection connection;
        public SqlConnection Connection
        {
            get
            {
                if (connection == null)
                {
                    connection = new SqlConnection(connString);
                }
                return connection;
            }
        }
        //打开数据库
        public void OpenConnection()
        {
            if (Connection.State == ConnectionState.Closed)
                Connection.Open();
            if (Connection.State == ConnectionState.Broken)
            {
                Connection.Close();
                Connection.Open();
            }
        }
        //关闭数据库连接
        public void CloseConnection()
        {
            if (Connection.State == ConnectionState.Open || Connection.State == ConnectionState.Broken)
                Connection.Close(); 
        }
    }
}
