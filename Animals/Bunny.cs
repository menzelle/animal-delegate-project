using AnimalDelegateProject.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalDelegateProject.Animals
{
    class Bunny : IAnimal
    {
        public string MakeNoise()
        {
            return "That's all folks!";
        }
    }
}
