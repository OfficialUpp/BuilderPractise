using BuilderPractise.Services.StatusMessages;

namespace BuilderPractise.Builders.StatusMessages;

public class StatusMessagesBuilder
{
    private StatusMessagesRequest _statusMessagesRequest;

        public StatusMessagesBuilder()
        {
            _statusMessagesRequest = new StatusMessagesRequest();
        }

        public StatusMessagesBuilder BuildGcid(string gcid)
        {
            _statusMessagesRequest.Gcid = gcid;
            return this;
        }
        
        public StatusMessagesBuilder BuildBrand(string userAgent)
        {
            //var userAgentObject = request.UserAgent.ToUserAgentObject();
            //app brand
            //group id
            //container id
            _statusMessagesRequest.UserAgent = userAgent;
            return this;
        }

        public StatusMessagesBuilder BuildDate(string? beforeDate)
        {
            //afterdate
            //beforeDate
            _statusMessagesRequest.Others = beforeDate;
            return this;
        }

        public StatusMessagesBuilder BuildTags(string tags)
        {
            //SanitizeStatusMessagesTags()
            _statusMessagesRequest.Tags = tags;
            return this;
        }

        public StatusMessagesRequest Build() => _statusMessagesRequest;
}
