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
	/// Represents the DataRepository.ViewThongKeChucVuProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewThongKeChucVuDataSourceDesigner))]
	public class ViewThongKeChucVuDataSource : ReadOnlyDataSource<ViewThongKeChucVu>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThongKeChucVuDataSource class.
		/// </summary>
		public ViewThongKeChucVuDataSource() : base(new ViewThongKeChucVuService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewThongKeChucVuDataSourceView used by the ViewThongKeChucVuDataSource.
		/// </summary>
		protected ViewThongKeChucVuDataSourceView ViewThongKeChucVuView
		{
			get { return ( View as ViewThongKeChucVuDataSourceView ); }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewThongKeChucVuDataSourceView class that is to be
		/// used by the ViewThongKeChucVuDataSource.
		/// </summary>
		/// <returns>An instance of the ViewThongKeChucVuDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewThongKeChucVu, Object> GetNewDataSourceView()
		{
			return new ViewThongKeChucVuDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewThongKeChucVuDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewThongKeChucVuDataSourceView : ReadOnlyDataSourceView<ViewThongKeChucVu>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThongKeChucVuDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewThongKeChucVuDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewThongKeChucVuDataSourceView(ViewThongKeChucVuDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewThongKeChucVuDataSource ViewThongKeChucVuOwner
		{
			get { return Owner as ViewThongKeChucVuDataSource; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewThongKeChucVuService ViewThongKeChucVuProvider
		{
			get { return Provider as ViewThongKeChucVuService; }
		}

		#endregion Properties
		
		#region Methods
		
		#endregion Methods
	}

	#region ViewThongKeChucVuDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewThongKeChucVuDataSource class.
	/// </summary>
	public class ViewThongKeChucVuDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewThongKeChucVu>
	{
	}

	#endregion ViewThongKeChucVuDataSourceDesigner

	#region ViewThongKeChucVuFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThongKeChucVu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThongKeChucVuFilter : SqlFilter<ViewThongKeChucVuColumn>
	{
	}

	#endregion ViewThongKeChucVuFilter

	#region ViewThongKeChucVuExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThongKeChucVu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThongKeChucVuExpressionBuilder : SqlExpressionBuilder<ViewThongKeChucVuColumn>
	{
	}
	
	#endregion ViewThongKeChucVuExpressionBuilder		
}

