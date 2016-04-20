// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

namespace Microsoft.Graph
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    
    using Microsoft.Graph.Core;
    using Newtonsoft.Json;

    /// <summary>
    /// The type UserEventsCollectionResponse.
    /// </summary>
    [DataContract]
    public class UserEventsCollectionResponse
    {
        /// <summary>
        /// Gets or sets the <see cref="IUserEventsCollectionPage"/> value.
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false, IsRequired = false)]
        public IUserEventsCollectionPage Value { get; set; }

        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    }
}
