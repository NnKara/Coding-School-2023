
using Session_05;

internal class Program
{
    private static void Main(string[] args)
    {

        //Exercise #1
        Console.WriteLine("//    Exercise #1  WithLibrary      //");
        ReverseString reverse=new ReverseString();  
       // reverse.ReverseWithLibrary();
        Console.WriteLine("//     Exercise #1 ByHand    // ");
       // reverse.ReverseByHand();
        Console.WriteLine("\n");

        //Exercise #2
        Console.WriteLine("//    Exercise #2        //");
        ProductAndSum result = new ProductAndSum();
       // result.SumAndProduct();


        //Exercise #3
        Console.WriteLine("//    Exercise #2        //");
        PrimeNumbers primes=new PrimeNumbers();
        primes.FindPrimeNumbers();








        Console.ReadLine();
    }
}