// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Workbook.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Workbook : Entity
    {
    
		///<summary>
		/// The Workbook constructor
		///</summary>
        public Workbook()
        {
            this.ODataType = "microsoft.graph.workbook";
        }
	
        /// <summary>
        /// Gets or sets application.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "application", Required = Newtonsoft.Json.Required.Default)]
        public WorkbookApplication Application { get; set; }
    
        /// <summary>
        /// Gets or sets names.
        /// Represents a collection of workbook scoped named items (named ranges and constants). Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "names", Required = Newtonsoft.Json.Required.Default)]
        public IWorkbookNamesCollectionPage Names { get; set; }
    
        /// <summary>
        /// Gets or sets tables.
        /// Represents a collection of tables associated with the workbook. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tables", Required = Newtonsoft.Json.Required.Default)]
        public IWorkbookTablesCollectionPage Tables { get; set; }
    
        /// <summary>
        /// Gets or sets worksheets.
        /// Represents a collection of worksheets associated with the workbook. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "worksheets", Required = Newtonsoft.Json.Required.Default)]
        public IWorkbookWorksheetsCollectionPage Worksheets { get; set; }
    
        /// <summary>
        /// Gets or sets comments.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "comments", Required = Newtonsoft.Json.Required.Default)]
        public IWorkbookCommentsCollectionPage Comments { get; set; }
    
        /// <summary>
        /// Gets or sets functions.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "functions", Required = Newtonsoft.Json.Required.Default)]
        public WorkbookFunctions Functions { get; set; }
    
        /// <summary>
        /// Gets or sets operations.
        /// The status of workbook operations. Getting an operation collection is not supported, but you can get the status of a long-running operation if the Location header is returned in the response. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "operations", Required = Newtonsoft.Json.Required.Default)]
        public IWorkbookOperationsCollectionPage Operations { get; set; }
    
    }
}

