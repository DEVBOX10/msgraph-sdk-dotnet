// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IMethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IWorkbookRangeUsedRangeRequestBuilder.
    /// </summary>
    public partial interface IWorkbookRangeUsedRangeRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IWorkbookRangeUsedRangeRequest Request(IEnumerable<Option> options = null);
        /// <summary>
        /// Gets the request builder for WorkbookRangeBoundingRectRequestBuilder.
        /// </summary>
        /// <param name="anotherRange">A anotherRange parameter for the OData method call.</param>
        /// <returns>The <see cref="IWorkbookRangeBoundingRectRequestBuilder"/>.</returns>
        IWorkbookRangeBoundingRectRequestBuilder BoundingRect(
            string anotherRange);
        /// <summary>
        /// Gets the request builder for WorkbookRangeCellRequestBuilder.
        /// </summary>
        /// <param name="row">A row parameter for the OData method call.</param>
        /// <param name="column">A column parameter for the OData method call.</param>
        /// <returns>The <see cref="IWorkbookRangeCellRequestBuilder"/>.</returns>
        IWorkbookRangeCellRequestBuilder Cell(
            Int32 row,
            Int32 column);
        /// <summary>
        /// Gets the request builder for WorkbookRangeClearRequestBuilder.
        /// </summary>
        /// <param name="applyTo">A applyTo parameter for the OData method call.</param>
        /// <returns>The <see cref="IWorkbookRangeClearRequestBuilder"/>.</returns>
        IWorkbookRangeClearRequestBuilder Clear(
            string applyTo);
        /// <summary>
        /// Gets the request builder for WorkbookRangeColumnRequestBuilder.
        /// </summary>
        /// <param name="column">A column parameter for the OData method call.</param>
        /// <returns>The <see cref="IWorkbookRangeColumnRequestBuilder"/>.</returns>
        IWorkbookRangeColumnRequestBuilder Column(
            Int32 column);
        /// <summary>
        /// Gets the request builder for WorkbookRangeColumnsAfterRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeColumnsAfterRequestBuilder"/>.</returns>
        IWorkbookRangeColumnsAfterRequestBuilder ColumnsAfter();
        /// <summary>
        /// Gets the request builder for WorkbookRangeColumnsBeforeRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeColumnsBeforeRequestBuilder"/>.</returns>
        IWorkbookRangeColumnsBeforeRequestBuilder ColumnsBefore();
        /// <summary>
        /// Gets the request builder for WorkbookRangeDeleteRequestBuilder.
        /// </summary>
        /// <param name="shift">A shift parameter for the OData method call.</param>
        /// <returns>The <see cref="IWorkbookRangeDeleteRequestBuilder"/>.</returns>
        IWorkbookRangeDeleteRequestBuilder Delete(
            string shift);
        /// <summary>
        /// Gets the request builder for WorkbookRangeEntireColumnRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeEntireColumnRequestBuilder"/>.</returns>
        IWorkbookRangeEntireColumnRequestBuilder EntireColumn();
        /// <summary>
        /// Gets the request builder for WorkbookRangeEntireRowRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeEntireRowRequestBuilder"/>.</returns>
        IWorkbookRangeEntireRowRequestBuilder EntireRow();
        /// <summary>
        /// Gets the request builder for WorkbookRangeInsertRequestBuilder.
        /// </summary>
        /// <param name="shift">A shift parameter for the OData method call.</param>
        /// <returns>The <see cref="IWorkbookRangeInsertRequestBuilder"/>.</returns>
        IWorkbookRangeInsertRequestBuilder Insert(
            string shift);
        /// <summary>
        /// Gets the request builder for WorkbookRangeIntersectionRequestBuilder.
        /// </summary>
        /// <param name="anotherRange">A anotherRange parameter for the OData method call.</param>
        /// <returns>The <see cref="IWorkbookRangeIntersectionRequestBuilder"/>.</returns>
        IWorkbookRangeIntersectionRequestBuilder Intersection(
            string anotherRange);
        /// <summary>
        /// Gets the request builder for WorkbookRangeLastCellRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeLastCellRequestBuilder"/>.</returns>
        IWorkbookRangeLastCellRequestBuilder LastCell();
        /// <summary>
        /// Gets the request builder for WorkbookRangeLastColumnRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeLastColumnRequestBuilder"/>.</returns>
        IWorkbookRangeLastColumnRequestBuilder LastColumn();
        /// <summary>
        /// Gets the request builder for WorkbookRangeLastRowRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeLastRowRequestBuilder"/>.</returns>
        IWorkbookRangeLastRowRequestBuilder LastRow();
        /// <summary>
        /// Gets the request builder for WorkbookRangeMergeRequestBuilder.
        /// </summary>
        /// <param name="across">A across parameter for the OData method call.</param>
        /// <returns>The <see cref="IWorkbookRangeMergeRequestBuilder"/>.</returns>
        IWorkbookRangeMergeRequestBuilder Merge(
            bool across);
        /// <summary>
        /// Gets the request builder for WorkbookRangeOffsetRangeRequestBuilder.
        /// </summary>
        /// <param name="rowOffset">A rowOffset parameter for the OData method call.</param>
        /// <param name="columnOffset">A columnOffset parameter for the OData method call.</param>
        /// <returns>The <see cref="IWorkbookRangeOffsetRangeRequestBuilder"/>.</returns>
        IWorkbookRangeOffsetRangeRequestBuilder OffsetRange(
            Int32 rowOffset,
            Int32 columnOffset);
        /// <summary>
        /// Gets the request builder for WorkbookRangeResizedRangeRequestBuilder.
        /// </summary>
        /// <param name="deltaRows">A deltaRows parameter for the OData method call.</param>
        /// <param name="deltaColumns">A deltaColumns parameter for the OData method call.</param>
        /// <returns>The <see cref="IWorkbookRangeResizedRangeRequestBuilder"/>.</returns>
        IWorkbookRangeResizedRangeRequestBuilder ResizedRange(
            Int32 deltaRows,
            Int32 deltaColumns);
        /// <summary>
        /// Gets the request builder for WorkbookRangeRowRequestBuilder.
        /// </summary>
        /// <param name="row">A row parameter for the OData method call.</param>
        /// <returns>The <see cref="IWorkbookRangeRowRequestBuilder"/>.</returns>
        IWorkbookRangeRowRequestBuilder Row(
            Int32 row);
        /// <summary>
        /// Gets the request builder for WorkbookRangeRowsAboveRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeRowsAboveRequestBuilder"/>.</returns>
        IWorkbookRangeRowsAboveRequestBuilder RowsAbove();
        /// <summary>
        /// Gets the request builder for WorkbookRangeRowsBelowRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeRowsBelowRequestBuilder"/>.</returns>
        IWorkbookRangeRowsBelowRequestBuilder RowsBelow();
        /// <summary>
        /// Gets the request builder for WorkbookRangeUnmergeRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeUnmergeRequestBuilder"/>.</returns>
        IWorkbookRangeUnmergeRequestBuilder Unmerge();
        /// <summary>
        /// Gets the request builder for WorkbookRangeUsedRangeRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeUsedRangeRequestBuilder"/>.</returns>
        IWorkbookRangeUsedRangeRequestBuilder UsedRange();
        /// <summary>
        /// Gets the request builder for WorkbookRangeVisibleViewRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeVisibleViewRequestBuilder"/>.</returns>
        IWorkbookRangeVisibleViewRequestBuilder VisibleView();
    }
}
