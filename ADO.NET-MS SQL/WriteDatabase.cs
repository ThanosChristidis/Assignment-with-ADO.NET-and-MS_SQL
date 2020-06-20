using System;
using System.Configuration;
using System.Data.SqlClient;


namespace ADO.NET_MS_SQL
{
    class WriteDatabase
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["Sindesi"].ConnectionString;

        public static void InsertNewStudents()
        {
            try
            {
                Console.Write("\tInsert student's name: ");
                string Firstname = Console.ReadLine();
                Console.Write("\tInsert student's surname: ");
                string Lastname = Console.ReadLine();
                Console.Write("\tBirthday in the form \"dd/mm/yyyy\": ");
                string input = Console.ReadLine();
                DateTime? DateOfBirth = string.IsNullOrWhiteSpace(input) ? (DateTime?)null : Convert.ToDateTime(input);


                string querry = "insert into Student (FirstName, LastName, DateOfBirth)" +
                                 "values (@FirstName,@LastName,@DateOfBirth)";

                SqlConnection dbcon = new SqlConnection(connectionString);
                using (dbcon)
                {
                    dbcon.Open();
                    SqlCommand command = new SqlCommand(querry, dbcon);

                    command.Parameters.AddWithValue("@FirstName", Firstname);
                    command.Parameters.AddWithValue("@LastName", Lastname);
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth ?? (object)DBNull.Value);

                    command.ExecuteNonQuery();
                }

                Console.WriteLine("\tStudent inserted successfully!");

                ReadDatabase.ReadAllStudents();
            }
            catch (SqlException e)
            {
                Console.WriteLine("There was a problem with student insertion! Please try again!");
                Console.WriteLine("Error type: " + e.Message);
            }
            finally { }

        }






    }


}
