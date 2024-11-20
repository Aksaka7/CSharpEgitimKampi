using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi30.EntityLayer.Concrete
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProdoctStoct { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public virtual Category Category { get; set; } //Context.Product.Category.CategoryName  => Yani Ürünler sayfasında Categori taplosuna git . CategoryName mi Al.
        public int CategoryId { get; set; }


    }
}
