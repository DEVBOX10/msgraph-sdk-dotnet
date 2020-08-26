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
    /// The type DeviceManagementDeviceEnrollmentConfigurationsCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceManagementDeviceEnrollmentConfigurationsCollectionRequestBuilder : BaseRequestBuilder, IDeviceManagementDeviceEnrollmentConfigurationsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceManagementDeviceEnrollmentConfigurationsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceManagementDeviceEnrollmentConfigurationsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceManagementDeviceEnrollmentConfigurationsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceManagementDeviceEnrollmentConfigurationsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceManagementDeviceEnrollmentConfigurationsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDeviceEnrollmentConfigurationRequestBuilder"/> for the specified DeviceManagementDeviceEnrollmentConfiguration.
        /// </summary>
        /// <param name="id">The ID for the DeviceManagementDeviceEnrollmentConfiguration.</param>
        /// <returns>The <see cref="IDeviceEnrollmentConfigurationRequestBuilder"/>.</returns>
        public IDeviceEnrollmentConfigurationRequestBuilder this[string id]
        {
            get
            {
                return new DeviceEnrollmentConfigurationRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
