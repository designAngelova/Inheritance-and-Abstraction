using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class TestSchool
    {
        static void Main()
        {
            Student pesho = new Student("Pesho", "201411V21", "very tallented, self-critical");
            Student misho = new Student("Misho", "201411V13");

            // Student gatyo = new Student("Gosho", "201411V13"); // should throw exception
            Student gosho = new Student("Gosho", "201412V13");
            Student katya = new Student("Katya", "201412V19", "likes litterature, expecially indian novels of Karl May");

            Discipline maths = new Discipline("Mathematics", new List<Student>() { pesho, gosho, misho }, 35);
            Discipline litterature = new Discipline("Litterature", new List<Student>() { gosho, misho, katya }, 15, "optional");
            Discipline informatics = new Discipline("Informatics", new List<Student>() { pesho, gosho, katya, misho }, 50, "main discipline");

            Teacher peshova = new Teacher("Peshova", new List<Discipline>() { litterature });
            Teacher dushkov = new Teacher("Dushkov", new List<Discipline>() { maths, informatics });

            Class class201411V = new Class("201411V", new List<Student>() { pesho, misho }, new List<Teacher>() { peshova });

            // below row should throw exception
            // SchoolClass class201412 = new SchoolClass("201411V", new List<Student>() { }, new List<Teacher>() { peshova, dushkov });
            Class class201412V = new Class("201412V", new List<Student>() { }, new List<Teacher>() { peshova, dushkov });

           
        }
    }
}
