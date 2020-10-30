// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type WorkbookTableColumnRangeRequestBuilder.
    /// </summary>
    public partial class WorkbookTableColumnRangeRequestBuilder : BaseFunctionMethodRequestBuilder<IWorkbookTableColumnRangeRequest>, IWorkbookTableColumnRangeRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookTableColumnRangeRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public WorkbookTableColumnRangeRequestBuilder(
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
        protected override IWorkbookTableColumnRangeRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookTableColumnRangeRequest(functionUrl, this.Client, options);

            return request;
        }
        /// <summary>
        /// Gets the request builder for WorkbookRangeBoundingRectRequestBuilder.
        /// </summary>
        /// <param name="anotherRange">A anotherRange parameter for the OData method call.</param>
        /// <returns>The <see cref="IWorkbookRangeBoundingRectRequestBuilder"/>.</returns>
        public IWorkbookRangeBoundingRectRequestBuilder BoundingRect(
            string anotherRange)
        {
            return new WorkbookRangeBoundingRectRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.boundingRect"),
                this.Client,
                anotherRange);
        }
        /// <summary>
        /// Gets the request builder for WorkbookRangeCellRequestBuilder.
        /// </summary>
        /// <param name="row">A row parameter for the OData method call.</param>
        /// <param name="column">A column parameter for the OData method call.</param>
        /// <returns>The <see cref="IWorkbookRangeCellRequestBuilder"/>.</returns>
        public IWorkbookRangeCellRequestBuilder Cell(
            Int32 row,
            Int32 column)
        {
            return new WorkbookRangeCellRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.cell"),
                this.Client,
                row,
                column);
        }
        /// <summary>
        /// Gets the request builder for WorkbookRangeClearRequestBuilder.
        /// </summary>
        /// <param name="applyTo">A applyTo parameter for the OData method call.</param>
        /// <returns>The <see cref="IWorkbookRangeClearRequestBuilder"/>.</returns>
        public IWorkbookRangeClearRequestBuilder Clear(
            string applyTo)
        {
            return new WorkbookRangeClearRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.clear"),
                this.Client,
                applyTo);
        }
        /// <summary>
        /// Gets the request builder for WorkbookRangeColumnRequestBuilder.
        /// </summary>
        /// <param name="column">A column parameter for the OData method call.</param>
        /// <returns>The <see cref="IWorkbookRangeColumnRequestBuilder"/>.</returns>
        public IWorkbookRangeColumnRequestBuilder Column(
            Int32 column)
        {
            return new WorkbookRangeColumnRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.column"),
                this.Client,
                column);
        }
        /// <summary>
        /// Gets the request builder for WorkbookRangeColumnsAfterRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeColumnsAfterRequestBuilder"/>.</returns>
        public IWorkbookRangeColumnsAfterRequestBuilder ColumnsAfter()
        {
            return new WorkbookRangeColumnsAfterRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.columnsAfter"),
                this.Client);
        }
        /// <summary>
        /// Gets the request builder for WorkbookRangeColumnsBeforeRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeColumnsBeforeRequestBuilder"/>.</returns>
        public IWorkbookRangeColumnsBeforeRequestBuilder ColumnsBefore()
        {
            return new WorkbookRangeColumnsBeforeRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.columnsBefore"),
                this.Client);
        }
        /// <summary>
        /// Gets the request builder for WorkbookRangeDeleteRequestBuilder.
        /// </summary>
        /// <param name="shift">A shift parameter for the OData method call.</param>
        /// <returns>The <see cref="IWorkbookRangeDeleteRequestBuilder"/>.</returns>
        public IWorkbookRangeDeleteRequestBuilder Delete(
            string shift)
        {
            return new WorkbookRangeDeleteRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.delete"),
                this.Client,
                shift);
        }
        /// <summary>
        /// Gets the request builder for WorkbookRangeEntireColumnRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeEntireColumnRequestBuilder"/>.</returns>
        public IWorkbookRangeEntireColumnRequestBuilder EntireColumn()
        {
            return new WorkbookRangeEntireColumnRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.entireColumn"),
                this.Client);
        }
        /// <summary>
        /// Gets the request builder for WorkbookRangeEntireRowRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeEntireRowRequestBuilder"/>.</returns>
        public IWorkbookRangeEntireRowRequestBuilder EntireRow()
        {
            return new WorkbookRangeEntireRowRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.entireRow"),
                this.Client);
        }
        /// <summary>
        /// Gets the request builder for WorkbookRangeInsertRequestBuilder.
        /// </summary>
        /// <param name="shift">A shift parameter for the OData method call.</param>
        /// <returns>The <see cref="IWorkbookRangeInsertRequestBuilder"/>.</returns>
        public IWorkbookRangeInsertRequestBuilder Insert(
            string shift)
        {
            return new WorkbookRangeInsertRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.insert"),
                this.Client,
                shift);
        }
        /// <summary>
        /// Gets the request builder for WorkbookRangeIntersectionRequestBuilder.
        /// </summary>
        /// <param name="anotherRange">A anotherRange parameter for the OData method call.</param>
        /// <returns>The <see cref="IWorkbookRangeIntersectionRequestBuilder"/>.</returns>
        public IWorkbookRangeIntersectionRequestBuilder Intersection(
            string anotherRange)
        {
            return new WorkbookRangeIntersectionRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.intersection"),
                this.Client,
                anotherRange);
        }
        /// <summary>
        /// Gets the request builder for WorkbookRangeLastCellRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeLastCellRequestBuilder"/>.</returns>
        public IWorkbookRangeLastCellRequestBuilder LastCell()
        {
            return new WorkbookRangeLastCellRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.lastCell"),
                this.Client);
        }
        /// <summary>
        /// Gets the request builder for WorkbookRangeLastColumnRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeLastColumnRequestBuilder"/>.</returns>
        public IWorkbookRangeLastColumnRequestBuilder LastColumn()
        {
            return new WorkbookRangeLastColumnRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.lastColumn"),
                this.Client);
        }
        /// <summary>
        /// Gets the request builder for WorkbookRangeLastRowRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeLastRowRequestBuilder"/>.</returns>
        public IWorkbookRangeLastRowRequestBuilder LastRow()
        {
            return new WorkbookRangeLastRowRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.lastRow"),
                this.Client);
        }
        /// <summary>
        /// Gets the request builder for WorkbookRangeMergeRequestBuilder.
        /// </summary>
        /// <param name="across">A across parameter for the OData method call.</param>
        /// <returns>The <see cref="IWorkbookRangeMergeRequestBuilder"/>.</returns>
        public IWorkbookRangeMergeRequestBuilder Merge(
            bool across)
        {
            return new WorkbookRangeMergeRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.merge"),
                this.Client,
                across);
        }
        /// <summary>
        /// Gets the request builder for WorkbookRangeOffsetRangeRequestBuilder.
        /// </summary>
        /// <param name="rowOffset">A rowOffset parameter for the OData method call.</param>
        /// <param name="columnOffset">A columnOffset parameter for the OData method call.</param>
        /// <returns>The <see cref="IWorkbookRangeOffsetRangeRequestBuilder"/>.</returns>
        public IWorkbookRangeOffsetRangeRequestBuilder OffsetRange(
            Int32 rowOffset,
            Int32 columnOffset)
        {
            return new WorkbookRangeOffsetRangeRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.offsetRange"),
                this.Client,
                rowOffset,
                columnOffset);
        }
        /// <summary>
        /// Gets the request builder for WorkbookRangeResizedRangeRequestBuilder.
        /// </summary>
        /// <param name="deltaRows">A deltaRows parameter for the OData method call.</param>
        /// <param name="deltaColumns">A deltaColumns parameter for the OData method call.</param>
        /// <returns>The <see cref="IWorkbookRangeResizedRangeRequestBuilder"/>.</returns>
        public IWorkbookRangeResizedRangeRequestBuilder ResizedRange(
            Int32 deltaRows,
            Int32 deltaColumns)
        {
            return new WorkbookRangeResizedRangeRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.resizedRange"),
                this.Client,
                deltaRows,
                deltaColumns);
        }
        /// <summary>
        /// Gets the request builder for WorkbookRangeRowRequestBuilder.
        /// </summary>
        /// <param name="row">A row parameter for the OData method call.</param>
        /// <returns>The <see cref="IWorkbookRangeRowRequestBuilder"/>.</returns>
        public IWorkbookRangeRowRequestBuilder Row(
            Int32 row)
        {
            return new WorkbookRangeRowRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.row"),
                this.Client,
                row);
        }
        /// <summary>
        /// Gets the request builder for WorkbookRangeRowsAboveRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeRowsAboveRequestBuilder"/>.</returns>
        public IWorkbookRangeRowsAboveRequestBuilder RowsAbove()
        {
            return new WorkbookRangeRowsAboveRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.rowsAbove"),
                this.Client);
        }
        /// <summary>
        /// Gets the request builder for WorkbookRangeRowsBelowRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeRowsBelowRequestBuilder"/>.</returns>
        public IWorkbookRangeRowsBelowRequestBuilder RowsBelow()
        {
            return new WorkbookRangeRowsBelowRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.rowsBelow"),
                this.Client);
        }
        /// <summary>
        /// Gets the request builder for WorkbookRangeUnmergeRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeUnmergeRequestBuilder"/>.</returns>
        public IWorkbookRangeUnmergeRequestBuilder Unmerge()
        {
            return new WorkbookRangeUnmergeRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.unmerge"),
                this.Client);
        }
        /// <summary>
        /// Gets the request builder for WorkbookRangeUsedRangeRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeUsedRangeRequestBuilder"/>.</returns>
        public IWorkbookRangeUsedRangeRequestBuilder UsedRange()
        {
            return new WorkbookRangeUsedRangeRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.usedRange"),
                this.Client);
        }
        /// <summary>
        /// Gets the request builder for WorkbookRangeVisibleViewRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeVisibleViewRequestBuilder"/>.</returns>
        public IWorkbookRangeVisibleViewRequestBuilder VisibleView()
        {
            return new WorkbookRangeVisibleViewRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.visibleView"),
                this.Client);
        }
    }
}
