using System;

namespace ClsWrkActivityOOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initializing object
            // object reference name - you choose what ever you want             
            Car bmw = new Car(234, "bmw", "2019", "Red");
            
            // 
            Console.WriteLine(bmw.Id);
            Console.WriteLine(bmw.Color);
            Console.WriteLine(bmw.Model);
            // Tostring method
            Console.WriteLine(bmw);

            // How you call the method 
            // method is returning something (string)
            // how you get this return thing
            // var --> dynamic type 
            int carKey = 1245;
            // Step 1: Start the car with Key
            var  carIsStarted = bmw.Start(carKey);
            Console.WriteLine(carIsStarted);
            // Step 2: while car is starting then you should drive the car
            var moving = bmw.Move(carIsStarted);
            Console.WriteLine(moving);
            // step 3: while you stop your driving you need a brake
            var carIsStopped = bmw.Stop(moving);
            Console.WriteLine(carIsStopped);
           // Console.WriteLine(bmw);



            Car audi = new Car();
            Car honda = new Car();

            Console.ReadKey();

            // Class
            // object 
            // Encapsulation 
            // Abstraction
            // Inheritance
        }
           
    }
}

