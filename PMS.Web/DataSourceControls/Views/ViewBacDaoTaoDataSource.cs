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
	/// Represents the DataRepository.ViewBacDaoTaoProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewBacDaoTaoDataSourceDesigner))]
	public class ViewBacDaoTaoDataSource : ReadOnlyDataSource<ViewBacDaoTao>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewBacDaoTaoDataSource class.
		/// </summary>
		public ViewBacDaoTaoDataSource() : base(new ViewBacDaoTaoService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewBacDaoTaoDataSourceView used by the ViewBacDaoTaoDataSource.
		/// </summary>
		protected ViewBacDaoTaoDataSourceView ViewBacDaoTaoView
		{
			get { return ( View as ViewBacDaoTaoDataSourceView ); }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewBacDaoTaoDataSourceView class that is to be
		/// used by the ViewBacDaoTaoDataSource.
		/// </summary>
		/// <returns>An instance of the ViewBacDaoTaoDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewBacDaoTao, Object> GetNewDataSourceView()
		{
			return new ViewBacDaoTaoDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewBacDaoTaoDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewBacDaoTaoDataSourceView : ReadOnlyDataSourceView<ViewBacDaoTao>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewBacDaoTaoDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewBacDaoTaoDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewBacDaoTaoDataSourceView(ViewBacDaoTaoDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewBacDaoTaoDataSource ViewBacDaoTaoOwner
		{
			get { return Owner as ViewBacDaoTaoDataSource; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewBacDaoTaoService ViewBacDaoTaoProvider
		{
			get { return Provider as ViewBacDaoTaoService; }
		}

		#endregion Properties
		
		#region Methods
		
		#endregion Methods
	}

	#region ViewBacDaoTaoDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewBacDaoTaoDataSource class.
	/// </summary>
	public class ViewBacDaoTaoDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewBacDaoTao>
	{
	}

	#endregion ViewBacDaoTaoDataSourceDesigner

	#region ViewBacDaoTaoFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewBacDaoTao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewBacDaoTaoFilter : SqlFilter<ViewBacDaoTaoColumn>
	{
	}

	#endregion ViewBacDaoTaoFilter

	#region ViewBacDaoTaoExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewBacDaoTao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewBacDaoTaoExpressionBuilder : SqlExpressionBuilder<ViewBacDaoTaoColumn>
	{
	}
	
	#endregion ViewBacDaoTaoExpressionBuilder		
}

