using GreetLibrary;
using Grpc.Net.Client;
using static GreetLibrary.Greeter;

// The port number must match the port of the gRPC server.
using var channel = GrpcChannel.ForAddress("https://localhost:7042");
var client = new GreeterClient(channel);
var reply = await client.SayHelloAsync(
                  new HelloRequest { Name = "GreeterClient" });
Console.WriteLine($"Greeting: {reply.Message}, Number: {reply.Number}");
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
