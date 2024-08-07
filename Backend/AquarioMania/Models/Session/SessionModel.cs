﻿using AquarioMania.Models.User;
using System.Text.Json.Serialization;

namespace AquarioMania.Models.Session;

public class SessionModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Country { get; set; }
    public int Profile_id { get; set; }
    public string? Profile_name { get; set; }
    public string Token { get; set; }
}
