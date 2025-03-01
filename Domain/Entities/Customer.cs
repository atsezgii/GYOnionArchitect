﻿using Domain.Entities.Common;

namespace Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Order> Orders { get; set; } //Bir müşterinin birden fazla siparişi olabilir
    }
}
