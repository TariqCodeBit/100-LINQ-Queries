using System;
using System.Linq;
using System.Collections.Generic;
using SharedDataRepository;
using System.Threading.Tasks;
namespace StudentManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Query29();
            Console.ReadKey();
        }
        static void Query1()
        {
            // Q1: Get all students.

            var AllStudents = Repository.GetStudents();


            foreach (var i in AllStudents)
                Console.WriteLine($" ID : {i.id} , Name : {i.name} , Age : {i.Age}");
           

        }
        static void Query2()
        {
            // Q2: Get only the names of students.


            var AllStudents = Repository.GetStudents();

            var GetOnlyNameOf_Students = AllStudents.Select(x => x.name);
            foreach (var i in GetOnlyNameOf_Students)
            {
                Console.WriteLine($" Name : {i} ");
            }

        }
        static void Query3()
        {
            // Q3: Get students whose age is greater than 21.


            var AllStudents = Repository.GetStudents();

            var OnlyStudentsWhoseAgeisGreaterThan_21 = AllStudents.Where(x => x.Age > 21);
            foreach (var i in OnlyStudentsWhoseAgeisGreaterThan_21)
            {
                Console.WriteLine($" ID : {i.id} , Name : {i.name} , Age : {i.Age}");
            }

        }
        static void Query4()
        {
            // Q4: Get the first student.

            var AllStudents = Repository.GetStudents();

            var FirstStudent = AllStudents.FirstOrDefault(); // if list empty return null take care


            Console.WriteLine($" ID : {FirstStudent.id} , Name : {FirstStudent.name} , Age : {FirstStudent.Age}");


        }
        static void Query5()
        {
            // Q5: Get the last student.


            var AllStudents = Repository.GetStudents();

            var LastStudent = AllStudents.LastOrDefault(); // if list empty return null


            Console.WriteLine($" ID : {LastStudent.id} , Name : {LastStudent.name} , Age : {LastStudent.Age}");


        }
        static void Query6()
        {
            // Q6: Count the number of students.

            var AllStudents = Repository.GetStudents();

            int NumberOf_Students = AllStudents.Count();


            Console.WriteLine($" count : {NumberOf_Students} ");


        }
        static void Query7()
        {
            // Q7: Check if there is any student with age = 25.
            var AllStudents = Repository.GetStudents();

            bool IsStudentWithAge_25  = AllStudents.Any(x => x.Age == 25);

            if (IsStudentWithAge_25) Console.WriteLine("True");
            else Console.WriteLine("Fasle");
        }
        static void Query8()
        {
            // Q8: Find the student whose name is "Mostafa".

            var AllStudents = Repository.GetStudents();

            clsStudent Nameis_Mostafa = AllStudents.FirstOrDefault(x => x.name == "Mostafa");

            Console.WriteLine($" ID : {Nameis_Mostafa.id} , Name : {Nameis_Mostafa.name} , Age : {Nameis_Mostafa.Age}");
        }
        static void Query9()
        {
            // Q9: Order students by age ascending.


            var AllStudents = Repository.GetStudents();

            IEnumerable<clsStudent> OrderStudentsASCByAge = AllStudents.OrderBy(x => x.Age);
            foreach (var i in OrderStudentsASCByAge)
                Console.WriteLine($" ID : {i.id} , Name : {i.name} , Age : {i.Age}");

        }
        static void Query10()
        {
            // Q10: Get the maximum age among students.

            var AllStudents = Repository.GetStudents();

            var Maximumage = AllStudents.MaxBy(x => x.Age);// MaxBy ---> return object of same type (clsStudentsa) [diff] Max ---->return maximum value (int)
            Console.WriteLine($" ID : {Maximumage.id} , Name : {Maximumage.name} , Age : {Maximumage.Age}");

        }
        static void Query11()
        {
            // Q11: Get students with age between 20 and 23.


            var AllStudents = Repository.GetStudents();

            var StudentsAgeBetween_20_And_23 = AllStudents.Where(x => x.Age >= 20 && x.Age <= 23);
            foreach (var i in StudentsAgeBetween_20_And_23)
                Console.WriteLine($" ID : {i.id} , Name : {i.name} , Age : {i.Age}");

        }
        static void Query12()
        {
            //Get all student names in uppercase



            var AllStudents = Repository.GetStudents();

            var NameStudentinUpperCase = AllStudents.Select(x => x.name.ToUpper());
            foreach (var i in NameStudentinUpperCase)
                Console.WriteLine($" Name {i} ");

        }
        static void Query13()
        {
            // Q13: Order students by name alphabetically.

            var AllStudents = Repository.GetStudents();

            var OrderByNameASC = AllStudents.OrderBy(x => x.name);
            foreach (var i in OrderByNameASC)
                Console.WriteLine($" ID : {i.id} , Name : {i.name} , Age : {i.Age}");

        }
        static void Query14()
        {
            // Q14: Get the youngest student.

            var AllStudents = Repository.GetStudents();

            var YoungestStudent = AllStudents.MinBy(x => x.Age);

            Console.WriteLine($" ID : {YoungestStudent.id} , Name : {YoungestStudent.name} , Age : {YoungestStudent.Age}");

        }
        static void Query15()
        {
            // Q15: Get all course titles.


            var AllCourses = Repository.GetCourses();

            IEnumerable<string> AllTitles = AllCourses.Select(x => x.Title);
            foreach (var i in AllTitles)
                Console.WriteLine($" Title {i} ");
        }
        static void Query16()
        {
            // Q16: Count how many courses exist.

            List<clsCourses> AllCourses = Repository.GetCourses();

            var NumberCourses = AllCourses.Count();
            Console.WriteLine(NumberCourses);
        }
        static void Query17()
        {
            // Q17: Select each student’s name and age in a formatted string. 

            List<clsStudent> AllCourses = Repository.GetStudents();

            var  SelcteachStudentsNameAndAgeOnly  = AllCourses.Select(s=> new { s.name, s.Age });//Anonymous type
            foreach (var i in SelcteachStudentsNameAndAgeOnly)
                Console.WriteLine($" Name : {i.name} , Age : {i.Age}");
        }
        static void Query18()
        {
            // Q18: Get students whose names start with "M". 

            List<clsStudent> AllCourses = Repository.GetStudents();

            var StartWith_M = AllCourses.Where(x=>x.name.StartsWith('M'));
            foreach (var i in StartWith_M)
                Console.WriteLine($"ID : {i.id} Name : {i.name} , Age : {i.Age}");
        }
        static void Query19()
        {
            // Q19: Get IDs of students who are enrolled in more than one course. 

            var AllEnrollments = Repository.GetEnrollments();

            var EnrolledinMorethanOneCourse = AllEnrollments.GroupBy(x => x.StudentId).Where(c => c.Count() > 1).Select(g => g.Key);
            foreach (var i in EnrolledinMorethanOneCourse)
                Console.WriteLine($"ID : {i} ");

        }
        static void Query20()
        {
                //Q20: Get IDs of students who scored less than 80 in any course.

            var AllEnrollments = Repository.GetEnrollments();

            var ScoredlessThan80 = AllEnrollments.Where(x => x.Grade < 80).Select(x=>x.StudentId).Distinct();
            foreach (var i in ScoredlessThan80)
                Console.WriteLine($"ID : {i} ");

        }
        static void Query21()
        {
            // Q21: Return student names with the courses they enrolled in and their grade.

            var AllEnrollments = Repository.GetEnrollments();
            var AllStudents = Repository.GetStudents();
            var AllCourses = Repository.GetCourses();

            var Studentname_Courses_Grade = from enro in AllEnrollments
                                   join Stud in AllStudents on enro.StudentId equals Stud.id
                                   join cou in AllCourses on enro.CourseId equals cou.id
                                   select (new { Stud.name, enro.Grade,cou.Title });



            foreach (var i in Studentname_Courses_Grade)
                Console.WriteLine($" Student name : {i.name}   Courser name  : {i.Title}       Grade : {i.Grade} ");

        }
        static void Query22()
        {
            // Q22: Get names of students enrolled in course "C# Basics".

            var AllEnrollments = Repository.GetEnrollments();
            var AllStudents = Repository.GetStudents();
            var AllCourses = Repository.GetCourses();

            var Name_Course = from Enro in AllEnrollments
                              join Stud in AllStudents on Enro.StudentId equals Stud.id
                              join Cour in AllCourses on Enro.CourseId equals Cour.id
                              where (Cour.Title == "C# Basics")
                              select new { Stud.name, Cour.Title, Enro.Grade };
                          


            foreach (var i in Name_Course.Distinct())
                Console.WriteLine($" Student name : {i.name} ,  Courser name  : {i.Title}   ,    Grade : {i.Grade} ");

        }
        static void Query23()
        {
            // Q23: Get courses taken by the student "Sara".

            var AllEnrollments = Repository.GetEnrollments();
            var AllStudents = Repository.GetStudents();
            var AllCourses = Repository.GetCourses();

            var CourserSaraTaken = from Enro in AllEnrollments
                              join Stud in AllStudents on Enro.StudentId equals Stud.id
                              join Cour in AllCourses on Enro.CourseId equals Cour.id
                              where (Stud.name == "Sara")
                              select new { Stud.name, Cour.Title, Enro.Grade };



            foreach (var i in CourserSaraTaken.Distinct())
                Console.WriteLine($" Student name : {i.name} ,  Courser name  : {i.Title}   ,    Grade : {i.Grade} ");

        }
        static void Query24()
        {
            // Q24: Get each student with the number of courses they are enrolled in.

            var AllEnrollments = Repository.GetEnrollments();
            var AllStudents = Repository.GetStudents();
      ;

            var Number = AllStudents.GroupJoin(AllEnrollments, s => s.id, En => En.StudentId, (student, Enrol) => new
            {
                student.name,
               coursescount= Enrol.Count()
            });



            foreach(var i in Number)
            Console.WriteLine($"Number of courses {i}");

        }
        static void Query25()
        {
            // Q25: Get the highest grade for each student.

            var AllEnrollments = Repository.GetEnrollments();
            var AllStudents = Repository.GetStudents();


            var highestGread = AllStudents.GroupJoin(AllEnrollments, x => x.id, E => E.StudentId, (student, Enrol) => new
            {
                student.name,
                maxGrade = Enrol.Any() ? Enrol.Max(x => x.Grade) : 0
            });


            var highestGreadQuery = from stud in AllStudents
                                    join Enrol in AllEnrollments on
                                    stud.id equals Enrol.StudentId
                                     into Studintse
                                    select new
                                    {
                                        stud.name,
                                        Highest = Studintse.Any() ? Studintse.Max(m => m.Grade) : 0
                                    };
            
            

            foreach (var i in highestGreadQuery)
                Console.WriteLine($" Name {i.name}   , Grade => {i.Highest} ");

        }
        static void Query26()
        {

            // Q26: Get the average grade for each student.

            var AllEnrollments = Repository.GetEnrollments();
            var AllStudents = Repository.GetStudents();

            var AverageGread = AllStudents.GroupJoin(AllEnrollments, x => x.id, e => e.StudentId, (stud, result) => new
            {
                stud.name,

                Average =result.Any()? result.Average(x => x.Grade) : 0
            });

            var AvrageGreadQuery = from stud in AllStudents
                                   join enro in AllEnrollments on
                                   stud.id equals enro.StudentId
                                   into StudResult
                                   select (new { stud.name, Average = StudResult.Any() ? StudResult.Average(x => x.Grade) : 0 });

            foreach (var i in AvrageGreadQuery)
                Console.WriteLine($" Name {i.name}   , Grade => {i.Average} ");

        }
        static void Query27()
        {

            /// Q27: Get students who took "SQL Fundamentals" and scored above 80.


            var AllEnrollments = Repository.GetEnrollments();
            var AllStudents = Repository.GetStudents();
            var AllCourses = Repository.GetCourses();

            var StAndCordAbove80inSQL = from Enro in AllEnrollments
                                        join stu in AllStudents on Enro.StudentId equals stu.id
                                        join cour in AllCourses on Enro.CourseId equals cour.id
                                        where (cour.Title == "SQL Fundamentals" && Enro.Grade > 80)
                                        select (new { stu.name, cour.Title, Enro.Grade });

            

            foreach (var i in StAndCordAbove80inSQL)
                Console.WriteLine($" Name {i.name} ,CoursesTitel {i.Title}  , Grade => {i.Grade} ");

        }
        static void Query28()
        {

            // Q28: Get each course with the number of students enrolled.


            var AllEnrollments = Repository.GetEnrollments();
            var AllCourses = Repository.GetCourses();

            var numberOfStudentsEnrolled = from cour in AllCourses
                                           join enro in AllEnrollments on
                                           cour.id equals enro.CourseId
                                            into Coursen
                                           select (new { cour.Title, number = Coursen.Count() });


            foreach (var i in numberOfStudentsEnrolled)
                Console.WriteLine($" CoursesTitel {i.Title}  , Number => {i.number} ");

        }
        static void Query29()
        {

            // Q29: Get student name, course title, and grade sorted by grade descending.

            var AllStudent = Repository.GetStudents();
            var AllEnrollments = Repository.GetEnrollments();
            var AllCourses = Repository.GetCourses();

            var numberOfStudentsEnrolled = from Enrollment in AllEnrollments
                                           join Student in AllStudent
                                           on Enrollment.StudentId equals Student.id
                                           join Courses in AllCourses
                                           on Enrollment.CourseId equals Courses.id
                                           orderby Enrollment.Grade descending
                                           select (new { Student.name, Courses.Title, Enrollment.Grade });


            foreach (var i in numberOfStudentsEnrolled)
                Console.WriteLine($" name : {i.name} ,  CoursesTitel {i.Title}  , Grade => {i.Grade} ");

        }
        static void Query30()
        {

            // Q30: Get students who are not enrolled in any course.

            var AllStudent = Repository.GetStudents();
            var AllEnrollments = Repository.GetEnrollments();
            var AllCourses = Repository.GetCourses();



            foreach (var i in numberOfStudentsEnrolled)
                Console.WriteLine($" name : {i.name}   , Grade => {i.Grade} ");

        }
    }
}
