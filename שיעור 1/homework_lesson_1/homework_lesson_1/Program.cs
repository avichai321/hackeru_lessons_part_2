using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = -1;
            while (true)
            { 
                int last_choise1 = int.Parse(Console.ReadLine());
                {
                    switch (last_choise1)
                    {
                        case -1:

                            switch (choice)
                            {
                                case -1:
                                    Console.WriteLine("the lamp was broken");
                                    break;
                                default:
                                    Console.WriteLine("the lamp is broken now");
                                    choice = -1;
                                    break;

                            }
                            break;
                           
                        case 0:

                            switch (choice)
                            {
                                case -1:
                                Console.WriteLine("there is no options, the lamp was broken");
                                    break;
                                default:
                                    Console.WriteLine("lamp status : off");
                                    choice = 0;
                                    break;
                                   

                            }
                            break;

                        case 1:
                            switch (choice)
                            {
                                case -1:
                                    Console.WriteLine("we cannot turn on the lamp was broken");
                                    break;
                                default:
                                    Console.WriteLine("lamp status : on");
                                    choice = 1;
                                    break;


                            }
                            break;
                        
                        case 10:
                            break;

                        default:
                            switch (choice)
                            {
                                case -1:
                                    Console.WriteLine("the lamp is now reparing");
                                    choice = last_choise1;
                                    break;
                                default:
                                    Console.WriteLine("there is no need the is working propertly");
                                    choice = last_choise1;
                                    break;


                            }
                            break;
                                
                    }
                }
                if (last_choise1 == 10)
                    {
                    break;
                }
                    }
   

                }
            }
        }
    }

