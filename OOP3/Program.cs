using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICrediManager personalFinanceCrediManager = new PersonalFinanceCrediManager();
            ICrediManager vehicleCrediManager = new VehicleCrediManager();
            ICrediManager housingCrediManager = new HousingCrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeOnApplication(personalFinanceCrediManager, new List<ILoggerService>() { databaseLoggerService,fileLoggerService });
            Console.WriteLine("-----------------------------------------------------------");
            applicationManager.MakeOnApplication(new TradesmanCrediManager(),new List<ILoggerService>() { new SmsLoggerService() });

            List<ICrediManager> crediler = new List<ICrediManager>() { personalFinanceCrediManager,vehicleCrediManager};
            //applicationManager.CrediInformation(crediler);
        }
    }
}
