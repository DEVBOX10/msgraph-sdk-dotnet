// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    
    using Microsoft.Graph.Core;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Quota.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class Quota
    {
    
        /// <summary>
        /// Gets or sets deleted.
        /// </summary>
        [DataMember(Name = "deleted", EmitDefaultValue = false, IsRequired = false)]
        public Int64? Deleted { get; set; }
    
        /// <summary>
        /// Gets or sets remaining.
        /// </summary>
        [DataMember(Name = "remaining", EmitDefaultValue = false, IsRequired = false)]
        public Int64? Remaining { get; set; }
    
        /// <summary>
        /// Gets or sets state.
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false, IsRequired = false)]
        public string State { get; set; }
    
        /// <summary>
        /// Gets or sets total.
        /// </summary>
        [DataMember(Name = "total", EmitDefaultValue = false, IsRequired = false)]
        public Int64? Total { get; set; }
    
        /// <summary>
        /// Gets or sets used.
        /// </summary>
        [DataMember(Name = "used", EmitDefaultValue = false, IsRequired = false)]
        public Int64? Used { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}
