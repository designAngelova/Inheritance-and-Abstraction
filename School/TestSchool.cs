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
            Student pesho = new Student("Pesho", "201411V21");
            Student misho = new Student("Misho", "201411V13");
            Student gosho = new Student("Gosho", "201412V13");
            Student katya = new Student("Katya", "201412V19", "likes litterature, expecially indian novels of Karl May");
            IDetail[] Students = { pesho, misho, gosho, katya };

            foreach (var st in Students)
            {
                Console.WriteLine(st + "\n");
            }

            Discipline maths = new Discipline("Mathematics", new List<Student>() { pesho, gosho, misho }, 35);
            Discipline litterature = new Discipline("Litterature", new List<Student>() { gosho, misho, katya }, 15, "optional");
            Discipline informatics = new Discipline("Informatics", new List<Student>() { pesho, gosho, katya, misho }, 50, "main discipline");

            IDetail[] Disciplines = { maths, litterature, informatics };
            foreach (var item in Disciplines)
            {
                Console.WriteLine(item + "\n");
            }
            Teacher peshova = new Teacher("Peshova", new List<Discipline>() { litterature });
            Teacher dushkov = new Teacher("Dushkov", new List<Discipline>() { maths, informatics });
            IDetail[] Teachers = { peshova, dushkov };

            foreach (var item in Teachers)
            {
                Console.WriteLine(item + "\n");
            }
        }
    }
}
