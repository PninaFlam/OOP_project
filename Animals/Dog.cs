using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Dog :Animal, ILand
    {

        private int numberOfLegs;
        public Dog(bool mammals, bool carnivorous, int mood) : base(mammals, carnivorous, mood)
        {
            this.numberOfLegs = 4;
        }
        public int GetNumberOfLegs() => numberOfLegs;

        public override void SayHello()
        {
            Console.WriteLine("waggs its tails");
        }

        public override void SayHello(int mood)
        {
            if (mood == MOOD_HAPPY)

                Console.WriteLine("HOU HOU");

            else if (mood == MOOD_SCARE)

                Console.WriteLine("whooping");
        }
    }
}
