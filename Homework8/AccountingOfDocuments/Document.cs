using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8.AccountingOfDocuments
{
    internal abstract class Document
    {
        protected string _numberDocument;
        protected DateTime _dateDocument;
        protected Document()
        {
            _numberDocument = "Not found";
            _dateDocument = DateTime.Now;
        }
        protected Document(string NumberDocument, DateTime DateDocument)
        {
            _numberDocument = NumberDocument;
            _dateDocument = DateDocument;
        }
    }
}
