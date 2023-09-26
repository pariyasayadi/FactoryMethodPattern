namespace FactoryMethodPattern.Products
{
    public abstract class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public abstract string GetProductType();
    }

    public class Laptop : Product
    {
        public override string GetProductType()
        {
            return "Laptop";
        }
    }

    public class Smartphone : Product
    {
        public override string GetProductType()
        {
            return "Smartphone";
        }
    }

}
