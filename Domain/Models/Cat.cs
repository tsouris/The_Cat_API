using System.Collections.Generic;

namespace The_Cat_API.Domain.Models
{
    /// <summary>
    /// Contains the core domain models representing cat information, including properties
    /// such as ID, dimensions, URL, breed details, and related information.
    /// Additionally, includes supporting classes for breed information and weight metrics.
    /// Constructors are provided for customization, but default parameterless constructors are
    /// automatically available for each class.
    /// </summary>
    public class Cat
    {
        public string Id { get; set; }
        public int? Height { get; set; }
        public int? Width { get; set; }
        public string? ImageUrl { get; set; }
        public List<Breed>? Breeds { get; set; } 

        public Cat() { }
        public Cat(string id, int? height, int? width, string? imageUrl, List<Breed>? breeds)
        {
            Id = id;
            Height = height;
            Width = width;
            ImageUrl = imageUrl;
            Breeds = breeds;
        }
    }

    public class Breed
    {
        public Weight? Weitgh { get; set; }
        public string? Name { get; set; }
        public string? Temperament { get; set; }
        public string? Origin { get; set; }
        public string? CountryCodes { get; set; }
        public string? CountryCode { get; set; }
        public string? LifeSpan { get; set; }
        public string? WikiUrl { get; set; }

    }

    public class Weight
    {
        public string? Imperial { get; set; }
        public string? Metric { get; set; }
    }
}
