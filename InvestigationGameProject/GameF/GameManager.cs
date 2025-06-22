using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvestigationGameProject.AgentsF;
using InvestigationGameProject.SensorsF;
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

        private static int severalTurns = 0;





        public GameManager(string userName) { this.userName = userName; }

        public void Run()
        {
            currentLevel = new Users().GetLevel(userName);

            if (Victory(currentLevel)) { return; }

            InitializeIranianAgent();

            DisplayAgentDetails();

            while (!end)
            {
                DisplaySensors();

                InputSensor();

                while (flag)
                {
                    flag = false;

                    DisplaySensors();
                    InputSensor();
                }

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
            severalTurns += 1; 



            string sensor = ConsoleDesign.Input();

            switch (sensor)
            {
                case "Audio Sensor":
                    success = new AudioSensor().Activate(iranianAgent, severalTurns);
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
                    severalTurns -= 1;
                    SensorNotExist();
                    break;

            }
        }
        

     

        private void ContinueToTheNextLevel() 
        {
            Console.WriteLine("Would you like to continue to the next level? (yes / no)\n");

            string choice = ConsoleDesign.Input();

            while (true)
            {
                if (choice == "yes" || choice == "no") { break; }
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


        private bool Victory(string currentLevel)
        {
            if (currentLevel != "end") { return false; }

            nextLevel = false;

            Users.usersLevel[userName] = null;

            ConsoleDesign.CyanColor("Congratulations! ", false);
            Console.Write("you managed to expose ");
            ConsoleDesign.CyanColor("all the agents.\n");

            Console.WriteLine("Press Enter to continue...\n");
            ConsoleDesign.Input();

            return true;
         

        }
    }
}
          
            



        
