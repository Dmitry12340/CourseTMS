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

        public FinancialInvoice() : base()
        {
            _totalAmountForMonth = 0;
            _departmentCode = "Not found"; 
        }
        public FinancialInvoice(decimal TotalAmountForMonth, string DepartmentCode, string NumberDocument, DateTime DateDocument) : base(NumberDocument, DateDocument)
        {
            _totalAmountForMonth = TotalAmountForMonth;
            _departmentCode = DepartmentCode;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"_totalAmountForMonth = {_totalAmountForMonth}\n_departmentCode = {_departmentCode}\n_dateDocument = {_dateDocument}\n_numberDocument = {_numberDocument}");
        }
    }
}
