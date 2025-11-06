namespace als;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("- ur searching for the key.");
        Console.WriteLine("- did u find the key? (Y/N)");
        bool sleutelkwijt = Console.ReadLine() == "N";
        

        if (sleutelkwijt == true)
        {
        
            Console.WriteLine("u didnt find the key.");
            Console.WriteLine("door stays closed.");
        }
        else
        {
            Console.WriteLine("u have found the key");
            Console.WriteLine("door is open");
        }
    //console hier

    }
}
