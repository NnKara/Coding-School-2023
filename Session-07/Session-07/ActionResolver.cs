using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    internal class ActionResolver
    {
       public MessageLogger? Logger { get; set; }



        public ActionResponse Execute(ActionRequest request)
        {
            ActionResponse response = new ActionResponse();
            response.ResponseID=Guid.NewGuid();
            response.RequestID=request.RequestID;

            Logger = new MessageLogger();
            Log("EXECUTION START");
           
            try
            {

                switch (request.Action)
                {
                    case ActionEnum.Convert:
                        Log("EXECUTION FOR BINARY");
                        ConvertToBinary binaryConverter = new ConvertToBinary();
                        response.Output = binaryConverter.Manipulate(request.Input);
                        break;

                    case ActionEnum.Uppercase:
                        Log("EXECUTION FOR UPPERCASE");
                        ConvertToUpperCase converter = new ConvertToUpperCase();
                        response.Output = converter.Manipulate(request.Input);                      
                        break;


                    case ActionEnum.Reverse:
                        Log("EXECUTION FOR REVERSE");
                        ReverseString reverse = new ReverseString();
                        response.Output = reverse.Manipulate(request.Input);
                        break;

                    default:

                        break;

                }
            }
            catch (Exception ex)

            {              
                Log(ex.Message);
               
                throw;
            }
            finally
            {
                Log("EXECUTION END");
            }


            
            return response;
        }
        public void Log(String loggerMesssage)
        {
            Logger.Write(new Message(loggerMesssage)); 
        }
    }
}
