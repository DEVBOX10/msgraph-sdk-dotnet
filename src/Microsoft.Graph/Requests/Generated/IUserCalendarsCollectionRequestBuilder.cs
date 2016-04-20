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
    /// The interface IUserCalendarsCollectionRequestBuilder.
    /// </summary>
    public partial interface IUserCalendarsCollectionRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IUserCalendarsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IUserCalendarsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="ICalendarRequestBuilder"/> for the specified Calendar.
        /// </summary>
        /// <param name="id">The ID for the Calendar.</param>
        /// <returns>The <see cref="ICalendarRequestBuilder"/>.</returns>
        ICalendarRequestBuilder this[string id] { get; }
    }
}
