using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerLibrary
{
    public class PokerKeeper
    {
        private static List<Poker> _pokergames = new List<Poker>();

        public static void Add(Poker game)
        {
            _pokergames.Add(game);
        }

        public static Poker[] GetGames()
        {
            return _pokergames.ToArray();
        }


    }

    public class Poker
    {
        public Poker(string discipline, int numberOfCards, int numberOfPlayers, string type)
        {
            this.Discipline = discipline;
            this.NumberOfCards = numberOfCards;
            this.NumberOfPlayers = numberOfPlayers;
            this.Type = type;
        }

        public string Discipline { get; set; }
        public int NumberOfCards { get; set; }
        public int NumberOfPlayers { get; set; }
        public string Type { get; set; }


        public override string ToString()
        {
            return $"Discipline: {this.Discipline} \n Number of Cards: {this.NumberOfCards} \n Number of Players: {this.NumberOfPlayers} \n Game Type: {this.Type}";
        }

    }
}
