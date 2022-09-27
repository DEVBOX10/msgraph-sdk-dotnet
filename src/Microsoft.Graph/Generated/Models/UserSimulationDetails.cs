using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class UserSimulationDetails : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The assignedTrainingsCount property</summary>
        public int? AssignedTrainingsCount {
            get { return BackingStore?.Get<int?>("assignedTrainingsCount"); }
            set { BackingStore?.Set("assignedTrainingsCount", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The completedTrainingsCount property</summary>
        public int? CompletedTrainingsCount {
            get { return BackingStore?.Get<int?>("completedTrainingsCount"); }
            set { BackingStore?.Set("completedTrainingsCount", value); }
        }
        /// <summary>The compromisedDateTime property</summary>
        public DateTimeOffset? CompromisedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("compromisedDateTime"); }
            set { BackingStore?.Set("compromisedDateTime", value); }
        }
        /// <summary>The inProgressTrainingsCount property</summary>
        public int? InProgressTrainingsCount {
            get { return BackingStore?.Get<int?>("inProgressTrainingsCount"); }
            set { BackingStore?.Set("inProgressTrainingsCount", value); }
        }
        /// <summary>The isCompromised property</summary>
        public bool? IsCompromised {
            get { return BackingStore?.Get<bool?>("isCompromised"); }
            set { BackingStore?.Set("isCompromised", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The reportedPhishDateTime property</summary>
        public DateTimeOffset? ReportedPhishDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("reportedPhishDateTime"); }
            set { BackingStore?.Set("reportedPhishDateTime", value); }
        }
        /// <summary>The simulationEvents property</summary>
        public List<UserSimulationEventInfo> SimulationEvents {
            get { return BackingStore?.Get<List<UserSimulationEventInfo>>("simulationEvents"); }
            set { BackingStore?.Set("simulationEvents", value); }
        }
        /// <summary>The simulationUser property</summary>
        public AttackSimulationUser SimulationUser {
            get { return BackingStore?.Get<AttackSimulationUser>("simulationUser"); }
            set { BackingStore?.Set("simulationUser", value); }
        }
        /// <summary>The trainingEvents property</summary>
        public List<UserTrainingEventInfo> TrainingEvents {
            get { return BackingStore?.Get<List<UserTrainingEventInfo>>("trainingEvents"); }
            set { BackingStore?.Set("trainingEvents", value); }
        }
        /// <summary>
        /// Instantiates a new userSimulationDetails and sets the default values.
        /// </summary>
        public UserSimulationDetails() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.userSimulationDetails";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UserSimulationDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserSimulationDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"assignedTrainingsCount", n => { AssignedTrainingsCount = n.GetIntValue(); } },
                {"completedTrainingsCount", n => { CompletedTrainingsCount = n.GetIntValue(); } },
                {"compromisedDateTime", n => { CompromisedDateTime = n.GetDateTimeOffsetValue(); } },
                {"inProgressTrainingsCount", n => { InProgressTrainingsCount = n.GetIntValue(); } },
                {"isCompromised", n => { IsCompromised = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"reportedPhishDateTime", n => { ReportedPhishDateTime = n.GetDateTimeOffsetValue(); } },
                {"simulationEvents", n => { SimulationEvents = n.GetCollectionOfObjectValues<UserSimulationEventInfo>(UserSimulationEventInfo.CreateFromDiscriminatorValue)?.ToList(); } },
                {"simulationUser", n => { SimulationUser = n.GetObjectValue<AttackSimulationUser>(AttackSimulationUser.CreateFromDiscriminatorValue); } },
                {"trainingEvents", n => { TrainingEvents = n.GetCollectionOfObjectValues<UserTrainingEventInfo>(UserTrainingEventInfo.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("assignedTrainingsCount", AssignedTrainingsCount);
            writer.WriteIntValue("completedTrainingsCount", CompletedTrainingsCount);
            writer.WriteDateTimeOffsetValue("compromisedDateTime", CompromisedDateTime);
            writer.WriteIntValue("inProgressTrainingsCount", InProgressTrainingsCount);
            writer.WriteBoolValue("isCompromised", IsCompromised);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteDateTimeOffsetValue("reportedPhishDateTime", ReportedPhishDateTime);
            writer.WriteCollectionOfObjectValues<UserSimulationEventInfo>("simulationEvents", SimulationEvents);
            writer.WriteObjectValue<AttackSimulationUser>("simulationUser", SimulationUser);
            writer.WriteCollectionOfObjectValues<UserTrainingEventInfo>("trainingEvents", TrainingEvents);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
