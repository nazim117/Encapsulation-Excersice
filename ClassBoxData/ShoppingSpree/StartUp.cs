/*
Peter=11;George=4
Bread=10;Milk=2;
Peter Bread
George Milk
George Milk
Peter Milk
END

Maria=0
Coffee=2
Maria Coffee
END

John=-3
Peppers=1;Tomatoes=2;Cheese=3
John Peppers
John Tomatoes
John Cheese
END
*/

using ShoppingSpree.Models;

namespace ShoppingSpree
{
    public class StartUp
    {
        public static void Main()
        {
            List<Person> people;
            List<Product> products;

            string[] inputPeople;
            string[] inputProducts;
			try
			{
                people = new List<Person>();
                products = new List<Product>();

                inputPeople = Console.ReadLine().Split(';',StringSplitOptions.RemoveEmptyEntries);
                inputProducts= Console.ReadLine().Split(';',StringSplitOptions.RemoveEmptyEntries);

                foreach (var personInfo in inputPeople)
                {
                    var personData = personInfo.Split('=');
                    string name = personData[0];
                    decimal money = decimal.Parse(personData[1]);

                    people.Add(new Person(name,money));
                }
                foreach (var productInfo in inputProducts)
                {
                    var productData = productInfo.Split('=');
                    string name = productData[0];
                    decimal cost = decimal.Parse(productData[1]);

                    products.Add(new Product(name,cost));
                }

                string command;
                while ((command = Console.ReadLine()) != "END")
                {
                    var purchaseData = command.Split();
                    string personName = purchaseData[0];
                    string productName = purchaseData[1];

                    Person person = people.First(p=>p.Name == personName);
                    Product product = products.First(p=>p.Name == productName);

                    if (person.BuyProduct(product))
                    {
                        Console.WriteLine($"{personName} bought {productName}");
                    }
                    else
                    {
                        Console.WriteLine($"{personName} can't afford { productName}");
                    }
                    
                }

                foreach (var person in people)
                {
                    Console.WriteLine(person);
                }
			}
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
            }
        }
    }
}