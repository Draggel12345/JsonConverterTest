using Newtonsoft.Json;
using System;

namespace JsonConverterTest.Service
{
    class JsonService : IJsonService
    {
        public string Serializing(object o)
        {
            try
            {
                string output = JsonConvert.SerializeObject(o);
                return output;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public Object Deserializing<Object>(string str)
        {
            try
            {
                Object output = JsonConvert.DeserializeObject<Object>(str);
                return output;
            }
            catch
            {
                throw new NullReferenceException();
            }

        }
    }
}
