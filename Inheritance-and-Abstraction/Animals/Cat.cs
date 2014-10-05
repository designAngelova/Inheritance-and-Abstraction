using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Cat:Animal
    {
         public Cat(string name, double age, Gender gender)
           : base(name, age, gender)
       { 
       }
       
       public override void ProduceSound()
       {
           Console.WriteLine("I am cat and I say: miauuuu");
       }
    }
}
