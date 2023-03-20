namespace BuilderPractise.Services.StatusMessages;

public record StatusMessagesRequest
{
    public string Gcid { get; set; }
    public string UserAgent { get; set; }

    public string? Others { get; set; }
    public string Tags { get; set; }    
}