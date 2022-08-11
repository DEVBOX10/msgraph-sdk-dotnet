// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IGraphServiceDevicesCollectionRequestBuilder.
    /// </summary>
    public partial interface IGraphServiceDevicesCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IGraphServiceDevicesCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IGraphServiceDevicesCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IDeviceRequestBuilder"/> for the specified Device.
        /// </summary>
        /// <param name="id">The ID for the Device.</param>
        /// <returns>The <see cref="IDeviceRequestBuilder"/>.</returns>
        IDeviceRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for DeviceDelta.
        /// </summary>
        /// <returns>The <see cref="IDeviceDeltaRequestBuilder"/>.</returns>
        IDeviceDeltaRequestBuilder Delta();
    }
}
