using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TradesmanCrediManager : ICrediManager
    {
        public void Calculate()
        {
            Console.WriteLine("Esnaf kredisi hesaplandı.");
        }

        public void DoIt()
        {
            throw new NotImplementedException();
        }
    }
}
