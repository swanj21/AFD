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
    class GameSession
    {
        Player curPlayer { get; set; }

        public GameSession()
        {
            curPlayer = new Player();

            curPlayer.playerName = "Jerry";
            curPlayer.gold = 100500;
        }
    }
}
