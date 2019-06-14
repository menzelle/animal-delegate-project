using AnimalDelegateProject.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalDelegateProject.Animals
{
   public class Dog : IAnimal
    {
        public string MakeNoise()
        {
            return "Bark";
        }
    }
}
