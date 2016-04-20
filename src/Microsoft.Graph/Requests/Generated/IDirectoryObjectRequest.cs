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
    /// The interface IDirectoryObjectRequest.
    /// </summary>
    public partial interface IDirectoryObjectRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DirectoryObject using PUT.
        /// </summary>
        /// <param name="directoryObjectToCreate">The DirectoryObject to create.</param>
        /// <returns>The created DirectoryObject.</returns>
        Task<DirectoryObject> CreateAsync(DirectoryObject directoryObjectToCreate);        /// <summary>
        /// Creates the specified DirectoryObject using PUT.
        /// </summary>
        /// <param name="directoryObjectToCreate">The DirectoryObject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DirectoryObject.</returns>
        Task<DirectoryObject> CreateAsync(DirectoryObject directoryObjectToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DirectoryObject.
        /// </summary>
        /// <returns>The task to await.</returns>
        Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DirectoryObject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DirectoryObject.
        /// </summary>
        /// <returns>The DirectoryObject.</returns>
        Task<DirectoryObject> GetAsync();

        /// <summary>
        /// Gets the specified DirectoryObject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DirectoryObject.</returns>
        Task<DirectoryObject> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DirectoryObject using PATCH.
        /// </summary>
        /// <param name="directoryObjectToUpdate">The DirectoryObject to update.</param>
        /// <returns>The updated DirectoryObject.</returns>
        Task<DirectoryObject> UpdateAsync(DirectoryObject directoryObjectToUpdate);

        /// <summary>
        /// Updates the specified DirectoryObject using PATCH.
        /// </summary>
        /// <param name="directoryObjectToUpdate">The DirectoryObject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated DirectoryObject.</returns>
        Task<DirectoryObject> UpdateAsync(DirectoryObject directoryObjectToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDirectoryObjectRequest Expand(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDirectoryObjectRequest Select(string value);
    }
}
