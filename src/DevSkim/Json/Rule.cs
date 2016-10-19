﻿// Copyright (C) Microsoft. All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

using Newtonsoft.Json;

namespace DevSkim
{
    /// <summary>
    /// Class to hold the Rule
    /// </summary>
    public class Rule
    {
        public string File { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "overrides")]
        public string[] Overrides { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "active")]
        public bool Active { get; set; }

        [JsonProperty(PropertyName = "tags")]
        public string[] Tags { get; set; }

        [JsonProperty(PropertyName = "applies_to")]
        public string[] AppliesTo { get; set; }

        [JsonProperty(PropertyName = "severity")]
        [JsonConverter(typeof(SeverityConverter))]
        public Severity Severity { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "replacement")]
        public string Replecement { get; set; }

        [JsonProperty(PropertyName = "rule_info")]
        public string RuleInfo { get; set; }

        [JsonProperty(PropertyName = "patterns")]
        public PatternRecord[] Patterns { get; set; }

        [JsonProperty(PropertyName = "fix_it")]
        public FixRecord[] Fixes { get; set; }
    }
}
