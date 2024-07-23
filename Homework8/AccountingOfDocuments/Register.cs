using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8.AccountingOfDocuments
{
    public class Register
    {
        IDocument[] documents = new IDocument[10];
        int count = 0;
        public void SaveDocument(IDocument document)
        {
            if (count < documents.Length)
            {
                documents[count] = document;
                count++;

                GetDocument(0);
            }
            else
            {
                Console.WriteLine("Error, The register is full");
            }
        }
        public void GetDocument(int index)
        {
            documents[index].PrintInfo();
        }
    }
}
