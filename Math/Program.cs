using System;

namespace Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FourTransactions fourTransaction = new FourTransactions();
            fourTransaction.Sum(5, 6);
            fourTransaction.Sum(6, 9);
        }
    }
}
