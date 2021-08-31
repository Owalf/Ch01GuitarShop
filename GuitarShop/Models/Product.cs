namespace GuitarShop.Models
{

    //Model class for the product
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Slug => Name.Replace(' ', '-');
    }
}