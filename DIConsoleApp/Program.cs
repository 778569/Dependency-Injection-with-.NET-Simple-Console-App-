using DIConsoleApp;
using Microsoft.Extensions.DependencyInjection;

internal class Program
{
    private static void Main(string[] args)
    {
        //RandomGuidGenerator generator = new RandomGuidGenerator();
        //var newGuid = generator.Generate;
        //Console.WriteLine(newGuid);

        var serviceCollection = new ServiceCollection();

        serviceCollection.AddTransient<RandomGuidGenerator>();


        var provider = serviceCollection.BuildServiceProvider();

        var object1 = provider.GetService<RandomGuidGenerator>();
        var object2 = provider.GetService<RandomGuidGenerator>();

        Console.WriteLine($"Random 1 - {object1.Generate}");
        Console.WriteLine($"Random 1 - {object2.Generate}");

    }
}