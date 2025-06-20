using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGameProject.AgentsF
{
    internal class IranianAgentNameGenerator
    {

        public string GetFullName()
        {
           

            string fullName = FirstNames(new Random().Next(0, 20)) + " " +
                              LastNames(new Random().Next(0, 20));

            return fullName;


        }
        private static string FirstNames(int rand)
        {

            string[] firstName = {
                    "Mohammad", "Fatemeh", "Zahra", "Ali", "Reza",
                    "Sara", "Maryam", "Masoud", "Nima", "Omid",
                    "Arash", "Parvīz", "Farhad", "Babak", "Kaveh",
                    "Darius", "Ehsan", "Kamran", "Amin", "Hossein" };

            return firstName[rand];
        }
        private static string LastNames(int rand)
        {

            string[] lastName = {
                    "Mohammadi", "Hosseini", "Ahmadi", "Ali", "Moradi",
                    "Karimi", "Mousavi", "Jafari", "Rahimi", "Ebrahimi",
                    "Abbasi", "Gholami", "Ghasemi", "Ghorbani", "Akbari",
                    "Sadeghi", "Gholami", "Shirazi", "Tehrani", "Sharifi"};

            return lastName[rand];

        }

    }
}




