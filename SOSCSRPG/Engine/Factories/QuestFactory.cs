using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    internal static class QuestFactory
    {
        private static readonly List<Quest> quests = new List<Quest>();

        static QuestFactory()
        {
            // Clear the herb garden 
            // NEEDS: 5 Snake fangs 
            // REWARD: 1 Rusty sword
            quests.Add(new Quest(1, "Clear the herb garden",
                "Remove the snakes in the Herbalist's garden",
                new List<ItemQuantity> { new ItemQuantity(9001, 5) }, 
                25, 10, 
                new List<ItemQuantity> { new ItemQuantity(1002, 1) }));
        }

        internal static Quest GetQuestByID(int id)
        {
            return quests.FirstOrDefault(quest => quest.ID == id);
        }
    }
}
