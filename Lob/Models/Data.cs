using Newtonsoft.Json;

namespace Lob.Data
{
    public class Data
    {
        public virtual string Serialize()
        {
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };
            string json = JsonConvert.SerializeObject(this, Formatting.None, settings);
            return json;
        }
    }
}
