using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class TestAnimals
    {
        static void Main()
        {
            Animal sharo = new Dog("Sharo", 2.4, Gender.Male);
            Animal chara = new Dog("Chara", 5.8, Gender.Female);
            Animal kiara = new Cat("Kiara", 1, Gender.Female);
            Animal Kondio = new Cat("Kondio", 3.5, Gender.Male);
            Animal genka = new Frog("Genka", 3, Gender.Female);
            Animal pesho = new Frog("pesho", 0.5, Gender.Male);
            Animal stela = new Kitten("Stela", 9);
            Animal tomy = new Tomcat("Tomy", 4.6);

            List<Animal> animals = new List<Animal>(){
                sharo,
                chara,
                kiara,
                Kondio,
                genka,
                pesho,
                stela,
                tomy};
            var sortedAnimals =
                from an in animals
                group an by (an is Cat) ? typeof(Cat) : an.GetType() into g
                select new { GroupName = g.Key, AverageAge = g.ToList().Average(an => an.Age) };
            foreach (var animal in sortedAnimals)
            {
                Console.WriteLine("{0} - average age: {1:N2}", animal.GroupName.Name, animal.AverageAge);
            }
        }
    }
}
