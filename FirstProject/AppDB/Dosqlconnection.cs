using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;


namespace FirstProject.AppDB
{
    class Dosqlconnection
    {
       public static OleDbConnection con = DBconnection.getconn();//定义一个静态全局的con 方便以后用

       public string getpassword(string name)
       {
           con.Open();
           string password = "";
           string query = "select * from Person where PersonName=@name";
           OleDbCommand cmd = new OleDbCommand(query,con);
           cmd.Parameters.AddWithValue("@name", name);
           cmd.ExecuteNonQuery();
           OleDbDataReader myreader = cmd.ExecuteReader();
           while (myreader.Read() == true)
           {
               password = myreader["Password"].ToString().Trim();

           }
        
           return password;
       }
    }
}
