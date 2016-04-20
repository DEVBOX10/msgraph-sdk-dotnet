// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    
    using Microsoft.Graph.Core;

    /// <summary>
    /// The type ConversationThreadReplyRequestBuilder.
    /// </summary>
    public partial class ConversationThreadReplyRequestBuilder : BaseRequestBuilder, IConversationThreadReplyRequestBuilder
    {
    
        public ConversationThreadReplyRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Post post)
            : base(requestUrl, client)
        {
            
            this.Post = post;

        }
    
        /// <summary>
        /// Gets the value of Post.
        /// </summary>
        public Post Post { get; set; }
    
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IConversationThreadReplyRequest Request(IEnumerable<Option> options = null)
        {
        
            if (this.Post == null)
            {
                throw new ServiceException(
                    new Error
                    {
                        Code = "invalidRequest",
                        Message = "post is a required parameter for this method request.",
                    });
            }
                
            return new ConversationThreadReplyRequest(
                this.RequestUrl,
                this.Client,
                options,
                this.Post);
        
        }

    }
}

