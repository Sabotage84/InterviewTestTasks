using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle
{
    class PassengerCar : Transport
    {
        int maxPassengers;

        int currentPassengers;
        public PassengerCar( double averageFuelConsumption, double tankCapacity, double speed, int curPas = 0, int maxPass=4) : base(averageFuelConsumption, tankCapacity, speed)
        {
            MaxPassengers = maxPass;
            CurrentPassengers = curPas;
        }

        public int CurrentPassengers { get => currentPassengers; 
        set
            {
                if (value < 0 || value > MaxPassengers)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    currentPassengers = value;
                }
            }
        }

        public int MaxPassengers { get => maxPassengers; set => maxPassengers = value; }

        public double GetMaxDistanceWithPassengers()
        {
            return GetMaxDistance() * (0.06 * CurrentPassengers);
        }

        public double GetCurrentDistanceWithPassengers()
        {
            return GetCurrentDistance() * (0.06 * CurrentPassengers);
        }

        public double GetFuelByDistanceWithPassengers(int dist)
        {
            return GetFuelByDistance(dist) * (0.06 * CurrentPassengers);
        }

    }
}
