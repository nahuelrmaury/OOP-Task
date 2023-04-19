﻿using System;
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
            bear.Eat("Animal Example","Plant Example");
            bear.NameSpecie();
            bear.NameParticularIndividual();
        }
    }

    public abstract class Alive
    {
        public abstract string NameSpecie();
    }

    public abstract class Animal : Alive
    {
        public abstract string NameParticularIndividual();
    }

    public class Herbal : Alive
    {
        public override string NameSpecie()
        {
            throw new NotImplementedException();
        }
    }

    public interface IHerbivore
    {
        void Eat(string plant);
    }

    public interface ICarnivore
    {
        void Eat(string animal);
    }

    public interface IOmnivore
    {
        void Eat(string animal, string plant);
    }

    public class Herbivore : Animal, IHerbivore
    {
        public void Eat(string animal)
        {
            throw new NotImplementedException();
        }

        public override string NameParticularIndividual()
        {
            throw new NotImplementedException();
        }

        public override string NameSpecie()
        {
            throw new NotImplementedException();
        }
    }

    public class Carnivore : Animal, ICarnivore
    {
        public void Eat(string animal)
        {
            throw new NotImplementedException();
        }

        public override string NameParticularIndividual()
        {
            throw new NotImplementedException();
        }

        public override string NameSpecie()
        {
            throw new NotImplementedException();
        }
    }

    public class Omnivore : Animal, IOmnivore
    {
        public void Eat(string animal, string plant)
        {
            throw new NotImplementedException();
        }

        public override string NameParticularIndividual()
        {
            throw new NotImplementedException();
        }

        public override string NameSpecie()
        {
            throw new NotImplementedException();
        }
    }

    public class Bear : Omnivore
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

        public string Eat(string animal, string plant)
        {
            Console.WriteLine("Eat: " + animal + " and " + plant);
            return animal + " and " + plant;
        }
    }

    public class Wolf : Carnivore
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
        public string Eat(string animal)
        {
            Console.WriteLine("Eat: " + animal);
            return animal;
        }
    }

    public class Rabbit : Herbivore
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
        public string Eat(string plant)
        {
            Console.WriteLine("Eat: " + plant);
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