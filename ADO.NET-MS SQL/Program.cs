using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_MS_SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReadDatabase.ReadAllStudents();
            //ReadDatabase.ReadAllTrainers();
            //ReadDatabase.ReadAllCourses();
            //ReadDatabase.ReadAllProjects();
            ReadDatabase.ReadAllStudentsPerCourse();
            //ReadDatabase.ReadAllTrainersPerCourse();
            ReadDatabase.ReadAllProjectsPerCourse();
            ReadDatabase.ReadAllProjectsPerStudent();
            //WriteDataBase.InsertNewStudents();

            Console.ReadKey();
        }
    }
}
