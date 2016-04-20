// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    
    using Microsoft.Graph.Core;

    /// <summary>
    /// The type MessageForwardRequest.
    /// </summary>
    public partial class MessageForwardRequest : BaseRequest, IMessageForwardRequest
    {
    
        /// <summary>
        /// Constructs a new MessageForwardRequest.
        /// </summary>
        public MessageForwardRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options,
            string comment = null,
            IEnumerable<Recipient> toRecipients = null)
            : base(requestUrl, client, options)
        {
            this.Method = "POST";
            this.ContentType = "application/json";
            this.RequestBody = new MessageForwardRequestBody();
            this.RequestBody.Comment = comment;
            this.RequestBody.ToRecipients = toRecipients;
        }
    
        /// <summary>
        /// Gets the request body.
        /// </summary>
        public MessageForwardRequestBody RequestBody { get; private set; }
    
        /// <summary>
        /// Issues the POST request.
        /// </summary>
        public Task PostAsync()
        {
            return this.PostAsync(CancellationToken.None);
        }
        
        /// <summary>
        /// Issues the POST request.
        /// </summary>
        /// /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public Task PostAsync(CancellationToken cancellationToken)
        {
    
            return this.SendAsync(this.RequestBody, cancellationToken); 
    
        }
    
        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMessageForwardRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IMessageForwardRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }
    
    }
}
