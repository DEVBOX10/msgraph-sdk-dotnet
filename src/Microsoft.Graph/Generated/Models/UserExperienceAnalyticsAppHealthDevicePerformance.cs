// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    /// <summary>
    /// The user experience analytics device performance entity contains device performance details.
    /// </summary>
    public class UserExperienceAnalyticsAppHealthDevicePerformance : Entity, IParsable {
        /// <summary>The number of application crashes for the device. Valid values 0 to 2147483647. Supports: $filter, $select, $OrderBy. Read-only. Valid values -2147483648 to 2147483647</summary>
        public int? AppCrashCount {
            get { return BackingStore?.Get<int?>("appCrashCount"); }
            set { BackingStore?.Set("appCrashCount", value); }
        }
        /// <summary>The number of application hangs for the device. Valid values 0 to 2147483647. Supports: $select, $OrderBy. Read-only. Valid values -2147483648 to 2147483647</summary>
        public int? AppHangCount {
            get { return BackingStore?.Get<int?>("appHangCount"); }
            set { BackingStore?.Set("appHangCount", value); }
        }
        /// <summary>The number of distinct application crashes for the device. Valid values 0 to 2147483647. Supports: $select, $OrderBy. Read-only. Valid values -2147483648 to 2147483647</summary>
        public int? CrashedAppCount {
            get { return BackingStore?.Get<int?>("crashedAppCount"); }
            set { BackingStore?.Set("crashedAppCount", value); }
        }
        /// <summary>The application health score of the device. Valid values 0 to 100. Supports: $filter, $select, $OrderBy. Read-only. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? DeviceAppHealthScore {
            get { return BackingStore?.Get<double?>("deviceAppHealthScore"); }
            set { BackingStore?.Set("deviceAppHealthScore", value); }
        }
        /// <summary>The name of the device. Supports: $select, $OrderBy. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceDisplayName {
            get { return BackingStore?.Get<string?>("deviceDisplayName"); }
            set { BackingStore?.Set("deviceDisplayName", value); }
        }
#nullable restore
#else
        public string DeviceDisplayName {
            get { return BackingStore?.Get<string>("deviceDisplayName"); }
            set { BackingStore?.Set("deviceDisplayName", value); }
        }
#endif
        /// <summary>The Intune device id of the device. Supports: $select, $OrderBy. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceId {
            get { return BackingStore?.Get<string?>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
#nullable restore
#else
        public string DeviceId {
            get { return BackingStore?.Get<string>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
#endif
        /// <summary>The manufacturer name of the device. Supports: $select, $OrderBy. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceManufacturer {
            get { return BackingStore?.Get<string?>("deviceManufacturer"); }
            set { BackingStore?.Set("deviceManufacturer", value); }
        }
#nullable restore
#else
        public string DeviceManufacturer {
            get { return BackingStore?.Get<string>("deviceManufacturer"); }
            set { BackingStore?.Set("deviceManufacturer", value); }
        }
#endif
        /// <summary>The model name of the device. Supports: $select, $OrderBy. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceModel {
            get { return BackingStore?.Get<string?>("deviceModel"); }
            set { BackingStore?.Set("deviceModel", value); }
        }
#nullable restore
#else
        public string DeviceModel {
            get { return BackingStore?.Get<string>("deviceModel"); }
            set { BackingStore?.Set("deviceModel", value); }
        }
#endif
        /// <summary>The healthStatus property</summary>
        public UserExperienceAnalyticsHealthState? HealthStatus {
            get { return BackingStore?.Get<UserExperienceAnalyticsHealthState?>("healthStatus"); }
            set { BackingStore?.Set("healthStatus", value); }
        }
        /// <summary>The mean time to failure for the application in minutes. Valid values 0 to 2147483647. Supports: $filter, $select, $OrderBy. Read-only. Valid values -2147483648 to 2147483647</summary>
        public int? MeanTimeToFailureInMinutes {
            get { return BackingStore?.Get<int?>("meanTimeToFailureInMinutes"); }
            set { BackingStore?.Set("meanTimeToFailureInMinutes", value); }
        }
        /// <summary>The date and time when the statistics were last computed. The value cannot be modified and is automatically populated when the statistics are computed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2022 would look like this: &apos;2022-01-01T00:00:00Z&apos;. Returned by default. Read-only.</summary>
        public DateTimeOffset? ProcessedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("processedDateTime"); }
            set { BackingStore?.Set("processedDateTime", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UserExperienceAnalyticsAppHealthDevicePerformance CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsAppHealthDevicePerformance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appCrashCount", n => { AppCrashCount = n.GetIntValue(); } },
                {"appHangCount", n => { AppHangCount = n.GetIntValue(); } },
                {"crashedAppCount", n => { CrashedAppCount = n.GetIntValue(); } },
                {"deviceAppHealthScore", n => { DeviceAppHealthScore = n.GetDoubleValue(); } },
                {"deviceDisplayName", n => { DeviceDisplayName = n.GetStringValue(); } },
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"deviceManufacturer", n => { DeviceManufacturer = n.GetStringValue(); } },
                {"deviceModel", n => { DeviceModel = n.GetStringValue(); } },
                {"healthStatus", n => { HealthStatus = n.GetEnumValue<UserExperienceAnalyticsHealthState>(); } },
                {"meanTimeToFailureInMinutes", n => { MeanTimeToFailureInMinutes = n.GetIntValue(); } },
                {"processedDateTime", n => { ProcessedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("appCrashCount", AppCrashCount);
            writer.WriteIntValue("appHangCount", AppHangCount);
            writer.WriteIntValue("crashedAppCount", CrashedAppCount);
            writer.WriteDoubleValue("deviceAppHealthScore", DeviceAppHealthScore);
            writer.WriteStringValue("deviceDisplayName", DeviceDisplayName);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("deviceManufacturer", DeviceManufacturer);
            writer.WriteStringValue("deviceModel", DeviceModel);
            writer.WriteEnumValue<UserExperienceAnalyticsHealthState>("healthStatus", HealthStatus);
            writer.WriteIntValue("meanTimeToFailureInMinutes", MeanTimeToFailureInMinutes);
            writer.WriteDateTimeOffsetValue("processedDateTime", ProcessedDateTime);
        }
    }
}
