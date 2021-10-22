using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance_Console
{
    //This is where the conversation with the user takes place.
    public class ProgramUI
    {
        public void Run()
        {

        }

        private void Menu()
        {
            Console.WriteLine("Please utilize this interface to manipulate developer data: \n" +
                "1. Enter name of developer: \n" +
                "2. Enter developer ID: \n" +
                "3. Enter 'Yes' if developer has Pluralsight access.  If not, enter 'No': \n" +
                "4. Enter the name of the team the developer is assigned to:  \n" +
                "5. Enter the team ID the developer is assigned to: \n" +
                "6. Exit");

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    //Developer's name
                    break;
                case "2":
                    //Developer's ID
                    break;
                case "3":
                    //Developer's status regarding access to Pluralsight
                    break;
                case "4":
                    //Developer's team name
                    break;
                case "5":
                    //Developer's team ID
                    break;
                case "6":
                //Exit
                default:
                    Console.WriteLine("Please input a valid entry.  \n" +
                        "Press any key to continue...");
                    Console.ReadKey();
                    break;
            }
        }
        private void EnterNeWContent()
        {
            Developer developer = new Developer();
            //Developer name
            Console.WriteLine("Welcome back to Komodo Insurance's user interface.  Please provide the relevant information in regards to the developer in question: \n" +
                "Please enter the Name of the developer: ");
            developer.DeveloperName = Console.ReadLine();
            //Developer ID
            Console.WriteLine("Please enter the ID of the developer: ");
            developer.DeveloperID = Console.ReadLine();
            //Status of Pluralsight access
            Console.WriteLine("Please answer 'Yes' if the developer has access to Pluralshight. \n" +
                "Please answer 'No' otherwise: ");
            developer.HasPluralsightAccess = Console.ReadLine();

        }
    }
}
