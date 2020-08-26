// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Cloud Communications.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class CloudCommunications : Entity
    {
    
		///<summary>
		/// The CloudCommunications constructor
		///</summary>
        public CloudCommunications()
        {
            this.ODataType = "microsoft.graph.cloudCommunications";
        }
	
        /// <summary>
        /// Gets or sets calls.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "calls", Required = Newtonsoft.Json.Required.Default)]
        public ICloudCommunicationsCallsCollectionPage Calls { get; set; }
    
        /// <summary>
        /// Gets or sets call records.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "callRecords", Required = Newtonsoft.Json.Required.Default)]
        public ICloudCommunicationsCallRecordsCollectionPage CallRecords { get; set; }
    
        /// <summary>
        /// Gets or sets online meetings.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "onlineMeetings", Required = Newtonsoft.Json.Required.Default)]
        public ICloudCommunicationsOnlineMeetingsCollectionPage OnlineMeetings { get; set; }
    
    }
}

