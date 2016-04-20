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
    /// The type DeviceRequestBuilder.
    /// </summary>
    public partial class DeviceRequestBuilder : DirectoryObjectRequestBuilder, IDeviceRequestBuilder
    {

        /// <summary>
        /// Constructs a new DeviceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IDeviceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IDeviceRequest Request(IEnumerable<Option> options)
        {
            return new DeviceRequest(this.RequestUrl, this.Client, options);
        }
        
        /// <summary>
        /// Gets the request builder for RegisteredOwners.
        /// </summary>
        /// <returns>The <see cref="IDeviceRegisteredOwnersCollectionWithReferencesRequestBuilder"/>.</returns>
        public IDeviceRegisteredOwnersCollectionWithReferencesRequestBuilder RegisteredOwners
        {
            get
            {
                return new DeviceRegisteredOwnersCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("registeredOwners"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for RegisteredUsers.
        /// </summary>
        /// <returns>The <see cref="IDeviceRegisteredUsersCollectionWithReferencesRequestBuilder"/>.</returns>
        public IDeviceRegisteredUsersCollectionWithReferencesRequestBuilder RegisteredUsers
        {
            get
            {
                return new DeviceRegisteredUsersCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("registeredUsers"), this.Client);
            }
        }
    
    }
}
