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
	/// Represents the DataRepository.ViewBuoiProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewBuoiDataSourceDesigner))]
	public class ViewBuoiDataSource : ReadOnlyDataSource<ViewBuoi>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewBuoiDataSource class.
		/// </summary>
		public ViewBuoiDataSource() : base(new ViewBuoiService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewBuoiDataSourceView used by the ViewBuoiDataSource.
		/// </summary>
		protected ViewBuoiDataSourceView ViewBuoiView
		{
			get { return ( View as ViewBuoiDataSourceView ); }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewBuoiDataSourceView class that is to be
		/// used by the ViewBuoiDataSource.
		/// </summary>
		/// <returns>An instance of the ViewBuoiDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewBuoi, Object> GetNewDataSourceView()
		{
			return new ViewBuoiDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewBuoiDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewBuoiDataSourceView : ReadOnlyDataSourceView<ViewBuoi>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewBuoiDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewBuoiDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewBuoiDataSourceView(ViewBuoiDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewBuoiDataSource ViewBuoiOwner
		{
			get { return Owner as ViewBuoiDataSource; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewBuoiService ViewBuoiProvider
		{
			get { return Provider as ViewBuoiService; }
		}

		#endregion Properties
		
		#region Methods
		
		#endregion Methods
	}

	#region ViewBuoiDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewBuoiDataSource class.
	/// </summary>
	public class ViewBuoiDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewBuoi>
	{
	}

	#endregion ViewBuoiDataSourceDesigner

	#region ViewBuoiFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewBuoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewBuoiFilter : SqlFilter<ViewBuoiColumn>
	{
	}

	#endregion ViewBuoiFilter

	#region ViewBuoiExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewBuoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewBuoiExpressionBuilder : SqlExpressionBuilder<ViewBuoiColumn>
	{
	}
	
	#endregion ViewBuoiExpressionBuilder		
}

