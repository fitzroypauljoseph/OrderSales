namespace Kidly.Interview.Web.Models.Product
{
    public class ProductService
    {
        public Product LoadProduct(string sku)
        {
            if (sku == "KD01")
                return new Product()
                {
                    Sku = "KD01",
                    ProductName = "Pink Telephone",
                    ImagePath = "/Images/KD01.jpg"
                };

            if (sku == "KD02")
                return new Product()
                {
                    Sku = "KD02",
                    ProductName = "Red Top",
                    ImagePath = "/Images/KD02.jpg"
                };

            return new Product()
            {
                Sku = "KD03",
                ProductName = "Wooden Rainbow",
                ImagePath = "/Images/KD03.jpg"
            };

        }
    }
}