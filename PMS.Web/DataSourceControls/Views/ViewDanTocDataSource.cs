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
	/// Represents the DataRepository.ViewDanTocProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewDanTocDataSourceDesigner))]
	public class ViewDanTocDataSource : ReadOnlyDataSource<ViewDanToc>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewDanTocDataSource class.
		/// </summary>
		public ViewDanTocDataSource() : base(new ViewDanTocService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewDanTocDataSourceView used by the ViewDanTocDataSource.
		/// </summary>
		protected ViewDanTocDataSourceView ViewDanTocView
		{
			get { return ( View as ViewDanTocDataSourceView ); }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewDanTocDataSourceView class that is to be
		/// used by the ViewDanTocDataSource.
		/// </summary>
		/// <returns>An instance of the ViewDanTocDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewDanToc, Object> GetNewDataSourceView()
		{
			return new ViewDanTocDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewDanTocDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewDanTocDataSourceView : ReadOnlyDataSourceView<ViewDanToc>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewDanTocDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewDanTocDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewDanTocDataSourceView(ViewDanTocDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewDanTocDataSource ViewDanTocOwner
		{
			get { return Owner as ViewDanTocDataSource; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewDanTocService ViewDanTocProvider
		{
			get { return Provider as ViewDanTocService; }
		}

		#endregion Properties
		
		#region Methods
		
		#endregion Methods
	}

	#region ViewDanTocDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewDanTocDataSource class.
	/// </summary>
	public class ViewDanTocDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewDanToc>
	{
	}

	#endregion ViewDanTocDataSourceDesigner

	#region ViewDanTocFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewDanToc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewDanTocFilter : SqlFilter<ViewDanTocColumn>
	{
	}

	#endregion ViewDanTocFilter

	#region ViewDanTocExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewDanToc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewDanTocExpressionBuilder : SqlExpressionBuilder<ViewDanTocColumn>
	{
	}
	
	#endregion ViewDanTocExpressionBuilder		
}

