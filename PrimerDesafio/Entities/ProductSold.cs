using System;
namespace PrimerDesafio.Entities
{
    public class ProductSold
    {

        public int Id { get; set; }
        public int IdProduct { get; set; }
        public int Stock { get; set; }
        public int IdSale { get; set; }
            

        public ProductSold() { }
    }
}

