// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum AndroidRequiredPasswordType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum AndroidRequiredPasswordType
    {
    
        /// <summary>
        /// Device Default
        /// </summary>
        DeviceDefault = 0,
	
        /// <summary>
        /// Alphabetic
        /// </summary>
        Alphabetic = 1,
	
        /// <summary>
        /// Alphanumeric
        /// </summary>
        Alphanumeric = 2,
	
        /// <summary>
        /// Alphanumeric With Symbols
        /// </summary>
        AlphanumericWithSymbols = 3,
	
        /// <summary>
        /// Low Security Biometric
        /// </summary>
        LowSecurityBiometric = 4,
	
        /// <summary>
        /// Numeric
        /// </summary>
        Numeric = 5,
	
        /// <summary>
        /// Numeric Complex
        /// </summary>
        NumericComplex = 6,
	
        /// <summary>
        /// Any
        /// </summary>
        Any = 7,
	
    }
}
