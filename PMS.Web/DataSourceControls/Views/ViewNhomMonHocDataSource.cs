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
	/// Represents the DataRepository.ViewNhomMonHocProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewNhomMonHocDataSourceDesigner))]
	public class ViewNhomMonHocDataSource : ReadOnlyDataSource<ViewNhomMonHoc>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewNhomMonHocDataSource class.
		/// </summary>
		public ViewNhomMonHocDataSource() : base(new ViewNhomMonHocService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewNhomMonHocDataSourceView used by the ViewNhomMonHocDataSource.
		/// </summary>
		protected ViewNhomMonHocDataSourceView ViewNhomMonHocView
		{
			get { return ( View as ViewNhomMonHocDataSourceView ); }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewNhomMonHocDataSourceView class that is to be
		/// used by the ViewNhomMonHocDataSource.
		/// </summary>
		/// <returns>An instance of the ViewNhomMonHocDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewNhomMonHoc, Object> GetNewDataSourceView()
		{
			return new ViewNhomMonHocDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewNhomMonHocDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewNhomMonHocDataSourceView : ReadOnlyDataSourceView<ViewNhomMonHoc>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewNhomMonHocDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewNhomMonHocDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewNhomMonHocDataSourceView(ViewNhomMonHocDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewNhomMonHocDataSource ViewNhomMonHocOwner
		{
			get { return Owner as ViewNhomMonHocDataSource; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewNhomMonHocService ViewNhomMonHocProvider
		{
			get { return Provider as ViewNhomMonHocService; }
		}

		#endregion Properties
		
		#region Methods
		
		#endregion Methods
	}

	#region ViewNhomMonHocDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewNhomMonHocDataSource class.
	/// </summary>
	public class ViewNhomMonHocDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewNhomMonHoc>
	{
	}

	#endregion ViewNhomMonHocDataSourceDesigner

	#region ViewNhomMonHocFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewNhomMonHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewNhomMonHocFilter : SqlFilter<ViewNhomMonHocColumn>
	{
	}

	#endregion ViewNhomMonHocFilter

	#region ViewNhomMonHocExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewNhomMonHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewNhomMonHocExpressionBuilder : SqlExpressionBuilder<ViewNhomMonHocColumn>
	{
	}
	
	#endregion ViewNhomMonHocExpressionBuilder		
}

