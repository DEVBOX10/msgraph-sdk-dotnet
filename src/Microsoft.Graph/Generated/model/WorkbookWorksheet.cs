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
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Workbook Worksheet.
    /// </summary>
    public partial class WorkbookWorksheet : Entity
    {
    
        /// <summary>
        /// Gets or sets name.
        /// The display name of the worksheet.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets position.
        /// The zero-based position of the worksheet within the workbook.
        /// </summary>
        [JsonPropertyName("position")]
        public Int32? Position { get; set; }
    
        /// <summary>
        /// Gets or sets visibility.
        /// The Visibility of the worksheet. The possible values are: Visible, Hidden, VeryHidden.
        /// </summary>
        [JsonPropertyName("visibility")]
        public string Visibility { get; set; }
    
        /// <summary>
        /// Gets or sets charts.
        /// Returns collection of charts that are part of the worksheet. Read-only.
        /// </summary>
        [JsonPropertyName("charts")]
        public IWorkbookWorksheetChartsCollectionPage Charts { get; set; }

        /// <summary>
        /// Gets or sets chartsNextLink.
        /// </summary>
        [JsonPropertyName("charts@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ChartsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets names.
        /// Returns collection of names that are associated with the worksheet. Read-only.
        /// </summary>
        [JsonPropertyName("names")]
        public IWorkbookWorksheetNamesCollectionPage Names { get; set; }

        /// <summary>
        /// Gets or sets namesNextLink.
        /// </summary>
        [JsonPropertyName("names@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string NamesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets pivot tables.
        /// Collection of PivotTables that are part of the worksheet.
        /// </summary>
        [JsonPropertyName("pivotTables")]
        public IWorkbookWorksheetPivotTablesCollectionPage PivotTables { get; set; }

        /// <summary>
        /// Gets or sets pivotTablesNextLink.
        /// </summary>
        [JsonPropertyName("pivotTables@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string PivotTablesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets protection.
        /// Returns sheet protection object for a worksheet. Read-only.
        /// </summary>
        [JsonPropertyName("protection")]
        public WorkbookWorksheetProtection Protection { get; set; }
    
        /// <summary>
        /// Gets or sets tables.
        /// Collection of tables that are part of the worksheet. Read-only.
        /// </summary>
        [JsonPropertyName("tables")]
        public IWorkbookWorksheetTablesCollectionPage Tables { get; set; }

        /// <summary>
        /// Gets or sets tablesNextLink.
        /// </summary>
        [JsonPropertyName("tables@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string TablesNextLink { get; set; }
    
    }
}

