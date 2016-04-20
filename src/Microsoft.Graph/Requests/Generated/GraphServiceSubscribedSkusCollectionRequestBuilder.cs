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
    /// The type GraphServiceSubscribedSkusCollectionRequestBuilder.
    /// </summary>
    public partial class GraphServiceSubscribedSkusCollectionRequestBuilder : BaseRequestBuilder, IGraphServiceSubscribedSkusCollectionRequestBuilder
    {  
        /// <summary>
        /// Constructs a new GraphServiceSubscribedSkusCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GraphServiceSubscribedSkusCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGraphServiceSubscribedSkusCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGraphServiceSubscribedSkusCollectionRequest Request(IEnumerable<Option> options)
        {
            return new GraphServiceSubscribedSkusCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ISubscribedSkuRequestBuilder"/> for the specified GraphServiceSubscribedSku.
        /// </summary>
        /// <param name="id">The ID for the GraphServiceSubscribedSku.</param>
        /// <returns>The <see cref="ISubscribedSkuRequestBuilder"/>.</returns>
        public ISubscribedSkuRequestBuilder this[string id]
        {
            get
            {
                return new SubscribedSkuRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }
    }
}
