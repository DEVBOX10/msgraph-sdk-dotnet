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
    /// The type OrganizationalBrandingRequest.
    /// </summary>
    public partial class OrganizationalBrandingRequest : BaseRequest, IOrganizationalBrandingRequest
    {
        /// <summary>
        /// Constructs a new OrganizationalBrandingRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public OrganizationalBrandingRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified OrganizationalBranding using POST.
        /// </summary>
        /// <param name="organizationalBrandingToCreate">The OrganizationalBranding to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OrganizationalBranding.</returns>
        public async System.Threading.Tasks.Task<OrganizationalBranding> CreateAsync(OrganizationalBranding organizationalBrandingToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<OrganizationalBranding>(organizationalBrandingToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified OrganizationalBranding using POST and returns a <see cref="GraphResponse{OrganizationalBranding}"/> object.
        /// </summary>
        /// <param name="organizationalBrandingToCreate">The OrganizationalBranding to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OrganizationalBranding}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<OrganizationalBranding>> CreateResponseAsync(OrganizationalBranding organizationalBrandingToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<OrganizationalBranding>(organizationalBrandingToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified OrganizationalBranding.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<OrganizationalBranding>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified OrganizationalBranding and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified OrganizationalBranding.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OrganizationalBranding.</returns>
        public async System.Threading.Tasks.Task<OrganizationalBranding> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<OrganizationalBranding>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified OrganizationalBranding and returns a <see cref="GraphResponse{OrganizationalBranding}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OrganizationalBranding}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<OrganizationalBranding>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<OrganizationalBranding>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified OrganizationalBranding using PATCH.
        /// </summary>
        /// <param name="organizationalBrandingToUpdate">The OrganizationalBranding to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated OrganizationalBranding.</returns>
        public async System.Threading.Tasks.Task<OrganizationalBranding> UpdateAsync(OrganizationalBranding organizationalBrandingToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<OrganizationalBranding>(organizationalBrandingToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified OrganizationalBranding using PATCH and returns a <see cref="GraphResponse{OrganizationalBranding}"/> object.
        /// </summary>
        /// <param name="organizationalBrandingToUpdate">The OrganizationalBranding to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{OrganizationalBranding}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<OrganizationalBranding>> UpdateResponseAsync(OrganizationalBranding organizationalBrandingToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<OrganizationalBranding>(organizationalBrandingToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified OrganizationalBranding using PUT.
        /// </summary>
        /// <param name="organizationalBrandingToUpdate">The OrganizationalBranding object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<OrganizationalBranding> PutAsync(OrganizationalBranding organizationalBrandingToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<OrganizationalBranding>(organizationalBrandingToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified OrganizationalBranding using PUT and returns a <see cref="GraphResponse{OrganizationalBranding}"/> object.
        /// </summary>
        /// <param name="organizationalBrandingToUpdate">The OrganizationalBranding object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{OrganizationalBranding}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<OrganizationalBranding>> PutResponseAsync(OrganizationalBranding organizationalBrandingToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<OrganizationalBranding>(organizationalBrandingToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOrganizationalBrandingRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOrganizationalBrandingRequest Expand(Expression<Func<OrganizationalBranding, object>> expandExpression)
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
        public IOrganizationalBrandingRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IOrganizationalBrandingRequest Select(Expression<Func<OrganizationalBranding, object>> selectExpression)
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
        /// <param name="organizationalBrandingToInitialize">The <see cref="OrganizationalBranding"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(OrganizationalBranding organizationalBrandingToInitialize)
        {

            if (organizationalBrandingToInitialize != null && organizationalBrandingToInitialize.AdditionalData != null)
            {

                if (organizationalBrandingToInitialize.Localizations != null && organizationalBrandingToInitialize.Localizations.CurrentPage != null)
                {
                    organizationalBrandingToInitialize.Localizations.AdditionalData = organizationalBrandingToInitialize.AdditionalData;

                    if(organizationalBrandingToInitialize.AdditionalData.TryGetValue("localizations@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.GetString()))
                        {
                            organizationalBrandingToInitialize.Localizations.InitializeNextPageRequest(
                                this.Client,
                                element.GetString());
                        }
                    }
                }

            }


        }
    }
}
