using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
namespace DataAccessLogicLayer
{
    class SqlHelper
    {
        public static SqlConnection ConnectToDB()
        {
            SqlConnection cn = new SqlConnection("server=NAWALDELL\\SQLEXPRESS;integrated" +
                " security=true;database=PizzaDB");
            cn.Open();
            return cn;
        }
        public static string GetENameById(int id)
        {
            SqlConnection cn = ConnectToDB();
            string query = "select Type from tbl_pizzalist where PizzaId=@PizzaId";
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@PizzaId", id);
            string ename = cmd.ExecuteScalar().ToString();
            return ename;
        }
    }
}
