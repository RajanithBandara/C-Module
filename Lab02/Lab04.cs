public class Product
{
    public static string Pro_Name;
    public static int Price;

    public Product(string product_name, int price)
    {
        Pro_Name = product_name;
        Price = price;
    }
    public static void display()
    {
        Console.WriteLine(Pro_Name);
        Console.WriteLine(Price);
    }
}

public class Record
{
    private static int x = 0;
    public static void record_product(string pro_name, int price)
    {
        Console.WriteLine("Enter the Product Name : ");
        Console.WriteLine("To abort the process press 'x' : ");
        pro_name = Console.ReadLine();
        if (pro_name == "x")
        {
            Product[] products = new Product[x];
            for (int x = 0; x < products.Length; x++)
            {
                products[x] = new Product(pro_name, x);
                
            }
            Environment.Exit(0);
        }
        Console.WriteLine("Enter the Price of the relevant Product : ");
        price = int.Parse(Console.ReadLine());
        x = x + 1;
        record_product(pro_name,price);
    }
}

class programe
{
    static void Main(string[] args)
    {
        string productname = "";
        int price = 0;
        Record.record_product(productname, price);
    }
}