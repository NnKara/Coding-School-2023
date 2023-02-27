﻿using FuelStation.Model;
using Session_30.Shared.TransactionDto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_30.Shared.CustomerDto
{
    public class CustomerDetailsDto {

        public int CustomerID { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [MaxLength(15, ErrorMessage = "Maximum 15 characters")]
        [RegularExpression(@"^[a-zA-ZΑ-Ωα-ω\u0386-\u03CE\s]+$", ErrorMessage = "Name can only contain letters")]
        public string? CustomerName { get; set; }

        [Required(ErrorMessage = "Surname is required.")]
        [MaxLength(15, ErrorMessage = "Maximum 15 characters")]
        [RegularExpression(@"^[a-zA-ZΑ-Ωα-ω\u0386-\u03CE\s]+$", ErrorMessage = "Surname can only contain letters")]
        public string? CustomerSurname { get; set; }


        [RegularExpression("^A.{0,}$", ErrorMessage = "CardNumber should start with 'A'.")]
        public string? CardNumber { get; set; }

        public List<TransactionDetailsDto> Transactions { get; set; } = new List<TransactionDetailsDto>();

        
    }
}
