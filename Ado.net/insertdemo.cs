using System;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace ConnectingToSqlServer
{
    class Program
    {
        static void Main(string[] args)
        {
            //connecting to the database
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=SoniaVM;Initial Catalog=sample;Integrated Security=True";
            sqlConnection  = new SqlConnection(connectionString);
            //opening of the database
            sqlConnection.Open();

            Console.WriteLine("Please Enter Customer Id : ");
            int Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPlease Enter  First Name : ");
            String FirstName = Console.ReadLine();

            Console.WriteLine("\nPlease Enter  Last Name  : ");
            String LastName = Console.ReadLine();

            Console.WriteLine("\nPlease Enter  City : ");
            String City = Console.ReadLine();

            Console.WriteLine("\nPlease Enter  Country : ");
            String Country = Console.ReadLine();

            //inserting values 
            string insertQuery = "insert into Customer1(Id, Firstname, Lastname ,City,Country) Values('" + Id + "','" + FirstName + "','" + LastName + "','" + City + "','"+Country +" ')";
            SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
            //used to execute 
            insertCommand.ExecuteNonQuery();
            Console.WriteLine("Data Inserted successfully");
            sqlConnection.Close();
            Console.ReadKey();
        }
    }
}
