// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Threat Assessment Request.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ThreatAssessmentRequestObject : Entity
    {
    
		///<summary>
		/// The internal ThreatAssessmentRequest constructor
		///</summary>
        protected internal ThreatAssessmentRequestObject()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets created date time.
        /// The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets content type.
        /// The content type of threat assessment. Possible values are: mail, url, file.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contentType", Required = Newtonsoft.Json.Required.Default)]
        public ThreatAssessmentContentType? ContentType { get; set; }
    
        /// <summary>
        /// Gets or sets expected assessment.
        /// The expected assessment from submitter. Possible values are: block, unblock.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "expectedAssessment", Required = Newtonsoft.Json.Required.Default)]
        public ThreatExpectedAssessment? ExpectedAssessment { get; set; }
    
        /// <summary>
        /// Gets or sets category.
        /// The threat category. Possible values are: spam, phishing, malware.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "category", Required = Newtonsoft.Json.Required.Default)]
        public ThreatCategory? Category { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// The assessment process status. Possible values are: pending, completed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status", Required = Newtonsoft.Json.Required.Default)]
        public ThreatAssessmentStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets request source.
        /// The source of the threat assessment request. Possible values are: user, administrator.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "requestSource", Required = Newtonsoft.Json.Required.Default)]
        public ThreatAssessmentRequestSource? RequestSource { get; set; }
    
        /// <summary>
        /// Gets or sets created by.
        /// The threat assessment request creator.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdBy", Required = Newtonsoft.Json.Required.Default)]
        public IdentitySet CreatedBy { get; set; }
    
        /// <summary>
        /// Gets or sets results.
        /// A collection of threat assessment results. Read-only. By default, a GET /threatAssessmentRequests/{id} does not return this property unless you apply $expand on it.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "results", Required = Newtonsoft.Json.Required.Default)]
        public IThreatAssessmentRequestResultsCollectionPage Results { get; set; }
    
    }
}

