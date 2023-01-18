
using Session_07;

internal class Program
{
    private static void Main(string[] args)
    {
        ActionResolver resolver= new ActionResolver();
        ActionResponse response=new ActionResponse();
        ActionRequest request=new ActionRequest();
        response = resolver.Execute(request);
        
        
        Console.ReadLine();
    }
}