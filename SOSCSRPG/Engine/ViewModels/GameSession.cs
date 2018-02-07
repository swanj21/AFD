using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Factories;

namespace Engine.ViewModels
{
    /* This is used to manage the session as the player is 
       playing the game. 
    */
    public class GameSession
    {
        public Player curPlayer { get; set; }
        public Location curLocation { get; set; }
        public World curWorld { get; set; }

        public GameSession()
        {
            curPlayer = new Player();

            curPlayer.PlayerName = "Jerry";
            curPlayer.Gold = 100500;
            curPlayer.CharacterClass = "Hunter";
            curPlayer.HitPoints = 10;
            curPlayer.ExperiencePoints = 0;
            curPlayer.Level = 1;

            WorldFactory worldFactory = new WorldFactory();

            curWorld = worldFactory.CreateWorld();

            curLocation = curWorld.LocationAt(0, -1);
        }
    }
}
