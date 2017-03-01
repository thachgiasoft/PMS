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
	/// Represents the DataRepository.ViewHesoThuLaoProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewHesoThuLaoDataSourceDesigner))]
	public class ViewHesoThuLaoDataSource : ReadOnlyDataSource<ViewHesoThuLao>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewHesoThuLaoDataSource class.
		/// </summary>
		public ViewHesoThuLaoDataSource() : base(new ViewHesoThuLaoService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewHesoThuLaoDataSourceView used by the ViewHesoThuLaoDataSource.
		/// </summary>
		protected ViewHesoThuLaoDataSourceView ViewHesoThuLaoView
		{
			get { return ( View as ViewHesoThuLaoDataSourceView ); }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewHesoThuLaoDataSourceView class that is to be
		/// used by the ViewHesoThuLaoDataSource.
		/// </summary>
		/// <returns>An instance of the ViewHesoThuLaoDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewHesoThuLao, Object> GetNewDataSourceView()
		{
			return new ViewHesoThuLaoDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewHesoThuLaoDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewHesoThuLaoDataSourceView : ReadOnlyDataSourceView<ViewHesoThuLao>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewHesoThuLaoDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewHesoThuLaoDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewHesoThuLaoDataSourceView(ViewHesoThuLaoDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewHesoThuLaoDataSource ViewHesoThuLaoOwner
		{
			get { return Owner as ViewHesoThuLaoDataSource; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewHesoThuLaoService ViewHesoThuLaoProvider
		{
			get { return Provider as ViewHesoThuLaoService; }
		}

		#endregion Properties
		
		#region Methods
		
		#endregion Methods
	}

	#region ViewHesoThuLaoDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewHesoThuLaoDataSource class.
	/// </summary>
	public class ViewHesoThuLaoDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewHesoThuLao>
	{
	}

	#endregion ViewHesoThuLaoDataSourceDesigner

	#region ViewHesoThuLaoFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewHesoThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewHesoThuLaoFilter : SqlFilter<ViewHesoThuLaoColumn>
	{
	}

	#endregion ViewHesoThuLaoFilter

	#region ViewHesoThuLaoExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewHesoThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewHesoThuLaoExpressionBuilder : SqlExpressionBuilder<ViewHesoThuLaoColumn>
	{
	}
	
	#endregion ViewHesoThuLaoExpressionBuilder		
}

