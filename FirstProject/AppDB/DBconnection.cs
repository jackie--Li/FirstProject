using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Configuration;
using System.Data;


namespace FirstProject.AppDB
{
    class DBconnection
    {
        public static OleDbConnection getconn()
        {
                //从配置文件中读取连接access 数据信息
            OleDbConnection connectionString = new OleDbConnection(ConfigurationManager.ConnectionStrings["MyDataConnectionString"].ConnectionString);
            return connectionString;


        }
    }
}
