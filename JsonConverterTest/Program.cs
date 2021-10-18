using JsonConverterTest.Models;
using static System.Console;
using System;
using JsonConverterTest.Service;

namespace JsonConverterTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();

            ReadKey();
        }

        public static void Run()
        {
            //JsonService have 2 methods. 1 Serailizing(string). 2 Deseralizing<Object>(string).
            JsonService jserv = new();

            //Create two objects from the product-class
            Product one = new("Apple", new DateTime(2021, 12, 8), 15);
            Product two = new("Sallad", new DateTime(2021, 12, 10), 10); 

            //Used for converting object data in to Json text
            string output1 = jserv.Serializing(one);
            string output2 = jserv.Serializing(two);

            //To print out the Json text
            WriteLine($"Serialized : {output1}");
            WriteLine($"Serialized : {output2}\n");

            //Used for converting Json text in to object data
            Product product1 = jserv.Deserializing<Product>(output1);
            Product product2 = jserv.Deserializing<Product>(output2);

            //Using override toString() in product-class
            WriteLine($"Deserialized : {product1}");
            WriteLine($"Deserialized : {product2}");
        }
    }
}
