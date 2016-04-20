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
    /// The type DirectoryRoleTemplateRequestBuilder.
    /// </summary>
    public partial class DirectoryRoleTemplateRequestBuilder : DirectoryObjectRequestBuilder, IDirectoryRoleTemplateRequestBuilder
    {

        /// <summary>
        /// Constructs a new DirectoryRoleTemplateRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DirectoryRoleTemplateRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IDirectoryRoleTemplateRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IDirectoryRoleTemplateRequest Request(IEnumerable<Option> options)
        {
            return new DirectoryRoleTemplateRequest(this.RequestUrl, this.Client, options);
        }
    
    }
}
