using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace Practica3.MVC.Models
{
    public class PeopleView
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "height")]
        public string Height { get; set; }

        [JsonProperty(PropertyName = "mass")]
        public string Mass { get; set; }

        [JsonProperty(PropertyName = "hair_color")]
        public string HairColor { get; set; }

        [JsonProperty(PropertyName = "skin_color")]
        public string SkinColor { get; set; }

        [JsonProperty(PropertyName = "birth_year")]
        public string BirthYear { get; set; }

        [JsonProperty(PropertyName = "gender")]
        public string Gender { get; set; }

        [JsonProperty(PropertyName = "homeworld")]
        public string HomeWorld { get; set; }


        public List<Films> Movies { get; set; }


        public List<Species> Raze { get; set; }


        public List<Vehicles> Automovil { get; set; }


        public List<Starships> Naves { get; set; }

        [JsonProperty(PropertyName = "created")]
        public string Created { get; set; }

        [JsonProperty(PropertyName = "edited")]
        public string Edited { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
    }

    public class Films
    {
        [JsonProperty(PropertyName = "films")]
        public string film;
    }

    public class Species
    {
        [JsonProperty(PropertyName = "species")]
        public string species;
    }

    public class Vehicles
    {
        [JsonProperty(PropertyName = "vehicles")]
        public string vehicle;
    }

    public class Starships
    {
        [JsonProperty(PropertyName = "starships")]
        public string Starship;
    }
}