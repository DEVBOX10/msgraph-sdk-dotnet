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
    /// The type ConversationThreadRequest.
    /// </summary>
    public partial class ConversationThreadRequest : BaseRequest, IConversationThreadRequest
    {
        /// <summary>
        /// Constructs a new ConversationThreadRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ConversationThreadRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified ConversationThread using POST.
        /// </summary>
        /// <param name="conversationThreadToCreate">The ConversationThread to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ConversationThread.</returns>
        public async System.Threading.Tasks.Task<ConversationThread> CreateAsync(ConversationThread conversationThreadToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<ConversationThread>(conversationThreadToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified ConversationThread using POST and returns a <see cref="GraphResponse{ConversationThread}"/> object.
        /// </summary>
        /// <param name="conversationThreadToCreate">The ConversationThread to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ConversationThread}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ConversationThread>> CreateResponseAsync(ConversationThread conversationThreadToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<ConversationThread>(conversationThreadToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified ConversationThread.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<ConversationThread>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified ConversationThread and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified ConversationThread.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ConversationThread.</returns>
        public async System.Threading.Tasks.Task<ConversationThread> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<ConversationThread>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified ConversationThread and returns a <see cref="GraphResponse{ConversationThread}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ConversationThread}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ConversationThread>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<ConversationThread>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified ConversationThread using PATCH.
        /// </summary>
        /// <param name="conversationThreadToUpdate">The ConversationThread to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ConversationThread.</returns>
        public async System.Threading.Tasks.Task<ConversationThread> UpdateAsync(ConversationThread conversationThreadToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<ConversationThread>(conversationThreadToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ConversationThread using PATCH and returns a <see cref="GraphResponse{ConversationThread}"/> object.
        /// </summary>
        /// <param name="conversationThreadToUpdate">The ConversationThread to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ConversationThread}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ConversationThread>> UpdateResponseAsync(ConversationThread conversationThreadToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<ConversationThread>(conversationThreadToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified ConversationThread using PUT.
        /// </summary>
        /// <param name="conversationThreadToUpdate">The ConversationThread object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<ConversationThread> PutAsync(ConversationThread conversationThreadToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<ConversationThread>(conversationThreadToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ConversationThread using PUT and returns a <see cref="GraphResponse{ConversationThread}"/> object.
        /// </summary>
        /// <param name="conversationThreadToUpdate">The ConversationThread object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{ConversationThread}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ConversationThread>> PutResponseAsync(ConversationThread conversationThreadToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<ConversationThread>(conversationThreadToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IConversationThreadRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IConversationThreadRequest Expand(Expression<Func<ConversationThread, object>> expandExpression)
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
        public IConversationThreadRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IConversationThreadRequest Select(Expression<Func<ConversationThread, object>> selectExpression)
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
        /// <param name="conversationThreadToInitialize">The <see cref="ConversationThread"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(ConversationThread conversationThreadToInitialize)
        {

            if (conversationThreadToInitialize != null && conversationThreadToInitialize.AdditionalData != null)
            {

                if (conversationThreadToInitialize.Posts != null && conversationThreadToInitialize.Posts.CurrentPage != null)
                {
                    conversationThreadToInitialize.Posts.AdditionalData = conversationThreadToInitialize.AdditionalData;

                    if(conversationThreadToInitialize.AdditionalData.TryGetValue("posts@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.GetString()))
                        {
                            conversationThreadToInitialize.Posts.InitializeNextPageRequest(
                                this.Client,
                                element.GetString());
                        }
                    }
                }

            }


        }
    }
}
