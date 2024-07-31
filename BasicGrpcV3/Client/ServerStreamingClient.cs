using Grpc.Core;
using Grpc.Net.Client;

namespace Client;

internal class ServerStreamingClient
{
    public async Task GetRandomNumbers()
    {
        using var channel = GrpcChannel.ForAddress("http://localhost:5013");
        var client = new RandomNumbers.RandomNumbersClient(channel);
        var reply = client.GetRandomNumbers(new GetRandomNumbersRequest
        {
            Count = 100,
            Max = 100,
            Min = 1
        });
        await foreach (var number in reply.ResponseStream.ReadAllAsync()) Console.WriteLine(number.Number);
        Console.ReadKey();
    }
}