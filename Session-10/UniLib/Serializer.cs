using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace UniLib
{
    public class Serializer
    {
        public void Serialize(object obj)
        {
            string jsonString = JsonSerializer.Serialize(obj);
        }


        public void SerializeToFile(object obj, string fileName)
        {

            
            string jsonString = JsonSerializer.Serialize(obj);

            File.WriteAllText(fileName, jsonString);
        }


        public T Deserialize<T>(string fileName)
        {

            string jsonString = File.ReadAllText(fileName);
            T? obj = JsonSerializer.Deserialize<T>(jsonString);

            return obj;
        }

    }
}
