using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazilimGelistiriciKampi_Gun2
{
    public class IndividualCustomer : BaseCustomer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalIdentity { get; set; }
    }
    public class CorporateCustomer : BaseCustomer
    {
        public string Name { get; set; }
        public string TaxNumber { get; set; }
    }
    public class BaseCustomer
    {
        public int Id { get; set; }
        public string CustomerNumber { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.NationalIdentity = "1545251265";
            customer1.FirstName = "Aslı";
            customer1.LastName = "Karayiğit";
            customer1.CustomerNumber = "12354";
            IndividualCustomer customer2 = new IndividualCustomer();
            customer2.Id = 2;
            customer2.NationalIdentity = "154525145";
            customer2.FirstName = "Özgür";
            customer2.LastName = "Atılgan";
            customer2.CustomerNumber = "1235414";
            CorporateCustomer customer3 = new CorporateCustomer();
            customer3.Id = 3;
            customer3.Name = "Kodlama";
            customer3.CustomerNumber = "532215";
            customer3.TaxNumber = "5456842";
            CorporateCustomer customer4 = new CorporateCustomer();
            customer4.Id = 4;
            customer4.Name = "Abcd";
            customer4.CustomerNumber = "5356";
            customer4.TaxNumber = "558";

            BaseCustomer[] customers = {customer1, customer2,customer3,customer4};
            foreach (BaseCustomer customer in customers)
            {
                Console.WriteLine(customer.CustomerNumber);
            }

            /*
            int number1 = 10;
            int number2 = 20;
            number1= number2;
            number2 = 50;
            Console.WriteLine(number1);

            string[] cities1 = { "Ankara", "İstanbul", "İzmir" };
            string[] cities2 = { "Bursa", "Bolu", "Diyarbakir" };
            cities2 = cities1;
            cities1[0] = "Adana";
            Console.WriteLine(cities2[0]);
            */

            Console.ReadKey();

        }
    }
}
