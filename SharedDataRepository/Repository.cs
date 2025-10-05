using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedDataRepository
{
    public  class Repository
    {
        public static List<clsStudent> GetStudents() => new List<clsStudent>()
        {
            new clsStudent { id = 1, name = "Mostafa", Age = 20 },
            new clsStudent { id = 2, name = "Sara", Age = 22 },
            new clsStudent { id = 3, name = "Omar", Age = 19 },
            new clsStudent { id = 4, name = "Laila", Age = 21 },
            new clsStudent { id = 5, name = "Ahmed", Age = 23 },
            new clsStudent { id = 6, name = "Hana", Age = 20 },
            new clsStudent { id = 7, name = "Youssef", Age = 24 },
            new clsStudent { id = 8, name = "Mona", Age = 22 },
            new clsStudent { id = 9, name = "Khaled", Age = 25 },
            new clsStudent { id = 10, name = "Nada", Age = 21 },
            new clsStudent {id=11,name="Tarek",Age=19}

        };

        public static List<clsCourses> GetCourses() => new List<clsCourses>()
        {
            new clsCourses { id = 101, Title = "C# Basics" },
            new clsCourses { id = 102, Title = "Advanced LINQ" },
            new clsCourses { id = 103, Title = "SQL Fundamentals" },
            new clsCourses { id = 104, Title = "ASP.NET Core" },
            new clsCourses { id = 105, Title = "Entity Framework Core" },
            new clsCourses { id = 106, Title = "Data Structures" },
            new clsCourses { id = 107, Title = "Algorithms" },
            new clsCourses { id = 108, Title = "Design Patterns" },
            new clsCourses { id = 109, Title = "Cloud Computing" },
            new clsCourses { id = 110, Title = "Machine Learning" }
        };

        public static List<clsEnrollments> GetEnrollments() => new List<clsEnrollments>()
        {
            new clsEnrollments { StudentId = 1, CourseId = 101, Grade = 90 },
            new clsEnrollments { StudentId = 1, CourseId = 102, Grade = 85 },
            new clsEnrollments { StudentId = 1, CourseId = 103, Grade = 88 },
            new clsEnrollments { StudentId = 2, CourseId = 101, Grade = 95 },
            new clsEnrollments { StudentId = 2, CourseId = 104, Grade = 78 },
            new clsEnrollments { StudentId = 3, CourseId = 103, Grade = 70 },
            new clsEnrollments { StudentId = 3, CourseId = 104, Grade = 88 },
            new clsEnrollments { StudentId = 4, CourseId = 105, Grade = 92 },
            new clsEnrollments { StudentId = 4, CourseId = 106, Grade = 81 },
            new clsEnrollments { StudentId = 5, CourseId = 101, Grade = 80 },
            new clsEnrollments { StudentId = 5, CourseId = 103, Grade = 75 },
            new clsEnrollments { StudentId = 5, CourseId = 105, Grade = 60 },
            new clsEnrollments { StudentId = 6, CourseId = 106, Grade = 89 },
            new clsEnrollments { StudentId = 6, CourseId = 107, Grade = 93 },
            new clsEnrollments { StudentId = 7, CourseId = 108, Grade = 77 },
            new clsEnrollments { StudentId = 7, CourseId = 109, Grade = 85 },
            new clsEnrollments { StudentId = 8, CourseId = 102, Grade = 91 },
            new clsEnrollments { StudentId = 8, CourseId = 110, Grade = 87 },
            new clsEnrollments { StudentId = 9, CourseId = 103, Grade = 65 },
            new clsEnrollments { StudentId = 9, CourseId = 107, Grade = 72 },
            new clsEnrollments { StudentId = 10, CourseId = 101, Grade = 99 },
            new clsEnrollments { StudentId = 10, CourseId = 110, Grade = 94 }
        };
    }
}
