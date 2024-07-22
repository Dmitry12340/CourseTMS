using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8.AccountingOfDocuments
{
    internal class СontractEmployee : Document
    {
        private string _name;
        private DateTime _startDateContract;
        private DateTime _endDateContract;
        public СontractEmployee() : base()
        {
            _name = "Not found";
            _startDateContract = DateTime.Now;
            _endDateContract = DateTime.MaxValue;
        }
        public СontractEmployee(string Name, DateTime StartDateContract, DateTime EndDateContract, string NumberDocument, DateTime DateDocument) : base(NumberDocument, DateDocument)
        {
            _name = Name;
            _startDateContract = StartDateContract;
            _endDateContract = EndDateContract;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"_name = {_name}\n_startDateContract = {_startDateContract}\n_endDateContract = {_endDateContract}\n_dateDocument = {_dateDocument}\n_numberDocument = {_numberDocument}");
        }
    }
}
