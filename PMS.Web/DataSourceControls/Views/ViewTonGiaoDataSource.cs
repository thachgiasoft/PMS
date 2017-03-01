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
	/// Represents the DataRepository.ViewTonGiaoProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewTonGiaoDataSourceDesigner))]
	public class ViewTonGiaoDataSource : ReadOnlyDataSource<ViewTonGiao>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTonGiaoDataSource class.
		/// </summary>
		public ViewTonGiaoDataSource() : base(new ViewTonGiaoService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewTonGiaoDataSourceView used by the ViewTonGiaoDataSource.
		/// </summary>
		protected ViewTonGiaoDataSourceView ViewTonGiaoView
		{
			get { return ( View as ViewTonGiaoDataSourceView ); }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewTonGiaoDataSourceView class that is to be
		/// used by the ViewTonGiaoDataSource.
		/// </summary>
		/// <returns>An instance of the ViewTonGiaoDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewTonGiao, Object> GetNewDataSourceView()
		{
			return new ViewTonGiaoDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewTonGiaoDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewTonGiaoDataSourceView : ReadOnlyDataSourceView<ViewTonGiao>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTonGiaoDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewTonGiaoDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewTonGiaoDataSourceView(ViewTonGiaoDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewTonGiaoDataSource ViewTonGiaoOwner
		{
			get { return Owner as ViewTonGiaoDataSource; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewTonGiaoService ViewTonGiaoProvider
		{
			get { return Provider as ViewTonGiaoService; }
		}

		#endregion Properties
		
		#region Methods
		
		#endregion Methods
	}

	#region ViewTonGiaoDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewTonGiaoDataSource class.
	/// </summary>
	public class ViewTonGiaoDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewTonGiao>
	{
	}

	#endregion ViewTonGiaoDataSourceDesigner

	#region ViewTonGiaoFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTonGiao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTonGiaoFilter : SqlFilter<ViewTonGiaoColumn>
	{
	}

	#endregion ViewTonGiaoFilter

	#region ViewTonGiaoExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTonGiao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTonGiaoExpressionBuilder : SqlExpressionBuilder<ViewTonGiaoColumn>
	{
	}
	
	#endregion ViewTonGiaoExpressionBuilder		
}

