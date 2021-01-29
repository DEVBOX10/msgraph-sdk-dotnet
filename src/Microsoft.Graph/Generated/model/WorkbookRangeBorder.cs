// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Workbook Range Border.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookRangeBorder : Entity
    {
    
		///<summary>
		/// The WorkbookRangeBorder constructor
		///</summary>
        public WorkbookRangeBorder()
        {
            this.ODataType = "microsoft.graph.workbookRangeBorder";
        }
	
        /// <summary>
        /// Gets or sets color.
        /// HTML color code representing the color of the border line, of the form #RRGGBB (e.g. 'FFA500') or as a named HTML color (e.g. 'orange').
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "color", Required = Newtonsoft.Json.Required.Default)]
        public string Color { get; set; }
    
        /// <summary>
        /// Gets or sets side index.
        /// Constant value that indicates the specific side of the border. Possible values are: EdgeTop, EdgeBottom, EdgeLeft, EdgeRight, InsideVertical, InsideHorizontal, DiagonalDown, DiagonalUp. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sideIndex", Required = Newtonsoft.Json.Required.Default)]
        public string SideIndex { get; set; }
    
        /// <summary>
        /// Gets or sets style.
        /// One of the constants of line style specifying the line style for the border. Possible values are: None, Continuous, Dash, DashDot, DashDotDot, Dot, Double, SlantDashDot.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "style", Required = Newtonsoft.Json.Required.Default)]
        public string Style { get; set; }
    
        /// <summary>
        /// Gets or sets weight.
        /// Specifies the weight of the border around a range. Possible values are: Hairline, Thin, Medium, Thick.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "weight", Required = Newtonsoft.Json.Required.Default)]
        public string Weight { get; set; }
    
    }
}

