// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type ReportRootGetOffice365ActivationsUserDetailRequestBuilder.
    /// </summary>
    public partial class ReportRootGetOffice365ActivationsUserDetailRequestBuilder : BaseFunctionMethodRequestBuilder<IReportRootGetOffice365ActivationsUserDetailRequest>, IReportRootGetOffice365ActivationsUserDetailRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="ReportRootGetOffice365ActivationsUserDetailRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ReportRootGetOffice365ActivationsUserDetailRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IReportRootGetOffice365ActivationsUserDetailRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new ReportRootGetOffice365ActivationsUserDetailRequest(functionUrl, this.Client, options);

            return request;
        }
    }
}
