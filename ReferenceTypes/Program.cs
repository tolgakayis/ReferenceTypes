using System;

namespace ReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //raw value type stack
            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2;

            sayi2 = 100;

            Console.WriteLine("Sayı1 : " + sayi1);

            //reference type heap
            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar1 = sayilar2;
            sayilar2[0] = 1000;

            Console.WriteLine("Sayilar1[0]: " + sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Tolga";
            person2 = person1;
            person1.FirstName = "Engin";

            Console.WriteLine("Person2 FN : " + person2.FirstName);

            Customer customer = new Customer();
            Employee employee = new Employee();
            customer.FirstName = "Ahmet";
            customer.CreditCardNumber = "1231213";

            Person person3 = customer;
            Console.WriteLine("person3 fn: " + ((Customer)person3).FirstName);
            Console.WriteLine("person3 fn: " + ((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(customer);
        }
    }
    class Person //base class
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    class Customer: Person //child class
    {
        public string CreditCardNumber { get; set; }
    }
    class Employee : Person //child class
    {
        public int EmployeeNumber { get; set; }
    }
    class PersonManager 
    {
        public void Add(Person person) //base class verildiği için diğer classlara girebiliyorum.
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
