using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class WorkbookCommentReply : Entity, IParsable {
        /// <summary>The content of a comment reply.</summary>
        public string Content {
            get { return BackingStore?.Get<string>("content"); }
            set { BackingStore?.Set("content", value); }
        }
        /// <summary>Indicates the type for the comment reply.</summary>
        public string ContentType {
            get { return BackingStore?.Get<string>("contentType"); }
            set { BackingStore?.Set("contentType", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WorkbookCommentReply CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookCommentReply();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"content", n => { Content = n.GetStringValue(); } },
                {"contentType", n => { ContentType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("content", Content);
            writer.WriteStringValue("contentType", ContentType);
        }
    }
}
