using Microsoft.Graph.Groups.Item.Sites.Item.TermStores.Item.Sets.Item.ParentGroup.Sets.Item.Relations.Count;
using Microsoft.Graph.Groups.Item.Sites.Item.TermStores.Item.Sets.Item.ParentGroup.Sets.Item.Relations.Item;
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models.TermStore;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Microsoft.Graph.Groups.Item.Sites.Item.TermStores.Item.Sets.Item.ParentGroup.Sets.Item.Relations {
    /// <summary>Provides operations to manage the relations property of the microsoft.graph.termStore.set entity.</summary>
    public class RelationsRequestBuilder {
        /// <summary>The count property</summary>
        public CountRequestBuilder Count { get =>
            new CountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>Gets an item from the Microsoft.Graph.groups.item.sites.item.termStores.item.sets.item.parentGroup.sets.item.relations.item collection</summary>
        public RelationItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("relation_id", position);
            return new RelationItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new RelationsRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public RelationsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/groups/{group_id}/sites/{site_id}/termStores/{store_id}/sets/{set_id}/parentGroup/sets/{set_id1}/relations{?top,skip,search,filter,count,orderby,select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new RelationsRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public RelationsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/groups/{group_id}/sites/{site_id}/termStores/{store_id}/sets/{set_id}/parentGroup/sets/{set_id1}/relations{?top,skip,search,filter,count,orderby,select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Indicates which terms have been pinned or reused directly under the set.
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// <param name="queryParameters">Request query parameters</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetQueryParameters> queryParameters = default, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (queryParameters != null) {
                var qParams = new GetQueryParameters();
                queryParameters.Invoke(qParams);
                qParams.AddQueryParameters(requestInfo.QueryParameters);
            }
            headers?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(options?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Create new navigation property to relations for groups
        /// <param name="body"></param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// </summary>
        public RequestInformation CreatePostRequestInformation(Relation body, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            headers?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(options?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Indicates which terms have been pinned or reused directly under the set.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// <param name="queryParameters">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<RelationCollectionResponse> GetAsync(Action<GetQueryParameters> queryParameters = default, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(queryParameters, headers, options);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<RelationCollectionResponse>(requestInfo, RelationCollectionResponse.CreateFromDiscriminatorValue, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Create new navigation property to relations for groups
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<Relation> PostAsync(Relation body, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePostRequestInformation(body, headers, options);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Relation>(requestInfo, Relation.CreateFromDiscriminatorValue, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>Indicates which terms have been pinned or reused directly under the set.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Include count of items</summary>
            public bool? Count { get; set; }
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Filter items by property values</summary>
            public string Filter { get; set; }
            /// <summary>Order items by property values</summary>
            public string[] Orderby { get; set; }
            /// <summary>Search items by search phrases</summary>
            public string Search { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
            /// <summary>Skip the first n items</summary>
            public int? Skip { get; set; }
            /// <summary>Show only the first n items</summary>
            public int? Top { get; set; }
        }
    }
}
