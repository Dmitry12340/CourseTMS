using System.Text.Json;

namespace Homework13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\diman\OneDrive\Рабочий стол\4.json";

            string result = "";
            //SomeClass someClass = new SomeClass(1, "Dmity", 30);
            //CreateJson(someClass);
            using (FileStream fileStream = new FileStream(path, FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    result = reader.ReadToEnd();
                }
            }
            Console.WriteLine(result);


            //var deserializedJson = JsonSerializer.Deserialize<SomeClass>(serializedJson);
            //Console.WriteLine($"Id = {deserializedJson.Id}\nName = {deserializedJson.Name}\nAge = {deserializedJson.Age}");


        }
        //Метод для сериализации в json
        static void CreateJson(Object instance)
        {
            string path = @"C:\Users\diman\OneDrive\Рабочий стол\1.json";

            var serializedJson = JsonSerializer.Serialize(instance);
            Console.WriteLine(serializedJson);

            using (FileStream fileStream = new FileStream(path, FileMode.Create))
            {
                using (StreamWriter streamWriter = new StreamWriter(fileStream))
                {
                    streamWriter.Write(serializedJson);
                    streamWriter.Dispose();
                }
                fileStream.Dispose();
            }
        }
    }
}
