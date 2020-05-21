using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    public class Car
    {

        public int CurrentSpeed { get; set; }
        public int CurrentFuel { get; set; }
        public int FuelingUp { get; set; }

        public void Accelerate(int speedChange)
        {
            CurrentSpeed += speedChange;
        }
        public void ReduceFuel(int fuelLoss)
        {
            CurrentFuel -= fuelLoss;
        }
        public void AddFuel(int refuel)
        {
            FuelingUp += refuel;
        }
    }

}
