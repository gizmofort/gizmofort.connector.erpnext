using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GizmoFort.Connector.ERPNext.Serialization
{
    public class ERPNextObjectBaseDateTimeConverter : JsonConverter<DateTime>
    {
        public ERPNextObjectBaseDateTimeConverter() { }

        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            //
            // functions that must be supported:
            //
            // mariadb datetime export format when server timezone is "Etc/UTC"
            // "2022-09-12 14:46:12.845619" -> "2022-09-12T14:46:12.8456190Z"
            //

            var datetimeString = reader.GetString();
            if (datetimeString is null)
                throw new InvalidOperationException("value cannot be null.");

            //
            // the following assumes the conversion is taking place on a machine with tz = "Etc\UTC"
            //
            var culture = CultureInfo.CreateSpecificCulture("en-US");
            var styles = DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal;
            return DateTime.Parse(datetimeString, culture, styles);
        }

        public override void Write(Utf8JsonWriter writer, DateTime date, JsonSerializerOptions options)
        {
            //
            // ISO-8601 date format string when serializeing
            //
            writer.WriteStringValue(date.ToUniversalTime().ToString("o").Replace("+00:00", "Z"));
        }
    }
}
