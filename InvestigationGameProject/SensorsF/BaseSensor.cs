using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvestigationGameProject.AgentsF;

namespace InvestigationGameProject.SensorsF
{
    internal class BaseSensor
    {

        public virtual string SensorType { get; set; }

        public virtual bool Activate(BaseAgent agent, int severalTurns)
        {
            ConsoleDesign.CyanColor($"{SensorType} action...\n");

            return new AgentSensorInterface().Interaction(SensorType, agent, severalTurns);
        }


    }
}
