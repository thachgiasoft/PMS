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
	/// Represents the DataRepository.ViewMonHocProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewMonHocDataSourceDesigner))]
	public class ViewMonHocDataSource : ReadOnlyDataSource<ViewMonHoc>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewMonHocDataSource class.
		/// </summary>
		public ViewMonHocDataSource() : base(new ViewMonHocService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewMonHocDataSourceView used by the ViewMonHocDataSource.
		/// </summary>
		protected ViewMonHocDataSourceView ViewMonHocView
		{
			get { return ( View as ViewMonHocDataSourceView ); }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewMonHocDataSourceView class that is to be
		/// used by the ViewMonHocDataSource.
		/// </summary>
		/// <returns>An instance of the ViewMonHocDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewMonHoc, Object> GetNewDataSourceView()
		{
			return new ViewMonHocDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewMonHocDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewMonHocDataSourceView : ReadOnlyDataSourceView<ViewMonHoc>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewMonHocDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewMonHocDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewMonHocDataSourceView(ViewMonHocDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewMonHocDataSource ViewMonHocOwner
		{
			get { return Owner as ViewMonHocDataSource; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewMonHocService ViewMonHocProvider
		{
			get { return Provider as ViewMonHocService; }
		}

		#endregion Properties
		
		#region Methods
		
		#endregion Methods
	}

	#region ViewMonHocDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewMonHocDataSource class.
	/// </summary>
	public class ViewMonHocDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewMonHoc>
	{
	}

	#endregion ViewMonHocDataSourceDesigner

	#region ViewMonHocFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewMonHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewMonHocFilter : SqlFilter<ViewMonHocColumn>
	{
	}

	#endregion ViewMonHocFilter

	#region ViewMonHocExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewMonHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewMonHocExpressionBuilder : SqlExpressionBuilder<ViewMonHocColumn>
	{
	}
	
	#endregion ViewMonHocExpressionBuilder		
}

