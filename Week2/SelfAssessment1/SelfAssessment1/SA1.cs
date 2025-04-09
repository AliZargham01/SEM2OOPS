using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssessment1
{
    public class SA1
    {
        public void sa1()
        {
            Transaction transaction1 = new Transaction();
            transaction1.TransactionID = "1";
            transaction1.ProductName = "Eggs";
            transaction1.DateTime = "2:00";
            transaction1.amount = 100;
            Transaction transaction2 = new Transaction(transaction1);
            transaction1.ProductName = "Bread";
            Console.WriteLine(transaction1.ProductName);
            Console.WriteLine(transaction2.ProductName);
        }
    }
     class Transaction
    {
        public string TransactionID;
        public string ProductName;
        public String DateTime;
        public int amount;
        public Transaction()
        {

        }
        public Transaction(Transaction transaction)
        {
            TransactionID = transaction.TransactionID;
            ProductName = transaction.ProductName;
            DateTime = transaction.DateTime;
            amount = transaction.amount;
        }
    }
}
