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
	/// Represents the DataRepository.ViewLoaiHocPhanProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewLoaiHocPhanDataSourceDesigner))]
	public class ViewLoaiHocPhanDataSource : ReadOnlyDataSource<ViewLoaiHocPhan>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLoaiHocPhanDataSource class.
		/// </summary>
		public ViewLoaiHocPhanDataSource() : base(new ViewLoaiHocPhanService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewLoaiHocPhanDataSourceView used by the ViewLoaiHocPhanDataSource.
		/// </summary>
		protected ViewLoaiHocPhanDataSourceView ViewLoaiHocPhanView
		{
			get { return ( View as ViewLoaiHocPhanDataSourceView ); }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewLoaiHocPhanDataSourceView class that is to be
		/// used by the ViewLoaiHocPhanDataSource.
		/// </summary>
		/// <returns>An instance of the ViewLoaiHocPhanDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewLoaiHocPhan, Object> GetNewDataSourceView()
		{
			return new ViewLoaiHocPhanDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewLoaiHocPhanDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewLoaiHocPhanDataSourceView : ReadOnlyDataSourceView<ViewLoaiHocPhan>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLoaiHocPhanDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewLoaiHocPhanDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewLoaiHocPhanDataSourceView(ViewLoaiHocPhanDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewLoaiHocPhanDataSource ViewLoaiHocPhanOwner
		{
			get { return Owner as ViewLoaiHocPhanDataSource; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewLoaiHocPhanService ViewLoaiHocPhanProvider
		{
			get { return Provider as ViewLoaiHocPhanService; }
		}

		#endregion Properties
		
		#region Methods
		
		#endregion Methods
	}

	#region ViewLoaiHocPhanDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewLoaiHocPhanDataSource class.
	/// </summary>
	public class ViewLoaiHocPhanDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewLoaiHocPhan>
	{
	}

	#endregion ViewLoaiHocPhanDataSourceDesigner

	#region ViewLoaiHocPhanFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLoaiHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewLoaiHocPhanFilter : SqlFilter<ViewLoaiHocPhanColumn>
	{
	}

	#endregion ViewLoaiHocPhanFilter

	#region ViewLoaiHocPhanExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLoaiHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewLoaiHocPhanExpressionBuilder : SqlExpressionBuilder<ViewLoaiHocPhanColumn>
	{
	}
	
	#endregion ViewLoaiHocPhanExpressionBuilder		
}

