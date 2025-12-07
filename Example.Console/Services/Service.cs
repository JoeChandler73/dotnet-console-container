using Microsoft.Extensions.Logging;

namespace Example.Console.Services;

public class Service(ILogger<Service> logger) : IService
{
    public void Say(string message)
    {
        logger.LogInformation(message);
    }
}