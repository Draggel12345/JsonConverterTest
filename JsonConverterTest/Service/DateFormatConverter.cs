using Newtonsoft.Json.Converters;

namespace JsonConverterTest.Service
{
    class DateFormatConverter : IsoDateTimeConverter
    {
        public DateFormatConverter(string format)
        {
            DateTimeFormat = format;
        }
    }
}
