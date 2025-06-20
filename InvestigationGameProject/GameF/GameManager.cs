using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvestigationGameProject.AgentsF;
using static System.Net.Mime.MediaTypeNames;

namespace InvestigationGameProject
{
    internal class GameManager
    {
        private bool flag = false;

        private bool end = false;

        private bool success = false;

        private readonly string userName;

        private string currentLevel;

        public bool nextLevel = false;

        private BaseAgent iranianAgent;

        //private static int severalTurns = 0;
        




        public GameManager(string userName) { this.userName = userName; }

        public void Run()
        {
            currentLevel = Users.GetLevel(userName);

            InitializeIranianAgent();

            DisplayAgentDetails();

            while (!end)
            {
                DisplaySensors();

                InputSensor();

                while (!flag)
                {
                    DisplaySensors();
                    InputSensor();
                }

                Result();

                if (success) { ContinueToTheNextLevel(); }
              
                
            }
          
        }

        private void InitializeIranianAgent()
        {
            iranianAgent = new GetAgent().GetAgentByLevel(currentLevel);
        }

        private void DisplayAgentDetails() 
        {
            Console.Write("The agent to be interrogated is ");

            ConsoleDesign.CyanColor($"* {iranianAgent.AgentName} * ", false);

            Console.Write("an Iranian agent of the rank of ");

            ConsoleDesign.CyanColor($"* {iranianAgent.AgentRank} *\n");
        }
        private static void DisplaySensors()
        {

            Console.WriteLine("Please attach one of the following sensors:\n\n" +
                              "1. Audio Sensor\n" +
                              "2. Thermal Sensor\n" +
                              "3. pulse sensor\n" +
                              "4. Motion Sensor\n" +
                              "5. Magnetic Sensor\n" +
                              "6. Signal Sensor\n" +
                              "7. Light Sensor\n");


        }

        private void InputSensor()
        { 

            string sensor = ConsoleDesign.Input();

            switch (sensor)
            {
                case "Audio Sensor":
                    Console.WriteLine();
                    break;
                case "Thermal Sensor":
                    Console.WriteLine();
                    break;
                case "pulse sensor":
                    Console.WriteLine();
                    break;
                case "Motion Sensor":
                    Console.WriteLine();
                    break;
                case " Magnetic Sensor":
                    Console.WriteLine();
                    break;
                case "Signal Sensor":
                    Console.WriteLine();
                    break;
                case "Light Sensor":
                    Console.WriteLine();
                    break;
                default:
                    SensorNotExist();
                    break;

            }
        }
        

     
        private void Result() 
        {
            //success = true;
        }
        private void ContinueToTheNextLevel() 
        {
            Console.WriteLine("Would you like to continue to the next level? (yes / no)\n");

            string choice = ConsoleDesign.Input();

            while (choice != "yes" || choice != "no")
            {
                ConsoleDesign.ErrorColor("No valid selection was entered!\n");
                choice = ConsoleDesign.Input();
            }

            if (choice == "yes") { nextLevel = true; }

            end = true;

        }
        private void SensorNotExist() 
        {
            ConsoleDesign.ErrorColor("The inserted sensor does not exist!\n");
            flag = true;
        }


    }
}
          
            



        
