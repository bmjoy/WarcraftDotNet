﻿using Newtonsoft.Json;

namespace WarcraftDotNet.API.Guild
{
    public class CharacterSpec
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("role")]
        public string Role { get; set; }
        [JsonProperty("backgroundImage")]
        public string BackgroundImage { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("order")]
        public int Order { get; set; }
    }
}