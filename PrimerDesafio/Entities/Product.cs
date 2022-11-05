using System;
namespace PrimerDesafio.Entities
{
    public class Product
    {

        public int? Id { get; set; }
        public string? Description { get; set; }
        public double? Price { get; set; }
        public double? SalePrice { get; set; }
        public int? Stock { get; set; }
        public int? IdUser { get; set; }


        public Product() {}
    }
}

