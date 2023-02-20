using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamesDll;
using GamesContext;
using System.Configuration;

namespace Gamess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (GamesContextClass gc = new GamesContextClass(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString))
            {
                Games game1 = new Games();
                Games game2 = new Games();
                game1.Name = "Doom";
                game1.Creator = "3D";
                game1.Genre = "strategy";
                game1.Date = DateTime.Now;

                game2.Name = "Heroes of Might and Magic";
                game2.Creator = "3DO";
                game2.Genre = "strategy";
                game2.Date = DateTime.Now;

                gc.gamesSet.Add(game1);
                gc.gamesSet.Add(game2);
                gc.SaveChanges();
            }
        }
    }
}
