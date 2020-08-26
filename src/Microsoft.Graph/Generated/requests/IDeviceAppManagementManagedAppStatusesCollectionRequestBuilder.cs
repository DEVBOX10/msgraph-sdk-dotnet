// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IDeviceAppManagementManagedAppStatusesCollectionRequestBuilder.
    /// </summary>
    public partial interface IDeviceAppManagementManagedAppStatusesCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IDeviceAppManagementManagedAppStatusesCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IDeviceAppManagementManagedAppStatusesCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IManagedAppStatusRequestBuilder"/> for the specified ManagedAppStatus.
        /// </summary>
        /// <param name="id">The ID for the ManagedAppStatus.</param>
        /// <returns>The <see cref="IManagedAppStatusRequestBuilder"/>.</returns>
        IManagedAppStatusRequestBuilder this[string id] { get; }

        
    }
}
