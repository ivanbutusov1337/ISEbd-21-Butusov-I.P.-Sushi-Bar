﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractSushiBarContracts.BindingModels
{
    public class CreateOrderBindingModel
    {
        public int ProductId { get; set; }
        public int Count { get; set; }
        public decimal Sum { get; set; }
    }
}
