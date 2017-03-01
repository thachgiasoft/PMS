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
	/// Represents the DataRepository.ViewNgachLuongHrmProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewNgachLuongHrmDataSourceDesigner))]
	public class ViewNgachLuongHrmDataSource : ReadOnlyDataSource<ViewNgachLuongHrm>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewNgachLuongHrmDataSource class.
		/// </summary>
		public ViewNgachLuongHrmDataSource() : base(new ViewNgachLuongHrmService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewNgachLuongHrmDataSourceView used by the ViewNgachLuongHrmDataSource.
		/// </summary>
		protected ViewNgachLuongHrmDataSourceView ViewNgachLuongHrmView
		{
			get { return ( View as ViewNgachLuongHrmDataSourceView ); }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewNgachLuongHrmDataSourceView class that is to be
		/// used by the ViewNgachLuongHrmDataSource.
		/// </summary>
		/// <returns>An instance of the ViewNgachLuongHrmDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewNgachLuongHrm, Object> GetNewDataSourceView()
		{
			return new ViewNgachLuongHrmDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewNgachLuongHrmDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewNgachLuongHrmDataSourceView : ReadOnlyDataSourceView<ViewNgachLuongHrm>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewNgachLuongHrmDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewNgachLuongHrmDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewNgachLuongHrmDataSourceView(ViewNgachLuongHrmDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewNgachLuongHrmDataSource ViewNgachLuongHrmOwner
		{
			get { return Owner as ViewNgachLuongHrmDataSource; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewNgachLuongHrmService ViewNgachLuongHrmProvider
		{
			get { return Provider as ViewNgachLuongHrmService; }
		}

		#endregion Properties
		
		#region Methods
		
		#endregion Methods
	}

	#region ViewNgachLuongHrmDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewNgachLuongHrmDataSource class.
	/// </summary>
	public class ViewNgachLuongHrmDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewNgachLuongHrm>
	{
	}

	#endregion ViewNgachLuongHrmDataSourceDesigner

	#region ViewNgachLuongHrmFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewNgachLuongHrm"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewNgachLuongHrmFilter : SqlFilter<ViewNgachLuongHrmColumn>
	{
	}

	#endregion ViewNgachLuongHrmFilter

	#region ViewNgachLuongHrmExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewNgachLuongHrm"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewNgachLuongHrmExpressionBuilder : SqlExpressionBuilder<ViewNgachLuongHrmColumn>
	{
	}
	
	#endregion ViewNgachLuongHrmExpressionBuilder		
}

