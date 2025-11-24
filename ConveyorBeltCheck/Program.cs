
class Program
{
    static void Main()
    {   
        // Input motors - must be integer and allow mutation (not constant) - we use ?? "" to avoid null issues
        Console.Write("How many motors are carrying the packages? ");

        // int.Parse to convert string input to integer
        int motors = int.Parse(Console.ReadLine() ?? "");
        
        // Input weight - must be double and allow mutations
        Console.Write("How many kg of packages do we expect? ");

        // double.Parse to convert string input to double
        double weight = double.Parse(Console.ReadLine() ?? "");

        // Each motor can handle 5.6 kg - constant
        const double capacityPerMotor = 5.6;

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
