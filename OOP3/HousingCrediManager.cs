﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class HousingCrediManager : ICrediManager
    {
        public void Calculate()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı.");
        }

        public void DoIt()
        {
            throw new NotImplementedException();
        }
    }
}
