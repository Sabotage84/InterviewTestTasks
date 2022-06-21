using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle
{
    class SportCarcs : Transport
    {
        public SportCarcs(double averageFuelConsumption, double tankCapacity, double speed) : base(averageFuelConsumption, tankCapacity, speed)
        {
        }
    }
}
