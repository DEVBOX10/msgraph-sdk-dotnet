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
    /// The type UserEventsCollectionRequestBuilder.
    /// </summary>
    public partial class UserEventsCollectionRequestBuilder : BaseRequestBuilder, IUserEventsCollectionRequestBuilder
    {  
        /// <summary>
        /// Constructs a new UserEventsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public UserEventsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IUserEventsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IUserEventsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new UserEventsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IEventRequestBuilder"/> for the specified UserEvent.
        /// </summary>
        /// <param name="id">The ID for the UserEvent.</param>
        /// <returns>The <see cref="IEventRequestBuilder"/>.</returns>
        public IEventRequestBuilder this[string id]
        {
            get
            {
                return new EventRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }
    }
}
