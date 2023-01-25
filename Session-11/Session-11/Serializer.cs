using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Session_11
{
    public class Serializer
    {
        public void SerializeToFile(PetShop petShop, string fileName)
        {
            string jsonString = JsonSerializer.Serialize(petShop);

            File.WriteAllText(fileName, jsonString);
        }

        public T DeserializeFromFile<T>(string fileName)
        {

            string jsonString = File.ReadAllText(fileName);

            T? petShop = JsonSerializer.Deserialize<T>(jsonString);

            return petShop;


        }
    }
    }
