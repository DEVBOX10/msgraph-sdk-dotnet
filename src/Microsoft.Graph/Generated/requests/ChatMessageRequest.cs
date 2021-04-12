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
    /// The type ChatMessageRequest.
    /// </summary>
    public partial class ChatMessageRequest : BaseRequest, IChatMessageRequest
    {
        /// <summary>
        /// Constructs a new ChatMessageRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ChatMessageRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified ChatMessage using POST.
        /// </summary>
        /// <param name="chatMessageToCreate">The ChatMessage to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ChatMessage.</returns>
        public async System.Threading.Tasks.Task<ChatMessage> CreateAsync(ChatMessage chatMessageToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<ChatMessage>(chatMessageToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified ChatMessage using POST and returns a <see cref="GraphResponse{ChatMessage}"/> object.
        /// </summary>
        /// <param name="chatMessageToCreate">The ChatMessage to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ChatMessage}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ChatMessage>> CreateResponseAsync(ChatMessage chatMessageToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<ChatMessage>(chatMessageToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified ChatMessage.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<ChatMessage>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified ChatMessage and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified ChatMessage.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ChatMessage.</returns>
        public async System.Threading.Tasks.Task<ChatMessage> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<ChatMessage>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified ChatMessage and returns a <see cref="GraphResponse{ChatMessage}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ChatMessage}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ChatMessage>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<ChatMessage>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified ChatMessage using PATCH.
        /// </summary>
        /// <param name="chatMessageToUpdate">The ChatMessage to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ChatMessage.</returns>
        public async System.Threading.Tasks.Task<ChatMessage> UpdateAsync(ChatMessage chatMessageToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<ChatMessage>(chatMessageToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ChatMessage using PATCH and returns a <see cref="GraphResponse{ChatMessage}"/> object.
        /// </summary>
        /// <param name="chatMessageToUpdate">The ChatMessage to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ChatMessage}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ChatMessage>> UpdateResponseAsync(ChatMessage chatMessageToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<ChatMessage>(chatMessageToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified ChatMessage using PUT.
        /// </summary>
        /// <param name="chatMessageToUpdate">The ChatMessage object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<ChatMessage> PutAsync(ChatMessage chatMessageToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<ChatMessage>(chatMessageToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ChatMessage using PUT and returns a <see cref="GraphResponse{ChatMessage}"/> object.
        /// </summary>
        /// <param name="chatMessageToUpdate">The ChatMessage object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{ChatMessage}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ChatMessage>> PutResponseAsync(ChatMessage chatMessageToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<ChatMessage>(chatMessageToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IChatMessageRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IChatMessageRequest Expand(Expression<Func<ChatMessage, object>> expandExpression)
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
        public IChatMessageRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IChatMessageRequest Select(Expression<Func<ChatMessage, object>> selectExpression)
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
        /// <param name="chatMessageToInitialize">The <see cref="ChatMessage"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(ChatMessage chatMessageToInitialize)
        {

            if (chatMessageToInitialize != null && chatMessageToInitialize.AdditionalData != null)
            {

                if (chatMessageToInitialize.HostedContents != null && chatMessageToInitialize.HostedContents.CurrentPage != null)
                {
                    chatMessageToInitialize.HostedContents.AdditionalData = chatMessageToInitialize.AdditionalData;

                    if(chatMessageToInitialize.AdditionalData.TryGetValue("hostedContents@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.GetString()))
                        {
                            chatMessageToInitialize.HostedContents.InitializeNextPageRequest(
                                this.Client,
                                element.GetString());
                        }
                    }
                }

                if (chatMessageToInitialize.Replies != null && chatMessageToInitialize.Replies.CurrentPage != null)
                {
                    chatMessageToInitialize.Replies.AdditionalData = chatMessageToInitialize.AdditionalData;

                    if(chatMessageToInitialize.AdditionalData.TryGetValue("replies@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.GetString()))
                        {
                            chatMessageToInitialize.Replies.InitializeNextPageRequest(
                                this.Client,
                                element.GetString());
                        }
                    }
                }

            }


        }
    }
}
