using System.Text.Json.Serialization;

namespace BizimHesap.Integration.Model
{
    public class ApiResponseObject
    {
        [JsonPropertyName("resultCode")]
        public int Code { get; set; }

        [JsonPropertyName("errorText")]
        public string ErrorText { get; set; }
    }
}
