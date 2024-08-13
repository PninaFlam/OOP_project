using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Frog : Animal, IWater, ILand
    {
        private int numberOfLegs;

        public Frog(bool mammals, bool carnivorous, int mood) : base(mammals, carnivorous, mood)
        {
            this.numberOfLegs = 4;
        }

        public int GetNumberOfLegs() => numberOfLegs;

        public bool HasGills()
        {
            return false;
        }

        public bool HasLaysEggs()
        {
            return true;
        }

        public override void SayHello(int mood)
        {
            if (mood == MOOD_HAPPY)

                Console.WriteLine("quack quack quack");

            else if (mood == MOOD_SCARE)

                Console.WriteLine("plops into the water");

        }
    }
}
