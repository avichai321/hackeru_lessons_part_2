using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_12__homework
{
    class dog: lAnimal, IMakeSoundable 
    {
        public void Eat()
        {
            Console.WriteLine("bring me bone");
        }
        public void Sleep()
        {
            Console.WriteLine("zzzzzzzzzzzzzzzzzz");
        }
        public void Move()
        {
            Console.WriteLine("watch your back idiot");
        }

        public void MakeSoundBeforeEating()
        {
            Console.WriteLine("bark bark");
            Eat();
        }
    }

}
