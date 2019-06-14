using System;
using System.Collections.Generic;

namespace AnimalDelegateProject
{
    class Program
    {
        public delegate string delegateAnimalProperties(string animalType);

        static string GetSound(string type)
        {
             type = AnimalDictionary.AnimalSoundList[type];
            return type;
        }

        static string SetColor(string color)
        {
           var _color = color;
                return _color;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Which animal would you like to hear?");

            var _animalList = AnimalDictionary.AnimalSoundList;

            foreach (var item in _animalList.Keys)
            {
                Console.WriteLine(item.ToString());
            }
            var animal = Console.ReadLine();

            delegateAnimalProperties getSound = GetSound;
            Console.WriteLine("Your " + animal + " says " + getSound(animal));

            Console.WriteLine("What color would you like your "+ animal + " to be?");

            var color = Console.ReadLine();

            delegateAnimalProperties setColor = SetColor;
            Console.WriteLine("Your " + animal + " is now " + setColor(color));
            Console.ReadLine();

        }
    }
}
