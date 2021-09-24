using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RandomUserClient.Dto
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);

    public class RandomUserResponse
    {
        [JsonPropertyName("results")]
        public List<Result> Results { get; set; }
    }
}