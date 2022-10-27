using Grpc.Core;
using GreetLibrary;

namespace GrpcGreeter.Services;

public class GreeterService : Greeter.GreeterBase
{
    private readonly ILogger<GreeterService> _logger;
    private static int counter = 0;
    public GreeterService(ILogger<GreeterService> logger)
    {
        _logger = logger;
    }

    public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
    {
        _logger.LogInformation("Message received!");
        return Task.FromResult(new HelloReply
        {
            Message = "Hello " + request.Name
        });
    }
}

