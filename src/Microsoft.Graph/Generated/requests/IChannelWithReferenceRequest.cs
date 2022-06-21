// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IChannelWithReferenceRequest.
    /// </summary>
    public partial interface IChannelWithReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the specified Channel.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Channel.</returns>
        System.Threading.Tasks.Task<Channel> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Channel and returns a <see cref="GraphResponse{Channel}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Channel}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Channel>> GetResponseAsync(CancellationToken cancellationToken = default);

		/// <summary>
        /// Creates the specified Channel using POST.
        /// </summary>
        /// <param name="channelToCreate">The Channel to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Channel.</returns>
        System.Threading.Tasks.Task<Channel> CreateAsync(Channel channelToCreate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Creates the specified Channel using POST and returns a <see cref="GraphResponse{Channel}"/> object.
        /// </summary>
        /// <param name="channelToCreate">The Channel to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Channel}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Channel>> CreateResponseAsync(Channel channelToCreate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Updates the specified Channel using PATCH.
        /// </summary>
        /// <param name="channelToUpdate">The Channel to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Channel.</returns>
        System.Threading.Tasks.Task<Channel> UpdateAsync(Channel channelToUpdate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Updates the specified Channel using PATCH and returns a <see cref="GraphResponse{Channel}"/> object.
        /// </summary>
        /// <param name="channelToUpdate">The Channel to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Channel}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Channel>> UpdateResponseAsync(Channel channelToUpdate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Deletes the specified Channel.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

		/// <summary>
        /// Deletes the specified Channel and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IChannelWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IChannelWithReferenceRequest Expand(Expression<Func<Channel, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IChannelWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IChannelWithReferenceRequest Select(Expression<Func<Channel, object>> selectExpression);

    }
}
