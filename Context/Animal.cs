using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HustleWebAPI.Context
{
    public class Animal
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "gender")]
        public string Gender { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "weight")]
        public decimal? Weight { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "model")]
        public JObject Model { get; set; }
    }
}
