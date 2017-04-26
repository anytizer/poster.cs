using Newtonsoft.Json;
using System;
/**
 * @see https://msdn.microsoft.com/en-us/library/aa288454(v=vs.71).aspx
 */
namespace business
{
    public class DataContractAttribute : Attribute
    {
        public string serialize(object data)
        {
            string json = JsonConvert.SerializeObject(data);
            return json;
        }

        public string deserialize()
        {
            return "";
        }
    }
}
