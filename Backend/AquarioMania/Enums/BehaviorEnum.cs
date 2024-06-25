using System.Text.Json.Serialization;

namespace AquarioMania.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum BehaviorEnum
    {
        Pacifico,
        Moderado,
        Agressivo
    }
}
