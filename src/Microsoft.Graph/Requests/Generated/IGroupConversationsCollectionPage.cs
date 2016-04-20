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
    /// The interface IGroupConversationsCollectionPage.
    /// </summary>
    [JsonConverter(typeof(InterfaceConverter<GroupConversationsCollectionPage>))]
    public interface IGroupConversationsCollectionPage : ICollectionPage<Conversation>
    {
        /// <summary>
        /// Gets the next page <see cref="IGroupConversationsCollectionRequest"/> instance.
        /// </summary>
        IGroupConversationsCollectionRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString);
    }
}
