namespace BasicProject2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductId = 1;
            product1.ProductName = "Telefon";
            product1.ProductColor = "Mavi";

            Product product2 = new Product();
            product2.ProductId = 2;
            product2.ProductName = "Ayakkabı";
            product2.ProductColor = "Beyaz";

            Product product3 = new Product();
            product3.ProductId = 3;
            product3.ProductName = "Bilgisayar";
            product3.ProductColor = "Siyah";


            Product[] products = new Product[] { product1, product2, product3 };

            Console.WriteLine("-------------------For İle Listeleme--------------------------------");

            for (int i = 0; i <products.Length; i++)
            {
                Console.WriteLine(products[i].ProductId + ":" + products[i].ProductName + ":" + products[i].ProductColor);
            }

            Console.WriteLine("-------------------Foreach İle Listeleme----------------------------");

            foreach (var product in products)
            {
                Console.WriteLine(product.ProductId + ":" + product.ProductName + ":" + product.ProductColor );
            }

            Console.WriteLine("-------------------While İle Listeleme------------------------------");
            int j = 0;
            while (j<products.Length)
            {
                Console.WriteLine(products[j].ProductId + ":" + products[j].ProductName + ":" + products[j].ProductColor);
                j++;
            }










        }
    }
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductColor { get; set; }
    }
}