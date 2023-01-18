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
           
            try
            {

                switch (request.Action)
                {
                    case ActionEnum.Convert:
                        ConvertToBinary binaryConverter = new ConvertToBinary();
                        response.Output = binaryConverter.BinaryConverter(request.Input);
                        break;

                    case ActionEnum.Uppercase:
                        ConvertToUpperCase converter = new ConvertToUpperCase();
                        response.Output = converter.UppercaseConverter(request.Input);
                        break;


                    case ActionEnum.Reverse:
                        ReverseString reverse = new ReverseString();
                        response.Output = reverse.ReverseStringWithRecursion(request.Input);
                        break;

                    default:

                        break;

                }

               

            }
            catch (Exception ex)

            {
                throw;
            }
            
            return response;




            
        }
    }
}
