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
	/// Represents the DataRepository.ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtDataSourceDesigner))]
	public class ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtDataSource : ReadOnlyDataSource<ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvt>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtDataSource class.
		/// </summary>
		public ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtDataSource() : base(new ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtDataSourceView used by the ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtDataSource.
		/// </summary>
		protected ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtDataSourceView ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtView
		{
			get { return ( View as ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtDataSourceView ); }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtDataSourceView class that is to be
		/// used by the ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtDataSource.
		/// </summary>
		/// <returns>An instance of the ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvt, Object> GetNewDataSourceView()
		{
			return new ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtDataSourceView : ReadOnlyDataSourceView<ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvt>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtDataSourceView(ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtDataSource ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtOwner
		{
			get { return Owner as ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtDataSource; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtService ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtProvider
		{
			get { return Provider as ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtService; }
		}

		#endregion Properties
		
		#region Methods
		
		#endregion Methods
	}

	#region ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtDataSource class.
	/// </summary>
	public class ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvt>
	{
	}

	#endregion ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtDataSourceDesigner

	#region ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvt"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtFilter : SqlFilter<ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtColumn>
	{
	}

	#endregion ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtFilter

	#region ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvt"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtExpressionBuilder : SqlExpressionBuilder<ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtColumn>
	{
	}
	
	#endregion ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtExpressionBuilder		
}

