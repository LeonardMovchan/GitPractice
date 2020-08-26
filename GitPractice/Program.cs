using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using PokerLibrary;
namespace GitPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("I want to remove it");
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
                            Console.Write("Please enter the name of the discipline: ");
                            string name = Console.ReadLine();

                            Console.Write("Please enter the number of cards in  the game: ");

                            int cards = Valdiation.InputValidation();


                            Console.Write("Please enter the number of players in  the game: ");
                            int players = Valdiation.InputValidation();

                            Console.Write("Please enter the type of the game: ");
                            string type = Console.ReadLine();

                            Poker game = new Poker(discipline: name, numberOfCards: cards, numberOfPlayers: players, type: type);

                            PokerKeeper.Add(game);
                        }
                        break;
                    case Menu.CheckGames:
                        {
                            Console.Clear();
                            foreach (var games in PokerKeeper.GetGames())
                            {
                                Console.WriteLine($"=============\n {games}");
                            }


                            Console.ReadLine();
                        }
                        break;
                    case Menu.RemoveGames:
                        {
                            Console.Write("Please enter the index of the game you would like to remove: ");
                            int index = int.Parse(Console.ReadLine());

                            PokerKeeper.RemoveAt(index);

                            Console.WriteLine($"The game on index {index} was removed from the list");




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
