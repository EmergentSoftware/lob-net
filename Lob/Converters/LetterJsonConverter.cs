using Lob.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lob.Converters
{
    public class LetterJsonConverter : JsonConverter
    {
        private readonly Type[] Types;

        public LetterJsonConverter(params Type[] types)
        {
            Types = types;
        }

        public override bool CanConvert(Type objectType)
        {
            return Types.Any(t => t == objectType);
        }

        public override bool CanRead
        {
            get { return false; }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            Letter letter = (Letter)value;

            PropertyInfo[] props = typeof(Letter).GetProperties();

            JObject jObject = new JObject();

            foreach (PropertyInfo prop in letter.GetType().GetProperties().ToList())
            {
                var val = prop.GetValue(letter);

                var type = val.GetType();

                var check = val.GetType().IsSubclassOf(typeof(Data.Data));

                if(val != null)
                {
                    jObject[val] = new JValue((prop.GetCustomAttributes(true).First() as JsonPropertyAttribute).PropertyName);
                }

                var key = (prop.GetCustomAttributes(true).First() as JsonPropertyAttribute).PropertyName;
            }

            jObject.WriteTo(writer);
        }
    }
}
