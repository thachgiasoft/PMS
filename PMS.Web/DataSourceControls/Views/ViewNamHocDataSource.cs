#region Using Directives
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using PMS.Entities;
using PMS.Data;
using PMS.Data.Bases;
using PMS.Services;
#endregion

namespace PMS.Web.Data
{
	/// <summary>
	/// Represents the DataRepository.ViewNamHocProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewNamHocDataSourceDesigner))]
	public class ViewNamHocDataSource : ReadOnlyDataSource<ViewNamHoc>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewNamHocDataSource class.
		/// </summary>
		public ViewNamHocDataSource() : base(new ViewNamHocService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewNamHocDataSourceView used by the ViewNamHocDataSource.
		/// </summary>
		protected ViewNamHocDataSourceView ViewNamHocView
		{
			get { return ( View as ViewNamHocDataSourceView ); }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewNamHocDataSourceView class that is to be
		/// used by the ViewNamHocDataSource.
		/// </summary>
		/// <returns>An instance of the ViewNamHocDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewNamHoc, Object> GetNewDataSourceView()
		{
			return new ViewNamHocDataSourceView(this, DefaultViewName);
		}
		
		/// <summary>
        /// Creates a cache hashing key based on the startIndex, pageSize and the SelectMethod being used.
        /// </summary>
        /// <param name="startIndex">The current start row index.</param>
        /// <param name="pageSize">The current page size.</param>
        /// <returns>A string that can be used as a key for caching purposes.</returns>
		protected override string CacheHashKey(int startIndex, int pageSize)
        {
			return String.Format("{0}:{1}:{2}", SelectMethod, startIndex, pageSize);
        }
		
		#endregion Methods
	}
	
	/// <summary>
	/// Supports the ViewNamHocDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewNamHocDataSourceView : ReadOnlyDataSourceView<ViewNamHoc>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewNamHocDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewNamHocDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewNamHocDataSourceView(ViewNamHocDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewNamHocDataSource ViewNamHocOwner
		{
			get { return Owner as ViewNamHocDataSource; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewNamHocService ViewNamHocProvider
		{
			get { return Provider as ViewNamHocService; }
		}

		#endregion Properties
		
		#region Methods
		
		#endregion Methods
	}

	#region ViewNamHocDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewNamHocDataSource class.
	/// </summary>
	public class ViewNamHocDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewNamHoc>
	{
	}

	#endregion ViewNamHocDataSourceDesigner

	#region ViewNamHocFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewNamHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewNamHocFilter : SqlFilter<ViewNamHocColumn>
	{
	}

	#endregion ViewNamHocFilter

	#region ViewNamHocExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewNamHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewNamHocExpressionBuilder : SqlExpressionBuilder<ViewNamHocColumn>
	{
	}
	
	#endregion ViewNamHocExpressionBuilder		
}

