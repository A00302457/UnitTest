// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FeatureManagement;
var features = new Dictionary<string, string> {{"premium", "true"}};
IConfigurationRoot config = new ConfigurationBuilder().AddInMemoryCollection(features).Build();

IServiceCollection services = new ServiceCollection();

services.AddFeatureManagement(config);

IServiceProvider serviceProvider = services.BuildServiceProvider();

IFeatureManager featManager = serviceProvider.GetRequiredService<IFeatureManager>();


if(await featManager.IsEnabledAsync("Premium"))
{
    Console.WriteLine("Welcome to Calculator");
}
else
{
    Console.WriteLine("Welcome to Calculator");
}

Console.WriteLine("Choose your Function");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Substarction");
if(await featManager.IsEnabledAsync("Premium"))
{
    Console.WriteLine("3. multiplication");
    Console.WriteLine("4. Division");
}
var num = Console.ReadLine();
switch (num)
{
    case "1":
    Console.WriteLine("Do Addition");
    break;

    case "2":
    Console.WriteLine("DoSubstarction");
    break;

    case "3":
    if(await featManager.IsEnabledAsync("Premium"))
    {
        Console.WriteLine("Do Multiplication");
    }
    else{
        Console.WriteLine("wrong choice");
    }
    break;

    case "4":
    if(await featManager.IsEnabledAsync("Premium"))
    {
        Console.WriteLine("Do Division");
    }
     else{
        Console.WriteLine("wrong choice");
    }
    
    break;
    default:
     
        Console.WriteLine("wrong choice");
        break;
   
}


