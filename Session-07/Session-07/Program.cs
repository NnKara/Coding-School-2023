
using Session_07;

internal class Program
{
    private static void Main(string[] args)
    {

        MessageLogger logger = new MessageLogger();

        ActionResolver resolver = new ActionResolver();

        ActionRequest request = new ActionRequest();

        ActionResponse response = new ActionResponse();

        response = resolver.Execute(request);
        
        Console.ReadLine();
    }
}