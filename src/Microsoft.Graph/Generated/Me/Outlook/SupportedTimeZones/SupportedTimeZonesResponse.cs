// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Me.Outlook.SupportedTimeZones {
    [Obsolete("This class is obsolete. Use supportedTimeZonesGetResponse instead.")]
    public class SupportedTimeZonesResponse : SupportedTimeZonesGetResponse, IParsable {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SupportedTimeZonesResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SupportedTimeZonesResponse();
        }
    }
}
