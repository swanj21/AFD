using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Factories;
using System.ComponentModel;

namespace Engine.ViewModels
{
    /* This is used to manage the session as the player is 
       playing the game. 
    */
    public class GameSession : BasePropertyChangedClass
    {
        private Location curLoc;
        public Player curPlayer { get; set; }
        public Location curLocation
        {
            get { return curLoc; }
            set
            {
                curLoc = value;
                OnPropertyChanged(nameof(curLocation));
                OnPropertyChanged(nameof(HasLocationToNorth));
                OnPropertyChanged(nameof(HasLocationToWest));
                OnPropertyChanged(nameof(HasLocationToEast));
                OnPropertyChanged(nameof(HasLocationToSouth));

                GivePlayerQuestsAtLocation();
            }
        }

        public World curWorld { get; set; }

        public GameSession()
        {
            curPlayer = new Player{
                PlayerName ="Jerry", Gold=100500, CharacterClass="Hunter",
                HitPoints =10, ExperiencePoints=0, Level=1
            };

            curWorld = WorldFactory.CreateWorld();

            curLocation = curWorld.LocationAt(0, -1);
        }

        public bool HasLocationToNorth
        {
            get
            {
                return curWorld.LocationAt(curLocation.XCoordinate, curLocation.YCoordinate + 1) != null;
            }
        }

        public bool HasLocationToWest
        {
            get
            {
                return curWorld.LocationAt(curLocation.XCoordinate - 1, curLocation.YCoordinate) != null;
            }
        }

        public bool HasLocationToEast
        {
            get
            {
                return curWorld.LocationAt(curLocation.XCoordinate + 1, curLocation.YCoordinate) != null;
            }
        }

        public bool HasLocationToSouth
        {
            get
            {
                return curWorld.LocationAt(curLocation.XCoordinate, curLocation.YCoordinate - 1) != null;
            }
        }

        public void MoveNorth()
        {
            if (HasLocationToNorth)
                curLocation = curWorld.LocationAt(curLocation.XCoordinate, curLocation.YCoordinate + 1);
        }
        public void MoveWest()
        {
            if (HasLocationToWest)
                curLocation = curWorld.LocationAt(curLocation.XCoordinate - 1, curLocation.YCoordinate);
        }
        public void MoveEast()
        {
            if (HasLocationToEast)
                curLocation = curWorld.LocationAt(curLocation.XCoordinate + 1, curLocation.YCoordinate);
        }
        public void MoveSouth()
        {
            if (HasLocationToSouth)
                curLocation = curWorld.LocationAt(curLocation.XCoordinate, curLocation.YCoordinate - 1);
        }

        private void GivePlayerQuestsAtLocation()
        {
            foreach(Quest quest in curLoc.QuestsAvailable)
            {
                if (!curPlayer.Quests.Any(q => q.playerQuest.ID == quest.ID))
                    curPlayer.Quests.Add(new QuestStatus(quest));
            }
        }
    }
}
