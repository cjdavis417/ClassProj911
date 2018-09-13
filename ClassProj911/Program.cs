using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProj911
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<string> commands = new List<string> (new string[] 
            {
                "Help",
                "Engine State",
                "Start Engine",
                "Stop Engine",
                "Start Tow",
                "Stop Tow",
                "Color"
            } );
            var chevy = new Truck();
            chevy.CabType = "Extended Cab";
            chevy.EngineType = "Hybrid";
            chevy.Color = "Tangerine";

            Console.WriteLine("Welcome to C.A.R. \nType 'Help' to see the list of available commands");
            UserInput();
            
            void UserInput()
            {
                do
                {
                    Console.Write("Command: ");
                    input = Console.ReadLine();

                    if (input == "Help")
                    {
                        Console.WriteLine("- Available Commands -");
                        foreach (var command in commands)
                        {
                            Console.WriteLine(command);
                        }
                    }
                    else if (input == "Engine State")
                    {
                        var state = chevy.getState(chevy.Type);
                        Console.WriteLine(state);
                    }
                    else if (input == "Start Engine")
                    {
                        chevy.Start(chevy.Type);
                    }
                    else if (input == "Stop Engine")
                    {
                        chevy.Stop(chevy.Type);
                    }
                    else if (input == "Start Tow")
                    {
                        Console.WriteLine(chevy.startTow());
                    }
                    else if (input == "Stop Tow")
                    {
                        Console.WriteLine(chevy.stopTow());
                    }
                    else if (input == "Color")
                    {
                        Console.WriteLine("The color is " + chevy.Color + ".");
                    }
                    else
                    {
                        Console.Write("Not a valid command.  \nType 'Help' to see all commands.");
                    }

                } while (input != "");

            }

        }

        
    }
}
