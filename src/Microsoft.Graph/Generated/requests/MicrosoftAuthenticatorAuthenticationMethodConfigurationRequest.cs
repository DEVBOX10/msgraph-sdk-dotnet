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
    /// The type MicrosoftAuthenticatorAuthenticationMethodConfigurationRequest.
    /// </summary>
    public partial class MicrosoftAuthenticatorAuthenticationMethodConfigurationRequest : BaseRequest, IMicrosoftAuthenticatorAuthenticationMethodConfigurationRequest
    {
        /// <summary>
        /// Constructs a new MicrosoftAuthenticatorAuthenticationMethodConfigurationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public MicrosoftAuthenticatorAuthenticationMethodConfigurationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified MicrosoftAuthenticatorAuthenticationMethodConfiguration using POST.
        /// </summary>
        /// <param name="microsoftAuthenticatorAuthenticationMethodConfigurationToCreate">The MicrosoftAuthenticatorAuthenticationMethodConfiguration to create.</param>
        /// <returns>The created MicrosoftAuthenticatorAuthenticationMethodConfiguration.</returns>
        public System.Threading.Tasks.Task<MicrosoftAuthenticatorAuthenticationMethodConfiguration> CreateAsync(MicrosoftAuthenticatorAuthenticationMethodConfiguration microsoftAuthenticatorAuthenticationMethodConfigurationToCreate)
        {
            return this.CreateAsync(microsoftAuthenticatorAuthenticationMethodConfigurationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified MicrosoftAuthenticatorAuthenticationMethodConfiguration using POST.
        /// </summary>
        /// <param name="microsoftAuthenticatorAuthenticationMethodConfigurationToCreate">The MicrosoftAuthenticatorAuthenticationMethodConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MicrosoftAuthenticatorAuthenticationMethodConfiguration.</returns>
        public async System.Threading.Tasks.Task<MicrosoftAuthenticatorAuthenticationMethodConfiguration> CreateAsync(MicrosoftAuthenticatorAuthenticationMethodConfiguration microsoftAuthenticatorAuthenticationMethodConfigurationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<MicrosoftAuthenticatorAuthenticationMethodConfiguration>(microsoftAuthenticatorAuthenticationMethodConfigurationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified MicrosoftAuthenticatorAuthenticationMethodConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified MicrosoftAuthenticatorAuthenticationMethodConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<MicrosoftAuthenticatorAuthenticationMethodConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified MicrosoftAuthenticatorAuthenticationMethodConfiguration.
        /// </summary>
        /// <returns>The MicrosoftAuthenticatorAuthenticationMethodConfiguration.</returns>
        public System.Threading.Tasks.Task<MicrosoftAuthenticatorAuthenticationMethodConfiguration> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified MicrosoftAuthenticatorAuthenticationMethodConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MicrosoftAuthenticatorAuthenticationMethodConfiguration.</returns>
        public async System.Threading.Tasks.Task<MicrosoftAuthenticatorAuthenticationMethodConfiguration> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<MicrosoftAuthenticatorAuthenticationMethodConfiguration>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified MicrosoftAuthenticatorAuthenticationMethodConfiguration using PATCH.
        /// </summary>
        /// <param name="microsoftAuthenticatorAuthenticationMethodConfigurationToUpdate">The MicrosoftAuthenticatorAuthenticationMethodConfiguration to update.</param>
        /// <returns>The updated MicrosoftAuthenticatorAuthenticationMethodConfiguration.</returns>
        public System.Threading.Tasks.Task<MicrosoftAuthenticatorAuthenticationMethodConfiguration> UpdateAsync(MicrosoftAuthenticatorAuthenticationMethodConfiguration microsoftAuthenticatorAuthenticationMethodConfigurationToUpdate)
        {
            return this.UpdateAsync(microsoftAuthenticatorAuthenticationMethodConfigurationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified MicrosoftAuthenticatorAuthenticationMethodConfiguration using PATCH.
        /// </summary>
        /// <param name="microsoftAuthenticatorAuthenticationMethodConfigurationToUpdate">The MicrosoftAuthenticatorAuthenticationMethodConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MicrosoftAuthenticatorAuthenticationMethodConfiguration.</returns>
        public async System.Threading.Tasks.Task<MicrosoftAuthenticatorAuthenticationMethodConfiguration> UpdateAsync(MicrosoftAuthenticatorAuthenticationMethodConfiguration microsoftAuthenticatorAuthenticationMethodConfigurationToUpdate, CancellationToken cancellationToken)
        {
			if (microsoftAuthenticatorAuthenticationMethodConfigurationToUpdate.AdditionalData != null)
			{
				if (microsoftAuthenticatorAuthenticationMethodConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					microsoftAuthenticatorAuthenticationMethodConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, microsoftAuthenticatorAuthenticationMethodConfigurationToUpdate.GetType().Name)
						});
				}
			}
            if (microsoftAuthenticatorAuthenticationMethodConfigurationToUpdate.AdditionalData != null)
            {
                if (microsoftAuthenticatorAuthenticationMethodConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    microsoftAuthenticatorAuthenticationMethodConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, microsoftAuthenticatorAuthenticationMethodConfigurationToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<MicrosoftAuthenticatorAuthenticationMethodConfiguration>(microsoftAuthenticatorAuthenticationMethodConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMicrosoftAuthenticatorAuthenticationMethodConfigurationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMicrosoftAuthenticatorAuthenticationMethodConfigurationRequest Expand(Expression<Func<MicrosoftAuthenticatorAuthenticationMethodConfiguration, object>> expandExpression)
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
        public IMicrosoftAuthenticatorAuthenticationMethodConfigurationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IMicrosoftAuthenticatorAuthenticationMethodConfigurationRequest Select(Expression<Func<MicrosoftAuthenticatorAuthenticationMethodConfiguration, object>> selectExpression)
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
        /// <param name="microsoftAuthenticatorAuthenticationMethodConfigurationToInitialize">The <see cref="MicrosoftAuthenticatorAuthenticationMethodConfiguration"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(MicrosoftAuthenticatorAuthenticationMethodConfiguration microsoftAuthenticatorAuthenticationMethodConfigurationToInitialize)
        {

            if (microsoftAuthenticatorAuthenticationMethodConfigurationToInitialize != null && microsoftAuthenticatorAuthenticationMethodConfigurationToInitialize.AdditionalData != null)
            {

                if (microsoftAuthenticatorAuthenticationMethodConfigurationToInitialize.IncludeTargets != null && microsoftAuthenticatorAuthenticationMethodConfigurationToInitialize.IncludeTargets.CurrentPage != null)
                {
                    microsoftAuthenticatorAuthenticationMethodConfigurationToInitialize.IncludeTargets.AdditionalData = microsoftAuthenticatorAuthenticationMethodConfigurationToInitialize.AdditionalData;

                    object nextPageLink;
                    microsoftAuthenticatorAuthenticationMethodConfigurationToInitialize.AdditionalData.TryGetValue("includeTargets@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        microsoftAuthenticatorAuthenticationMethodConfigurationToInitialize.IncludeTargets.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
