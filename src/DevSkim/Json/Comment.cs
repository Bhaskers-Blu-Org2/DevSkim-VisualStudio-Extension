﻿// Copyright(C) Microsoft.All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

using Newtonsoft.Json;

namespace DevSkim
{
    /// <summary>
    /// Comment class to hold information about comment for each language
    /// </summary>
    public class Comment
    {
        [JsonProperty(PropertyName ="content_type")]
        public string[] ContentTypes { get; set; }

        [JsonProperty(PropertyName ="preffix")]
        public string Preffix{ get; set; }

        [JsonProperty(PropertyName ="suffix")]
        public string Suffix { get; set; }

    }
}
