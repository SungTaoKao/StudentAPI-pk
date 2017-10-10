using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentAPI.Models
{
    public class DummyData
    {
        public static List<Student> GetStudent()
        {
            List<Student> students = new List<Student>()
            {
                new Student { StudentId = "A00111111", FirstName = "John", LastName = "Archer", Program = "CIT" },
                new Student { StudentId = "A00222222", FirstName = "Jane", LastName = "Baker", Program = "CST" },
                new Student { StudentId = "A00333333", FirstName = "Bill", LastName = "Carter", Program = "BTECH" },
                new Student { StudentId = "A00444444", FirstName = "Judy", LastName = "Fisher", Program = "Nursing" }
            };

            return students;
        }
    }
}