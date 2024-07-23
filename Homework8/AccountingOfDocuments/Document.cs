using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8.AccountingOfDocuments
{
    abstract class Document : IDocument
    {
        public string NumberDocument { get; private set; }
        public DateTime DateDocument { get; private set; }

        public Document(string NumberDocument, DateTime DateDocument)
        {
            this.NumberDocument = NumberDocument;
            this.DateDocument = DateDocument;
        }
        protected Document()
        {
            NumberDocument = "Not found";
            DateDocument = DateTime.Now;
        }

        public abstract void PrintInfo();
    }
}
