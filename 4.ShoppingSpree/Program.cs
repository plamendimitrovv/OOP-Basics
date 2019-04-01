using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>();
        List<Product> products = new List<Product>();

        string[] allPeople = Console.ReadLine().Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < allPeople.Length; i++)
        {
            string[] personInfo = allPeople[i].Split(new[] { "=" }, StringSplitOptions.RemoveEmptyEntries);
            var personName = personInfo[0];
            var personMoney = decimal.Parse(personInfo[1]);
            Person person = new Person(personName, personMoney);
            people.Add(person);
        }

        string[] allproducts = Console.ReadLine().Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < allproducts.Length; i++)
        {
            string[] productInfo = allproducts[i].Split(new[] { "=" }, StringSplitOptions.RemoveEmptyEntries);
            var productName = productInfo[0];
            var productCost = decimal.Parse(productInfo[1]);
            Product product = new Product(productName, productCost);
            products.Add(product);
        }

        string purchaseInfo = Console.ReadLine();

        while (purchaseInfo != "END")
        {
            string[] purchase = purchaseInfo.Split();
            string personName = purchase[0];
            string productName = purchase[1];

            Person currentPerson = people.FirstOrDefault(p => p.Name == personName);
            Product currentProduct = products.FirstOrDefault(pr => pr.Name == productName);

            if (currentPerson.Money < currentProduct.Cost)
            {
                Console.WriteLine($"{personName} can't afford {productName}");
            }
            else
            {
                currentPerson.Money -= currentProduct.Cost;

                foreach (var person in people.Where(p => p.Name == personName))
                {
                    person.Money = currentPerson.Money;
                    person.BagOfProducts.Add(currentProduct);
                }

                Console.WriteLine($"{personName} bought {productName}");
            }


            purchaseInfo = Console.ReadLine();
        }

        foreach (var per in people)
        {
            per.Print();
        }

    }
}

