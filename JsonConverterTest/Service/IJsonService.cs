using System;

namespace JsonConverterTest.Service
{
    interface IJsonService
    {
        string Serializing(Object o);
        Object Deserializing<Object>(String str);
    }
}
