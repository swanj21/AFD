using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.ViewModels
{
    /* This is used to manage the session as the player is 
       playing the game. 
    */
    public class GameSession
    {
        public Player curPlayer { get; set; }

        public GameSession()
        {
            curPlayer = new Player();

            curPlayer.PlayerName = "Jerry";
            curPlayer.Gold = 100500;
            curPlayer.CharacterClass = "Hunter";
            curPlayer.HitPoints = 10;
            curPlayer.ExperiencePoints = 0;
            curPlayer.Level = 1;
        }
    }
}
