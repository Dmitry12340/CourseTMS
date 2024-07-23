using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8.AccountingOfDocuments
{
    internal class FinancialInvoice : Document
    {
        public decimal TotalAmountForMonth {  get; private set; }
        public string DepartmentCode { get; private set; }

        public FinancialInvoice() : base()
        {
            TotalAmountForMonth = 0;
            DepartmentCode = "Not found"; 
        }
        public FinancialInvoice(decimal TotalAmountForMonth, string DepartmentCode, string NumberDocument, DateTime DateDocument) : base(NumberDocument, DateDocument)
        {
            this.TotalAmountForMonth = TotalAmountForMonth;
            this.DepartmentCode = DepartmentCode;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"TotalAmountForMonth = {TotalAmountForMonth}\n" +
                $"DepartmentCode = {DepartmentCode}\n" +
                $"DateDocument = {DateDocument}\n" +
                $"NumberDocument = {NumberDocument}\n");
        }
    }
}
