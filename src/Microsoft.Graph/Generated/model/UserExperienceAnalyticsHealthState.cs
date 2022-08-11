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
    /// The enum UserExperienceAnalyticsHealthState.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum UserExperienceAnalyticsHealthState
    {
    
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,
	
        /// <summary>
        /// Insufficient Data
        /// </summary>
        InsufficientData = 1,
	
        /// <summary>
        /// Needs Attention
        /// </summary>
        NeedsAttention = 2,
	
        /// <summary>
        /// Meeting Goals
        /// </summary>
        MeetingGoals = 3,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 4,
	
    }
}
