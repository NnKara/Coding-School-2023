
using Session_05;

internal class Program
{
    private static void Main(string[] args)
    {

        //Exercise #1
        Console.WriteLine("//    Exercise #1  Reverse With Library      //");
        ReverseString reverse=new ReverseString();  
        reverse.ReverseWithLibrary();
        Console.WriteLine("\n");
        Console.WriteLine("//     Exercise #1 Reverse By Hand    // ");
        reverse.ReverseByHand();
        Console.WriteLine("\n");

        //Exercise #2
        Console.WriteLine("//    Exercise #2   Product-Sum     //");
        ProductAndSum result = new ProductAndSum();
        result.SumAndProduct();
        Console.WriteLine("\n");


        //Exercise #3
        Console.WriteLine("//    Exercise #3   Prime-Numbers     //");
        PrimeNumbers primes=new PrimeNumbers();
        primes.FindPrimeNumbers();
        Console.WriteLine("\n");

        //Exercise #4
        Console.WriteLine("//    Exercise #4   Multiply Arrays    //");
        MultiplyValuesBetweenArrays multiply=new MultiplyValuesBetweenArrays();
        multiply.MultiplyArrayValues();
        Console.WriteLine("\n");

        //Exercise #5
        Console.WriteLine("//    Exercise #5 Sort Array By Hand      //");
        SortGivenArray sort=new SortGivenArray();
        sort.SortArrayByHand();
        Console.WriteLine("\n");
        Console.WriteLine("//     Exercise #5 Sort Array With Library    // ");
        sort.SortWithLibrary();
        Console.WriteLine("\n");




        Console.ReadLine();
    }
}