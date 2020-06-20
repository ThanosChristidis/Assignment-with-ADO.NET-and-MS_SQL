using System;
using System.Configuration;
using System.Data.SqlClient;

namespace ADO.NET_MS_SQL
{
    class ReadDatabase
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["Sindesi"].ConnectionString;

        public static void ReadAllStudents()
        {

            try
            {
                using (SqlConnection dbcon = new SqlConnection(connectionString))
                {
                    dbcon.Open();
                    SqlCommand cmd = new SqlCommand("select * from Student", dbcon);
                    SqlDataReader reader = cmd.ExecuteReader();

                    Console.WriteLine("\t ___________ _____________ _______________ ______________________");
                    Console.WriteLine("\t| StudentID | First Name  |  Last Name    |       Birthday       |");
                    Console.WriteLine("\t ___________ _____________ _______________ ______________________");

                    while (reader.Read())
                    {
                        var studentid = reader["Student_ID"];
                        var firstname = reader["FirstName"];
                        var lastname = reader["LastName"];
                        var dateofbirth = reader["DateOfBirth"];

                        Console.WriteLine("\t|{0,11}|{1,14}|{2,14}|{3,22}|", studentid, firstname, lastname, dateofbirth);
                    }

                    Console.WriteLine("\t ___________ ______________ ______________ _______________________");
                }

            }
            catch (SqlException e)
            {
                Console.WriteLine("\tThere was a problem with data showing up! Please try again!");
                Console.WriteLine("\tError type: " + e.Message);
            }
            finally { }
        }

