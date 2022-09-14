using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.Serialization;

namespace GizmoFort.Connector.ERPNext.WrapperTypes
{
    public abstract class ERPNextObjectBase
    {
        public ERPObject Object { get; internal set; }

        protected ERPNextObjectBase(ERPObject obj)
        {
            this.Object = obj;
        }

#pragma warning disable IDE1006 // Naming Styles
        protected dynamic data => Object.Data;
#pragma warning restore IDE1006 // Naming Styles

#pragma warning disable IDE1006 // Naming Styles
        public string name
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return Object.Name; }
            set { Object.Name = value; }
        }

        public DocType ObjectType => Object.ObjectType;

        protected static T ParseEnum<T>(string enumString)
        {
            if (!typeof(T).IsEnum) {
                throw new ArgumentException("T must be an enum");
            }

            return (T)Enum.Parse(typeof(T), enumString, true);
        }


        public static T? Deserialize<T>(string value, JsonSerializerOptions? _options = null)
        {
            //
            // deserialization is straight-forward... setters will only be called if values
            // are included in the json string
            //
            // also, the date time formats TO ERPNext/mariadb will be in the
            // server timezone. So set the server to UTC and convert assuming UTC
            //

            _options ??= new JsonSerializerOptions();
            _options.Converters.Add(new ERPNextObjectBaseDateTimeConverter());
            _options.Converters.Add(new ERPNextObjectBaseDateTimeOffsetConverter());
            var result = typeof(JsonSerializer)
                            .GetMethod("Deserialize", new Type[] { typeof(string), typeof(JsonSerializerOptions) } )!
                            .MakeGenericMethod(new Type[] { typeof(T) })
                            .Invoke(null, new object[] { value, _options });
            return (T?)result;
        }

        public static object? Deserialize(string value, Type type, JsonSerializerOptions? _options = null)
        {
            //
            // deserialization is straight-forward... setters will only be called if values
            // are included in the json string
            //
            // also, the date time formats TO ERPNext/mariadb will be in the
            // server timezone. So set the server to UTC and convert assuming UTC
            //

            _options ??= new JsonSerializerOptions();
            _options.Converters.Add(new ERPNextObjectBaseDateTimeConverter());
            _options.Converters.Add(new ERPNextObjectBaseDateTimeOffsetConverter());
            return JsonSerializer.Deserialize(value, type, (JsonSerializerOptions)_options);

        }

        public static string Serialize(ERPNextObjectBase value, JsonSerializerOptions? _options = null)
        {
            //
            // serializtion is more complex... will need to serialize the data
            // property ONLY, but map the names and values to the exposed property names and values
            //
            // also, the date time formats FROM ERPNext/mariadb will be in the
            // server timezone. So set the server to UTC and convert assuming UTC
            //

            //Type policyGenericWithType = typeof(CustomJsonNamingPolicy<>).MakeGenericType(new Type[] { value.GetType() });
            //var policy = Activator.CreateInstance(policyGenericWithType)!;

            //var enhancedOptions = _options ?? new JsonSerializerOptions();
            //enhancedOptions.DictionaryKeyPolicy = (JsonNamingPolicy)policy;

            //var castValue = (ERPNextObjectBase)value;

            Type converterGenericWithType = typeof(ERPNextObjectBaseJsonConverter<>).MakeGenericType(new Type[] { value.GetType() });
            var converter = (JsonConverter)Activator.CreateInstance(converterGenericWithType)!;

            _options ??= new JsonSerializerOptions();
            _options.Converters.Add(converter);
            _options.Converters.Add(new ERPNextObjectBaseDateTimeOffsetConverter());
            _options.Converters.Add(new ERPNextObjectBaseDateTimeConverter());

            return JsonSerializer.Serialize(value, _options);
        }


    }
}