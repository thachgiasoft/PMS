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
	/// Represents the DataRepository.ViewLoaiHinhDaoTaoProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewLoaiHinhDaoTaoDataSourceDesigner))]
	public class ViewLoaiHinhDaoTaoDataSource : ReadOnlyDataSource<ViewLoaiHinhDaoTao>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLoaiHinhDaoTaoDataSource class.
		/// </summary>
		public ViewLoaiHinhDaoTaoDataSource() : base(new ViewLoaiHinhDaoTaoService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewLoaiHinhDaoTaoDataSourceView used by the ViewLoaiHinhDaoTaoDataSource.
		/// </summary>
		protected ViewLoaiHinhDaoTaoDataSourceView ViewLoaiHinhDaoTaoView
		{
			get { return ( View as ViewLoaiHinhDaoTaoDataSourceView ); }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewLoaiHinhDaoTaoDataSourceView class that is to be
		/// used by the ViewLoaiHinhDaoTaoDataSource.
		/// </summary>
		/// <returns>An instance of the ViewLoaiHinhDaoTaoDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewLoaiHinhDaoTao, Object> GetNewDataSourceView()
		{
			return new ViewLoaiHinhDaoTaoDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewLoaiHinhDaoTaoDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewLoaiHinhDaoTaoDataSourceView : ReadOnlyDataSourceView<ViewLoaiHinhDaoTao>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLoaiHinhDaoTaoDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewLoaiHinhDaoTaoDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewLoaiHinhDaoTaoDataSourceView(ViewLoaiHinhDaoTaoDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewLoaiHinhDaoTaoDataSource ViewLoaiHinhDaoTaoOwner
		{
			get { return Owner as ViewLoaiHinhDaoTaoDataSource; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewLoaiHinhDaoTaoService ViewLoaiHinhDaoTaoProvider
		{
			get { return Provider as ViewLoaiHinhDaoTaoService; }
		}

		#endregion Properties
		
		#region Methods
		
		#endregion Methods
	}

	#region ViewLoaiHinhDaoTaoDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewLoaiHinhDaoTaoDataSource class.
	/// </summary>
	public class ViewLoaiHinhDaoTaoDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewLoaiHinhDaoTao>
	{
	}

	#endregion ViewLoaiHinhDaoTaoDataSourceDesigner

	#region ViewLoaiHinhDaoTaoFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLoaiHinhDaoTao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewLoaiHinhDaoTaoFilter : SqlFilter<ViewLoaiHinhDaoTaoColumn>
	{
	}

	#endregion ViewLoaiHinhDaoTaoFilter

	#region ViewLoaiHinhDaoTaoExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLoaiHinhDaoTao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewLoaiHinhDaoTaoExpressionBuilder : SqlExpressionBuilder<ViewLoaiHinhDaoTaoColumn>
	{
	}
	
	#endregion ViewLoaiHinhDaoTaoExpressionBuilder		
}

