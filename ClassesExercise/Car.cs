using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercise
{
    public class Car
    {

        //Constructors

        public Car() //- a special member method that has the same name as it's class.
        {

        }



        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }




        //Fields
        //Properties
        //Methods


        // Create a Make property of type string that is public
        public string Make { get; set; } //get = read, set = write
        public string Model { get; set; }
        public int Year { get; set; }

    }
}
