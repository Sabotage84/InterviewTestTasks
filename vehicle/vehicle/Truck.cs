using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle
{
    class Truck : Transport
    {
        double maxCargoWeight;
        double currentCargoWeight;
        public Truck(double averageFuelConsumption, double tankCapacity, double speed, double curWeight=0, double maxCargo = 1000) : base(averageFuelConsumption, tankCapacity, speed)
        {
            MaxCargoWeight = maxCargo;
            CurrentCargoWeight = curWeight;
        }

        public double CurrentCargoWeight 
        { get => currentCargoWeight;
            set 
            {
                if (value < 0 || value > MaxCargoWeight)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    CurrentCargoWeight = value;
                }
            } 
        }

        public double MaxCargoWeight { get => maxCargoWeight; set => maxCargoWeight = value; }
    }
}
