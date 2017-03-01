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
	/// Represents the DataRepository.ViewSinhVienLopHocPhanSgProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewSinhVienLopHocPhanSgDataSourceDesigner))]
	public class ViewSinhVienLopHocPhanSgDataSource : ReadOnlyDataSource<ViewSinhVienLopHocPhanSg>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewSinhVienLopHocPhanSgDataSource class.
		/// </summary>
		public ViewSinhVienLopHocPhanSgDataSource() : base(new ViewSinhVienLopHocPhanSgService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewSinhVienLopHocPhanSgDataSourceView used by the ViewSinhVienLopHocPhanSgDataSource.
		/// </summary>
		protected ViewSinhVienLopHocPhanSgDataSourceView ViewSinhVienLopHocPhanSgView
		{
			get { return ( View as ViewSinhVienLopHocPhanSgDataSourceView ); }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewSinhVienLopHocPhanSgDataSourceView class that is to be
		/// used by the ViewSinhVienLopHocPhanSgDataSource.
		/// </summary>
		/// <returns>An instance of the ViewSinhVienLopHocPhanSgDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewSinhVienLopHocPhanSg, Object> GetNewDataSourceView()
		{
			return new ViewSinhVienLopHocPhanSgDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewSinhVienLopHocPhanSgDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewSinhVienLopHocPhanSgDataSourceView : ReadOnlyDataSourceView<ViewSinhVienLopHocPhanSg>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewSinhVienLopHocPhanSgDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewSinhVienLopHocPhanSgDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewSinhVienLopHocPhanSgDataSourceView(ViewSinhVienLopHocPhanSgDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewSinhVienLopHocPhanSgDataSource ViewSinhVienLopHocPhanSgOwner
		{
			get { return Owner as ViewSinhVienLopHocPhanSgDataSource; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewSinhVienLopHocPhanSgService ViewSinhVienLopHocPhanSgProvider
		{
			get { return Provider as ViewSinhVienLopHocPhanSgService; }
		}

		#endregion Properties
		
		#region Methods
		
		#endregion Methods
	}

	#region ViewSinhVienLopHocPhanSgDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewSinhVienLopHocPhanSgDataSource class.
	/// </summary>
	public class ViewSinhVienLopHocPhanSgDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewSinhVienLopHocPhanSg>
	{
	}

	#endregion ViewSinhVienLopHocPhanSgDataSourceDesigner

	#region ViewSinhVienLopHocPhanSgFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewSinhVienLopHocPhanSg"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewSinhVienLopHocPhanSgFilter : SqlFilter<ViewSinhVienLopHocPhanSgColumn>
	{
	}

	#endregion ViewSinhVienLopHocPhanSgFilter

	#region ViewSinhVienLopHocPhanSgExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewSinhVienLopHocPhanSg"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewSinhVienLopHocPhanSgExpressionBuilder : SqlExpressionBuilder<ViewSinhVienLopHocPhanSgColumn>
	{
	}
	
	#endregion ViewSinhVienLopHocPhanSgExpressionBuilder		
}

