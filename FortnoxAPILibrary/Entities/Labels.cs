using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming

namespace FortnoxAPILibrary.Entities
{
    /// <remarks/>

    
    
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class Labels : BaseEntityCollection : BaseEntityCollection : BaseEntityCollection {

        /// <remarks/>
        [JsonProperty]
        public List<LabelSubset> LabelSubset { get; set; }



    }

    /// <remarks/>
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class LabelSubset {

        /// <remarks/>
        [JsonProperty]
        public string Id { get; set; }

        /// <remarks/>
        [JsonProperty]
        public string Description { get; set; }

        /// <remarks/>
        [JsonProperty(PropertyName = "@url")]
        public string Url { get; set; }
    }
}