        public static void ReadAllCourses()
        {
            try
            {

                using (SqlConnection dbcon = new SqlConnection(connectionString))
                {
                    dbcon.Open();
                    SqlCommand command = new SqlCommand("select * from Course", dbcon);
                    SqlDataReader reader = command.ExecuteReader();

                    Console.WriteLine(" __________ _______ ________ __________ ____________________ _____________________");
                    Console.WriteLine("| CourseID | Title | Stream |   Type   |     StartDate      |      EndDate        |");
                    Console.WriteLine(" __________ _______ ________ __________ ____________________ _____________________");

                    while (reader.Read())
                    {
                        var courseid = reader["Course_ID"];
                        var title = reader["Title"];
                        var stream = reader["Stream"];
                        var type = reader["CType"];
                        var startdate = reader["StartDate"];
                        var enddate = reader["EndDate"];

                        Console.WriteLine("|{0,10}|{1,7}|{2,8}|{3,10}|{4,11}|{5,11}|", courseid, title, stream, type, startdate, enddate);
                    }

                    Console.WriteLine(" __________ _______ ________ __________ __________________ _______________________");
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("There was a problem with data showing up! Please try again!");
                Console.WriteLine("Error type: " + e.Message);
            }
            finally { }
        }

        public static void ReadAllTrainers()
        {
            try
            {

                using (SqlConnection dbcon = new SqlConnection(connectionString))
                {
                    dbcon.Open();
                    SqlCommand command = new SqlCommand("select * from Trainer", dbcon);
                    SqlDataReader reader = command.ExecuteReader();

                    Console.WriteLine(" ___________ ______________ _______________ ____________________");
                    Console.WriteLine("| TrainerID |  First Name  |    Last Name  |      Subject       |");
                    Console.WriteLine(" ___________ ______________ _______________ ____________________");

                    while (reader.Read())
                    {
                        var trainerid = reader["Trainer_ID"];
                        var firstName = reader["FirstName"];
                        var lastName = reader["LastName"];
                        var subject = reader["TSubject"];

                        Console.WriteLine("|{0,11}|{1,14}|{2,17}|{3,20}|", trainerid, firstName, lastName, subject);
                    }

                    Console.WriteLine(" ___________ ______________ ______________ ______________________");
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("There was a problem with data showing! Please try again!");
                Console.WriteLine("Error type: " + e.Message);
            }
            finally { }
        }

        public static void ReadAllProjects()
        {
            try
            {
                using (SqlConnection dbcon = new SqlConnection(connectionString))
                {
                    dbcon.Open();
                    SqlCommand cmd = new SqlCommand("select * from Project", dbcon);
                    SqlDataReader reader = cmd.ExecuteReader();

                    Console.WriteLine(" ___________ _____________________ _____________________________________________ ______________________");
                    Console.WriteLine("| ProjectID |        Title        |                   Details                   |     SubmissionDate   |");
                    Console.WriteLine(" ___________ _____________________ _____________________________________________ ______________________");

                    while (reader.Read())
                    {
                        var projectid = reader["Project_ID"];
                        var title = reader["Title"];
                        var details = reader["Details"];
                        var submissiondate = reader["SubmissionDate"];

                        Console.WriteLine("|{0,12}|{1,21}|{2,44}|{3,16}|", projectid, title, details, submissiondate);
                    }

                    Console.WriteLine(" ___________ _____________________  ___________________________________________ _____________________");
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("There was a problem with data showing! Please try again!");
                Console.WriteLine("Error type: " + e.Message);
            }
            finally { }
        }

        public static void ReadAllStudentsPerCourse()
        {
            try
            {
                using (SqlConnection dbcon = new SqlConnection(connectionString))
                {
                    dbcon.Open();
                    SqlCommand command = new SqlCommand("select S.FirstName, S.LastName, C.Title, C.CType, TuitionFees, SPC.Student_ID, SPC.Course_ID " +
                                                         "from StudentPerCourse SPC " +
                                                         "inner join Student S on S.Student_ID = SPC.Student_ID " +
                                                         "inner join Course C on C.Course_ID = SPC.Course_ID ", dbcon);


                    SqlDataReader reader = command.ExecuteReader();

                    Console.WriteLine("____________ __________ _________________ _________________ __________ ___________ _________");
                    Console.WriteLine("| StudentID | CourseID  |   First Name   |    Last Name    |   Title  |    Type   |   Fees  |");
                    Console.WriteLine("____________ __________ _________________ _________________ __________ ___________ _________ ");


                    while (reader.Read())
                    {
                        var studentid = reader["Student_ID"];
                        var courseid = reader["Course_ID"];
                        var firstname = reader["FirstName"];
                        var lastname = reader["LastName"];
                        var title = reader["Title"];
                        var type = reader["CType"];
                        var tuitionfees = reader["TuitionFees"];


                        Console.WriteLine("|{0,10}|{1,10}|{2,18}|{3,17}|{4,10}|{5,11}|{6,9}|", studentid, courseid, firstname, lastname, title, type, tuitionfees);
                    }

                    Console.WriteLine("____________ __________ __________________ _________________ __________ ___________ __________");
                }

            }
            catch (SqlException e)
            {
                Console.WriteLine("There was a problem with data showing! Please try again!");
                Console.WriteLine("Error type: " + e.Message);
            }
            finally { }
        }

        public static void ReadAllTrainersPerCourse()
        {
            try
            {
                using (SqlConnection dbcon = new SqlConnection(connectionString))
                {
                    dbcon.Open();
                    SqlCommand command = new SqlCommand("select T.FirstName, T.LastName, T.TSubject, C.Title, C.CType, TPC.Trainer_ID, TPC.Course_ID " +
                                                         "from TrainerPerCourse TPC " +
                                                         "inner join Trainer T on T.Trainer_ID = TPC.Trainer_ID " +
                                                         "inner join Course C on C.Course_ID = TPC.Course_ID ", dbcon);


                    SqlDataReader reader = command.ExecuteReader();

                    Console.WriteLine("____________ __________ _________________ _________________ ____________________ _______ _________ ");
                    Console.WriteLine("| TrainerID | CourseID  |   First Name   |    Last Name    |       Subject      | Title |  Type   | ");
                    Console.WriteLine("____________ __________ _________________ _________________ ____________________ _______ _________ ");


                    while (reader.Read())
                    {
                        var trainerid = reader["Trainer_ID"];
                        var courseid = reader["Course_ID"];
                        var firstname = reader["FirstName"];
                        var lastname = reader["LastName"];
                        var subject = reader["TSubject"];
                        var title = reader["Title"];
                        var type = reader["CType"];


                        Console.WriteLine("|{0,10}|{1,10}|{2,18}|{3,17}|{4,20}|{5,7}|{6,9}|", trainerid, courseid, firstname, lastname, subject, title, type);
                    }

                    Console.WriteLine("____________ __________ __________________ _________________ ___________________ ________ ________ ");
                }

            }
            catch (SqlException e)
            {
                Console.WriteLine("There was a problem with data showing! Please try again!");
                Console.WriteLine("Error type: " + e.Message);
            }
            finally { }
        }

        public static void ReadAllProjectsPerCourse()
        {
            try
            {
                using (SqlConnection dbcon = new SqlConnection(connectionString))
                {
                    dbcon.Open();
                    SqlCommand command = new SqlCommand("select C.Title, C.CType, P.Title, PPS.Project_ID, PPS.Course_Id " +
                                                         "from ProjectPerStudent PPS " +
                                                         "inner join Project P on P.Project_ID = PPS.Project_ID " +
                                                         "inner join COURSE C on C.Course_ID = PPS.Course_ID ", dbcon);


                    SqlDataReader reader = command.ExecuteReader();

                    Console.WriteLine("____________ __________  _____________ __________ ______________");
                    Console.WriteLine("| ProjectID | CourseID | Course Title |   Type   | Project Title|");
                    Console.WriteLine("____________ __________  _____________ __________ _______________");


                    while (reader.Read())
                    {
                        var projectid = reader["Project_ID"];
                        var courseid = reader["Course_ID"];
                        var coursetitle = reader["Title"];
                        var type = reader["CType"];
                        var projecttitle = reader["Title"];


                        Console.WriteLine("|{0,10}|{1,10}|{2,16}|{3,9}|{4,13}|", projectid, courseid, coursetitle, type, projecttitle);
                    }

                    Console.WriteLine("____________ __________ _______________ _________ _____________");
                }

            }
            catch (SqlException e)
            {
                Console.WriteLine("There was a problem with data showing! Please try again!");
                Console.WriteLine("Error type: " + e.Message);
            }
            finally { }
        }

        public static void ReadAllProjectsPerStudent()
        {
            try
            {
                using (SqlConnection dbcon = new SqlConnection(connectionString))
                {
                    dbcon.Open();
                    SqlCommand command = new SqlCommand("select C.Title, C.CType, P.Title, PPS.Project_ID, PPS.Course_Id " +
                                                         "from ProjectPerStudent PPS " +
                                                         "inner join Project P on P.Project_ID = PPS.Project_ID " +
                                                         "inner join COURSE C on C.Course_ID = PPS.Course_ID ", dbcon);


                    SqlDataReader reader = command.ExecuteReader();

                    Console.WriteLine("____________ __________  _____________ __________ ______________");
                    Console.WriteLine("| ProjectID | CourseID | Course Title |   Type   | Project Title|");
                    Console.WriteLine("____________ __________  _____________ __________ _______________");


                    while (reader.Read())
                    {
                        var projectid = reader["Project_ID"];
                        var courseid = reader["Course_ID"];
                        var coursetitle = reader["Title"];
                        var type = reader["CType"];
                        var projecttitle = reader["Title"];


                        Console.WriteLine("|{0,10}|{1,10}|{2,16}|{3,9}|{4,13}|", projectid, courseid, coursetitle, type, projecttitle);
                    }

                    Console.WriteLine("____________ __________ _______________ _________ _____________");
                }

            }
            catch (SqlException e)
            {
                Console.WriteLine("There was a problem with data showing! Please try again!");
                Console.WriteLine("Error type: " + e.Message);
            }
            finally { }
        }


    }


}

