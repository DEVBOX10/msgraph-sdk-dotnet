// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    
    using Microsoft.Graph.Core;

    /// <summary>
    /// The type ProfilePhotoContentRequest.
    /// </summary>
    public partial class ProfilePhotoContentRequest : BaseRequest, IProfilePhotoContentRequest
    {
        /// <summary>
        /// Constructs a new ProfilePhotoContentRequest.
        /// <param name="requestUrl">The request URL.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query option name value pairs for the request.</param>
        /// </summary>
        public ProfilePhotoContentRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Gets the stream.
        /// </summary>
        /// <returns>The stream.</returns>
        public Task<Stream> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the stream.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <param name="completionOption">The <see cref="HttpCompletionOption"/> to pass to the <see cref="IHttpProvider"/> on send.</param>
        /// <returns>The stream.</returns>
        public Task<Stream> GetAsync(CancellationToken cancellationToken, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead)
        {
            this.Method = "GET";
            return this.SendStreamRequestAsync(null, cancellationToken, completionOption);
        }
        
        /// <summary>
        /// PUTs the specified stream.
        /// </summary>
        /// <param name="content">The stream to PUT.</param>
        /// <returns>The updated stream.</returns>
        public Task<Stream> PutAsync(Stream content)
        {
            return this.PutAsync(content, CancellationToken.None);
        }
        
        /// <summary>
        /// PUTs the specified stream.
        /// </summary>
        /// <param name="content">The stream to PUT.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <param name="completionOption">The <see cref="HttpCompletionOption"/> to pass to the <see cref="IHttpProvider"/> on send.</param>
        /// <returns>The updated stream.</returns>
        public Task<Stream> PutAsync(Stream content, CancellationToken cancellationToken, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead)
        {
            this.ContentType = "application/octet-stream";
            this.Method = "PUT";
            return this.SendStreamRequestAsync(content, cancellationToken, completionOption);
        }
    
    }
}
