using GizmoFort.Connector.ERPNext.DataAnnotations;
using System;
using System.Data;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace GizmoFort.Connector.ERPNext.Serialization
{
    public class ERPNextConverter
    {
        public static ColumnInfoAttribute? GetColumnInfoByPropertyName<T>(string propertyName)
        {
            if (string.IsNullOrWhiteSpace(propertyName))
                throw new ArgumentNullException(nameof(propertyName), "'propertyName' cannot be null or empty.");

            var classType = typeof(T);
            var columnInfo = (ColumnInfoAttribute?)classType
                                      .GetProperties(BindingFlags.GetProperty
                                                     | BindingFlags.Instance
                                                     | BindingFlags.Public)
                                      .Where(p => p.Name == propertyName)
                                      .FirstOrDefault()?
                                      .GetCustomAttributes(attributeType: typeof(ColumnInfoAttribute), inherit: false)
                                      .FirstOrDefault();
            return columnInfo;
        }

        public static ColumnInfoAttribute? GetColumnInfoByColumnName<T>(string columnName)
        {
            if (string.IsNullOrWhiteSpace(columnName))
                throw new ArgumentNullException(nameof(columnName), "'columnName' cannot be null or empty.");

            var classType = typeof(T);
            var columnInfo = (ColumnInfoAttribute?)classType
                                      .GetProperties(BindingFlags.GetProperty
                                                     | BindingFlags.Instance
                                                     | BindingFlags.Public)
                                      .SelectMany(pi => pi.GetCustomAttributes(attributeType: typeof(ColumnInfoAttribute), inherit: false))
                                      .Where(ci => ((ColumnInfoAttribute)ci).ColumnName == columnName)
                                      .FirstOrDefault();
            return columnInfo;
        }
        public static PropertyInfo? GetPropertyInfoByPropertyName<T>(string propertyName)
        {
            if (string.IsNullOrWhiteSpace(propertyName))
                throw new ArgumentNullException(nameof(propertyName), "'propertyName' cannot be null or empty.");

            var classType = typeof(T);
            var propertyInfo = classType
                                   .GetProperties(BindingFlags.GetProperty
                                                  | BindingFlags.Instance
                                                  | BindingFlags.Public)
                                   .Where(pi => pi.Name == propertyName)
                                   .FirstOrDefault();
            return propertyInfo;
        }

        public static PropertyInfo? GetPropertyInfoByColumnName<T>(string columnName)
        {
            if (string.IsNullOrWhiteSpace(columnName))
                throw new ArgumentNullException(nameof(columnName), "'columnName' cannot be null or empty.");

            var classType = typeof(T);
            var propertyInfo = classType
                                   .GetProperties(BindingFlags.GetProperty
                                                  | BindingFlags.Instance
                                                  | BindingFlags.Public)
                                   .Where(pi => pi.GetCustomAttributes(attributeType: typeof(ColumnInfoAttribute), inherit: false)
                                                  .Where(ci => ((ColumnInfoAttribute)ci).ColumnName == columnName)
                                                  .Count() == 1)
                                   .FirstOrDefault();
            return propertyInfo;
        }

        public static bool? NullableIntToBool(int? value)
        {
            if (!value.HasValue) return null;
            return value.Value != 0;
        }

        public static int? NullableBoolToInt(bool? value)
        {
            if (!value.HasValue) return null;
            return value.Value ? 1 : 0;
        }

        public static bool IntToBool(int value)
        {
            return value != 0;
        }

        public static int BoolToInt(bool value)
        {
            return value ? 1 : 0;
        }

        public static DateTimeOffset? StringToDateTimeOffset(string? value)
        {
            //
            // functions that must be supported:
            //
            // mariadb datetime export format when server timezone is "Etc/UTC"
            // "2022-09-12 14:46:12.845619" -> "2022-09-12T14:46:12.8456190Z"
            //

            if (value is null) return null;
            var culture = CultureInfo.CreateSpecificCulture("en-US");
            var styles = DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal;
            return DateTimeOffset.Parse(value, culture, styles);
        }

        public static string? DateTimeOffsetToString(DateTimeOffset? value, int fractionalSecondDigits = -1)
        {
            if (value is null) return null;
            var fracSecFmt = fractionalSecondDigits switch 
            {
                0 => String.Empty,
                1 => ".F",
                2 => ".FF",
                3 => ".FFF",
                4 => ".FFFF",
                5 => ".FFFFF",
                6 => ".FFFFFF",
                _ => ".FFFFFFF",
            };
            return value?.ToUniversalTime().ToString($"yyyy-MM-dd HH:mm:ss{fracSecFmt}");
        }

        public static DateTime? StringToDateTime(string? value)
        {
            //
            // functions that must be supported:
            //
            // mariadb datetime export format when server timezone is "Etc/UTC"
            // "2022-09-12 14:46:12.845619" -> "2022-09-12T14:46:12.8456190Z"
            //

            if (value is null) return null;
            var culture = CultureInfo.CreateSpecificCulture("en-US");
            var styles = DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal;
            return DateTime.Parse(value, culture, styles);
        }

        public static string? DateTimeToString(DateTime? value, int fractionalSecondDigits = -1)
        {
            if (value is null) return null;
            var fracSecFmt = fractionalSecondDigits switch
            {
                0 => String.Empty,
                1 => ".F",
                2 => ".FF",
                3 => ".FFF",
                4 => ".FFFF",
                5 => ".FFFFF",
                6 => ".FFFFFF",
                _ => ".FFFFFFF",
            };
            return value?.ToUniversalTime().ToString($"yyyy-MM-dd HH:mm:ss{fracSecFmt}");
        }

        public static DateOnly? StringToDateOnly(string? value)
        {
            //
            // functions that must be supported:
            //
            // mariadb datetime export format when server timezone is "Etc/UTC"
            // "2022-09-12" -> "2022-09-12T00:00:00.0000000Z"
            //

            if (value is null) return null;
            var culture = CultureInfo.CreateSpecificCulture("en-US");
            return DateOnly.Parse(value, culture);
        }

        public static string? DateOnlyToString(DateOnly? value)
        {
            if (value is null) return null;
            return value?.ToString("yyyy-MM-dd");
        }

        public static TimeSpan? StringToTimeSpan(string? value)
        {
            //
            // functions that must be supported:
            //
            // mariadb datetime export format when server timezone is "Etc/UTC"
            // "14:46:12.84561900" -> "14:46:12.845619"
            //

            if (value is null) return null;
            var culture = CultureInfo.CreateSpecificCulture("en-US");
            var styles = DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal;
            return DateTime.Parse(value, culture, styles).TimeOfDay;
        }

        public static string? TimeSpanToString(TimeSpan? value, int fractionalSecondDigits = -1)
        {
            if (value is null) return null;
            var fracSecFmt = fractionalSecondDigits switch
            {
                0 => String.Empty,
                1 => "\\.F",
                2 => "\\.FF",
                3 => "\\.FFF",
                4 => "\\.FFFF",
                5 => "\\.FFFFF",
                6 => "\\.FFFFFF",
                _ => "\\.FFFFFFF",
            };
            if (value.HasValue)
            {
                var neg = value?.TotalMilliseconds < 0 ? "-" : String.Empty;
                var days = value?.Days != 0 ? "d\\:" : String.Empty;
                return value?.ToString($"{neg}{days}hh\\:mm\\:ss{fracSecFmt}");
            }
            else
            {
                return null;
            }
        }

        public static string? TruncateString(string? value, int maxLength)
        {
            if (string.IsNullOrEmpty(value)) return value;
            if (value.Length < maxLength) return value;
            return value.Substring(0, maxLength);
        }

        public static string? FormatDecimal(decimal? value, int precision, int scale)
        {
            if (value is null) return null;

            //
            // reference: https://stackoverflow.com/a/192906/2758185
            //
            var valueScaled = SqlDecimal.ConvertToPrecScale(new SqlDecimal(value.Value), precision, scale);
            return valueScaled.ToString();
        }
    }
}
