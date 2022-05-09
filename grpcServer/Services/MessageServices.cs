using Grpc.Core;
using grpcMessageServer;
using grpcServer;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace grpcServer;


public class MessageServices : MessageService.MessageServiceBase
{

    public override async Task<MessageResponse> SendMessage(MessageRequest request, ServerCallContext context)
    {
        System.Console.WriteLine($" Merhaba : {request.Message} | Name : {request.Name}");

        return   new MessageResponse{
            Message = "Request Alınmıştır."
        };
        
    }
}