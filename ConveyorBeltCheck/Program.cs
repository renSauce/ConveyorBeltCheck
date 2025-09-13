using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("How many motors are carrying the packages? ");
        int motors = int.Parse(Console.ReadLine()!);

        Console.Write("How many kg of packages do we expect? ");
        double weight = double.Parse(Console.ReadLine()!);

        // Each motor can handle 5.6 kg
        double capacityPerMotor = 5.6;

        // Check
        if (weight / motors <= capacityPerMotor)
        {
            Console.WriteLine("Yes! The conveyor belt can carry the packages.");
        }
        else
        {
            Console.WriteLine("No. The conveyor belt cannot carry the packages.");
        }
    }
}
