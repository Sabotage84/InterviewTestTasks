using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle
{
    class PassengerCar : Transport
    {
        const int MAX_PASSENGERS = 4;

        int currentPassengers;
        public PassengerCar( double averageFuelConsumption, double tankCapacity, double speed, int curPas = 0) : base(averageFuelConsumption, tankCapacity, speed)
        {
            CurrentPassengers = curPas;
        }

        public int CurrentPassengers { get => currentPassengers; 
        set
            {
                if (value < 0 || value > MAX_PASSENGERS)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    currentPassengers = value;
                }
            }
        }


    }
}
