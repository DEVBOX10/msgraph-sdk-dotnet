// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type UserTranslateExchangeIdsRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class UserTranslateExchangeIdsRequestBody
    {
    
        /// <summary>
        /// Gets or sets InputIds.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "InputIds", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> InputIds { get; set; }
    
        /// <summary>
        /// Gets or sets TargetIdType.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "TargetIdType", Required = Newtonsoft.Json.Required.Default)]
        public ExchangeIdFormat TargetIdType { get; set; }
    
        /// <summary>
        /// Gets or sets SourceIdType.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "SourceIdType", Required = Newtonsoft.Json.Required.Default)]
        public ExchangeIdFormat SourceIdType { get; set; }
    
    }
}
