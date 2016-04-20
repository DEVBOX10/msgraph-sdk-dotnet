// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    
    using Microsoft.Graph.Core;
    using Newtonsoft.Json;
    
    /// <summary>
    /// The interface IGraphServiceDirectoryRolesCollectionPage.
    /// </summary>
    [JsonConverter(typeof(InterfaceConverter<GraphServiceDirectoryRolesCollectionPage>))]
    public interface IGraphServiceDirectoryRolesCollectionPage : ICollectionPage<DirectoryRole>
    {
        /// <summary>
        /// Gets the next page <see cref="IGraphServiceDirectoryRolesCollectionRequest"/> instance.
        /// </summary>
        IGraphServiceDirectoryRolesCollectionRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString);
    }
}
