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
	/// Represents the DataRepository.ViewHeDaoTaoProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewHeDaoTaoDataSourceDesigner))]
	public class ViewHeDaoTaoDataSource : ReadOnlyDataSource<ViewHeDaoTao>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewHeDaoTaoDataSource class.
		/// </summary>
		public ViewHeDaoTaoDataSource() : base(new ViewHeDaoTaoService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewHeDaoTaoDataSourceView used by the ViewHeDaoTaoDataSource.
		/// </summary>
		protected ViewHeDaoTaoDataSourceView ViewHeDaoTaoView
		{
			get { return ( View as ViewHeDaoTaoDataSourceView ); }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewHeDaoTaoDataSourceView class that is to be
		/// used by the ViewHeDaoTaoDataSource.
		/// </summary>
		/// <returns>An instance of the ViewHeDaoTaoDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewHeDaoTao, Object> GetNewDataSourceView()
		{
			return new ViewHeDaoTaoDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewHeDaoTaoDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewHeDaoTaoDataSourceView : ReadOnlyDataSourceView<ViewHeDaoTao>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewHeDaoTaoDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewHeDaoTaoDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewHeDaoTaoDataSourceView(ViewHeDaoTaoDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewHeDaoTaoDataSource ViewHeDaoTaoOwner
		{
			get { return Owner as ViewHeDaoTaoDataSource; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewHeDaoTaoService ViewHeDaoTaoProvider
		{
			get { return Provider as ViewHeDaoTaoService; }
		}

		#endregion Properties
		
		#region Methods
		
		#endregion Methods
	}

	#region ViewHeDaoTaoDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewHeDaoTaoDataSource class.
	/// </summary>
	public class ViewHeDaoTaoDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewHeDaoTao>
	{
	}

	#endregion ViewHeDaoTaoDataSourceDesigner

	#region ViewHeDaoTaoFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewHeDaoTao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewHeDaoTaoFilter : SqlFilter<ViewHeDaoTaoColumn>
	{
	}

	#endregion ViewHeDaoTaoFilter

	#region ViewHeDaoTaoExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewHeDaoTao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewHeDaoTaoExpressionBuilder : SqlExpressionBuilder<ViewHeDaoTaoColumn>
	{
	}
	
	#endregion ViewHeDaoTaoExpressionBuilder		
}

