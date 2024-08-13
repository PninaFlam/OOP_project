using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Cat :Animal, ILand
    {
        private int numberOfLegs;
        public Cat(bool mammals, bool carnivorous, int mood) : base(mammals, carnivorous, mood)
        {
            this.numberOfLegs = 4;
        }
        public int GetNumberOfLegs() => numberOfLegs;
        public override void SayHello()
        {
            Console.WriteLine("meow~");
        }

        public override void SayHello(int mood)
        {
            if (mood == MOOD_HAPPY)

                Console.WriteLine("purr, purr");

            else if (mood == MOOD_SCARE)

                Console.WriteLine("hiss");
        }

    }
}
