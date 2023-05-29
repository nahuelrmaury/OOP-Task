using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bear bear = new Bear();
            bear.EatAnimal("Animal food example");
            bear.EatPlant("Plant food example");
            bear.NameSpecie();
            bear.NameParticularIndividual();

            Wolf wolf = new Wolf();
            wolf.EatAnimal("Animal food example");
            wolf.NameSpecie();
            wolf.NameParticularIndividual();

            Rabbit rabbit = new Rabbit();
            rabbit.EatPlant("Plant food example");
            rabbit.NameSpecie();
            rabbit.NameParticularIndividual();

            Rose rose = new Rose();
            rose.NameSpecie();

            Grass grass = new Grass();
            grass.NameSpecie();
        }

        public abstract class Alive
        {
            public abstract string NameSpecie();
        }

        public abstract class Animal : Alive
        {
            public abstract string NameParticularIndividual();
        }

        public abstract class Herbal : Alive
        {
        }

        public interface IHerbivore
        {
            public abstract string EatPlant(string plant);
        }

        public interface ICarnivore
        {
            public abstract string EatAnimal(string animal);
        }

        public class Bear : Animal, IHerbivore, ICarnivore
        {
            public override string NameSpecie()
            {
                Console.WriteLine("Ursidae");
                return "Ursidae";
            }

            public override string NameParticularIndividual()
            {
                Console.WriteLine("Panda Bear");
                return "Panda Bear";
            }

            public string EatPlant(string plant)
            {
                Console.WriteLine("Eat plant: " + plant);
                return plant;
            }

            public string EatAnimal(string animal)
            {
                Console.WriteLine("Eat animal: " + animal);
                return animal;
            }
        }

        public class Wolf : Animal, ICarnivore
        {
            public override string NameSpecie()
            {
                Console.WriteLine("Canis lupus");
                return "Canis lupus";
            }
            public override string NameParticularIndividual()
            {
                Console.WriteLine("Canis lupus arctos");
                return "Canis lupus arctos";
            }
            public string EatAnimal(string animal)
            {
                Console.WriteLine("Eat animal: " + animal);
                return animal;
            }
        }

        public class Rabbit : Animal, IHerbivore
        {
            public override string NameSpecie()
            {
                Console.WriteLine("Oryctolagus cuniculos");
                return "Oryctolagus cuniculus";
            }
            public override string NameParticularIndividual()
            {
                Console.WriteLine("Leporidae Romerolagus");
                return "Leporidae Romerolagus";
            }
            public string EatPlant(string plant)
            {
                Console.WriteLine("Eat plant: " + plant);
                return plant;
            }
        }

        public class Rose : Herbal
        {
            public override string NameSpecie()
            {
                Console.WriteLine("Rosa rubiginosa");
                return "Rosa rubiginosa";
            }
        }

        public class Grass : Herbal
        {
            public override string NameSpecie()
            {
                Console.WriteLine("Poaceae");
                return "Poaceae";
            }
        }
    }
}