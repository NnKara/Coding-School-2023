using FuelStation.EF.Repositorys;
using FuelStation.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Session_30.Shared;
using Session_30.Shared.CustomerDto;
using Session_30.Shared.TransactionDto;

namespace Session_30.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
public class TransactionController : ControllerBase {

        private readonly IEntityRepo<Transaction> _trasRepo;

        public TransactionController(IEntityRepo<Transaction> trasRepo) {
            _trasRepo= trasRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<TransactionListDto>> Get() {
            var result=_trasRepo.GetAll().ToList();
            var tras = result.Select(t => new TransactionListDto {
                TransactionID = t.TransactionID,
                Date = t.Date,
                PaymentMethod = t.PaymentMethod,
                TotalValue = t.TotalValue,
                EmployeeID = t.EmployeeID,
                CustomerID = t.CustomerID,
                TransactionLines = t.TransactionLines.Select(tl => new TransactionLineListDto {
                    TransactionLineID = tl.TransactionLineID,
                    Quantity = tl.Quantity,
                    ItemPrice = tl.ItemPrice,
                    NetValue = tl.NetValue,
                    DiscountValue = tl.DiscountValue,
                    DiscountPercent = tl.DiscountPercent,
                    TotalValue = tl.TotalValue
                }).ToList()
            });
            return tras;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TransactionEditDto>> GetById(int id) {
            var result = _trasRepo.GetByID(id);
            if (result == null) {
                return NotFound();
            }
            var transaction= new TransactionEditDto {
                TransactionID = id,
                Date = result.Date,
                PaymentMethod = result.PaymentMethod,
                TotalValue = result.TotalValue,
                CustomerID=result.CustomerID,
                EmployeeID=result.EmployeeID,
                TransactionLines = result.TransactionLines.Select(transactionLine => new TransactionLineEditDto {
                    TransactionLineID = transactionLine.TransactionLineID,
                    Quantity = transactionLine.Quantity,
                    ItemPrice = transactionLine.ItemPrice,
                    NetValue = transactionLine.NetValue,
                    DiscountPercent = transactionLine.DiscountPercent,
                    DiscountValue = transactionLine.DiscountValue,
                    TotalValue = transactionLine.TotalValue,
                    TransactionID=transactionLine.TransactionID,
                    ItemID=transactionLine.ItemID
                }).ToList()
            };
            return transaction;
        }

        [HttpPost]
        public async Task Post(TransactionEditDto transaction) {
            var newTransaction = new Transaction(transaction.Date, transaction.PaymentMethod,transaction.TotalValue) {
                Date = transaction.Date,
                CustomerID = transaction.CustomerID,
                EmployeeID = transaction.EmployeeID,
                //TransactionLines = transaction.TransactionLines.Select(transactionLine => new TransactionLine(transactionLine.Quantity, transactionLine.ItemPrice, transactionLine.NetValue, transactionLine.DiscountPercent,transactionLine.DiscountValue,transactionLine.TotalValue) {
                //    TransactionLineID = transactionLine.TransactionLineID,
                //    TransactionID = transactionLine.TransactionID,
                //    ItemID = transactionLine.ItemID,
                //}).ToList()
            };
             _trasRepo.Add(newTransaction);
        }


        [HttpPut]
        public async Task Put(TransactionEditDto transaction) {
            var dbTransaction =  _trasRepo.GetByID(transaction.TransactionID);
                if (dbTransaction is null) {
                return;
            }
            dbTransaction.Date = transaction.Date;
            dbTransaction.TotalValue = transaction.TotalValue;
            dbTransaction.PaymentMethod = transaction.PaymentMethod;
            dbTransaction.EmployeeID = transaction.EmployeeID;
            //dbTransaction.TransactionLines = transaction.TransactionLines
            //    .Select(transactionLine => new TransactionLine(
            //        transactionLine.Quantity,
            //        transactionLine.ItemPrice,
            //        transactionLine.NetValue,
            //        transactionLine.DiscountPercent, 
            //        transactionLine.DiscountValue,
            //        transactionLine.TotalValue) {
            //        ItemID = transactionLine.ItemID,
            //        TransactionID = transactionLine.TransactionID,
            //        TransactionLineID = transactionLine.TransactionLineID
            //    }
            //    ).ToList();

            _trasRepo.Update(transaction.TransactionID, dbTransaction);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id) {
            try {
                await Task.Run(() => { _trasRepo.Delete(id); });
                return Ok();
            } catch (DbUpdateException) {
                return BadRequest($"Could not delete this transaction because it has transactionLines");
            } catch (KeyNotFoundException) {
                return BadRequest($"Transaction not found");
            }
        }
    }
}
