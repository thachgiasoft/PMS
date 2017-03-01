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
	/// Represents the DataRepository.ViewThoiKhoaBieuProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewThoiKhoaBieuDataSourceDesigner))]
	public class ViewThoiKhoaBieuDataSource : ReadOnlyDataSource<ViewThoiKhoaBieu>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThoiKhoaBieuDataSource class.
		/// </summary>
		public ViewThoiKhoaBieuDataSource() : base(new ViewThoiKhoaBieuService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewThoiKhoaBieuDataSourceView used by the ViewThoiKhoaBieuDataSource.
		/// </summary>
		protected ViewThoiKhoaBieuDataSourceView ViewThoiKhoaBieuView
		{
			get { return ( View as ViewThoiKhoaBieuDataSourceView ); }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewThoiKhoaBieuDataSourceView class that is to be
		/// used by the ViewThoiKhoaBieuDataSource.
		/// </summary>
		/// <returns>An instance of the ViewThoiKhoaBieuDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewThoiKhoaBieu, Object> GetNewDataSourceView()
		{
			return new ViewThoiKhoaBieuDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewThoiKhoaBieuDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewThoiKhoaBieuDataSourceView : ReadOnlyDataSourceView<ViewThoiKhoaBieu>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThoiKhoaBieuDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewThoiKhoaBieuDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewThoiKhoaBieuDataSourceView(ViewThoiKhoaBieuDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewThoiKhoaBieuDataSource ViewThoiKhoaBieuOwner
		{
			get { return Owner as ViewThoiKhoaBieuDataSource; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewThoiKhoaBieuService ViewThoiKhoaBieuProvider
		{
			get { return Provider as ViewThoiKhoaBieuService; }
		}

		#endregion Properties
		
		#region Methods
		
		#endregion Methods
	}

	#region ViewThoiKhoaBieuDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewThoiKhoaBieuDataSource class.
	/// </summary>
	public class ViewThoiKhoaBieuDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewThoiKhoaBieu>
	{
	}

	#endregion ViewThoiKhoaBieuDataSourceDesigner

	#region ViewThoiKhoaBieuFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThoiKhoaBieu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThoiKhoaBieuFilter : SqlFilter<ViewThoiKhoaBieuColumn>
	{
	}

	#endregion ViewThoiKhoaBieuFilter

	#region ViewThoiKhoaBieuExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThoiKhoaBieu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThoiKhoaBieuExpressionBuilder : SqlExpressionBuilder<ViewThoiKhoaBieuColumn>
	{
	}
	
	#endregion ViewThoiKhoaBieuExpressionBuilder		
}

