using System.Text.Json.Serialization;

namespace RandomUserClient.Dto
{
    public class Result
    {
        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        [JsonPropertyName("cell")]
        public string Cell { get; set; }

        [JsonPropertyName("dob")]
        public Dob Dob { get; set; }
    }
}