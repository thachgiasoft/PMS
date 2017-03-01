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
	/// Represents the DataRepository.ViewGiangVienKhoaProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewGiangVienKhoaDataSourceDesigner))]
	public class ViewGiangVienKhoaDataSource : ReadOnlyDataSource<ViewGiangVienKhoa>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienKhoaDataSource class.
		/// </summary>
		public ViewGiangVienKhoaDataSource() : base(new ViewGiangVienKhoaService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewGiangVienKhoaDataSourceView used by the ViewGiangVienKhoaDataSource.
		/// </summary>
		protected ViewGiangVienKhoaDataSourceView ViewGiangVienKhoaView
		{
			get { return ( View as ViewGiangVienKhoaDataSourceView ); }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewGiangVienKhoaDataSourceView class that is to be
		/// used by the ViewGiangVienKhoaDataSource.
		/// </summary>
		/// <returns>An instance of the ViewGiangVienKhoaDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewGiangVienKhoa, Object> GetNewDataSourceView()
		{
			return new ViewGiangVienKhoaDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewGiangVienKhoaDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewGiangVienKhoaDataSourceView : ReadOnlyDataSourceView<ViewGiangVienKhoa>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienKhoaDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewGiangVienKhoaDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewGiangVienKhoaDataSourceView(ViewGiangVienKhoaDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewGiangVienKhoaDataSource ViewGiangVienKhoaOwner
		{
			get { return Owner as ViewGiangVienKhoaDataSource; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewGiangVienKhoaService ViewGiangVienKhoaProvider
		{
			get { return Provider as ViewGiangVienKhoaService; }
		}

		#endregion Properties
		
		#region Methods
		
		#endregion Methods
	}

	#region ViewGiangVienKhoaDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewGiangVienKhoaDataSource class.
	/// </summary>
	public class ViewGiangVienKhoaDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewGiangVienKhoa>
	{
	}

	#endregion ViewGiangVienKhoaDataSourceDesigner

	#region ViewGiangVienKhoaFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewGiangVienKhoa"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewGiangVienKhoaFilter : SqlFilter<ViewGiangVienKhoaColumn>
	{
	}

	#endregion ViewGiangVienKhoaFilter

	#region ViewGiangVienKhoaExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewGiangVienKhoa"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewGiangVienKhoaExpressionBuilder : SqlExpressionBuilder<ViewGiangVienKhoaColumn>
	{
	}
	
	#endregion ViewGiangVienKhoaExpressionBuilder		
}

