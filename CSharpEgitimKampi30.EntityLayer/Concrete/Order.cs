using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi30.EntityLayer.Concrete
{
    public class Order
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; } //Hangi Ürünü sattıgımı bilmeliyim
        public virtual Product Product {  get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; } // Ürünün 1 tanesi Kaç para
        public decimal TotalPrice { get; set; }
        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; } //Müşterinin Diger bilgilerine ulasmak için

    }
}
