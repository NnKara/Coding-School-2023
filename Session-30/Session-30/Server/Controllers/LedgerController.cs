using FuelStation.EF.Repositorys;
using FuelStation.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Session_30.Shared.Ledger;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Session_30.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LedgerController : ControllerBase
    {

        private readonly ITransactionRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<Employee> _employeeRepo;
        private readonly IEntityRepo<Item> _itemRepo;
        private readonly DateTime currentDate = DateTime.Now;


        public LedgerController(ITransactionRepo<Transaction> transactionRepo, IEntityRepo<Employee> employeeRepo, IEntityRepo<Item> itemRepo)
        {
            _transactionRepo = transactionRepo;
            _employeeRepo = employeeRepo;
            _itemRepo = itemRepo;
        }


        [Route("/ledger/details/{int}")]
        [HttpGet]
        public async Task <IEnumerable<LedgerListDto>>? GetLedger(int rent)
        {
            List<LedgerListDto> ledgers = new List<LedgerListDto>();
            var items = _itemRepo.GetAll().ToList();
            var employees = _employeeRepo.GetAll().ToList();

            // Retrieve the date of the first transaction made
            var firstTransactionDate = _transactionRepo.GetAll().OrderBy(t => t.Date).FirstOrDefault()?.Date;

            if (firstTransactionDate == null)
            {
                return ledgers;
            }
            else
            {

                // Calculate the month of the first transaction date
                var firstTransactionMonth = new DateTime(firstTransactionDate.Value.Year, firstTransactionDate.Value.Month, 1);


                // Calculate the number of months between the first transaction month and the current month
                int monthsSinceFirstTransaction = ((currentDate.Year - firstTransactionMonth.Year) * 12) + (currentDate.Month - firstTransactionMonth.Month);

                // Loop through each month since the first transaction date until the current month
                for (int i = 0; i <= monthsSinceFirstTransaction; i++)
                {
                    DateTime monthStartDate = firstTransactionMonth.AddMonths(i);
                    DateTime monthEndDate = new DateTime(monthStartDate.Year, monthStartDate.Month, DateTime.DaysInMonth(monthStartDate.Year, monthStartDate.Month));


                    // Get transactions for the current month
                    List<Transaction> transactions = _transactionRepo.GetAll().Where(t => t.Date >= monthStartDate && t.Date <= monthEndDate).ToList();

                    decimal income = transactions.Sum(t => t.TotalValue);
                    decimal expenses = items.Sum(i => i.Cost) + employees.Sum(e => e.SalaryPerMonth);
                    decimal total = income - expenses - rent;

                    var currentLedger = new LedgerListDto
                    {
                        Year = monthStartDate.Year,
                        Month = monthStartDate.Month,
                        Income = income,
                        Expenses = expenses + rent,
                        Total = total
                    };

                    ledgers.Add(currentLedger);
                }
            }

            return ledgers;

        }





    }
}

