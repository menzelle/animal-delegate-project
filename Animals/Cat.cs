using AnimalDelegateProject.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalDelegateProject.Animals
{
    class Cat : IAnimal
    {
        public string MakeNoise()
        {
            return "Meow";
        }
    }
}
