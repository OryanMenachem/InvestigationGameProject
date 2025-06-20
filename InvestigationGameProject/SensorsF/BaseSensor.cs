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

        public virtual void Activate(BaseAgent agent)
        {
            ConsoleDesign.CyanColor($"{SensorType} action...\n");

            new AgentSensorInterface().Interaction(SensorType, agent);
        }


    }
}
