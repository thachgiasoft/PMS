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
	/// Represents the DataRepository.ViewTietGiangDayProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewTietGiangDayDataSourceDesigner))]
	public class ViewTietGiangDayDataSource : ReadOnlyDataSource<ViewTietGiangDay>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTietGiangDayDataSource class.
		/// </summary>
		public ViewTietGiangDayDataSource() : base(new ViewTietGiangDayService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewTietGiangDayDataSourceView used by the ViewTietGiangDayDataSource.
		/// </summary>
		protected ViewTietGiangDayDataSourceView ViewTietGiangDayView
		{
			get { return ( View as ViewTietGiangDayDataSourceView ); }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewTietGiangDayDataSourceView class that is to be
		/// used by the ViewTietGiangDayDataSource.
		/// </summary>
		/// <returns>An instance of the ViewTietGiangDayDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewTietGiangDay, Object> GetNewDataSourceView()
		{
			return new ViewTietGiangDayDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewTietGiangDayDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewTietGiangDayDataSourceView : ReadOnlyDataSourceView<ViewTietGiangDay>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTietGiangDayDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewTietGiangDayDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewTietGiangDayDataSourceView(ViewTietGiangDayDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewTietGiangDayDataSource ViewTietGiangDayOwner
		{
			get { return Owner as ViewTietGiangDayDataSource; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewTietGiangDayService ViewTietGiangDayProvider
		{
			get { return Provider as ViewTietGiangDayService; }
		}

		#endregion Properties
		
		#region Methods
		
		#endregion Methods
	}

	#region ViewTietGiangDayDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewTietGiangDayDataSource class.
	/// </summary>
	public class ViewTietGiangDayDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewTietGiangDay>
	{
	}

	#endregion ViewTietGiangDayDataSourceDesigner

	#region ViewTietGiangDayFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTietGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTietGiangDayFilter : SqlFilter<ViewTietGiangDayColumn>
	{
	}

	#endregion ViewTietGiangDayFilter

	#region ViewTietGiangDayExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTietGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTietGiangDayExpressionBuilder : SqlExpressionBuilder<ViewTietGiangDayColumn>
	{
	}
	
	#endregion ViewTietGiangDayExpressionBuilder		
}

