//Google.Protobuf Grpc.Net.Client Grpc.tools nuget packages 
using Grpc.Net.Client;
using grpcServer;
using grpcMessageClient;

var channel = GrpcChannel.ForAddress("http://localhost:5206");//grpc service
// var greetClient = new Greeter.GreeterClient(channel);

// //request
// HelloReply result =  await greetClient.SayHelloAsync(new HelloRequest{

// Name = "Bu bir Request Orneğidir."
// });
// System.Console.WriteLine(result.Message);

var messageClient = new MessageService.MessageServiceClient(channel);

MessageResponse response =  await messageClient.SendMessageAsync(new MessageRequest
{

    Message = "Merhaba",
    Name = "Serkan"
});
System.Console.WriteLine(response.Message);

