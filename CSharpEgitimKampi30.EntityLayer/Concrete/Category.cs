using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi30.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoriName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; } // <List> Yaptık Çunku üründen birden fazla var // Aynı zamanda diger ürünlere ulasmak için


    }
}
