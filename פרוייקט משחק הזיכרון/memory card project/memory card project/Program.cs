using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memory_card_project
{
    class Program
    {
        static void Main(string[] args)
        {
            int pairs= create_pairs();
            

        }

        public static int create_pairs()
        {
            Console.WriteLine("Enter the size for the bored you want to play (example: Enter 4 for 4X4 and please enter equal number ): ");
            int bored_size = int.Parse(Console.ReadLine());
            int cards_amount = bored_size * bored_size;
            int pair = cards_amount / 2;
            int[,] m_bored = new int[pair, pair];
            int row, column;
            Random cards = new Random();
            for (int i = 1; i <= pair; i++)
            {
                row = cards.Next(0, bored_size-1);
                column = cards.Next(0, bored_size-1);
                while (m_bored[row,column]!=0)
                {
                    m_bored[row, column] = i;
                }
            }
            for (int i = 1; i <= pair; i++)
            {
                row = cards.Next(0, bored_size - 1);
                column = cards.Next(0, bored_size - 1);
                while (m_bored[row, column] != 0)
                {
                    m_bored[row, column] = i;
                }
            }


            return (bored_size % 2 == 0 && bored_size> 0 && 8 > bored_size ? cards_amount / 2 : create_pairs());

        }
        public static void create_bored(int pairs)
        {
            Random rnd = new Random();
            for (int i = 0; i < m_bored.GetLength(0); i++)
            {
                for (int k = 0; k < m_bored.GetLength(1); k++)
                {
                    
                }
            }
            

        }
    }
}
