using System.Text.Json.Serialization;

namespace AquarioMania.Models.User;

public class UserUpdateModel
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Country { get; set; }
}
