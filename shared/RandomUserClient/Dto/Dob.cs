using System;
using System.Text.Json.Serialization;

namespace RandomUserClient.Dto
{
    public class Dob
    {
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }

        [JsonPropertyName("age")]
        public int Age { get; set; }
    }
}
