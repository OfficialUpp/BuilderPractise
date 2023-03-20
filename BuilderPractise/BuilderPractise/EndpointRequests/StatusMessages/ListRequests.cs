namespace BuilderPractise.EndpointRequests.StatusMessages;

public class ListRequests
{
    public string Gcid { get; set; }
    public string UserAgent { get; set; }
    public string BeforeDate { get; init; }
    public string Tags { get; init; }
}