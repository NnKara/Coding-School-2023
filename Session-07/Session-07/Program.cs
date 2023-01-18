
using Session_07;

internal class Program
{
    private static void Main(string[] args)
    {
        ActionResolver resolver = new ActionResolver();
        ActionResponse response = new ActionResponse();
        ActionRequest request = new ActionRequest()
        {
            Input = "Hi am Nikos!",
            Action = ActionEnum.Uppercase
        };
        response = resolver.Execute(request);

        resolver.Logger.ReadAll();

        Console.ReadLine();
    }
}