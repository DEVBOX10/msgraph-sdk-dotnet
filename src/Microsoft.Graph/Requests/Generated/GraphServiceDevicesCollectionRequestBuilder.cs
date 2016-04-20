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
    /// The type GraphServiceDevicesCollectionRequestBuilder.
    /// </summary>
    public partial class GraphServiceDevicesCollectionRequestBuilder : BaseRequestBuilder, IGraphServiceDevicesCollectionRequestBuilder
    {  
        /// <summary>
        /// Constructs a new GraphServiceDevicesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GraphServiceDevicesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGraphServiceDevicesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGraphServiceDevicesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new GraphServiceDevicesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDeviceRequestBuilder"/> for the specified GraphServiceDevice.
        /// </summary>
        /// <param name="id">The ID for the GraphServiceDevice.</param>
        /// <returns>The <see cref="IDeviceRequestBuilder"/>.</returns>
        public IDeviceRequestBuilder this[string id]
        {
            get
            {
                return new DeviceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }
    }
}
