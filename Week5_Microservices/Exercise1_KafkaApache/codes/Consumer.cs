using System;
using Confluent.Kafka;

public static class Consumer
{
    public static void ConsumeMessages()
    {
        var config = new ConsumerConfig
        {
            BootstrapServers = "localhost:9092",
            GroupId = "chat-consumer-group",
            AutoOffsetReset = AutoOffsetReset.Earliest
        };

        using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();
        consumer.Subscribe("chat-topic");

        Console.WriteLine("Listening for messages (press Ctrl+C to exit)...");

        try
        {
            while (true)
            {
                var message = consumer.Consume();
                Console.WriteLine($"Received: {message.Message.Value}");
            }
        }
        catch (OperationCanceledException)
        {
            consumer.Close();
        }
    }
}
