using Domain.Entities.Common;

namespace Domain.Entities
{
    public class Order:BaseEntity
    {
        public Guid CustomerId { get; set; }
        public string Description { get; set; }
        public string Address { get; set; } //ValueObject olarak tutulabilir ; Şehir,İlçe,Posta Kodu vs
        public ICollection<Product> Products { get; set; }
        public Customer customer { get; set; }//Bir sipariş bir müşteriye aittir.

    }
}
