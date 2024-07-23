using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8.AccountingOfDocuments
{
    internal class СontractEmployee : Document
    {
        public string Name {  get; private set; }
        public DateTime StartDateContract {  get; private set; }
        public DateTime EndDateContract { get; private set; }
        public СontractEmployee() : base()
        {
            Name = "Not found";
            StartDateContract = DateTime.Now;
            EndDateContract = DateTime.MaxValue;
        }
        public СontractEmployee(string Name, DateTime StartDateContract, DateTime EndDateContract, string NumberDocument, DateTime DateDocument) : base(NumberDocument, DateDocument)
        {
            this.Name = Name;
            this.StartDateContract = StartDateContract;
            EndDateContract = EndDateContract;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Name = {Name}\n" +
                $"StartDateContract = {StartDateContract}\n" +
                $"EndDateContract = {EndDateContract}\n" +
                $"DateDocument = {DateDocument}\n" +
                $"NumberDocument = {NumberDocument}\n");
        }
    }
}
