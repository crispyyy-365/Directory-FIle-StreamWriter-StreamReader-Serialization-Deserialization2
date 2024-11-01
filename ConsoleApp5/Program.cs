using Newtonsoft.Json;
using System.Dynamic;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Path.GetFullPath(Path.Combine("..", "..", "..", "Data", "customer.json"));
            Customer customer1 = new Customer(213443, "Abbasov", "Huseyn", "051-978-32-69");
            Customer customer2 = new Customer(542513, "Abbasov", "Huseyn", "051-978-32-69");
            Customer customer3 = new Customer(234234, "Abbasov", "Huseyn", "051-978-32-69");
            Customer customer4 = new Customer(746464, "Abbasov", "Huseyn", "051-978-32-69");
            Customer customer5 = new Customer(231244, "Abbasov", "Huseyn", "051-978-32-69");

            List<Customer> customers = new List<Customer> { customer1, customer2, customer3, customer4, customer5 }; 
            Add(customer5, path, customers);
            //CustomerSearch(213443, path, customers);
            GetAll(path);

        }
        static void Add(Customer customer, string path, List<Customer> customers)
        {
            customers.Add(customer);
            string json = JsonConvert.SerializeObject(customers);

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(json);
            }
        }
        static bool CustomerSearch(int id, string path, List<Customer> customers)
        {
            List<Customer> customers1 = JsonConvert.DeserializeObject<List<Customer>>(path);

            if (customers1.Contains(customers.Find(x => x.ID == id)))
            {
                return true;
            }
            return false;
        }
        static void Update(int id, string newFirstName, string newLastName, string newPhoneNumber)
        {

        }
        static void DeleteCustomer(int id, string path, List<Customer> customers)
        {
            customers.Remove(customers.Find(x=>x.ID == id));
            string json = JsonConvert.SerializeObject(customers);

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(json);
            }
        }
        static void GetAll(string path)
        {
            List<Customer> customers1 = JsonConvert.DeserializeObject<List<Customer>>(path);

            for (int i = 0; i < customers1.Count; i++)
            {
                Console.WriteLine($"ID : {customers1[i].ID}, Name : {customers1[i].FirstName}, Surname : {customers1[i].LastName}, Number : {customers1[i].PhoneNumber}");
            }
        }
    }
}