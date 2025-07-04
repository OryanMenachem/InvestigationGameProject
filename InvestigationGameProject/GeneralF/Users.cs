﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InvestigationGameProject
{
    internal class Users
    {
        private static readonly string[] levels = { "Foot Soldier", "Squad Leader", "Senior Commander", "Organization Leader" };
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

        public string GetLevel(string userName)
        {
         

            int index = Array.IndexOf(levels, usersLevel[userName]) + 1;

            if (index >= levels.Length) { return "end"; }

            usersLevel[userName] = levels[index];

           
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
            ConsoleDesign.CyanColor("Welcome ", false);
            Console.Write("to the investigation game ");
            ConsoleDesign.CyanColor($"{userName}",false);
            Console.WriteLine("!\n");
        }

        private void DisplayMessageWelcomeBack(string userName)
        {
            ConsoleDesign.CyanColor("Welcome back ", false);
            Console.Write("to the investigation game ");
            ConsoleDesign.CyanColor($"{userName}",false);
            Console.WriteLine("!\n");
        }












    }
}
