using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    public class Mammal : Animal, IAnimalInterface, IMammalInterface
    {
        public void Sound()
        {
            Console.WriteLine("Sound...");
        }

        public void Hit()
        {
            Console.WriteLine("Hit...");
        }

        public override void AnimalSound()
        {
            Console.WriteLine("Hello");
        }

        public void Running()
        {
            base.Eat();
            Console.WriteLine("Running....");
        }

        public void Running(string msg)
        {
            Console.WriteLine(msg);
        }

        public void Running(int n)
        {
            Console.WriteLine(n);
        }

        public override void Eat()
        {
            Console.WriteLine("Eat abc...");
        }
    }
}
