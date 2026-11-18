using System.Text.Json.Serialization;

namespace BlazorWasmSuperHeroApi.Models;

public sealed class HeroSearchResponse
{
    [JsonPropertyName("response")]
    public string? Response { get; set; }

    [JsonPropertyName("error")]
    public string? Error { get; set; }

    [JsonPropertyName("results-for")]
    public string? ResultsFor { get; set; }

    [JsonPropertyName("results")]
    public List<Hero>? Results { get; set; }
}

public sealed class Hero
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("powerstats")]
    public HeroPowerStats? PowerStats { get; set; }

    [JsonPropertyName("biography")]
    public HeroBiography? Biography { get; set; }

    [JsonPropertyName("appearance")]
    public HeroAppearance? Appearance { get; set; }

    [JsonPropertyName("work")]
    public HeroWork? Work { get; set; }

    [JsonPropertyName("image")]
    public HeroImage? Image { get; set; }
}

public sealed class HeroPowerStats
{
    [JsonPropertyName("intelligence")] public string? Intelligence { get; set; }
    [JsonPropertyName("strength")] public string? Strength { get; set; }
    [JsonPropertyName("speed")] public string? Speed { get; set; }
    [JsonPropertyName("durability")] public string? Durability { get; set; }
    [JsonPropertyName("power")] public string? Power { get; set; }
    [JsonPropertyName("combat")] public string? Combat { get; set; }
}

public sealed class HeroBiography
{
    [JsonPropertyName("full-name")] public string? FullName { get; set; }
    [JsonPropertyName("publisher")] public string? Publisher { get; set; }
    [JsonPropertyName("alignment")] public string? Alignment { get; set; }
}

public sealed class HeroAppearance
{
    [JsonPropertyName("gender")] public string? Gender { get; set; }
    [JsonPropertyName("race")] public string? Race { get; set; }
    [JsonPropertyName("height")] public List<string>? Height { get; set; }
    [JsonPropertyName("weight")] public List<string>? Weight { get; set; }
}

public sealed class HeroWork
{
    [JsonPropertyName("occupation")] public string? Occupation { get; set; }
}

public sealed class HeroImage
{
    [JsonPropertyName("url")] public string? Url { get; set; }
}
