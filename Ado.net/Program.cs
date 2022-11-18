using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;

namespace ado.net
{
    internal class demo
    {
        static void Main(string[] args)
        {


            SqlConnection con = new SqlConnection("data source = .; database = Sample; integrated security = True");
            con.Open();
            SqlCommand cmd = new SqlCommand(" select * from dbo.Customer1;", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string ID = dr["ID"].ToString();
                string Firstname = dr["Firstname"].ToString();
                string Lastname = dr["Lastname"].ToString();
                string City = dr["City"].ToString();
                string Country = dr["Country"].ToString();
               

                Console.WriteLine(ID + " -----" + Firstname + "------- " + Lastname + " -----" + City + " ------" + Country );





            }
            dr.Close();
            con.Close();
            Console.ReadLine();


        }
    }
}
