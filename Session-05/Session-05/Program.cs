
using Session_05;

internal class Program
{
    private static void Main(string[] args)
    {

        //Exercise #1
        Console.WriteLine("//    Exercise #1  WithLibrary      //");
        ReverseString reverse=new ReverseString();  
        reverse.ReverseWithLibrary();
        Console.WriteLine("\n");
        Console.WriteLine("//     Exercise #1 ByHand    // ");
        reverse.ReverseByHand();
        Console.WriteLine("\n");

        //Exercise #2
        Console.WriteLine("//    Exercise #2        //");
        ProductAndSum result = new ProductAndSum();
        result.SumAndProduct();
        Console.WriteLine("\n");


        //Exercise #3
        Console.WriteLine("//    Exercise #3        //");
        PrimeNumbers primes=new PrimeNumbers();
        primes.FindPrimeNumbers();
        Console.WriteLine("\n");

        //Exercise #4
        Console.WriteLine("//    Exercise #4       //");
        MultiplyValuesBetweenArrays multiply=new MultiplyValuesBetweenArrays();
        multiply.MultiplyArrayValues();
        Console.WriteLine("\n");








        Console.ReadLine();
    }
}