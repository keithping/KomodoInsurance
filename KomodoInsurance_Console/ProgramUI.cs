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
                "2. ");

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    //Developer's name
                    break;
            }

        }
    }
}
