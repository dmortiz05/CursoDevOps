﻿using System;
using Newtonsoft.Json;

namespace poi.Models
{
    public class Healthcheck
    {
        public Healthcheck()
        {
            Message = "POI Service Healthcheck";
            Status = "Healthy";
            Version = "2021-10-12.1";
            //Status = "Broken...";
        }
        [Newtonsoft.Json.JsonProperty(PropertyName = "message")]
        public string Message {get;set;}

        [Newtonsoft.Json.JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
        
        [Newtonsoft.Json.JsonProperty(PropertyName = "version")]
        public string Version { get; set; }
    }
}
