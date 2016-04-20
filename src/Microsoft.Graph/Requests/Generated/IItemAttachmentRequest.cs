// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    
    using Microsoft.Graph.Core;

    /// <summary>
    /// The interface IItemAttachmentRequest.
    /// </summary>
    public partial interface IItemAttachmentRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ItemAttachment using PUT.
        /// </summary>
        /// <param name="itemAttachmentToCreate">The ItemAttachment to create.</param>
        /// <returns>The created ItemAttachment.</returns>
        Task<ItemAttachment> CreateAsync(ItemAttachment itemAttachmentToCreate);        /// <summary>
        /// Creates the specified ItemAttachment using PUT.
        /// </summary>
        /// <param name="itemAttachmentToCreate">The ItemAttachment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ItemAttachment.</returns>
        Task<ItemAttachment> CreateAsync(ItemAttachment itemAttachmentToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ItemAttachment.
        /// </summary>
        /// <returns>The task to await.</returns>
        Task DeleteAsync();

        /// <summary>
        /// Deletes the specified ItemAttachment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ItemAttachment.
        /// </summary>
        /// <returns>The ItemAttachment.</returns>
        Task<ItemAttachment> GetAsync();

        /// <summary>
        /// Gets the specified ItemAttachment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ItemAttachment.</returns>
        Task<ItemAttachment> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ItemAttachment using PATCH.
        /// </summary>
        /// <param name="itemAttachmentToUpdate">The ItemAttachment to update.</param>
        /// <returns>The updated ItemAttachment.</returns>
        Task<ItemAttachment> UpdateAsync(ItemAttachment itemAttachmentToUpdate);

        /// <summary>
        /// Updates the specified ItemAttachment using PATCH.
        /// </summary>
        /// <param name="itemAttachmentToUpdate">The ItemAttachment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated ItemAttachment.</returns>
        Task<ItemAttachment> UpdateAsync(ItemAttachment itemAttachmentToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IItemAttachmentRequest Expand(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IItemAttachmentRequest Select(string value);
    }
}
