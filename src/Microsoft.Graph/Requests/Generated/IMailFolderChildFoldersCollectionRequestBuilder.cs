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
    /// The interface IMailFolderChildFoldersCollectionRequestBuilder.
    /// </summary>
    public partial interface IMailFolderChildFoldersCollectionRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IMailFolderChildFoldersCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IMailFolderChildFoldersCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IMailFolderRequestBuilder"/> for the specified MailFolder.
        /// </summary>
        /// <param name="id">The ID for the MailFolder.</param>
        /// <returns>The <see cref="IMailFolderRequestBuilder"/>.</returns>
        IMailFolderRequestBuilder this[string id] { get; }
    }
}
