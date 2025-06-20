using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvestigationGameProject.GameF;

namespace InvestigationGameProject.AgentsF
{
    internal class GetAgent
    {
        public BaseAgent GetAgentByLevel(string level)
        {
            switch (level)
            {
                case "foot soldier":
                    return new FootSoldier();

                case "squad leader":
                    return new FootSoldier();

                case "senior commander":
                    return new FootSoldier();

                case "organization leader":
                    return new FootSoldier();

                default:
                    ConsoleDesign.ErrorColor("Level does not exist!\n");
                    break;
            }

            return null;

        }



    }
}
