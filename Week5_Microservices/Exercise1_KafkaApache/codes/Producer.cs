using System;
using System.Threading.Tasks;
using Confluent.Kafka;

public static class Producer
{
    public static async Task ProduceMessages()
    {
        var config = new ProducerConfig
        {
            BootstrapServers = "localhost:9092"
        };

        using var producer = new ProducerBuilder<Null, string>(config).Build();

        Console.WriteLine("Enter messages to send (type 'exit' to quit):");

        while (true)
        {
            var input = Console.ReadLine();
            if (input.ToLower() == "exit")
                break;

            var result = await producer.ProduceAsync("chat-topic", new Message<Null, string> { Value = input });

            Console.WriteLine($"Message sent to {result.TopicPartitionOffset}");
        }
    }
}
