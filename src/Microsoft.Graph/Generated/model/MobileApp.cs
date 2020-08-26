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
    /// The type Mobile App.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class MobileApp : Entity
    {
    
		///<summary>
		/// The internal MobileApp constructor
		///</summary>
        protected internal MobileApp()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets display name.
        /// The admin provided or imported title of the app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// The description of the app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets publisher.
        /// The publisher of the app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "publisher", Required = Newtonsoft.Json.Required.Default)]
        public string Publisher { get; set; }
    
        /// <summary>
        /// Gets or sets large icon.
        /// The large icon, to be displayed in the app details and used for upload of the icon.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "largeIcon", Required = Newtonsoft.Json.Required.Default)]
        public MimeContent LargeIcon { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// The date and time the app was created.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// The date and time the app was last modified.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets is featured.
        /// The value indicating whether the app is marked as featured by the admin.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isFeatured", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsFeatured { get; set; }
    
        /// <summary>
        /// Gets or sets privacy information url.
        /// The privacy statement Url.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "privacyInformationUrl", Required = Newtonsoft.Json.Required.Default)]
        public string PrivacyInformationUrl { get; set; }
    
        /// <summary>
        /// Gets or sets information url.
        /// The more information Url.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "informationUrl", Required = Newtonsoft.Json.Required.Default)]
        public string InformationUrl { get; set; }
    
        /// <summary>
        /// Gets or sets owner.
        /// The owner of the app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "owner", Required = Newtonsoft.Json.Required.Default)]
        public string Owner { get; set; }
    
        /// <summary>
        /// Gets or sets developer.
        /// The developer of the app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "developer", Required = Newtonsoft.Json.Required.Default)]
        public string Developer { get; set; }
    
        /// <summary>
        /// Gets or sets notes.
        /// Notes for the app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "notes", Required = Newtonsoft.Json.Required.Default)]
        public string Notes { get; set; }
    
        /// <summary>
        /// Gets or sets publishing state.
        /// The publishing state for the app. The app cannot be assigned unless the app is published. Possible values are: notPublished, processing, published.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "publishingState", Required = Newtonsoft.Json.Required.Default)]
        public MobileAppPublishingState? PublishingState { get; set; }
    
        /// <summary>
        /// Gets or sets categories.
        /// The list of categories for this app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "categories", Required = Newtonsoft.Json.Required.Default)]
        public IMobileAppCategoriesCollectionWithReferencesPage Categories { get; set; }
    
        /// <summary>
        /// Gets or sets assignments.
        /// The list of group assignments for this mobile app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignments", Required = Newtonsoft.Json.Required.Default)]
        public IMobileAppAssignmentsCollectionPage Assignments { get; set; }
    
    }
}

