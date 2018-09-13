using System;

namespace ClassProj911
{
    class Automobile
    {
        public string Color { get; set; }
        public string EngineType { get; set; }
        public bool isOn { get; set; }

        

        public void Start(string type)
        {
            if (isOn)
            {
                Console.WriteLine("The " + type + " is already on.");
            }
            else
            {
                isOn = true;
                Console.WriteLine("The " + type + " is started!");
            }
        }

        public void Stop(string type)
        {
            if (isOn)
            {
                isOn = false;
                Console.WriteLine("The " + type + " is off!");
            }
            else
            {
                Console.WriteLine("The " + type + " is already off.");
            }
        }

        public string getState(string type)
        {
            if (isOn == false)
            {
                return "The " + type + " is off";
            } else
            {
                return "The " + type + " is on.";
            }
        }



    }
}
