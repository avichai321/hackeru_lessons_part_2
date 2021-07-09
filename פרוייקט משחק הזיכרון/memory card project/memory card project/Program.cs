using System;

namespace memory_card_project
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();

        }
        #region Choose game 2 players or player vs pc

        public static void menu()
        {
            Console.WriteLine("\nWellcome to our memory card game\nprees 1 of the options:\n1.player 1 VS player 2\n2.player VS PC\n3.Exit");
            int choise = int.Parse(Console.ReadLine());
            if (choise == 1)
            {
                P1_VS_P2();
            }
            else if (choise == 2)
            {
                P1_VS_PC();
            }
            else if (choise == 3)
            {
                Console.WriteLine("bye bye");
                return;
            }
            else
            {
                Console.WriteLine("Enter one of the folowing numbers only!");
            }
            menu();
        }// אפשרויות ראשונות להתחלת משחק
        public static void P1_VS_PC()
        {
            Console.WriteLine("prees 1 of the options:\n1.with Numbers\n2.with Chars\n3.Main menu");
            int g_choise = int.Parse(Console.ReadLine());
            if (g_choise == 1)
            {
                Game_PC_Numbers(create_game_bored_Number());
            }
            else if (g_choise == 2)
            {
                Game_PC_Chars(create_game_bored_Char());
            }
            else if (g_choise == 3)
            {
                return;
            }
            else
            {
                Console.WriteLine("please enter 1 or 2!\n");
                P1_VS_PC();
            }
        }//התחלת משחק בחירה בין אותיות למספרים שחקן על שחקן
        public static void P1_VS_P2()
        {
            Console.WriteLine("prees 1 of the options:\n1.with Numbers\n2.with Chars\n3.Main menu");
            int g_choise = int.Parse(Console.ReadLine());
            if (g_choise == 3)
            {
                return;
            }
            else
            {

                Console.WriteLine("Enter player 1 name:");
                string player_1 = Console.ReadLine();
                Console.WriteLine("Enter player 2 name:");
                string player_2 = Console.ReadLine();
                if (g_choise == 1)
                {
                    Game_P1_VS_P2_Numbers(create_game_bored_Number(),player_1 ,player_2);
                }
                else if (g_choise == 2)
                {
                    Game_P1_VS_P2_Chars(create_game_bored_Char(), player_1, player_2);
                }
                else
                {
                    Console.WriteLine("please enter 1 or 2!\n");
                    P1_VS_P2();
                }
            }
        }// התחלת משחק בחירה בין אותיות למספרים שחקן מול מחשב
        #endregion

        #region Game options
        public static void Game_PC_Chars(char[,] game_bored)
        {
            int FirstCardRow, FirstCardColumn, SecondCardRow, SecondCardColumn;
            int sum_points = 0;
            int check;
            int pairs = (game_bored.GetLength(0) * game_bored.GetLength(1)) / 2;
            while (sum_points != pairs)
            {
                Print_Bored_Char(game_bored);
                do
                {
                    check = 0;
                    Console.WriteLine("choose first card row: ");
                    FirstCardRow = int.Parse(Console.ReadLine());
                    Console.WriteLine("choose first card column: ");
                    FirstCardColumn = int.Parse(Console.ReadLine());
                    if (0 >= FirstCardRow || FirstCardRow > game_bored.GetLength(0) || 0 >= FirstCardColumn || FirstCardColumn > game_bored.GetLength(1))
                    {
                        Console.WriteLine("\nThere is no card such this");
                        check += 1;
                    }
                    else if (game_bored[FirstCardRow - 1, FirstCardColumn - 1] == (char)48)
                    {
                        Console.WriteLine("\nThis card has been found plese choose other");
                        check += 1;
                    }
                }
                while (check>0);
                Print_Bored_medium_Char(game_bored, FirstCardRow-1, FirstCardColumn-1);

                do
                {
                    check = 0;
                    Console.WriteLine("choose second card row: ");
                    SecondCardRow = int.Parse(Console.ReadLine());
                    Console.WriteLine("choose second card column: ");
                    SecondCardColumn = int.Parse(Console.ReadLine());
                    if (0 >= SecondCardColumn || SecondCardColumn > game_bored.GetLength(1) || 0 >= SecondCardRow || SecondCardRow > game_bored.GetLength(1))
                    {
                        Console.WriteLine("\nThere is no card such this\n");
                        check += 1;
                    }
                    else if (game_bored[SecondCardRow - 1, SecondCardColumn - 1] == (char) 48)
                    {
                        Console.WriteLine("\nThis card has been found plese choose other\n");
                        check += 1;
                    }
                    else if (SecondCardRow == FirstCardRow && SecondCardColumn == FirstCardColumn)
                    {
                        Console.WriteLine("\nyou cant choose the same card!!\n");
                        check += 1;
                    }

                }
                while (check>0);
                Print_Bored_Last_Char(game_bored, FirstCardRow-1, FirstCardColumn-1, SecondCardRow-1, SecondCardColumn-1);
                char card1 = game_bored[FirstCardRow - 1, FirstCardColumn - 1];
                Console.WriteLine($"card1: {card1}");
                char card2 = game_bored[SecondCardRow - 1, SecondCardColumn - 1];
                Console.WriteLine($"card2: {card2}");
                if (card1 == card2)
                {
                    game_bored[FirstCardRow - 1, FirstCardColumn - 1] = (char)48;
                    game_bored[SecondCardRow - 1, SecondCardColumn - 1] = (char)48;
                    sum_points++;
                    Console.WriteLine("\nCongrats you found the missing pair and you get a point\n");
                }
                else
                {
                    Console.WriteLine("\nSorry you were wrong try again next time\n");
                }
                Console.WriteLine($"your points : {sum_points}");
                continue;
            }

            Console.WriteLine("congratulation, you finish the game");
        } //משחק אותיות מול מחשב
        public static void Game_PC_Numbers(int[,] game_bored)
        {
            int FirstCardRow, FirstCardColumn, SecondCardRow, SecondCardColumn;
            int sum_points = 0;
            int pairs = (game_bored.GetLength(0) * game_bored.GetLength(1)) / 2;
            int check;
            while (sum_points != pairs)
            {
                Print_Bored_Number(game_bored);
                do
                {
                    check = 0;
                    Console.WriteLine("choose first card row: ");
                    FirstCardRow = int.Parse(Console.ReadLine());
                    Console.WriteLine("choose first card column: ");
                    FirstCardColumn = int.Parse(Console.ReadLine());
                    if (0 >= FirstCardRow || FirstCardRow > game_bored.GetLength(0) || 0 >= FirstCardColumn || FirstCardColumn > game_bored.GetLength(1))
                    {
                        Console.WriteLine("\nThere is no card such this");
                        check += 1;
                    }
                    if(game_bored[FirstCardRow - 1, FirstCardColumn - 1] == 0)
                    {
                        Console.WriteLine("\nThis card has been found plese choose other");
                        check += 1;
                    }
                }
                while (check>0);
                Print_Bored_medium_Number(game_bored, FirstCardRow - 1, FirstCardColumn - 1);

                do
                {
                    check = 0;
                    Console.WriteLine("choose second card row: ");
                    SecondCardRow = int.Parse(Console.ReadLine());
                    Console.WriteLine("choose second card column: ");
                    SecondCardColumn = int.Parse(Console.ReadLine());
                    if (0 >= SecondCardColumn || SecondCardColumn > game_bored.GetLength(1) || 0 >= SecondCardRow || SecondCardRow > game_bored.GetLength(1))
                    {
                        Console.WriteLine("\nThere is no card such this\n");
                        check += 1;
                    }
                    else if (game_bored[SecondCardRow - 1, SecondCardColumn - 1] == 0)
                    {
                        Console.WriteLine("\nThis card has been found plese choose other\n");
                        check += 1;
                    }
                    else if(SecondCardRow == FirstCardRow && SecondCardColumn == FirstCardColumn)
                    {
                        Console.WriteLine("\nyou cant choose the same card!!\n");
                        check += 1;
                    }

                }
                while (check>0);
                Print_Bored_Last_Number(game_bored,FirstCardRow-1, FirstCardColumn-1 , SecondCardRow - 1, SecondCardColumn - 1);
                int card1 = game_bored[FirstCardRow - 1, FirstCardColumn - 1];
                Console.WriteLine($"card1: {card1}");
                int card2 = game_bored[SecondCardRow - 1, SecondCardColumn - 1];
                Console.WriteLine($"card2: {card2}");
                if (card1 == card2)
                {
                    game_bored[FirstCardRow - 1, FirstCardColumn - 1] = 0;
                    game_bored[SecondCardRow - 1, SecondCardColumn - 1] = 0;
                    sum_points++;
                    Console.WriteLine("\nCongrats you found the missing pair and you get a point\n");
                }
                else
                {
                    Console.WriteLine("\nSorry you were wrong try again next time\n");
                }
                Console.WriteLine($"your points : {sum_points}");
                continue;
            }
            Console.WriteLine("congratulation, you finish the game");
        }//משחק מספרים מול מחשב
        public static void Game_P1_VS_P2_Numbers(int[,] game_bored, string player1, string player2)
        {
            int FirstCardRow, FirstCardColumn, SecondCardRow, SecondCardColumn;
            int player1_points = 0;
            int player2_points = 0;
            string turn = player1;
            int check;
            int sum_points = 0;
            int pairs = (game_bored.GetLength(0) * game_bored.GetLength(1)) / 2;
            while (sum_points != pairs)
            {
                Print_Bored_Number(game_bored);
                do
                {
                    check = 0;
                    Console.WriteLine($"{turn}, choose first card row: ");
                    FirstCardRow = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{turn}, choose first card column: ");
                    FirstCardColumn = int.Parse(Console.ReadLine());
                    if (0 >= FirstCardRow || FirstCardRow > game_bored.GetLength(0) || 0 >= FirstCardColumn || FirstCardColumn > game_bored.GetLength(1))
                    {
                        Console.WriteLine("\nThere is no card such this");
                        check += 1;
                    }
                    else if (game_bored[FirstCardRow - 1, FirstCardColumn - 1] == 0)
                    {
                        Console.WriteLine("\nThis card has been found plese choose other");
                        check += 1;
                    }

                }
                while (check>0);
                Print_Bored_medium_Number(game_bored, FirstCardRow - 1, FirstCardColumn - 1);

                do
                {
                    check = 0;
                    Console.WriteLine($"{turn}, choose second card row: ");
                    SecondCardRow = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{turn}, choose second card column: ");
                    SecondCardColumn = int.Parse(Console.ReadLine());
                    if (0 >= SecondCardColumn || SecondCardColumn > game_bored.GetLength(1) || 0 >= SecondCardRow || SecondCardRow > game_bored.GetLength(1))
                    {
                        Console.WriteLine("\nThere is no card such this\n");
                        check += 1;
                    }
                    else if (game_bored[SecondCardRow - 1, SecondCardColumn - 1] == 0)
                    {
                        Console.WriteLine("\nThis card has been found plese choose other\n");
                        check += 1;
                    }
                    else if (SecondCardRow == FirstCardRow && SecondCardColumn == FirstCardColumn)
                    {
                        Console.WriteLine("\nyou cant choose the same card!!\n");
                        check += 1;
                    }
                }
                while (check<0);
                Print_Bored_Last_Number(game_bored, FirstCardRow - 1, FirstCardColumn - 1, SecondCardRow - 1, SecondCardColumn - 1);
                int card1 = game_bored[FirstCardRow - 1, FirstCardColumn - 1];
                Console.WriteLine($"\ncard1: {card1}");
                int card2 = game_bored[SecondCardRow - 1, SecondCardColumn - 1];
                Console.WriteLine($"card2: {card2}");
                if (card1 == card2)
                {
                    game_bored[FirstCardRow - 1, FirstCardColumn - 1] = 0;
                    game_bored[SecondCardRow - 1, SecondCardColumn - 1] = 0;
                    Console.WriteLine("\nCongrats you found the missing pair\nand you get a point\n");
                    if (turn == player1)
                    {
                        player1_points++;
                    }
                    else
                    {
                        player2_points++;
                    }
                    sum_points++;
                    Console.WriteLine($"The result of the game this far:\n{player1} : {player1_points}\n{player2} : {player2_points}\n");
                    continue;
                }
                else
                {
                    Console.WriteLine("\nSorry you were wrong try again next time\n");
                }

                if (turn == player1)
                {
                    turn = player2;
                }
                else
                {
                    turn = player1;
                }
                Console.WriteLine($"The result of the game this far:\n{player1} : {player1_points}\n{player2} : {player2_points}");
                continue;
            }
            Console.WriteLine($"The result of the game is:\n{player1} : {player1_points}\n{player2} : {player2_points}");
        }//משחק מספרים שחקן מול שחקן
        public static void Game_P1_VS_P2_Chars(char[,] game_bored, string player1, string player2)
        {
            int FirstCardRow, FirstCardColumn, SecondCardRow, SecondCardColumn;
            int player1_points = 0;
            int player2_points = 0;
            string turn = player1;
            int sum_points = 0;
            int check;
            int pairs = (game_bored.GetLength(0) * game_bored.GetLength(1)) / 2;
            while (sum_points != pairs)
            {
                Print_Bored_Char(game_bored);
                do
                {
                    check = 0;
                    Console.WriteLine("choose first card row: ");
                    FirstCardRow = int.Parse(Console.ReadLine());
                    Console.WriteLine("choose first card column: ");
                    FirstCardColumn = int.Parse(Console.ReadLine());
                    if (0 >= FirstCardRow || FirstCardRow > game_bored.GetLength(0) || 0 >= FirstCardColumn || FirstCardColumn > game_bored.GetLength(1))
                    {
                        Console.WriteLine("\nThere is no card such this");
                        check += 1;
                    }
                    else if (game_bored[FirstCardRow - 1, FirstCardColumn - 1] == (char)48)
                    {
                        Console.WriteLine("\nThis card has been found plese choose other");
                        check += 1;
                    }
                }
                while (check > 0);
                Print_Bored_medium_Char(game_bored, FirstCardRow - 1, FirstCardColumn - 1);

                do
                {
                    check = 0;
                    Console.WriteLine("choose second card row: ");
                    SecondCardRow = int.Parse(Console.ReadLine());
                    Console.WriteLine("choose second card column: ");
                    SecondCardColumn = int.Parse(Console.ReadLine());
                    if (0 >= SecondCardColumn || SecondCardColumn > game_bored.GetLength(1) || 0 >= SecondCardRow || SecondCardRow > game_bored.GetLength(1))
                    {
                        Console.WriteLine("\nThere is no card such this\n");
                        check += 1;
                    }
                    else if (game_bored[SecondCardRow - 1, SecondCardColumn - 1] == (char)48)
                    {
                        Console.WriteLine("\nThis card has been found plese choose other\n");
                        check += 1;
                    }
                    else if (SecondCardRow == FirstCardRow && SecondCardColumn == FirstCardColumn)
                    {
                        Console.WriteLine("\nyou cant choose the same card!!\n");
                        check += 1;
                    }

                }
                while (check > 0);
                Print_Bored_Last_Char(game_bored, FirstCardRow - 1, FirstCardColumn - 1, SecondCardRow - 1, SecondCardColumn - 1);
                int card1 = game_bored[FirstCardRow - 1, FirstCardColumn - 1];
                Console.WriteLine($"\ncard1: {card1}");
                int card2 = game_bored[SecondCardRow - 1, SecondCardColumn - 1];
                Console.WriteLine($"card2: {card2}");
                if (card1 == card2)
                {
                    game_bored[FirstCardRow - 1, FirstCardColumn - 1] = (char) 48;
                    game_bored[SecondCardRow - 1, SecondCardColumn - 1] = (char)48;
                    Console.WriteLine("\nCongrats you found the missing pair\nand you get a point\n");
                    if (turn == player1)
                    {
                        player1_points++;
                    }
                    else
                    {
                        player2_points++;
                    }
                    sum_points++;
                    Console.WriteLine($"The result of the game this far:\n{player1} : {player1_points}\n{player2} : {player2_points}\n");
                    continue;
                }
                else
                {
                    Console.WriteLine("\nSorry you were wrong try again next time\n");
                }

                if (turn == player1)
                {
                    turn = player2;
                }
                else
                {
                    turn = player1;
                }
                Console.WriteLine($"The result of the game this far:\n{player1} : {player1_points}\n{player2} : {player2_points}");
                continue;
            }
            Console.WriteLine($"The result of the game is:\n{player1} : {player1_points}\n{player2} : {player2_points}");
        }//מסחק אותיות שחקן מול שחקן
        #endregion

        #region challenge! game functions with chars
        public static char[,] create_game_bored_Char()
        {
            int bored_size;
            Random rand = new Random();
            do
            {
                Console.WriteLine("Enter the size for the bored you want to play (example: Enter 4 for 4X4 and please enter equal number ): ");
                bored_size = int.Parse(Console.ReadLine());

            }
            while (bored_size < 0 && bored_size > 8 && bored_size % 1 == 0);
            Random ascii = new Random();
            char[,] m_bored = new char [bored_size, bored_size];
            int cards_amount = m_bored.GetLength(0) * m_bored.GetLength(1);
            int pair = cards_amount / 2;
            for (int i = 1; i <= pair; i++)
            {
                char letter = (char)ascii.Next(97, 122);
                int Flag = 0;
                while (Flag != 2)
                {
                    int row = rand.Next(0, m_bored.GetLength(0));
                    int column = rand.Next(0, m_bored.GetLength(1));
                    if (m_bored[row, column] == '\0')
                    {
                        m_bored[row, column] = letter;
                        Flag++;
                    }
                }

            }
            return m_bored;
        }//יצירת לוח משחק עם אותיות
        public static void Print_Bored_Char(char[,] game_bored)
        {
            for (int i = 0; i < game_bored.GetLength(0); i++)
            {
                for (int k = 0; k < game_bored.GetLength(1); k++)
                {
                    if (game_bored[i, k] == (char)48)
                    {
                        Console.Write(game_bored[i, k] + "\t");
                    }
                    else
                    {
                        Console.Write("X" + "\t");
                    }
                }
                Console.WriteLine();
            }
        }//הדפסת לוח תחילת משחק אותיות
        public static void Print_Bored_medium_Char(char[,] game_bored, int row, int column)
        {
            for (int i = 0; i < game_bored.GetLength(0); i++)
            {
                for (int k = 0; k < game_bored.GetLength(1); k++)
                {
                    if (i == row && k == column)
                    {
                        Console.Write(game_bored[row, column] + "\t");
                    }
                    else if (game_bored[i, k] == '\0')
                    {
                        Console.Write("0" + "\t");
                    }
                    else
                    {
                        Console.Write("X" + "\t");
                    }
                }
                Console.WriteLine();
            }
        }//הדפסת מהלך קלף ראשון אותיות
        public static void Print_Bored_Last_Char(char[,] game_bored, int row1, int column1, int row2, int column2)
        {
            for (int i = 0; i < game_bored.GetLength(0); i++)
            {
                for (int k = 0; k < game_bored.GetLength(1); k++)
                {
                    if (i == row1 && k == column1)
                    {
                        Console.Write(game_bored[row1, column1] + "\t");
                    }
                    else if (i == row2 && k == column2)
                    {
                        Console.Write(game_bored[row2, column2] + "\t");
                    }
                    else if (game_bored[i, k] == '\0')
                    {
                        Console.Write("0" + "\t");
                    }
                    else
                    {
                        Console.Write("X" + "\t");
                    }
                }
                Console.WriteLine();
            }
        } //הדפסת מהלך קלף ראשון אותיות
        #endregion

        #region game functions with numbers 
        public static int[,] create_game_bored_Number()
        {
            int bored_size;
            Random rand = new Random();
            do
            {
                Console.WriteLine("Enter the size for the bored you want to play (example: Enter 4 for 4X4 and please enter equal number ): ");
                bored_size = int.Parse(Console.ReadLine());

            }
            while (bored_size < 0 && bored_size > 8 && bored_size % 1 == 0);
            int[,] m_bored = new int[bored_size, bored_size];
            int cards_amount = bored_size * bored_size;
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
        }//יצירת לוח משחק עם מספרים
        public static void Print_Bored_Number(int[,] game_bored)
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
                        Console.Write("X" + "\t");
                    }
                }
                Console.WriteLine();
            }
        }//הדפסת לוח תחילת משחק מספרים
        public static void Print_Bored_medium_Number(int[,] game_bored, int row, int column)
        {
            for (int i = 0; i < game_bored.GetLength(0); i++)
            {
                for (int k = 0; k < game_bored.GetLength(1); k++)
                {

                    if (i == row && k == column)
                    {
                        Console.Write(game_bored[row, column] + "\t");
                    }
                    else if (game_bored[i, k] == 0)
                    {
                        Console.Write(game_bored[i, k] + "\t");
                    }
                    else
                    {
                        Console.Write("X" + "\t");
                    }
                }
                Console.WriteLine();
            }
        }// הדפסת מהלך קלף ראשון מספרים
        public static void Print_Bored_Last_Number(int[,] game_bored, int row1, int column1, int row2, int column2)
        {
            for (int i = 0; i < game_bored.GetLength(0); i++)
            {
                for (int k = 0; k < game_bored.GetLength(1); k++)
                {
                    if (i == row1 && k == column1)
                    {
                        Console.Write(game_bored[row1, column1] + "\t");
                    }
                    else if (i == row2 && k == column2)
                    {
                        Console.Write(game_bored[row2, column2] + "\t");
                    }
                    else if (game_bored[i, k] == '\0')
                    {
                        Console.Write("0" + "\t");
                    }
                    else
                    {
                        Console.Write("X" + "\t");
                    }

                }
                    Console.WriteLine();
            }
        }//הדפסת מהלך קלף שני מספרים

        #endregion


            }
        }
