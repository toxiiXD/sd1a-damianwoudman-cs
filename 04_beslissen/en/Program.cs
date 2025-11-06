namespace en;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("- answer in caps");
        Console.WriteLine("- is the door closed? Y/N");
        bool doorNeedsKey = Console.ReadLine() == "Y";
        if (doorNeedsKey == true)
        {
            Console.WriteLine("- do u have the key? Y/N");
            bool hasKey = Console.ReadLine() == "Y";
            if (hasKey == true)
            {
                Console.WriteLine("- u use the key to open the door.");
            }
            else
            {
                Console.WriteLine("- u dont have a key.");
                Console.WriteLine("- the door stays closed.");
            }
        }
        else
        {
            Console.WriteLine("- u open the door.");
        }
     
    }
}
