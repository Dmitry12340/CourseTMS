
using System.Text;

namespace Lesson10
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Person2
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person1 = new Person { Name = "John", Age = 30 };
            //Person2 person2 = new Person2 { Name = "John", Age = 30 };

            //bool areEqual = AreEqual(person1, person2);
            //Console.WriteLine(areEqual);


            Person person = new Person { Name = "John", Age = 30 };

            string json = SerializeToJson(person);
            Console.WriteLine(json);
        }

        private static string SerializeToJson(object obj)
        {
            Type type = obj.GetType();
            StringBuilder sb = new StringBuilder();

            var prop = type.GetProperties();
            sb.Append("{");
            for (int i = 0; i < prop.Length; i++)
            {
                //sb.AppendFormat("\"{0}\"\":\"{1}\"");
                sb.Append(prop[i].Name);
                sb.Append(":");
                sb.Append(prop[i].GetValue(obj));
                if(i < prop.Length - 1)
                {
                    sb.Append(",");
                }
            }
            sb.Append("}");
            return sb.ToString();
        }

        private static bool AreEqual(object obj1, object obj2)
        {
            Type type1 = obj1.GetType();
            Type type2 = obj2.GetType();
            if (type1 != type2)
            {
                return false;
            }
            else
            {
                var Properties = type1.GetProperties();
                foreach (var prop in Properties)
                {
                    var value = prop.GetValue(obj1, null);
                    var value2 = prop.GetValue(obj2, null);
                    if (!object.Equals(value, value2))
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
