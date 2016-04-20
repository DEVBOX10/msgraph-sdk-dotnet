// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    
    using Microsoft.Graph.Core;
    
    /// <summary>
    /// The type UserRegisteredDevicesCollectionWithReferencesPage.
    /// </summary>
    public partial class UserRegisteredDevicesCollectionWithReferencesPage : CollectionPage<DirectoryObject>, IUserRegisteredDevicesCollectionWithReferencesPage
    {
        /// <summary>
        /// Gets the next page <see cref="IUserRegisteredDevicesCollectionWithReferencesRequest"/> instance.
        /// </summary>
        public IUserRegisteredDevicesCollectionWithReferencesRequest NextPageRequest { get; private set; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        public void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString)
        {
            if (!string.IsNullOrEmpty(nextPageLinkString))
            {
                this.NextPageRequest = new UserRegisteredDevicesCollectionWithReferencesRequest(
                    nextPageLinkString,
                    client,
                    null);
            }
        }
    }
}
