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
        }
    }

    public abstract class Lightstring
    {
        public class Bulb
        {
            int serialNumber;
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
                    On = true;
                }
                else
                {
                    On = false;
                }
                return On;
            }
        }

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
        /* constructor for bulbs */
        public Simple(int lightsAmount) : base(lightsAmount)
        {
            for (int i = 0; i < lightsAmount; i++)
            {
                bulbs[i] = new Bulb(i);
            }
        }

        public override string GetCurrentState()
        {
            string currentState = "";
            string bulbState = "";

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
                currentState = currentState + $"Bulb {i}: " + bulbState;
            }
            return currentState;
        }
    }
    public class Colored : Lightstring
    {
        Color[] colors = { Color.Red, Color.Yellow, Color.Green, Color.Blue };
        int colorIndex;

        

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