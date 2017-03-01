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
	/// Represents the DataRepository.ViewBacDaoTaoLoaiHinhProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewBacDaoTaoLoaiHinhDataSourceDesigner))]
	public class ViewBacDaoTaoLoaiHinhDataSource : ReadOnlyDataSource<ViewBacDaoTaoLoaiHinh>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewBacDaoTaoLoaiHinhDataSource class.
		/// </summary>
		public ViewBacDaoTaoLoaiHinhDataSource() : base(new ViewBacDaoTaoLoaiHinhService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewBacDaoTaoLoaiHinhDataSourceView used by the ViewBacDaoTaoLoaiHinhDataSource.
		/// </summary>
		protected ViewBacDaoTaoLoaiHinhDataSourceView ViewBacDaoTaoLoaiHinhView
		{
			get { return ( View as ViewBacDaoTaoLoaiHinhDataSourceView ); }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewBacDaoTaoLoaiHinhDataSourceView class that is to be
		/// used by the ViewBacDaoTaoLoaiHinhDataSource.
		/// </summary>
		/// <returns>An instance of the ViewBacDaoTaoLoaiHinhDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewBacDaoTaoLoaiHinh, Object> GetNewDataSourceView()
		{
			return new ViewBacDaoTaoLoaiHinhDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewBacDaoTaoLoaiHinhDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewBacDaoTaoLoaiHinhDataSourceView : ReadOnlyDataSourceView<ViewBacDaoTaoLoaiHinh>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewBacDaoTaoLoaiHinhDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewBacDaoTaoLoaiHinhDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewBacDaoTaoLoaiHinhDataSourceView(ViewBacDaoTaoLoaiHinhDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewBacDaoTaoLoaiHinhDataSource ViewBacDaoTaoLoaiHinhOwner
		{
			get { return Owner as ViewBacDaoTaoLoaiHinhDataSource; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewBacDaoTaoLoaiHinhService ViewBacDaoTaoLoaiHinhProvider
		{
			get { return Provider as ViewBacDaoTaoLoaiHinhService; }
		}

		#endregion Properties
		
		#region Methods
		
		#endregion Methods
	}

	#region ViewBacDaoTaoLoaiHinhDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewBacDaoTaoLoaiHinhDataSource class.
	/// </summary>
	public class ViewBacDaoTaoLoaiHinhDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewBacDaoTaoLoaiHinh>
	{
	}

	#endregion ViewBacDaoTaoLoaiHinhDataSourceDesigner

	#region ViewBacDaoTaoLoaiHinhFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewBacDaoTaoLoaiHinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewBacDaoTaoLoaiHinhFilter : SqlFilter<ViewBacDaoTaoLoaiHinhColumn>
	{
	}

	#endregion ViewBacDaoTaoLoaiHinhFilter

	#region ViewBacDaoTaoLoaiHinhExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewBacDaoTaoLoaiHinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewBacDaoTaoLoaiHinhExpressionBuilder : SqlExpressionBuilder<ViewBacDaoTaoLoaiHinhColumn>
	{
	}
	
	#endregion ViewBacDaoTaoLoaiHinhExpressionBuilder		
}

