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
    /// The type Thumbnail.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class Thumbnail
    {
    
        /// <summary>
        /// Gets or sets content.
        /// </summary>
        [DataMember(Name = "content", EmitDefaultValue = false, IsRequired = false)]
        public Stream Content { get; set; }
    
        /// <summary>
        /// Gets or sets height.
        /// </summary>
        [DataMember(Name = "height", EmitDefaultValue = false, IsRequired = false)]
        public Int32? Height { get; set; }
    
        /// <summary>
        /// Gets or sets url.
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = false, IsRequired = false)]
        public string Url { get; set; }
    
        /// <summary>
        /// Gets or sets width.
        /// </summary>
        [DataMember(Name = "width", EmitDefaultValue = false, IsRequired = false)]
        public Int32? Width { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}
