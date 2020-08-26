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
    /// The type WorkbookFunctionsNorm_InvRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookFunctionsNorm_InvRequestBody
    {
    
        /// <summary>
        /// Gets or sets Probability.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "probability", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Probability { get; set; }
    
        /// <summary>
        /// Gets or sets Mean.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mean", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Mean { get; set; }
    
        /// <summary>
        /// Gets or sets StandardDev.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "standardDev", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken StandardDev { get; set; }
    
    }
}
