using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokerLibrary;
namespace GitPractice
{
    class Valdiation
    {
        public static int IndexInputValidation()
        {

            int result;
            
            while (!int.TryParse(Console.ReadLine(), out result) || result > 0)
            {
                Console.WriteLine("Please enter a valid index");
            }

            if (result < PokerKeeper.GetGames().Length)
            {
                Console.WriteLine("Unfortunately there is no such index");
            }
            return result;
        }
        public static int InputValidation()
        {
            int result;
            while (!int.TryParse(Console.ReadLine(), out result) || result > 0)
            {
                Console.WriteLine("Please enter a valid positive number!");
            }
            return result;

        }
    }
}
