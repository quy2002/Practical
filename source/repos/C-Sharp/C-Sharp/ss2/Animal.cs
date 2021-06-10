using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    public abstract class Animal
    {
        public string kind;

        public virtual void Eat()
        {
            Console.WriteLine("Eat...");
        }

        public abstract void AnimalSound();
    }
}
