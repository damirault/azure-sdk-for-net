// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class AnomalyDetectionConfigurationPatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(WholeMetricConfiguration))
            {
                writer.WritePropertyName("wholeMetricConfiguration");
                writer.WriteObjectValue(WholeMetricConfiguration);
            }
            if (Optional.IsCollectionDefined(DimensionGroupOverrideConfigurations))
            {
                writer.WritePropertyName("dimensionGroupOverrideConfigurations");
                writer.WriteStartArray();
                foreach (var item in DimensionGroupOverrideConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SeriesOverrideConfigurations))
            {
                writer.WritePropertyName("seriesOverrideConfigurations");
                writer.WriteStartArray();
                foreach (var item in SeriesOverrideConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
    }
}
