using System.Text.Json.Serialization;

namespace firstapi.Models{
    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RgpClass{
        Warior = 1,
        Mage = 2,
        Rouge = 3
    }
}