using FactoryMethodPattern.Products;

namespace FactoryMethodPattern.Factory
{
    public class ProductFactory
    {
        public Product CreateProduct(string productType)
        {
            switch (productType.ToLower())
            {
                case "laptop":
                    return new Laptop();
                case "smartphone":
                    return new Smartphone();
                default:
                    throw new ArgumentException("Invalid product type");
            }
        }
    }
}
