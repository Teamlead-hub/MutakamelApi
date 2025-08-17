using System.Text.Json.Serialization;
using System.Text.Json;

namespace CleanBase.Entities
{
    // DateOnly Converter
    public class DateOnlyJsonConverter : JsonConverter<DateOnly>
    {
        public override DateOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String && reader.TryGetDateTime(out DateTime dateTime))
            {
                return DateOnly.FromDateTime(dateTime);
            }

            throw new JsonException("Invalid date format.");
        }

        public override void Write(Utf8JsonWriter writer, DateOnly value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString("yyyy-MM-dd")); // Customize format as needed
        }
    }

    // TimeOnly Converter
    public class TimeOnlyJsonConverter : JsonConverter<TimeOnly>
    {
        public override TimeOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String && reader.TryGetDateTime(out DateTime dateTime))
            {
                return TimeOnly.FromDateTime(dateTime);
            }

            throw new JsonException("Invalid time format.");
        }

        public override void Write(Utf8JsonWriter writer, TimeOnly value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString("HH:mm:ss")); // Customize format as needed
        }
    }

}