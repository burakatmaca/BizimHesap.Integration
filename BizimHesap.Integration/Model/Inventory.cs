using System;
using System.Text.Json.Serialization;

namespace BizimHesap.Integration.Model
{
    public sealed class Inventory
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("barcode")]
        public string Barcode { get; set; }

        [JsonPropertyName("qty")]
        public int? Quantity { get; set; }
    }
}
