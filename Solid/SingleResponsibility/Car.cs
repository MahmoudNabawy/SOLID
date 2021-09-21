using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    //A class should have one and only one reason to change, 
    //meaning that a class should have only one job.

    public class Car
    {
        private int speed;
        private string name;

        public Car(int speed, string name)
        {
            this.speed = speed;
            this.name = name;
        }

        // This methods are belong to car and doing his job
        public void startEngine() { }
        public void accelerate() { }
        public void stopEngine() { }

        // but this method not belong to car functionality
        public void driveToPlace() { }

    }
}
