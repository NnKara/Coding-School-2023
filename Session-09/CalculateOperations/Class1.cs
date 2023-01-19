namespace CalculateOperations
{
    public class class1
    {
        public decimal Addition(decimal? value1,decimal? value2)
        {
            decimal result= 0;
            if(value1!=null && value2!=null)
            {
                result = value1.Value + value2.Value;
            }

            return result;
        }
    }
}