// <auto-generated/>
using Microsoft.Graph.Groups.Item.Owners.Item.GraphApplication;
using Microsoft.Graph.Groups.Item.Owners.Item.GraphDevice;
using Microsoft.Graph.Groups.Item.Owners.Item.GraphGroup;
using Microsoft.Graph.Groups.Item.Owners.Item.GraphOrgContact;
using Microsoft.Graph.Groups.Item.Owners.Item.GraphServicePrincipal;
using Microsoft.Graph.Groups.Item.Owners.Item.GraphUser;
using Microsoft.Graph.Groups.Item.Owners.Item.Ref;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Microsoft.Graph.Groups.Item.Owners.Item {
    /// <summary>
    /// Builds and executes requests for operations under \groups\{group-id}\owners\{directoryObject-id}
    /// </summary>
    public class DirectoryObjectItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Casts the previous resource to application.</summary>
        public GraphApplicationRequestBuilder GraphApplication { get =>
            new GraphApplicationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to device.</summary>
        public GraphDeviceRequestBuilder GraphDevice { get =>
            new GraphDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to group.</summary>
        public GraphGroupRequestBuilder GraphGroup { get =>
            new GraphGroupRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to orgContact.</summary>
        public GraphOrgContactRequestBuilder GraphOrgContact { get =>
            new GraphOrgContactRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to servicePrincipal.</summary>
        public GraphServicePrincipalRequestBuilder GraphServicePrincipal { get =>
            new GraphServicePrincipalRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to user.</summary>
        public GraphUserRequestBuilder GraphUser { get =>
            new GraphUserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of group entities.</summary>
        public RefRequestBuilder Ref { get =>
            new RefRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new DirectoryObjectItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DirectoryObjectItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/groups/{group%2Did}/owners/{directoryObject%2Did}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new DirectoryObjectItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DirectoryObjectItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/groups/{group%2Did}/owners/{directoryObject%2Did}", rawUrl) {
        }
    }
}
