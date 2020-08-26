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
    /// The enum AndroidWorkProfileRequiredPasswordType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum AndroidWorkProfileRequiredPasswordType
    {
    
        /// <summary>
        /// Device Default
        /// </summary>
        DeviceDefault = 0,
	
        /// <summary>
        /// Low Security Biometric
        /// </summary>
        LowSecurityBiometric = 1,
	
        /// <summary>
        /// Required
        /// </summary>
        Required = 2,
	
        /// <summary>
        /// At Least Numeric
        /// </summary>
        AtLeastNumeric = 3,
	
        /// <summary>
        /// Numeric Complex
        /// </summary>
        NumericComplex = 4,
	
        /// <summary>
        /// At Least Alphabetic
        /// </summary>
        AtLeastAlphabetic = 5,
	
        /// <summary>
        /// At Least Alphanumeric
        /// </summary>
        AtLeastAlphanumeric = 6,
	
        /// <summary>
        /// Alphanumeric With Symbols
        /// </summary>
        AlphanumericWithSymbols = 7,
	
    }
}
