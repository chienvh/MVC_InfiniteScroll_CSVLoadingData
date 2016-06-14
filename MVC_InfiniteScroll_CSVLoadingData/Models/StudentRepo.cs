using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace MVC_InfiniteScroll_CSVLoadingData.Models
{
    public class StudentRepo
    {
        // Get list students from csv file
        public IEnumerable<Student> ListStudents()
        {
            string studentFile = HostingEnvironment.MapPath("~/App_Data/Students.csv");

            foreach (string line in System.IO.File.ReadAllLines(studentFile))
            {
                var parts = line.Split('|');
                yield return new Student
                {
                    ID = parts[0],
                    Name = parts[1],
                    Email = parts[2]
                };
            }
        }
    }
}