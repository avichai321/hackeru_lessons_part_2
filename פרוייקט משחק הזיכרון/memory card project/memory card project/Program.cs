using System;

namespace memory_card_project
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();

            //int[,] game = Enter_value_to_bored(create_game_bored());
            //Game(game);
            //char[,] game2 = Enter_value_to_bored2(create_game_bored2());
            //Game2(game2);
        }
        #region Choose game 2 players or player vs pc

        public static void menu()
        {
            Console.WriteLine("Wellcome to our memory card game\nprees 1 of the options:\n1.player 1 VS player 2\n2.player VS PC");
            int choise = int.Parse(Console.ReadLine());
            if (choise == 2)
            {
                P1_VS_PC();
            }
        }
        public static void P1_VS_PC()
        {
            Console.WriteLine("prees 1 of the options:\n1.with Numbers\n2.with Chars");
            int g_choise = int.Parse(Console.ReadLine());
            if (g_choise == 1)
            {
                Game_PC_Numbers(Enter_value_to_bored(create_game_bored()));
            }
            else if (g_choise == 2)
            {
                Game_PC_Chars(Enter_value_to_bored2(create_game_bored2()));
            }
            else
            {
                Console.WriteLine("please enter 1 or 2!\n");
                P1_VS_PC();
            }
        }
        public static void P1_VS_P2()
        {
            Console.WriteLine("Enter player 1 name:");
            string player_1 = Console.ReadLine();
            Console.WriteLine("Enter player 2 name:");
            string player_2 = Console.ReadLine();
            Console.WriteLine("prees 1 of the options:\n1.with Numbers\n2.with Chars");
            int g_choise = int.Parse(Console.ReadLine());
            if (g_choise == 1)
            {
                Game_PC_Numbers(Enter_value_to_bored(create_game_bored()));
            }
            else if (g_choise == 2)
            {
                Game_PC_Chars(Enter_value_to_bored2(create_game_bored2()));
            }
            else
            {
                Console.WriteLine("please enter 1 or 2!\n");
                P1_VS_P2();
            }
        }
        #endregion

        #region Game options
        public static void Game_PC_Chars(char[,] game_bored)
        {
            int FirstCardRow, FirstCardColumn, SecondCardRow, SecondCardColumn;
            int sum_points = 0;
            int pairs = (game_bored.GetLength(0) * game_bored.GetLength(1)) / 2;
            while (sum_points != pairs)
            {
                Print_Bored2(game_bored);

                Console.WriteLine("choose first card row: ");
                FirstCardRow = int.Parse(Console.ReadLine());
                Console.WriteLine("choose first card column: ");
                FirstCardColumn = int.Parse(Console.ReadLine());
                char card1 = game_bored[FirstCardRow - 1, FirstCardColumn - 1];
                Console.WriteLine(card1);

                Console.WriteLine("choose second card row: ");
                SecondCardRow = int.Parse(Console.ReadLine());
                Console.WriteLine("choose second card column: ");
                SecondCardColumn = int.Parse(Console.ReadLine());
                char card2 = game_bored[SecondCardRow - 1, SecondCardColumn - 1];
                Console.WriteLine(card2);

                if (card1 == card2)
                {
                    game_bored[FirstCardRow - 1, FirstCardColumn - 1] = (char)33;
                    game_bored[SecondCardRow - 1, SecondCardColumn - 1] = (char)33;
                    sum_points++;
                }

            }
            Console.WriteLine("congrats, you finish the game");
        }
        public static void Game_PC_Numbers(int[,] game_bored)
        {
            int FirstCardRow, FirstCardColumn, SecondCardRow, SecondCardColumn;
            int points = 0;
            int pairs = (game_bored.GetLength(0) * game_bored.GetLength(1)) / 2;
            while (points != pairs)
            {
                Print_Bored(game_bored);

                Console.WriteLine("choose first card row: ");
                FirstCardRow = int.Parse(Console.ReadLine());
                Console.WriteLine("choose first card column: ");
                FirstCardColumn = int.Parse(Console.ReadLine());
                int card1 = game_bored[FirstCardRow - 1, FirstCardColumn - 1];
                Console.WriteLine(card1);

                Console.WriteLine("choose second card row: ");
                SecondCardRow = int.Parse(Console.ReadLine());
                Console.WriteLine("choose second card column: ");
                SecondCardColumn = int.Parse(Console.ReadLine());
                int card2 = game_bored[SecondCardRow - 1, SecondCardColumn - 1];
                Console.WriteLine(card2);

                if (card1 == card2)
                {
                    game_bored[FirstCardRow - 1, FirstCardColumn - 1] = 0;
                    game_bored[SecondCardRow - 1, SecondCardColumn - 1] = 0;
                    points++;
                }

            }
            Console.WriteLine("congrats, you finish the game");
        }
        #endregion
        //P1 VS P2


        //VS PC
        #region challenge! game functions with chars PC
        public static char[,] create_game_bored2()
        {
            Console.WriteLine("Enter the size for the bored you want to play (example: Enter 4 for 4X4 and please enter equal number ): ");
            int bored_size = int.Parse(Console.ReadLine());

            return (bored_size > 0 && bored_size < 8 && bored_size % 2 == 0 ? new char[bored_size, bored_size] : create_game_bored2());
        }
        public static char[,] Enter_value_to_bored2(char[,] m_bored)
        {
            Random rand = new Random();
            Random ascii = new Random();
            int cards_amount = m_bored.GetLength(0) * m_bored.GetLength(1);
            int pair = cards_amount / 2;
            for (int i = 1; i <= pair; i++)
            {
                char letter = (char)ascii.Next(65, 90);
                int Flag = 0;
                while (Flag != 2)
                {
                    int row = rand.Next(0, m_bored.GetLength(0));
                    int column = rand.Next(0, m_bored.GetLength(1));
                    if (m_bored[row, column] == 0)
                    {
                        m_bored[row, column] = letter;
                        Flag++;
                    }
                }

            }
            return m_bored;
        }
        public static void Print_Bored2(char[,] game_bored)
        {
            for (int i = 0; i < game_bored.GetLength(0); i++)
            {
                for (int k = 0; k < game_bored.GetLength(1); k++)
                {
                    if (game_bored[i, k] == (char)33)
                    {
                        Console.Write(game_bored[i, k] + "\t");
                    }
                    else
                    {
                        Console.Write("*" + "\t");
                    }
                }
                Console.WriteLine();
            }
        }
        #endregion

        #region game functions with numbers PC
        public static int[,] create_game_bored()
        {
            Console.WriteLine("Enter the size for the bored you want to play (example: Enter 4 for 4X4 and please enter equal number ): ");
            int bored_size = int.Parse(Console.ReadLine());

            return (bored_size > 0 && bored_size < 8 && bored_size % 2 == 0 ? new int[bored_size, bored_size] : create_game_bored());
        }
        public static int[,] Enter_value_to_bored(int[,] m_bored)
        {
            Random rand = new Random();
            int cards_amount = m_bored.GetLength(0) * m_bored.GetLength(1);
            int pair = cards_amount / 2;
            for (int i = 1; i <= pair; i++)
            {
                int Flag = 0;
                while (Flag != 2)
                {
                    int row = rand.Next(0, m_bored.GetLength(0));
                    int column = rand.Next(0, m_bored.GetLength(1));
                    if (m_bored[row, column] == 0)
                    {
                        m_bored[row, column] = i;
                        Flag++;
                    }
                }
            }
            return m_bored;
        }
        public static void Print_Bored(int[,] game_bored)
        {
            for (int i = 0; i < game_bored.GetLength(0); i++)
            {
                for (int k = 0; k < game_bored.GetLength(1); k++)
                {
                    if (game_bored[i, k] == 0)
                    {
                        Console.Write(game_bored[i, k] + "\t");
                    }
                    else
                    {
                        Console.Write("*" + "\t");
                    }
                }
                Console.WriteLine();
            }
        }
        #endregion

    }
}
