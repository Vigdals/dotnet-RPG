using System.Text.Json.Serialization;

namespace dotnet_RPG.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight = 1,
        Mage = 2,
        Cleric = 3,
        Warrior = 4,
        Assassin = 5
    }
}