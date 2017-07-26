using Lob.Actions;

namespace Lob
{
    public class Lob
    {
        public Retrieve Retrieve { get; set; }
        public Create Create { get; set; }
        public Verify Verify { get; set; }

        public Lob(string apiKey)
        {
            Retrieve = new Retrieve(apiKey);
            Create = new Create(apiKey);
            Verify = new Verify(apiKey);
        }
    }
}
