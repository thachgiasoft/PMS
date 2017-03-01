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
	/// Represents the DataRepository.ViewLopHocPhanGiangBangTiengNuocNgoaiBuhProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewLopHocPhanGiangBangTiengNuocNgoaiBuhDataSourceDesigner))]
	public class ViewLopHocPhanGiangBangTiengNuocNgoaiBuhDataSource : ReadOnlyDataSource<ViewLopHocPhanGiangBangTiengNuocNgoaiBuh>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLopHocPhanGiangBangTiengNuocNgoaiBuhDataSource class.
		/// </summary>
		public ViewLopHocPhanGiangBangTiengNuocNgoaiBuhDataSource() : base(new ViewLopHocPhanGiangBangTiengNuocNgoaiBuhService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewLopHocPhanGiangBangTiengNuocNgoaiBuhDataSourceView used by the ViewLopHocPhanGiangBangTiengNuocNgoaiBuhDataSource.
		/// </summary>
		protected ViewLopHocPhanGiangBangTiengNuocNgoaiBuhDataSourceView ViewLopHocPhanGiangBangTiengNuocNgoaiBuhView
		{
			get { return ( View as ViewLopHocPhanGiangBangTiengNuocNgoaiBuhDataSourceView ); }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewLopHocPhanGiangBangTiengNuocNgoaiBuhDataSourceView class that is to be
		/// used by the ViewLopHocPhanGiangBangTiengNuocNgoaiBuhDataSource.
		/// </summary>
		/// <returns>An instance of the ViewLopHocPhanGiangBangTiengNuocNgoaiBuhDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewLopHocPhanGiangBangTiengNuocNgoaiBuh, Object> GetNewDataSourceView()
		{
			return new ViewLopHocPhanGiangBangTiengNuocNgoaiBuhDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewLopHocPhanGiangBangTiengNuocNgoaiBuhDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewLopHocPhanGiangBangTiengNuocNgoaiBuhDataSourceView : ReadOnlyDataSourceView<ViewLopHocPhanGiangBangTiengNuocNgoaiBuh>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLopHocPhanGiangBangTiengNuocNgoaiBuhDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewLopHocPhanGiangBangTiengNuocNgoaiBuhDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewLopHocPhanGiangBangTiengNuocNgoaiBuhDataSourceView(ViewLopHocPhanGiangBangTiengNuocNgoaiBuhDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewLopHocPhanGiangBangTiengNuocNgoaiBuhDataSource ViewLopHocPhanGiangBangTiengNuocNgoaiBuhOwner
		{
			get { return Owner as ViewLopHocPhanGiangBangTiengNuocNgoaiBuhDataSource; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewLopHocPhanGiangBangTiengNuocNgoaiBuhService ViewLopHocPhanGiangBangTiengNuocNgoaiBuhProvider
		{
			get { return Provider as ViewLopHocPhanGiangBangTiengNuocNgoaiBuhService; }
		}

		#endregion Properties
		
		#region Methods
		
		#endregion Methods
	}

	#region ViewLopHocPhanGiangBangTiengNuocNgoaiBuhDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewLopHocPhanGiangBangTiengNuocNgoaiBuhDataSource class.
	/// </summary>
	public class ViewLopHocPhanGiangBangTiengNuocNgoaiBuhDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewLopHocPhanGiangBangTiengNuocNgoaiBuh>
	{
	}

	#endregion ViewLopHocPhanGiangBangTiengNuocNgoaiBuhDataSourceDesigner

	#region ViewLopHocPhanGiangBangTiengNuocNgoaiBuhFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLopHocPhanGiangBangTiengNuocNgoaiBuh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewLopHocPhanGiangBangTiengNuocNgoaiBuhFilter : SqlFilter<ViewLopHocPhanGiangBangTiengNuocNgoaiBuhColumn>
	{
	}

	#endregion ViewLopHocPhanGiangBangTiengNuocNgoaiBuhFilter

	#region ViewLopHocPhanGiangBangTiengNuocNgoaiBuhExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLopHocPhanGiangBangTiengNuocNgoaiBuh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewLopHocPhanGiangBangTiengNuocNgoaiBuhExpressionBuilder : SqlExpressionBuilder<ViewLopHocPhanGiangBangTiengNuocNgoaiBuhColumn>
	{
	}
	
	#endregion ViewLopHocPhanGiangBangTiengNuocNgoaiBuhExpressionBuilder		
}

