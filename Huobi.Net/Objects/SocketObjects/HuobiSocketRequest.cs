using Newtonsoft.Json;

namespace Huobi.Net.Objects.SocketObjects
{
    public class HuobiRequest
    {
        [JsonIgnore]
        public string? Id { get; set; }
    }

    public class HuobiSocketRequest: HuobiRequest
    {
        [JsonProperty("req")]
        public string Request { get; set; }

        [JsonProperty("id")]
        public new string Id { get; set; }


        public HuobiSocketRequest(string id, string topic)
        {
            Id = id;
            Request = topic;
        }
    }

    public class HuobiAuthenticatedSubscribeRequest
    {
        [JsonProperty("action")]
        public string Action { get; set; }
        [JsonProperty("ch")]
        public string Channel { get; set; }

        public HuobiAuthenticatedSubscribeRequest(string channel, string action = "sub")
        {
            Action = action;
            Channel = channel;
        }
    }

    public class HuobiSubscribeRequest: HuobiRequest
    {
        [JsonProperty("sub")]
        public string Topic { get; set; }
        [JsonProperty("id")]
        public new string Id { get; set; }

        public HuobiSubscribeRequest(string id, string topic)
        {
            Id = id;
            Topic = topic;
        }
    }
}
