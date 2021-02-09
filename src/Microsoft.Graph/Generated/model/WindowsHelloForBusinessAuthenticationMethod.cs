// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Windows Hello For Business Authentication Method.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WindowsHelloForBusinessAuthenticationMethod : AuthenticationMethod
    {
    
		///<summary>
		/// The WindowsHelloForBusinessAuthenticationMethod constructor
		///</summary>
        public WindowsHelloForBusinessAuthenticationMethod()
        {
            this.ODataType = "microsoft.graph.windowsHelloForBusinessAuthenticationMethod";
        }
	
        /// <summary>
        /// Gets or sets created date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets key strength.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "keyStrength", Required = Newtonsoft.Json.Required.Default)]
        public AuthenticationMethodKeyStrength? KeyStrength { get; set; }
    
        /// <summary>
        /// Gets or sets device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "device", Required = Newtonsoft.Json.Required.Default)]
        public Device Device { get; set; }
    
    }
}

