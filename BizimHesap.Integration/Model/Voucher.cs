using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace BizimHesap.Integration.Model
{
    public sealed class AddVoucher
    {

    }

    public sealed class Voucher
    {
        [JsonPropertyName("guid")]
        public Guid Id { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
