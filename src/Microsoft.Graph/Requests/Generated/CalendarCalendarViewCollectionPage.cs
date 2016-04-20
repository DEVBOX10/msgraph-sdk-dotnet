// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    
    using Microsoft.Graph.Core;
    
    /// <summary>
    /// The type CalendarCalendarViewCollectionPage.
    /// </summary>
    public partial class CalendarCalendarViewCollectionPage : CollectionPage<Event>, ICalendarCalendarViewCollectionPage
    {
        /// <summary>
        /// Gets the next page <see cref="ICalendarCalendarViewCollectionRequest"/> instance.
        /// </summary>
        public ICalendarCalendarViewCollectionRequest NextPageRequest { get; private set; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        public void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString)
        {
            if (!string.IsNullOrEmpty(nextPageLinkString))
            {
                this.NextPageRequest = new CalendarCalendarViewCollectionRequest(
                    nextPageLinkString,
                    client,
                    null);
            }
        }
    }
}
