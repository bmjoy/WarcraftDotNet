﻿using Newtonsoft.Json;

namespace WarcraftDotNet.API.Pet
{
    public class Stats
    {
        [JsonProperty("speciesId")]
        public int SpeciesId { get; set; }
        [JsonProperty("breedId")]
        public int BreedId { get; set; }
        [JsonProperty("petQualityId")]
        public int PetQualityId { get; set; }
        [JsonProperty("level")]
        public int Level { get; set; }
        [JsonProperty("health")]
        public int Health { get; set; }
        [JsonProperty("power")]
        public int Power { get; set; }
        [JsonProperty("speed")]
        public int Speed { get; set; }
    }
}