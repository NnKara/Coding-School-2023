using FuelStation.EF.Repositorys;
using FuelStation.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Session_30.Shared.Ledger;

namespace Session_30.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LedgerController : ControllerBase {

        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<Employee> _employeeRepo;
        private readonly IEntityRepo<Item> _itemRepo;
        private readonly decimal _rent = 5000;

        public LedgerController(IEntityRepo<Transaction> transactionRepo, IEntityRepo<Employee> employeeRepo, IEntityRepo<Item> itemRepo) {
            _transactionRepo = transactionRepo;
            _employeeRepo = employeeRepo;
            _itemRepo = itemRepo;
        }

        [HttpGet]
        public IActionResult GetLedger() {
            List<Ledger> ledgers = new List<Ledger>();
            var items=_itemRepo.GetAll().ToList();
            var employees=_employeeRepo.GetAll().ToList();
            decimal expenses = 0;
            

            // Get all transactions for the current year and month
            DateTime currentDate = DateTime.Now;
            List<Transaction> transactions = _transactionRepo.GetAll().Where(t => t.Date.Year == currentDate.Year && t.Date.Month == currentDate.Month).ToList();

            // Calculate income
            decimal income = transactions.Sum(t => t.TotalValue);

            // Calculate expenses
            
            foreach (var item in items) {
                expenses += item.Cost;
            }

            foreach (var emp in employees) {
                expenses += emp.SalaryPerMonth;
            }

            //foreach (Transaction transaction in transactions) {
            //    foreach (TransactionLine line in transaction.TransactionLines) {
            //        decimal netValue = line.Quantity * line.ItemPrice;
            //        decimal discountValue = netValue * line.DiscountPercent;
            //        decimal totalValue = netValue - discountValue;
            //        if (line.Item.ItemType == ItemType.Fuel && netValue > 20) {
            //            discountValue += netValue * 0.1m;
            //            totalValue = netValue - discountValue;
            //        }
            //        expenses += totalValue;
            //    }
            //}

            // Calculate total
            decimal total = income - expenses - _rent;

            // Add the ledger to the list
            var currentLedger = new Ledger {
                Year = currentDate.Year,
                Month = currentDate.Month,
                Income = income,
                Expenses = expenses + _rent,
                Total = total
            };
            ledgers.Add(currentLedger);

            return Ok(ledgers);
        }
    }





}

