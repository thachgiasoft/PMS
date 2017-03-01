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
	/// Represents the DataRepository.ViewTongHopGioDayGiangVienProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewTongHopGioDayGiangVienDataSourceDesigner))]
	public class ViewTongHopGioDayGiangVienDataSource : ReadOnlyDataSource<ViewTongHopGioDayGiangVien>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTongHopGioDayGiangVienDataSource class.
		/// </summary>
		public ViewTongHopGioDayGiangVienDataSource() : base(new ViewTongHopGioDayGiangVienService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewTongHopGioDayGiangVienDataSourceView used by the ViewTongHopGioDayGiangVienDataSource.
		/// </summary>
		protected ViewTongHopGioDayGiangVienDataSourceView ViewTongHopGioDayGiangVienView
		{
			get { return ( View as ViewTongHopGioDayGiangVienDataSourceView ); }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewTongHopGioDayGiangVienDataSourceView class that is to be
		/// used by the ViewTongHopGioDayGiangVienDataSource.
		/// </summary>
		/// <returns>An instance of the ViewTongHopGioDayGiangVienDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewTongHopGioDayGiangVien, Object> GetNewDataSourceView()
		{
			return new ViewTongHopGioDayGiangVienDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewTongHopGioDayGiangVienDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewTongHopGioDayGiangVienDataSourceView : ReadOnlyDataSourceView<ViewTongHopGioDayGiangVien>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTongHopGioDayGiangVienDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewTongHopGioDayGiangVienDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewTongHopGioDayGiangVienDataSourceView(ViewTongHopGioDayGiangVienDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewTongHopGioDayGiangVienDataSource ViewTongHopGioDayGiangVienOwner
		{
			get { return Owner as ViewTongHopGioDayGiangVienDataSource; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewTongHopGioDayGiangVienService ViewTongHopGioDayGiangVienProvider
		{
			get { return Provider as ViewTongHopGioDayGiangVienService; }
		}

		#endregion Properties
		
		#region Methods
		
		#endregion Methods
	}

	#region ViewTongHopGioDayGiangVienDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewTongHopGioDayGiangVienDataSource class.
	/// </summary>
	public class ViewTongHopGioDayGiangVienDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewTongHopGioDayGiangVien>
	{
	}

	#endregion ViewTongHopGioDayGiangVienDataSourceDesigner

	#region ViewTongHopGioDayGiangVienFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTongHopGioDayGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTongHopGioDayGiangVienFilter : SqlFilter<ViewTongHopGioDayGiangVienColumn>
	{
	}

	#endregion ViewTongHopGioDayGiangVienFilter

	#region ViewTongHopGioDayGiangVienExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTongHopGioDayGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTongHopGioDayGiangVienExpressionBuilder : SqlExpressionBuilder<ViewTongHopGioDayGiangVienColumn>
	{
	}
	
	#endregion ViewTongHopGioDayGiangVienExpressionBuilder		
}

