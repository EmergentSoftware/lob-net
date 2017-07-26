namespace Lob.Requests
{
    public class PostRequest : Request
    {
        public string Data { get; set; }

        public PostRequest() 
            : base()
        {
            Method = "POST";
        }
    }
}
