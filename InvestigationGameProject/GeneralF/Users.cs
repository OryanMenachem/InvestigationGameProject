using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InvestigationGameProject
{
    internal class Users
    {
        private static readonly string[] levels = { "foot soldier", "squad leader", "senior commander", "organization leader" };
        /// <summary>
        /// A dictionary containing the username and the last agent who revealed
        /// (to determine the stage of the game).
        /// </summary>
        public static Dictionary<string,string> usersLevel = new Dictionary<string,string>();

        /// <summary>
        /// Gets a name from the user.
        /// </summary>
        /// <returns></returns>
        public string InputUserName()
        {
            string userName;

            Console.WriteLine("Please enter a username: \n");

            while (true)
            {
                userName = ConsoleDesign.Input();

                if (userName != string.Empty) {break;}

                ConsoleDesign.ErrorColor("Username not entered!\n");
            }
  
            ExistingUser(userName);

            return userName;
        }

        public static string GetLevel(string userName)
        {
            int index = Array.IndexOf(levels, usersLevel[userName]) + 1;

            //if (index <= levels.Length) { }
            
            return levels[index];

        }

        /// <summary>
        /// If the user does not exist, adds it to the 'usersLevel' dictionary, 
        /// and prints greeting messages accordingly.
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        private void ExistingUser(string userName)
        {
            if (usersLevel.ContainsKey(userName))
            {
                DisplayMessageWelcomeBack(userName);
            }

            else
            {
                DisplayMessageWelcome(userName);

                usersLevel.Add(userName, null);
            }

        }
        private void DisplayMessageWelcome(string userName)
        {
            Console.Write("Welcome to the investigation game ");
            ConsoleDesign.CyanColor($"{userName} ",false);
            Console.WriteLine("!\n");
        }

        private void DisplayMessageWelcomeBack(string userName)
        {
            Console.Write("Welcome back to the investigation game ");
            ConsoleDesign.CyanColor($"{userName} ",false);
            Console.WriteLine("!\n");
        }












    }
}
