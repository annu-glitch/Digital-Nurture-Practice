using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Select mode: 1 = Producer, 2 = Consumer");
        var choice = Console.ReadLine();

        if (choice == "1")
            await Producer.ProduceMessages();
        else if (choice == "2")
            Consumer.ConsumeMessages();
        else
            Console.WriteLine("Invalid choice.");
    }
}
