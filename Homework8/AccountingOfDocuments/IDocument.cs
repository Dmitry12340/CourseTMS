using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8.AccountingOfDocuments
{
    public interface IDocument
    {
        string NumberDocument { get; }
        DateTime DateDocument { get; }
        void PrintInfo();
    }
}
