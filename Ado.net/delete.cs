using System;
using System.Data.SqlClient;


namespace Update
{
    class DeleteDemo
    {
        static void Main(string[] args)
        {
           //Connecting to database
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=SoniaVM;Initial Catalog=sample;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            
            sqlConnection.Open();
            try
            {

                Console.WriteLine("enter the id value that u want to delete");
                int Id = int.Parse(Console.ReadLine());
                 //passing the query to delete the data from the table 
                string deletequery = "delete from Customer1 where Id="+Id;
                SqlCommand deleteCommand = new SqlCommand(deletequery, sqlConnection);
               //executing the deleted data
                deleteCommand.ExecuteNonQuery();
                Console.WriteLine("deleted data successfully");
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

