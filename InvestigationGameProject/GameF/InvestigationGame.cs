using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGameProject
{
    internal class InvestigationGame
    {
        private bool flag = true;

        private string userName = string.Empty;
        public void Start() 
        {
            DisplayGeneralMessageAboutGame();

            while (flag)
            {
                DisplayMenu();

                HandlingUserSelection(ConsoleDesign.Input());

            }

                
        }

        private static void DisplayGeneralMessageAboutGame() 
        {

            Console.Write("Welcome to the ");
            ConsoleDesign.CyanColor(" * INVESTIGATION GAME * ", false);
            Console.WriteLine("A game where you expose Iranian agents using sensors.\n");


        }

        private static void DisplayMenu() 
        {

            ConsoleDesign.CyanColor("Please select one of the following options:\n");

            ConsoleDesign.CyanColor("\n******* MENU **********");
            ConsoleDesign.CyanColor("\n* 1. new game.        *");
            ConsoleDesign.CyanColor("\n* 2. instructions     *");
            ConsoleDesign.CyanColor("\n* 3. exit.            *");
            ConsoleDesign.CyanColor("\n***********************");
        }

        private void HandlingUserSelection(string choice) 
        {
    

            switch (choice)
            {
                case "1":
                    StartNewGame();
                    break;
                case "2":
                    DisplayGameInstructions();
                    break;
                case "3":
                    ExitTheGame();
                    break;
                default:
                    DisplayIncorrectSelectionMessage();
                    break;

            }
        }

        private void StartNewGame() 
        {
            userName = new Users().InputUserName();

            GameManager newGame = new GameManager(userName);
            newGame.Run();


            while (newGame.nextLevel)
            {
                newGame = new GameManager(userName);
                newGame.Run();
            }
        }

        private static void DisplayGameInstructions() 
        {
            ConsoleDesign.CyanColor("Instructions:\n");
            Console.WriteLine("- You will now interrogate an Iranian agent of a random rank.\n" +
                              "- Your mission is to uncover which sensors are needed to expose him.\n" +
                              "- Note that the higher the rank of the agent, the more sensors are needed to expose him.\n");
            ConsoleDesign.CyanColor("Good luck!\n");

            Console.WriteLine("To return to the menu, press enter...\n");
            Console.ReadLine();
            Console.Clear();
        }

        private void ExitTheGame() 
        {
            Console.Clear();
            Console.WriteLine();
            ConsoleDesign.CyanColor("Good bye!");
            flag = false;
        }

        private static void DisplayIncorrectSelectionMessage()
        {
            ConsoleDesign.ErrorColor("No valid choice was made!\n");
        }






    }
}
