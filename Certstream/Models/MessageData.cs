﻿using System;
using System.Text.Json.Serialization;

namespace Certstream.Models
{
    public struct MessageData
    {
        [JsonPropertyName("cert_index")]
        public long CertIndex { get; set; }

        [JsonPropertyName("cert_link")]
        public string CertLink { get; set; }

        [JsonPropertyName("leaf_cert")]
        public LeafCertificate Leaf { get; set; }

        [JsonConverter(typeof(UnixDateTimeOffsetConverter))]
        [JsonPropertyName("seen")]
        public DateTimeOffset Seen { get; set; }

        [JsonPropertyName("source")]
        public Source Source { get; set; }

        [JsonPropertyName("update_type")]
        public string UpdateType { get; set; }
    }
}