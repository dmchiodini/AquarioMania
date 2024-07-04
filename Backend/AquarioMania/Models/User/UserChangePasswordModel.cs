using System.Text.Json.Serialization;

namespace AquarioMania.Models.User;

public class UserChangePasswordModel
{
    public int Id { get; set; }
    public string Password { get; set; }
    public DateTime Updated_at { get; set; } = DateTime.Now.ToLocalTime();
}
