using FuelStation.EF.Repositorys;
using FuelStation.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Session_30.Shared.CustomerDto;
using Session_30.Shared.ItemDto;
using Session_30.Shared.Validator;

namespace Session_30.Server.Controllers
{
    [Route("[controller]")]
[ApiController]
public class ItemController : ControllerBase {

        private readonly IEntityRepo<Item> _itemRepo;
        private readonly IValidator _validator;
        private string? _errorMessage;

        public ItemController(IEntityRepo<Item> itemrepo,IValidator validator) {
            _itemRepo= itemrepo;
            _validator= validator;
            _errorMessage= string.Empty;
        }

        [HttpGet]
        public async Task<IEnumerable<ItemListDto>> Get() {
            var result = _itemRepo.GetAll();
            return result.Select(x => new ItemListDto {
                ItemID= x.ItemID,
                Code= x.Code,
                Description= x.Description,
                ItemType= x.ItemType,
                Cost= x.Cost,
                Price= x.Price                
            });
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<ItemEditDto>> GetById(int id) {
            var result = _itemRepo.GetByID(id);

            if (result == null) {
                return NotFound(); 
            }

            var itemDto = new ItemEditDto {
                ItemID = result.ItemID,
                Code = result.Code,
                Description = result.Description,
                Price = result.Price,
                Cost = result.Cost,
                ItemType = result.ItemType
            };

            return itemDto;
        }


        public async Task<IActionResult> Post(ItemEditDto item) {

            var items = _itemRepo.GetAll().ToList();

            if (_validator.ValidateAddItem(items, item, out _errorMessage)) {
                var newItem = new Item(item.Code, item.Description, item.ItemType, item.Cost, item.Price);
                _itemRepo.Add(newItem);
                return Ok();
            }
            else {
                return BadRequest(_errorMessage);
            }
        }




        [HttpPut]
        public async Task<IActionResult> Put(ItemEditDto item)
        {

            var items = _itemRepo.GetAll().ToList();
            var itemToUpdate = _itemRepo.GetByID(item.ItemID);
           
            if (itemToUpdate == null)
            {
                return NotFound();
            }
            try
            {
                if (_validator.ValidateUpdateItem(items, itemToUpdate, item, out _errorMessage))
                {
                    itemToUpdate.Code = item.Code;
                    itemToUpdate.Description = item.Description;
                    itemToUpdate.ItemType = item.ItemType;
                    itemToUpdate.Cost = item.Cost;
                    itemToUpdate.Price = item.Price;
                    _itemRepo.Update(item.ItemID, itemToUpdate);

                    return Ok();
                }
                else
                {
                    return BadRequest(_errorMessage);
                }
            }catch(Exception ex)
            {
                return BadRequest($"You cannot update the code of this item because it has associated Transactions!");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) {
            var itemToDelete = _itemRepo.GetByID(id);

            if (itemToDelete == null) {
                return NotFound(); 
            }
            if (_validator.ValidateDeleteItem(itemToDelete, out _errorMessage))
            {
                _itemRepo.Delete(id);
                return Ok();
            }
            else
            {
                return BadRequest(_errorMessage);
            }          

        }
    }
}
