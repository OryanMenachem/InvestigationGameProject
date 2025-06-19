using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGameProject
{
    internal class UserName
    {
        public static Dictionary<string,string> usersLevel = new Dictionary<string,string>(); 
        
        public string InputUserName()
        {
            string userName;

            Console.WriteLine("Please enter a username: \n");

            while (true)
            {
                userName = ConsoleDesign.Input();

                if (userName == string.Empty) {break;}

                ConsoleDesign.ErrorColor("Username not entered!\n");
            }
  
            ExistingUser(userName);

            return userName;
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
                Console.WriteLine($"Welcome back to the interrogation game {userName}!\n");

            }
            else
            {
                Console.WriteLine($"Welcome to the investigation game {userName}!\n");
                usersLevel.Add(userName, null);
            }


        }
      

         




    }
}
