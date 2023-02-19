using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Session_30.Shared.CustomerDto
{
    public class CustomerListDto {

        public int CustomerID { get; set; }
        public string? CustomerName { get; set; }

        public string? CustomerSurname { get; set; }


        public string? CardNumber { get; set; }

        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}
