using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal
    {

        protected bool mammals;

        protected bool carnivorous;

        public  static readonly int MOOD_HAPPY = 1;

        public static readonly int MOOD_SCARE = 0;

        protected int mood;

        public bool isMammals() => this.mammals;

        public void setMammals(bool m)
        {
            this.mammals = m;
        }

        public bool isCarnivorous() => this.carnivorous;

        public void setCarnivorous(bool c)
        {
            this.carnivorous = c;
        }

        public Animal(bool mammals, bool carnivorous, int mood)
        {
            this.mammals = mammals;

            this.carnivorous = carnivorous;

            this.mood = mood;
        }

        public virtual void SayHello() { }

        public abstract void SayHello(int mood);

    }
}
