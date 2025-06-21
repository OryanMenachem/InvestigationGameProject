using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvestigationGameProject.AgentsF;

namespace InvestigationGameProject.GameF
{
    internal class FootSoldier : BaseAgent
    {
        public override string AgentName { get; set; } = new IranianAgentNameGenerator().GetFullName();
        public override string AgentRank { get; set; } = "Foot Soldier";

        public override List<string> SensitiveToSensors { get; set; } = new List<string> {Sensortypes[0], Sensortypes[0] };

        public override List<string> AttachedSensors { get; set; } = new List<string> {null, null};


    }
}
