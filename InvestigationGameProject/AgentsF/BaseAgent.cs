using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGameProject.AgentsF
{
    internal class BaseAgent
    {
        public static readonly string[] Sensortypes = {"Audio Sensor",
                                                "Thermal Sensor",
                                                "pulse sensor",
                                                "Motion Sensor", 
                                                "Magnetic Sensor",
                                                "Signal Sensor", 
                                                "Light Sensor"}; 
        public virtual string AgentName { get; set; }
        public virtual string AgentRank {  get; set; }

        public virtual List<string> SensitiveToSensors { get; set; }

        public virtual List<string> AttachedSensors { get; set; }

        //int Count { get; set; }

        //public virtual void CounterStrike() { }

        public int AgentIsSensitive(string sensor)
        {
            int index = -1;

            for (int i = 0; i < SensitiveToSensors.Count; i++)
            {
                if (SensitiveToSensors[i] == sensor && AttachedSensors[i] == null)
                { index = i; }
            }

            return index;



        }

    }
}
