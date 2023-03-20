using BuilderPractise.Builders.StatusMessages;
using BuilderPractise.EndpointRequests.StatusMessages;
using BuilderPractise.Services.StatusMessages;

namespace BuilderPractise.EndpointV1;

public class List : ListRequests
{
    private static ListRequests _request; //so para nao escrever o request na totalidade
    
    StatusMessagesRequest statusMessagesRequests = new StatusMessagesBuilder()
        .BuildGcid(_request.Gcid)
        .BuildBrand(_request.UserAgent)
        .BuildDate(_request.BeforeDate)
        .Build();
    
    //chamar listAsync(statusMessagesRequest);
}