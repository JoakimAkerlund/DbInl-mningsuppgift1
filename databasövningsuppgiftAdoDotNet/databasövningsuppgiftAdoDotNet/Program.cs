using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace databasövningsuppgiftAdoDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NORTHWND;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = cn.CreateCommand();
            cn.Open();
            cmd.CommandText = "UPDATE Products SET UnitPrice = 1.05 * UnitPrice FROM Products p INNER JOIN Categories c ON p.CategoryID = c.CategoryID WHERE c.CategoryName = 'Beverages'";
            cmd.ExecuteNonQuery();

            cmd.CommandText= "SELECT TOP (1000) [ProductID]"+
            ",[ProductName]"+
            ",[CategoryID]"+
            ",[UnitPrice]"+     
            "FROM .[dbo].[Products]"+
            "WHERE[CategoryID]='1'";
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                Console.WriteLine("{0} {1} {2}", rd.GetString(1),rd.GetInt32(2), Math.Round(rd.GetDecimal(3), 2));
            }

            Console.ReadLine();
            rd.Close();
            cn.Close();
        }
    }
}
