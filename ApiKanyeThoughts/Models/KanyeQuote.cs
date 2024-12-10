using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApiKanyeThoughts.Models
{

    internal class KanyeQuote
    {
        [JsonPropertyName("quote")]
        public string? Quote { get; set; }
    }
}