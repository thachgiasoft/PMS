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
	/// Represents the DataRepository.ViewKyThiProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewKyThiDataSourceDesigner))]
	public class ViewKyThiDataSource : ReadOnlyDataSource<ViewKyThi>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKyThiDataSource class.
		/// </summary>
		public ViewKyThiDataSource() : base(new ViewKyThiService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewKyThiDataSourceView used by the ViewKyThiDataSource.
		/// </summary>
		protected ViewKyThiDataSourceView ViewKyThiView
		{
			get { return ( View as ViewKyThiDataSourceView ); }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewKyThiDataSourceView class that is to be
		/// used by the ViewKyThiDataSource.
		/// </summary>
		/// <returns>An instance of the ViewKyThiDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewKyThi, Object> GetNewDataSourceView()
		{
			return new ViewKyThiDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewKyThiDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewKyThiDataSourceView : ReadOnlyDataSourceView<ViewKyThi>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKyThiDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewKyThiDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewKyThiDataSourceView(ViewKyThiDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewKyThiDataSource ViewKyThiOwner
		{
			get { return Owner as ViewKyThiDataSource; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewKyThiService ViewKyThiProvider
		{
			get { return Provider as ViewKyThiService; }
		}

		#endregion Properties
		
		#region Methods
		
		#endregion Methods
	}

	#region ViewKyThiDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewKyThiDataSource class.
	/// </summary>
	public class ViewKyThiDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewKyThi>
	{
	}

	#endregion ViewKyThiDataSourceDesigner

	#region ViewKyThiFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKyThi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKyThiFilter : SqlFilter<ViewKyThiColumn>
	{
	}

	#endregion ViewKyThiFilter

	#region ViewKyThiExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKyThi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKyThiExpressionBuilder : SqlExpressionBuilder<ViewKyThiColumn>
	{
	}
	
	#endregion ViewKyThiExpressionBuilder		
}

