using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8.AccountingOfDocuments
{
    internal class FinancialInvoice : Document
    {
        private decimal _totalAmountForMonth;
        private string _departmentCode;
        //Нужно добавить свойства
        public FinancialInvoice()
        {
            _totalAmountForMonth = 0;
            _departmentCode = "Not found";
            _dateDocument = DateTime.Today;
            _numberDocument = 10;
        }
        public FinancialInvoice(decimal TotalAmountForMonth, string DepartmentCode, int NumberDocument, DateTime DateDocument)
        {
            _totalAmountForMonth = TotalAmountForMonth;
            _departmentCode = DepartmentCode;
            _numberDocument = NumberDocument;
            _dateDocument = DateDocument;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"_totalAmountForMonth = {_totalAmountForMonth}\n_departmentCode = {_departmentCode}\n_dateDocument = {_dateDocument}\n_numberDocument = {_numberDocument}");
        }
    }
}
