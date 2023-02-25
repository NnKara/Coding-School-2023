using FuelStation.EF.Repositorys;
using FuelStation.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Session_30.Shared;
using Session_30.Shared.CustomerDto;
using System.Reflection.Metadata.Ecma335;

namespace Session_30.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TransactionLineController : ControllerBase {


        private readonly IEntityRepo<TransactionLine> _transLineRepo;

        public TransactionLineController(IEntityRepo<TransactionLine> transLineRepo) {
            _transLineRepo = transLineRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<TransactionLineListDto>> Get() {
            var result = _transLineRepo.GetAll().ToList();
            var transLine = result.Select(t => new TransactionLineListDto {
                TransactionLineID = t.TransactionLineID,
                Quantity = t.Quantity,
                ItemPrice = t.ItemPrice,
                TotalValue = t.TotalValue,
                DiscountPercent = t.DiscountPercent,
                DiscountValue = t.DiscountValue,
                NetValue = t.NetValue,
                TransactionID = t.TransactionID,
                ItemID = t.ItemID

            });
            return transLine;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TransactionLineListDto>> GetById(int id) {
            var result = _transLineRepo.GetByID(id);
            if (result == null) {
                return NotFound();
            }
            return new TransactionLineListDto {
                TransactionLineID = result.TransactionLineID,
                Quantity = result.Quantity,
                ItemPrice = result.ItemPrice,
                NetValue = result.NetValue,
                DiscountPercent = result.DiscountPercent,
                DiscountValue = result.DiscountValue,
                TotalValue = result.TotalValue,
                TransactionID = result.TransactionID,
                ItemID = result.ItemID
            };
        }
        [HttpPost]
        public async Task<IActionResult> Post(TransactionLineEditDto transLine) {

            var newTransaction = new TransactionLine(
                transLine.Quantity,
                transLine.ItemPrice,
                transLine.NetValue,
                transLine.DiscountPercent,
                transLine.DiscountValue,
                transLine.TotalValue
               );
          await Task.Run(() => { _transLineRepo.Add(newTransaction); });
            return Ok();
        }
           

    


        [HttpPut]
        public async Task<IActionResult> Put(TransactionLineEditDto transLine) {
            var itemToUpdate = _transLineRepo.GetByID(transLine.TransactionID);

            if (itemToUpdate == null) {
                return NotFound();
            }

            itemToUpdate.Quantity = transLine.Quantity;
            itemToUpdate.ItemPrice = transLine.ItemPrice;
            itemToUpdate.NetValue = transLine.NetValue;
            itemToUpdate.DiscountValue = transLine.DiscountValue;
            itemToUpdate.DiscountPercent = transLine.DiscountPercent;
            itemToUpdate.TotalValue= transLine.TotalValue;
            itemToUpdate.TransactionID = transLine.TransactionID;
            itemToUpdate.ItemID = transLine.ItemID;
            _transLineRepo.Update(transLine.TransactionLineID, itemToUpdate);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) {
            var itemToDelete = _transLineRepo.GetByID(id);

            if (itemToDelete == null) {
                return NotFound();
            }

            _transLineRepo.Delete(id);

            return Ok();
        }

    }
}
