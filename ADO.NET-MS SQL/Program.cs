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
            ReadDatabase.ReadAllStudents();
            //ReadDataBase.ReadAllTrainers();
            //ReadDataBase.ReadAllCourses();
            //ReadDataBase.ReadAllProjects();
            //ReadDataBase.ReadAllStudentsPerCourse();
            //ReadDataBase.ReadAllTrainersPerCourse();
            //ReadDataBase.ReadAllProjectsPerCourse();
            //ReadDataBase.ReadAllProjectsPerStudent();
            //WriteDataBase.InsertNewStudents();

            Console.ReadKey();
        }
    }
}
