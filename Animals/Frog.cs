﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Frog:Animal
    {
         public Frog(string name, double age, Gender gender)
           : base(name, age, gender)
       { 
       }
       
       public override void ProduceSound()
       {
           Console.WriteLine("I am frog and I say: kraya-kraya-kraya");
       }
    }
}
