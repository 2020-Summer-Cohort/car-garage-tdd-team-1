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
        public bool ToggleEngine { get; set; }

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
        public void Brake(int slowDown)
        {
            CurrentFuel -= slowDown;
        }

        public void EngineOn()
        {
            ToggleEngine = true;
        }
        public void EngineOff()
        {
            ToggleEngine = false;
        }
    }

}
