using System;

namespace ClassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //dot notation
            Car myCar = new Car(); // Constructor = special member method. Helps us create a new instance of the 'Car' class

            myCar.Make = "Suzuki"; //Properties
            myCar.Model = "Forenza";
            myCar.Year = 2008;

            //object initializer
            var mazda = new Car()
            {
                Make = "Mazda",
                Model = "CX-5",
                Year = 2016
            };


            //passing in through constructor

            var chevy = new Car("Chevy", "Impala", 1964);



            Console.WriteLine(myCar.Make);
            Console.WriteLine(myCar.Model);
            Console.WriteLine(myCar.Year);

            Console.WriteLine(mazda.Make);
            Console.WriteLine(mazda.Model);
            Console.WriteLine(mazda.Year);

            Console.WriteLine(chevy.Make);
            Console.WriteLine(chevy.Model);
            Console.WriteLine(chevy.Year);





        }
    }
}
