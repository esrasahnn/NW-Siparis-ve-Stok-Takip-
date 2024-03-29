﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFBasics
{
   public class OrderDetailViewModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public short Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }

        public decimal TotalAmount
        {
            get
            {
                return UnitPrice * Quantity * (1 - Discount);
            }
        }
    }
}
