using System;
using System.Text.Json.Serialization;

namespace BizimHesap.Integration.Model
{
    public sealed class Warehouse
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
