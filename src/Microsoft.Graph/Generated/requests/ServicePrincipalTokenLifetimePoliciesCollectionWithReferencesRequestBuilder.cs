// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type ServicePrincipalTokenLifetimePoliciesCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial class ServicePrincipalTokenLifetimePoliciesCollectionWithReferencesRequestBuilder : BaseRequestBuilder, IServicePrincipalTokenLifetimePoliciesCollectionWithReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new ServicePrincipalTokenLifetimePoliciesCollectionWithReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ServicePrincipalTokenLifetimePoliciesCollectionWithReferencesRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IServicePrincipalTokenLifetimePoliciesCollectionWithReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IServicePrincipalTokenLifetimePoliciesCollectionWithReferencesRequest Request(IEnumerable<Option> options)
        {
            return new ServicePrincipalTokenLifetimePoliciesCollectionWithReferencesRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ITokenLifetimePolicyWithReferenceRequestBuilder"/> for the specified ServicePrincipalTokenLifetimePolicy.
        /// </summary>
        /// <param name="id">The ID for the ServicePrincipalTokenLifetimePolicy.</param>
        /// <returns>The <see cref="ITokenLifetimePolicyWithReferenceRequestBuilder"/>.</returns>
        public ITokenLifetimePolicyWithReferenceRequestBuilder this[string id]
        {
            get
            {
                return new TokenLifetimePolicyWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
        /// <summary>
        /// Gets an <see cref="IServicePrincipalTokenLifetimePoliciesCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IServicePrincipalTokenLifetimePoliciesCollectionReferencesRequestBuilder"/>.</returns>
        public IServicePrincipalTokenLifetimePoliciesCollectionReferencesRequestBuilder References
        {
            get
            {
                return new ServicePrincipalTokenLifetimePoliciesCollectionReferencesRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
