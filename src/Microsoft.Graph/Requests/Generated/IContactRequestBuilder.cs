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
    /// The interface IContactRequestBuilder.
    /// </summary>
    public partial interface IContactRequestBuilder : IOutlookItemRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IContactRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IContactRequest Request(IEnumerable<Option> options);
        
        /// <summary>
        /// Gets the request builder for Photo.
        /// </summary>
        /// <returns>The <see cref="IProfilePhotoRequestBuilder"/>.</returns>
        IProfilePhotoRequestBuilder Photo { get; }
    
    }
}
