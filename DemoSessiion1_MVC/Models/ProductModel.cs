namespace DemoSessiion1_MVC.Models
{
    public class ProductModel
    {
        private List<Product> products;

        public ProductModel()
        {
            products = new List<Product>
            {
                new Product
                    {
                        Id = 1,
                        Name = "Name 1",
                        Photo = "thumb1.gif",
                        Price = 4.5,
                        Quantity = 2,
                        Created = DateTime.Now
                    },
                new Product
                    {
                        Id = 2,
                        Name = "Name 2",
                        Photo = "thumb2.gif",
                        Price = 6.7,
                        Quantity = 3,
                        Created = DateTime.Now
                    },
                new Product
                    {
                        Id = 3,
                        Name = "Name 3",
                        Photo = "thumb3.gif",
                        Price = 3.4,
                        Quantity = 7,
                        Created = DateTime.Now
                    }
            };
        }

    }
}
