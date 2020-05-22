using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    public class Garage
    {
        public List<Car> GarageCars = new List<Car>();
       
        
        public void AddCar(string newCar)
        {
            GarageCars += newCar;
        }


    }

}
