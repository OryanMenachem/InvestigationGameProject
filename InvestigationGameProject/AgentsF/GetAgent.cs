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
                case "Foot Soldier":
                    return new FootSoldier();

                case "Squad Leader":
                    return new SquadLeader();

                case "Senior Commander":
                    return new SeniorCommander();

                case "Organization Leader":
                    return new OrganizationLeader();

                default:
                    ConsoleDesign.ErrorColor("Level does not exist!\n");
                    break;
            }

            return null;

        }



    }
}
