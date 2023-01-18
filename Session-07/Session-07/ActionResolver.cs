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
            Logger.Write(new Message("EXECUTION START"));
           
            try
            {

                switch (request.Action)
                {
                    case ActionEnum.Convert:
                        Logger.Write(new Message("EXECUTION FOR BINARY"));
                        ConvertToBinary binaryConverter = new ConvertToBinary();
                        response.Output = binaryConverter.BinaryConverter(request.Input);
                        break;

                    case ActionEnum.Uppercase:
                        Logger.Write(new Message("EXECUTION FOR UPPERCASE"));
                        ConvertToUpperCase converter = new ConvertToUpperCase();
                        response.Output = converter.UppercaseConverter(request.Input);                      
                        break;


                    case ActionEnum.Reverse:
                        Logger.Write(new Message("EXECUTION FOR REVERSE"));
                        ReverseString reverse = new ReverseString();
                        response.Output = reverse.ReverseStringWithRecursion(request.Input);
                        break;

                    default:

                        break;

                }

               

            }
            catch (Exception ex)

            {              
                Logger.Write(new Message(ex.Message));
               
                throw;
            }
            finally
            {
                Logger.Write(new Message("EXECUTION END"));
            }
            
            return response;




            
        }
    }
}
