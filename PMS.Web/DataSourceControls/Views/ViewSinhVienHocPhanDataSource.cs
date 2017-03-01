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
	/// Represents the DataRepository.ViewSinhVienHocPhanProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewSinhVienHocPhanDataSourceDesigner))]
	public class ViewSinhVienHocPhanDataSource : ReadOnlyDataSource<ViewSinhVienHocPhan>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewSinhVienHocPhanDataSource class.
		/// </summary>
		public ViewSinhVienHocPhanDataSource() : base(new ViewSinhVienHocPhanService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewSinhVienHocPhanDataSourceView used by the ViewSinhVienHocPhanDataSource.
		/// </summary>
		protected ViewSinhVienHocPhanDataSourceView ViewSinhVienHocPhanView
		{
			get { return ( View as ViewSinhVienHocPhanDataSourceView ); }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewSinhVienHocPhanDataSourceView class that is to be
		/// used by the ViewSinhVienHocPhanDataSource.
		/// </summary>
		/// <returns>An instance of the ViewSinhVienHocPhanDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewSinhVienHocPhan, Object> GetNewDataSourceView()
		{
			return new ViewSinhVienHocPhanDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewSinhVienHocPhanDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewSinhVienHocPhanDataSourceView : ReadOnlyDataSourceView<ViewSinhVienHocPhan>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewSinhVienHocPhanDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewSinhVienHocPhanDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewSinhVienHocPhanDataSourceView(ViewSinhVienHocPhanDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewSinhVienHocPhanDataSource ViewSinhVienHocPhanOwner
		{
			get { return Owner as ViewSinhVienHocPhanDataSource; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewSinhVienHocPhanService ViewSinhVienHocPhanProvider
		{
			get { return Provider as ViewSinhVienHocPhanService; }
		}

		#endregion Properties
		
		#region Methods
		
		#endregion Methods
	}

	#region ViewSinhVienHocPhanDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewSinhVienHocPhanDataSource class.
	/// </summary>
	public class ViewSinhVienHocPhanDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewSinhVienHocPhan>
	{
	}

	#endregion ViewSinhVienHocPhanDataSourceDesigner

	#region ViewSinhVienHocPhanFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewSinhVienHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewSinhVienHocPhanFilter : SqlFilter<ViewSinhVienHocPhanColumn>
	{
	}

	#endregion ViewSinhVienHocPhanFilter

	#region ViewSinhVienHocPhanExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewSinhVienHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewSinhVienHocPhanExpressionBuilder : SqlExpressionBuilder<ViewSinhVienHocPhanColumn>
	{
	}
	
	#endregion ViewSinhVienHocPhanExpressionBuilder		
}

