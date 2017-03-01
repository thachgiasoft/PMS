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
	/// Represents the DataRepository.ViewKhoiLuongGiangDayCanBoProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewKhoiLuongGiangDayCanBoDataSourceDesigner))]
	public class ViewKhoiLuongGiangDayCanBoDataSource : ReadOnlyDataSource<ViewKhoiLuongGiangDayCanBo>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKhoiLuongGiangDayCanBoDataSource class.
		/// </summary>
		public ViewKhoiLuongGiangDayCanBoDataSource() : base(new ViewKhoiLuongGiangDayCanBoService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewKhoiLuongGiangDayCanBoDataSourceView used by the ViewKhoiLuongGiangDayCanBoDataSource.
		/// </summary>
		protected ViewKhoiLuongGiangDayCanBoDataSourceView ViewKhoiLuongGiangDayCanBoView
		{
			get { return ( View as ViewKhoiLuongGiangDayCanBoDataSourceView ); }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewKhoiLuongGiangDayCanBoDataSourceView class that is to be
		/// used by the ViewKhoiLuongGiangDayCanBoDataSource.
		/// </summary>
		/// <returns>An instance of the ViewKhoiLuongGiangDayCanBoDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewKhoiLuongGiangDayCanBo, Object> GetNewDataSourceView()
		{
			return new ViewKhoiLuongGiangDayCanBoDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewKhoiLuongGiangDayCanBoDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewKhoiLuongGiangDayCanBoDataSourceView : ReadOnlyDataSourceView<ViewKhoiLuongGiangDayCanBo>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKhoiLuongGiangDayCanBoDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewKhoiLuongGiangDayCanBoDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewKhoiLuongGiangDayCanBoDataSourceView(ViewKhoiLuongGiangDayCanBoDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewKhoiLuongGiangDayCanBoDataSource ViewKhoiLuongGiangDayCanBoOwner
		{
			get { return Owner as ViewKhoiLuongGiangDayCanBoDataSource; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewKhoiLuongGiangDayCanBoService ViewKhoiLuongGiangDayCanBoProvider
		{
			get { return Provider as ViewKhoiLuongGiangDayCanBoService; }
		}

		#endregion Properties
		
		#region Methods
		
		#endregion Methods
	}

	#region ViewKhoiLuongGiangDayCanBoDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewKhoiLuongGiangDayCanBoDataSource class.
	/// </summary>
	public class ViewKhoiLuongGiangDayCanBoDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewKhoiLuongGiangDayCanBo>
	{
	}

	#endregion ViewKhoiLuongGiangDayCanBoDataSourceDesigner

	#region ViewKhoiLuongGiangDayCanBoFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKhoiLuongGiangDayCanBo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKhoiLuongGiangDayCanBoFilter : SqlFilter<ViewKhoiLuongGiangDayCanBoColumn>
	{
	}

	#endregion ViewKhoiLuongGiangDayCanBoFilter

	#region ViewKhoiLuongGiangDayCanBoExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKhoiLuongGiangDayCanBo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKhoiLuongGiangDayCanBoExpressionBuilder : SqlExpressionBuilder<ViewKhoiLuongGiangDayCanBoColumn>
	{
	}
	
	#endregion ViewKhoiLuongGiangDayCanBoExpressionBuilder		
}

