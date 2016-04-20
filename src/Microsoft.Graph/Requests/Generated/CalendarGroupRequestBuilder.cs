// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    
    using Microsoft.Graph.Core;

    /// <summary>
    /// The type CalendarGroupRequestBuilder.
    /// </summary>
    public partial class CalendarGroupRequestBuilder : EntityRequestBuilder, ICalendarGroupRequestBuilder
    {

        /// <summary>
        /// Constructs a new CalendarGroupRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public CalendarGroupRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new ICalendarGroupRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new ICalendarGroupRequest Request(IEnumerable<Option> options)
        {
            return new CalendarGroupRequest(this.RequestUrl, this.Client, options);
        }
        
        /// <summary>
        /// Gets the request builder for Calendars.
        /// </summary>
        /// <returns>The <see cref="ICalendarGroupCalendarsCollectionRequestBuilder"/>.</returns>
        public ICalendarGroupCalendarsCollectionRequestBuilder Calendars
        {
            get
            {
                return new CalendarGroupCalendarsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("calendars"), this.Client);
            }
        }
    
    }
}
