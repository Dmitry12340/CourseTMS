using System.Text.Json;

namespace Homework13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\diman\source\repos\CourseTMS\Homework13\JsonFiles";

            var files = Directory.GetFileSystemEntries(path, "*.json");

            for (int i = 0; i < files.Length; i++)
            {
                string Newfile = files[i].Remove(0, path.Length + 1);
                Console.WriteLine($"{i + 1} : {Newfile}");
            }

            Console.WriteLine();
            Console.WriteLine("Введите номер файла который нужно десериализовать");

            int numberFile = 0;
            bool tryParse = false;
            bool correctInput = false;

            while(!tryParse || !correctInput)
            {
                tryParse = int.TryParse(Console.ReadLine(), out numberFile);
                if(numberFile > 0 && numberFile <= files.Length)
                {
                    correctInput = true;
                }
                else
                {
                    Console.WriteLine("Введены некорректные данные");
                }
            }
            Console.WriteLine();



            string result = "";

            using (FileStream fileStream = new FileStream(files[numberFile - 1], FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    result = reader.ReadToEnd();
                    reader.Dispose();
                }
                fileStream.Dispose();
            }
            Console.WriteLine(result);


            var deserializedJson = JsonSerializer.Deserialize<SomeClass>(result);
            Console.WriteLine($"Id = {deserializedJson.Id}\nName = {deserializedJson.Name}\nAge = {deserializedJson.Age}");


        }

        //Метод для сериализации в json
        static void CreateJson(Object instance, string path)
        {
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
