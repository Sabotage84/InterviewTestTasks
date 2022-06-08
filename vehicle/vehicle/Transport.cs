using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle
{
    abstract class Transport
    {
        double averageFuelConsumption;
        double tankCapacity;
        double speed;

        protected Transport(double averageFuelConsumption, double tankCapacity, double speed)
        {
            AverageFuelConsumption = averageFuelConsumption;
            TankCapacity = tankCapacity;
            Speed = speed;
        }

        public double AverageFuelConsumption { get => averageFuelConsumption; set => averageFuelConsumption = value; }
        public double TankCapacity { get => tankCapacity; set => tankCapacity = value; }
        public double Speed { get => speed; set => speed = value; }

        public virtual double GetMaxDistance()
        {
            return 0;
        }

        public virtual double GetCurrentDistance()
        {
            return 0;
        }

    }
}
