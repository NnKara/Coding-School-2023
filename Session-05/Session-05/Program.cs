
using Session_05;

internal class Program
{
    private static void Main(string[] args)
    {

        //Exercise #1
        Console.WriteLine("//    Exercise #1  WithLibrary      //");
        ReverseString reverse=new ReverseString();  
        reverse.ReverseWithLibrary();
        Console.WriteLine("//     Exercise #1 ByHand    // ");
        reverse.ReverseByHand();

        //Exercise #2
        Console.WriteLine("//    Exercise #2        //");
        ProductAndSum result = new ProductAndSum();
        result.SumAndProduct();













        Console.ReadLine();
    }
}