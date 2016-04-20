// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    
    using Microsoft.Graph.Core;

    /// <summary>
    /// The type DirectoryObjectGetMemberGroupsRequest.
    /// </summary>
    public partial class DirectoryObjectGetMemberGroupsRequest : BaseRequest, IDirectoryObjectGetMemberGroupsRequest
    {
    
        /// <summary>
        /// Constructs a new DirectoryObjectGetMemberGroupsRequest.
        /// </summary>
        public DirectoryObjectGetMemberGroupsRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options,
            bool? securityEnabledOnly = null)
            : base(requestUrl, client, options)
        {
            this.Method = "POST";
            this.ContentType = "application/json";
            this.RequestBody = new DirectoryObjectGetMemberGroupsRequestBody();
            this.RequestBody.SecurityEnabledOnly = securityEnabledOnly;
        }
    
        /// <summary>
        /// Gets the request body.
        /// </summary>
        public DirectoryObjectGetMemberGroupsRequestBody RequestBody { get; private set; }
    
        /// <summary>
        /// Issues the POST request.
        /// </summary>
        public Task<IDirectoryObjectGetMemberGroupsCollectionPage> PostAsync()
        {
            return this.PostAsync(CancellationToken.None);
        }
        
        /// <summary>
        /// Issues the POST request.
        /// </summary>
        /// /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>TheIDirectoryObjectGetMemberGroupsCollectionPage</returns>
        public async Task<IDirectoryObjectGetMemberGroupsCollectionPage> PostAsync(CancellationToken cancellationToken)
        {
    
            var response = await this.SendAsync<DirectoryObjectGetMemberGroupsCollectionResponse>(this.RequestBody, cancellationToken).ConfigureAwait(false);
            if (response != null && response.Value != null && response.Value.CurrentPage != null)
            {
                if (response.AdditionalData != null)
                {
                    response.Value.AdditionalData = response.AdditionalData;
                    
                    object nextPageLink;
                    response.AdditionalData.TryGetValue("@odata.nextLink", out nextPageLink);

                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        response.Value.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                return response.Value;
            }

            return null;
    
        }
    
        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDirectoryObjectGetMemberGroupsRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IDirectoryObjectGetMemberGroupsRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }
    
        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        public IDirectoryObjectGetMemberGroupsRequest Top(int value)
        {
            this.QueryOptions.Add(new QueryOption("$top", value.ToString()));
            return this;
        }
		
        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        public IDirectoryObjectGetMemberGroupsRequest Filter(string value)
        {
            this.QueryOptions.Add(new QueryOption("$filter", value));
            return this;
        }

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        public IDirectoryObjectGetMemberGroupsRequest Skip(int value)
        {
            this.QueryOptions.Add(new QueryOption("$skip", value.ToString()));
            return this;
        }

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        public IDirectoryObjectGetMemberGroupsRequest OrderBy(string value)
        {
            this.QueryOptions.Add(new QueryOption("$orderby", value));
            return this;
        }
    
    }
}
