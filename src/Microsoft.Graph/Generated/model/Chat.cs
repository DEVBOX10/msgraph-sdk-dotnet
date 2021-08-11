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
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Chat.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<Chat>))]
    public partial class Chat : Entity
    {
    
        /// <summary>
        /// Gets or sets chat type.
        /// Specifies the type of chat. Possible values are:group, oneOnOne and meeting.
        /// </summary>
        [JsonPropertyName("chatType")]
        public ChatType? ChatType { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// Date and time at which the chat was created. Read-only.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last updated date time.
        /// Date and time at which the chat was renamed or list of members were last changed. Read-only.
        /// </summary>
        [JsonPropertyName("lastUpdatedDateTime")]
        public DateTimeOffset? LastUpdatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets topic.
        /// (Optional) Subject or topic for the chat. Only available for group chats.
        /// </summary>
        [JsonPropertyName("topic")]
        public string Topic { get; set; }
    
        /// <summary>
        /// Gets or sets installed apps.
        /// A collection of all the apps in the chat. Nullable.
        /// </summary>
        [JsonPropertyName("installedApps")]
        public IChatInstalledAppsCollectionPage InstalledApps { get; set; }

        /// <summary>
        /// Gets or sets installedAppsNextLink.
        /// </summary>
        [JsonPropertyName("installedApps@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string InstalledAppsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets members.
        /// A collection of all the members in the chat. Nullable.
        /// </summary>
        [JsonPropertyName("members")]
        public IChatMembersCollectionPage Members { get; set; }

        /// <summary>
        /// Gets or sets membersNextLink.
        /// </summary>
        [JsonPropertyName("members@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string MembersNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets messages.
        /// A collection of all the messages in the chat. Nullable.
        /// </summary>
        [JsonPropertyName("messages")]
        public IChatMessagesCollectionPage Messages { get; set; }

        /// <summary>
        /// Gets or sets messagesNextLink.
        /// </summary>
        [JsonPropertyName("messages@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string MessagesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets tabs.
        /// </summary>
        [JsonPropertyName("tabs")]
        public IChatTabsCollectionPage Tabs { get; set; }

        /// <summary>
        /// Gets or sets tabsNextLink.
        /// </summary>
        [JsonPropertyName("tabs@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string TabsNextLink { get; set; }
    
    }
}

