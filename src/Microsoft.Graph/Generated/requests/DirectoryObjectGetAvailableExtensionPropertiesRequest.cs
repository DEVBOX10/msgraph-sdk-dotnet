// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The type DirectoryObjectGetAvailableExtensionPropertiesRequest.
    /// </summary>
    public partial class DirectoryObjectGetAvailableExtensionPropertiesRequest : BaseRequest, IDirectoryObjectGetAvailableExtensionPropertiesRequest
    {
        /// <summary>
        /// Constructs a new DirectoryObjectGetAvailableExtensionPropertiesRequest.
        /// </summary>
        public DirectoryObjectGetAvailableExtensionPropertiesRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.RequestBody = new DirectoryObjectGetAvailableExtensionPropertiesRequestBody();
        }

        /// <summary>
        /// Gets the request body.
        /// </summary>
        public DirectoryObjectGetAvailableExtensionPropertiesRequestBody RequestBody { get; private set; }

        /// <summary>
        /// Issues the POST request.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        public async System.Threading.Tasks.Task<IDirectoryObjectGetAvailableExtensionPropertiesCollectionPage> PostAsync(
            CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.POST;
            var response = await this.SendAsync<DirectoryObjectGetAvailableExtensionPropertiesCollectionResponse>(this.RequestBody, cancellationToken).ConfigureAwait(false);
            if (response != null && response.Value != null && response.Value.CurrentPage != null)
            {
                if (response.AdditionalData != null)
                {
                    response.Value.AdditionalData = response.AdditionalData;

                    if(response.AdditionalData.TryGetValue("@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.GetString()))
                        {
                            response.Value.InitializeNextPageRequest(
                                this.Client,
                                element.GetString());
                        }
                    }
                }

                return response.Value;
            }

            return null;
        }

        /// <summary>
        /// Issues the POST request and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse"/> object of the request</returns>
        public System.Threading.Tasks.Task<GraphResponse<DirectoryObjectGetAvailableExtensionPropertiesCollectionResponse>> PostResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<DirectoryObjectGetAvailableExtensionPropertiesCollectionResponse>(this.RequestBody, cancellationToken);
        }



        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDirectoryObjectGetAvailableExtensionPropertiesRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IDirectoryObjectGetAvailableExtensionPropertiesRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        public IDirectoryObjectGetAvailableExtensionPropertiesRequest Top(int value)
        {
            this.QueryOptions.Add(new QueryOption("$top", value.ToString()));
            return this;
        }

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        public IDirectoryObjectGetAvailableExtensionPropertiesRequest Filter(string value)
        {
            this.QueryOptions.Add(new QueryOption("$filter", value));
            return this;
        }

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        public IDirectoryObjectGetAvailableExtensionPropertiesRequest Skip(int value)
        {
            this.QueryOptions.Add(new QueryOption("$skip", value.ToString()));
            return this;
        }

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        public IDirectoryObjectGetAvailableExtensionPropertiesRequest OrderBy(string value)
        {
            this.QueryOptions.Add(new QueryOption("$orderby", value));
            return this;
        }
    }
}
