using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    class Program
    {
        public static List<Player> Players;
        public static List<GameScore> GameScores;
        static void Main(string[] args)
        {
            //DateTime t = DateTime.Parse("30/01/2017 16:42");

            SeedPlayers();
            SeedScores();
           // // Query 1
           //Player found =  Players.FirstOrDefault(p => p.GamerTag == "Watcha");

           // if (found != null)
           //     Console.WriteLine(found.ToString());
           // else Console.WriteLine("Player not found");

           // // Query 2 Find First score by Watcha
           // GameScore Scorefound = GameScores
           //                         .FirstOrDefault(p => p.GamerTag == "Watcha"
           //                         );
           // if (Scorefound != null)
           //     Console.WriteLine(Scorefound.ToString());
           // else Console.WriteLine("No Score found");

            // Query 3 return all the scores for a named game
            string Name = "World of Goo";
            var scores = GameScores.Where(g => g.GameName == Name);
            foreach (var item in scores)
            {
                Console.WriteLine(item.ToString());
            }

            // Query 4 produce a score board for a game
            var scoreBoard = GameScores.Where(g => g.GameName == Name)
                            .OrderByDescending(g => g.Score)
                            .Take(2);

            Console.WriteLine("ScoreBoard for {0}", Name);
            foreach (var item in scoreBoard)
            {
                Console.WriteLine(item.ToString());
            }

            // Query 5 Select the Top XP player 
            var topPlayer = Players
                            .OrderByDescending(g => g.XP)
                            .Take(1);
            foreach (var item in topPlayer)
                Console.WriteLine(item.ToString());
            // Alternative way to get top player
            Player AlternateTop = Players
                    .OrderByDescending(t => t.XP)
                    .FirstOrDefault();

            if(AlternateTop != null)
                Console.WriteLine(AlternateTop.ToString());

            Console.ReadKey();
        }

        public static void SeedPlayers()
        {
            Players = new List<Player>()
            {
                new Player { FirstName="Billy", SecondName = "Bragg", GamerTag="Watcha", PlayerId =1, XP =200 },
                new Player { FirstName="Martha", SecondName = "Abraham", GamerTag="Muffin", PlayerId =2, XP =500 },
                new Player { FirstName="Fred", SecondName = "Flinstones", GamerTag="YabaYaba", PlayerId =3, XP =300 }

            };
        }

        public static void SeedScores()
        {
            GameScores = new List<GameScore>()
            {
                new GameScore { GamerTag="Watcha", GameName="World of Goo", Score=200, scoredAt = DateTime.Parse("25/10/2016 16:42")  },
                new GameScore { GamerTag="Watcha", GameName="World of Goo", Score=1500, scoredAt = DateTime.Parse("29/10/2016 01:50")  },
                new GameScore { GamerTag="Muffin", GameName="World of Goo", Score=1200, scoredAt = DateTime.Parse("13/09/2016 12:45")  },
                new GameScore { GamerTag="Watcha", GameName="Witcher", Score=500, scoredAt = DateTime.Parse("09/09/2016 21:30")  },
            };

        }

    }
}
