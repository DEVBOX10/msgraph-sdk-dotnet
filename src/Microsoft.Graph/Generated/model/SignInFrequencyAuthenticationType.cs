// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum SignInFrequencyAuthenticationType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SignInFrequencyAuthenticationType
    {
    
        /// <summary>
        /// Primary And Secondary Authentication
        /// </summary>
        PrimaryAndSecondaryAuthentication = 0,
	
        /// <summary>
        /// Secondary Authentication
        /// </summary>
        SecondaryAuthentication = 1,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 2,
	
    }
}
