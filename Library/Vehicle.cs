using Newtonsoft.Json;

using System.Collections.Generic;

namespace Library
{
    public class Vehicle
    {
        [JsonProperty(Order = -2)]
        public string Make {get; set;}
        
        public string Model {get; set;}

        public int Year {get; set;}
        
        public int Seats {get; set;}

        public List<Feature> Features = new List<Feature>();
    }
}