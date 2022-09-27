using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class UserTrainingContentEventInfo : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The browser property</summary>
        public string Browser {
            get { return BackingStore?.Get<string>("browser"); }
            set { BackingStore?.Set("browser", value); }
        }
        /// <summary>The contentDateTime property</summary>
        public DateTimeOffset? ContentDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("contentDateTime"); }
            set { BackingStore?.Set("contentDateTime", value); }
        }
        /// <summary>The ipAddress property</summary>
        public string IpAddress {
            get { return BackingStore?.Get<string>("ipAddress"); }
            set { BackingStore?.Set("ipAddress", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The osPlatformDeviceDetails property</summary>
        public string OsPlatformDeviceDetails {
            get { return BackingStore?.Get<string>("osPlatformDeviceDetails"); }
            set { BackingStore?.Set("osPlatformDeviceDetails", value); }
        }
        /// <summary>The potentialScoreImpact property</summary>
        public double? PotentialScoreImpact {
            get { return BackingStore?.Get<double?>("potentialScoreImpact"); }
            set { BackingStore?.Set("potentialScoreImpact", value); }
        }
        /// <summary>
        /// Instantiates a new userTrainingContentEventInfo and sets the default values.
        /// </summary>
        public UserTrainingContentEventInfo() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.userTrainingContentEventInfo";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UserTrainingContentEventInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserTrainingContentEventInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"browser", n => { Browser = n.GetStringValue(); } },
                {"contentDateTime", n => { ContentDateTime = n.GetDateTimeOffsetValue(); } },
                {"ipAddress", n => { IpAddress = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"osPlatformDeviceDetails", n => { OsPlatformDeviceDetails = n.GetStringValue(); } },
                {"potentialScoreImpact", n => { PotentialScoreImpact = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("browser", Browser);
            writer.WriteDateTimeOffsetValue("contentDateTime", ContentDateTime);
            writer.WriteStringValue("ipAddress", IpAddress);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("osPlatformDeviceDetails", OsPlatformDeviceDetails);
            writer.WriteDoubleValue("potentialScoreImpact", PotentialScoreImpact);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
