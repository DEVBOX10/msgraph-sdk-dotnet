// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Users.Item.TranslateExchangeIds {
    [Obsolete("This class is obsolete. Use translateExchangeIdsPostResponse instead.")]
    public class TranslateExchangeIdsResponse : TranslateExchangeIdsPostResponse, IParsable {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TranslateExchangeIdsResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TranslateExchangeIdsResponse();
        }
    }
}
