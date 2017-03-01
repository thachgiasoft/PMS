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
	/// Represents the DataRepository.ViewTietNghiaVuProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewTietNghiaVuDataSourceDesigner))]
	public class ViewTietNghiaVuDataSource : ReadOnlyDataSource<ViewTietNghiaVu>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTietNghiaVuDataSource class.
		/// </summary>
		public ViewTietNghiaVuDataSource() : base(new ViewTietNghiaVuService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewTietNghiaVuDataSourceView used by the ViewTietNghiaVuDataSource.
		/// </summary>
		protected ViewTietNghiaVuDataSourceView ViewTietNghiaVuView
		{
			get { return ( View as ViewTietNghiaVuDataSourceView ); }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewTietNghiaVuDataSourceView class that is to be
		/// used by the ViewTietNghiaVuDataSource.
		/// </summary>
		/// <returns>An instance of the ViewTietNghiaVuDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewTietNghiaVu, Object> GetNewDataSourceView()
		{
			return new ViewTietNghiaVuDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewTietNghiaVuDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewTietNghiaVuDataSourceView : ReadOnlyDataSourceView<ViewTietNghiaVu>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTietNghiaVuDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewTietNghiaVuDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewTietNghiaVuDataSourceView(ViewTietNghiaVuDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewTietNghiaVuDataSource ViewTietNghiaVuOwner
		{
			get { return Owner as ViewTietNghiaVuDataSource; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewTietNghiaVuService ViewTietNghiaVuProvider
		{
			get { return Provider as ViewTietNghiaVuService; }
		}

		#endregion Properties
		
		#region Methods
		
		#endregion Methods
	}

	#region ViewTietNghiaVuDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewTietNghiaVuDataSource class.
	/// </summary>
	public class ViewTietNghiaVuDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewTietNghiaVu>
	{
	}

	#endregion ViewTietNghiaVuDataSourceDesigner

	#region ViewTietNghiaVuFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTietNghiaVu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTietNghiaVuFilter : SqlFilter<ViewTietNghiaVuColumn>
	{
	}

	#endregion ViewTietNghiaVuFilter

	#region ViewTietNghiaVuExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTietNghiaVu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTietNghiaVuExpressionBuilder : SqlExpressionBuilder<ViewTietNghiaVuColumn>
	{
	}
	
	#endregion ViewTietNghiaVuExpressionBuilder		
}

