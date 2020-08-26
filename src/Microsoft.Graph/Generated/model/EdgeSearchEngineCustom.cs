// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type EdgeSearchEngineCustom.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class EdgeSearchEngineCustom : EdgeSearchEngineBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeSearchEngineCustom"/> class.
        /// </summary>
        public EdgeSearchEngineCustom()
        {
            this.ODataType = "microsoft.graph.edgeSearchEngineCustom";
        }

        /// <summary>
        /// Gets or sets edgeSearchEngineOpenSearchXmlUrl.
        /// Points to a https link containing the OpenSearch xml file that contains, at minimum, the short name and the URL to the search Engine.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "edgeSearchEngineOpenSearchXmlUrl", Required = Newtonsoft.Json.Required.Default)]
        public string EdgeSearchEngineOpenSearchXmlUrl { get; set; }
    
    }
}
