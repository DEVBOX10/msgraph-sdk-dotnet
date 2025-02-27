// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class UserRegistrationMethodSummary : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
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
        /// <summary>Total number of users in the tenant.</summary>
        public long? TotalUserCount {
            get { return BackingStore?.Get<long?>("totalUserCount"); }
            set { BackingStore?.Set("totalUserCount", value); }
        }
        /// <summary>Number of users registered for each authentication method.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserRegistrationMethodCount>? UserRegistrationMethodCounts {
            get { return BackingStore?.Get<List<UserRegistrationMethodCount>?>("userRegistrationMethodCounts"); }
            set { BackingStore?.Set("userRegistrationMethodCounts", value); }
        }
#nullable restore
#else
        public List<UserRegistrationMethodCount> UserRegistrationMethodCounts {
            get { return BackingStore?.Get<List<UserRegistrationMethodCount>>("userRegistrationMethodCounts"); }
            set { BackingStore?.Set("userRegistrationMethodCounts", value); }
        }
#endif
        /// <summary>The role type of the user. Possible values are: all, privilegedAdmin, admin, user, unknownFutureValue.</summary>
        public IncludedUserRoles? UserRoles {
            get { return BackingStore?.Get<IncludedUserRoles?>("userRoles"); }
            set { BackingStore?.Set("userRoles", value); }
        }
        /// <summary>User type. Possible values are: all, member, guest, unknownFutureValue.</summary>
        public IncludedUserTypes? UserTypes {
            get { return BackingStore?.Get<IncludedUserTypes?>("userTypes"); }
            set { BackingStore?.Set("userTypes", value); }
        }
        /// <summary>
        /// Instantiates a new userRegistrationMethodSummary and sets the default values.
        /// </summary>
        public UserRegistrationMethodSummary() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UserRegistrationMethodSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserRegistrationMethodSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"totalUserCount", n => { TotalUserCount = n.GetLongValue(); } },
                {"userRegistrationMethodCounts", n => { UserRegistrationMethodCounts = n.GetCollectionOfObjectValues<UserRegistrationMethodCount>(UserRegistrationMethodCount.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userRoles", n => { UserRoles = n.GetEnumValue<IncludedUserRoles>(); } },
                {"userTypes", n => { UserTypes = n.GetEnumValue<IncludedUserTypes>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteLongValue("totalUserCount", TotalUserCount);
            writer.WriteCollectionOfObjectValues<UserRegistrationMethodCount>("userRegistrationMethodCounts", UserRegistrationMethodCounts);
            writer.WriteEnumValue<IncludedUserRoles>("userRoles", UserRoles);
            writer.WriteEnumValue<IncludedUserTypes>("userTypes", UserTypes);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
