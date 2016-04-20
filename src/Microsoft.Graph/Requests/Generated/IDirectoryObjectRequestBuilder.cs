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
    /// The interface IDirectoryObjectRequestBuilder.
    /// </summary>
    public partial interface IDirectoryObjectRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IDirectoryObjectRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IDirectoryObjectRequest Request(IEnumerable<Option> options);
        
        /// <summary>
        /// Gets the request builder for DirectoryObjectCheckMemberGroups.
        /// </summary>
        /// <returns>The <see cref="IDirectoryObjectCheckMemberGroupsRequestBuilder"/>.</returns>
        IDirectoryObjectCheckMemberGroupsRequestBuilder CheckMemberGroups(
            IEnumerable<string> groupIds);

        /// <summary>
        /// Gets the request builder for DirectoryObjectGetMemberGroups.
        /// </summary>
        /// <returns>The <see cref="IDirectoryObjectGetMemberGroupsRequestBuilder"/>.</returns>
        IDirectoryObjectGetMemberGroupsRequestBuilder GetMemberGroups(
            bool? securityEnabledOnly = null);

        /// <summary>
        /// Gets the request builder for DirectoryObjectGetMemberObjects.
        /// </summary>
        /// <returns>The <see cref="IDirectoryObjectGetMemberObjectsRequestBuilder"/>.</returns>
        IDirectoryObjectGetMemberObjectsRequestBuilder GetMemberObjects(
            bool? securityEnabledOnly = null);
    
    }
}
