﻿using Newtonsoft.Json;

namespace Conflux.KeyStore.Model
{
    public class Pbkdf2Params : KdfParams
    {
        [JsonProperty("c")]
        public int Count { get; set; }

        [JsonProperty("prf")]
        public string Prf { get; set; }
    }
}