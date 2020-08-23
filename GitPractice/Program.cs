using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GitPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("This is A Menu");
                Console.WriteLine("1. Add new game");
                Console.WriteLine("2. Check all avaialble games ");
                Console.WriteLine("3. Remove Game by Index");
                Console.WriteLine("4. Exit >>");

                Menu comand = (Menu)int.Parse(Console.ReadLine());

                switch (comand)
                {
                    case Menu.AddNewGame:
                        {

                        }
                        break;
                    case Menu.CheckGames:
                        {

                        }
                        break;
                    case Menu.RemoveGames:
                        {

                        }
                        break;
                    case Menu.Exit:
                        {

                        }
                        break;
                    default:
                        {
                            Console.WriteLine("There is no such index");
                        }
                        break;
                }
            } while (true);
        }

        enum Menu
        {
            NoItem = 0,
            AddNewGame = 1,
            CheckGames = 2,
            RemoveGames = 3,
            Exit = 4
        }
    }
}
