namespace Bevasarlas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer(["sausage", "winrar", "sausage", "computer"]);
            Store store = new Store();
            Console.WriteLine(cust);
            Console.WriteLine(store);
            cust.GoShopping(store);
            Console.WriteLine(cust);
            Console.WriteLine(store);
                
        }
    }
}
