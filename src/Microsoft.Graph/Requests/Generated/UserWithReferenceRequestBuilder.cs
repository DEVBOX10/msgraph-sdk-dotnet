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
    /// The type UserWithReferenceRequestBuilder.
    /// </summary>
    public partial class UserWithReferenceRequestBuilder : BaseRequestBuilder, IUserWithReferenceRequestBuilder
    {

        /// <summary>
        /// Constructs a new UserWithReferenceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public UserWithReferenceRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IUserWithReferenceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IUserWithReferenceRequest Request(IEnumerable<Option> options)
        {
            return new UserWithReferenceRequest(this.RequestUrl, this.Client, options);
        }
        
        /// <summary>
        /// Gets the request builder for the reference of the user.
        /// </summary>
        /// <returns>The <see cref="IUserReferenceRequestBuilder"/>.</returns>
        public IUserReferenceRequestBuilder Reference
        {
            get
            {
                return new UserReferenceRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
