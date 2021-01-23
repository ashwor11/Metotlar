using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager vehicleLoanManager = new VehicleLoanManager();
            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            ICreditManager housingLoanManager = new HousingLoanManager();
            ICreditManager artisanCreditManager = new ArtisanCreditManager();

            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new DataBaseLoggerService() };

            ApplyManager applyManager = new ApplyManager();
            applyManager.BasvuruYap(artisanCreditManager, loggers);

            List<ICreditManager> credits = new List<ICreditManager>() { personalFinanceCreditManager,housingLoanManager };

            //applyManager.CreditPreInformation(credits);
            //interface=birbirleriyle alakalı ama kodları farklı olanlar için kullanılır.--
        }
    }
}
