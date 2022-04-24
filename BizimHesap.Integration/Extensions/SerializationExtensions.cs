using System.Diagnostics.CodeAnalysis;

namespace BizimHesap.Integration
{
    static class SerializationExtensions
    {
        static System.Text.Json.JsonSerializerOptions SERIALIZER_OPTIONS => new System.Text.Json.JsonSerializerOptions
        {

            WriteIndented = true,
            DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
            DictionaryKeyPolicy = System.Text.Json.JsonNamingPolicy.CamelCase,
            PropertyNamingPolicy = System.Text.Json.JsonNamingPolicy.CamelCase,
            IgnoreReadOnlyFields = true,
            IgnoreReadOnlyProperties = true,
        };

        public static string? ToJson(this object data)
            => data.ToJson(SERIALIZER_OPTIONS);
        public static string? ToJson(this object data, [NotNull] System.Text.Json.JsonSerializerOptions config)
        {
            try { return System.Text.Json.JsonSerializer.Serialize(data, config); }
            catch { return null; }
        }

        public static TObject? FromJson<TObject>(this string data) where TObject : class
            => data.FromJson<TObject>(SERIALIZER_OPTIONS);
        public static TObject? FromJson<TObject>(this string data, [NotNull] System.Text.Json.JsonSerializerOptions config) where TObject : class
        {
            try { return System.Text.Json.JsonSerializer.Deserialize<TObject>(data, config); }
            catch { return null; }
        }

        public static object? FromJson(this string data)
            => data.FromJson(SERIALIZER_OPTIONS);
        public static object? FromJson(this string data, [NotNull] System.Text.Json.JsonSerializerOptions config)
        {
            try { return System.Text.Json.JsonSerializer.Deserialize(data, typeof(object), config); }
            catch { return null; }
        }
    }
}
