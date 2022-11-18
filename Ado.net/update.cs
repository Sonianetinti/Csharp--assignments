using System;
using System.Data.SqlClient;


namespace Update
{
    class Program
    {
        static void Main(string[] args)
        {
            //connecting to the database
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=SoniaVM;Initial Catalog=sample;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            //opening of the database
            sqlConnection.Open();
            try
            {
               //used to display the statement 
                Console.WriteLine("enter the id value that u want to update");
                //parse is used to convert string to int
                int Id = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the name to be updated");
                string name = Convert.ToString(Console.ReadLine());
                string updatequery = "update Customer1 set FirstName ='" + name + "'where Id=" + Id + "";
                SqlCommand updateCommand = new SqlCommand(updatequery, sqlConnection);
                //to execute the updated data
                updateCommand.ExecuteNonQuery();
                Console.WriteLine("updated data successfully");
                sqlConnection.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();




        }
    }
}

