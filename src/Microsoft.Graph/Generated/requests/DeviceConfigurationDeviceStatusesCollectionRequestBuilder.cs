// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type DeviceConfigurationDeviceStatusesCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceConfigurationDeviceStatusesCollectionRequestBuilder : BaseRequestBuilder, IDeviceConfigurationDeviceStatusesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceConfigurationDeviceStatusesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceConfigurationDeviceStatusesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceConfigurationDeviceStatusesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceConfigurationDeviceStatusesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceConfigurationDeviceStatusesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDeviceConfigurationDeviceStatusRequestBuilder"/> for the specified DeviceConfigurationDeviceConfigurationDeviceStatus.
        /// </summary>
        /// <param name="id">The ID for the DeviceConfigurationDeviceConfigurationDeviceStatus.</param>
        /// <returns>The <see cref="IDeviceConfigurationDeviceStatusRequestBuilder"/>.</returns>
        public IDeviceConfigurationDeviceStatusRequestBuilder this[string id]
        {
            get
            {
                return new DeviceConfigurationDeviceStatusRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
