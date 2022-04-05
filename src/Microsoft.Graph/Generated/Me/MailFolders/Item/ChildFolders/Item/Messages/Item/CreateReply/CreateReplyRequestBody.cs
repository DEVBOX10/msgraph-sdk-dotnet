using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Me.MailFolders.Item.ChildFolders.Item.Messages.Item.CreateReply {
    /// <summary>Provides operations to call the createReply method.</summary>
    public class CreateReplyRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Comment property</summary>
        public string Comment { get; set; }
        /// <summary>The Message property</summary>
        public Microsoft.Graph.Models.Message Message { get; set; }
        /// <summary>
        /// Instantiates a new createReplyRequestBody and sets the default values.
        /// </summary>
        public CreateReplyRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CreateReplyRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CreateReplyRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"comment", (o,n) => { (o as CreateReplyRequestBody).Comment = n.GetStringValue(); } },
                {"message", (o,n) => { (o as CreateReplyRequestBody).Message = n.GetObjectValue<Microsoft.Graph.Models.Message>(Microsoft.Graph.Models.Message.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("comment", Comment);
            writer.WriteObjectValue<Microsoft.Graph.Models.Message>("message", Message);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
