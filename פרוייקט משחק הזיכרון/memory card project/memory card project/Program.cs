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
            int[,] game = Enter_value_to_bored(create_game_bored());
            Print_Bored(game);
        }

        public static int[,] create_game_bored()
        {
            Console.WriteLine("Enter the size for the bored you want to play (example: Enter 4 for 4X4 and please enter equal number ): ");
            int bored_size = int.Parse(Console.ReadLine());

            return (bored_size>0 && bored_size<8 && bored_size%2==0 ? new int [bored_size,bored_size]: create_game_bored());
        }

        public static int[,] Enter_value_to_bored(int[,] m_bored)
        {
            Random rand = new Random();
            int cards_amount = m_bored.GetLength(0) * m_bored.GetLength(1);
            int pair = cards_amount / 2;
            for (int i = 1; i <= pair; i++)
            {
                int Flag = 0;
                while (Flag!=2)
                {
                    int row = rand.Next(0, m_bored.GetLength(0));
                    int column = rand.Next(0, m_bored.GetLength(1));
                    if (m_bored[row , column] == 0)
                    {
                        m_bored[row,column] = i;
                        Flag++;
                    }
                }
            }
            return m_bored;
        }

        public static void game(int[,] game_bored)
        {
            int FirstCardRow, FirstCardColumn, SecondCardRow, SecondCardColumn;
            Console.WriteLine("choose first card row: ");
            FirstCardRow = int.Parse(Console.ReadLine());
            Console.WriteLine("choose first card column: ");
            FirstCardColumn = int.Parse(Console.ReadLine());
            Console.WriteLine("choose second card row: ");
            SecondCardRow = int.Parse(Console.ReadLine());
            Console.WriteLine("choose second card column: ");
            SecondCardColumn = int.Parse(Console.ReadLine());


        }
        public static void Print_Bored(int[,] game_bored)
        {
            for (int i = 0; i < game_bored.GetLength(0); i++)
            {
                for (int k = 0; k < game_bored.GetLength(1); k++)
                {
                    if (game_bored[i, k] == 0)
                    {
                        Console.Write(game_bored[i,k]+ "\t");
                    }
                    else
                    {
                        Console.Write("*"+"\t");
                    }
                }
                Console.WriteLine();
            }
        }
   
        
    }
}
