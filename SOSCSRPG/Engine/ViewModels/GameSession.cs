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
    public class GameSession : INotifyPropertyChanged
    {
        private Location curLoc;

        public Player curPlayer { get; set; }
        public Location curLocation
        {
            get { return curLoc; }
            set
            {
                curLoc = value;
                OnPropertyChanged("curLocation");
                OnPropertyChanged("HasLocationToNorth");
                OnPropertyChanged("HasLocationToWest");
                OnPropertyChanged("HasLocationToEast");
                OnPropertyChanged("HasLocationToSouth");
            }
        }
        public World curWorld { get; set; }

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

        public void MoveNorth()
        {
            curLocation = curWorld.LocationAt(curLocation.XCoordinate, curLocation.YCoordinate + 1);
        }
        public void MoveWest()
        {
            curLocation = curWorld.LocationAt(curLocation.XCoordinate - 1, curLocation.YCoordinate);
        }
        public void MoveEast()
        {
            curLocation = curWorld.LocationAt(curLocation.XCoordinate + 1, curLocation.YCoordinate);
        }
        public void MoveSouth()
        {
            curLocation = curWorld.LocationAt(curLocation.XCoordinate, curLocation.YCoordinate - 1);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        { // ? means that if anyone is listening, do the Invoke.
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
