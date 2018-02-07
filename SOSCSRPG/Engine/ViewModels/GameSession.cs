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

            curPlayer.playerName = "Jerry";
            curPlayer.gold = 100500;
            curPlayer.charClass = "Hunter";
            curPlayer.hitPoints = 10;
            curPlayer.expPoints = 0;
            curPlayer.level = 1;
        }
    }
}
