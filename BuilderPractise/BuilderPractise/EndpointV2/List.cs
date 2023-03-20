using BuilderPractise.Builders.StatusMessages;
using BuilderPractise.EndpointRequests.StatusMessages;
using BuilderPractise.Services.StatusMessages;

namespace BuilderPractise.EndpointV2;

public class List
{
    private static ListRequests _request; //so para nao escrever o request na totalidade
    
    StatusMessagesRequest statusMessagesRequests = new StatusMessagesBuilder()
        .BuildGcid(_request.Gcid)
        .BuildBrand(_request.UserAgent)
        .BuildDate(_request.BeforeDate)
        .Build();
    
    //chamar listV2Async(statusMessagesRequest);
}