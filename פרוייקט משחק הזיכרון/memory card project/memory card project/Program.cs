using System;

namespace memory_card_project
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();

        }
        #region Main Menus for the Games

        public static void menu()
        {
            Console.WriteLine("\nWellcome to our memory card game\nprees 1 of the options:\n1.with Numbers\n2.with Chars\n3.Exit");
            int choise = int.Parse(Console.ReadLine());
            if (choise == 1)
            {
                GamesNumber();
            }
            else if (choise == 2)
            {
                Games_Chars();
            }
            else if (choise == 3)
            {
                Console.WriteLine("\nbye bye");
                return;
            }
            else
            {
                Console.WriteLine("Enter one of the folowing numbers only!\n");
            }
            menu();
        }// אפשרויות ראשונות להתחלת משחק
        public static void GamesNumber()
        {
            Console.WriteLine("prees 1 of the options:\n1.player 1 VS player 2\n2.player VS PC\n3.Main menu");
            int g_choise = int.Parse(Console.ReadLine());
            if (g_choise == 1 || g_choise == 2)
            {
                Game_Numbers(create_game_bored_Number(), g_choise);
            }
            else if (g_choise == 3)
            {
                return;
            }
            else
            {
                Console.WriteLine("please enter 1 or 2!\n");
                GamesNumber();
            }
        }//התחלת משחק מספרים בחירה בין מחשב מול שחקן לשחקן על שחקן
        public static void Games_Chars()
        {
            Console.WriteLine("prees 1 of the options:\n1.player 1 VS player 2\n2.player VS PC\n\n3.Main menu");
            int g_choise = int.Parse(Console.ReadLine());
            if (g_choise == 1 || g_choise == 2)
            {
                Game_Chars(create_game_bored_Char(), g_choise);
            }
            else if (g_choise == 3)
            {
                return;
            }
            else
            {
                Console.WriteLine("please enter 1 or 2!\n");
                Games_Chars();
            }
        }// התחלת משחק אותיות בחירה בין מחשב מול שחקן לשחקן על שחקן
        #endregion

        #region Game options
        public static void Game_Numbers(int[,] game_bored, int choise)
        {
            int FirstCardRow, FirstCardColumn, SecondCardRow, SecondCardColumn;
            int check;
            int sum_points = 0;
            string player_1 = "p1", player_2 = "p2";
            string turn;
            int player1_points = 0;
            int player2_points = 0;
            int pairs = (game_bored.GetLength(0) * game_bored.GetLength(1)) / 2;
            if (choise == 1)
            {
                Console.WriteLine("Enter player 1 name:");
                player_1 = Console.ReadLine();
                Console.WriteLine("Enter player 2 name:");
                player_2 = Console.ReadLine();
                turn = player_1;
            }
            else
            {
                Console.WriteLine("Enter your name: ");
                turn = Console.ReadLine();
            }
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
                while (check > 0);
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
                while (check < 0);
                Print_Bored_Last_Number(game_bored, FirstCardRow - 1, FirstCardColumn - 1, SecondCardRow - 1, SecondCardColumn - 1);
                int card1 = game_bored[FirstCardRow - 1, FirstCardColumn - 1];
                Console.WriteLine($"\ncard1: {card1}");
                int card2 = game_bored[SecondCardRow - 1, SecondCardColumn - 1];
                Console.WriteLine($"card2: {card2}");
                if (card1 == card2)
                {
                    game_bored[FirstCardRow - 1, FirstCardColumn - 1] = 0;
                    game_bored[SecondCardRow - 1, SecondCardColumn - 1] = 0;
                    Console.WriteLine("\nCongrats you found the missing pair and you get a point\n");
                    if (choise == 1)
                    {
                        if (turn == player_1)
                        {
                            player1_points++;
                        }
                        else if (turn == player_2)
                        {
                            player2_points++;
                        }
                        sum_points++;
                        Console.WriteLine($"The result of the game this far:\n{player_1} : {player1_points}\n{player_2} : {player2_points}\n");
                    }
                    else
                    {
                        Console.WriteLine($"your points : {sum_points}");
                    sum_points++;
                    }
                    continue;
                }
                else
                {
                    Console.WriteLine("\nSorry you were wrong try again next time\n");
                    if (choise == 1)
                    {
                        if (turn == player_1)
                        {
                            turn = player_2;
                        }
                        else
                        {
                            turn = player_1;
                        }
                        Console.WriteLine($"The result of the game this far:\n{player_1} : {player1_points}\n{player_2} : {player2_points}");
                    }
                }

                continue;
            }
            if (choise == 1)
            {
                Console.WriteLine($"The result of the game is:\n{player_1} : {player1_points}\n{player_2} : {player2_points}");
            }
            else
            {
                Console.WriteLine("congratulation, you finish the game");
            }
        }///משחק על פי מספרים
        public static void Game_Chars(char[,] game_bored, int choise)
        {

            int FirstCardRow, FirstCardColumn, SecondCardRow, SecondCardColumn;
            int check;
            int sum_points = 0;
            string player_1 = "p1", player_2 = "p2";
            string turn;
            int player1_points = 0;
            int player2_points = 0;
            int pairs = (game_bored.GetLength(0) * game_bored.GetLength(1)) / 2;
            if (choise == 1)
            {
                Console.WriteLine("Enter player 1 name:");
                player_1 = Console.ReadLine();
                Console.WriteLine("Enter player 2 name:");
                player_2 = Console.ReadLine();
                turn = player_1;
            }
            else
            {
                Console.WriteLine("Enter your name: ");
                turn = Console.ReadLine();
            }
            while (sum_points != pairs)
            {
                Print_Bored_Char(game_bored);
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
                while (check > 0);
                Print_Bored_medium_Char(game_bored, FirstCardRow - 1, FirstCardColumn - 1);
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
                while (check < 0);
                Print_Bored_Last_Char(game_bored, FirstCardRow - 1, FirstCardColumn - 1, SecondCardRow - 1, SecondCardColumn - 1);
                char card1 = game_bored[FirstCardRow - 1, FirstCardColumn - 1];
                Console.WriteLine($"\ncard1: {card1}");
                char card2 = game_bored[SecondCardRow - 1, SecondCardColumn - 1];
                Console.WriteLine($"card2: {card2}");
                if (card1 == card2)
                {
                    game_bored[FirstCardRow - 1, FirstCardColumn - 1] = (char)48;
                    game_bored[SecondCardRow - 1, SecondCardColumn - 1] = (char)48;
                    Console.WriteLine("\nCongrats you found the missing pair and you get a point\n");
                    if (choise == 1)
                    {
                        if (turn == player_1)
                        {
                            player1_points++;
                        }
                        else if (turn == player_2)
                        {
                            player2_points++;
                        }
                    sum_points++;
                        Console.WriteLine($"The result of the game this far:\n{player_1} : {player1_points}\n{player_2} : {player2_points}\n");
                    }
                    else
                    {
                        sum_points++;
                        Console.WriteLine($"your points : {sum_points}");
                    }
                    continue;
                }
                else
                {
                    Console.WriteLine("\nSorry you were wrong try again next time\n");
                    if (choise == 1)
                    {
                        if (turn == player_1)
                        {
                            turn = player_2;
                        }
                        else
                        {
                            turn = player_1;
                        }
                        Console.WriteLine($"The result of the game this far:\n{player_1} : {player1_points}\n{player_2} : {player2_points}");
                    }
                }
                continue;
            }
            if (choise == 1)
            {
                Console.WriteLine($"The result of the game is:\n{player_1} : {player1_points}\n{player_2} : {player2_points}");
            }
            else
            {
                Console.WriteLine("congratulation, you finish the game");
            }
        }//משחק על פי אותיות
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
            char[,] m_bored = new char[bored_size, bored_size];
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

