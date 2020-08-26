// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type EventRequestBuilder.
    /// </summary>
    public partial class EventRequestBuilder : OutlookItemRequestBuilder, IEventRequestBuilder
    {

        /// <summary>
        /// Constructs a new EventRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public EventRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IEventRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IEventRequest Request(IEnumerable<Option> options)
        {
            return new EventRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Attachments.
        /// </summary>
        /// <returns>The <see cref="IEventAttachmentsCollectionRequestBuilder"/>.</returns>
        public IEventAttachmentsCollectionRequestBuilder Attachments
        {
            get
            {
                return new EventAttachmentsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("attachments"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for SingleValueExtendedProperties.
        /// </summary>
        /// <returns>The <see cref="IEventSingleValueExtendedPropertiesCollectionRequestBuilder"/>.</returns>
        public IEventSingleValueExtendedPropertiesCollectionRequestBuilder SingleValueExtendedProperties
        {
            get
            {
                return new EventSingleValueExtendedPropertiesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("singleValueExtendedProperties"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for MultiValueExtendedProperties.
        /// </summary>
        /// <returns>The <see cref="IEventMultiValueExtendedPropertiesCollectionRequestBuilder"/>.</returns>
        public IEventMultiValueExtendedPropertiesCollectionRequestBuilder MultiValueExtendedProperties
        {
            get
            {
                return new EventMultiValueExtendedPropertiesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("multiValueExtendedProperties"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Calendar.
        /// </summary>
        /// <returns>The <see cref="ICalendarRequestBuilder"/>.</returns>
        public ICalendarRequestBuilder Calendar
        {
            get
            {
                return new CalendarRequestBuilder(this.AppendSegmentToRequestUrl("calendar"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Instances.
        /// </summary>
        /// <returns>The <see cref="IEventInstancesCollectionRequestBuilder"/>.</returns>
        public IEventInstancesCollectionRequestBuilder Instances
        {
            get
            {
                return new EventInstancesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("instances"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Extensions.
        /// </summary>
        /// <returns>The <see cref="IEventExtensionsCollectionRequestBuilder"/>.</returns>
        public IEventExtensionsCollectionRequestBuilder Extensions
        {
            get
            {
                return new EventExtensionsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("extensions"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for EventDismissReminder.
        /// </summary>
        /// <returns>The <see cref="IEventDismissReminderRequestBuilder"/>.</returns>
        public IEventDismissReminderRequestBuilder DismissReminder()
        {
            return new EventDismissReminderRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.dismissReminder"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for EventSnoozeReminder.
        /// </summary>
        /// <returns>The <see cref="IEventSnoozeReminderRequestBuilder"/>.</returns>
        public IEventSnoozeReminderRequestBuilder SnoozeReminder(
            DateTimeTimeZone NewReminderTime)
        {
            return new EventSnoozeReminderRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.snoozeReminder"),
                this.Client,
                NewReminderTime);
        }

        /// <summary>
        /// Gets the request builder for EventAccept.
        /// </summary>
        /// <returns>The <see cref="IEventAcceptRequestBuilder"/>.</returns>
        public IEventAcceptRequestBuilder Accept(
            string Comment = null,
            bool? SendResponse = null)
        {
            return new EventAcceptRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.accept"),
                this.Client,
                Comment,
                SendResponse);
        }

        /// <summary>
        /// Gets the request builder for EventDecline.
        /// </summary>
        /// <returns>The <see cref="IEventDeclineRequestBuilder"/>.</returns>
        public IEventDeclineRequestBuilder Decline(
            string Comment = null,
            bool? SendResponse = null)
        {
            return new EventDeclineRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.decline"),
                this.Client,
                Comment,
                SendResponse);
        }

        /// <summary>
        /// Gets the request builder for EventTentativelyAccept.
        /// </summary>
        /// <returns>The <see cref="IEventTentativelyAcceptRequestBuilder"/>.</returns>
        public IEventTentativelyAcceptRequestBuilder TentativelyAccept(
            string Comment = null,
            bool? SendResponse = null)
        {
            return new EventTentativelyAcceptRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.tentativelyAccept"),
                this.Client,
                Comment,
                SendResponse);
        }
    
    }
}
