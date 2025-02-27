// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class ProvisioningStep : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Summary of what occurred during the step.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>Details of what occurred during the step.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DetailsInfo? Details {
            get { return BackingStore?.Get<DetailsInfo?>("details"); }
            set { BackingStore?.Set("details", value); }
        }
#nullable restore
#else
        public DetailsInfo Details {
            get { return BackingStore?.Get<DetailsInfo>("details"); }
            set { BackingStore?.Set("details", value); }
        }
#endif
        /// <summary>Name of the step.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Type of step. Possible values are: import, scoping, matching, processing, referenceResolution, export, unknownFutureValue.</summary>
        public Microsoft.Graph.Models.ProvisioningStepType? ProvisioningStepType {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ProvisioningStepType?>("provisioningStepType"); }
            set { BackingStore?.Set("provisioningStepType", value); }
        }
        /// <summary>Status of the step. Possible values are: success, warning,  failure, skipped, unknownFutureValue.</summary>
        public ProvisioningResult? Status {
            get { return BackingStore?.Get<ProvisioningResult?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Instantiates a new provisioningStep and sets the default values.
        /// </summary>
        public ProvisioningStep() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ProvisioningStep CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ProvisioningStep();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"description", n => { Description = n.GetStringValue(); } },
                {"details", n => { Details = n.GetObjectValue<DetailsInfo>(DetailsInfo.CreateFromDiscriminatorValue); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"provisioningStepType", n => { ProvisioningStepType = n.GetEnumValue<ProvisioningStepType>(); } },
                {"status", n => { Status = n.GetEnumValue<ProvisioningResult>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteObjectValue<DetailsInfo>("details", Details);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<ProvisioningStepType>("provisioningStepType", ProvisioningStepType);
            writer.WriteEnumValue<ProvisioningResult>("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
