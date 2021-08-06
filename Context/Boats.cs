using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HustleWebAPI.Context
{
    public class Boats
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "boatType")]
        public string BoatType { get; set; }        
    }
}
