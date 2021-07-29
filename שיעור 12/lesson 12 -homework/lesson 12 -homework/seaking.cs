using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_12__homework
{
    class seaking : lAnimal, IMakeSoundable
    {
        public void Eat()
        {
            Console.WriteLine("where is shirahishi");
        }
        public void Sleep()
        {
            Console.WriteLine("we dont sleep");
        }
        public void Move()
        {
            Console.WriteLine("i dont move i swim only in grand line");
        }
        public void MakeSoundBeforeEating()
        {
            Console.WriteLine("i can eat everyting!");
            Eat();
        }
    }
}
