using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
   public class Dog:Animal
    {
       public Dog(string name, double age, Gender gender)
           : base(name, age, gender)
       { 
       }
       
       public override void ProduceSound()
       {
           Console.WriteLine("I am dog and I bauuu");
       }
       
    }
}
