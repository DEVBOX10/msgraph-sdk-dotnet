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
    /// The type DeviceManagementWindowsInformationProtectionAppLearningSummariesCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceManagementWindowsInformationProtectionAppLearningSummariesCollectionRequestBuilder : BaseRequestBuilder, IDeviceManagementWindowsInformationProtectionAppLearningSummariesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceManagementWindowsInformationProtectionAppLearningSummariesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceManagementWindowsInformationProtectionAppLearningSummariesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceManagementWindowsInformationProtectionAppLearningSummariesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceManagementWindowsInformationProtectionAppLearningSummariesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceManagementWindowsInformationProtectionAppLearningSummariesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IWindowsInformationProtectionAppLearningSummaryRequestBuilder"/> for the specified DeviceManagementWindowsInformationProtectionAppLearningSummary.
        /// </summary>
        /// <param name="id">The ID for the DeviceManagementWindowsInformationProtectionAppLearningSummary.</param>
        /// <returns>The <see cref="IWindowsInformationProtectionAppLearningSummaryRequestBuilder"/>.</returns>
        public IWindowsInformationProtectionAppLearningSummaryRequestBuilder this[string id]
        {
            get
            {
                return new WindowsInformationProtectionAppLearningSummaryRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
