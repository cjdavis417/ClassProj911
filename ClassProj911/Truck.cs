using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProj911
{
    class Truck : Automobile
    {

        public string Type { get; } = "Truck";
        public string CabType { get; set; }
        public bool isTowing { get; set; } = false;

        private string line;

        public string startTow()
        {
            if (isOn)
            {
                isTowing = true;
                line = "Towing has begun.  \nWow!  The people sitting in the " + CabType + " are in for a show!";
            }
            else
            {
                line = "The engine must be started first.";
            }
            return line;
        }

        public string stopTow()
        {
            isTowing = false;
            line = "Towing has stopped.";

            return line;
        }

    }
}
