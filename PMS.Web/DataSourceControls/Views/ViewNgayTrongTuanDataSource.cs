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
	/// Represents the DataRepository.ViewNgayTrongTuanProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewNgayTrongTuanDataSourceDesigner))]
	public class ViewNgayTrongTuanDataSource : ReadOnlyDataSource<ViewNgayTrongTuan>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewNgayTrongTuanDataSource class.
		/// </summary>
		public ViewNgayTrongTuanDataSource() : base(new ViewNgayTrongTuanService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewNgayTrongTuanDataSourceView used by the ViewNgayTrongTuanDataSource.
		/// </summary>
		protected ViewNgayTrongTuanDataSourceView ViewNgayTrongTuanView
		{
			get { return ( View as ViewNgayTrongTuanDataSourceView ); }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewNgayTrongTuanDataSourceView class that is to be
		/// used by the ViewNgayTrongTuanDataSource.
		/// </summary>
		/// <returns>An instance of the ViewNgayTrongTuanDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewNgayTrongTuan, Object> GetNewDataSourceView()
		{
			return new ViewNgayTrongTuanDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewNgayTrongTuanDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewNgayTrongTuanDataSourceView : ReadOnlyDataSourceView<ViewNgayTrongTuan>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewNgayTrongTuanDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewNgayTrongTuanDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewNgayTrongTuanDataSourceView(ViewNgayTrongTuanDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewNgayTrongTuanDataSource ViewNgayTrongTuanOwner
		{
			get { return Owner as ViewNgayTrongTuanDataSource; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewNgayTrongTuanService ViewNgayTrongTuanProvider
		{
			get { return Provider as ViewNgayTrongTuanService; }
		}

		#endregion Properties
		
		#region Methods
		
		#endregion Methods
	}

	#region ViewNgayTrongTuanDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewNgayTrongTuanDataSource class.
	/// </summary>
	public class ViewNgayTrongTuanDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewNgayTrongTuan>
	{
	}

	#endregion ViewNgayTrongTuanDataSourceDesigner

	#region ViewNgayTrongTuanFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewNgayTrongTuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewNgayTrongTuanFilter : SqlFilter<ViewNgayTrongTuanColumn>
	{
	}

	#endregion ViewNgayTrongTuanFilter

	#region ViewNgayTrongTuanExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewNgayTrongTuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewNgayTrongTuanExpressionBuilder : SqlExpressionBuilder<ViewNgayTrongTuanColumn>
	{
	}
	
	#endregion ViewNgayTrongTuanExpressionBuilder		
}

