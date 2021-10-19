using System;

namespace JsonConverterTest.Models
{
    class Product
    {
        private static int idCounter = 0;
        public int Id { get; set; }
        public string ProductName { get; set; }
        public DateTime ExpiryDate { get; set; }
        public decimal Price { get; set; }
        public Product(string name, DateTime expier, decimal price) => (Id, ProductName, ExpiryDate, Price) = (++idCounter, name, expier, price);
        public override string ToString()
        {
            return (char)123 + $"\"Id\":{Id},\"ProductName\":\"{ProductName}\",\"ExpiryDate\":\"{ExpiryDate.ToShortDateString()}\",\"Price\":{Price}" + (char)125;
        }
    }
}
