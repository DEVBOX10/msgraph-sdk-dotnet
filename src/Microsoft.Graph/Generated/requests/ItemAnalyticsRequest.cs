// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type ItemAnalyticsRequest.
    /// </summary>
    public partial class ItemAnalyticsRequest : BaseRequest, IItemAnalyticsRequest
    {
        /// <summary>
        /// Constructs a new ItemAnalyticsRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ItemAnalyticsRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified ItemAnalytics using POST.
        /// </summary>
        /// <param name="itemAnalyticsToCreate">The ItemAnalytics to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ItemAnalytics.</returns>
        public async System.Threading.Tasks.Task<ItemAnalytics> CreateAsync(ItemAnalytics itemAnalyticsToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<ItemAnalytics>(itemAnalyticsToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified ItemAnalytics using POST and returns a <see cref="GraphResponse{ItemAnalytics}"/> object.
        /// </summary>
        /// <param name="itemAnalyticsToCreate">The ItemAnalytics to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ItemAnalytics}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ItemAnalytics>> CreateResponseAsync(ItemAnalytics itemAnalyticsToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<ItemAnalytics>(itemAnalyticsToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified ItemAnalytics.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<ItemAnalytics>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified ItemAnalytics and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified ItemAnalytics.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ItemAnalytics.</returns>
        public async System.Threading.Tasks.Task<ItemAnalytics> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<ItemAnalytics>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified ItemAnalytics and returns a <see cref="GraphResponse{ItemAnalytics}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ItemAnalytics}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ItemAnalytics>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<ItemAnalytics>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified ItemAnalytics using PATCH.
        /// </summary>
        /// <param name="itemAnalyticsToUpdate">The ItemAnalytics to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ItemAnalytics.</returns>
        public async System.Threading.Tasks.Task<ItemAnalytics> UpdateAsync(ItemAnalytics itemAnalyticsToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<ItemAnalytics>(itemAnalyticsToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ItemAnalytics using PATCH and returns a <see cref="GraphResponse{ItemAnalytics}"/> object.
        /// </summary>
        /// <param name="itemAnalyticsToUpdate">The ItemAnalytics to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ItemAnalytics}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ItemAnalytics>> UpdateResponseAsync(ItemAnalytics itemAnalyticsToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<ItemAnalytics>(itemAnalyticsToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified ItemAnalytics using PUT.
        /// </summary>
        /// <param name="itemAnalyticsToUpdate">The ItemAnalytics object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<ItemAnalytics> PutAsync(ItemAnalytics itemAnalyticsToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<ItemAnalytics>(itemAnalyticsToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ItemAnalytics using PUT and returns a <see cref="GraphResponse{ItemAnalytics}"/> object.
        /// </summary>
        /// <param name="itemAnalyticsToUpdate">The ItemAnalytics object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{ItemAnalytics}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ItemAnalytics>> PutResponseAsync(ItemAnalytics itemAnalyticsToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<ItemAnalytics>(itemAnalyticsToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IItemAnalyticsRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IItemAnalyticsRequest Expand(Expression<Func<ItemAnalytics, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IItemAnalyticsRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IItemAnalyticsRequest Select(Expression<Func<ItemAnalytics, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="itemAnalyticsToInitialize">The <see cref="ItemAnalytics"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(ItemAnalytics itemAnalyticsToInitialize)
        {

            if (itemAnalyticsToInitialize != null && itemAnalyticsToInitialize.AdditionalData != null)
            {

                if (itemAnalyticsToInitialize.ItemActivityStats != null && itemAnalyticsToInitialize.ItemActivityStats.CurrentPage != null)
                {
                    itemAnalyticsToInitialize.ItemActivityStats.AdditionalData = itemAnalyticsToInitialize.AdditionalData;

                    if(itemAnalyticsToInitialize.AdditionalData.TryGetValue("itemActivityStats@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.GetString()))
                        {
                            itemAnalyticsToInitialize.ItemActivityStats.InitializeNextPageRequest(
                                this.Client,
                                element.GetString());
                        }
                    }
                }

            }


        }
    }
}
