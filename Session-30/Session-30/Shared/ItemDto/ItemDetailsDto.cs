using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_30.Shared.ItemDto
{
    public class ItemDetailsDto {

        public int ItemID { get; set; }

        public string? Code { get; set; }

        public string? Description { get; set; }
        public ItemType ItemType { get; set; }

        public decimal Cost { get; set; }
        public decimal Price { get; set; }

        public List<TransactionLine> TransactionLines { get; set; }=new List<TransactionLine>();
    }
}
