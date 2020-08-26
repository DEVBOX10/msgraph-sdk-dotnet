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
    /// The enum DefenderMonitorFileActivity.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum DefenderMonitorFileActivity
    {
    
        /// <summary>
        /// User Defined
        /// </summary>
        UserDefined = 0,
	
        /// <summary>
        /// Disable
        /// </summary>
        Disable = 1,
	
        /// <summary>
        /// Monitor All Files
        /// </summary>
        MonitorAllFiles = 2,
	
        /// <summary>
        /// Monitor Incoming Files Only
        /// </summary>
        MonitorIncomingFilesOnly = 3,
	
        /// <summary>
        /// Monitor Outgoing Files Only
        /// </summary>
        MonitorOutgoingFilesOnly = 4,
	
    }
}
