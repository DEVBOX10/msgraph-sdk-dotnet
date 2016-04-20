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
    /// The interface IDriveItemSearchRequestBuilder.
    /// </summary>
    public partial interface IDriveItemSearchRequestBuilder
    {
    
        /// <summary>
        /// Gets the Q.
        /// </summary>
        string Q { get; }
    
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IDriveItemSearchRequest Request(IEnumerable<Option> options = null);
    }
}
