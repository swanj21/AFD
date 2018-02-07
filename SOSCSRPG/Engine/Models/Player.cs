using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    // INotifyPropertyChanged: View needs to listen to any changes to this class' properties
    public class Player : INotifyPropertyChanged
    {
        private string playerName;
        private string characterClass;
        private int hitPoints;
        private int experiencePoints;
        private int level;
        private int gold;

        public string PlayerName
        {
            get { return playerName; }
            set
            {
                playerName = value;
                OnPropertyChanged("PlayerName");
            }
        }

        public string CharacterClass
        {
            get { return characterClass; }
            set
            {
                characterClass = value;
                OnPropertyChanged("CharacterClass");
            }
        }

        public int HitPoints
        {
            get { return hitPoints; }
            set
            {
                hitPoints = value;
                OnPropertyChanged("HitPoints");
            }
        }

        public int ExperiencePoints
        {
            get { return experiencePoints; }
            set
            {
                experiencePoints = value;
                OnPropertyChanged("ExperiencePoints");
            }
        }

        public int Level
        {
            get { return level; }
            set
            {
                level = value;
                OnPropertyChanged("Level");
            }
        }

        public int Gold
        {
            get { return gold; }
            set
            {
                gold = value;
                OnPropertyChanged("Gold");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        { // ? means that if anyone is listening, do the Invoke.
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
