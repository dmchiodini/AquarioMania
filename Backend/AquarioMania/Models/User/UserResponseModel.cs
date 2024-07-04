using System.Text.Json.Serialization;

namespace AquarioMania.Models.User
{
    public class UserResponseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        [JsonIgnore]
        public string? Password { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public int Profile_id { get; set; }
        public string? Profile_name { get; set; }
        public DateTime Created_at { get; set; } = DateTime.Now.ToLocalTime();
        public DateTime Updated_at { get; set; } = DateTime.Now.ToLocalTime();
    }
}
