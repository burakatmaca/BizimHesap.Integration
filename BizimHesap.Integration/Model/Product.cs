using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BizimHesap.Integration.Model
{
    public sealed class Product
    {
        public Guid Id { get; set; }
        public bool IsActive { get; set; }
        public string Code { get; set; }
        public string Barcode { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string Currency { get; set; }
        public string Unit { get; set; }
        public double Tax { get; set; }
        public string Description { get; set; }
        public string ECommerceDescription { get; set; }
        public double Quantity { get; set; }
        public IList<Photo> Photos { get; set; }
        public IList<Variant> Variants { get; set; }

        public sealed class Variant
        {
            public string Name { get; set; }
            public string Value { get; set; }
            public double? Price { get; set; }
        }

        public sealed class Photo
        {
            [JsonPropertyName("FlCover")]
            public bool Cover { get; set; }

            [JsonPropertyName("PhotoUrlOriginal")]
            public string Original { get; set; }

            [JsonPropertyName("ThumbnailUrl")]
            public string Thumbnail { get; set; }
        }
    }
}