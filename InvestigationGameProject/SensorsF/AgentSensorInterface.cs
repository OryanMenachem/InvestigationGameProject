using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvestigationGameProject.AgentsF;

namespace InvestigationGameProject.SensorsF
{
    internal class AgentSensorInterface
    {

        public bool Interaction(string sensorType, BaseAgent agent, int severalTurns)
        {
            int index = agent.AgentIsSensitive(sensorType);

            if (index == -1) { return false; }

            agent.AttachedSensors[index] = sensorType;

            agent.CounterStrike(severalTurns);

            return agent.SensorsWereExposed();

        }



    }
}
