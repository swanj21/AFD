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
        private int experiencePoints;

        public string PlayerName { get; set; }
        public string CharacterClass { get; set; }
        public int HitPoints { get; set; }
        public int ExperiencePoints
        {
            get { return experiencePoints; }
            set { experiencePoints = value; }
        }
        public int Level { get; set; }
        public int Gold { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
