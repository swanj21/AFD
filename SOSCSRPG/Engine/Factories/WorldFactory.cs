using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    // WorldFactory is by default an internal class
    internal static class WorldFactory
    {
        internal static World CreateWorld()
        {
            World world = new World();
            world.AddLocation(-2, -1, "Farmer's Field",
                "There are rows of corn growing here, with giant rats hiding between them.",
                "/Engine;component/Images/Locations/FarmFields.png");
            world.AddLocation(-1, -1, "Farmer's House",
                "This is the house of your neighbor, Farmer Ted.",
                "/Engine;component/Images/Locations/Farmhouse.png");
            world.AddLocation(0, -1, "Home", 
                "This is your home.", 
                "/Engine;component/Images/Locations/Home.png");
            world.AddLocation(-1, 0, "Trading Shop",
                "The shop of Susan, the trader.",
                "/Engine;component/Images/Locations/Trader.png");
            world.AddLocation(0, 0, "Town Square",
                "There is a fountain here.",
                "/Engine;component/Images/Locations/TownSquare.png");
            world.AddLocation(1, 0, "Town Gate",
                "There is a gate here, protecting the town from giant spiders.",
                "/Engine;component/Images/Locations/TownGate.png");
            world.AddLocation(2, 0, "Spider Forest",
                "The trees in this forest are covered with spider webs.",
                "/Engine;component/Images/Locations/SpiderForest.png");
            world.AddLocation(0, 1, "Herbalist's hut",
                "You see a small hut, with plants drying from the roof.",
                "/Engine;component/Images/Locations/HerbalistsHut.png");
            world.AddLocation(0, 2, "Herbalist's garden",
                "There are many plants here, with snakes hiding(not very well) behind them.",
                "/Engine;component/Images/Locations/HerbalistsGarden.png");

            world.LocationAt(0, 1).QuestsAvailable.Add(QuestFactory.GetQuestByID(1));

            return world;
        }
    }
}
