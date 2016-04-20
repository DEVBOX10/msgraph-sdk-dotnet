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
    /// The type UserReminderViewRequestBuilder.
    /// </summary>
    public partial class UserReminderViewRequestBuilder : BaseRequestBuilder, IUserReminderViewRequestBuilder
    {
    
        public UserReminderViewRequestBuilder(
            string requestUrl,
            IBaseClient client,
            string startDateTime,
            string endDateTime = null)
            : base(requestUrl, client)
        {
            
            this.StartDateTime = startDateTime;
            this.EndDateTime = endDateTime;

        }
    
        /// <summary>
        /// Gets the value of StartDateTime.
        /// </summary>
        public string StartDateTime { get; set; }
    
        /// <summary>
        /// Gets the value of EndDateTime.
        /// </summary>
        public string EndDateTime { get; set; }
    
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IUserReminderViewRequest Request(IEnumerable<Option> options = null)
        {
        
            var functionRequestUrl = this.RequestUrl;
            
            var functionParametersStringBuilder = new StringBuilder();

            if (this.StartDateTime != null)
            {
                functionParametersStringBuilder.AppendFormat("startDateTime='{0}'", this.StartDateTime);
            }
            else
            {
                throw new ServiceException(
                    new Error
                    {
                        Code = "invalidRequest",
                        Message = "startDateTime is a required parameter for this method request.",
                    });
            }

            if (this.EndDateTime != null)
            {
                functionParametersStringBuilder.AppendFormat(",endDateTime='{0}'", this.EndDateTime);
            }
            else
            {
                functionParametersStringBuilder.Append(",endDateTime=null");
            }

            functionRequestUrl = string.Format("{0}({1})", this.RequestUrl, functionParametersStringBuilder.ToString());
            
            return new UserReminderViewRequest(
                functionRequestUrl,
                this.Client,
                options);
        
        }

    }
}

