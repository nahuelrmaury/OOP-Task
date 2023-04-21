using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* create a simple lightstring */ 
            Console.WriteLine("Insert simple lights quantity: ");
            int simpleLights = Convert.ToInt32(Console.ReadLine());
            Simple simpleLightstring = new Simple(simpleLights);

            /* create a colored lightstring */ 
            Console.WriteLine("Insert colored lights quantity: ");
            int coloredLights = Convert.ToInt32(Console.ReadLine());
            Colored coloredLightstring = new Colored(coloredLights);

            /* print the current state of both lightstrings */
            Console.WriteLine("Simple Lightstring:");
            Console.WriteLine(simpleLightstring.GetCurrentState());
            Console.WriteLine("Colored Lightstring:");
            Console.WriteLine(coloredLightstring.GetCurrentState());
        }
    }

    public abstract class Lightstring
    {
        public class Bulb
        {
            /* variable por serial number */
            int serialNumber;
            /* variable for on or off bulbs */
            bool On;

            public Bulb(int serialNumber)
            {
                this.serialNumber = serialNumber;
            }

            /* method to know state of the bulb */
            public bool GetState(int currentMinute)
            {
                /* if minute is even return true for even numbered bulbs */
                if (currentMinute % 2 == 0)
                {
                    On = serialNumber % 2 == 0;
                }
                else
                {
                    On = serialNumber % 2 != 0;
                }
                return On;
            }
        }

        /* abstract method to get the current state of the bulbs */
        public abstract string GetCurrentState();

        /* set color type and return color string */
        public class ColoredBulb
        {
            public Color color;
            public void SetColor(Color color)
            {
                this.color = color;
            }
        public string GetColorAsString()
            {
                return color.ToString();
            }
        }

        /* bulb init and lights quantity assignment */
        public Bulb[] bulbs;
        public int lightsAmount;
        public Lightstring(int lightsAmount)
        {
            this.lightsAmount = lightsAmount;
            bulbs = new Bulb[lightsAmount];
        }
    }

    public class Simple : Lightstring 
    {
        /* constructor to initialize buls */
        public Simple(int lightsAmount) : base(lightsAmount)
        {
            for (int i = 0; i < lightsAmount; i++)
            {
                bulbs[i] = new Bulb(i + 1);
            }
        }

        /* method to get the current state of the lights for simple bulbs */
        public override string GetCurrentState()
        {
            string currentState = "";
            string bulbState;

            for (int i = 0; i < lightsAmount; i++)
            {
                bool On = bulbs[i].GetState(DateTime.Now.Minute);
                if (On)
                {
                    bulbState = "On";
                }
                else
                {
                    bulbState = "Off";
                }
                currentState = currentState + $"Bulb {i + 1}: {bulbState}\n";
            }
            return currentState;
        }
    }

    public class Colored : Lightstring
    {
        Color[] colors = { Color.Red, Color.Yellow, Color.Green, Color.Blue };
        int colorIndex;

        /* constructor to initialize buls and set color base on serial number */ 
        public Colored(int lightsAmount) : base(lightsAmount)
        {
            for (int i = 0; i < lightsAmount; i++)
            {
                bulbs[i] = new ColoredBulb(i + 1);
                ((ColoredBulb)bulbs[i]).SetColor(colors[colorIndex]);
                colorIndex = (colorIndex + 1) % colors.Length;
            }
        }

        /* method to get the current state of the lights for colored bulbs */
        public override string GetCurrentState()
        {
            string currentState = "";
            string bulbState;
            for (int i = 0; i < lightsAmount; i++)
            {
                ColoredBulb bulb = (ColoredBulb)bulbs[i];
                bool On = bulb.GetState(DateTime.Now.Minute);
                string color = bulb.GetColorAsString();

                if (On)
                {
                    bulbState = "On";
                }
                else
                {
                    bulbState = "Off";
                }
                currentState = currentState + $"Bulb {i + 1} {bulbState} - Color: {color}\n";
            }
            return currentState;
        }

        /* colored bulb class */
        public class ColoredBulb : Bulb
        {
            Color color;
            /* method to get abd set the color of the bulb as a type and a string */
            /* constructor for colored bulb */
            public ColoredBulb(int serialNumber) : base(serialNumber)
            {
            }

            public void SetColor(Color color)
            {
                this.color = color;
            }

            public string GetColorAsString()
            {
                return color.ToString();
            }
        }
    }

    /* enumeration Color type */
    public enum Color
    {
        Red,
        Yellow,
        Green,
        Blue
    }
}