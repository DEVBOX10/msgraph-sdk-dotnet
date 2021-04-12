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
    /// The type ManagedAppRegistrationRequest.
    /// </summary>
    public partial class ManagedAppRegistrationRequest : BaseRequest, IManagedAppRegistrationRequest
    {
        /// <summary>
        /// Constructs a new ManagedAppRegistrationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ManagedAppRegistrationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified ManagedAppRegistration using POST.
        /// </summary>
        /// <param name="managedAppRegistrationToCreate">The ManagedAppRegistration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagedAppRegistration.</returns>
        public async System.Threading.Tasks.Task<ManagedAppRegistration> CreateAsync(ManagedAppRegistration managedAppRegistrationToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<ManagedAppRegistration>(managedAppRegistrationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified ManagedAppRegistration using POST and returns a <see cref="GraphResponse{ManagedAppRegistration}"/> object.
        /// </summary>
        /// <param name="managedAppRegistrationToCreate">The ManagedAppRegistration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedAppRegistration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ManagedAppRegistration>> CreateResponseAsync(ManagedAppRegistration managedAppRegistrationToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<ManagedAppRegistration>(managedAppRegistrationToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified ManagedAppRegistration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<ManagedAppRegistration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified ManagedAppRegistration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified ManagedAppRegistration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ManagedAppRegistration.</returns>
        public async System.Threading.Tasks.Task<ManagedAppRegistration> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<ManagedAppRegistration>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified ManagedAppRegistration and returns a <see cref="GraphResponse{ManagedAppRegistration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedAppRegistration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ManagedAppRegistration>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<ManagedAppRegistration>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified ManagedAppRegistration using PATCH.
        /// </summary>
        /// <param name="managedAppRegistrationToUpdate">The ManagedAppRegistration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ManagedAppRegistration.</returns>
        public async System.Threading.Tasks.Task<ManagedAppRegistration> UpdateAsync(ManagedAppRegistration managedAppRegistrationToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<ManagedAppRegistration>(managedAppRegistrationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ManagedAppRegistration using PATCH and returns a <see cref="GraphResponse{ManagedAppRegistration}"/> object.
        /// </summary>
        /// <param name="managedAppRegistrationToUpdate">The ManagedAppRegistration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ManagedAppRegistration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ManagedAppRegistration>> UpdateResponseAsync(ManagedAppRegistration managedAppRegistrationToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<ManagedAppRegistration>(managedAppRegistrationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified ManagedAppRegistration using PUT.
        /// </summary>
        /// <param name="managedAppRegistrationToUpdate">The ManagedAppRegistration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<ManagedAppRegistration> PutAsync(ManagedAppRegistration managedAppRegistrationToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<ManagedAppRegistration>(managedAppRegistrationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ManagedAppRegistration using PUT and returns a <see cref="GraphResponse{ManagedAppRegistration}"/> object.
        /// </summary>
        /// <param name="managedAppRegistrationToUpdate">The ManagedAppRegistration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{ManagedAppRegistration}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ManagedAppRegistration>> PutResponseAsync(ManagedAppRegistration managedAppRegistrationToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<ManagedAppRegistration>(managedAppRegistrationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IManagedAppRegistrationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IManagedAppRegistrationRequest Expand(Expression<Func<ManagedAppRegistration, object>> expandExpression)
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
        public IManagedAppRegistrationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IManagedAppRegistrationRequest Select(Expression<Func<ManagedAppRegistration, object>> selectExpression)
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
        /// <param name="managedAppRegistrationToInitialize">The <see cref="ManagedAppRegistration"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(ManagedAppRegistration managedAppRegistrationToInitialize)
        {

            if (managedAppRegistrationToInitialize != null && managedAppRegistrationToInitialize.AdditionalData != null)
            {

                if (managedAppRegistrationToInitialize.AppliedPolicies != null && managedAppRegistrationToInitialize.AppliedPolicies.CurrentPage != null)
                {
                    managedAppRegistrationToInitialize.AppliedPolicies.AdditionalData = managedAppRegistrationToInitialize.AdditionalData;

                    if(managedAppRegistrationToInitialize.AdditionalData.TryGetValue("appliedPolicies@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.GetString()))
                        {
                            managedAppRegistrationToInitialize.AppliedPolicies.InitializeNextPageRequest(
                                this.Client,
                                element.GetString());
                        }
                    }
                }

                if (managedAppRegistrationToInitialize.IntendedPolicies != null && managedAppRegistrationToInitialize.IntendedPolicies.CurrentPage != null)
                {
                    managedAppRegistrationToInitialize.IntendedPolicies.AdditionalData = managedAppRegistrationToInitialize.AdditionalData;

                    if(managedAppRegistrationToInitialize.AdditionalData.TryGetValue("intendedPolicies@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.GetString()))
                        {
                            managedAppRegistrationToInitialize.IntendedPolicies.InitializeNextPageRequest(
                                this.Client,
                                element.GetString());
                        }
                    }
                }

                if (managedAppRegistrationToInitialize.Operations != null && managedAppRegistrationToInitialize.Operations.CurrentPage != null)
                {
                    managedAppRegistrationToInitialize.Operations.AdditionalData = managedAppRegistrationToInitialize.AdditionalData;

                    if(managedAppRegistrationToInitialize.AdditionalData.TryGetValue("operations@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.GetString()))
                        {
                            managedAppRegistrationToInitialize.Operations.InitializeNextPageRequest(
                                this.Client,
                                element.GetString());
                        }
                    }
                }

            }


        }
    }
}
