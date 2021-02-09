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
    /// The type Authentication.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Authentication : Entity
    {
    
		///<summary>
		/// The Authentication constructor
		///</summary>
        public Authentication()
        {
            this.ODataType = "microsoft.graph.authentication";
        }
	
        /// <summary>
        /// Gets or sets fido2methods.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fido2Methods", Required = Newtonsoft.Json.Required.Default)]
        public IAuthenticationFido2MethodsCollectionPage Fido2Methods { get; set; }
    
        /// <summary>
        /// Gets or sets methods.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "methods", Required = Newtonsoft.Json.Required.Default)]
        public IAuthenticationMethodsCollectionPage Methods { get; set; }
    
        /// <summary>
        /// Gets or sets microsoft authenticator methods.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "microsoftAuthenticatorMethods", Required = Newtonsoft.Json.Required.Default)]
        public IAuthenticationMicrosoftAuthenticatorMethodsCollectionPage MicrosoftAuthenticatorMethods { get; set; }
    
        /// <summary>
        /// Gets or sets windows hello for business methods.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "windowsHelloForBusinessMethods", Required = Newtonsoft.Json.Required.Default)]
        public IAuthenticationWindowsHelloForBusinessMethodsCollectionPage WindowsHelloForBusinessMethods { get; set; }
    
    }
}

