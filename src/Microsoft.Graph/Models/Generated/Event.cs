// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Event.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Event : OutlookItem
    {
    
        /// <summary>
        /// Gets or sets original start time zone.
        /// The start time zone that was set when the event was created. A value of tzone://Microsoft/Custom indicates that a legacy custom time zone was set in desktop Outlook.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "originalStartTimeZone", Required = Newtonsoft.Json.Required.Default)]
        public string OriginalStartTimeZone { get; set; }
    
        /// <summary>
        /// Gets or sets original end time zone.
        /// The end time zone that was set when the event was created. A value of tzone://Microsoft/Customindicates that a legacy custom time zone was set in desktop Outlook.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "originalEndTimeZone", Required = Newtonsoft.Json.Required.Default)]
        public string OriginalEndTimeZone { get; set; }
    
        /// <summary>
        /// Gets or sets response status.
        /// Indicates the type of response sent in response to an event message.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "responseStatus", Required = Newtonsoft.Json.Required.Default)]
        public ResponseStatus ResponseStatus { get; set; }
    
        /// <summary>
        /// Gets or sets i cal uid.
        /// A unique identifier that is shared by all instances of an event across different calendars.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "iCalUId", Required = Newtonsoft.Json.Required.Default)]
        public string ICalUId { get; set; }
    
        /// <summary>
        /// Gets or sets reminder minutes before start.
        /// The number of minutes before the event start time that the reminder alert occurs.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reminderMinutesBeforeStart", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ReminderMinutesBeforeStart { get; set; }
    
        /// <summary>
        /// Gets or sets is reminder on.
        /// Set to true if an alert is set to remind the user of the event.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isReminderOn", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsReminderOn { get; set; }
    
        /// <summary>
        /// Gets or sets has attachments.
        /// Set to true if the event has attachments.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "hasAttachments", Required = Newtonsoft.Json.Required.Default)]
        public bool? HasAttachments { get; set; }
    
        /// <summary>
        /// Gets or sets subject.
        /// The text of the event's subject line.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subject", Required = Newtonsoft.Json.Required.Default)]
        public string Subject { get; set; }
    
        /// <summary>
        /// Gets or sets body.
        /// The body of the message associated with the event. It can be in HTML or text format.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "body", Required = Newtonsoft.Json.Required.Default)]
        public ItemBody Body { get; set; }
    
        /// <summary>
        /// Gets or sets body preview.
        /// The preview of the message associated with the event. It is in text format.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bodyPreview", Required = Newtonsoft.Json.Required.Default)]
        public string BodyPreview { get; set; }
    
        /// <summary>
        /// Gets or sets importance.
        /// The importance of the event: Low = 0, Normal = 1, High = 2. Possible values are: Low, Normal, High.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "importance", Required = Newtonsoft.Json.Required.Default)]
        public Importance? Importance { get; set; }
    
        /// <summary>
        /// Gets or sets sensitivity.
        /// Possible values are: Normal, Personal, Private, Confidential.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sensitivity", Required = Newtonsoft.Json.Required.Default)]
        public Sensitivity? Sensitivity { get; set; }
    
        /// <summary>
        /// Gets or sets start.
        /// The date, time, and time zone that the event starts.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "start", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeTimeZone Start { get; set; }
    
        /// <summary>
        /// Gets or sets original start.
        /// The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "originalStart", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? OriginalStart { get; set; }
    
        /// <summary>
        /// Gets or sets end.
        /// The date, time, and time zone that the event ends.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "end", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeTimeZone End { get; set; }
    
        /// <summary>
        /// Gets or sets location.
        /// The location of the event.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "location", Required = Newtonsoft.Json.Required.Default)]
        public Location Location { get; set; }
    
        /// <summary>
        /// Gets or sets is all day.
        /// Set to true if the event lasts all day.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isAllDay", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsAllDay { get; set; }
    
        /// <summary>
        /// Gets or sets is cancelled.
        /// Set to true if the event has been canceled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isCancelled", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsCancelled { get; set; }
    
        /// <summary>
        /// Gets or sets is organizer.
        /// Set to true if the message sender is also the organizer.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isOrganizer", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsOrganizer { get; set; }
    
        /// <summary>
        /// Gets or sets recurrence.
        /// The recurrence pattern for the event.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recurrence", Required = Newtonsoft.Json.Required.Default)]
        public PatternedRecurrence Recurrence { get; set; }
    
        /// <summary>
        /// Gets or sets response requested.
        /// Set to true if the sender would like a response when the event is accepted or declined.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "responseRequested", Required = Newtonsoft.Json.Required.Default)]
        public bool? ResponseRequested { get; set; }
    
        /// <summary>
        /// Gets or sets series master id.
        /// The categories assigned to the item.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "seriesMasterId", Required = Newtonsoft.Json.Required.Default)]
        public string SeriesMasterId { get; set; }
    
        /// <summary>
        /// Gets or sets show as.
        /// The status to show. Possible values are: Free, Tentative, Busy, Oof, WorkingElsewhere, Unknown.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "showAs", Required = Newtonsoft.Json.Required.Default)]
        public FreeBusyStatus? ShowAs { get; set; }
    
        /// <summary>
        /// Gets or sets type.
        /// The event type. Possible values are: SingleInstance, Occurrence, Exception, SeriesMaster. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "type", Required = Newtonsoft.Json.Required.Default)]
        public EventType? Type { get; set; }
    
        /// <summary>
        /// Gets or sets attendees.
        /// The collection of attendees for the event.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "attendees", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<Attendee> Attendees { get; set; }
    
        /// <summary>
        /// Gets or sets organizer.
        /// The organizer of the event.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "organizer", Required = Newtonsoft.Json.Required.Default)]
        public Recipient Organizer { get; set; }
    
        /// <summary>
        /// Gets or sets web link.
        /// The URL to open the event in Outlook Web App.The event will open in the browser if you are logged in to your mailbox via Outlook Web App. You will be prompted to login if you are not already logged in with the browser.This URL can be accessed from within an iFrame.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "webLink", Required = Newtonsoft.Json.Required.Default)]
        public string WebLink { get; set; }
    
        /// <summary>
        /// Gets or sets online meeting url.
        /// A URL for an online meeting.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "onlineMeetingUrl", Required = Newtonsoft.Json.Required.Default)]
        public string OnlineMeetingUrl { get; set; }
    
        /// <summary>
        /// Gets or sets calendar.
        /// The calendar that contains the event. Navigation property. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "calendar", Required = Newtonsoft.Json.Required.Default)]
        public Calendar Calendar { get; set; }
    
        /// <summary>
        /// Gets or sets instances.
        /// The instances of the event. Navigation property. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "instances", Required = Newtonsoft.Json.Required.Default)]
        public IEventInstancesCollectionPage Instances { get; set; }
    
        /// <summary>
        /// Gets or sets extensions.
        /// The collection of open extensions defined for the event. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "extensions", Required = Newtonsoft.Json.Required.Default)]
        public IEventExtensionsCollectionPage Extensions { get; set; }
    
        /// <summary>
        /// Gets or sets attachments.
        /// The collection of fileAttachment and itemAttachment attachments for the event. Navigation property. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "attachments", Required = Newtonsoft.Json.Required.Default)]
        public IEventAttachmentsCollectionPage Attachments { get; set; }
    
        /// <summary>
        /// Gets or sets single value extended properties.
        /// The collection of single-value extended properties defined for the event. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "singleValueExtendedProperties", Required = Newtonsoft.Json.Required.Default)]
        public IEventSingleValueExtendedPropertiesCollectionPage SingleValueExtendedProperties { get; set; }
    
        /// <summary>
        /// Gets or sets multi value extended properties.
        /// The collection of multi-value extended properties defined for the event. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "multiValueExtendedProperties", Required = Newtonsoft.Json.Required.Default)]
        public IEventMultiValueExtendedPropertiesCollectionPage MultiValueExtendedProperties { get; set; }
    
    }
}

