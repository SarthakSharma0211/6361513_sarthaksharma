using Confluent.Kafka;
using System;
using System.Threading.Tasks;

class Program
{
    public static async Task Main(string[] args)
    {
        var config = new ProducerConfig { BootstrapServers = "localhost:9092" };
        using var producer = new ProducerBuilder<Null, string>(config).Build();

        Console.WriteLine("Type your message (type 'exit' to quit):");

        string? text;
        while ((text = Console.ReadLine()) != "exit")
        {
            await producer.ProduceAsync("chat-topic", new Message<Null, string> { Value = text });
            Console.WriteLine($"Sent: {text}");
        }
    }
}
