using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        //Method injection
        public void MakeOnApplication(ICrediManager crediManager,List<ILoggerService> loggerServices)
        {
            //Başvuran bilgilerini değerlendirme 
            //

            crediManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }
        public void CrediInformation(List<ICrediManager> credis)
        {
            foreach (var credi in credis)
            {
                credi.Calculate();
            }
        }
    }
}
