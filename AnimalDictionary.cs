using AnimalDelegateProject.Animals;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalDelegateProject
{
    class AnimalDictionary
    {
        public static Dictionary<string, string> AnimalSoundList = new Dictionary<string, string>()
        {
                {"dog", new Dog().MakeNoise() },
                {"cat",new Cat().MakeNoise() },
                {"cow", new Cow().MakeNoise() },
                {"bunny", new Bunny().MakeNoise() },

        };

    }
}
