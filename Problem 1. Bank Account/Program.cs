using System;


    class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount();

            acc.Id = 1;
            acc.Balance = 15;

          var toString = acc.ToString();
        
    Console.WriteLine(toString);

        }
    }

 