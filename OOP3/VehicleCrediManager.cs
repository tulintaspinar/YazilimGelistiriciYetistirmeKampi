﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class VehicleCrediManager : ICrediManager
    {
        public void Calculate()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı.");
        }

        public void DoIt()
        {
            throw new NotImplementedException();
        }
    }
}
