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

        public string startTow()
        {
            isTowing = true;
            var line = "Towing has begun.  \nWow!  The people sitting in the " + CabType + " are in for a show!";

            return line;
        }

        public string stopTow()
        {
            isTowing = false;
            var line = "Towing has stopped.";

            return line;
        }

    }
}
