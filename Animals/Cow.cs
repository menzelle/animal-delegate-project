using AnimalDelegateProject.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalDelegateProject.Animals
{
    class Cow : IAnimal
    {
        public string MakeNoise()
        {
            return "Moo";
        }
    }
}
